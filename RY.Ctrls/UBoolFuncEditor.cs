using RY.Base;
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
    public partial class UBoolFuncEditor : UserControl,IRYModalEditor
    {

        //[Editor(typeof(RYModelEditor<UBoolFuncEditor>), typeof(System.Drawing.Design.UITypeEditor))]
        public UBoolFuncEditor()
        {
            InitializeComponent();
            lsbNames.Items.AddRange(RYBoolDelegateFactory.GetOrderName("").ToArray());
        }


        public string Command
        { get; set; } = "";
        public object GetValue()
        {
            return Command;
        }

        public void SetValue(object obj, object instance)
        {
            if(obj is string)
            {
                Command= (string)obj;
                lbCmd.Text = "当前命令："+Command;
                //计算(3,4)
                int idx = Command.IndexOf('(');
                if(idx != -1)
                {
                    string name = Command.Substring(0, idx);
                    for (int i = 0; i < lsbNames.Items.Count; i++)
                    {
                        if(lsbNames.Items[i].ToString() == name)
                        {
                            lsbNames.SelectedIndex = i;
                            break;
                        }
                    }
                }
                
            }
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            lsbNames.Items.Clear();
            string prefix = tbSearch.Text.Trim();
            lsbNames.Items.AddRange(RYBoolDelegateFactory.GetOrderName(prefix).ToArray());
        }

        private void btConfirm_Click(object sender, EventArgs e)
        {
            if(lsbNames.SelectedIndex==-1)
            {
                MsgBox.ShowWarningTip("请选中要添加修改的命令");
                return;
            }
            RYBoolDelegateItem item= RYBoolDelegateFactory.GetFunc(lsbNames.SelectedItem.ToString());
            if(item.ParamList.Count<=0)
            {
                Command = item.Name + "(" + ")";
            }
            else
            {


                FParamInput f = new FParamInput();
                f.SetUp(item);
                if (f.ShowDialog() != DialogResult.OK)
                {
                    return;
                }
                //int a,int b
                //3,4
                Command = item.Name + "(" + f.Result + ")";
            }
            lbCmd.Text = "当前命令：" + Command;
        }
    }
}
