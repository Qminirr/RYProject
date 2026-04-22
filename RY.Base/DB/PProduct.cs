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
namespace RY.Base
{
    public partial class PProduct :UIPage
    {
        public PProduct()
        {
            InitializeComponent();
            dtp1from.Value=dtp1to.Value=dtp2.Value=dtp3.Value=DateTime.Now;
        }

        private void cbp1select_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbp1select.SelectedIndex == -1) return;
            DateTime dtstart = DateTime.Now;
            DateTime dtEnd=DateTime.Now;
            int dayidx = (int)dtstart.DayOfWeek-1;
            if (dayidx < 0) dayidx = 6;
            switch (cbp1select.SelectedIndex)
            {
                case 0://当前
                    break;
                case 1://本周
                    dtstart=dtstart.AddDays(-1 * dayidx);
                    break;
                case 2://本月
                    dtstart = DateTime.Now.BeginOfMonth();
                    break;
                case 3://上月
                    dtstart = DateTime.Now.BeginOfMonth().AddDays(-1).BeginOfMonth();
                    dtEnd = dtstart.EndOfMonth();
                    break;
                case 4://半年
                    dtstart = DateTime.Now.AddMonths(-6);
                    break;
                default:
                    break;
            }
            dtp1from.Value = dtstart;
            dtp1to.Value = dtEnd;
        }


        public void SaveCSV(string title, DataTable dt)//table数据写入csv
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            //打开的文件选择对话框上的标题
            saveFileDialog.Title = "请选择文件";
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            //设置文件类型
            saveFileDialog.Filter = "文本文件(*.csv)|*.csv";
            //设置默认文件类型显示顺序
            saveFileDialog.FilterIndex = 1;
            if (DialogResult.OK != saveFileDialog.ShowDialog())
            {
                return;
            }

            string fullPath = saveFileDialog.FileName;

            System.IO.FileStream fs = new System.IO.FileStream(fullPath, System.IO.FileMode.Create, System.IO.FileAccess.Write);
            System.IO.StreamWriter sw = new System.IO.StreamWriter(fs, System.Text.Encoding.UTF8);

            //写入列名
            string data = "";
            for (int i = 0; i < dt.Columns.Count; i++)
            {
                data += dt.Columns[i].ColumnName.ToString();
                if (i < dt.Columns.Count - 1)
                {
                    data += ",";
                }
            }
            sw.WriteLine(data);

            //写入各行数据
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                data = "";
                for (int j = 0; j < dt.Columns.Count; j++)
                {
                    string str = dt.Rows[i][j].ToString();
                    str = str.Replace("\"", "\"\"");//替换英文冒号 英文冒号需要换成两个冒号
                    if (str.Contains(',') || str.Contains('"')
                      || str.Contains('\r') || str.Contains('\n')) //含逗号 冒号 换行符的需要放到引号中
                    {
                        str = string.Format("\"{0}\"", str);
                    }

                    data += str;
                    if (j < dt.Columns.Count - 1)
                    {
                        data += ",";
                    }
                }
                sw.WriteLine(data);
            }
            sw.WriteLine(title);
            sw.Close();
            fs.Close();
        }

        private void btQuery_Click(object sender, EventArgs e)
        {
            DateTime dtS = dtp1from.Value;
            DateTime dtE = dtp1to.Value;
            DataSet ds = DBOperator.GetProductDetailBetween(dtS, dtE, cbp1product.SelectedIndex > 0 ? cbp1product.SelectedItem.ToString() : "");
            this.dvAll.DataSource = ds.Tables[0];
            foreach (DataGridViewColumn c in this.dvAll.Columns)
            {
                c.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            lbP1QueryInfo.Symbol = 559535;
            lbP1QueryInfo.Text = "共" + dvAll.Rows.Count.ToString() + "条记录";
        }

        private void PProduct_Load(object sender, EventArgs e)
        {
            cbp1product.Items.Clear();
            cbp1product.Items.AddRange(DBOperator.GetModels().ToArray());

            cbp2product.Items.Clear();
            cbp2product.Items.AddRange(DBOperator.GetModels().ToArray());

            cbp3product.Items.Clear();
            cbp3product.Items.AddRange(DBOperator.GetModels().ToArray());
            
        }

        private void btQuery2_Click(object sender, EventArgs e)
        {
            DateTime dtS = dtp2.Value;
            var lst = DBOperator.GetProductSummaryByDay(dtS.Year,dtS.Month,dtS.Day, cbp2product.SelectedIndex > 0 ? cbp2product.SelectedItem.ToString() : "");
            DataTable tb = DBOperator.ToDS(lst, true, true);
            this.dgvDay.DataSource = tb;
            foreach (DataGridViewColumn c in this.dgvDay.Columns)
            {
                c.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        private void btQuery3_Click(object sender, EventArgs e)
        {
            DateTime dtS = dtp3.Value;
            var lst = DBOperator.GetProductSummaryByMonth(dtS.Year, dtS.Month, cbp3product.SelectedIndex > 0 ? cbp3product.SelectedItem.ToString() : "");
            DataTable tb = DBOperator.ToDS(lst, false, true);
            this.dgvMonth.DataSource = tb;
            foreach (DataGridViewColumn c in this.dgvMonth.Columns)
            {
                c.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        private void btExport3_Click(object sender, EventArgs e)
        {
            DateTime dtime = dtp3.Value;
            DataTable dt = dgvMonth.DataSource as DataTable;
            string s = string.Format("{0}月产能分布", dtime.ToString("yyyy-MM"));
            if (dt != null)
            {
                SaveCSV(s, dt);
                MsgBox.ShowSuccess("导出成功！");
            }
        }
    }
}
