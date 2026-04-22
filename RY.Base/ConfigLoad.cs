using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RY.Base
{
    public class ConfigLoad<T> where T:ConfigBase,new()
    {
        public static T LoadCfg(string path)
        {
            T obj = null;
            if(!File.Exists(path))
            {
                obj= new T();
            }
            else
            {
                obj=JsonHelper.ReadJson<T>(path);
            }
            if(obj==null)
            {
                UserLog.AddErrorMsg("加载模型失败" + path);
                return null;
            }
            obj.SetPath(path);
            return obj;
        }
    }
}
