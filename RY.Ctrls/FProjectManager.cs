using RY.Base;
using SunnyUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace RY.Ctrls
{
    public partial class FProjectManager : UIPage
    {
        public FProjectManager()
        {
            InitializeComponent();
            lsbProjectNames.Items.AddRange(GBase.GProject.ListModel().ToArray());
        }

        private void btNew_Click(object sender, EventArgs e)
        {
            string str = "";
            if (!MsgBox.ShowInputString(ref str, true, "请输入新的模型名")) return;
            string modelname = str.Trim().ToLower();
            if (!modelname.EndsWith(".project"))
            {
                modelname += ".project";
            }
            if (GBase.GProject.Exists(modelname))
            {
                MsgBox.ShowWarningTip("已经存在该工程");
                return;
            }
            GBase.GProject.AddModel(modelname);
            lsbProjectNames.Items.Add(modelname);
            lsbProjectNames.SelectedIndex = lsbProjectNames.Items.Count - 1;
        }

        private void lsbProjectNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsbProjectNames.SelectedIndex != -1)
            {
                pg.SelectedObject = GBase.GProject.GetModel(lsbProjectNames.SelectedItem.ToString());
            }
        }

        private void btCopy_Click(object sender, EventArgs e)
        {
            if (lsbProjectNames.SelectedIndex == -1)
            {
                MsgBox.ShowWarningTip("请先选中任务");
                return;
            }
            string str = "";
            if (!MsgBox.ShowInputString(ref str, true, "请输入复制后的流程名字")) return;
            string newname = str.Trim().ToLower();
            if (!newname.Contains(".project"))
            {
                newname += ".project";
            }
            string oldname = lsbProjectNames.SelectedItem.ToString();
            if (GBase.GProject.Exists(newname))
            {
                MsgBox.ShowWarningTip("新的任务名字已经存在，请换一个");
                return;
            }
            GBase.GProject.CopyModel(oldname, newname);
            lsbProjectNames.Items.Add(newname);
            lsbProjectNames.SelectedIndex = lsbProjectNames.Items.Count - 1;
        }

        private void btRename_Click(object sender, EventArgs e)
        {
            if (lsbProjectNames.SelectedIndex == -1)
            {
                MsgBox.ShowWarningTip("请先选中任务");
                return;
            }
            string str = "";
            if (!MsgBox.ShowInputString(ref str, true, "请输入重命名的任务名字")) return;
            string newname = str.Trim().ToLower();
            if (!newname.Contains(".project"))
            {
                newname += ".project";
            }
            string oldname = lsbProjectNames.SelectedItem.ToString();
            if (GBase.GProject.Exists(newname))
            {
                MsgBox.ShowWarningTip("重命名的任务名字已经存在，请换一个");
                return;
            }
            GBase.GProject.Rename(oldname, newname);
            lsbProjectNames.Items.RemoveAt(lsbProjectNames.SelectedIndex);
            lsbProjectNames.Items.Add(newname);
            lsbProjectNames.SelectedIndex = lsbProjectNames.Items.Count - 1;
        }

        private void btDel_Click(object sender, EventArgs e)
        {
            if (lsbProjectNames.SelectedIndex == -1)
            {
                MsgBox.ShowWarningTip("请先选中任务");
                return;
            }
            string oldname = lsbProjectNames.SelectedItem.ToString();
            GBase.GProject.DeleteModel(oldname);
            lsbProjectNames.Items.RemoveAt(lsbProjectNames.SelectedIndex);
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (lsbProjectNames.SelectedIndex == -1)
            {
                MsgBox.ShowWarningTip("请先选中任务");
                return;
            }
            string modelname = lsbProjectNames.SelectedItem.ToString();
            ConfigBase cb = GBase.GProject.GetModel<ConfigBase>(modelname);
            if (cb == null|| !cb.Save())
            {
                MsgBox.ShowWarningTip("保存失败");
            }
            else
            {
                MsgBox.ShowSuccessTip("保存成功");
            }
        }
    }
}
