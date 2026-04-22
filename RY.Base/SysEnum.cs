using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RY.Base
{
    public enum eMachineState
    {
        Stop=0,
        Pause,
        Running
    }

    public enum eUserLevel
    {
        Operator=0,
        Engineer,
        Administrator
    }

    public enum eDbgFatherNode
    {
        系统标定=0,
        工程相关,
        通用设置
    }

    public enum eCode
    {
        //执行OK
        OK=0,
        //执行失败
        NG,
        //命令设备暂停
        MPause,
        //命令设备停止
        MStop,
        //命令流程从头开始
        Pause,
        //命令流程从头开始
        Restart,
        //重新执行该方法
        Again,
        //命令线程停止
        Stop
    }

    public enum eLogic
    {
        And=0,
        Or
    }

    public enum eProcessRunMode
    {
        循环=0,
        一次,
        等待唤醒
    }
}
