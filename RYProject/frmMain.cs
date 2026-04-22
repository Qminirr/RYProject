using RY.Base;
using RY.Ctrls;
using RY.Device;
using SunnyUI;
using SunnyUI.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RYProject
{
    public partial class frmMain : Form
    {
        Dictionary<ePage, UIPage> _dicPage = new Dictionary<ePage, UIPage>();

        PulseSource psNormal = new PulseSource(500, "主框架慢定时器");

        static frmMain fmain = null;
        static object lockobj = new object();
        public frmMain()
        {
            InitializeComponent();
            _dicPage[ePage.Main] = new FMain();
            _dicPage[ePage.Debug] = new FDebug();
            _dicPage[ePage.Process] = new PProcess();
            _dicPage[ePage.Project] = new FProjectManager();
            _dicPage[ePage.ProductLog] = new PProduct();
            pnlContainer.Controls.Add(_dicPage[ePage.Main]);
            _dicPage[ePage.Main].Show();
            psNormal.PulseOut += PulseNormal;
            psNormal.StartPulse();
            //RYStorage.Instance.SetObject("haha", "hahahaha");
            //RYStorage.Instance.SetObject("dt", DateTime.Now);
            //RYStorage.Instance.Clear();
            RYStorage.Instance.GetBoolean("IsOK");

            lbAlarmInfo.Active = true;
            btnClearAlarm.SymbolColor = Color.DodgerBlue;
        }


        public static frmMain Inistance
        {
            get
            {
                if (fmain != null) return fmain;
                lock(lockobj)
                {
                    if(fmain != null) return fmain;
                    fmain=new frmMain();
                    return fmain;
                }
            }
        }

        public FMain MainPage
        {
            get
            {
                return _dicPage[ePage.Main] as FMain;
            }
        }


       

        private void PulseNormal(object sender,EventArgs e)
        {
            if (InvokeRequired&&!IsDisposed)
            {
                Invoke(new Action(() =>
                {
                    PulseNormal(sender,e);
                }));
            }
            else
            {
                string tag = "";
                Color c = Color.Blue;
                switch(G.MachineState)
                {
                    case eMachineState.Running:
                        tag = "运行";
                        c = Color.Green;
                        break;
                    case eMachineState.Pause:
                        tag = "暂停";
                        c = Color.Yellow;
                        break;
                    default:
                        tag = "停止";
                        c = Color.Blue;
                        break;

                }
                if(!lbState.Text.Contains(tag))
                {
                    lbState.Text = "设备状态：" + tag;
                    lbState.MarkColor = c;
                }

                switch(G.UserLevel)
                {
                    case eUserLevel.Administrator:
                        tag = "管理员";
                        break;
                    case eUserLevel.Engineer:
                        tag = "工程师";
                        break;
                    default:
                        tag = "操作员";
                        break;
                }
                if(!lbLogin.Text.Contains(tag))
                {
                    lbLogin.Text = "当前用户：" + tag;
                }
                //lbTime.Text = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
            }
                

        }

        private void btClose_Click(object sender, EventArgs e)
        {
            if(G.MachineState == eMachineState.Running)
            {
                MsgBox.ShowWarning("请先停止设备后，才可以关闭控制软件");
                return;
            }
            if(!MsgBox.ShowAsk("确定关闭设备吗？"))
            {
                return;
            }
            this.Hide();
            MsgBox.ShowWait("正在关闭设备，请等待......");
            PulseSource.Clean();
            Close();
            MsgBox.HideWait();
        }

        private void btMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btMainPage_Click(object sender, EventArgs e)
        {
            pnlContainer.Controls.Clear();
            pnlContainer.Controls.Add(_dicPage[ePage.Main]);
            _dicPage[ePage.Main].Show();
        }

        private void btDebug_Click(object sender, EventArgs e)
        {
            pnlContainer.Controls.Clear();
            pnlContainer.Controls.Add(_dicPage[ePage.Debug]);
            _dicPage[ePage.Debug].Show();
        }

        private void btLogPage_Click(object sender, EventArgs e)
        {
            G.frmLog.Show();
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            
            RYProject project =G.curProject;
            if(project == null)
            {
                MsgBox.ShowWarningTip("未加载任何料号");
                return;
            }
            if(G.MachineState==eMachineState.Running)
            {
                UserLog.AddWarnMsg("请先停止设备，再开始");
                return;
            }
            if (G.MachineState == eMachineState.Pause)
            {
                G.MachineState = eMachineState.Running;
                UserLog.AddRunMsg("设备从暂停切换到运行状态");
                return;
            }
            G.MachineState = eMachineState.Running;
            RYProcess.CreateProcess(project);
            RYProcess.StartAllProcess();
            
        }

        private void btPause_Click(object sender, EventArgs e)
        {
            if(G.MachineState == eMachineState.Running)
            {
                G.MachineState = eMachineState.Pause;
                UserLog.AddRunMsg("设备从运行切换到暂停状态");
            }
            

        }

        private void btStop_Click(object sender, EventArgs e)
        {
            G.MachineState = eMachineState.Stop;
            RYProcess.StopAllProcess();
        }

        private void btTask_Click(object sender, EventArgs e)
        {
            pnlContainer.Controls.Clear();
            pnlContainer.Controls.Add(_dicPage[ePage.Project]);
            _dicPage[ePage.Project].Show();
        }

        private void tbFunc_Click(object sender, EventArgs e)
        {

            G.frmFunc.Show();
        }

        private void btProcessPage_Click(object sender, EventArgs e)
        {
            pnlContainer.Controls.Clear();
            pnlContainer.Controls.Add(_dicPage[ePage.Process]);
            _dicPage[ePage.Process].Show();
        }

        private void btSysIO_Click(object sender, EventArgs e)
        {
            if (G.MachineState == eMachineState.Running)
            {
                MsgBox.ShowWarningTip("设备非停止或暂停状态，无法进入");
                return;
            }
            G.myIO.Show();
        }

        private void btAxisCtrl_Click(object sender, EventArgs e)
        {
            if (G.MachineState == eMachineState.Running)
            {
                MsgBox.ShowWarningTip("设备非停止或暂停状态，无法进入");
                return;
            }
            G.frmAxis.Show();
        }

        private bool _isHomeFailed = false;
        private bool _isHomeProcessing = false;
        private void AxisHome()
        {
            
            _isHomeFailed = false;
            List<AxisBase> lstAll=DeviceFactory.GetAxisList();
            if(lstAll.Count==0)
            {
                UserLog.AddWarnMsg("系统不存在任何轴");
                return;
            }
            _isHomeProcessing = true;
            MsgBox.ShowWait("正在复位系统......");
            Thread.Sleep(10);
            //先取得要回零的轴列表
            foreach(eAxisHomeOrder od in Enum.GetValues(typeof(eAxisHomeOrder)))
            {
                List<AxisBase>  lstCur = lstAll.FindAll(x => x.HomeOrder == od);
                if (lstCur.Count == 0) continue;
                int homemaxwait = 0;
                MsgBox.SetWaitDescription("正在复位" + od.ToString() + "......");
                UserLog.AddRunMsg("正在复位" + od.ToString() + "......");
                //列表中同时启动Home的Task
                foreach (AxisBase cur in lstCur)
                {
                    //获取列表中HomeTimeOut的最大超时值
                    if(cur.HomeTimeOut > homemaxwait) homemaxwait = cur.HomeTimeOut;
                    Task.Run(() =>
                    {
                        cur.Home();
                    });
                }
                
                
                WaitTimer.Wait(homemaxwait, () =>
                {
                    WaitTimer.Sleep(50);
                    //如果其中某个轴复位失败，停止等待
                    if (lstCur.Find(x => x.IsHomeFailed) != null) return true;
                    //如果列表中所有轴都复位成功，停止等待
                    if (lstCur.Find(x => !x.IsHome) == null) return true;
                    //继续等待
                    return false;
                });
                //如果列表中所有轴复位完成，继续下一个HomeOrder
                if (lstCur.Find(x => !x.IsHome) == null) continue;
                _isHomeFailed = true;
                //复位失败或者超时
                foreach(AxisBase cur in lstCur)
                {
                    //停止该轴运动
                    cur.Stop();
                    break;
                }
                
            }
            _isHomeProcessing = false;
            //隐藏等待窗口
            MsgBox.HideWait();
            if(_isHomeFailed)
            {
                UserLog.AddErrorMsg("系统复位失败");
                MsgBox.ShowError("系统复位失败");
            }
            else
            {
                UserLog.AddRunMsg("系统复位成功");
                MsgBox.ShowSuccessTip("系统复位成功");
            }
        }

        private void btInitMachine_Click(object sender, EventArgs e)
        {
            if (G.MachineState != eMachineState.Stop)
            {
                MsgBox.ShowWarningTip("设备非停止或暂停状态，无法进入");
                return;
            }
            if(_isHomeProcessing)
            {
                MsgBox.ShowWarningTip("系统正在复位中");
                return;
            }
            Task.Run(() =>
            {
                AxisHome();
            });
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            FLogin f=new FLogin();
            f.ShowDialog();
            f.Dispose();
        }

        private void btnKeyBoard_Click(object sender, EventArgs e)
        {
            System.Diagnostics.ProcessStartInfo info = new System.Diagnostics.ProcessStartInfo();
            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            info.FileName = "osk.exe";
            info.Arguments = "";
            try
            {
                proc = System.Diagnostics.Process.Start(info);
            }
            catch
            {
                MsgBox.ShowError("未能打开软键盘");
            }
        }


        public void AddAlarm(string msg)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => {
                    AddAlarm(msg);
                }));
            }
            else
            {
                lbAlarmInfo.Active = true;
                lbAlarmInfo.Text = lbAlarmInfo.Text + "    " + msg;
                btnClearAlarm.SymbolColor = Color.Red;
                UserLog.AddWarnMsg(msg);
            }
        }
        private void btnClearAlarm_Click(object sender, EventArgs e)
        {
            btnClearAlarm.SymbolColor = Color.DodgerBlue;
            lbAlarmInfo.Active = false;
            lbAlarmInfo.Text = "";
        }

        private void btnMore_Click(object sender, EventArgs e)
        {
            btnMore.ShowContextMenuStrip(menuMore, 0, btnMore.Height);
        }

        private void btnChangePWD_Click(object sender, EventArgs e)
        {
            if (G.UserLevel == eUserLevel.Operator)
            {
                MsgBox.ShowWarningNotifier("权限不足");
                return;
            }
            if (G.MachineState != eMachineState.Stop)
            {
                MsgBox.ShowWarningTip("设备非停止状态，无法进入");
                return;
            }
            FChangePassword frm = new FChangePassword();
            frm.ShowDialog();
            frm.Dispose();
        }

        private void lbLogin_DoubleClick(object sender, EventArgs e)
        {
            if (!MsgBox.ShowAsk("确定退出登录状态吗？")) return;
            G.UserLevel = eUserLevel.Operator;
        }


        /// <summary>
        /// 当线程调用，无须多线程处理
        /// </summary>
        /// <param name="prjName"></param>
        /// <returns></returns>
        public bool LoadProject(string prjName)
        {
            if (string.IsNullOrEmpty(prjName) || prjName == "「重置工程」")
            {
                //重置任务料号配方
                G.curProject = null;
                G.curProjectName = "";
                lbLoadProject.Text = "双击加载配方";
                lbLoadProject.ForeColor = Color.Red;
                return true;
            }
            RYProject pro = G.GProject.GetModel<RYProject>(prjName);
            if (pro == null)
            {
                G.curProject = null;
                G.curProjectName = "";
                lbLoadProject.Text = "双击加载配方";
                lbLoadProject.ForeColor = Color.Red;
                UserLog.AddErrorMsg("加载配方料号" + prjName + "失败");
                return false;
            }
            if (!MainPage.LoadProject(pro))
            {
                G.curProject = null;
                G.curProjectName = "";
                lbLoadProject.Text = "";
                lbLoadProject.ForeColor = Color.Red;
                UserLog.AddErrorMsg("处理配方料号" + prjName + "加载失败");
                return false;
            }
            G.curProject = pro;
            G.curProjectName = prjName;
            lbLoadProject.Text = "当前配方："+prjName;
            lbLoadProject.ForeColor = Color.Blue;

            return true;
        }
        private void lbLoadProject_DoubleClick(object sender, EventArgs e)
        {
            if(G.MachineState!=eMachineState.Stop)
            {
                MsgBox.ShowWarningTip("请停止设备后，再切换配方");
                return;
            }
            FProduct f=new FProduct();
            f.ShowDialog();
        }

        private void btProductLog_Click(object sender, EventArgs e)
        {
            pnlContainer.Controls.Clear();
            pnlContainer.Controls.Add(_dicPage[ePage.ProductLog]);
            _dicPage[ePage.ProductLog].Show();
        }
    }

    public enum ePage
    {
        Main=0,
        Debug,
        Process,
        Project,
        ProductLog
    }
}
