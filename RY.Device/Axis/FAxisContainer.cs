using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SunnyUI;
using RY.Base;
namespace RY.Device
{
    public partial class FAxisContainer : UIForm
    {

        PulseSource ps = new PulseSource(200, "轴控制器脉冲");

        bool bInited = false;
        public FAxisContainer()
        {
            InitializeComponent();
            SetUp();
        }

 
        /// <summary>
        /// 脉冲到来时
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnPulseOne(object sender, EventArgs e)
        {
            if(InvokeRequired&&!IsDisposed)
            {
                Invoke(new Action(() =>
                {
                    OnPulseOne(sender, e);
                }));
            }
            else
            {
                TabPage tp = tcAllAxis.SelectedTab;
                if (tp == null) return;
                foreach (Control c in tp.Controls)
                {
                    AxisCtrl ac = c as AxisCtrl;
                    if (ac == null) continue;
                    ac.PulseComing(sender, e);
                }
            }
                
        }


        public void SetUp()
        {
            if (bInited) return;
            ps.PulseOut += OnPulseOne;
            tcAllAxis.TabPages.Clear();
            List<AxisBase> lst = DeviceFactory.GetAxisList();
            lst.Sort((x, y) => { return x.GroupName.CompareTo(y.GroupName); });
            List<string> lstGroupName = new List<string>();
            foreach(AxisBase a in lst)
            {
                if (lstGroupName.Contains(a.GroupName)) continue;
                lstGroupName.Add(a.GroupName);
                
            }

            foreach(string gname in lstGroupName)
            {
                TabPage tc = new TabPage(gname);
                tcAllAxis.TabPages.Add(tc);
                tc.AutoScroll = true;
                tc.BringToFront();
                List<AxisBase> lstCur = lst.FindAll(x => x.GroupName == gname);
                lstCur.Sort((x, y) =>
                {
                    int idx=x.Order.CompareTo(y.Order);
                    return idx * -1;
                });
                foreach (AxisBase ab in lstCur)
                {
                    AxisCtrl ua = new AxisCtrl();
                    ua.SetUp(ab);
                    ua.Parent = tc;
                    ua.AutoSize = false;
                    ua.Margin = new Padding(3);
                    ua.Dock = DockStyle.Top;
                    tc.Controls.Add(ua);

                }
            }

            bInited = true;

        }

        private void FAxisContainer_FormClosing(object sender, FormClosingEventArgs e)
        {
            ps.PausePulse();
            e.Cancel = true;
            Hide();
        }

        private void FAxisContainer_Activated(object sender, EventArgs e)
        {
            ps.StartPulse();
        }
    }
}
