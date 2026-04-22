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
namespace RY.Device
{
    public partial class PDeviceCtrl : UIPage
    {
        public PDeviceCtrl()
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
    }
}
