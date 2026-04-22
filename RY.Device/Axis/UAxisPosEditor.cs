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
    public partial class UAxisPosEditor : UserControl, IRYModalEditor
    {
        public UAxisPosEditor()
        {
            InitializeComponent();
        }

        AxisPos _ap = null;
        public void SetUp(AxisPos ap)
        {
            _ap = ap;
            if(_ap==null)
            {
                _ap = new AxisPos();
            }
            
            BuildUI();
            if(GBase.UserLevel!=eUserLevel.Administrator)
            {
                cbAxis.Visible = false;
                lsbCur.Visible = false;
                btnAdd.Visible = false;
                btnDel.Visible = false;
                
            }
            else
            {
                List<string> lstAxisNames = DeviceFactory.GetAxisNames();
                cbAxis.Items.Clear();
                cbAxis.Items.AddRange(lstAxisNames.ToArray());
                
            }
            

        }

        void BuildUI()
        {   
            if(_ap==null ||string.IsNullOrEmpty(_ap.Axis))
            {
                btRead.Visible = false;
                btMove.Visible = false;
                btnStepMotion.Visible = false;
                return;
            }
            lbName.Text = _ap.Axis;
            lbPos.Text = _ap.Pos.ToString("f3");
            btRead.Visible = true;
            if(UAxisPos.DisableMove)
            {
                btMove.Visible = false;
            }
            else
            {
                btMove.Visible = true;
            }

        }
        private void btnMove_Click(object sender, EventArgs e)
        {
            if (_ap == null || string.IsNullOrEmpty(_ap.Axis))
            {
                MsgBox.ShowWarningTip("轴设置不正确");
                return;
            }
            string msg = "正在" + _ap.Axis + "......";
            MsgBox.ShowWait(msg);
            bool b = false;
            b = _ap.Move();
            if(!b)
            {
                MsgBox.HideWait();
                MsgBox.ShowError("移动失败！");
            }
            MsgBox.HideWait();
        }
       
        private void btnRead_Click(object sender, EventArgs e)
        {
            if (_ap == null || string.IsNullOrEmpty(_ap.Axis))
            {
                MsgBox.ShowWarningTip("轴设置不正确");
                return;
            }

            bool bRet =_ap.RefreshOwnPos();
            if(bRet)
            {
                lbPos.Text = _ap.Pos.ToString("f3");
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
                if (_ap == null || string.IsNullOrEmpty(_ap.Axis))
                {
                    MsgBox.ShowWarningTip("请先编辑轴信息");
                    return;
                }
                lsbCur.Items.Clear();
                lsbCur.Items.Add(_ap.Axis);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(lsbCur.Items.Count>0)
            {
                MsgBox.ShowWarningTip("请先删除轴，再添加");
                return;
            }
            if(cbAxis.SelectedItem==null)
            {
                MsgBox.ShowWarningTip("请先选择轴");
                return;
            }
            string name = cbAxis.SelectedItem.ToString();
            if (_ap == null) _ap = new AxisPos();
            AxisBase ab = DeviceFactory.GetDevice<AxisBase>(name);
            _ap.Axis = name;
            lsbCur.Items.Clear();
            lsbCur.Items.Add(_ap.Axis.ToString());
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if(lsbCur.SelectedIndex==-1)
            {
                MsgBox.ShowWarningTip("请先选中要删除的轴");
                return;
            }
            if (!MsgBox.ShowAsk("确定要删除选中的轴吗？")) return;
            if (_ap == null) _ap = new AxisPos();
            lsbCur.Items.Clear();
            _ap.Axis = "";
        }

        public void SetValue(object obj, object instance)
        {
            if(obj is AxisPos||obj==null)
            {
                if(obj==null)
                {
                    SetUp(new AxisPos());
                }
                else
                {
                    SetUp(obj as AxisPos);
                }
                
            }
            
        }

        public object GetValue()
        {
            return _ap.GetCopy();
        }

        private void lbPos_DoubleClick(object sender, EventArgs e)
        {
            if (_ap == null) return;
            if (GBase.UserLevel != eUserLevel.Administrator) return;
            double d = _ap.Pos;
            if (!MsgBox.ShowInputDouble(ref d, 3, true, "请输入位置数据")) return;
            _ap.Pos = d;
            lbPos.Text = d.ToString("f3");
        }

        private void btnStepMotion_Click(object sender, EventArgs e)
        {
            if (_ap==null)
            {
                return;
            }
            FAxisStepMotion f = new FAxisStepMotion();
            f.SetUp(_ap.Axis);
            f.Show();
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            DataObject dataobj = new DataObject();
            dataobj.SetData("AxisPos", _ap.GetCopy());
            Clipboard.SetDataObject(dataobj, true);
        }

        private void btnPaste_Click(object sender, EventArgs e)
        {
            DataObject obj = Clipboard.GetDataObject() as DataObject;
            if (obj == null)
            {
                MsgBox.ShowWarningTip("剪贴板中无数据");
                return;
            }
            AxisPos l = obj.GetData("AxisPos") as AxisPos;
            if (l == null)
            {
                MsgBox.ShowWarningTip("剪贴板中数据不正确");
                return;
            }
            _ap = l;
            BuildUI();
        }
    }
}
