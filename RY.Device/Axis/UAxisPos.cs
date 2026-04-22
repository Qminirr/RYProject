using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RY.Base;
namespace RY.Device
{
    public partial class UAxisPos : UserControl
    {
        public UAxisPos()
        {
            InitializeComponent();
        }

        public static bool DisableMove
        { get; set; } = false;

        AxisBase _ab = null;
        AxisPos _ap = null;
        public void SetUp(AxisPosGroup gp,eAxis axtype,bool bMoveOnly=false)
        {
            _ap = gp.GetPosOwn(axtype);
            if(_ap==null)
            {
                throw new Exception("空值");
            }
            lbName.Text = _ap.Axis;
            lbVal.Text = _ap.Pos.ToString("f3");
            _ab = DeviceFactory.GetDevice<AxisBase>(_ap.Axis);
            if(bMoveOnly)
            {
                btnRead.Visible = false;
            }
            if(DisableMove)
            {
                btnMove.Visible = false;
            }
        }

        public void SetUp(AxisPos ap,bool bMoveOnly=false)
        {
            _ap = ap;
            if (_ap == null)
            {
                throw new Exception("空值");
            }
            lbName.Text = _ap.Axis;
            lbVal.Text = _ap.Pos.ToString("f3");
            _ab = DeviceFactory.GetDevice<AxisBase>(_ap.Axis);
            if (bMoveOnly)
            {
                btnRead.Visible = false;
            }
            if (DisableMove)
            {
                btnMove.Visible = false;
            }
        }
        public bool MoveTo()
        {
            if(_ab==null)
            {
                UserLog.AddErrorMsg(_ap.Axis+"轴不存在！");
                return false;
            }
            if (!_ab.IsAxisOK())
            {
                UserLog.AddErrorMsg(_ap.Axis+"轴目前状态不可用！");
                return false;
            }
            return _ab.MoveTo(_ap.Pos);
        }

        void RefreshPos()
        {
            if(InvokeRequired)
            {
                Invoke(new Action(() =>
                {
                    RefreshPos();
                }));
            }
            else
            {
                lbVal.Text = _ap.Pos.ToString("f3");
            }
        }

        public bool ReadPos()
        {
           
            if (_ap == null)
            {
                UserLog.AddErrorMsg("轴赋值为空");
                return false;
            }
            if (_ab == null)
            {
                UserLog.AddErrorMsg(_ap.Axis + "轴不存在！");
                return false;
            }
            if (!_ab.IsAxisOK())
            {
                UserLog.AddErrorMsg(_ap.Axis + "轴目前状态不可用！");
                return false;
            }
            _ap.Pos = _ab.GetPos();
            RefreshPos();
            return true;
        }


        private void btnMove_Click(object sender, EventArgs e)
        {
            if(!MoveTo())
            {
                MsgBox.ShowWarningTip("移动轴失败！");
            }
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            if(!ReadPos())
            {
                MsgBox.ShowWarningTip("读取位置失败！");
            }
        }

        private void lbPos_DoubleClick(object sender, EventArgs e)
        {
            if (GBase.UserLevel != eUserLevel.Administrator) return;
            double d = _ap.Pos;
            if (!MsgBox.ShowInputDouble(ref d, 3, true, "请输入位置")) return;
            _ap.Pos = d;
            RefreshPos();
        }
    }
}
