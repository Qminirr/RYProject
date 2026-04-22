using RY.Base;
using SunnyUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace RY.Ctrls
{
    public partial class FParamInput : UIForm
    {
        public FParamInput()
        {
            InitializeComponent();

        }

        IRYFunc _item = null;
        public void SetUp(IRYFunc item,string curparam="")
        {
            _item = item;
            lbParamInfo.Text = "请输入执行参数\r\n"+item.GetParamInfo();
            lbRemark.Text ="说明\r\n"+ item.Remark;
            tbParam.Text = curparam;
        }
        public string Result
        { get; set; } = "";
        private void btConfirm_Click(object sender, EventArgs e)
        {
            Result = tbParam.Text.Trim().Replace('，',',');
            if(Result.Split(',').Length!=_item.ParamList.Count)
            {
                MsgBox.ShowErrorTip("输入参数数量不正确");
                return;
            }
            if(!_item.IsParamOK(Result.Split(',').ToArray()))
            {
                MsgBox.ShowWarningTip("输入参数不正确");
                return;
            }
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void tbParam_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btConfirm_Click(null,null);
            }
        }
    }
}
