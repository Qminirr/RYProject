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
    public partial class PProcess : UIPage
    {
        public PProcess()
        {
            InitializeComponent();
            cbProcess.Items.AddRange(GBase.GProcess.ListModel().ToArray());


            InitDgvAllProcess(RYMethodDelegateFactory.GetFuncs());
        }


        private void InitDgvAllProcess(List<RYMethodDelegateItem> lst)
        {
            dgvAllProcess.Rows.Clear();
            for(int i=0;i<lst.Count;i++)
            {
                int n = dgvAllProcess.Rows.Add();
                dgvAllProcess.Rows[n].Cells[0].Value = (i + 1).ToString();
                dgvAllProcess.Rows[n].Cells[1].Value = lst[i].Name;
                dgvAllProcess.Rows[n].Cells[2].Value = lst[i].MethodType;
                dgvAllProcess.Rows[n].Cells[3].Value = lst[i].Remark;
            }
        }
        private void btAddProcess_Click(object sender, EventArgs e)
        {
            string name = "";
            if (!MsgBox.ShowInputString(ref name, true, "请输入流程名")) return;
            string fname = name.ToLower();
            if(!fname.Contains(".proc"))
            {
                fname += ".proc";
            }
            if(GBase.GProcess.Exists(fname))
            {
                MsgBox.ShowWarning("系统已经存在该名称，请更换一个");
                return;
            }

            RYMethodCollection methods=new RYMethodCollection();

            GBase.GProcess.AddModel(fname, methods);
            cbProcess.Items.Add(fname);
            cbProcess.SelectedIndex=cbProcess.Items.Count-1;
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            string key = tbSearch.Text.Trim();
            InitDgvAllProcess(RYMethodDelegateFactory.GetFuncsByPrefix(key));
        }

        void RefreshCurProcess(RYMethodCollection model)
        {
            dgvCurProcess.Rows.Clear();
            
            for (int i = 0; i < model.MethodList.Count; i++)
            {
                int n = dgvCurProcess.Rows.Add();
                dgvCurProcess.Rows[n].Cells[0].Value = (i + 1).ToString();
                dgvCurProcess.Rows[n].Cells[1].Value = model.MethodList[i].Name;
                dgvCurProcess.Rows[n].Cells[2].Value = model.MethodList[i].Param;
                dgvCurProcess.Rows[n].Cells[3].Value = model.MethodList[i].Remark;
                int retcode = RYMethodDelegateFactory.CheckCmd(model.MethodList[i]);
                if(retcode==1)
                {
                    dgvCurProcess.Rows[n].Cells[1].Style.BackColor = Color.Red;
                }
                else if(retcode==2)
                {
                    dgvCurProcess.Rows[n].Cells[2].Style.BackColor = Color.Red;
                }
                dgvCurProcess.Rows[n].Cells[4].Value = model.MethodList[i].MethodType;
            }
            dgvCurProcess.ClearSelection();
        }

        int FindMaxIndex()
        {
            int idx = -1;
            if(dgvCurProcess.SelectedRows!=null)
            {
                for(int i=0;i<dgvCurProcess.SelectedRows.Count;i++)
                {
                    if (dgvCurProcess.SelectedRows[i].Index>idx)
                    {
                        idx=dgvCurProcess.SelectedRows [i].Index;
                    }
                }
            }
            return idx;
        }
        void AddMethodRecord()
        {
            if(cbProcess.SelectedIndex==-1)
            {
                MsgBox.ShowWarningTip("请选中对应流程模型文件");
                return;
            }
            if (dgvAllProcess.SelectedRows == null || dgvAllProcess.SelectedRows.Count == 0) return;

            RYMethodCollection model = GBase.GProcess.GetModel<RYMethodCollection>(cbProcess.SelectedItem.ToString());
            string funname = dgvAllProcess.SelectedRows[0].Cells[1].Value.ToString();
            RYMethodDelegateItem item= RYMethodDelegateFactory.GetFunc(funname);
            int idx = dgvCurProcess.SelectedRows==null?-1: FindMaxIndex()+ 1;
            if (idx >= dgvCurProcess.Rows.Count) idx = -1;
            RYMethodRecord record = new RYMethodRecord();
            record.Name = item.Name;
            record.Remark = item.Remark;
            record.MethodType = item.MethodType;
            if (item.ParamList.Count==0)
            {           
                record.Param = ""; 
            }
            else
            {
                FParamInput f = new FParamInput();
                f.SetUp(item);
                if(f.ShowDialog()!= DialogResult.OK)
                {
                    return;
                }
                //int a,int b
                //3,4
                record.Param = f.Result;
            }
            model.AddMethod(record, idx);
            model.Save();
            RefreshCurProcess(model);

            if (idx == -1)
            {
                if(model.MethodList.Count>0)
                    idx = model.MethodList.Count - 1;
            }
            dgvCurProcess.ClearSelection();
            if(idx!=-1)
            {
                dgvCurProcess.Rows[idx].Selected = true;
                dgvCurProcess.FirstDisplayedScrollingRowIndex= idx;
            }
        }
        private void dgvAllProcess_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            AddMethodRecord();
        }

        private void cbProcess_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbProcess.SelectedIndex == -1) return;
            RYMethodCollection model = GBase.GProcess.GetModel<RYMethodCollection>(cbProcess.SelectedItem.ToString());
            RefreshCurProcess(model);
        }

        private void btDelProcess_Click(object sender, EventArgs e)
        {
            if (cbProcess.SelectedIndex == -1) return;
            if (!MsgBox.ShowAsk("确定要删除选中的流程吗？")) return;
            string fmodel = cbProcess.SelectedItem.ToString();
            GBase.GProcess.DeleteModel(fmodel);
            cbProcess.Items.Clear();
            dgvCurProcess.Rows.Clear();
            cbProcess.Items.AddRange(GBase.GProcess.ListModel().ToArray());
        }


        void ProcessItemSelect(string name)
        {
            for(int i=0;i<cbProcess.Items.Count;i++)
            {
                if (cbProcess.Items[i].ToString() == name)
                {
                    cbProcess.SelectedIndex = i; 
                    break;
                }

            }
        }
        private void btCopyProcess_Click(object sender, EventArgs e)
        {
            if (cbProcess.SelectedIndex == -1) return;
            string str = "";
            if (!MsgBox.ShowInputString(ref str, true, "请输入复制后的流程名字")) return;
            string newname = str.Trim().ToLower();
            if(!newname.Contains(".proc"))
            {
                newname += ".proc";
            }
            string oldname = cbProcess.SelectedItem.ToString();
            if(GBase.GProcess.Exists(newname))
            {
                MsgBox.ShowWarningTip("新的流程名字已经存在，请换一个");
                return;
            }
            GBase.GProcess.CopyModel<RYMethodCollection>(oldname, newname);
            cbProcess.Items.Clear();
            dgvCurProcess.Rows.Clear();
            cbProcess.Items.AddRange(GBase.GProcess.ListModel().ToArray());
            ProcessItemSelect(newname);
        }

        List<int> GetSelectedIndexs()
        {
            List<int> lst = new List<int>();
            if(dgvCurProcess.SelectedRows==null || dgvCurProcess.SelectedRows.Count==0) return lst;
            for (int i=0;i< dgvCurProcess.SelectedRows.Count;i++)
            {
                lst.Add(dgvCurProcess.SelectedRows[i].Index);
            }
            lst.Sort((x, y) =>
            {
                return x.CompareTo(y); 
            });
            return lst;
        }

        private void btMoveUp_Click(object sender, EventArgs e)
        {
            if (dgvCurProcess.SelectedRows == null || dgvCurProcess.SelectedRows.Count == 0)
            {
                MsgBox.ShowWarningTip("请先选中要操作的行");
                return;
            }
            List<int> lstCur = GetSelectedIndexs();
            if (lstCur.Count == 0) return;
            if (lstCur[0] == 0) return;
            RYMethodCollection model = GBase.GProcess.GetModel<RYMethodCollection>(cbProcess.SelectedItem.ToString());
            model.MoveUp(lstCur);
            RefreshCurProcess(model);
            foreach (int i in lstCur)
            {
                dgvCurProcess.Rows[i - 1].Selected = true;
            }
        }

        private void btMoveDown_Click(object sender, EventArgs e)
        {
            if (dgvCurProcess.SelectedRows == null|| dgvCurProcess.SelectedRows.Count == 0)
            {
                MsgBox.ShowWarningTip("请先选中要操作的行");
                return;
            }
            if (cbProcess.SelectedIndex == -1) return;
            List<int> lstCur = GetSelectedIndexs();
            if (lstCur.Count == 0) return;
            if ((lstCur[lstCur.Count - 1] + 1) == dgvCurProcess.Rows.Count) return;
            RYMethodCollection model = GBase.GProcess.GetModel<RYMethodCollection>(cbProcess.SelectedItem.ToString());
            model.MoveDown(lstCur);
            RefreshCurProcess(model);
            foreach (int i in lstCur)
            {
                dgvCurProcess.Rows[i + 1].Selected = true;
            }
        }

        private void btAddIn_Click(object sender, EventArgs e)
        {
            AddMethodRecord();
        }

        private void btDelCur_Click(object sender, EventArgs e)
        {
            if (dgvCurProcess.SelectedRows == null|| dgvCurProcess.SelectedRows.Count==0)
            {
                MsgBox.ShowWarningTip("请选中要操作的行");
                return;
            }
            if (cbProcess.SelectedIndex == -1) return;
            if (!MsgBox.ShowAsk("确定要删除选中的流程吗？")) return;
            List<int> lstCur = GetSelectedIndexs();
            RYMethodCollection model = GBase.GProcess.GetModel<RYMethodCollection>(cbProcess.SelectedItem.ToString());
            model.Remove(lstCur);
            RefreshCurProcess(model);
        }

        private void dgvCurProcess_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(dgvCurProcess.SelectedRows==null || dgvCurProcess.SelectedRows.Count!=1)
            {
                return;
            }
            if(dgvCurProcess.Rows[e.RowIndex].Cells[1].Style.BackColor==Color.Red)
            {
                MsgBox.ShowWarningTip("该方法不存在，请删除后重新添加");
                return;
            }
            if (cbProcess.SelectedIndex == -1) return;
            RYMethodCollection model = GBase.GProcess.GetModel<RYMethodCollection>(cbProcess.SelectedItem.ToString());
            RYMethodRecord record = model.MethodList[e.RowIndex];
            RYMethodDelegateItem item = RYMethodDelegateFactory.GetFunc(record.Name);
            if (string.IsNullOrEmpty(record.Param)) return;
            FParamInput f = new FParamInput();
            f.SetUp(item, record.Param);
            if (f.ShowDialog() != DialogResult.OK) return;
            record.Param = f.Result;
            model.Save();
            dgvCurProcess.Rows[e.RowIndex].Cells[2].Value = record.Param;
            dgvCurProcess.Rows[e.RowIndex].Cells[2].Style.BackColor = Color.White;
        }

        protected ContextMenuStrip GetContextMenuTrip()
        {
            ContextMenuStrip menu = new ContextMenuStrip();
            Image imgcp = Properties.Resources.copy_64px;
            Image imgcut = Properties.Resources.cut_64px;
            Image imgpaste = Properties.Resources.paste_64px;
            if (dgvCurProcess.SelectedRows.Count > 0)
            {
                menu.Items.Add("复制", imgcp, Copy);
                menu.Items.Add("剪切", imgcut, Cut);
                if (Clipboard.GetData("我的Task数据") != null)
                {
                    menu.Items.Add("粘贴", imgpaste, Paste);
                }
            }


            return menu;
        }


        private void Copy(object sender, EventArgs e)
        {
            List<int> lstSel = GetSelectedIndexs();
            if (cbProcess.SelectedIndex == -1) return;
            if (lstSel.Count < 1) return;
            RYMethodCollection model = GBase.GProcess.GetModel<RYMethodCollection>(cbProcess.SelectedItem.ToString());
            List<RYMethodRecord> lstSelItem = new List<RYMethodRecord>();
            foreach (var k in lstSel)
            {
                lstSelItem.Add(model.MethodList[k].ToCopy());
            }
            Clipboard.SetData("我的Task数据", lstSelItem);
        }
        private void Cut(object sender, EventArgs e)
        {
            List<int> lstSel = GetSelectedIndexs();
            if (lstSel.Count < 1) return;
            if (cbProcess.SelectedIndex == -1) return;
            RYMethodCollection model = GBase.GProcess.GetModel<RYMethodCollection>(cbProcess.SelectedItem.ToString());
            List<RYMethodRecord> lstSelItem = new List<RYMethodRecord>();
            foreach (var k in lstSel)
            {
                lstSelItem.Add(model.MethodList[k].ToCopy());
            }
            Clipboard.SetData("我的Task数据", lstSelItem);
            model.MethodList.RemoveRange(lstSel[0], lstSel.Count);
            model.Save();
            RefreshCurProcess(model);
        }
        private void Paste(object sender, EventArgs e)
        {
            if (cbProcess.SelectedIndex == -1)
            {
                MsgBox.ShowWarningTip("请选中对应流程模型文件");
                return;
            }
            RYMethodCollection model = GBase.GProcess.GetModel<RYMethodCollection>(cbProcess.SelectedItem.ToString());
            int idx = dgvCurProcess.SelectedRows == null ? -1 : FindMaxIndex() + 1;
            if (idx >= dgvCurProcess.Rows.Count) idx = -1;

            List<RYMethodRecord> lstItem = Clipboard.GetData("我的Task数据") as List<RYMethodRecord>;
            if (lstItem == null)
            {
                return;
            }
            List<RYMethodRecord> lstCopy= new List<RYMethodRecord>();
            foreach(RYMethodRecord mr in lstItem)
            {
                lstCopy.Add(mr.ToCopy());
            }
            if (idx==-1)
            {
                model.MethodList.AddRange(lstCopy);
                //要添加到最后
            }
            else
            {
                model.MethodList.InsertRange(idx, lstCopy);
            }
            model.Save();
            RefreshCurProcess(model);
        }
        private void dgvCurProcess_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(e.Button==MouseButtons.Right&&dgvCurProcess.SelectedRows!=null&&dgvCurProcess.SelectedRows.Count>0)
            {
                if(e.RowIndex>=0)
                {
                    ContextMenuStrip menu = GetContextMenuTrip();
                    if(menu.Items.Count>0)
                    {
                        menu.Show(MousePosition);
                    }
                }
            }
        }
    }
}
