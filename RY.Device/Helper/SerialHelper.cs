using Newtonsoft.Json;
using RY.Base;
using RY.Device;
using System;
using System.IO.Ports;
using System.Threading;

namespace RY.Base
{

    public class SerialHelper
    {
        private SerialPort com = new SerialPort();
        bool isLink = false;
        //bool isTimeOutAlarm;
        string strReceivedData = "";
        public event EventHandler<RYDataReciveEventArgs> DataReceiveEvent;        
        public event SerialErrorReceivedEventHandler SerialErrorReceivedEvent;

        public bool IsLink
        {
            get
            {
                return isLink;
            }

            set
            {
                isLink = value;
            }
        }
        public void DiscardInBuffer()
        {
            if (com.IsOpen)
            {
                com.DiscardInBuffer();
            }
        }

        public void DiscardOutBuffer()
        {
            if (com.IsOpen)
            {
                com.DiscardOutBuffer();
            }
        }
        public SerialPort Com
        {
            get
            {
                if (com==null)
                {
                    com = new SerialPort();
                }
                return com;
            }

            set
            {
                com = value;
            }
        }
        public string StrReceivedData
        {
            get
            {
                return strReceivedData;
            }

            set
            {
                strReceivedData = value;
            }
        }
        /// <summary>
        /// 串口初始化
        /// </summary>
        public void SetUp(string PortName="COM1",int BaudRate=115200,Parity Parity=Parity.None,int DataBits=8,StopBits StopBits=StopBits.One,int ReadTimeout=500,int WriteTimeout=500)
        {
            try
            {
                if (Com.IsOpen)
                {
                    Close();
                }
                isLink = false;                              
                Com.PortName = PortName;
                Com.BaudRate = BaudRate;
                Com.Parity = Parity;
                Com.DataBits = DataBits;
                Com.StopBits = StopBits;
                Com.ReadTimeout = ReadTimeout;
                Com.WriteTimeout = WriteTimeout;
                Com.Open();
                isLink = true;                

                Com.DataReceived += this.OnDataReceived;
                Com.ErrorReceived += this.OnErrorReceived;                   
            }
            catch (Exception ex)
            {
                IsLink = false;
                UserLog.AddWarnMsg(string.Format("串口{0}打开失败,", Com.PortName) + ex.Message);
            }
        }
        /// <summary>
        /// 写入数据到串口
        /// </summary>
        /// <param name="str">待写入字符串-无校验</param>
        /// <returns></returns>
        public void WriteDataToSerial(string str)
        {
            try
            {
                if (Com.IsOpen == false||!IsLink)
                {
                    UserLog.AddWarnMsg("串口未打开");
                    return;
                }
                if(Com.BytesToWrite >0)
                {
                    bool iswritebufferempty = false;
                    int num = 0;
                    while (!iswritebufferempty && num < 5)
                    {
                        num++;
                        Thread.Sleep(10);
                        if (Com.BytesToWrite == 0)
                            iswritebufferempty = true;
                    }
                    if(!iswritebufferempty)
                    {
                        UserLog.AddWarnMsg("串口写缓冲区已满，发送数据超时");
                        return;
                    }
                }
                Com.Write(str);                
            }
            catch(Exception ex)
            {                
                UserLog.AddErrorMsg("串口写数据异常:" + ex.Message);
            }
        }


        public void WriteDataToSerial(byte[] btdata,int offset,int count)
        {
            try
            {
                if (Com.IsOpen == false||!IsLink)
                {
                    UserLog.AddWarnMsg("串口未打开");
                    return;
                }
                if (Com.BytesToWrite > 0)
                {
                    bool iswritebufferempty = false;
                    int num = 0;
                    while (!iswritebufferempty && num < 5)
                    {
                        num++;
                        Thread.Sleep(10);
                        if (Com.BytesToWrite == 0)
                            iswritebufferempty = true;
                    }
                    if (!iswritebufferempty)
                    {
                        UserLog.AddWarnMsg("串口写缓冲区已满，发送数据超时");
                        return;
                    }
                }
                Com.Write(btdata, offset, count);
            }
            catch (Exception ex)
            {
                UserLog.AddErrorMsg("串口写数据异常:" + ex.Message);
            }
        }
        //private object portLockObj = new object();
        /// <summary>
        /// 串口接收到数据引发的事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnDataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                byte[] bt = new byte[com.BytesToRead];
                Com.Read(bt, 0, bt.Length);
                if (DataReceiveEvent != null && IsLink)
                {
                    DataReceiveEvent(this, new RYDataReciveEventArgs(bt,com.PortName));
                }
            }
            catch (Exception ex)
            {
                UserLog.AddErrorMsg( "串口读数据异常:" + ex.Message);
                return;
            }
        }
        public void Close()
        {
            IsLink = false;
            if (Com != null && Com.IsOpen)
            {
                try
                {
                    Com.DataReceived -= this.OnDataReceived;
                    Com.ErrorReceived -= this.OnErrorReceived;
                    Com.Close();
                    UserLog.AddRunMsg(string.Format("串口{0}已关闭:", Com.PortName));
                }
                catch(Exception ex)
                {
                    UserLog.AddErrorMsg(string.Format("串口{0}关闭异常:" ,Com.PortName)+ ex.Message);
                }
                
            }
                
            Com = null;
            
        }
       
        private void OnErrorReceived(Object sender,SerialErrorReceivedEventArgs e)
        {
            try
            {
                if (SerialErrorReceivedEvent != null)
                {
                    SerialErrorReceivedEvent(sender, e);
                }
            }
            catch(Exception ex)
            {
                UserLog.AddErrorMsg(string.Format("串口{0}异常:", Com.PortName) + ex.Message);
            }
            
        }
    }


    public enum eBaudRate:int
    {
        波特率4800=4800,
        波特率9600=9600,
        波特率14400 = 14400,
        波特率19200 = 19200,
        波特率38400 = 38400,
        波特率56000 = 56000,
        波特率576000 = 576000,
        波特率115200 = 115200
    }
}
