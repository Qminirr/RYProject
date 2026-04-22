using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RY.Base;
namespace RY.Device
{
    public partial class UDevicesCtrl : UserControl
    {
        public UDevicesCtrl()
        {
            InitializeComponent();
        }

        private void UDevicesCtrl_Load(object sender, EventArgs e)
        {
            if (Common.IsDesignMode()) return;
            cbModule.Items.Clear();
            lsbDevNames.Items.Clear();
            pg.SelectedObject = null;
            cbModule.Items.AddRange(DeviceFactory.GetModulesName().ToArray());
            lsbDevNames.Items.AddRange(DeviceFactory.GetDevicesName().ToArray());
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            if(cbModule.SelectedIndex == -1)
            {
                MsgBox.ShowWarningTip("请先选中要添加的硬件");
                return;
            }
            string modulename = cbModule.SelectedItem.ToString();
            string devname = "";
            if (!MsgBox.ShowInputString(ref devname, true, "请输入设备名")) return;
            if(!DeviceFactory.CreateDevice(modulename, devname))
            {
                MsgBox.ShowWarningTip("执行失败");
            }
            else
            {
                MsgBox.ShowSuccessTip("创建成功");
                lsbDevNames.Items.Add(devname);
            }

        }

        private void lbDevNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsbDevNames.SelectedIndex == -1) return;
            DeviceBase dev = DeviceFactory.GetDeviceByName(lsbDevNames.SelectedItem.ToString());
            if(dev==null)
            {
                MsgBox.ShowWarningTip("未知设备");
                return;
            }
            pg.SelectedObject = dev;
        }

        private void btRename_Click(object sender, EventArgs e)
        {
            if (lsbDevNames.SelectedIndex == -1)
            {
                MsgBox.ShowWarningTip("请先选中要操作的设备名");
                return;
            }
            string devname=lsbDevNames.SelectedItem.ToString();
            string newname = "";
            if (!MsgBox.ShowInputString(ref newname, true, "请输入新的设备名")) return;
            if(devname==newname)
            {
                MsgBox.ShowWarningTip("新旧设备名一样，无法修改");
                return;
            }
            if(DeviceFactory.ReName(newname, devname))
            {
                MsgBox.ShowSuccessTip("执行成功");
                lsbDevNames.Items.Clear();
                lsbDevNames.Items.AddRange(DeviceFactory.GetDevicesName().ToArray());
            }
            else
            {
                MsgBox.ShowWarningTip("执行失败");
            }

        }

        private void btDel_Click(object sender, EventArgs e)
        {
            if (lsbDevNames.SelectedIndex == -1)
            {
                MsgBox.ShowWarningTip("请先选中要操作的设备名");
                return;
            }
            string devname = lsbDevNames.SelectedItem.ToString();
            if (!MsgBox.ShowAsk("确定要删除设备" + devname + "?")) return;
            DeviceBase db=DeviceFactory.GetDeviceByName(devname);
            if (db!=null)
            {
                db.Close();
            }
            if (DeviceFactory.RemoveDevice(devname))
            {
                MsgBox.ShowSuccessTip("删除成功");
                lsbDevNames.Items.RemoveAt(lsbDevNames.SelectedIndex);
            }
            else
            {
                MsgBox.ShowWarningTip("删除失败");
            }
        }
        
        private void btSave_Click(object sender, EventArgs e)
        {

            if(DeviceFactory.SaveToFile())
            {
                MsgBox.ShowSuccessTip("保存成功");
            }
            else
            {

                MsgBox.ShowWarningTip("保存失败");
            }
        }

        private void btDebugForm_Click(object sender, EventArgs e)
        {
            if(lsbDevNames.SelectedIndex == -1)
            {
                MsgBox.ShowWarningTip("请选中要调试的设备");
                return;
            }
            string devname=lsbDevNames.SelectedItem.ToString();
            
            DeviceBase db = DeviceFactory.GetDeviceByName(devname);
            if(db != null)
            {
                FDevDebugBase f = new FDevDebugBase();
                f.SetUp(db);
                f.Show();
            }
        }

        private void btUp_Click(object sender, EventArgs e)
        {
            if (lsbDevNames.SelectedIndex == -1)
            {
                MsgBox.ShowWarningTip("请选中要调整的设备");
                return;
            }
            string devname = lsbDevNames.SelectedItem.ToString();
            int idx = DeviceFactory.MoveUp(devname);
            lsbDevNames.Items.Clear();
            lsbDevNames.Items.AddRange(DeviceFactory.GetDevicesName().ToArray());
            lsbDevNames.SelectedIndex = idx;
        }

        private void btDown_Click(object sender, EventArgs e)
        {
            if (lsbDevNames.SelectedIndex == -1)
            {
                MsgBox.ShowWarningTip("请选中要调整的设备");
                return;
            }
            string devname = lsbDevNames.SelectedItem.ToString();
            int idx = DeviceFactory.MoveDown(devname);
            lsbDevNames.Items.Clear();
            lsbDevNames.Items.AddRange(DeviceFactory.GetDevicesName().ToArray());
            lsbDevNames.SelectedIndex = idx;
        }
    }
}
