using RY.Base;
using RY.Device;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RYProject
{
    [Serializable]
    public class SystemConfig: SysCfgBase
    {
        [DisplayName("设备名"), Category("设置"), Description("设备名")]
        public string SystemName
        { get; set; } = "";

        [DisplayName("报警使能"), Category("设置"), Description("是否使能报警，True使能，False不使能")]
        public bool EnableAlarm
        { get; set; } = false;


        [DisplayName("等待点位"), Category("点位"), Description("等待点位")]
        public AxisPosGroup WaitPos
        {
            get; set;
        } = new AxisPosGroup();


        [DisplayName("夹爪安全位置"), Category("点位"), Description("夹爪安全位置")]
        public AxisPos HandSafePos
        { get; set; } = new AxisPos();

        [DisplayName("取料位置"), Category("点位"), Description("取料位置")]
        public AxisPosGroup FetchPos
        { get; set; }= new AxisPosGroup();


        [DisplayName("测试位置"), Category("点位"), Description("测试位置")]
        public AxisPosGroup TestPos
        { get; set; } = new AxisPosGroup();


        [DisplayName("出料位置"), Category("点位"), Description("出料位置")]
        public AxisPosGroup OutPos
        { get; set; } = new AxisPosGroup();

        [DisplayName("NG放料位置"), Category("点位"), Description("出料位置")]
        public AxisPosGroup NGPos
        { get; set; } = new AxisPosGroup();


    }
}
