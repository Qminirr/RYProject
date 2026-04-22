using RY.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RYProject
{
    internal static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.ThreadException += Application_ThreadException; //UI线程异常
            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException; //多线程
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            const string MutexName = "RYProject";
            using (var m = new Mutex(false, MutexName))
            {
                if (!m.WaitOne(TimeSpan.FromSeconds(5), false))
                {
                    MsgBox.ShowWarning("设备程序已运行");
                }
                else
                {
                    G.Init();
                    m.ReleaseMutex();
                }
            }
        }

        //UI线程异常
        static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            UserLog.AddExceptionMsg(e.Exception);
            MsgBox.ShowError(e.Exception.ToString());

        }

        //多线程异常
        static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            MsgBox.ShowError(e.ExceptionObject.ToString());
            UserLog.AddErrorMsg(e.ExceptionObject.ToString());
        }
    }
}
