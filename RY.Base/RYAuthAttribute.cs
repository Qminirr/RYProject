using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace RY.Base
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = false)]
    public class RYAuthAttribute:Attribute
    {
        public RYAuthAttribute(eDbgFatherNode fathernode,string nodename="",eUserLevel lowestlevel=eUserLevel.Engineer,
            int symbol=0,int sort=99)
        {
            FatherNode = fathernode;
            NodeName = nodename;
            LowestAuth = lowestlevel;
            Symbol = symbol;
            Sort = sort;
        }

        public string NodeName
        { get; set; } = "";


        public int Symbol
        { get; set; } = 0;

        public int Sort
        { get; set; } = 99;


        /// <summary>
        /// 结合FatherNode和Sort生成整个SortIndex
        /// </summary>
        /// <returns></returns>
        public int GetSortIndex()
        {
            return (int)FatherNode * 1000 + Sort;
        }

        public eDbgFatherNode FatherNode
        { get; set; } = eDbgFatherNode.通用设置;

        public eUserLevel LowestAuth
        { get; set; } = eUserLevel.Engineer;

        public PropertyInfo PI
        { get; set; } = null;

        public object GetValue()
        {
            if (PI == null) return null;
            return PI.GetValue(null, null);
        } 

        public T GetValue<T>() where T:class
        {
            return GetValue() as T;
        }

    }

    public class RYAuthAttribCtrl
    {
        public static List<RYAuthAttribute> GetAuthProperties(Type t)
        {
            List<RYAuthAttribute> myList=new List<RYAuthAttribute>();
            List<PropertyInfo> lst = t.GetProperties(BindingFlags.Public | BindingFlags.Static | BindingFlags.Instance).ToList();
            foreach(PropertyInfo pi in lst)
            {
                RYAuthAttribute attrib=pi.GetCustomAttribute<RYAuthAttribute>();
                if(attrib!=null)
                {
                    if((int)GBase.UserLevel>=(int)attrib.LowestAuth)
                    {
                        attrib.PI = pi;
                        myList.Add(attrib);
                    }
                }
            }
            //Sort List
            myList.Sort((x, y) =>
            {
                return x.GetSortIndex().CompareTo(y.GetSortIndex());
            });
            return myList;
        }
    }
}
