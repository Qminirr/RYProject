using RY.Base;
using RY.Device;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RY.Ctrls;
using System.Threading;
namespace RY.PlugIns.SimAxis
{

    [Category("轴")]
    [DisplayName("模拟轴")]
    public class SimAxisCtrl : AxisBase
    {
        #region 插件必须实现的方法

        public static DeviceBase CreateDevice(string jsonstr)
        {
            SimAxisCtrl ctrl = JsonHelper.ParseJson<SimAxisCtrl>(jsonstr);
            return ctrl;
        }

        [DescriptionAttribute("插件名称")]
        [DisplayNameAttribute("名称")]
        [CategoryAttribute("插件")]
        public override string ModuleName
        {
            get
            {
                return SimAxisCtrl.PlugInName;
            }
        }

        public static string PlugInName
        {
            get
            {
                return "模拟轴";
            }
        }


        #endregion


        public double _curPos = 0.0;

        /// <summary>
        /// 清空报警信息
        /// </summary>
        /// <returns></returns>
        public override bool ClearAlarm()
        {
            return true;
        }

        /// <summary>
        /// 关闭设备
        /// </summary>
        /// <returns></returns>
        public override bool Close()
        {
            _isOpen = false;
            return true;
        }
        /// <summary>
        /// 等到轴的IO状态
        /// </summary>
        /// <returns></returns>
        public override Dictionary<eAxisStatus, bool> GetAxisIO()
        {
            Dictionary<eAxisStatus,bool> dic=new Dictionary<eAxisStatus,bool>();
            dic[eAxisStatus.报警] = false;
            dic[eAxisStatus.正限位] = false;
            dic[eAxisStatus.负限位] = false;
            dic[eAxisStatus.原点] = false;
            dic[eAxisStatus.就绪] = true;
            return dic;
        }

        public override double GetCommandPos()
        {
            return _curPos;
        }

        public override double GetEncoderPos()
        {
            return _curPos;
        }


        /// <summary>
        /// 轴Home
        /// </summary>
        /// <returns></returns>
        public override bool Home()
        {
            UserLog.AddRunMsg("正在复位" + Name + "......");
            IsHome = false;
            IsHomeFailed = false;
            Servo(true);
            _isMoving = true;
            WaitTimer.Sleep(5000);
            _curPos = 0.0;
            //如果Home失败及时复制IsHomeFailed=true,提前结束整个回零进程
            //回零超时，也需要设置整个标志
            _isMoving = false;
            IsHome = true;
            ChangeSpeed(eAxisSpeedMode.运行速度);
            return true;

        }

        public override bool IsAlarm()
        {
            return false;
        }


        bool _isMoving = false;
        public override bool IsMoving()
        {
            return _isMoving;
        }


        bool _isPowerOn = false;
        public override bool IsServoOn()
        {
            return _isPowerOn;
        }

        public override bool JogMove(bool bForward = true)
        {
            _isMoving = true;
            _curPos += (_curPos * (bForward ? 1.0 : -1.0));
            WaitTimer.Sleep(500);
            _isMoving = false;
            return true;
        }

        public override bool MoveTo(double pos, int timeout = 0)
        {
            _isMoving=true;
            _curPos = pos;
            WaitTimer.Sleep(400);
            _isMoving = false;
            return true;
        }

        public override bool Open()
        {
            _isOpen = true;
            return true;
        }

        public override bool Servo(bool bOn)
        {
            _isPowerOn = bOn;
            IsHome = false;
            return true;
        }

        public override bool Stop(eAxisStopMode stopmode = eAxisStopMode.减速停止)
        {
            if(_isMoving)
            {
                Thread.Sleep(300);
            }
            _isMoving = false;
            return true;
        }

        public override bool ZeroPos()
        {
            _curPos = 0.0;
            return true;
        }

        protected override bool SetSpeed(double speed)
        {
            return true;
        }
    }
}
