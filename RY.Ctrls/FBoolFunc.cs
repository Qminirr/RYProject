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
    public partial class FBoolFunc : UIForm
    {
        public FBoolFunc()
        {
            InitializeComponent();
            SetUp();
            
        }
        private void SetUp()
        {
            foreach(eRYBoolDelegateType e in Enum.GetValues(typeof(eRYBoolDelegateType)))
            {
                List<RYBoolDelegateItem> lst = RYBoolDelegateFactory.GetFuncs(e);
                if (lst.Count < 1) continue;
                TabPage tab = new TabPage(e.ToString());
                tab.Name = e.ToString();
                Panel pnl = new Panel();
                tabCtrl.TabPages.Add(tab);
                tab.Controls.Add(pnl);
                pnl.Dock = DockStyle.Fill;
                pnl.AutoScroll = true;
                foreach(var item in lst)
                {
                    URYBoolDelegate ctrl=new URYBoolDelegate();
                    ctrl.SetUp(item);
                    pnl.Controls.Add(ctrl);
                    ctrl.Dock = DockStyle.Top;
                }
            }
        }

        private void FBoolFunc_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }
    }
}
