using RY.Base;
using RY.Device.Helper;
using SunnyUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RY.Device
{
    public abstract class TCPServerBase:DeviceBase
    {
        protected TCPServerHelper myServer = null;
        public event EventHandler<RYDataReciveEventArgs> ReceiveMessageEvent;
        public event EventHandler<RYClientConnectedEventArgs> ClientConnectedEvent;
        //2 client endpoint

        //client1 st
        //client2 art

        protected Dictionary<string, StringBuilder> myMsg = new Dictionary<string, StringBuilder>();


        [DescriptionAttribute("绑定IP地址")]
        [DisplayNameAttribute("绑定IP地址")]
        [CategoryAttribute("配置")]
        public string IPAddr
        { get; set; } = "127.0.0.1";


        [DescriptionAttribute("绑定端口")]
        [DisplayNameAttribute("绑定端口")]
        [CategoryAttribute("配置")]
        public int Port { get; set; } = 5000;

        [DescriptionAttribute("消息结尾")]
        [DisplayNameAttribute("消息结尾")]
        [CategoryAttribute("配置")]
        public string EndMsgFlag
        { get; set; } = "";

        public bool Send2AllClient(byte[] buff)
        {
            if(myServer==null)
            {
                UserLog.AddErrorMsg("服务器未连接");
                return false;
            }
            return myServer.Send2AllClient(buff);
        }
        public bool Send2AllClient(string msg)
        {
            if (myServer == null)
            {
                UserLog.AddErrorMsg("服务器未连接");
                return false;
            }
            return myServer.Send2AllClient(msg);
        }
        public List<string> GetClientList()
        {
            if (myServer == null)
            {
                UserLog.AddErrorMsg("服务器未连接");
                return new List<string>();
            }
            return myServer.GetClientList();
        }
        public bool Send(TcpClient client, byte[] buff)
        {
            if (myServer == null)
            {
                UserLog.AddErrorMsg("服务器未连接");
                return false;
            }
            return myServer.Send(client, buff);
        }

        public bool Send(string clientEndPoint, byte[] buff)
        {
            if (myServer == null)
            {
                UserLog.AddErrorMsg("服务器未连接");
                return false;
            }
            return myServer.Send(clientEndPoint, buff);
        }
        public bool Send(string clientEndPoint, string msg)
        {
            if (myServer == null)
            {
                UserLog.AddErrorMsg("服务器未连接");
                return false;
            }
            return myServer.Send(clientEndPoint, msg);
        }
        public bool Send(TcpClient client, string msg)
        {
            if(myServer == null)
            {
                UserLog.AddErrorMsg("服务器未连接");
                return false;
            }
            return myServer.Send(client, msg);
        }


        public override UIPage GetDebugPage()
        {
            PTCPServerDebug f = new PTCPServerDebug();
            f.SetUp(this);
            return f;
        }

        public override bool IsOpen
        {
            get
            {
                if (myServer == null) return false;
                return myServer.IsBind;
            }
        }

        public override bool Open()
        {
            if (IsOpen) return true;
            myServer = new TCPServerHelper();
            if(myServer.Bind(IPAddr,Port))
            {
                myServer.DataReceiveEvent += DataRev;
                myServer.ClientConnectedEvent += ClientConnected;
            }
            return IsOpen;
        }

        //msg[endpoint] 值消息队列

        public string FetchHeadMsg(ref string clientendpoint)
        {
            clientendpoint = "";
            foreach (string s in myMsg.Keys)
            {
                if(HasMsg(s,EndMsgFlag))
                {
                    clientendpoint = s;
                    return FetchMsg(s, EndMsgFlag);
                }
            }
            return "";
        }


        /// <summary>
        /// 取得消息
        /// </summary>
        /// <param name="pattern"></param>
        /// <returns></returns>
        public string FetchMsg(string remoteendpoint,string pattern="|")
        {
            lock (this)
            {
                if (!myMsg.ContainsKey(remoteendpoint)) return "";
                string src = myMsg[remoteendpoint].ToString();
                if(string.IsNullOrEmpty(pattern))
                {
                    myMsg[remoteendpoint].Clear();
                    return src;
                }
                int idx = src.IndexOf(pattern);
                if (idx == -1) return "";
                myMsg[remoteendpoint].Remove(0, idx+1);
                //123^$123456|
                return src.Substring(0, idx);
            }
        }

        public void ClearAllMsgBuffer()
        {
            lock (this)
            {
                foreach(string k in myMsg.Keys)
                {
                    myMsg[k].Clear();
                }
            }
        }

        public void ClearMsgBuffer(string clientendpoint)
        {
            lock (this)
            {
                if(myMsg.ContainsKey(clientendpoint))
                {
                    myMsg[clientendpoint].Clear();
                }
            }
        }
        public bool HasMsg()
        {
            lock (this)
            {
                foreach (string k in myMsg.Keys)
                {
                    if (myMsg[k].Length > 0)
                    {
                        string s = myMsg[k].ToString();
                        if (string.IsNullOrEmpty(s)) continue;
                        if (string.IsNullOrEmpty(EndMsgFlag)) return true;
                        return s.Contains(EndMsgFlag);
                    }
                }
            }
            
            return false;
        }
        public bool HasMsg(string remoteendpoint,string pattern = "|")
        {
            if(myMsg.ContainsKey(remoteendpoint))
            {
                string s = myMsg[remoteendpoint].ToString();
                if (string.IsNullOrEmpty(s)) return false;
                if (string.IsNullOrEmpty(pattern)) return true;
                return s.Contains(pattern);
            }
            return false;
        }

        protected void DataRev(object sender, RYDataReciveEventArgs e)
        {
            //防止占包，所有消息根据key Push
            lock (this)
            {
                TcpClient client=e.DataSource as TcpClient;
                if (client != null)
                {
                    string key = client.Client.RemoteEndPoint.ToString();
                    if(!myMsg.ContainsKey(key))
                    {
                        myMsg[key] = new StringBuilder();
                    }
                    myMsg[key].Append(e.Data);
                }
            }
            //再次发送事件
            if (ReceiveMessageEvent != null)
            {
                ReceiveMessageEvent(sender, e);
            }
        }


        protected void ClientConnected(object sender,RYClientConnectedEventArgs e)
        {
            //直接转发消息
            if(ClientConnectedEvent!=null)
            {
                ClientConnectedEvent(sender, e);
            }
        }
        public override bool Close()
        {
            if (!IsOpen) return true;
            _isOpen = false;
            myMsg.Clear();
            myServer.Close();
            myServer.DataReceiveEvent -= DataRev;
            myServer.ClientConnectedEvent -= ClientConnected;
            return true;
        }
    }
}
