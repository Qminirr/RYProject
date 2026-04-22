using RY.Base;
using RY.Device.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RY.Device
{
    public class TCPServerHelper
    {
        private TcpListener myTcp = null;
        private object lkobj = new object();
        private Thread listenThread = null;
        private Dictionary<string, TcpClient> dicAll = new Dictionary<string, TcpClient>();
        private Dictionary<string, Thread> dicThread = new Dictionary<string, Thread>();
        public event EventHandler<RYDataReciveEventArgs> DataReceiveEvent;
        public event EventHandler<RYClientConnectedEventArgs> ClientConnectedEvent;


        public List<string> GetClientList()
        {
            return dicAll.Keys.ToList();
        }

        public bool IsBind
        { get; set; } = false;
        /// <summary>
        /// 创建TCP服务器
        /// </summary>
        /// <param name="ip">服务器ip地址</param>
        /// <param name="port">端口号</param>
        /// <returns>1成功，-1失败</returns>
        public bool Bind(string ip, int port)
        {

            lock (lkobj)
            {
                if (myTcp != null && IsBind) Close();
                if (string.IsNullOrEmpty(ip))
                {
                    UserLog.AddErrorMsg("Socket绑定到IP地址失败，IP地址不合法！");
                    return false;
                }
                IPAddress ipAddress = IPAddress.Parse(ip);
                myTcp = new TcpListener(new IPEndPoint(ipAddress, port));
                try
                {
                    myTcp.Start();
                    IsBind = true;
                    listenThread = new Thread(ListenThread);
                    listenThread.IsBackground = true;
                    listenThread.Start();

                }
                catch (Exception ex)
                {
                    UserLog.AddErrorMsg("Socket绑定到监听端口失败！" + ex.Message);
                    return false;
                }
            }
            return true;

        }
        private string GetEndPoint(TcpClient client)
        {
            string k=client.Client.RemoteEndPoint.ToString();
            if (dicAll.ContainsKey(k)) return k;
            return "";
        }

        public bool Send2AllClient(byte[] buff)
        {
            if (!IsBind) return false;
            foreach (var s in dicAll.Keys)
            {
                TcpClient client = dicAll[s];
                NetworkStream stream = client.GetStream();
                try
                {
                    stream.Write(buff, 0, buff.Length);
                }
                catch (Exception ex)
                {
                    UserLog.AddErrorMsg("客户端异常断开！" + GetEndPoint(client) + ex.Message);
                    RemoveClient(client);
                    return false;
                }
            }
            return true;
        }

        public bool Send2AllClient(string msg)
        {
            if (!IsBind) return false;
            foreach (var s in dicAll.Keys)
            {
                if(!Send(s, msg))
                {
                    UserLog.AddErrorMsg("向" + s + "发送消息失败");
                }
            }
            return true;
        }
        public bool Send(TcpClient client, byte[] buff)
        {
            NetworkStream stream = client.GetStream();
            try
            {
                stream.Write(buff, 0, buff.Length);
            }
            catch (Exception ex)
            {
                UserLog.AddErrorMsg("客户端异常断开！" + GetEndPoint(client) + ex.Message);
                RemoveClient(client);
                return false;
            }
            return true;
        }


        public bool Send(string clientEndPoint, byte[] buff)
        {
            lock(lkobj)
            {
                if(dicAll.ContainsKey(clientEndPoint))
                {
                    return Send(dicAll[clientEndPoint], buff);
                }
                return false;
            }
        }

        public bool Send(string clientEndPoint, string msg)
        {
            lock (lkobj)
            {
                if (dicAll.ContainsKey(clientEndPoint))
                {
                    return Send(dicAll[clientEndPoint], msg);
                }
                return false;
            }
        }
        public bool Send(TcpClient client, string msg)
        {
            return Send(client, Encoding.UTF8.GetBytes(msg));
        }
        private void RemoveClient(TcpClient client)
        {
            lock (lkobj)
            {
                if(dicAll.ContainsKey(client.Client.RemoteEndPoint.ToString())) dicAll.Remove(client.Client.RemoteEndPoint.ToString());
                if(dicThread.ContainsKey(client.Client.RemoteEndPoint.ToString())) dicThread.Remove(client.Client.RemoteEndPoint.ToString());
            }
            if(ClientConnectedEvent!=null)
            {
                RYClientConnectedEventArgs arg = new RYClientConnectedEventArgs("断开", client);
                ClientConnectedEvent(client, arg);
            }
            client.Client.Shutdown(SocketShutdown.Both);
            client.Dispose();
          
        }

        private void RemoveAllClient()
        {
            lock (lkobj)
            {
                try
                {
                    List<TcpClient> clients = dicAll.Values.ToList();
                    if (ClientConnectedEvent != null)
                    {
                        foreach (TcpClient client in clients)
                        {
                            RYClientConnectedEventArgs arg = new RYClientConnectedEventArgs("断开", client);
                            ClientConnectedEvent(client, arg);
                            client.Client.Shutdown(SocketShutdown.Both);
                            client.Dispose();
                        }

                    }
                    
                }
                catch (Exception ex)
                {
                }
                dicAll.Clear();
                dicThread.Clear();
            }
        }

        private void RemoveClient(string remoteEndPoint)
        {
            lock (lkobj)
            {
                if (dicAll.ContainsKey(remoteEndPoint)) dicAll.Remove(remoteEndPoint);
            }
        }

        private void RecvThread(object obj)
        {
            TcpClient client = obj as TcpClient;
            if (client == null) return;
            while (IsBind)
            {
                try
                {
                    if (client.Client.Poll(500, SelectMode.SelectRead))
                    {
                        if (client.Available > 0)
                        {
                            NetworkStream stream = client.GetStream();
                            byte[] buff = new byte[client.Available];
                            stream.Read(buff, 0, buff.Length);
                            if (DataReceiveEvent != null)
                            {
                                RYDataReciveEventArgs msg = new RYDataReciveEventArgs(buff, client);
                                DataReceiveEvent(client,msg);
                            }
                                
                        }
                        else
                        {
                            UserLog.AddErrorMsg("客户端异常断开！" + GetEndPoint(client));
                            RemoveClient(client);
                            return;
                        }
                    }

                }
                catch (Exception ex)
                {
                    RemoveClient(client);
                    return;
                }
                Thread.Sleep(50);
            }
            RemoveClient(client);
        }
        private void ListenThread()
        {

            while (IsBind)
            {
                try
                {
                    if (myTcp.Pending())
                    {
                        TcpClient client = myTcp.AcceptTcpClient();
                        UserLog.AddRunMsg("接收到客户端连接：" + client.Client.RemoteEndPoint.ToString());
                        
                        lock (lkobj)
                        {
                            dicAll[client.Client.RemoteEndPoint.ToString()] = client;
                            Thread t = new Thread(RecvThread);
                            t.IsBackground = true;
                            t.Start(client);
                            dicThread[client.Client.RemoteEndPoint.ToString()] = t;
                        }
                        if (ClientConnectedEvent != null)
                        {
                            RYClientConnectedEventArgs arg = new RYClientConnectedEventArgs("新的连接" + client.Client.RemoteEndPoint.ToString(), client);
                            ClientConnectedEvent(this, arg);
                        }
                    }
                }
                catch (Exception ex)
                {
                    UserLog.AddErrorMsg("监听客户连接线程异常退出！" + ex.Message);
                    Close();
                }

                Thread.Sleep(50);
            }
            UserLog.AddRunMsg("服务器监听线程关闭！");
        }

        private bool IsThreadStopped()
        {
            if (listenThread == null) return true;
            return !listenThread.IsAlive;
        }
        private bool IsAllClientThreadStopped()
        {
            foreach (var s in dicThread.Keys)
            {
                if (dicThread[s].IsAlive) return false;
            }
            return true;
        }
        public bool Close()
        {
            IsBind = false;
            try
            {
                if (myTcp != null)
                    myTcp.Stop();

                if (listenThread != null && listenThread.IsAlive)
                {
                    WaitTimer.Wait(1000, IsThreadStopped);
                    listenThread = null;
                }
                WaitTimer.Wait(1000, IsAllClientThreadStopped);
                foreach (var s in dicAll.Keys)
                {
                    dicAll[s].Client.Shutdown(SocketShutdown.Both);
                    dicAll[s].Dispose();
                }
                RemoveAllClient();

            }
            catch (Exception ex)
            {
                UserLog.AddErrorMsg(ex.Message);
            }
            return true;
        }


    }
}
