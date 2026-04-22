using RY.Base;
using RY.Ctrls;
using RY.Device;
using SunnyUI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RYProject
{
    public partial class G:GBase
    {
        //标志是否是加载状态
        private static bool loading = false;
        internal static void UpdateStep(int percentValue, string stepMsg, bool succeed)
        {
            try
            {
                if (percentValue > FWelcome.Instance.bar_step.Maximum)
                    percentValue = FWelcome.Instance.bar_step.Maximum;
                FWelcome.Instance.bar_step.Value = (percentValue > FWelcome.Instance.bar_step.Value ? percentValue : FWelcome.Instance.bar_step.Value);
                FWelcome.Instance.lbl_step.Text = stepMsg + " ......";
                Application.DoEvents();
            }
            catch (Exception ex)
            {
                UserLog.AddExceptionMsg(ex);
            }
        }

        /// <summary>
        /// 硬件打开比较耗时，故放在该硬件初始化打开的方法中
        /// </summary>
        internal static void HWInit()
        {
            UserLog.AddRunMsg("正在打开系统硬件......");
            UpdateStep(0, "正在打开硬件设备......", true);
            if(!DeviceFactory.OpenAllDevice())
            {
                UpdateStep(50, "打开硬件设备出现错误......", false);
            }
            else
            {
                UpdateStep(50, "已成功打开硬件设备......", true);
            }


            //故意增加时间，后续生产需拿掉
            WaitTimer.Sleep(3000);

            UpdateStep(70, "正在加载配置......", true);
            string cfgpath = Path.Combine(Application.StartupPath, "Config");
            if (!Directory.Exists(cfgpath))
            {
                Directory.CreateDirectory(cfgpath);
            }
            cfgpath += "\\ProjectSetting.dat";

            cfgpath = Path.Combine(Application.StartupPath, "Config");
            cfgpath += "\\SystemConfig.dat";


            //委托加载配方料号方法
            ProjectBase.LoadProjectHandle = frmMain.Inistance.LoadProject;


            SC = ConfigLoad<SystemConfig>.LoadCfg(cfgpath);
            UpdateStep(70, "正在初始化UI......", true);
            myIO = new FIO();
            myIO.SetUp();


            frmAxis = new FAxisContainer();


            PDC = new PDeviceCtrl();



            frmLog = new FLog();

            frmFunc = new FBoolFunc();


            UpdateStep(100, "设备初始化完成......", true);
            loading = false;
        }

        public static void Init()
        {

            //顺序最好不要变
            RYBoolDelegateFactory.SetUp(typeof(G));
            RYMethodDelegateFactory.SetUp(typeof(G));

            GBase.GBaseInit(typeof(RYProject));
            if(!DeviceFactory.LoadFromFile())
            {
                MsgBox.ShowError("加载设备配置失败！");
                return;
            }
            

            //正常生产需要拿掉
            UserLevel = eUserLevel.Administrator;
            FWelcome.Instance.Show();
            System.Windows.Forms.Application.DoEvents();

            Thread th = new Thread(HWInit);
            th.IsBackground = true;
            loading = true;
            th.Start();
            MainForm = frmMain.Inistance;
            MainPage = MainForm.MainPage;
            while (loading)
            {
                Thread.Sleep(5);
                System.Windows.Forms.Application.DoEvents();
            }
            //DBOperator.AddProduct("DDD", "123456", true, "测试正常");

            FWelcome.Instance.Dispose();
            MainForm.ShowDialog();

        }

        /// <summary>
        /// 主程序
        /// </summary>
        public static frmMain MainForm
        { get; set; } = null;

        /// <summary>
        /// 主页面
        /// </summary>
        public static FMain MainPage
        { get; set;  } = null;

        /// <summary>
        /// 保存当前配方
        /// </summary>
        public static RYProject curProject
        { get; set; } = null;


        /// <summary>
        /// 当前加载的配方名称
        /// </summary>
        public static string curProjectName
        { get; set; } = "";


        /// <summary>
        /// 当前系统所有的轴
        /// </summary>
        public static FAxisContainer frmAxis
        { get; set; }

        /// <summary>
        /// 日志
        /// </summary>
        public static FLog frmLog
        { get; set; }

        /// <summary>
        /// IO
        /// </summary>
        public static FIO myIO
        { get; set; }


        /// <summary>
        /// 布尔功能命令
        /// </summary>
        public static FBoolFunc frmFunc
        { get; set; }



        [RYAuth(eDbgFatherNode.通用设置, "设备管理", eUserLevel.Engineer, 0, 20)]
        public static PDeviceCtrl PDC
        { get; set; }


        private static SystemConfig _sc;

        [RYAuth(eDbgFatherNode.通用设置, "系统参数", eUserLevel.Administrator, 61449, 10)]
        public static SystemConfig SC
        {
            get
            {
                return _sc;
            }
            set
            {
                _sc = value;
                __SC = _sc;
            }
        }
    }
}
