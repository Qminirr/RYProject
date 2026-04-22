using RY.Base;
using RY.Device.Helper;
using SunnyUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace RY.Device
{
    public partial class PTCPServerDebug : UIPage, IUIControl
    {
        public PTCPServerDebug()
        {
            InitializeComponent();
        }

        TCPServerBase _server = null;
        public void SetUp(TCPServerBase server)
        {
            _server = server;
            _server.ReceiveMessageEvent += DataRecv;
            _server.ClientConnectedEvent += ClientConn;
            RefreshClientList();
        }


        void RefreshClientList()
        {
            if (InvokeRequired && !IsDisposed)
            {
                Invoke(new Action(() => { RefreshClientList(); }));
            }
            else
            {
                if (_server == null) return;
                string curclient = "";
                if (lsbAllClient.SelectedIndex != -1)
                {
                    curclient = lsbAllClient.SelectedItem.ToString();
                }
                lsbAllClient.Items.Clear();
                List<string> lstClients = _server.GetClientList();
                foreach (string c in lstClients)
                {
                    lsbAllClient.Items.Add(c);
                }
                int idx = string.IsNullOrEmpty(curclient) ? -1 : lstClients.IndexOf(curclient);
                if (idx != -1)
                {
                    lsbAllClient.SelectedIndex = idx;
                }
            }
            
        }
        /// <summary>
        /// 当有客户端连接时候
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClientConn(object sender,RYClientConnectedEventArgs e)
        {
            RefreshClientList();
            
        }

        /// <summary>
        /// 收到数据时候
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DataRecv(object sender, RYDataReciveEventArgs e)
        {
            TcpClient client = e.DataSource as TcpClient;
            if(client != null )
            {
                AddMsg("收到："+client.Client.RemoteEndPoint.ToString()+"->" + e.Data);
                
                //清除掉现有buffer
                _server.ClearMsgBuffer(client.Client.RemoteEndPoint.ToString());
            }
            
        }



        void AddMsg(string msg)
        {
            if (InvokeRequired && !IsDisposed)
            {
                Invoke(new Action(() => { AddMsg(msg); }));
            }
            else
            {
                if (lsbMsg.Items.Count == 0)
                {
                    lsbMsg.Items.Add(msg);
                }
                else
                {
                    lsbMsg.Items.Insert(0, msg);
                }
            }
           
        }
        private void btSend_Click(object sender, EventArgs e)
        {
            if(lsbAllClient.SelectedIndex==-1)
            {
                MsgBox.ShowWarningTip("请选中要发送信息的客户端");
                return;
            }
            if(!_server.IsOpen)
            {
                MsgBox.ShowWarningTip("设备未打开");
                return;
            }
            string ep = lsbAllClient.SelectedItem.ToString();
            string msg = tbMsg.Text.Trim();
            _server.Send(ep, msg);
            AddMsg("发送"+ep+"->"+msg);
        }

        private void btSendAll_Click(object sender, EventArgs e)
        {
            if (!_server.IsOpen)
            {
                MsgBox.ShowWarningTip("设备未打开");
                return;
            }
            string msg = tbMsg.Text.Trim();
            _server.Send2AllClient(msg);
            AddMsg("全部发送->" + msg);
        }

        public void UIClose()
        {
            if (_server != null)
            {
                _server.ReceiveMessageEvent -= DataRecv;
                _server.ClientConnectedEvent -= ClientConn;
            }
        }
    }
}
