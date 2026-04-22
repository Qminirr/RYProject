using RY.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RY.Ctrls
{
    public partial class ULog : UserControl
    {
        public ULog()
        {
            InitializeComponent();
            UserLog.OnMessage += ShowLog;
        }

        public void ShowLog(LogMessage msg)
        {
            if(InvokeRequired)
            {
                Invoke(new Action(() =>
                {
                    ShowLog(msg);
                }));
            }
            else
            {
                //如果控件析构了，就无须显示log了
                if (this.IsDisposed) return;
                Color color = Color.Black;
                ListView lv = lvInfo;
                switch (msg.Level)
                {
                    case eLogLevel.运行:
                        break;
                    case eLogLevel.警告:
                        color = Color.Blue;
                        lv = lvWarn;
                        break;
                    case eLogLevel.错误:
                    case eLogLevel.异常:
                        color = Color.Red;
                        lv = lvError;
                        break;
                }
                ListViewItem item = new ListViewItem();
                item.Text = msg.LogTime.ToString("HH:mm:ss");
                item.SubItems.Add(msg.Msg);
                item.ForeColor = color;
                lv.Items.Insert(0, item);
                if (lv != lvInfo)
                {
                    item = new ListViewItem();
                    item.Text = msg.LogTime.ToString("HH:mm:ss");
                    item.SubItems.Add(msg.Msg);
                    item.ForeColor = color;
                    lvInfo.Items.Insert(0, item);
                }

                if (lvInfo.Items.Count > 5000)
                    lvInfo.Items.RemoveAt(5000);
                if (lv.Items.Count > 5000)
                    lv.Items.RemoveAt(5000);
            }

          
            
        }
    }
}
