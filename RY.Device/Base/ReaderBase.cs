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
    public abstract class ReaderBase:DeviceBase
    {
        public abstract bool ReadOne(string cmd,int timeout=3000);

        public abstract bool ReadOne(int timeout = 3000);
        public abstract bool StopRead();


        public override UIPage GetDebugPage()
        {
            PReadDebugBase f = new PReadDebugBase();
            f.SetUp(this);
            return f;
        }

        [DescriptionAttribute("开始读命令")]
        [DisplayNameAttribute("开始读命令")]
        [CategoryAttribute("命令配置")]
        public string StartCmd
        {
            get; set;
        } = "start";


        [DescriptionAttribute("命令自动回车")]
        [DisplayNameAttribute("命令自动回车")]
        [CategoryAttribute("命令配置")]
        public bool IsEndCmdPatternWithEnter
        {
            get; set;
        } = true;



        [DescriptionAttribute("停止读命令")]
        [DisplayNameAttribute("停止读命令")]
        [CategoryAttribute("命令配置")]
        public string StopCmd
        {
            get; set;
        } = "stop";

        [JsonIgnore]
        [Browsable(false)]
        public string DataString
        { get; protected set; } = "";
        public bool HasData()
        {
            return !string.IsNullOrEmpty(DataString);
        }
    }
}
