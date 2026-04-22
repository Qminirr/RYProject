using Newtonsoft.Json;
using RY.Base;
using SunnyUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RY.Device
{
    public abstract class IOBase:DeviceBase
    {

        [Category("基本属性"), DisplayName("输出IO集合"), Description("输出IO集合")]
        [Editor(typeof(GenericCollectionEditor<IOPin>), typeof(UITypeEditor))]
        public List<IOPin> IOOutPins
        {
            get;set;
        }= new List<IOPin>();



        [Category("基本属性"), DisplayName("输入IO集合"), Description("输入IO集合")]
        [Editor(typeof(GenericCollectionEditor<IOPin>), typeof(UITypeEditor))]
        public List<IOPin> IOInPins
        {
            get; set;
        }=new List<IOPin>();

        //设置IOBaseName
        public void SetUp()
        {
            foreach(IOPin pin in IOOutPins)
            {
                pin.IOBaseName = Name;
            }
            foreach(IOPin pin in IOInPins)
            {
                pin.IOBaseName = Name;
            }
        }
        /// <summary>
        /// 是否存在输入
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public bool ExistInPin(string name)
        {
            return IOInPins.Find(x=>x.Name == name)!=null;
        }

        public bool ExistOutPin(string name)
        {
            return IOOutPins.Find(x => x.Name == name) != null;
        }

        public IOPin GetInPin(string name)
        {
            return IOInPins.Find(x=>x.Name==name);
        }

        public IOPin GetOutPin(string name)
        {
            return IOOutPins.Find(x => x.Name == name);
        }

        public bool SetPinOut(string name,eSwitch onoff)
        {
            IOPin pin=IOOutPins.Find(x=>x.Name == name);
            if (pin==null)
            {
                UserLog.AddErrorMsg("未找到输出IO" + name);
                return false;
            }
            if (!IsOpen) return false;
            //On Low  Off High
            eIOLevel lvl = eIOLevel.Low;
            if(pin.Opposite)
            {
                if (onoff == eSwitch.On) lvl = eIOLevel.High;
            }
            else
            {
                if (onoff == eSwitch.Off) lvl = eIOLevel.High;

            }
            return WritePinOut(pin, lvl);
        }

        public eSwitch GetPinOut(string name)
        {
            IOPin pin = IOOutPins.Find(x => x.Name == name);
            if (pin == null)
            {
                UserLog.AddErrorMsg("未找到输出IO" + name);
                return eSwitch.Unknown;
            }
            if (!IsOpen) return eSwitch.Unknown;
            eIOLevel level = eIOLevel.Low;
            if(!ReadPinOut(pin,ref  level)) return eSwitch.Unknown;
            // //On Low  Off High
            if (!pin.Opposite)
            {
                return level == eIOLevel.Low ? eSwitch.On : eSwitch.Off;
            }
            else
            {
                return level == eIOLevel.Low ? eSwitch.Off : eSwitch.On;
            }
        }

        public eSwitch GetPinIn(string name)
        {
            IOPin pin = IOInPins.Find(x => x.Name == name);
            if (pin == null)
            {
                UserLog.AddErrorMsg("未找到输入IO" + name);
                return eSwitch.Unknown;
            }
            if (!IsOpen) return eSwitch.Unknown;
            eIOLevel level = eIOLevel.Low;
            if (!ReadPinIn(pin, ref level)) return eSwitch.Unknown;
            // //On Low  Off High
            if (!pin.Opposite)
            {
                return level == eIOLevel.Low ? eSwitch.On : eSwitch.Off;
            }
            else
            {
                return level == eIOLevel.Low ? eSwitch.Off : eSwitch.On;
            }
        }


        public bool SetPinIn(string name, eSwitch onoff)
        {
            IOPin pin = IOInPins.Find(x => x.Name == name);
            if (pin == null)
            {
                UserLog.AddErrorMsg("未找到输入IO" + name);
                return false;
            }
            if (!IsOpen) return false;
            //On Low  Off High
            eIOLevel lvl = eIOLevel.Low;
            if (pin.Opposite)
            {
                if (onoff == eSwitch.On) lvl = eIOLevel.High;
            }
            else
            {
                if (onoff == eSwitch.Off) lvl = eIOLevel.High;

            }
            return WritePinIn(pin, lvl);
        }

        protected abstract bool ReadPinIn(IOPin pin, ref eIOLevel level);

        protected abstract bool ReadPinOut(IOPin pin, ref eIOLevel level);

        protected abstract bool WritePinOut(IOPin pin, eIOLevel level);


        protected abstract bool WritePinIn(IOPin pin, eIOLevel level);

        public override UIPage GetDebugPage()
        {
            return new PIODebug();
        }


    }
    //Card NodeNo Pin

    [DisplayName("IO定义")]
    [Serializable]

    public class IOPin
    {
        [Category("基本属性"),DisplayName("IO名称"),Description("IO名称")]
        public string Name
        { get; set; } = "";

        [Category("设置"), DisplayName("1板号"), Description("板号")]
        public int CardNo
        { get; set; } = 0;


        [Category("设置"), DisplayName("2节点"), Description("节点")]
        public int NodeNo
        { get; set; } = 0;

        [Category("设置"), DisplayName("3标号"), Description("标号")]
        public int Pin
        { get; set; } = 0;

        [Category("基本属性"), DisplayName("取反"), Description("取反")]
        public bool Opposite
        { get; set; } = false;


        [Category("基本属性"), DisplayName("排序"), Description("排序")]
        public int SortNum
        { get; set; } = 0;


        [Category("基本属性"), DisplayName("IO类型"), Description("IO类型")]
        public eIOType IOType
        { get; set; } = eIOType.通用;

        [JsonIgnore]
        [Browsable(false)]
        public string IOBaseName
        { get; set; } = "";

        public override string ToString()
        {
            return IOBaseName+"|"+Name + "|" + Pin.ToString();
        }

    }

    public enum eIOType:short
    {
        通用=0,
        气缸,
        真空,
        按钮,
        灯光,
        感应器
    }


    public enum eIOLevel:short
    {
        Low=0,
        High=1
    }

    public enum eSwitch:short
    {
        Off=0,
        On,
        Unknown
    }

}
