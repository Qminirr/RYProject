using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RY.Base
{
    [AttributeUsage(AttributeTargets.Method)]
    public class RYBoolDelegateAttribute : Attribute, IComparable
    {
        public int CompareTo(object obj)
        {
            RYBoolDelegateAttribute f = obj as RYBoolDelegateAttribute;
            if (f == null) return 0;
            return Name.CompareTo(f.Name);
        }

        public string Name
        { get; set; } = "";


        public eRYBoolDelegateType MethodType
        { get; set; } = eRYBoolDelegateType.通用功能;

        public string Remark
        { get; set; }

        public RYBoolDelegateAttribute(string name, eRYBoolDelegateType methodType, string remark)
        {
            Name = name;
            MethodType = methodType;
            Remark = remark;
        }
    }

    public enum eRYBoolDelegateType
    {
        通用功能=0,
        运动,
        照明,
        检测,
        未知
    }

    public class RYBoolDelegateItem:IRYFunc
    {
        public string Name { get; set; } = "";

        public eRYBoolDelegateType MethodType
        { get; set; } = eRYBoolDelegateType.未知;

        public MethodInfo Method
        { get; set; }


        public List<ParameterInfo> ParamList
        { get; set; }


        public string Remark
        { get; set; } = "";


        public string GetParamInfo()
        {
            StringBuilder sb = new StringBuilder();
            foreach(var  p in ParamList)
            {
                sb.Append(p.ParameterType.ToString().Replace("System.", "").Replace("32", "").ToLower());
                sb.Append(" ");
                sb.Append(p.Name);
                sb.Append(",");
            }
            if(sb.Length > 0)
            {
                sb.Remove(sb.Length - 1, 1);
            }
            return sb.ToString();
        }
        public bool IsParamOK(params object[] param)
        {
            if (param == null && ParamList.Count == 0) return true;
            if (param.Length == 1 && string.IsNullOrEmpty(param[0].ToString().Trim())&&ParamList.Count==0) return true;
            if(param.Length!=ParamList.Count)
            {
                UserLog.AddErrorMsg("布尔方法【" + Name + "】参数数量不匹配");
                return false;
            }
            for(int i = 0; i < param.Length; i++)
            {
                if (!ConvertHelper.CanChangeTo(param[i], ParamList[i].ParameterType))
                {
                    UserLog.AddErrorMsg("布尔方法" + Name + "】无法转换参数" + param[i].ToString());
                    return false;
                }
            }
            return true;
        }

        private List<object> ConvertParam(params object[] param)
        {
            List<object> list = new List<object>();
            if (param.Length == 1 && string.IsNullOrEmpty(param[0].ToString().Trim())) return list;
            for (int i=0;i< param.Length; i++)
            {
                list.Add(ConvertHelper.ChangeTo(param[i], ParamList[i].ParameterType));
            }
            return list;
        }
        public bool Exec(params object[] param)
        {
            if (!IsParamOK(param)) return false;
            bool ret = (bool)Method.Invoke(null, ConvertParam(param).ToArray());
            return ret;
        }
        
    }
    
    public class RYBoolDelegateFactory
    {

        static Dictionary<string, RYBoolDelegateItem> _dic = new Dictionary<string, RYBoolDelegateItem>();

        public static void SetUp(Type t)
        {
            _dic.Clear();
            List<MethodInfo> lst = new List<MethodInfo>();
            lst.AddRange(t.GetMethods(BindingFlags.Public | BindingFlags.Static).ToList().FindAll(x => x.IsDefined(typeof(RYBoolDelegateAttribute)) && x.ReturnType == typeof(bool)));
            
            foreach(MethodInfo m in lst)
            {
                RYBoolDelegateAttribute ryb = m.GetCustomAttribute<RYBoolDelegateAttribute>();
                RYBoolDelegateItem hitem=new RYBoolDelegateItem();
                hitem.Name = ryb.Name;
                hitem.Remark = ryb.Remark;
                hitem.Method = m;
                hitem.ParamList = m.GetParameters().ToList() ;
                hitem.MethodType=ryb.MethodType;
                _dic[hitem.Name] = hitem;

                
            }
        }

        //add(3,5)
        //add()
        public static bool ExecCmd(string cmd)
        {
            int indexleft = cmd.IndexOf('(');
            int indexright = cmd.IndexOf(')');
            if(indexleft==-1 || indexright==-1)
            {
                UserLog.AddErrorMsg(cmd + "命令格式不正确");
                return false;
            }
            string funcname = cmd.Substring(0, indexleft);
            string cmdparam = "";
            if ((indexright - indexleft - 1) != 0)
            {
                cmdparam = cmd.Substring(indexleft + 1, indexright - indexleft - 1);
            }
            return Exec(funcname, cmdparam.Split(','));
        }
        public static bool Exec(string name,params object[] param)
        {
            if(string.IsNullOrEmpty(name))
            {
                UserLog.AddErrorMsg("未赋值的函数调用");
                return false;
            }
            if(!_dic.ContainsKey(name))
            {
                UserLog.AddErrorMsg("不存在" + name + "的Bool调用");
                return false;
            }
            return _dic[name].Exec(param);
        }

        public static List<string> GetNames()
        {
            return _dic.Keys.ToList();
        }

        public static List<string> GetOrderName(string prefix)
        {
            List<string> lst = GetNames();
            if(!string.IsNullOrEmpty(prefix))
            {
                lst=lst.FindAll(x => x.Contains(prefix));
            }
            lst.Sort((x,y)=>
            {
                return x.CompareTo(y);
            });
            return lst;

        }
        public static List<RYBoolDelegateItem> GetFuncs(eRYBoolDelegateType e)
        {
            return _dic.Values.ToList().FindAll(x=>x.MethodType==e);
        }

        public static RYBoolDelegateItem GetFunc(string funname)
        {
            if(!_dic.ContainsKey(funname))
            {
                UserLog.AddWarnMsg("不存在的功能名");
                return null;
            }
            return _dic[funname];
        }
    }
}
