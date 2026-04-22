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
using RY.Device;
using RY.Base;
namespace RYProject
{
    public partial class FMain : UIPage
    {
        public FMain()
        {
            InitializeComponent();
            
        }


        public bool LoadProject(RYProject proj)
        {



            return true;
        }

        //private void btExec_Click(object sender, EventArgs e)
        //{
        //    string[] cmds = tbCmd.Text.Trim().Split('\n');
        //    UserLog.AddRunMsg("命令开始执行");
        //    foreach (string cmd in cmds)
        //    {
        //        if (!RYBoolDelegateFactory.ExecCmd(cmd.Trim()))
        //        {
        //            return;
        //        }

        //    }
        //    UserLog.AddRunMsg("命令执行完成");
        //}

        //public void ShowData(int val)
        //{
        //    if(InvokeRequired&&!IsDisposed)
        //    {
        //        Invoke(new Action(() =>
        //        {
        //            ShowData(val);
        //        }));
        //    }
        //    else
        //    {
        //        lbInfo.Text="采集到的数据："+val.ToString();
        //    }
        //}
    }
}
