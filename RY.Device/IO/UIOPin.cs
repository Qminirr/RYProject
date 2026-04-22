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
    public partial class UIOPin : UserControl
    {
        public UIOPin()
        {
            InitializeComponent();
        }

        IOPin _pin = null;
        bool _bIn = false;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pin">IOPin结构</param>
        /// <param name="bIn">是否是输入Pin</param>
        public void SetUp(IOPin pin,bool bIn=false)
        {
            _pin=pin;
            _bIn=bIn;
            lbInfo.Text = _pin.ToString();
            if(bIn)
            {
                btSW.Enabled = false;
            }
            else
            {
                btSW.Enabled = true;
            }
        }


        public IOPin Pin
        {
            get { return _pin; }
            private set { _pin = value; }
        }

        /// <summary>
        /// 是否是输入Pin
        /// </summary>
        public bool IsInPin
        {
            get { return _bIn; }
        }

        public void SetState(bool bOn)
        {
            if (InvokeRequired && !IsDisposed)
            {
                Invoke(new Action(() =>
                {
                    SetState(bOn);
                }));
            }
            else
            {
                btSW.Active = bOn;
            }
        }

        /// <summary>
        /// 点击按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btSW_Click(object sender, EventArgs e)
        {
            if (IsInPin) return;
            IOCtrl.SetOutPin(_pin.Name,btSW.Active?eSwitch.On:eSwitch.Off);
        }

        /// <summary>
        /// 脉冲到来
        /// </summary>
        public void Pulse()
        {
            if(InvokeRequired&&!IsDisposed)
            {
                Invoke(new Action(() =>
                {
                    Pulse();
                }));
            }
            else
            {
                eSwitch sw = eSwitch.Unknown;
                if (IsInPin)
                {
                    sw = IOCtrl.GetInPin(_pin.Name);
                }
                else
                {
                    sw = IOCtrl.GetOutPin(_pin.Name);
                    //设置按钮状态
                    if (sw == eSwitch.Unknown && btSW.Enabled)
                    {
                        btSW.Enabled = false;
                        return;
                    }
                    else
                    {
                        if (!btSW.Enabled) btSW.Enabled = true;
                    }

                }
                
                bool bAct=sw==eSwitch.On?true:false;
                if(btSW.Active!=bAct) btSW.Active=bAct;
            }
        }
    }
}
