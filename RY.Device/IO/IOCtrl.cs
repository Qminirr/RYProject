using RY.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RY.Device
{
    public class IOCtrl
    {
        static List<IOBase> mylstIO = new List<IOBase>();
        static IOCtrl()
        {
            List<IOBase> lst = DeviceFactory.GetDevicesList<IOBase>();
            foreach (IOBase o in lst)
            {
                //初始化设置IOBaseName
                o.SetUp();
                mylstIO.Add(o);
            }
        }
        public static bool ExistInPin(string name)
        {
            foreach (IOBase io in mylstIO)
            {
                
                if (io.ExistInPin(name))
                {
                    return true;
                }
            }
            return false;
        }
        public static bool ExistOutPin(string name)
        {
            foreach (IOBase io in mylstIO)
            {
                if(io.ExistOutPin(name)) return true;
                
            }
            return false;
        }
        public static bool IsAllIOOpen()
        {
            
            if (mylstIO.Find(x => !x.IsOpen) != null) return false;
            return true;
        }
        /// <summary>
        /// 获取输入IO状态
        /// </summary>
        /// <param name="pinName"></param>
        /// <returns></returns>
        public static eSwitch GetInPin(string pinName)
        {
            eSwitch sw = eSwitch.Unknown;
            foreach (IOBase io in mylstIO)
            {
                if (io.ExistInPin(pinName))
                {
                    sw = io.GetPinIn(pinName);
                }
            }
            return sw;
        }

        /// <summary>
        /// 获取输出IO状态
        /// </summary>
        /// <param name="pinName"></param>
        /// <returns></returns>
        public static eSwitch GetOutPin(string pinName)
        {
            eSwitch sw = eSwitch.Unknown;
            foreach(IOBase io in mylstIO)
            {
                if(io.ExistOutPin(pinName))
                {
                    sw=io.GetPinOut(pinName);
                }
            }

            return sw;
        }

        /// <summary>
        /// 设置输出IO状态
        /// </summary>
        /// <param name="pinName"></param>
        /// <param name="onoff"></param>
        /// <returns></returns>
        public static bool SetOutPin(string pinName,eSwitch onoff)
        {
            foreach(IOBase io in mylstIO)
            {
                if(io.ExistOutPin(pinName))
                {
                    return io.SetPinOut(pinName, onoff);
                }
            }
            UserLog.AddWarnMsg("未知输出-" + pinName);
            return false;
        }
        public static List<IOPin> GetIOInPins(eIOType tp)
        {
            List<IOPin> lst = new List<IOPin>();

            foreach (IOBase ib in mylstIO)
            {
                lst.AddRange(ib.IOInPins.FindAll(x=>x.IOType==tp));
            }
            lst.Sort((x, y) =>
            {
                return x.SortNum.CompareTo(y.SortNum)*-1;
            });
            lst.Sort((x, y) =>
            {
                return x.Name.CompareTo(y.Name);
            });
            return lst;
        }
        public static List<IOPin> GetIOOutPins(eIOType tp)
        {
            List<IOPin> lst = new List<IOPin>();
            foreach (IOBase ib in mylstIO)
            {
                lst.AddRange(ib.IOOutPins.FindAll(x=>x.IOType==tp));
            }
            lst.Sort((x, y) =>
            {
                return x.SortNum.CompareTo(y.SortNum) * -1;
            });
            lst.Sort((x, y) =>
            {
                return x.Name.CompareTo(y.Name);
            });
            return lst;
        }
    }
}
