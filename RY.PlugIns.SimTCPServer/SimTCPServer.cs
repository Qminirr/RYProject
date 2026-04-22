using RY.Base;
using RY.Device;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RY.PlugIns.SimTCPServer
{


    [Category("TCP")]
    [DisplayName("模拟TCP服务端")]
    public class SimTCPServer:TCPServerBase
    {
        #region 插件必须实现的方法

        public static DeviceBase CreateDevice(string jsonstr)
        {
            SimTCPServer ctrl = JsonHelper.ParseJson<SimTCPServer>(jsonstr);
            return ctrl;
        }




        [DescriptionAttribute("插件名称")]
        [DisplayNameAttribute("名称")]
        [CategoryAttribute("插件")]
        public override string ModuleName
        {
            get
            {
                return SimTCPServer.PlugInName;
            }
        }

        public static string PlugInName
        {
            get
            {
                return "模拟TCP服务端";
            }
        }


        #endregion
    }
}
