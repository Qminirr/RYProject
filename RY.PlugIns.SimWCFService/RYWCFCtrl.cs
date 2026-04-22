using RY.Base;
using RY.Device;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace RY.PlugIns.SimWCFService
{

    [Category("WCF")]
    [DisplayName("模拟WCF服务")]
    public class RYWCFCtrl : WCFBase
    {
        #region 插件必须实现的方法

        public static DeviceBase CreateDevice(string jsonstr)
        {
            RYWCFCtrl ctrl = JsonHelper.ParseJson<RYWCFCtrl>(jsonstr);
            return ctrl;
        }
        [DescriptionAttribute("插件名称")]
        [DisplayNameAttribute("名称")]
        [CategoryAttribute("插件")]
        public override string ModuleName
        {
            get
            {
                return RYWCFCtrl.PlugInName;
            }
        }

        public static string PlugInName
        {
            get
            {
                return "模拟WCF服务";
            }
        }


        #endregion

        RYWCF.RYSimpleWcfServiceClient server = new RYWCF.RYSimpleWcfServiceClient();
        public override int Add(int a, int b)
        {
           return server.Add(a, b);
        }

        public override bool Close()
        {
            _SetOpen(false);
            return true;
        }

        public override DateTime GetServerTime()
        {
            return server.GetTime();
        }

        public override bool Open()
        {
            _SetOpen(true);
            return true; 
        }
    }
}
