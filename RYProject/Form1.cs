using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SunnyUI;
using RY.Base;
using System.Diagnostics;
using RY.Ctrls;
namespace RYProject
{
    public partial class Form1 : UIForm
    {


        CfgEditorPage editor = new CfgEditorPage();
        public Form1()
        {
            InitializeComponent();

            //RYBoolDelegateFactory.SetUp(typeof(G));

            //List<string> lst = RYBoolDelegateFactory.GetNames();
            //foreach (string s in lst)
            //{
            //    Debug.WriteLine(s);
            //}
            string cfgpath = Path.Combine(Application.StartupPath, "Config");
            if(!Directory.Exists(cfgpath))
            {
                Directory.CreateDirectory(cfgpath);
            }
            cfgpath += "\\ProjectSetting.dat";
            //ps=ConfigLoad<ProjectSetting>.LoadCfg(cfgpath);
            //editor.Caption = "配置修改测试";
            //editor.SetObject(ps);
            //editor.Show();
            //panel1.Controls.Add(editor);
            //editor.Dock= DockStyle.Fill;

            
        }
        
        private void btGenExp_Click(object sender, EventArgs e)
        {
            


        }

        private void btSea_Click(object sender, EventArgs e)
        {



        }

        private void btDeSea_Click(object sender, EventArgs e)
        {
        }

        private void btFunc_Click(object sender, EventArgs e)
        {
            RYBoolDelegateFactory.Exec("计算",100,50);
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            //ps.Save();

        }
    }
}
