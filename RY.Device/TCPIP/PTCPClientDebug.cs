using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RY.Base;
using SunnyUI;
namespace RY.Device
{
    public partial class PTCPClientDebug : UIPage, IUIControl
    {
        public PTCPClientDebug()
        {
            InitializeComponent();
        }
        TCPClientBase _client=null;
        public void SetUp(TCPClientBase client)
        {
            _client = client;
            _client.ReceiveMessageEvent += DataRecv;

        }

        void AddMsg(string msg)
        {
            if (InvokeRequired && !IsDisposed)
            {
                Invoke(new Action(() => { AddMsg(msg); }));
            }
            else
            {
                if (lstMsg.Items.Count == 0)
                {
                    lstMsg.Items.Add(msg);
                }
                else
                {
                    lstMsg.Items.Insert(0, msg);
                }
            }
            
        }
        private void DataRecv(object sender,RYDataReciveEventArgs e)
        {
            AddMsg("收到：" + e.Data);
            //清除掉现有buffer
            _client.ClearMsgBuffer();   
        }

        

       

        private void btSend_Click(object sender, EventArgs e)
        {
            if(_client==null)
            {
                MsgBox.ShowWarningTip("赋值错误！");
                return;
            }
            if(!_client.IsOpen)
            {
                MsgBox.ShowWarningTip("设备未打开");
                return;
            }
            string msg = tbMsg.Text.Trim();
            _client.SendMessage(msg);
            AddMsg("发送：" + msg);
        }

        public void UIClose()
        {
            if (_client != null)
            {
                _client.ReceiveMessageEvent -= DataRecv;
            }
        }
    }
}
