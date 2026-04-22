using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SunnyUI;
using RY.Base;
namespace RY.Device
{
    public partial class UAxisGroupEditor : UserControl, IRYModalEditor
    {
        public UAxisGroupEditor()
        {
            InitializeComponent();
        }

        AxisPosGroup _agp = null;
        List<UAxisPos> _lst = new List<UAxisPos>();
        public void SetUp(AxisPosGroup gp)
        {
            _agp = gp;
            if(_agp==null)
            {
                _agp = new AxisPosGroup();
            }
            
            BuildUI();
            if(GBase.UserLevel!=eUserLevel.Administrator)
            {
                cbAxis.Visible = false;
                lsbCur.Visible = false;
                btnAdd.Visible = false;
                btnDel.Visible = false;
                rbMoveSameTime.Visible = false;
                rbZFirst.Visible = false;
                rbZLast.Visible = false;
            }
            else
            {
                List<string> lstAxisNames = DeviceFactory.GetAxisNames();
                cbAxis.Items.Clear();
                cbAxis.Items.AddRange(lstAxisNames.ToArray());
                switch(_agp.MoveType)
                {
                    case eAxisZMoveType.同时移动:
                        rbMoveSameTime.Checked = true;
                        break;
                    case eAxisZMoveType.先移动Z:
                        rbZFirst.Checked = true;
                        break;
                    default:
                        rbZLast.Checked = true;
                        break;
                }
            }
            

        }

        void BuildUI()
        {
            _lst.Clear();
            panelCtrl.Controls.Clear();   
            foreach(eAxis k in _agp.GetAxisTypeList())
            {
                UAxisPos u = new UAxisPos();
                u.SetUp(_agp,k);
                u.Parent = panelCtrl;
                panelCtrl.Controls.Add(u);
                u.Dock = DockStyle.Top;
                _lst.Add(u);
            }
            UILine line = new UILine();
            line.Text = _agp.MoveType.ToString();
            line.StyleCustomMode = true;
            line.FillColor = Color.White;
            panelCtrl.Controls.Add(line);
            line.Dock = DockStyle.Bottom;
            UISymbolButton btnRead = new UISymbolButton();
            btnRead.Text = "读取全部";
            btnRead.Symbol = 61470;
            panelCtrl.Controls.Add(btnRead);
            btnRead.Dock = DockStyle.Bottom;
            btnRead.Click += btnRead_Click;
            //有Z轴的话会多两个工程
            if(!UAxisPos.DisableMove)
            {
                UISymbolButton btnMove = new UISymbolButton();
                btnMove.Text = _agp.MoveType.ToString();
                btnMove.Symbol = 61515;
                panelCtrl.Controls.Add(btnMove);
                btnMove.Dock = DockStyle.Bottom;
                btnMove.Click += btnMove_Click;
            }



            UISymbolButton btnStepMotion = new UISymbolButton();
            btnStepMotion.Text = "单移";
            btnStepMotion.Symbol = 61531;
            panelCtrl.Controls.Add(btnStepMotion);
            btnStepMotion.Dock = DockStyle.Bottom;
            btnStepMotion.Click += btnStepMotion_Click;
            UISymbolButton btnCopy = new UISymbolButton();
            btnCopy.Text = "复制";
            btnCopy.Symbol = 261637;
            panelCtrl.Controls.Add(btnCopy);
            btnCopy.Dock = DockStyle.Bottom;
            btnCopy.Click += BtnCopy_Click;

            UISymbolButton btnPaste = new UISymbolButton();
            btnPaste.Text = "粘贴";
            btnPaste.Symbol = 361674;
            panelCtrl.Controls.Add(btnPaste);
            btnPaste.Dock = DockStyle.Bottom;
            btnPaste.Click += BtnPaste_Click;

        }


        private void btnStepMotion_Click(object sender, EventArgs e)
        {
            if (_agp == null) return;
            List<string> lst = _agp.GetAxisNameList();
            string name = "";
            if (!MsgBox.ShowSelectString(ref name, lst, "请选择要操作的轴", "通过键盘单独控制轴移动")) return;
            FAxisStepMotion f = new FAxisStepMotion();
            f.SetUp(name);
            f.Show();
        }

