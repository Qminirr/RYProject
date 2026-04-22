using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RY.Base
{
    public class RYProcess
    {

        #region 固态方法
        static List<RYProcess> _ThreadList = new List<RYProcess>();

        static object _lock = new object();

        //不是test.proc
        public static RYProcess GetProcess(string threadName)
        {
            RYProcess process = _ThreadList.Find(x => x.ThreadName == threadName);
            return process;
        }

        public static bool CreateProcess(ProcessParameter pparam)
        {
            lock (_lock)
            {
                RYProcess process = new RYProcess();
                if (!process.Setup(pparam)) return false;
                _ThreadList.Add(process);
                return true;
            }
            
        }


        public static int GetRunProcessCount()
        {
            int count = 0;
            foreach(var process in _ThreadList)
            {
                if(!process.IsStopped()) count++;
            }
            return count;
        }
        public static bool CreateProcess(ProjectBase pb)
        {
            lock (_lock)
            {
                foreach (ProcessParameter pp in pb.Proc)
                {
                    RYProcess process = new RYProcess();
                    if (!process.Setup(pp)) return false;
                    _ThreadList.Add(process);
                }
                return true;
            }
            
        }
        public static void StartAllProcess()
        {
            lock(_lock)
            {
                foreach (RYProcess item in _ThreadList)
                {
                    item.Run();
                }
            }
            
        }
        public static void StopAllProcess()
        {
            lock (_lock)
            {
                foreach (RYProcess item in _ThreadList)
                {
                    item.SetStop();
                }

                foreach (RYProcess item in _ThreadList)
                {
                    item.Stop();
                }
                _ThreadList.Clear();
            }
           
        }
        #endregion




        RYMethodCollection _model = null;
        public string ThreadName
        { get; private set; } = "";



        public ProcessParameter PParam
        {
            get;private set;
        }
        public bool Setup(ProcessParameter pparam)
        {

            PParam = pparam;
            _model = GBase.GProcess.GetModel<RYMethodCollection>(PParam.ProcessName.ToLower());
            if (_model == null)
            {
                UserLog.AddErrorMsg("初始化流程" + PParam.ProcessName + "失败");
                return false;
            }
            //检查流程是否有问题
            List<int> errIdx;
            List<string> errMsg;
            if(!_model.CheckMethods(out errIdx,out errMsg))
            {
                foreach(string s in errMsg)
                {
                    UserLog.AddErrorMsg(s);
                }
                return false;
            }
            ThreadName = PParam.ThreadName;
            return true;

        }


        public bool IsStopped()
        {
            return bThreadExit;
        }
        Thread myThread = null;
        bool bThreadExit = false;
        bool bExit = false;
        public void Run()
        {
            bThreadExit = false;
            bExit = false;
            myThread = new Thread(RunProcess);
            myThread.IsBackground = true;
            myThread.Priority = ThreadPriority.AboveNormal;
            _IsPaused = PParam.PauseWhenStart;
            myThread.Start();
        }

        public void SetStop()
        {
            bExit = true;
        }
        public void Stop()
        {
            bExit = true;
            if (myThread == null)
            {
                bThreadExit = true;
                return;
            }
            WaitTimer.Wait(3000, () =>
            {
                if (bThreadExit)
                {
                    return true;
                }
                return false;
            });
            if(!bThreadExit)
            {
                myThread.Abort();
            }
            myThread = null;
            bThreadExit = true;
            _IsNeedPause = false;
            _IsPaused = true;
        }


        public void SetPause(bool bPause=true)
        {
            _IsNeedPause = bPause;
        }

        public bool IsPaused()
        {
            return _IsPaused;
        }

        public void PauseRun()
        {
            _IsPaused = false;
        }



        bool _IsNeedPause = false;
        bool _IsPaused = false;

        int _curstep = 0;
        public int CurStep
        {
            get { return _curstep; }
            set
            {
                _curstep = value;
                if (value<_model.MethodList.Count)
                {
                    
                    UserLog.AddRunMsg("正在执行-" + _model.MethodList[CurStep].ToCmd());
                }
                
            }
        }



        //测试Logic
        private bool TestLogic(List<RYMethodRecord> testLst,eLogic lg)
        {
            if(lg==eLogic.And)
            {
                foreach(RYMethodRecord testRecord in testLst)
                {
                    if (eCode.OK != RYMethodDelegateFactory.ExecCmd(testRecord.ToCmd())) return false;
                }
                return true;
            }
            else
            {
                foreach (RYMethodRecord testRecord in testLst)
                {
                    if (eCode.OK == RYMethodDelegateFactory.ExecCmd(testRecord.ToCmd())) return true;
                }
                return false;
            }
        }
        private eCode ExecIfLogic()
        {
            eCode myCode = eCode.OK;
            //保存当前If标签索引
            int startidx = CurStep;
            RYLogicIf ryif = new RYLogicIf();
            List<int> errIdx=new List<int>();
            List<string> errMsg=new List<string>();
            //如果解析If指令错误，直接返回错误
            if (!_model.ParseLogicIf(CurStep, ref ryif, ref errIdx, ref errMsg))
            {
                foreach(string s in errMsg)
                {
                    UserLog.AddErrorMsg(s);
                }
                return eCode.NG;
            }
            List<RYMethodRecord> lstTest = ryif.GetTestCondition();
            if(lstTest.Count<1)
            {
                UserLog.AddErrorMsg("【" + ThreadName + "】逻辑If测试条件数量有问题");
                return eCode.NG;
            }
            //测试逻辑状态
            bool testresult = TestLogic(lstTest, ryif.Logic);
            List<RYMethodRecord> lstRun = ryif.GetRunItemsByLogic(testresult);
            //如果逻辑是false的状态，并且不包含else分支，直接返回
            if(lstRun.Count()==0)
            {
                CurStep = ryif.PriEndIdx;
                return eCode.OK;
            }
            int interStep = 0;
            while (!bExit)
            {
                int cur = -1;
                for (interStep = 0; interStep < lstRun.Count;)
                {
                    if (GBase.MachineState == eMachineState.Pause)
                    {
                        Thread.Sleep(200);
                        continue;
                    }
                    if (GBase.MachineState == eMachineState.Stop)
                    {
                        return eCode.Stop;
                    }
                    //如果需要暂停
                    if (_IsNeedPause)
                    {
                        if (!_IsPaused) UserLog.AddRunMsg("线程【" + ThreadName + "】已暂停");
                        _IsPaused = true;
                        _IsNeedPause = false;

                    }
                    //如果线程Paused直接返回
                    if (_IsPaused)
                    {
                        Thread.Sleep(200);
                        continue;
                    }
                    RYMethodRecord item = lstRun[interStep];
                    if(cur!=interStep)
                    {
                        cur = interStep;
                        UserLog.AddRunMsg("正在执行-" + item.ToCmd());
                    }
                    myCode = RYMethodDelegateFactory.ExecCmd(item.ToCmd());
                    switch (myCode)
                    {
                        case eCode.OK:
                            interStep++;
                            break;
                        case eCode.NG:
                            UserLog.AddErrorMsg("线程【" + ThreadName + "】命令【" + item.Name + "】设备停止");
                            GBase.MachineState = eMachineState.Stop;
                            break;
                        case eCode.MPause:
                            UserLog.AddRunMsg("线程【" + ThreadName + "】命令【" + item.Name + "】设备暂停");
                            GBase.MachineState = eMachineState.Pause;
                            break;
                        case eCode.MStop:
                            UserLog.AddRunMsg("线程【" + ThreadName + "】命令【" + item.Name + "】设备停止");
                            GBase.MachineState = eMachineState.Stop;
                            break;
                        case eCode.Pause:
                            if (!_IsPaused)
                            {
                                _IsPaused = true;
                                UserLog.AddRunMsg("线程【" + ThreadName + "】命令【" + item.Name + "】控制线程暂停");
                            }
                            break;
                        case eCode.Restart:
                            return myCode;
                            break;
                        case eCode.Again:
                            break;
                        default:
                            break;
                    }
                }
                //如果最后的状态是OK更改步骤后返回
                if(myCode == eCode.OK)
                {
                    CurStep = ryif.PriEndIdx;
                }
                return myCode;
            }
            //返回停止
            return eCode.Stop;
        }

        /// <summary>
        /// 流程总入口
        /// </summary>
        public void RunProcess()
        {
            eCode myCode = eCode.OK;
            while(!bExit)
            {
                if(GBase.MachineState==eMachineState.Stop)
                {
                    bExit = true;
                    break;
                }
                if (GBase.MachineState == eMachineState.Pause)
                {
                    Thread.Sleep(200);
                    continue;
                }
                //如果线程Paused直接返回
                if (_IsPaused)
                {
                    Thread.Sleep(200);
                    continue;
                }
                for (CurStep = 0; CurStep < _model.MethodList.Count;)
                {
                    if(GBase.MachineState==eMachineState.Pause)
                    {
                        Thread.Sleep(200);
                        continue;
                    }
                    if (GBase.MachineState == eMachineState.Stop)
                    {
                        break;
                    }
                    //如果需要暂停
                    if(_IsNeedPause)
                    {
                        if(!_IsPaused) UserLog.AddRunMsg("线程【" + ThreadName + "】已暂停");
                        _IsPaused = true;
                        _IsNeedPause = false;
                        
                    }
                    //如果线程Paused直接返回
                    if(_IsPaused)
                    {
                        Thread.Sleep(200);
                        continue;
                    }
                    RYMethodRecord item=_model.MethodList[CurStep];
                    if(item.MethodType==eMethodType.逻辑If)
                    {
                        myCode = ExecIfLogic();
                    }
                    else
                    {
                        myCode = RYMethodDelegateFactory.ExecCmd(item.ToCmd());
                    }
                    switch(myCode)
                    {
                        case eCode.OK:
                            CurStep++;
                            break;
                        case eCode.NG:
                            UserLog.AddErrorMsg("线程【" + ThreadName + "】命令【"+item.Name+"】设备停止");
                            GBase.MachineState = eMachineState.Stop;
                            break;
                        case eCode.MPause:
                            UserLog.AddRunMsg("线程【" + ThreadName + "】命令【" + item.Name + "】设备暂停");
                            GBase.MachineState=eMachineState.Pause;
                            break;
                        case eCode.MStop:
                            UserLog.AddRunMsg("线程【" + ThreadName + "】命令【" + item.Name + "】设备停止");
                            GBase.MachineState = eMachineState.Stop;
                            break;
                        case eCode.Pause:
                            if(!_IsPaused)
                            {
                                _IsPaused = true;
                                UserLog.AddRunMsg("线程【" + ThreadName + "】命令【" + item.Name + "】控制线程暂停");
                            }
                            break;
                        case eCode.Restart:
                            CurStep = 0;
                            break;
                        case eCode.Again:
                            break;
                        default:
                            break;
                    }
                }
                if(CurStep>=_model.MethodList.Count)
                {
                    if(PParam.RunMode==eProcessRunMode.循环)
                    {
                        _curstep = 0;
                        continue;
                    }
                    if (PParam.RunMode == eProcessRunMode.等待唤醒)
                    {
                        _curstep = 0;
                        _IsPaused = true;
                        continue;
                    }
                    break;
                }
            }
            UserLog.AddRunMsg(ThreadName + "已退出");
            bThreadExit = true;
            if(RYProcess.GetRunProcessCount()==0)
            {
                GBase.MachineState = eMachineState.Stop;
                RYProcess.StopAllProcess();
            }
        }
    }
}
