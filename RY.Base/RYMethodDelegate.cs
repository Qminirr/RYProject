using Newtonsoft.Json;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace RY.Base
{

    #region 流程方法
    [AttributeUsage(AttributeTargets.Method)]
    public class RYMethodDelegateAttribute : Attribute, IComparable
    {
        public int CompareTo(object obj)
        {
            RYMethodDelegateAttribute f = obj as RYMethodDelegateAttribute;
            if (f == null) return 0;
            return Name.CompareTo(f.Name);
        }

        public string Name
        { get; set; } = "";


        public eMethodType MethodType
        { get; set; } = eMethodType.正常;

        public string Remark
        { get; set; }

        public RYMethodDelegateAttribute(string name, eMethodType methodType, string remark)
        {
            Name = name;
            MethodType = methodType;
            Remark = remark;
        }
    }

    public enum eMethodType
    {
        正常=0,
        通用,
        逻辑If,
        逻辑Else,
        逻辑EndIf

    }

    public class RYMethodDelegateItem:IRYFunc
    {
        public string Name { get; set; } = "";

        public eMethodType MethodType
        { get; set; } = eMethodType.正常;


        [JsonIgnore]
        public MethodInfo Method
        { get; set; }

        [JsonIgnore]
        public List<ParameterInfo> ParamList
        { get; set; }


        public string GetParamInfo()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var p in ParamList)
            {
                sb.Append(p.ParameterType.ToString().Replace("System.", "").Replace("32", "").ToLower());
                sb.Append(" ");
                sb.Append(p.Name);
                sb.Append(",");
            }
            if (sb.Length > 0)
            {
                sb.Remove(sb.Length - 1, 1);
            }
            return sb.ToString();
        }
        public bool IsParamOK(params object[] param)
        {
            if (param == null && ParamList.Count == 0) return true;
            if (param.Length == 1 && string.IsNullOrEmpty(param[0].ToString().Trim()) && ParamList.Count == 0) return true;
            if (param.Length != ParamList.Count)
            {
                UserLog.AddErrorMsg("流程【" + Name + "】参数数量不匹配");
                return false;
            }
            for (int i = 0; i < param.Length; i++)
            {
                if (!ConvertHelper.CanChangeTo(param[i], ParamList[i].ParameterType))
                {
                    UserLog.AddErrorMsg("流程" + Name + "】无法转换参数" + param[i].ToString());
                    return false;
                }
            }
            return true;
        }

        public List<object> ConvertParam(params object[] param)
        {
            List<object> list = new List<object>();
            if (param.Length == 1 && string.IsNullOrEmpty(param[0].ToString().Trim())) return list;
            for (int i = 0; i < param.Length; i++)
            {
                list.Add(ConvertHelper.ChangeTo(param[i], ParamList[i].ParameterType));
            }
            return list;
        }

        
        public eCode Exec(params object[] param)
        {
            if (!IsParamOK(param)) return eCode.NG;
            eCode ret = (eCode)Method.Invoke(null, ConvertParam(param).ToArray());
            return ret;
        }
        public string Remark
        { get; set; } = "";
    }

    public class RYMethodDelegateFactory
    {

        static Dictionary<string, RYMethodDelegateItem> _dic = new Dictionary<string, RYMethodDelegateItem>();

        //G:GBase
        public static void SetUp(Type t)
        {
            _dic.Clear();
            List<MethodInfo> lst = new List<MethodInfo>();
            List<Type> tplst = new List<Type>();
            tplst.Add(t);
            Type d = t.BaseType;
            while(d.Name!="Object")
            {
                tplst.Add(d);
                d = d.BaseType;
            }
            foreach(Type tp in tplst)
            {
                lst.AddRange(tp.GetMethods(BindingFlags.Public | BindingFlags.Static).ToList().FindAll(x => x.IsDefined(typeof(RYMethodDelegateAttribute)) && x.ReturnType == typeof(eCode)));
            }
            

            foreach (MethodInfo m in lst)
            {
                RYMethodDelegateAttribute ryb = m.GetCustomAttribute<RYMethodDelegateAttribute>();
                RYMethodDelegateItem hitem = new RYMethodDelegateItem();
                hitem.Name = ryb.Name;
                hitem.Remark = ryb.Remark;
                hitem.Method = m;
                hitem.ParamList = m.GetParameters().ToList();
                hitem.MethodType = ryb.MethodType;
                _dic[hitem.Name] = hitem;


            }
        }

        /// <summary>
        /// 0 Check OK,1 方法不存在了 2 参数不匹配
        /// </summary>
        /// <param name="record"></param>
        /// <returns></returns>
        public static int CheckCmd(RYMethodRecord record)
        {
            if(!_dic.ContainsKey(record.Name))
            {
                return 1;
            }
            RYMethodDelegateItem item=_dic[record.Name];
            if (string.IsNullOrEmpty(record.Param) && item.ParamList.Count == 0) return 0;
            if (!item.IsParamOK(record.Param.Split(','))) return 2;
            return 0;

        }

        public static bool CheckCmds(RYMethodCollection collect)
        {
            foreach(RYMethodRecord record in collect.MethodList)
            {
                if(0!=CheckCmd(record)) return false;
            }
            return true;
        }

        //add(3,5)
        //add()
        public static eCode ExecCmd(string cmd)
        {
            int indexleft = cmd.IndexOf('(');
            int indexright = cmd.IndexOf(')');
            if (indexleft == -1 || indexright == -1)
            {
                UserLog.AddErrorMsg(cmd + "命令格式不正确");
                return eCode.NG;
            }
            string funcname = cmd.Substring(0, indexleft);
            string cmdparam = "";
            if ((indexright - indexleft - 1) != 0)
            {
                cmdparam = cmd.Substring(indexleft + 1, indexright - indexleft - 1);
            }
            return Exec(funcname, cmdparam.Split(','));
        }
        public static eCode Exec(string name, params object[] param)
        {
            if (string.IsNullOrEmpty(name))
            {
                UserLog.AddErrorMsg("未赋值的函数调用");
                return eCode.NG;
            }
            if (!_dic.ContainsKey(name))
            {
                UserLog.AddErrorMsg("不存在" + name + "的流程调用");
                return eCode.NG;
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
            if (!string.IsNullOrEmpty(prefix))
            {
                lst = lst.FindAll(x => x.Contains(prefix));
            }
            lst.Sort((x, y) =>
            {
                return x.CompareTo(y)*-1;
            });
            return lst;

        }
        public static List<RYMethodDelegateItem> GetFuncs()
        {
            List< RYMethodDelegateItem> lst=_dic.Values.ToList();
            lst.Sort((x, y) =>
            {
                return x.Name.CompareTo(y.Name)*-1;
            });
            return lst;
        }

        public static List<RYMethodDelegateItem> GetFuncsByPrefix(string prefix)
        {
            List<RYMethodDelegateItem> lst = _dic.Values.ToList();
            if(!string.IsNullOrEmpty(prefix))
            {
                lst=lst.FindAll(x => (x.Name.Contains(prefix)||x.Remark.Contains(prefix)));
            }
            lst.Sort((x, y) =>
            {
                return x.Name.CompareTo(y.Name) * -1;
            });
            return lst;
        }


        public static List<RYMethodDelegateItem> GetFuncs(eMethodType e)
        {
            List<RYMethodDelegateItem> lst = _dic.Values.ToList().FindAll(x=>x.MethodType==e);
            lst.Sort((x, y) =>
            {
                return x.Name.CompareTo(y.Name) * -1;
            });
            return lst;
        }

        public static RYMethodDelegateItem GetFunc(string funname)
        {
            if (!_dic.ContainsKey(funname))
            {
                UserLog.AddWarnMsg("不存在的功能名");
                return null;
            }
            return _dic[funname];
        }
    }

    #endregion
    #region 流程配置文件

    [Serializable]
    public class RYMethodRecord
    {
        public string Name { get; set; } = "";

        public eMethodType MethodType
        { get; set; } = eMethodType.正常;


        public string Param
        { get; set; } = "";
        public string Remark
        { get; set; } = "";

        public string ToCmd()
        {
            return Name + "(" + Param + ")";
        }

        public RYMethodRecord ToCopy()
        {
            RYMethodRecord m= new RYMethodRecord();
            m.Name = Name;
            m.MethodType = MethodType;
            m.Param = Param;
            m.Remark = Remark;
            return m;
        }
    }

    [Serializable]
    public class RYMethodCollection:ConfigBase
    {
        

        List<RYMethodRecord> _lst=new List<RYMethodRecord>();

        

        public List<RYMethodRecord> MethodList
        {
            get
            {
                return _lst;
            }
            set
            {
                _lst = value;
            }
        }

        public bool CheckMethods(out List<int> errIdx,out List<string> errMsg)
        {
            errIdx=new List<int>();
            errMsg = new List<string>();
            //保存含有逻辑If的开始索引
            List<int> lstIfStart=new List<int>();
            //1.检查所有的方法是否参数和方法匹配
            for(int i=0;i<MethodList.Count;i++)
            {
                RYMethodRecord rr=MethodList[i];
                RYMethodDelegateItem item = RYMethodDelegateFactory.GetFunc(rr.Name);
                if(item==null)
                {
                    errIdx.Add(i);
                    errMsg.Add("未获取到方法【" + Name + "  " + rr.Name + "】的存在");
                }
                if(!item.IsParamOK(rr.Param.Split(',')))
                {
                    errIdx.Add(i);
                    errMsg.Add("方法【" + Name + "  " + rr.Name + "】的参数赋值有问题");
                }
                if(item.MethodType==eMethodType.逻辑If)
                {
                    lstIfStart.Add(i);
                }
            }
            //如果不存在If，直接返回
            if (lstIfStart.Count < 1) return errIdx.Count()==0;
            foreach(int idx in lstIfStart)
            {
                RYLogicIf rf=new RYLogicIf();
                if (!ParseLogicIf(idx, ref rf, ref errIdx, ref errMsg)) return false;
            }
            return true;
        }

        //
        /// <summary>
        /// 获取逻辑If的所有内容
        /// </summary>
        /// <param name="startidx">开始的If标签</param>
        /// <param name="errIdx">错误的项目Index</param>
        /// <param name="logic">获取的内容</param>
        /// <returns></returns>
        public bool ParseLogicIf(int startidx, ref RYLogicIf logic, ref List<int> errIdx, ref List<string> errMsg)
        {
            //3,and
            RYMethodRecord startrecord = MethodList[startidx];
            //拆分Parameter
            string[] paras = startrecord.Param.Split(',');
            //如果参数长度不正确
            if (paras.Length != 2)
            {
                errMsg.Add("【" + Name+"】错误的If逻辑");
                errIdx.Add(startidx);
                return false;
            }
            int testcount = 0;
            if (!int.TryParse(paras[0],out testcount))
            {
                errMsg.Add("【" + Name + "】错误的If逻辑测试数量");
                errIdx.Add(startidx);
                return false;
            }
            if(testcount<=0)
            {
                errMsg.Add("【" + Name + "】逻辑If检测项目数量错误");
                errIdx.Add(startidx);
                return false;
            }
            eLogic l = eLogic.And;
            if(!Enum.TryParse<eLogic>(paras[1],true,out l))
            {
                errIdx.Add(startidx);
                errMsg.Add("【" + Name + "】错误的If逻辑AndOr");
                return false;
            }
            //赋值
            logic.PriStartIdx = startidx;
            logic.Logic = l;
            logic.TestCount = testcount;

            //总体列表数量至少要有（从startidx算起）
            //if            1
            //testcount      testcount
            //执行流程      至少1
            //else          最多1
            //执行流程      最少1
            //endif         1

            eMethodType mtype = eMethodType.逻辑If;
            //取得测试项目及内容
            for(int i=startidx+1;i<MethodList.Count;i++)
            {
                RYMethodRecord rr = MethodList[i];
                //判定必须不是Else,endif并填充满headerlist
                if(rr.MethodType==eMethodType.逻辑Else)
                {
                    logic.HasElseTag = true;
                    mtype = eMethodType.逻辑Else;
                    continue;
                }
                if(rr.MethodType==eMethodType.逻辑EndIf)
                {
                    logic.PriEndIdx = i;
                    logic.HasEndTag = true;
                    break;
                }
                if(rr.MethodType==mtype)
                {
                    //如果再次遇到同样If,else标签，直接判fail，不能嵌套
                    errIdx.Add(i);
                    errMsg.Add("【" + Name + "】不能嵌套逻辑");
                    return false;
                }
                //只剩下If和else两种情况
                if(mtype==eMethodType.逻辑If)
                {
                    logic.IfContent.Add(rr);
                }
                else
                {
                    logic.ElseContent.Add(rr);
                }

            }
            //1.判定IfContent的数量一定要大于testcount
            if(logic.IfContent.Count<=logic.TestCount||!logic.HasEndTag)
            {
                for(int i=0;i<logic.IfContent.Count;i++)
                {
                    errIdx.Add(startidx + 1 + i);
                }
                if (logic.HasEndTag)
                {
                    errMsg.Add("【" + Name + "】逻辑If测试项目数量不足");
                }
                else
                {
                    errMsg.Add("【" + Name + "】未发现EndIf标签");
                }
                return false;
            }
            
            if(logic.HasElseTag&&logic.ElseContent.Count<1)
            {
                //定位到else标签
                errIdx.Add(startidx + 1 + logic.IfContent.Count + 1);
                errMsg.Add("【" + Name + "】Else标签后无内容");
                return false;
            }
            return true;
        }
        /// <summary>
        /// 检测If标签是否满足条件
        /// </summary>
        /// <param name="startidx"></param>
        /// <param name="endidx"></param>
        /// <returns></returns>
        public bool CheckMethodsLogicIf(int startidx,ref int endidx)
        {
            List<int> errIdx=new List<int>();
            RYLogicIf logic=new RYLogicIf();
            List<string> errMsg=new List<string>();
            endidx = startidx;
            if (!ParseLogicIf(startidx, ref logic, ref errIdx,  ref errMsg))
            {
                foreach(var s in errMsg)
                {
                    UserLog.AddErrorMsg(s);
                }
                return false;
            }
            endidx = logic.PriEndIdx;
            return true;
        }

        public void AddMethod(RYMethodRecord item,int idx =-1)
        {
            if(idx<0||idx>=_lst.Count)
            {
                _lst.Add(item);
            }
            else
            {
                //>=0 && <_lst.Count
                _lst.Insert(idx, item);
            }
        }


        public void MoveUp(List<int> lst)
        {
            if (lst.Count == 0) return;
            if (lst[0] == 0) return;
            foreach (int i in lst)
            {
                RYMethodRecord cur= _lst[i];
                RYMethodRecord next = _lst[i - 1];
                _lst[i - 1] = cur;
                _lst[i] = next;
            }
            Save();
        }

        public void MoveDown(List<int> lst)
        {
            if (lst.Count == 0) return;
            if ((lst[lst.Count-1]+1) == _lst.Count) return;
            foreach (int i in lst)
            {
                RYMethodRecord cur = _lst[i];
                RYMethodRecord next = _lst[i + 1];
                _lst[i + 1] = cur;
                _lst[i] = next;
            }
            Save();
        }

        public void Remove(List<int> lst)
        {
            List<RYMethodRecord> lstnew = new List<RYMethodRecord>();
            for(int i=0; i<_lst.Count; i++)
            {
                if (lst.Contains(i)) continue;
                lstnew.Add(_lst[i]);
            }
            _lst = lstnew;
            Save();
        }
    }

    #region IF逻辑
    public class RYLogicIf
    {
        //原始流程中开始的If标签位置索引
        public int PriStartIdx
        { get; set; } = 0;

        //原始流程中EndIf标签位置索引
        public int PriEndIdx
        { get; set; } = 0;

        //测试条件数量
        public int TestCount
        { get; set; } = 1;

        //测试条件逻辑
        public eLogic Logic
        { get; set; } = eLogic.And;

        //是否含有Else标签
        public bool HasElseTag
        { get; set; } = false;

        //是否有EndIf标签
        public bool HasEndTag
        { get; set; } = false;

        //If测试项目列表
        public List<RYMethodRecord> IfContent
        { get; set; } = new List<RYMethodRecord>();

        //Else执行流程列表
        public List<RYMethodRecord> ElseContent
        { get; set; } = new List<RYMethodRecord>();

        //获取测试条件
        public List<RYMethodRecord> GetTestCondition()
        {
            List<RYMethodRecord> lst = new List<RYMethodRecord>();
            if (TestCount >= IfContent.Count) return lst;
            for(int i=0;i<TestCount;i++)
            {
                lst.Add(IfContent[i]);
            }
            return lst;
        }

        public List<RYMethodRecord> GetRunItemsByLogic(bool bTestOK)
        {
            List<RYMethodRecord> lst = new List<RYMethodRecord>();
            //如果测试逻辑是OK的
            if(bTestOK)
            {
                for(int i=TestCount;i<IfContent.Count;i++)
                {
                    lst.Add(IfContent[i]);
                }
            }
            else
            {
                foreach(RYMethodRecord record in ElseContent)
                {
                    lst.Add(record);
                }
            }
            return lst;
        }

    }
    #endregion


    #endregion


}
