using RY.Base;
using SunnyUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RY.Device
{
    public partial class FDevDebugBase : UIForm
    {
        public FDevDebugBase()
        {
            InitializeComponent();
        }

        DeviceBase _dev = null;
        PulseSource _ps = null;

        PulseSource _psself=new PulseSource(200,Guid.NewGuid().ToString());
        public void SetUp(DeviceBase dev)
        {
            _dev = dev;
            this.Text="设备调试-"+dev.ModuleName+"["+dev.Name+"]";
            lbInfo.Text = "当前设备状态：" + (dev.IsOpen ? "已打开" : "已关闭");
            UIPage page=dev.GetDebugPage();
            if(page!=null)
            {
                this.panelCtrl.Controls.Add(page);
                int w = page.Width;
                int h = page.Height;
                this.Width = w + 10;
                this.Height = h + 45 + 30;
                page.Dock= DockStyle.Fill;
                page.Show();
            }
            //如果Page含有脉冲需求
            if(page is IPulseConsume)
            {
                //新建PulseSource,并设置变量
                IPulseConsume pulse = (IPulseConsume)page;
                _ps=new PulseSource(pulse.TimeTick,Guid.NewGuid().ToString());
                _ps.PulseOut = pulse.PulseComing;
                _ps.StartPulse();
            }
            _psself.PulseOut += SelfPulseComing;
            _psself.StartPulse();
        }

        private void SelfPulseComing(object sender,EventArgs e)
        {
            
            if(InvokeRequired&&!IsDisposed)
            {
                Invoke(new EventHandler(SelfPulseComing));
            }
            else
            {
                if (_dev == null) return;
                bool bOpen = _dev.IsOpen;
                if(!bOpen&&lbInfo.Text.Contains("已"))
                {
                    lbInfo.Text = "当前设备状态：" + (_dev.IsOpen ? "已打开" : "已关闭");
                }
            }
        }
        private void FDevDebugBase_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(_ps != null)
            {
                _ps.StopAddRemovePulse();
            }
            _psself.PulseOut -= SelfPulseComing;
            _psself.StopAddRemovePulse();
            foreach(Control c in this.panelCtrl.Controls)
            {
                if (c is IUIControl)
                {
                    IUIControl ui = (IUIControl)c;
                    ui.UIClose();
                    
                }
                c.Dispose();
            }
        }

        private void btOpenDev_Click(object sender, EventArgs e)
        {
            if(_dev==null)
            {
                MsgBox.ShowWarningTip("窗体赋值错误！");
                return;
            }
            if (_dev.IsOpen)
            {
                MsgBox.ShowWarningTip("设备已打开，无需重复打开");
                return;
            }
            if(_dev.Open())
            {
                MsgBox.ShowSuccessTip("设备已打开");
            }
            else
            {
                MsgBox.ShowWarningTip("设备打开失败");
            }
            lbInfo.Text = "当前设备状态：" + (_dev.IsOpen ? "已打开" : "已关闭");
        }

        private void btCloseDev_Click(object sender, EventArgs e)
        {
            if (_dev == null)
            {
                MsgBox.ShowWarningTip("窗体赋值错误！");
                return;
            }
            if (!_dev.IsOpen)
            {
                MsgBox.ShowWarningTip("设备已关闭，无需重复关闭");
                return;
            }
            _dev.Close();
            MsgBox.ShowSuccessTip("设备已关闭");
            lbInfo.Text = "当前设备状态：" + (_dev.IsOpen ? "已打开" : "已关闭");

        }
    }
}
