using RY.Base;
using RY.Ctrls;
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

namespace RYProject
{
    public partial class FDebug : UIPage
    {
        Dictionary<eDbgFatherNode, TreeNode> _dicParent = new Dictionary<eDbgFatherNode, TreeNode>();

        int _pageIndex = 1;

        List<UIPage> _lstPage = new List<UIPage>();
        public FDebug()
        {
            InitializeComponent();
        }


        TreeNode GetFatherNode(eDbgFatherNode node)
        {
            if(_dicParent.ContainsKey(node)) return _dicParent[node];
            TreeNode tn = null;
            switch(node)
            {
                case eDbgFatherNode.通用设置:
                    tn = navMenu.CreateNode(node.ToString(), 61451, 24, _pageIndex++);
                    break;
                case eDbgFatherNode.工程相关:
                    tn = navMenu.CreateNode(node.ToString(), 57364, 24, _pageIndex++);
                    break;
                case eDbgFatherNode.系统标定:
                    tn = navMenu.CreateNode(node.ToString(), 57364, 24, _pageIndex++);
                    break;
            }
            _dicParent[node] = tn;
            return tn;
        }

        void BuildNode(RYAuthAttribute attrib)
        {
            if(attrib==null) return;
            UIPage uPage=attrib.GetValue<UIPage>();
            if(uPage==null)
            {
                ConfigBase cb = attrib.GetValue<ConfigBase>();
                if(cb!=null)
                {
                    CfgEditorPage editor =new CfgEditorPage();
                    editor.Caption = attrib.NodeName;
                    editor.SetObject(cb);
                    uPage = editor;

                }
            }
            if(uPage==null)
            {
                return;
            }
            TreeNode father = GetFatherNode(attrib.FatherNode);
            uPage.Parent = this;
            uPage.Dock = DockStyle.Fill;
            uPage.PageIndex = _pageIndex++;
            uPage.Text= attrib.NodeName;
            if(attrib.Symbol!=0)
            {
                uPage.Symbol = attrib.Symbol;
            }
            _lstPage.Add(uPage);
            navMenu.CreateChildNode(father, uPage);
        }

        void ShowPage(int pageIdx)
        {
            pnlContent.Controls.Clear();
            UIPage page=_lstPage.Find(x=>x.PageIndex==pageIdx);
            if (page==null)
            {
                return;
            }
            pnlContent.Controls.Add(page);
            page.Show();
        }
        private void FDebug_Load(object sender, EventArgs e)
        {
            navMenu.ClearAll();
            _pageIndex = 1;
            List<RYAuthAttribute> lst = RYAuthAttribCtrl.GetAuthProperties(typeof(G));
            foreach(RYAuthAttribute attr in lst)
            {
                BuildNode(attr);
            }
            navMenu.ExpandAll();
        }

        private void navMenu_MenuItemClick(TreeNode node, NavMenuItem item, int pageIndex)
        {
            ShowPage(pageIndex);

        }
    }
}
