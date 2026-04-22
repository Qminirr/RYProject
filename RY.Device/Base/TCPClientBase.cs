using RY.Base;
using SunnyUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RY.Device
{
    public abstract class TCPClientBase:DeviceBase
    {

        public event EventHandler<RYDataReciveEventArgs> ReceiveMessageEvent;
        protected TCPClientHelper myClient = null;


        [DescriptionAttribute("服务器地址")]
        [DisplayNameAttribute("服务器地址")]
        [CategoryAttribute("配置")]
        public string IPAddr
        { get; set; } = "127.0.0.1";


        [DescriptionAttribute("服务器端口")]
        [DisplayNameAttribute("服务器端口")]
        [CategoryAttribute("配置")]
        public int Port { get; set; } = 5000;


        [DescriptionAttribute("消息结尾")]
        [DisplayNameAttribute("消息结尾")]
        [CategoryAttribute("配置")]
        public string EndMsgFlag
        { get; set; } = "|";


        public override bool IsOpen
        {
            get
            {
                if (myClient == null) return false;
                return myClient.IsConnected;
            }
        }
        

        public void SendMessage(string str)
        {
            if (myClient == null)
            {
                UserLog.AddErrorMsg("客户端未连接");
                return;
            }
            myClient.SendMessage(str);
        }
        public void SendMessage(byte[] buff)
        {
            if (myClient == null)
            {
                UserLog.AddErrorMsg("客户端未连接");
                return;
            }
            myClient.SendMessage(buff);
        }
        public override UIPage GetDebugPage()
        {
            PTCPClientDebug f = new PTCPClientDebug();
            f.SetUp(this);
            return f;
        }

        public override bool Open()
        {
            if (IsOpen) return true;
            myClient = new TCPClientHelper();
            if(myClient.Connect(IPAddr, Port))
            {
                myClient.ReceiveMessageEvent += DataRev;
                myClient.DisconnectEvent += Disconnect;
            }
            return IsOpen;

        }

        protected void Disconnect(object sender, EventArgs e)
        {
            Close();
        }
        protected void DataRev(object sender,RYDataReciveEventArgs e)
        {
            lock (this)
            {
                MsgSummary.Append(e.Data);
            }
            //再次发送事件
            if (ReceiveMessageEvent != null)
            {
                ReceiveMessageEvent(sender, e);
            }
            
        }


        public string GetMsgBuffer()
        {
            lock(this)
            {
                return MsgSummary.ToString();
            }
        }
        public string FetchMsg()
        {
            return FetchMsg(EndMsgFlag);
        }
        public string FetchMsg(string pattern)
        {
            lock(this)
            {
                string src = MsgSummary.ToString();
                if (string.IsNullOrEmpty(pattern))
                {
                    MsgSummary.Clear();
                    return src;
                }
                int idx=src.IndexOf(pattern);
                if (idx == -1) return "";
                if(idx==0)
                {
                    MsgSummary.Clear();
                    return "";
                }
                MsgSummary.Remove(0, idx + pattern.Length);
                return src.Substring(0, idx);
            }
        }

        public void ClearMsgBuffer()
        {
            lock(this)
            {
                MsgSummary.Clear();
            }
        }
        public bool HasMsg()
        {
            return HasMsg(EndMsgFlag);
        }
        public bool HasMsg(string pattern)
        {
            if (string.IsNullOrEmpty(pattern)) return MsgSummary.Length > 0;
            return MsgSummary.ToString().Contains(pattern);
        }

        protected StringBuilder MsgSummary
        { get; set; }=new StringBuilder(4096);

        public override bool Close()
        {
            if (!IsOpen) return true;
            myClient.ReceiveMessageEvent -= DataRev;
            myClient.DisconnectEvent -= Disconnect;
            myClient.Close();
            return true;
        }
    }
}
