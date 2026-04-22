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
    public partial class FMotionDistance : UIForm
    {
        public FMotionDistance()
        {
            InitializeComponent();
        }

        public double Distance
        { get; set; } = 0.1;

        private void btn1_Click(object sender, EventArgs e)
        {
            UIButton bt = sender as UIButton;
            if (bt == null) return;
            string txt = bt.Text;
            double d = 0.0;
            if(!double.TryParse(txt,out d))
            {
                MsgBox.ShowWarningTip("解析按钮成双精度数据失败");
                return;
            }
            Distance = d;
            this.Close();
        }

        private void btUseHand_Click(object sender, EventArgs e)
        {
            double d = tbVal.DoubleValue;
            if(d<=0.0)
            {
                MsgBox.ShowWarningTip("指定的位移量必须大于0");
                return;
            }
            Distance = d;
            this.Close();
        }
    }
}
