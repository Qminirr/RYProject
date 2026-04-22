using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RY.Base;
namespace RY.Ctrls
{
    public partial class FLogin : Form
    {
        public FLogin()
        {
            InitializeComponent();

        }

        static string _cap = "睿颖智能";
        public static string Caption
        {
            get
            {
                return _cap;
            }
            set
            {
                _cap = value;
            }
        }
       
        private void FrmLogin_Load(object sender, EventArgs e)
        {
            label1.Text = _cap;

            combUser.Items.Add("操作员");
            combUser.Items.Add("工程师");
            combUser.Items.Add("管理员");
            
            combUser.SelectedIndex = 0;
            this.ActiveControl = tbPassword;
        }

        Point PtMouseDown;
        int nErrorCount = 0;
        bool isClick = false;
        private void btnLogin_Click(object sender, EventArgs e)
        {
            //登录
            eUserLevel user = (eUserLevel)combUser.SelectedIndex;
            string password = "123";
            if (tbPassword.Text == string.Empty)
            {
                MsgBox.ShowWarningTip("密码不能为空！");
                return;
            }
            password = DESEncrypt.Encrypt(tbPassword.Text);
            bool bOK = false;
            switch (user)
            {
                case eUserLevel.Operator:
                    if (GBase.GetSysCfgBase().OperatorPSW == null)
                    {
                        GBase.GetSysCfgBase().OperatorPSW = DESEncrypt.Encrypt("testme");
                        GBase.GetSysCfgBase().Save();
                    }
                    if (password == GBase.GetSysCfgBase().OperatorPSW)
                    {
                        GBase.UserLevel = eUserLevel.Operator;
                        bOK = true;
                    }
                    break;
                case eUserLevel.Engineer:
                    if (GBase.GetSysCfgBase().EngineerPSW == null)
                    {
                        GBase.GetSysCfgBase().EngineerPSW = DESEncrypt.Encrypt("RYRYRY");
                        GBase.GetSysCfgBase().Save();
                    }
                    if (password == GBase.GetSysCfgBase().EngineerPSW)
                    {

                        GBase.UserLevel = eUserLevel.Engineer;
                        bOK = true;
                    }
                    break;
                case eUserLevel.Administrator:
                    if (GBase.GetSysCfgBase().AdminPSW == null)
                    {
                        GBase.GetSysCfgBase().AdminPSW = DESEncrypt.Encrypt("RYAdmin");
                        GBase.GetSysCfgBase().Save();
                    }
                    if (password == GBase.GetSysCfgBase().AdminPSW)
                    {
                        GBase.UserLevel = eUserLevel.Administrator;
                        bOK = true;
                    }
                    break;
                default:
                    break;
            }
            if (bOK)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
                return;
            }
            nErrorCount++;
            if (nErrorCount <= 5)
            {
                lbLog.Text = "密码错误，继续" + (6 - nErrorCount).ToString() + "次输错后程序关闭！";
                return;
            }
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void toolStrip1_MouseDown(object sender, MouseEventArgs e)
        {
            PtMouseDown = new Point(e.X, e.Y);
        }

        private void toolStrip1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Location = new Point(this.Location.X + e.X - PtMouseDown.X, this.Location.Y + e.Y - PtMouseDown.Y);
            }
        }

        private void toolStripBtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            isClick = !isClick;
            if (isClick)
            {
                tbPassword.PasswordChar = new char();
                this.pictureBox4.BackgroundImage = global::RY.Ctrls.Properties.Resources.识别;
                this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                this.toolTip1.SetToolTip(this.pictureBox4, "隐藏输入");
            }
            else
            {
                tbPassword.PasswordChar = '*';
                this.pictureBox4.BackgroundImage = global::RY.Ctrls.Properties.Resources.识别_1;
                this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                this.toolTip1.SetToolTip(this.pictureBox4, "可见输入");
            }
        }


        private void tbPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)//按下Enter
            {
                btnLogin_Click(sender, e);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
