using SunnyUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RY.Device
{
    public partial class PIODebug : UIPage,IPulseConsume
    {
        public PIODebug()
        {
            InitializeComponent();
        }

        bool bInited = false;

        private void PIODebug_Load(object sender, EventArgs e)
        {
            bInited = false;
            SetUp();
            GenCodePage();
        }

        public int TimeTick { get; set; } = 150;

        public void SetUp()
        {
            if (bInited) return;
            foreach (eIOType tio in Enum.GetValues(typeof(eIOType)))
            {
                List<IOPin> lstIn = IOCtrl.GetIOInPins(tio);
                List<IOPin> lstOut = IOCtrl.GetIOOutPins(tio);
                if (lstIn.Count < 1 && lstOut.Count < 1) continue;
                TabPage tab = new TabPage(tio.ToString());
                tab.Name = tio.ToString();
                tabCtrl.TabPages.Add(tab);
                TableLayoutPanel tlp = new TableLayoutPanel();
                tlp.RowCount = 2;
                tlp.ColumnCount = 2;
                tlp.Dock = DockStyle.Fill;
                tab.Controls.Add(tlp);

                tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, tlp.Width * 0.5f));
                tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, tlp.Width * 0.5f));
                tlp.RowStyles.Add(new RowStyle(SizeType.Absolute, 30f));
                tlp.RowStyles.Add(new RowStyle(SizeType.Percent, 1f));
                tlp.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;

                Label lleft = new Label();
                lleft.Text = "输入";
                tlp.Controls.Add(lleft, 0, 0);
                lleft.Dock = DockStyle.Fill;
                lleft.TextAlign = ContentAlignment.MiddleCenter;
                Label lright = new Label();
                lright.Text = "输出";
                tlp.Controls.Add(lright, 1, 0);
                lright.Dock = DockStyle.Fill;
                lright.TextAlign = ContentAlignment.MiddleCenter;

                Panel pleft = new Panel();
                tlp.Controls.Add(pleft, 0, 1);
                pleft.Dock = DockStyle.Fill;
                pleft.AutoScroll = true;
                Panel pright = new Panel();
                tlp.Controls.Add(pright, 1, 1);
                pright.Dock = DockStyle.Fill;
                pright.AutoScroll = true;
                foreach (IOPin s in lstIn)
                {
                    UIOPin led = new UIOPin();
                    led.SetUp(s, true);
                    pleft.Controls.Add(led);
                    led.Dock = DockStyle.Top;
                    led.Parent = pleft;

                }
                foreach (IOPin s in lstOut)
                {
                    UIOPin led = new UIOPin();
                    led.SetUp(s);
                    pright.Controls.Add(led);
                    led.Dock = DockStyle.Top;
                    led.Parent = pright;
                }
            }
            bInited = true;
        }

        protected void GenCodePage()
        {
            TabPage tab = new TabPage("代码");
            tab.Name = "代码";
            tabCtrl.TabPages.Add(tab);
            TextBox tb = new TextBox();
            tb.Multiline = true;
            tab.Controls.Add(tb);
            tb.Dock = DockStyle.Fill;
            tb.ScrollBars = ScrollBars.Both;
            List<IOBase> lst = DeviceFactory.GetDevicesList<IOBase>();
            StringBuilder sbInput = new StringBuilder();
            StringBuilder sbOutput = new StringBuilder();
            sbInput.Append("public enum eIn\r\n{\r\n");
            sbOutput.Append("public enum eOut\r\n{\r\n");
            foreach (IOBase iob in lst)
            {
                foreach (IOPin pin in iob.IOInPins)
                {
                    sbInput.Append("\t");
                    sbInput.Append(pin.Name);
                    sbInput.Append(",\r\n");
                }
                sbInput.Append("\t无=999\r\n");
                foreach (IOPin pin in iob.IOOutPins)
                {
                    sbOutput.Append("\t");
                    sbOutput.Append(pin.Name);
                    sbOutput.Append(",\r\n");
                }
                sbOutput.Append("\t无=999\r\n");
            }

            sbInput.Append("}\r\n\r\n");
            sbOutput.Append("}\r\n");
            tb.Text = sbInput.ToString() + sbOutput.ToString();
        }

        public void PulseComing(object sender, EventArgs e)
        {
            if (!bInited) return;
            if (InvokeRequired && !IsDisposed)
            {
                Invoke(new Action(() =>
                {
                    PulseComing(sender, e);
                }));
            }
            else
            {
                if (!IOCtrl.IsAllIOOpen()) return;
                if (tabCtrl.SelectedTab == null) return;
                TableLayoutPanel table = null;
                foreach (Control c in tabCtrl.SelectedTab.Controls)
                {
                    if (c is TableLayoutPanel)
                    {
                        table = c as TableLayoutPanel;
                        break;
                    }
                }
                if (table == null) return;
                List<Panel> lst = table.GetControls<Panel>();
                foreach (Panel p in lst)
                {
                    foreach (Control c in p.Controls)
                    {
                        UIOPin iop = c as UIOPin;
                        if (iop != null)
                            iop.Pulse();
                    }
                }
            }
        }

        
    }
}
