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

namespace RY.Device
{
    public partial class UAxisCtrl : UIPage,IPulseConsume,IUIControl
    {
        public UAxisCtrl()
        {
            InitializeComponent();
        }

        AxisBase _ab = null;

        public void SetUp(AxisBase ab)
        {
            _ab = ab;
            axisCtrl1.SetUp(_ab);
        }
        public int TimeTick { get; set; } = 200;

        public void PulseComing(object sender, EventArgs e)
        {
            if (InvokeRequired && !IsDisposed)
            {
                Invoke(new Action(() =>
                {
                    PulseComing(sender, e);
                }));
            }
            else
            {
                axisCtrl1.PulseComing(sender, e);
            }
                
        }


        private void SetButtonText(string txt)
        {
            if(InvokeRequired&&!IsDisposed)
            {
                Invoke(new Action(() =>
                {
                    SetButtonText(txt);
                }));
            }
            else
            {
                btStartLoop.Text = txt;
            }
        }


        bool _isLoop = false;
        private void StartLoop(double pstart,double pend,double dwait)
        {
            SetButtonText("停止运动");
            while (_isLoop)
            {
                if (!_isLoop) break ;
                if (!_ab.IsAxisOK()) break;
                if (!_ab.MoveTo(pstart, 0)) break;
                if (!WaitTimer.Wait(50000, () =>
                {
                    if (!_isLoop) return true;
                    //轴从下指令开始运动需要等待一小段时间
                    WaitTimer.Sleep(50);
                    if (!_isLoop) return true;
                    if (_ab.IsMoving()) return false;
                    return true;
                })) break;
                if(!_isLoop) break;
                //等待设定时间
                WaitTimer.Wait(dwait, () =>
                {
                    if (!_isLoop) return true;
                    return false;
                });
                WaitTimer.Sleep(dwait);
                if (!_ab.MoveTo(pend, 0)) break;
                if (!WaitTimer.Wait(50000, () =>
                {
                    if (!_isLoop) return true;
                    //轴从下指令开始运动需要等待一小段时间
                    WaitTimer.Sleep(50);
                    if (!_isLoop) return true;
                    if (_ab.IsMoving()) return false;
                    
                    return true;
                })) break;
                if (!_isLoop) break;
                //等待设定时间
                WaitTimer.Wait(dwait, () =>
                {
                    if (!_isLoop) return true;
                    return false;
                });
            }
            SetButtonText("开始循环运动");
        }
        private void btStartLoop_Click(object sender, EventArgs e)
        {
            if (btStartLoop.Text.Contains("开始"))
            {
                if (_ab == null||!_ab.IsAxisOK())
                {
                    MsgBox.ShowWarningTip("轴状态不可用");
                    return;
                }
                double posstart = tbStart.DoubleValue;
                double posend = tbEnd.DoubleValue;
                if(posstart<_ab.MinPos || posstart>_ab.MaxPos)
                {
                    MsgBox.ShowWarningTip("开始位置设置超过软限位");
                    return;
                }
                if (posend < _ab.MinPos || posend > _ab.MaxPos)
                {
                    MsgBox.ShowWarningTip("结束位置设置超过软限位");
                    return;
                }
                double dwait=tbWait.DoubleValue;
                if(dwait<=0)
                {
                    MsgBox.ShowWarningTip("等待时间设置不正确");
                    return;
                }
                if (!MsgBox.ShowAsk("确定循环运动吗？请确认安全")) return;
                Task.Run(new Action(() =>
                {
                    _isLoop = true;
                    StartLoop(posstart,posend,dwait);
                }));
            }
            else
            {
                _isLoop = false;
            }
        }
        public void UIClose()
        {
            if (_isLoop)
            {
                _isLoop = false;
                WaitTimer.Sleep(500);
            }
        }
    }
}
