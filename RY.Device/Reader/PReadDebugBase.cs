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
    public partial class PReadDebugBase : UIPage,IPulseConsume
    {
        public PReadDebugBase()
        {
            InitializeComponent();
        }

        ReaderBase _reader = null;

        public int TimeTick { get; set; } = 200;

        public void SetUp(ReaderBase reader)
        {
            _reader= reader;
            tbCmd.Text = _reader.StartCmd;
        }

        private void btSendCmd_Click(object sender, EventArgs e)
        {
            if(_reader==null)
            {
                MsgBox.ShowWarningTip("未赋值设备");
                return;
            }
            string cmd = tbCmd.Text.Trim() + (_reader.IsEndCmdPatternWithEnter ? "\n" : "");
            //直接发送命令，不等待
            _reader.ReadOne(cmd, 0);
        }

        public void PulseComing(object sender, EventArgs e)
        {
            if(InvokeRequired&&!IsDisposed)
            {
                Invoke(new Action(() =>
                {
                    PulseComing(sender, e);
                }));
            }
            else
            {
                lbInfo.Text = _reader.DataString;
            }
        }

        private void btRead_Click(object sender, EventArgs e)
        {
            if (_reader == null)
            {
                MsgBox.ShowWarningTip("未赋值设备");
                return;
            }
            _reader.ReadOne(0);
        }

        private void btStop_Click(object sender, EventArgs e)
        {
            if (_reader == null)
            {
                MsgBox.ShowWarningTip("未赋值设备");
                return;
            }
            _reader.StopRead();
        }
    }
}
