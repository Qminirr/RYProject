using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RY.Base;
using SunnyUI;
namespace RY.Ctrls
{
    public partial class FChangePassword : UIForm
    {
        public FChangePassword()
        {
            InitializeComponent();
        }

        
        private void FrmChangePassword_Load(object sender, EventArgs e)
        {
            switch (GBase.UserLevel)
            {
                case eUserLevel.Operator:
                    combUser.Items.Add("操作员");
                    break;
                case eUserLevel.Engineer:
                    combUser.Items.Add("操作员");
                    combUser.Items.Add("工程师");
                    break;
                case eUserLevel.Administrator:
                    combUser.Items.Add("操作员");
                    combUser.Items.Add("工程师");
                    combUser.Items.Add("管理员");
                    break;
                default:
                    break;
            }
            combUser.SelectedIndex = 0;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (tbPassword.Text == string.Empty || tbNewPassword.Text == string.Empty)
            {
                lbText.Text = "-密码输入不能为空";
                return;
            }
            string strPassword = DESEncrypt.Encrypt(tbPassword.Text);
            string oldPassword = "123";
            
            if(combUser.SelectedItem.ToString()== "操作员")
            {
                oldPassword = GBase.GetSysCfgBase().OperatorPSW;
            }
            if (combUser.SelectedItem.ToString() == "工程师")
            {
                oldPassword = GBase.GetSysCfgBase().EngineerPSW;
            }
            if (combUser.SelectedItem.ToString() == "管理员")
            {
                oldPassword = GBase.GetSysCfgBase().AdminPSW;
            }
           
            if (GBase.UserLevel==eUserLevel.Administrator||strPassword == oldPassword)
            {
                if(tbNewPassword.Text!=tbNewPassword2.Text)
                {
                    MsgBox.ShowWarning("两次输入的新密码不一致！");
                    return;
                }
                strPassword = DESEncrypt.Encrypt(tbNewPassword.Text);
                if (combUser.SelectedItem.ToString() == "操作员")
                {
                    GBase.GetSysCfgBase().OperatorPSW=strPassword;
                }
                if (combUser.SelectedItem.ToString() == "工程师")
                {
                    GBase.GetSysCfgBase().EngineerPSW = strPassword;
                }
                if (combUser.SelectedItem.ToString() == "管理员")
                {
                    GBase.GetSysCfgBase().AdminPSW = strPassword;
                }
                GBase.GetSysCfgBase().Save();
                MsgBox.ShowSuccessNotifier("密码修改成功！");
                this.Close();
                return;
            }
            else
            {
                tbPassword.Clear();
                tbNewPassword.Clear();
                tbNewPassword2.Clear();
                lbText.Text = "-当前用户密码输入错误";
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
