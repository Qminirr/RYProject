using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SunnyUI;
using RY.Base;
namespace RY.Device
{
    public partial class FAxisStepMotion : UIForm
    {

        double curSpan = 0.3;
        public FAxisStepMotion()
        {
            InitializeComponent();
        }

        string _axisName = "";
        AxisBase _ab = null;
        bool _isInit = false;
        public void SetUp(string axisName)
        {
            _ab=DeviceFactory.GetAxis(axisName);
            _axisName=axisName;
            if(_ab==null)
            {
                lbCurAxis.Text = "无法获取轴" + axisName;
                lbCurAxis.ForeColor = Color.Red;
                return;
            }
            if(!_ab.IsAxisOK())
            {
                lbCurAxis.Text = "轴" + axisName+"目前状态不可用";
                lbCurAxis.ForeColor = Color.Red;
                return;
            }
            lbCurAxis.Text =_ab.GetPos().ToString("f3");
            this.Text = "轴单步移动-" + axisName;
            _isInit = true;
        }
        private void lbSpan_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            FMotionDistance f = new FMotionDistance();
            f.ShowDialog();
            curSpan = f.Distance;
            lbCurSpan.Text = "当前移动量：" + curSpan.ToString("f3");
        }

     

        void AxisDec()
        {
            if (!_ab.IsAxisOK()) return;
            if (_ab.IsMoving())
            {
                lbMsg.Text = _ab.Name + "正在移动中，请稍后";
                return;
            }
            double pos = _ab.GetPos();
            double d = curSpan * -1.0;
            pos += d;
            _ab.MoveTo(pos, 0);
            lbCurAxis.Text = pos.ToString("f3");
            lbMsg.Text = _ab.Name + "移动至" + pos.ToString("f3");
        }
        void AxisAdd()
        {
            if (!_ab.IsAxisOK()) return;
            if (_ab.IsMoving())
            {
                lbMsg.Text = _ab.Name + "正在移动中，请稍后";
                return;
            }
            double pos = _ab.GetPos();
            double d = curSpan;
            pos += d;
            _ab.MoveTo(pos, 0);
            lbCurAxis.Text = pos.ToString("f3");
            lbMsg.Text = _ab.Name + "移动至" + pos.ToString("f3");
        }
        private void FAxisStepMotion_KeyDown(object sender, KeyEventArgs e)
        {
            
            if(e.KeyCode==Keys.Left || e.KeyCode==Keys.Down)
            {
                AxisDec();
                return;
            }
            if(e.KeyCode==Keys.Right|| e.KeyCode==Keys.Up)
            {
                AxisAdd();
                return;
            }
        }

        private void FAxisStepMotion_Activated(object sender, EventArgs e)
        {
            if (!_isInit) return;
            this.Text = "轴单步移动-"+_axisName+"(激活)";
        }

        private void FAxisStepMotion_Deactivate(object sender, EventArgs e)
        {
            if (!_isInit) return;
            this.Text = "轴单步移动-" + _axisName + "(未激活)";
        }

        
    }
}
