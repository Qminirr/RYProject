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
    public partial class CfgEditorPage : UIPage
    {
        public CfgEditorPage()
        {
            InitializeComponent();
        }

        public string Caption
        {
            get
            {
                return uiCaption.Text;
            }
            set
            {
                uiCaption.Text = value;
            }
        }

        public void SetObject(ConfigBase cb)
        {
            pg.SelectedObject = cb;
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            ConfigBase cb=pg.SelectedObject as ConfigBase;
            if (cb == null)
            {
                MsgBox.ShowWarning("未取得对象");
                return;
            }
            cb.Save();
        }
    }
}
