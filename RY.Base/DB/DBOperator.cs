using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace RY.Base
{

    public class DBOperator
    {

        private static object obj = new object();
        public static List<string> GetTables()
        {
            List<string> lst = new List<string>();
            string s = "select name from sqlite_master where type=\'table\'";
            DataSet ds = DbHelperSQLite.Query(s);
            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    lst.Add(dr[0].ToString().ToLower());
                }
            }
            return lst;
        }
        public static bool MakeSureTableExist()
        {
            List<string> lst = GetTables();
            if(!lst.Contains("product"))
            {
                if (!CreateProductTable()) return false;
            }
            return true;
        }
        public static bool CreateProductTable()
        {
            if(GetTables().Contains("product"))
            {
                MsgBox.ShowError("数据库已经存在产品表，无法新建！");
                return false;
            }
            string s = @"create table Product(
    id integer primary key autoincrement,
	dt datetime,
    markyear integer,
    markmonth integer,
    markday integer,
    markhour integer,
    model text,
    sn text,
    remark text,
    result integer)";
            lock(obj)
            {
                if (DbHelperSQLite.ExecuteSql(s) >= 0)
                {
                    s = "create INDEX idx_model ON Product(model)";
                    return DbHelperSQLite.ExecuteSql(s) >= 0;
                }
            }
            
            return false;
        }


        public static List<string> GetModels()
        {
            MakeSureTableExist();
            List<string> lst = new List<string>();
            string s = "select distinct model from Product";
            DataSet ds=null;
            lock(obj)
            {
                ds = DbHelperSQLite.Query(s);
            }
            
            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    lst.Add(dr[0].ToString());
                }
            }
            if (lst.Count > 0)
            {
                lst.Insert(0, "所有产品");
            }
            else
            {
                lst.Add("所有产品");
            }
            return lst;
        }
        public static DataTable ToDS(Dictionary<int, PResult>dic,bool bByHour=true,bool bShowNG=false)
        {
            DataTable dt = new DataTable();
            if(bByHour)
            {
                dt.Columns.Add("时段", System.Type.GetType("System.String"));
            }
            else
            {
                dt.Columns.Add("日期", System.Type.GetType("System.String"));
            }
            dt.Columns.Add("总数量", System.Type.GetType("System.Int32"));
            if(bShowNG)
            {
                dt.Columns.Add("OK数", System.Type.GetType("System.Int32"));
                dt.Columns.Add("NG数", System.Type.GetType("System.Int32"));
                dt.Columns.Add("良率", System.Type.GetType("System.String"));
            }
            DataRow dr = null;
            if (bByHour)
            {
                int tot = 0;
                int ok = 0;
                int ng = 0;
                for(int i=8;i<20;i++)
                {
                    dr = dt.NewRow();

                    dr[0] = bByHour ? dic[i].ToMarkHour() : dic[i].ToMarkDay();
                    dr[1] = dic[i].Total;
                    tot += dic[i].Total;
                    if (bShowNG)
                    {
                        dr[2] = dic[i].OKCount;
                        dr[3] = dic[i].GetNGCount();
                        ok += dic[i].OKCount;
                        ng+= dic[i].GetNGCount();
                        dr[4] = dic[i].LVString();
                    }
                    dt.Rows.Add(dr);
                }
                dr = dt.NewRow();
                dr[0] = "白班总和";
                dr[1] = tot;
                if(bShowNG)
                {
                    dr[2] = ok;
                    dr[3] = ng;
                    if (tot != 0)
                    {
                        dr[4] = (ok * 100.0 / tot).ToString("f2") + "%";
                    }
                }
                dt.Rows.Add(dr);
                tot = 0;
                ok = 0;
                ng = 0;
                for (int i = 20; i <= 23; i++)
                {
                    dr = dt.NewRow();

                    dr[0] = bByHour ? dic[i].ToMarkHour() : dic[i].ToMarkDay();
                    dr[1] = dic[i].Total;
                    tot += dic[i].Total;
                    if (bShowNG)
                    {
                        dr[2] = dic[i].OKCount;
                        dr[3] = dic[i].GetNGCount();
                        ok += dic[i].OKCount;
                        ng += dic[i].GetNGCount();
                        dr[4] = dic[i].LVString();
                    }
                    dt.Rows.Add(dr);
                }
                for(int i=0;i<8;i++)
                {
                    dr = dt.NewRow();

                    dr[0] = bByHour ? dic[i].ToMarkHour() : dic[i].ToMarkDay();
                    dr[1] = dic[i].Total;
                    tot += dic[i].Total;
                    if (bShowNG)
                    {
                        dr[2] = dic[i].OKCount;
                        dr[3] = dic[i].GetNGCount();
                        ok += dic[i].OKCount;
                        ng += dic[i].GetNGCount();
                        dr[4] = dic[i].LVString();
                    }
                    dt.Rows.Add(dr);
                }
                dr = dt.NewRow();
                dr[0] = "晚班总和";
                dr[1] = tot;
                if (bShowNG)
                {
                    dr[2] = ok;
                    dr[3] = ng;
                    if (tot != 0)
                    {
                        dr[4] = (ok * 100.0 / tot).ToString("f2") + "%";
                    }
                    
                }
                dt.Rows.Add(dr);
            }
            else
            {
                int tot = 0;
                int ok = 0;
                int ng = 0;
                foreach (int mk in dic.Keys)
                {
                    dr = dt.NewRow();
                    dr[0] = bByHour ? dic[mk].ToMarkHour() : dic[mk].ToMarkDay();
                    dr[1] = dic[mk].Total;
                    tot += dic[mk].Total;
                    if (bShowNG)
                    {
                        dr[2] = dic[mk].OKCount;
                        dr[3] = dic[mk].GetNGCount();
                        ok += dic[mk].OKCount;
                        ng += dic[mk].GetNGCount();
                        dr[4] = dic[mk].LVString();
                    }
                    dt.Rows.Add(dr);
                }
                dr = dt.NewRow();
                dr[0] = "汇总";
                dr[1] = tot;
                if (bShowNG)
                {
                    dr[2] = ok;
                    dr[3] = ng;
                    if (tot != 0)
                    {
                        dr[4] = (ok * 100.0 / tot).ToString("f2") + "%";
                    }
                }
                dt.Rows.Add(dr);
            }

            return dt;

        }
        public static bool AddProduct(string model,string sn,bool result,string remark="")
        {
            MakeSureTableExist();
            StringBuilder sb = new StringBuilder();
            sb.Append("insert into product(dt,markyear,markmonth,markday,markhour,sn,result,model,remark) values(datetime(\'now\',\'localtime\'),");
            DateTime dt = DateTime.Now;
            if (dt.Hour < 8)
            {
                dt.AddDays(-1);
            }
            sb.Append(dt.Year.ToString());
            sb.Append(",");
            sb.Append(dt.Month.ToString());
            sb.Append(",");
            sb.Append(dt.Day.ToString());
            sb.Append(",");
            sb.Append(dt.Hour.ToString());
            sb.Append(",\'");
            sb.Append(sn);
            sb.Append("\',");
            sb.Append(result ? "1" : "0");
            sb.Append(",\'");
            sb.Append(model);
            sb.Append("\'");
            sb.Append(",\'");
            sb.Append(remark);
            sb.Append("\'");
            sb.Append(")");
            lock (obj)
            {
                return DbHelperSQLite.ExecuteSql(sb.ToString()) > 0;
            }


        }
        public static DataSet GetProductDetailByDay(DateTime dt,string model="")
        {
            MakeSureTableExist();
            StringBuilder sb = new StringBuilder();
            sb.Append("select id,dt,model,sn,result,remark from product where ");
            if(!string.IsNullOrEmpty(model))
            {
                sb.Append("model=\'");
                sb.Append(model);
                sb.Append("\' and ");
            }
            sb.Append("dt>=\'");
            sb.Append(dt.ToString("yyyy-MM-dd"));
            sb.Append(" 00:00:00");
            sb.Append("\' and dt<\'");
            sb.Append(dt.ToString("yyyy-MM-dd"));
            sb.Append(" 23:59:59");
            sb.Append("\' order by dt desc");
            lock(obj)
            {
                return DbHelperSQLite.Query(sb.ToString());
            }
            
        }

        public static DataSet GetProductDetailBetween(DateTime dtStart,DateTime dtEnd, string model = "")
        {
            MakeSureTableExist();
            StringBuilder sb = new StringBuilder();
            sb.Append("select id,dt,model,sn,result,remark from product where ");
            if (!string.IsNullOrEmpty(model))
            {
                sb.Append("model=\'");
                sb.Append(model);
                sb.Append("\' and ");
            }
            sb.Append("dt>=\'");
            sb.Append(dtStart.ToString("yyyy-MM-dd"));
            sb.Append(" 00:00:00");
            sb.Append("\' and dt<\'");
            sb.Append(dtEnd.ToString("yyyy-MM-dd"));
            sb.Append(" 23:59:59");
            sb.Append("\' order by dt desc");
            lock (obj)
            {
                return DbHelperSQLite.Query(sb.ToString());
            }

        }
        public static Dictionary<int, PResult> GetProductSummaryByMonth(int year, int month, string model = "")
        {
            MakeSureTableExist();
            int days = DateTime.DaysInMonth(year, month);
            Dictionary<int, PResult> dic = new Dictionary<int, PResult>();
            for (int i = 1; i <= days; i++)
            {
                dic[i] = new PResult();
                dic[i].Mark = i;
            }
            DateTime dtStart = new DateTime(year, month, 1);
            DateTime dtEnd = dtStart.AddMonths(1);
            StringBuilder sb = new StringBuilder();
            sb.Append("select markday,count(result) as t,sum(result) as s from product where markyear=");
            sb.Append(year.ToString());
            sb.Append(" and markmonth=");
            sb.Append(month.ToString("d2"));
            if (!string.IsNullOrEmpty(model))
            {
                sb.Append(" and model=\'");
                sb.Append(model);
                sb.Append("\'");
            }
            sb.Append(" group by markday order by markday");
            DataSet ds;
            lock (obj)
            {
                ds = DbHelperSQLite.Query(sb.ToString());
            }
            
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                int mk = int.Parse(dr[0].ToString());
                int t = int.Parse(dr[1].ToString());
                int ok = int.Parse(dr[2].ToString());

                if (dic.ContainsKey(mk))
                {
                    dic[mk].OKCount = ok;
                    dic[mk].Total = t;
                    dic[mk].Model = model;

                }
            }
            return dic;

        }

        public static Dictionary<int, PResult> GetProductSummaryByDay(int year, int month, int day, string model = "")
        {
            MakeSureTableExist();
            Dictionary<int, PResult> dic = new Dictionary<int, PResult>();
            for (int i = 0; i < 24; i++)
            {
                dic[i] = new PResult();
                dic[i].Mark = i;
            }
            DateTime dt = new DateTime(year, month, day);
            StringBuilder sb = new StringBuilder();
            sb.Clear();
            sb.Append("select markhour,count(result) as t,sum(result) as s from product where ");
            sb.Append("markyear=");
            sb.Append(year.ToString());
            sb.Append(" and markmonth=");
            sb.Append(month.ToString("d2"));
            sb.Append(" and markday=");
            sb.Append(day.ToString("d2"));
            if (!string.IsNullOrEmpty(model))
            {
                sb.Append(" and model=\'");
                sb.Append(model);
                sb.Append("\'");
            }

            sb.Append(" group by markhour order by markhour");
            DataSet ds;
            lock (obj)
            {
                ds = DbHelperSQLite.Query(sb.ToString());
            }
            
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                int mk = int.Parse(dr[0].ToString());
                int t = int.Parse(dr[1].ToString());
                int ok = int.Parse(dr[2].ToString());
                if (dic.ContainsKey(mk))
                {
                    dic[mk].OKCount = ok;
                    dic[mk].Total = t;
                    dic[mk].Model = model;
                }
            }
            return dic;
        }
    }

    public class PResult
    {
        public int Mark
        { get; set; }

        public int Total
        { get; set; } = 0;

        public int OKCount
        { get; set; } = 0;

        public int GetNGCount()
        {
            return Total - OKCount;
        }

        public string Model
        { get; set; } = "";
        public string LVString()
        {
            if (Total == 0) return "";
            if (OKCount == Total) return "100%";
            return (OKCount * 100.0 / Total).ToString("f2")+"%";
        }
        public string ToMarkHour()
        {
            int next = Mark + 1;
            if (Mark >= 24) Mark = 0;
            string s = Mark.ToString("d2") + ":00-" + next.ToString("d2") + ":00";
            return s;
        }
        public string ToMarkDay()
        {
            return Mark.ToString();
        }

    }
}
