using RY.Base;
using RY.Device;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace RYProject
{
    public partial class G:GBase
    {

        protected static bool SetAxisRunSpeed()
        {
            List<AxisBase> lst = DeviceFactory.GetAxisList();
            foreach(AxisBase axis in lst)
            {
                axis.ChangeSpeed(eAxisSpeedMode.运行速度);
            }
            return true;
        }

        /// <summary>
        /// 执行 Windows 命令（如 notepad、calc、mspaint 等）
        /// </summary>
        public static void RunCommand(string command)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "cmd.exe",
                Arguments = "/c " + command, // /c 执行后关闭cmd
                UseShellExecute = true,     // 必须开启才能正常打开窗口
                CreateNoWindow = true       // 不显示cmd黑窗口
            });
        }


        /// <summary>
        /// 执行CMD命令并返回输出结果
        /// </summary>
        /// <param name="command">要执行的命令</param>
        /// <returns>命令输出文本</returns>
        public static string RunCmdCommand(string command)
        {
            // 创建进程对象
            Process process = new Process();

            // 配置进程启动参数
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                FileName = "cmd.exe",          // 调用CMD
                Arguments = $"/c {command}",  // /c 表示执行命令后关闭CMD
                UseShellExecute = false,      // 必须禁用Shell才能重定向输入输出
                RedirectStandardOutput = true,// 重定向输出
                RedirectStandardError = true, // 重定向错误
                CreateNoWindow = true,        // 不显示黑窗口
                StandardOutputEncoding = System.Text.Encoding.GetEncoding("GBK") // 解决中文乱码
            };

            process.StartInfo = startInfo;
            process.Start();

            // 读取输出和错误
            string output = process.StandardOutput.ReadToEnd();
            string error = process.StandardError.ReadToEnd();

            process.WaitForExit();
            process.Close();

            // 返回结果（错误+输出）
            return string.IsNullOrEmpty(error) ? output : error;
        }
        public static bool _SetOutIO(eOut io,eSwitch sw)
        {
            return IOCtrl.SetOutPin(io.ToString(), sw);
        }


        public static eSwitch _GetOutIO(eOut io)
        {
            return IOCtrl.GetOutPin(io.ToString());
        }

        public static eSwitch _GetInIO(eIn io)
        {
            return IOCtrl.GetInPin(io.ToString());
        }

    }
}
