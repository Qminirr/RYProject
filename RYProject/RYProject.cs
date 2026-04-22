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

    /// <summary>
    /// new ProjectBase()
    /// </summary>
    public class RYProject:ProjectBase
    {

        [Category("位置"),DisplayName("等待位置"),Description("等待位置")]
        public AxisPosGroup WaitPos
        { get; set; }=new AxisPosGroup();


    }


    public enum eIn
    {
        安全门,
        无 = 999
    }

    public enum eOut
    {
        三色灯红,
        三色灯绿,
        三色灯黄,
        开始按钮,
        取料按钮,
        放料按钮,
        测试OK,
        测试NG,
        夹爪抓料,
        夹爪放料,
        取料位有料,
        无 = 999
    }


}
