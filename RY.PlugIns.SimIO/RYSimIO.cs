using RY.Base;
using RY.Device;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RY.PlugIns.SimIO
{


    [Category("IO")]
    [DisplayName("模拟IO")]
    public class RYSimIO:IOBase
    {
        #region 插件必须实现的方法

        public static DeviceBase CreateDevice(string jsonstr)
        {
            RYSimIO ctrl = JsonHelper.ParseJson<RYSimIO>(jsonstr);
            return ctrl;
        }



      
        [DescriptionAttribute("插件名称")]
        [DisplayNameAttribute("名称")]
        [CategoryAttribute("插件")]
        public override string ModuleName
        {
            get
            {
                return RYSimIO.PlugInName;
            }
        }

        public static string PlugInName
        {
            get
            {
                return "模拟IO";
            }
        }


        #endregion


        int IOIn = int.MaxValue;
        int IOOut = int.MaxValue;

        protected override bool ReadPinIn(IOPin pin, ref eIOLevel level)
        {
            long l = IOIn & (0x01 << pin.Pin);
            level=l==0?eIOLevel.High:eIOLevel.Low;
            return true;
        }

        protected override bool ReadPinOut(IOPin pin, ref eIOLevel level)
        {
            int l = IOOut & (0x01 << pin.Pin);
            level = l == 0 ? eIOLevel.Low : eIOLevel.High;
            return true;
        }

        protected override bool WritePinOut(IOPin pin, eIOLevel level)
        {
            int l = 0x01 << pin.Pin;
            if(level==eIOLevel.High)
            {
                IOOut |= l;
            }
            else
            {
                IOOut &= ~l;
            }
            return true;
        }

        protected override bool WritePinIn(IOPin pin, eIOLevel level)
        {
            int l = 0x01 << pin.Pin;
            IOIn |= l;
            return true;
        }

        public override bool Open()
        {
            if (_isOpen) return true;
            _isOpen = true;
            return true;
        }

        public override bool Close()
        {
            _isOpen = false;
            return true;
        }
    }
}
