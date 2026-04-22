using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RY.Base
{
    public class GBase
    {

        public static eMachineState MachineState = eMachineState.Stop;

        public static eUserLevel UserLevel = eUserLevel.Operator;


        public static void GBaseInit(Type projecttype)
        {
            GProcess = new RYModelCtrl();
            GProcess.Dir = "Process";
            GProcess.DotName = ".proc";
            GProcess.SetUp();
            GProject = new RYTypeModelCtrl();
            //启动目录\Project  料号
            GProject.Dir = "Project";
            GProject.DotName = ".project";
            GProject.SetUp(projecttype);

        }
        public static RYModelCtrl GProcess
        { get; set; }

        protected static SysCfgBase __SC
        { get; set; }

        /// <summary>
        /// 获取系统配置
        /// </summary>
        /// <returns></returns>
        public static SysCfgBase GetSysCfgBase()
        {
            return __SC;
        }

    


        public static RYTypeModelCtrl GProject
        { get; set; }


        #region 公共流程

        [RYMethodDelegate("【通用】返回控制", eMethodType.通用, "")]
        public static eCode CommonReturn(eCode code)
        {
            return code;
        }

        [RYMethodDelegate("【通用】等待一段时间", eMethodType.通用, "")]
        public static eCode CommonWait(int timeout)
        {
            WaitTimer.Sleep(timeout);
            return eCode.OK;
        }
        [RYMethodDelegate("【通用】打印信息", eMethodType.通用, "")]
        public static eCode CommonMsg(string msg)
        {
            UserLog.AddRunMsg(msg);
            return eCode.OK;
        }



        [RYMethodDelegate("【通用】流程暂停", eMethodType.通用, "")]
        public static eCode CommonThreadWaitPause(string threadname,int timeout)
        {
            //命令threadname线程去暂停
            //等待线程真的暂停

            RYProcess process = RYProcess.GetProcess(threadname);
            if (process == null) return eCode.NG;
            process.SetPause();
            WaitTimer.Wait(timeout, () =>
            {
                if (process.IsPaused()) return true;
                return false;
            });
            if (!process.IsPaused()) return eCode.NG;
            return eCode.OK;
        }
        [RYMethodDelegate("【通用】流程恢复运行", eMethodType.通用, "")]
        public static eCode CommonThreadPauseRun(string threadname)
        {
            //命令threadname线程去暂停
            //等待线程真的暂停

            RYProcess process = RYProcess.GetProcess(threadname);
            if (process == null) return eCode.NG;
            process.PauseRun();
            return eCode.OK;
        }


        [RYMethodDelegate("【通用】等待整形变量等于", eMethodType.通用, "")]
        public static eCode CommonWaitIntegerEq(string memintname,int val)
        {
            if(RYMem.GetInteger(memintname,-999)==val) return eCode.OK;
            return eCode.Again;
        }

        [RYMethodDelegate("【通用】测试整形变量等于", eMethodType.通用, "")]
        public static eCode CommonTestIntegerEq(string memintname, int val)
        {
            if (RYMem.GetInteger(memintname, -999) == val) return eCode.OK;
            return eCode.NG;
        }
        [RYMethodDelegate("【通用】设置整形变量", eMethodType.通用, "")]
        public static eCode CommonSetInteger(string memintname, int val)
        {
            RYMem.SetObject(memintname, val);
            return eCode.OK;
        }
        [RYMethodDelegate("【逻辑】If", eMethodType.逻辑If, "")]
        public static eCode IfMethodLogic(int testcount,eLogic logic)
        {
            return eCode.OK;
        }

        [RYMethodDelegate("【逻辑】Else", eMethodType.逻辑Else, "")]
        public static eCode ElseMethodLogic()
        {
            return eCode.OK;
        }

        [RYMethodDelegate("【逻辑】EndIf", eMethodType.逻辑EndIf, "")]
        public static eCode EndIfMethodLogic()
        {
            return eCode.OK;
        }

        #endregion
    }
}