        private void BtnPaste_Click(object sender, EventArgs e)
        {
            DataObject obj = Clipboard.GetDataObject() as DataObject;
            if (obj == null)
            {
                MsgBox.ShowWarningTip("剪贴板中无数据");
                return;
            }
            AxisPosGroup l = obj.GetData("AxisPosGroup") as AxisPosGroup;
            if (l == null)
            {
                MsgBox.ShowWarningTip("剪贴板中数据不正确");
                return;
            }
            _agp = l;
            BuildUI();
        }

        private void BtnCopy_Click(object sender, EventArgs e)
        {
            DataObject dataobj = new DataObject();
            dataobj.SetData("AxisPosGroup", _agp.GetCopy());
            Clipboard.SetDataObject(dataobj, true);
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            string msg = "正在" + _agp.MoveType.ToString() + "......";
            MsgBox.ShowWait(msg);
            bool b =_agp.Move(10000);
            if(!b)
            {
                MsgBox.HideWait();
                MsgBox.ShowError("移动失败！");
            }
            MsgBox.HideWait();
        }
        
        private void btnRead_Click(object sender, EventArgs e)
        {
            bool bRet = true;
            foreach(UAxisPos u in _lst)
            {
                if(!u.ReadPos())
                {
                    bRet = false;
                }
            }
            if(bRet)
            {
                MsgBox.ShowSuccessTip("读取成功！");

            }
            else
            {
                MsgBox.ShowWarningTip("读取失败！");
            }
        }

        private void tabCtrl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabCtrl.SelectedIndex == -1) return;
            if(tabCtrl.SelectedIndex==0)
            {
                BuildUI();
            }
            else
            {
                lsbCur.Items.Clear();
                lsbCur.Items.AddRange(_agp.GetAxisNameList().ToArray());
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cbAxis.SelectedItem ==null)
            {
                MsgBox.ShowWarningTip("请先选中要添加的轴");
                return;
            }
            string name = cbAxis.SelectedItem.ToString();
            if(_agp.Exist(name))
            {
                MsgBox.ShowErrorTip("已经存在该轴");
                return;
            }
            AxisBase ab = DeviceFactory.GetDevice<AxisBase>(name);
            if(_agp.Exist(ab.AxisType))
            {
                MsgBox.ShowErrorTip("已经存在该类型的轴，不允许在添加");
                return;
            }
            AxisPos ap = new AxisPos();
            ap.Axis = name;
            _agp[ab.AxisType] = ap;
            lsbCur.Items.Clear();
            lsbCur.Items.AddRange(_agp.GetAxisNameList().ToArray());
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if(lsbCur.SelectedItems==null)
            {
                MsgBox.ShowWarningTip("请先选中要删除的轴");
                return;
            }
            if (!MsgBox.ShowAsk("确定要删除选中的轴吗？")) return;
            
            foreach (var k in lsbCur.SelectedItems)
            {
                _agp.RemoveOwn(k.ToString());
            }
            
            lsbCur.Items.Clear();
            lsbCur.Items.AddRange(_agp.GetAxisNameList().ToArray());
        }

        public void SetValue(object obj, object instance)
        {
            if(obj is AxisPosGroup||obj==null)
            {
                if(obj==null)
                {
                    SetUp(new AxisPosGroup());
                }
                else
                {
                    SetUp(obj as AxisPosGroup);
                }
                
            }
            
        }

        public object GetValue()
        {
            return _agp.GetCopy();
        }

        private void rbMoveSameTime_CheckedChanged(object sender, EventArgs e)
        {
            if(rbMoveSameTime.Checked)
            {
                _agp.MoveType = eAxisZMoveType.同时移动;
                if(_agp.Exist(eAxis.Z))
                {
                    MsgBox.ShowWarning("该位置包含Z轴，设置成同时移动可能存在风险");
                    UserLog.AddWarnMsg("该位置包含Z轴，设置成同时移动可能存在风险");
                }
            }
        }

        private void rbZFirst_CheckedChanged(object sender, EventArgs e)
        {
            if (rbZFirst.Checked)
            {
                _agp.MoveType = eAxisZMoveType.先移动Z;
            }
        }

        private void rbZLast_CheckedChanged(object sender, EventArgs e)
        {
            if (rbZLast.Checked)
            {
                _agp.MoveType = eAxisZMoveType.后移动Z;
            }
        }
    }
}
