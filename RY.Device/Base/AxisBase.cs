using Newtonsoft.Json;
using RY.Base;
using RY.Ctrls;
using SunnyUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace RY.Device
{
    public abstract class AxisBase : DeviceBase
    {

        #region 具体轴需要实现的方法


        /// <summary>
        /// 设置轴运动速度
        /// </summary>
        /// <param name="speed"></param>
        /// <returns></returns>
        protected abstract bool SetSpeed(double speed);



        /// <summary>
        /// 轴回原操作
        /// </summary>
        /// <returns></returns>
        public abstract bool Home();

        /// <summary>
        /// 移动指令
        /// </summary>
        /// <param name="pos"></param>
        /// <param name="timeout">等待停止时间，单位ms</param>
        /// <returns></returns>
        public abstract bool MoveTo(double pos,int timeout=0);

        /// <summary>
        /// 轴停止
        /// </summary>
        /// <param name="stopmode"></param>
        /// <returns></returns>
        public abstract bool Stop(eAxisStopMode stopmode=eAxisStopMode.减速停止);

        /// <summary>
        /// 获取编码器位置
        /// </summary>
        /// <returns></returns>
        public abstract double GetEncoderPos();

        /// <summary>
        /// 获取命令位置
        /// </summary>
        /// <returns></returns>
        public abstract double GetCommandPos();

        /// <summary>
        /// 手动轴位置清零
        /// </summary>
        /// <returns></returns>
        public abstract bool ZeroPos();

        /// <summary>
        /// 轴是否运动
        /// </summary>
        /// <returns></returns>
        public abstract bool IsMoving();

        /// <summary>
        /// 获取轴IO状态
        /// </summary>
        /// <returns></returns>
        public abstract Dictionary<eAxisStatus, bool> GetAxisIO();

        /// <summary>
        /// 轴励磁或者下电
        /// </summary>
        /// <param name="bOn"></param>
        /// <returns></returns>
        public abstract bool Servo(bool bOn);

        /// <summary>
        /// 轴是否上电
        /// </summary>
        /// <returns></returns>
        public abstract bool IsServoOn();

        /// <summary>
        /// Jog移动
        /// </summary>
        /// <param name="bForward"></param>
        /// <returns></returns>
        public abstract bool JogMove(bool bForward = true);

        /// <summary>
        /// 清除轴报警
        /// </summary>
        /// <returns></returns>
        public abstract bool ClearAlarm();

        /// <summary>
        /// 是否轴报警
        /// </summary>
        /// <returns></returns>
        public abstract bool IsAlarm();


        #endregion

        #region 通用方法

        /// <summary>
        /// 检查轴是否正常
        /// </summary>
        /// <returns></returns>
        public bool IsAxisOK()
        {
            if (!Enable || !_isOpen || !IsHome || !IsServoOn() || IsAlarm())
            {
                UserLog.AddErrorMsg("轴" + Name + "目前状态不可用");
                return false;
            }
            return true;
        }
        
        /// <summary>
        /// 获取当前位置
        /// </summary>
        /// <returns></returns>
        public double GetPos()
        {
            if(PosMode==eAxisPosMode.编码器位置)
            {
                return GetEncoderPos();
            }
            return GetCommandPos();
        }


        /// <summary>
        /// 判定轴当前位置是否在设定范围内
        /// </summary>
        /// <param name="pos"></param>
        /// <param name="drange"></param>
        /// <returns></returns>
        public bool IsInPos(double pos,double drange)
        {
            double cur = GetPos();
            return Math.Abs(pos-cur)<=Math.Abs(drange);
        }


        /// <summary>
        /// 等待轴移动到位置范围内
        /// </summary>
        /// <param name="pos"></param>
        /// <param name="drange"></param>
        /// <param name="timeout"></param>
        /// <returns></returns>
        public bool WaitInPos(double pos,double drange,int timeout=200)
        {
            if(timeout<=0) return IsInPos(pos,drange);
            bool b=WaitTimer.Wait(timeout, () =>
            {
                if (IsInPos(pos, drange)) return true;
                return false;
            });
            if (b) return true;
            UserLog.AddErrorMsg("等待轴" + Name + "到位超时");
            return false;
        }



        /// <summary>
        /// 等待轴运动停止
        /// </summary>
        /// <param name="timeout"></param>
        /// <returns></returns>
        public bool WaitStop(int timeout=100)
        {
            if (timeout <= 0) return !IsMoving();
            bool b=WaitTimer.Wait(timeout, () =>
            {
                if (IsMoving()) return false;
                return true;
            });
            if(b) return true;
            UserLog.AddErrorMsg("等待轴" + Name + "停止超时");
            return false;
        }

        /// <summary>
        /// 等待轴开始运动
        /// </summary>
        /// <param name="timeout"></param>
        /// <returns></returns>
        public bool WaitMoving(int timeout=100)
        {
            if (timeout <= 0) return IsMoving();
            return WaitTimer.Wait(timeout, () =>
            {
                if (IsMoving()) return true;
                return false;
            });
        }



        /// <summary>
        /// 变更速度
        /// </summary>
        /// <param name="mode"></param>
        /// <returns></returns>
        public bool ChangeSpeed(eAxisSpeedMode mode)
        {
            double sd = mode == eAxisSpeedMode.运行速度 ? RunSpeed :JogDebugSpeed;
            if(SetSpeed(sd))
            {
                _speed = sd;
                return true;
            }
            return false;
        }

        /// <summary>
        /// 设置用户速度
        /// </summary>
        /// <param name="speed"></param>
        /// <returns></returns>
        public bool SetUserSpeed(double speed)
        {
            if(speed <= 0) return false;
            if (SetSpeed(speed))
            {
                _speed = speed;
                return true;
            }
            return false;
        }
       

        protected double _speed = 0.0;

        /// <summary>
        /// 获取当前速度
        /// </summary>
        /// <returns></returns>
        public double GetSpeed()
        {
            return _speed;
        }

        /// <summary>
        /// 获取调试接口UI
        /// </summary>
        /// <returns></returns>
        public override UIPage GetDebugPage()
        {
            UAxisCtrl ctrl = new UAxisCtrl();
            ctrl.SetUp(this);
            return ctrl;
        }
        #endregion

        #region 属性
        /// <summary>
        /// 标志是否Home完成
        /// </summary>
        [BrowsableAttribute(false)]
        [JsonIgnore]
        public bool IsHome
        {
            get; protected set;
        } = false;


        /// <summary>
        /// 标志是否Home过程中失败
        /// </summary>
        [BrowsableAttribute(false)]
        [JsonIgnore]
        public bool IsHomeFailed
        {
            get; protected set;
        } = false;


        [DescriptionAttribute("分类组名，显示按照分组显示")]
        [DisplayNameAttribute("分类组名")]
        [CategoryAttribute("设置")]
        public string GroupName
        { get; set; } = "通用";


        [DescriptionAttribute("轴类型,定义XYZ轴等")]
        [DisplayNameAttribute("轴类型")]
        [CategoryAttribute("设置")]
        public eAxis AxisType
        { get; set; } = eAxis.Unkown;



        [DescriptionAttribute("回零超时，单位毫秒")]
        [DisplayNameAttribute("回零超时")]
        [CategoryAttribute("回零")]
        public int HomeTimeOut
        { get; set; } = 60000;


        [DescriptionAttribute("是否确实硬件回零，对于某些旋转轴是不需要实际硬件回零的")]
        [DisplayNameAttribute("硬件回零")]
        [CategoryAttribute("回零")]
        public bool NeedHWHome
        {
            get; set;
        } = true;

        [DescriptionAttribute("回零顺序定义")]
        [DisplayNameAttribute("回零顺序")]
        [CategoryAttribute("回零")]
        public eAxisHomeOrder HomeOrder
        { get; set; } = eAxisHomeOrder.最后回零;


        [DescriptionAttribute("高速回零速度")]
        [DisplayNameAttribute("高速回零速度")]
        [CategoryAttribute("速度")]
        public double HighHomeSpeed
        { get; set; } = 30.0;

        [DescriptionAttribute("低速回零速度")]
        [DisplayNameAttribute("低速回零速度")]
        [CategoryAttribute("速度")]
        public double LowHomeSpeed
        { get; set; } = 5.0;

        [DescriptionAttribute("运行速度")]
        [DisplayNameAttribute("运行速度")]
        [CategoryAttribute("速度")]
        public double RunSpeed
        { get; set; } = 50;

        [DescriptionAttribute("调试及Jog速度")]
        [DisplayNameAttribute("调试及Jog速度")]
        [CategoryAttribute("速度")]
        public double JogDebugSpeed
        { get; set; } = 50;





        [DescriptionAttribute("位置模式")]
        [DisplayNameAttribute("位置模式")]
        [CategoryAttribute("位置")]
        public eAxisPosMode PosMode
        { get; set; } = eAxisPosMode.编码器位置;

        [DescriptionAttribute("编码器位置和命令位置允许误差范围")]
        [DisplayNameAttribute("允许误差范围")]
        [CategoryAttribute("位置")]
        public double ErrorRange
        { get; set; } = 0.02;

        [DescriptionAttribute("是否是能跟踪误差,当为false时候不检查误差")]
        [DisplayNameAttribute("检查跟踪误差")]
        [CategoryAttribute("位置")]
        public bool EnableErrorRange
        { get; set; } = true;


        [DescriptionAttribute("最小位置")]
        [DisplayNameAttribute("最小位置")]
        [CategoryAttribute("位置")]
        public double MinPos
        { get; set; } = 0.0;

        [DescriptionAttribute("最大位置")]
        [DisplayNameAttribute("最大位置")]
        [CategoryAttribute("位置")]
        public double MaxPos
        { get; set; } = 100.0;


        [Editor(typeof(RYModalEditor<UBoolFuncEditor>), typeof(System.Drawing.Design.UITypeEditor))]
        [DescriptionAttribute("安全检测，回零及运动前安全选项检测，如：安全门打开不能运动")]
        [DisplayNameAttribute("安全检测")]
        [CategoryAttribute("功能")]
        public string SafeCheckCmd
        { get; set; } = "";


        #endregion
   
    }

    #region 轴使用的枚举

    public enum eAxisStatus
    {
        报警,
        正限位,
        负限位,
        原点,//原点
        就绪
    }
    public enum eAxisStopMode
    {
        减速停止=0,
        急停
    }

    public enum eAxisSpeedMode
    {
        运行速度=0,
        JogOrDebug
    }

    public enum eAxisPosMode
    {
        编码器位置 = 0,
        命令位置
    }

    public enum eAxis
    {
        X = 0,
        Y,
        Z,
        U,
        V,
        W,
        R,
        Tunnel,
        Unkown = 99
    }
    public enum eAxisHomeOrder
    {
        首先回零 = 0,
        第二批回零,
        第三批回零,
        第四批回零,
        最后回零 = 99
    }

    public enum eAxisZMoveType
    {
        同时移动 = 0,
        先移动Z,
        后移动Z

    }


    #endregion


    #region 单点位
    [Editor(typeof(RYModalEditor<UAxisPosEditor>), typeof(System.Drawing.Design.UITypeEditor))]
    public class AxisPos
    {
        /// <summary>
        /// 轴名称
        /// </summary>
        public string Axis
        { get; set; } = "";

        /// <summary>
        /// 位置
        /// </summary>
        public double Pos
        { get; set; } = 0.0;


        /// <summary>
        /// 获取对应轴
        /// </summary>
        /// <returns></returns>
        public AxisBase GetAxis()
        {
            AxisBase ab = DeviceFactory.GetAxis(Axis);
            if (ab == null)
            {
                UserLog.AddErrorMsg("不存在轴-" + Axis);
                return null;
            }
            return ab;
        }


        /// <summary>
        /// 获得复制对象
        /// </summary>
        /// <returns></returns>
        public AxisPos GetCopy()
        {
            AxisPos copy = new AxisPos();
            copy.Axis = Axis;
            copy.Pos = Pos;
            return copy;
        }

        /// <summary>
        /// 增加一个Offset变量
        /// </summary>
        /// <param name="offset"></param>
        /// <returns></returns>
        public AxisPos Add(double offset)
        {
            AxisPos copy = GetCopy();
            copy.Pos += offset;
            return copy;
        }


        /// <summary>
        /// 更改位置
        /// </summary>
        /// <param name="d"></param>
        /// <returns></returns>
        public AxisPos ChangePos(double d)
        {
            AxisPos ap = GetCopy();
            ap.Pos = d;
            return ap;
        }


        /// <summary>
        /// 轴是否可用
        /// </summary>
        /// <returns></returns>
        public AxisBase IsAxisOK()
        {
            AxisBase ab = DeviceFactory.GetAxis(Axis);
            if(ab==null)
            {
                UserLog.AddErrorMsg("不存在轴-" + Axis);
                return null;
            }
            if(!ab.IsAxisOK())
            {
                return null;
            }
            return ab;
        }

        /// <summary>
        /// 移动
        /// </summary>
        /// <param name="timeout"></param>
        /// <returns></returns>
        public bool Move(int timeout=10000)
        {
            AxisBase ab = IsAxisOK();
            if (ab == null) return false;
            return ab.MoveTo(Pos,timeout);
        }

        /// <summary>
        /// 等待停止
        /// </summary>
        /// <param name="timeout"></param>
        /// <returns></returns>
        public bool WaitStop(int timeout=10000)
        {
            AxisBase ab = IsAxisOK();
            if (ab == null) return false;
            if (ab.WaitStop(timeout)) return true;
            UserLog.AddErrorMsg("等待轴" + Axis + "停止超时");
            return false;
        }

        /// <summary>
        /// 停止轴运动
        /// </summary>
        /// <param name="md"></param>
        /// <returns></returns>
        public bool Stop(eAxisStopMode md=eAxisStopMode.减速停止)
        {
            AxisBase ab = IsAxisOK();
            if (ab == null) return false;
            return ab.Stop(md);
        }

        /// <summary>
        /// 是否移动中
        /// </summary>
        /// <returns></returns>
        public bool IsMoving()
        {
            AxisBase ab = IsAxisOK();
            if (ab == null) return false;
            return ab.IsMoving();
        }

        /// <summary>
        /// 是否到位
        /// </summary>
        /// <param name="drange"></param>
        /// <returns></returns>
        public bool IsInPos(double drange)
        {
            AxisBase ab = IsAxisOK();
            if (ab == null) return false;
            return ab.IsInPos(Pos, drange);
        }

        /// <summary>
        /// 等待轴到位
        /// </summary>
        /// <param name="drange"></param>
        /// <param name="timeout"></param>
        /// <returns></returns>
        public bool WaitInPos(double drange,int timeout=10000)
        {
            AxisBase ab = IsAxisOK();
            if (ab == null) return false;
            return ab.WaitInPos(Pos, drange,timeout);
        }


        /// <summary>
        /// 变速
        /// </summary>
        /// <param name="mode"></param>
        /// <returns></returns>
        public bool ChangeSpeed(eAxisSpeedMode mode)
        {
            AxisBase ab = IsAxisOK();
            if (ab == null) return false;
            return ab.ChangeSpeed(mode);

        }
        /// <summary>
        /// 设置用户速度
        /// </summary>
        /// <param name="speed"></param>
        /// <returns></returns>
        public bool SetUserSpeed(double speed)
        {
            AxisBase ab = IsAxisOK();
            if (ab == null) return false;
            return ab.SetUserSpeed(speed);
        }

        /// <summary>
        /// 刷新当前位置到自己
        /// </summary>
        /// <returns></returns>
        public bool RefreshOwnPos()
        {
            AxisBase ab = IsAxisOK();
            if (ab == null) return false;
            Pos = ab.GetPos();
            return true;
        }

        /// <summary>
        /// 获取当前位置
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public double GetPos()
        {
            AxisBase ab = IsAxisOK();
            if (ab == null)
            {
                throw new Exception("轴" + Axis + "目前不可用");
            }
            return ab.GetPos();
        }

        /// <summary>
        /// 整体操作
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public static AxisPos operator -(AxisPos a, AxisPos b)
        {
            if(a.Axis == b.Axis)
            {
                AxisPos ax = a.GetCopy();
                ax.Pos -= b.Pos;
                return ax;
            }
            throw new Exception("不同轴不能相加减");
        }


        public static AxisPos operator +(AxisPos a, AxisPos b)
        {
            if (a.Axis == b.Axis)
            {
                AxisPos ax = a.GetCopy();
                ax.Pos += b.Pos;
                return ax;
            }
            throw new Exception("不同轴不能相加减");
        }


        public override string ToString()
        {
            if (string.IsNullOrEmpty(Axis)) return "";
            return Axis + "|" + Pos.ToString("f3");
        }
    }

    #endregion


    #region 复合点位


    [Editor(typeof(RYModalEditor<UAxisGroupEditor>), typeof(System.Drawing.Design.UITypeEditor))]
    public class AxisPosGroup
    {

        public static string SafeCheckCmd = "";
        /// <summary>
        /// 一个位置点仅允许同样类型的轴一次
        /// </summary>
        Dictionary<eAxis,AxisPos> _dic= new Dictionary<eAxis, AxisPos>();


        public Dictionary<eAxis, AxisPos> AxisGroup
        {
            get
            {
                return _dic;
            }
            set
            {
                _dic = value;
            }
        }

        public AxisPos this[eAxis index]
        {
            get
            {
                if (_dic.ContainsKey(index)) return _dic[index];
                return null;
            }
            set
            {
                _dic[index] = value;
            }
        }

        /// <summary>
        /// 获取轴类型
        /// </summary>
        /// <returns></returns>
        public List<eAxis> GetAxisTypeList(bool bS2BOrder=true)
        {
            List<eAxis> lst=_dic.Keys.ToList();
            lst.Sort((x, y) =>
            {
                return x.CompareTo(y)*(bS2BOrder?-1:1);
            });
            return lst;
        }

        /// <summary>
        /// 获取当前所有的轴名字
        /// </summary>
        /// <returns></returns>
        public List<string> GetAxisNameList()
        {
            List<string> result = new List<string>();
            List <eAxis> lst = GetAxisTypeList();
            foreach (eAxis k in lst)
            {
                result.Add(_dic[k].Axis);
            }
            return result;
        }


        /// <summary>
        /// 自身增加offset值
        /// </summary>
        /// <param name="axis"></param>
        /// <param name="d"></param>
        /// <returns></returns>
        public bool AddOffsetOwn(eAxis axis,double d)
        {
            if(!_dic.ContainsKey(axis)) return false;
            _dic[axis].Pos += d;
            return true;
        }

        /// <summary>
        /// 复制体增加offset值
        /// </summary>
        /// <param name="axis"></param>
        /// <param name="d"></param>
        /// <returns></returns>
        public AxisPosGroup AddOffset(eAxis axis,double d)
        {
            AxisPosGroup agp = GetCopy();
            if(_dic.ContainsKey(axis))
            {
                agp.AddOffsetOwn(axis,d);
            }
            return agp;
        }


        /// <summary>
        /// 获取复制对象
        /// </summary>
        /// <returns></returns>
        public AxisPosGroup GetCopy()
        {
            AxisPosGroup apg = new AxisPosGroup();
            foreach(eAxis k in _dic.Keys)
            {
                apg[k]= _dic[k];
            }
            apg.MoveType = MoveType;
            return apg;
        }

        /// <summary>
        /// 复制对象移除位置点
        /// </summary>
        /// <param name="axis"></param>
        /// <returns></returns>
        public AxisPosGroup Remove(params eAxis[] axes)
        {
            AxisPosGroup apg = GetCopy();
            apg.RemoveOwn(axes);
            return apg;
        }

        /// <summary>
        /// 复制对象，删除对应名字
        /// </summary>
        /// <param name="axesname"></param>
        /// <returns></returns>
        public AxisPosGroup Remove(params string[] axesname)
        {
            AxisPosGroup apg = GetCopy();
            apg.RemoveOwn(axesname);
            return apg;
        }

        /// <summary>
        /// 从本身移除
        /// </summary>
        /// <param name="axis"></param>
        public void RemoveOwn(params eAxis[] axes)
        {
            foreach(eAxis axis in axes)
            {
                if (_dic.ContainsKey(axis)) _dic.Remove(axis);
            }
            
        }

        /// <summary>
        /// 根据轴名删除
        /// </summary>
        /// <param name="axesname"></param>
        public void RemoveOwn(params string[] axesname)
        {
            
            foreach(string name in axesname)
            {
                List<eAxis> axes = GetAxisTypeList();
                foreach (eAxis axis in axes)
                {
                    if (_dic[axis].Axis == name)
                    {
                        _dic.Remove(axis);
                        break;
                    }
                }
            }
            
        }


        /// <summary>
        /// 获取对应位置
        /// </summary>
        /// <param name="axis"></param>
        /// <returns></returns>
        public AxisPos GetPosOwn(eAxis axis)
        {
            if(_dic.ContainsKey(axis)) return _dic[axis];
            return null;
        }


        public AxisPos GetPos(eAxis axis)
        {
            if (_dic.ContainsKey(axis)) return _dic[axis].GetCopy();
            return null;
        }

        /// <summary>
        /// 安全检测
        /// </summary>
        /// <returns></returns>
        private bool SafeCheck()
        {
            if (string.IsNullOrEmpty(SafeCheckCmd)) return true;
            return RYBoolDelegateFactory.ExecCmd(SafeCheckCmd);
        }

        /// <summary>
        /// 标志几个轴是否同时移动，先移动Z还是后移动Z
        /// </summary>
        public eAxisZMoveType MoveType
        {
            get; set;
        } = eAxisZMoveType.同时移动;

        /// <summary>
        /// 点位是否正常
        /// </summary>
        /// <returns></returns>
        public bool IsGroupValid()
        {
            return _dic.Count > 0;
        }

        /// <summary>
        /// 轴是否正常
        /// </summary>
        /// <returns></returns>
        public bool IsAxisOK()
        {
            if (!IsGroupValid()) return false;
            foreach(eAxis k in _dic.Keys)
            {
                if (_dic[k].IsAxisOK()==null) return false;
            }
            return true;
        }



       /// <summary>
       /// 同时移动
       /// </summary>
       /// <param name="checkvalid">是否检查没有点位的位置点是否算正常</param>
       /// <param name="timeout"></param>
       /// <returns></returns>

        private bool MoveAll(bool checkvalid=true,int timeout=10000)
        {
            if (!checkvalid&&_dic.Count==0)
            {
                return true;
            }
            if (!IsGroupValid()) return false;

            //全部同时下指令移动
            foreach(eAxis k in _dic.Keys)
            {
                if (!_dic[k].Move(0)) return false;
            }
            if (timeout <= 0) return true;
            string AxisName = "";
            bool b = WaitTimer.Wait(timeout, () =>
            {
                foreach (eAxis k in _dic.Keys)
                {
                    if (_dic[k].IsMoving())
                    {
                        AxisName = _dic[k].Axis;
                        return false;
                    }
                }
                return true;
            });
            if (b) return true;
            UserLog.AddErrorMsg("等待轴组停止超时"+AxisName);
            return false;
        }

        /// <summary>
        /// 向上运动
        /// </summary>
        /// <param name="timeout"></param>
        /// <returns></returns>
        public bool MoveUp(int timeout=10000)
        {
            if(_dic.Count==0) return false;
            if (!SafeCheck()) return false;
            //Z轴向上运动，然后再移动其他轴
            //先判断是否有Z轴
            if(_dic.ContainsKey(eAxis.Z))
            {
                if(!GetPos(eAxis.Z).Move(timeout)) return false;
                return GetCopy().Remove(eAxis.Z).MoveAll(false,timeout);
            }
            else
            {
                return MoveAll(true,timeout);
            }
        }

        /// <summary>
        /// 向下运动
        /// </summary>
        /// <param name="timeout"></param>
        /// <returns></returns>
        public bool MoveDown(int timeout=10000)
        {
            if (_dic.Count == 0) return false;
            if (!SafeCheck()) return false;
            //先移动其他轴,最后移动Z轴
            //先判断是否有Z轴
            if (_dic.ContainsKey(eAxis.Z))
            {
                //先保证其他轴移动到位
                if (!GetCopy().Remove(eAxis.Z).MoveAll(false, timeout)) return false;
                //单独移动Z轴
                if (!GetPos(eAxis.Z).Move(timeout)) return false;
                return true;
            }
            else
            {
                return MoveAll(true, timeout);
            }
        }

        /// <summary>
        /// 直接执行点位运动指令
        /// </summary>
        /// <param name="timeout"></param>
        /// <returns></returns>
        public bool Move(int timeout=10000)
        {
            //有Z轴但未指定移动方式，判定不能移动
            if(_dic.ContainsKey(eAxis.Z)&&MoveType==eAxisZMoveType.同时移动)
            {
                UserLog.AddErrorMsg("点位包含Z轴，但未指定Z移动方式");
                return false;
            }
            if(MoveType==eAxisZMoveType.先移动Z) return MoveUp(timeout);
            if (MoveType == eAxisZMoveType.后移动Z) return MoveDown(timeout);
            if (!SafeCheck()) return false;
            return MoveAll(true, timeout);
        }

        /// <summary>
        /// 使用当前位置刷新对象
        /// </summary>
        /// <returns></returns>
        public bool RefreshOwnPos()
        {
            if(_dic.Count == 0) return false;
            foreach(eAxis k in _dic.Keys)
            {
                if (!_dic[k].RefreshOwnPos()) return false;
            }
            return true;
        }

        /// <summary>
        /// 改变位置
        /// </summary>
        /// <param name="eAxis"></param>
        /// <param name="pos"></param>
        /// <returns></returns>
        public bool ChangeOwnPos(eAxis axis,double pos)
        {
            if (!_dic.ContainsKey(axis)) return false;
            _dic[axis].Pos = pos;
            return true;
        }
        /// <summary>
        /// 改变位置
        /// </summary>
        /// <param name="axis"></param>
        /// <param name="pos"></param>
        /// <returns></returns>
        public AxisPosGroup ChangePos(eAxis axis,double pos)
        {
            AxisPosGroup apg = GetCopy();
            if(_dic.ContainsKey(axis))
            {
                apg.ChangeOwnPos(axis,pos);
            }
            else
            {
                UserLog.AddWarnMsg("该位置点位不存在轴" + axis.ToString());
            }
            return apg;
        }

        /// <summary>
        /// 是否包含轴列表
        /// </summary>
        /// <param name="axes"></param>
        /// <returns></returns>
        public bool Contains(params eAxis[] axes)
        {
            foreach(eAxis axis in axes)
            {
                if(_dic.ContainsKey(axis)) return true;
            }
            return false;
        }

        /// <summary>
        /// 包含的变体
        /// </summary>
        /// <param name="axes"></param>
        /// <returns></returns>
        public bool Exist(params eAxis[] axes)
        {
            return Contains(axes);
        }

        /// <summary>
        /// 是否包含轴名
        /// </summary>
        /// <param name="axesnames"></param>
        /// <returns></returns>
        public bool Contains(params string[] axesnames)
        {
            List<string> lst = GetAxisNameList();
            foreach(string name in axesnames)
            {
                if(lst.Contains(name)) return true;
            }
            return false;
            
        }
        /// <summary>
        /// 包含的变体
        /// </summary>
        /// <param name="axesnames"></param>
        /// <returns></returns>
        public bool Exist(params string[] axesnames)
        {
            return Contains(axesnames);
        }


        /// <summary>
        /// 判断轴是否有正在移动的
        /// </summary>
        /// <returns></returns>
        public bool IsMoving()
        {
            foreach(eAxis k in _dic.Keys)
            {
                if (_dic[k].IsMoving()) return true;
            }
            return false;
        }

        /// <summary>
        /// 等待所有点位移动停止
        /// </summary>
        /// <param name="timeout"></param>
        /// <returns></returns>
        public bool WaitStop(int timeout=10000)
        {
            if (_dic.Count == 0) return true;
            string AxisName = "";
            bool b = WaitTimer.Wait(timeout, () =>
            {
                foreach (eAxis k in _dic.Keys)
                {
                    if (_dic[k].IsMoving())
                    {
                        AxisName = _dic[k].Axis;
                        return false;
                    }
                }
                return true;
            });
            if(b) return true;
            UserLog.AddErrorMsg("等待轴移动停止超时" + AxisName);
            return false;
        }

        /// <summary>
        /// 是否移动到位
        /// </summary>
        /// <param name="drange"></param>
        /// <returns></returns>
        public bool IsInPos(double drange)
        {
            if (_dic.Count == 0) return true;
            foreach(eAxis k in _dic.Keys)
            {
                AxisPos apsrc = _dic[k];
                if (!apsrc.IsInPos(drange)) return false;

            }
            return true;
        }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            List<eAxis> lst = GetAxisTypeList(false);
            foreach (eAxis k in lst)
            {
                sb.Append(_dic[k].Axis);
                sb.Append(":");
                sb.Append(_dic[k].Pos.ToString("f3"));
                sb.Append("|");
            }
            if (sb.Length > 0)
            {
                sb.Remove(sb.Length - 1, 1);
            }
            return sb.ToString();
        }

    }

    #endregion
}
