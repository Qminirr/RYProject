using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using RY.Base;
using SunnyUI;
namespace RY.Ctrls
{
    public partial class FProduct : UIForm
    {
        public FProduct()
        {
            InitializeComponent();
        }

        private void FrmProduct_Load(object sender, EventArgs e)
        {
            SetUp();
        }

        private void Cancel(object sender, EventArgs e)
        {
            this.Close();
        }
        private void CheckProduct(object sender, EventArgs e)
        {
            if(listbProduct.SelectedIndex==-1)
            {
                MsgBox.ShowWarningTip("请选择加载的配方名称！");
                return;
            }
            if(ProjectBase.LoadProjectHandle==null)
            {
                MsgBox.ShowWarningTip("配方加载处理事件未赋值");
                return;
            }
            string s = listbProduct.SelectedItem.ToString();



            this.Hide();
            MsgBox.ShowWait("正在加载配方......");
            //交给委托事件处理加载
            ProjectBase.LoadProjectHandle(s);

            MsgBox.HideWait();
            this.Close();
            
        }



        /// <summary>
        /// 更新项目列表
        /// </summary>
        private void SetUp()
        {
            
            listbProduct.Items.Clear();
            listbProduct.Items.AddRange(GBase.GProject.ListModel().ToArray());
            listbProduct.Items.Add("「重置工程」");

        }

    }
}
