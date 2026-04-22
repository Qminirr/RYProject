using SunnyUI.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RY.Base
{
    //运行目录/Project/test.project
    public delegate bool LoadProject(string prjName);
    /// <summary>
    /// 
    /// </summary>
    public abstract class ProjectBase:ConfigBase
    {
        public static LoadProject LoadProjectHandle=null;
        
        [Description("该工程执行的流程名称")]
        [DisplayName("流程列表")]
        [Category("流程")]
        [Editor(typeof(GenericCollectionEditor<ProcessParameter>), typeof(UITypeEditor))]
        public List<ProcessParameter> Proc
        { get; set; }= new List<ProcessParameter>();
    }



    [DisplayName("流程参数-")]
    public class ProcessParameter
    {
        [TypeConverter(typeof(ProcessNameConverter))]
        [DisplayName("流程名称"), Category("流程"), Description("流程名称")]
        public string ProcessName
        { get; set; } = "";

        [DisplayName("线程名称"), Category("线程"), Description("线程名称")]
        public string ThreadName
        { get; set; } = "";

        [DisplayName("开始时暂停"), Category("控制"), Description("线程启动时候是否立即暂停，等待信号")]
        public bool PauseWhenStart
        { get; set; } = true;

        [DisplayName("运行模式"), Category("控制"), Description("单次或者循环运行")]
        public eProcessRunMode RunMode
        { get; set; } = eProcessRunMode.循环;


        public override string ToString()
        {
            return ThreadName+"|"+ProcessName;
        }

    }
}
