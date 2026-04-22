using Newtonsoft.Json;
using SunnyUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RY.Device
{
    public abstract class DeviceBase:IDevice
    {
        public abstract bool Open();

        public abstract bool Close();


        public abstract UIPage GetDebugPage();



        [DescriptionAttribute("设备名")]
        [DisplayNameAttribute("设备名")]
        [CategoryAttribute("配置")]
        [ReadOnly(true)]
        public string Name
        { get; set; } = "";


        [DescriptionAttribute("排序序号，越小越靠前")]
        [DisplayNameAttribute("排序")]
        [CategoryAttribute("配置")]
        public int Order
        { get; set; } = 0;

        public abstract string ModuleName
        {
            get;
        }
        [DescriptionAttribute("是否使能设备")]
        [DisplayNameAttribute("使能")]
        [CategoryAttribute("配置")]
        public bool Enable
        { get; set; } = true;

        protected bool _isOpen = false;
        [JsonIgnore]
        [Browsable(false)]
        public virtual bool IsOpen
        {
            get
            {
                return _isOpen;
            }
        }
      
        protected void _SetOpen(bool bOpen)
        {
            _isOpen = bOpen;
        }

        [JsonIgnore]
        [Browsable(false)]
        public bool IsValid
        {
            get
            {
                return _isOpen && Enable;
            }
        }
    }

   
}
