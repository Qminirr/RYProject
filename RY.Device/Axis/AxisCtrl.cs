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
using System.Threading;
using RY.Device;

namespace RY.Device
{
    public partial class AxisCtrl : UserControl,IPulseConsume
    {
        public AxisCtrl()
        {
            InitializeComponent();
            _isInited = false;
        }
        AxisBase Axis = null;

        bool _isInited = false;

        public void SetUp(AxisBase ax)
        {
            _isInited = false;
            Axis = ax;
            lbCaption.Text = Axis.Name;
            _isInited = true;
        }

        public AxisBase GetAxis()
        {
            return Axis;
        }
        public int TimeTick { get; set; } = 1000;
        public void PulseComing(object sender, EventArgs e)
        {
            if(InvokeRequired)
            {
                Invoke(new Action(() =>
                {
                    PulseComing(sender,e);
                }));
            }
            else
            {
                if (!_isInited || Axis == null||!Axis.IsOpen) return;
                double pos = Axis.GetCommandPos();
                lbCmdPos.Text = pos.ToString("f4");
                lbEncoderPos.Text = Axis.GetEncoderPos().ToString("f4");
                
                lbSpeed.Text = Axis.GetSpeed().ToString("f3");
                var s=Axis.GetAxisIO();

                ledPositive.State = s[eAxisStatus.正限位];
                ledNeg.State = s[eAxisStatus.负限位];
                ledAlarm.State = s[eAxisStatus.报警];
                ledPrimary.State = s[eAxisStatus.原点] ;
                ledPower.State = Axis.IsServoOn();
                ledMoving.State = Axis.IsMoving();
                ledIsHomed.State = Axis.IsHome;
            }
            
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (Axis == null || !Axis.IsValid) return;
            Axis.Stop();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (Axis == null || !Axis.IsValid || Axis.IsMoving() || Axis.IsAlarm())
            {
                MsgBox.ShowWarningTip("该轴状态不可用！！");
                return;
            }
            Task t = Task.Run(() => {
                MsgBox.ShowWait(Axis.Name + "正在回原，请稍后");
                if(!Axis.Home())
                {
                    Axis.Stop();
                };
                MsgBox.HideWait();
            });
        }


        private void btnJogNeg_MouseDown(object sender, MouseEventArgs e)
        {
            if (Axis == null) return;
            if (!Axis.IsOpen || Axis.IsMoving())
            {
                MsgBox.ShowWarningTip("轴不可用！");
                return;
            }
            Axis.ChangeSpeed(eAxisSpeedMode.JogOrDebug);
            Axis.JogMove(false);
        }

        private void btnJogNeg_MouseUp(object sender, MouseEventArgs e)
        {
            if (Axis == null) return;
            if (!Axis.IsOpen)
            {
                MsgBox.ShowWarningTip("轴不可用！");
                return;
            }
            Axis.Stop();
            Axis.WaitStop();
            Axis.ChangeSpeed(eAxisSpeedMode.JogOrDebug);
        }

        private void btnJogPos_MouseDown(object sender, MouseEventArgs e)
        {
            if (Axis == null) return;
            if (!Axis.IsOpen || Axis.IsMoving())
            {
                MsgBox.ShowWarningTip("轴不可用！");
                return;
            }
            Axis.ChangeSpeed(eAxisSpeedMode.JogOrDebug);
            Axis.JogMove();
        }

        private void btnJogPos_MouseUp(object sender, MouseEventArgs e)
        {
            if (Axis == null) return;
            if (!Axis.IsOpen)
            {
                MsgBox.ShowWarningTip("轴不可用！");
                return;
            }
            Axis.Stop();
            Axis.WaitStop();
        }

        private void ledPower_Click(object sender, EventArgs e)
        {
            if (Axis == null || !Axis.IsValid) return;
            if (Axis.IsServoOn())
            {
                Axis.Servo(false);
            }
            else
            {
                Axis.Servo(true);
            }
        }

        private void ledAlarm_Click(object sender, EventArgs e)
        {
            if (Axis == null) return;
            if (Axis.ClearAlarm())
            {
                MsgBox.ShowSuccessTip("清除驱动器报警成功！");

            }
            else
            {
                MsgBox.ShowErrorTip("清除报警失败!");
            }
        }


        private void btPosDec_Click(object sender, EventArgs e)
        {
            if (Axis == null) return;
            if (!Axis.IsOpen || Axis.IsMoving())
            {
                MsgBox.ShowWarning("轴不可用！");
                return;
            }
            double cur = Axis.GetPos();
            double dspan = tbSpan.DoubleValue;
            if(!Axis.MoveTo(cur+dspan * -1.0))
            {
                MsgBox.ShowWarningTip("移动失败");
            }
        }

        private void btPosAdd_Click(object sender, EventArgs e)
        {
            if (Axis == null) return;
            if (!Axis.IsOpen || Axis.IsMoving())
            {
                MsgBox.ShowWarning("轴不可用！");
                return;
            }
            double cur = Axis.GetPos();
            double dspan = tbSpan.DoubleValue;
            if (!Axis.MoveTo(cur+dspan))
            {
                MsgBox.ShowWarningTip("移动失败");
            }
        }

        private void lbSpeed_DoubleClick(object sender, EventArgs e)
        {
            if (Axis == null) return;
            if (!Axis.IsOpen || Axis.IsMoving())
            {
                MsgBox.ShowWarning("轴不可用！");
                return;
            }
            double cur = Axis.GetSpeed();
            if (!MsgBox.ShowInputDouble(ref cur, 0, true, "请输入想要设置的速度")) return;
            Axis.SetUserSpeed(cur);

        }
    }
}
