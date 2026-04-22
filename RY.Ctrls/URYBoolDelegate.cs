using RY.Base;
using SunnyUI.Win32;
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
    public partial class URYBoolDelegate : UserControl
    {
        public URYBoolDelegate()
        {
            InitializeComponent();
        }

        RYBoolDelegateItem _item = null;
        public void SetUp(RYBoolDelegateItem item)
        {
            _item = item;
            lbName.Text = item.Name;
        }

        private void btExec_Click(object sender, EventArgs e)
        {
            if(_item==null)
            {
                UserLog.AddWarnMsg("URYBoolDelegate赋值错误");
                return;
            }
            if(_item.ParamList.Count==0)
            {
                object[] p = { };
                if (_item.Exec(p))
                {
                    MsgBox.ShowSuccessTip("执行成功");
                }
                else
                {
                    MsgBox.ShowWarningTip("执行失败");
                }
            }
            else
            {
                string str = "";
                
                FParamInput f=new FParamInput();
                f.SetUp(_item);
                if (DialogResult.OK != f.ShowDialog()) return;
                str = f.Result;
                string[] s = str.Replace('，', ',').Split(',');
                if(_item.Exec(s))
                {
                    MsgBox.ShowSuccessTip("执行成功");
                }
                else
                {
                    MsgBox.ShowWarningTip("执行失败");
                }
            }
                

        }
    }
}
