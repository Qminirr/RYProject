using RY.Base;
using RY.Device;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RY.PlugIns.SimTCPClient
{

    [Category("TCP")]
    [DisplayName("模拟TCP客户端")]
    public class SimTCPClient : TCPClientBase
    {
        #region 插件必须实现的方法

        public static DeviceBase CreateDevice(string jsonstr)
        {
            SimTCPClient ctrl = JsonHelper.ParseJson<SimTCPClient>(jsonstr);
            return ctrl;
        }




        [DescriptionAttribute("插件名称")]
        [DisplayNameAttribute("名称")]
        [CategoryAttribute("插件")]
        public override string ModuleName
        {
            get
            {
                return SimTCPClient.PlugInName;
            }
        }

        public static string PlugInName
        {
            get
            {
                return "模拟TCP客户端";
            }
        }


        #endregion
    }
}
