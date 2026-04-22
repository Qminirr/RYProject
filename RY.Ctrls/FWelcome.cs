using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RY.Ctrls
{
    public partial class FWelcome : Form
    {
        public FWelcome()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        #region 窗体拖动
        private static bool IsDrag = false;
        private int enterX;
        private int enterY;
        private void setForm_MouseDown(object sender, MouseEventArgs e)
        {
            IsDrag = true;
            enterX = e.Location.X;
            enterY = e.Location.Y;
        }
        private void setForm_MouseUp(object sender, MouseEventArgs e)
        {
            IsDrag = false;
            enterX = 0;
            enterY = 0;
        }

        
        private void setForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsDrag)
            {
                Left += e.Location.X - enterX;
                Top += e.Location.Y - enterY;
            }
        }
        #endregion

        /// <summary>
        /// 窗体对象实例
        /// </summary>
        private static FWelcome _instance;

        public static FWelcome Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new FWelcome();
                return _instance;
            }
        }

        /// <summary>
        /// 配置
        /// </summary>
        public string AssemblyConfiguration
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyConfigurationAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyConfigurationAttribute)attributes[0]).Configuration;
            }
        }
        private void frmWelcome_Load(object sender, EventArgs e)
        {
            
            string date = File.GetLastWriteTime(Application.ExecutablePath).ToString("yyyyMMdd");
            lbl_version.Text = "当前版本：" + date;// System.Reflection.Assembly.GetExecutingAssembly().GetName().Version .ToString();
            bar_step.Maximum = 100;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Process.GetCurrentProcess().Kill();
        }
    }
}
