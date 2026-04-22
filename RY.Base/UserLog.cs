using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace RY.Base
{

    public class UserLog
    {
        /// <summary>
        /// 多线程访问锁
        /// </summary>
        public static object objLock = new object();

        /// <summary>
        /// 界面显示事件，对应控件注册
        /// </summary>

        public static event Action<LogMessage> OnMessage;

        /// <summary>
        /// 添加消息进日志文件
        /// </summary>
        /// <param name="uMsg"></param>
        public static void AddMsg(LogMessage uMsg)
        {
            /*
             * 加锁，防止多线程访问冲突
             */
            lock (objLock)
            {
                /*
                 * 日志文件存储路径：启动目录\Applog\year\year-month-day.txt
                 * 内容格式：日期  日志类型    内容
                 * 
                 * */
                string path = Path.Combine(Application.StartupPath, "Applog",DateTime.Now.Year.ToString());
                //判断目录是否存在，不存在就创建
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
                //定义日志路径
                string logpath = Path.Combine(path, DateTime.Now.ToString("yyyy-MM-dd") + ".txt");
                //写入日志
                //using (StreamWriter sw = new StreamWriter(logpath))
                //{
                //    sw.WriteLine("|"+uMsg.ToString());
                //}
                File.AppendAllText(logpath, uMsg.ToString(), Encoding.UTF8);
                //如果有消息注册，消息通知界面
                if (OnMessage!=null) OnMessage(uMsg);
            }
        }
        /// <summary>
        /// 添加运行日志
        /// </summary>
        /// <param name="msg"></param>
        public static void AddRunMsg(string msg)
        {
            AddMsg(LogMessage.From(msg, eLogLevel.运行));
        }
        /// <summary>
        /// 添加警告日志
        /// </summary>
        /// <param name="msg"></param>
        public static void AddWarnMsg(string msg)
        {
            AddMsg(LogMessage.From(msg, eLogLevel.警告));
        }
        /// <summary>
        /// 添加错误日志
        /// </summary>
        /// <param name="msg"></param>
        public static void AddErrorMsg(string msg)
        {
            AddMsg(LogMessage.From(msg, eLogLevel.错误));
        }

        public static void AddExceptionMsg(Exception ex)
        {
            StackFrame tmpSF = new StackTrace(new StackFrame(true)).GetFrame(0);
            string rowNo = "";
            if (ex.ToString().Contains("行号") || ex.ToString().Contains("line"))
            {
                if (ex.ToString().Contains("行号"))
                {
                    rowNo = ex.ToString().Split(new string[] { "行号" }, StringSplitOptions.RemoveEmptyEntries)[1];
                }
                else
                {
                    rowNo = ex.ToString().Split(new string[] { "line" }, StringSplitOptions.RemoveEmptyEntries)[1];
                }
            }
            else
            {
                rowNo = "未知";
            }
            string data = "----------     " + DateTime.Now.ToString() + "     ----------" + Environment.NewLine +
                          "出错文件：" + tmpSF.GetFileName() + Environment.NewLine +
                          "出错函数：" + tmpSF.GetMethod().Name + Environment.NewLine +
                          "出错行号：" + rowNo + Environment.NewLine +
                          "出错列号：" + tmpSF.GetFileColumnNumber() + Environment.NewLine +
                          "出错信息：" + ex.Message.ToString() + Environment.NewLine;
            data += Environment.NewLine;
            AddMsg(LogMessage.From(data, eLogLevel.异常));
        }

    }
    /// <summary>
    /// 定义用户日志消息类
    /// </summary>
    public class LogMessage
    {
        /// <summary>
        /// 消息内容
        /// </summary>
        public string Msg
        { get; set; }

        /// <summary>
        /// 消息类别
        /// </summary>
        public eLogLevel Level
        { get; set; }

        /// <summary>
        /// 日志时间
        /// </summary>
        public DateTime LogTime
        { get; set; }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="level"></param>
        public LogMessage(string msg, eLogLevel level = eLogLevel.运行) 
        {
            Msg = msg;
            Level = level;
            LogTime = DateTime.Now;
        }

        /// <summary>
        /// 复写ToString
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string s = "|"+LogTime.ToString("yyyy-MM-dd HH:mm:ss.fff") + "\t" + Level.ToString() + "\t" + Msg+"\r\n";
            return s;
        }

        /// <summary>
        /// 固态生成实列
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="level"></param>
        /// <returns></returns>
        public static LogMessage From(string msg, eLogLevel level = eLogLevel.运行)
        {
            LogMessage message = new LogMessage(msg,level);
            return message;
        }
    }

    /// <summary>
    /// 消息日志类别
    /// </summary>
    public enum eLogLevel
    {
        运行=0,
        警告,
        错误,
        异常
    }
}
