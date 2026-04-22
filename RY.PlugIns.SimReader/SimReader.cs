using RY.Base;
using RY.Device;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RY.PlugIns.SimReader
{

    [Category("读码器")]
    [DisplayName("模拟读码器")]
    public class SimReader : ReaderBase
    {
        #region 插件必须实现的方法

        public static DeviceBase CreateDevice(string jsonstr)
        {
            SimReader ctrl = JsonHelper.ParseJson<SimReader>(jsonstr);
            return ctrl;
        }




        [DescriptionAttribute("插件名称")]
        [DisplayNameAttribute("名称")]
        [CategoryAttribute("插件")]
        public override string ModuleName
        {
            get
            {
                return SimReader.PlugInName;
            }
        }

        public static string PlugInName
        {
            get
            {
                return "模拟读码器";
            }
        }


        #endregion

       
        [DescriptionAttribute("串口名")]
        [DisplayNameAttribute("串口名")]
        [CategoryAttribute("串口配置")]
        public string PortName
        {
            get; set;
        } = "COM1";


        [DescriptionAttribute("波特率")]
        [DisplayNameAttribute("波特率")]
        [CategoryAttribute("串口配置")]
        public eBaudRate BaudRate
        { get; set; } = eBaudRate.波特率115200;

        [DescriptionAttribute("奇偶校验")]
        [DisplayNameAttribute("奇偶校验")]
        [CategoryAttribute("串口配置")]
        public Parity Parity
        {
            get; set;
        } = Parity.None;

        [DescriptionAttribute("数据位")]
        [DisplayNameAttribute("数据位")]
        [CategoryAttribute("串口配置")]
        public int DataBits
        { get; set; } = 8;


        [DescriptionAttribute("停止位")]
        [DisplayNameAttribute("停止位")]
        [CategoryAttribute("串口配置")]
        public StopBits StopBits
        { get; set; } = StopBits.One;


        [DescriptionAttribute("读超时")]
        [DisplayNameAttribute("读超时")]
        [CategoryAttribute("串口配置")]
        public int ReadTimeout
        { get; set; } = 500;



        [DescriptionAttribute("写超时")]
        [DisplayNameAttribute("写超时")]
        [CategoryAttribute("串口配置")]
        public int WriteTimeout
        { get; set; } = 500;


        public override bool Close()
        {
            if(sh.IsLink)
            {
                sh.DataReceiveEvent -= DataRecv;
                sh.Close();
            }
            _isOpen = false;
            return true;
        }

      
        SerialHelper sh=new SerialHelper();
        public override bool Open()
        {
            if (_isOpen) return true;
            sh.SetUp(PortName, (int)BaudRate, Parity, DataBits, StopBits, ReadTimeout, WriteTimeout);
            if(sh.IsLink)
            {
                sh.DataReceiveEvent += DataRecv;
            }
            _isOpen = sh.IsLink;
            return _isOpen;
        }
        public override bool ReadOne(int timeout = 3000)
        {
            string cmd = StartCmd + (IsEndCmdPatternWithEnter ? "\n" : "");
            return ReadOne(cmd,timeout);
        }
        public override bool ReadOne(string cmd, int timeout = 3000)
        {
            DataString = "";
            if (!sh.IsLink)
            {
                UserLog.AddWarnMsg(Name + "未打开");
                return false;
            }
            sh.WriteDataToSerial(cmd);
            if (timeout <= 0) return true;
            return WaitTimer.Wait(timeout, () =>
            {
                if (HasData()) return true;
                return false;
            });
        }

        public override bool StopRead()
        {
            if (!sh.IsLink)
            {
                UserLog.AddWarnMsg(Name + "未打开");
                return false;
            }
            try
            {
                string cmd = StopCmd + (IsEndCmdPatternWithEnter ? "\n" : "");
                sh.WriteDataToSerial(cmd);
                return true;
            }
            catch (Exception e)
            {
                UserLog.AddErrorMsg(e.ToString());
                return false;
            }
        }


        public void DataRecv(object sender, RYDataReciveEventArgs e)
        {
            lock (this)
            {
                DataString += e.Data;
                
            }

        }
    }
}
