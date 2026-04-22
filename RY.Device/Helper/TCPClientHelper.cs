using RY.Base;
using RY.Device;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RY.Device
{
    public class TCPClientHelper
    {
        public event EventHandler<RYDataReciveEventArgs> ReceiveMessageEvent;

        public event EventHandler DisconnectEvent;

        private byte[] result = new byte[2048];
        private Socket Client = null;
        Thread th1;
        bool isConnected = false;
        string strIP=string.Empty;
        int nPort=5000;


        public bool IsConnected
        {
            get
            {
                return isConnected;
            }
        }
        public bool Connect(string ip,int port)
        {
            try
            {
                if(isConnected)
                {
                    if (strIP == ip && port == nPort) return true;
                    isConnected = false;
                    if (th1 != null && th1.ThreadState != System.Threading.ThreadState.Stopped)
                    {
                        th1.Abort();
                        th1 = null;
                    }
                    Client.Shutdown(SocketShutdown.Both);
                    Client.Close();
                    Client.Dispose();
                    Client = null;
                }
                if (th1 != null && th1.ThreadState != System.Threading.ThreadState.Stopped)
                {
                    th1.Abort();
                    th1 = null;
                }
                Client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                IPAddress ipaddr = IPAddress.Parse(ip);
                Client.Connect(new IPEndPoint(ipaddr, port));
                
                strIP = ip;
                nPort = port;
                isConnected = true;
            }
            catch (Exception ex)
            {
                isConnected = false;
                UserLog.AddErrorMsg(ex.Message);
                return false;
            }
            th1 = new Thread(ReceiveMessage);
            th1.IsBackground = true;
            th1.Start(Client);
            
            return isConnected;
        }


        public bool Close()
        {
            if (isConnected)
            {
                isConnected = false;
                Client.Shutdown(SocketShutdown.Both);
                Client.Close();
                Client.Dispose();
                Client = null;
            }
            return true;
        }
        private void ReceiveMessage(object ServerSocket)
        {
            Socket myServerSocket = (Socket)ServerSocket;
            while (isConnected)
            {
                try
                {
                    //通过clientSocket接收数据 
                    int receiveNumber = myServerSocket.Receive(result);
                    if (receiveNumber == 0)
                    {
                        UserLog.AddErrorMsg(strIP + " :服务器连接中断");
                        myServerSocket.Disconnect(false);
                        isConnected = false;
                        if(DisconnectEvent!=null)
                        {
                            DisconnectEvent(this, new EventArgs());
                        }
                        return;
                    }
                    if (!myServerSocket.Connected)
                    {
                        myServerSocket.Disconnect(false);
                        isConnected = false;
                        if (DisconnectEvent != null)
                        {
                            DisconnectEvent(this, new EventArgs());
                        }
                        return;
                    }

                    RYDataReciveEventArgs msg = new RYDataReciveEventArgs(result.Take(receiveNumber).ToArray(), myServerSocket);
                    if (ReceiveMessageEvent != null)
                    {
                        ReceiveMessageEvent(myServerSocket, msg);
                    }
                }
                catch (Exception ex)
                {
                    UserLog.AddErrorMsg(ex.Message);
                    try
                    {
                        if (isConnected)
                        {
                            myServerSocket.Shutdown(SocketShutdown.Both);
                            myServerSocket.Close();
                        }

                    }
                    catch (Exception)
                    { }
                    isConnected = false;
                    if (DisconnectEvent != null)
                    {
                        DisconnectEvent(this, new EventArgs());
                    }
                    break;
                }
            }
        }

        public bool SendMessage(string str)
        {
            if (isConnected)
            {
                byte[] btsend = Encoding.UTF8.GetBytes(str);
                return Client.Send(btsend)>0;
            }
            else
            {
                UserLog.AddWarnMsg("未连接到服务器");
            }
            return false;
        }

        public void SendMessage(byte[] buff)
        {
            if (isConnected)
            {
                Client.Send(buff);
            }
        }
    }
}
