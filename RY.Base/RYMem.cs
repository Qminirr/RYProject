using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace RY.Base
{
    public class RYMem
    {
        static Dictionary<string, object> _dic = new Dictionary<string, object>();
        static object _lock=new object();
        public static void SetObject(string key, object value)
        {
            lock(_lock)
            {
                _dic[key] = value;
            }
        }
        public void Clear()
        {
            lock (_lock)
            {
                _dic.Clear();
            }
        }
        public static T GetObject<T>(string key) where T : class
        {
            lock(_lock)
            {
                if (_dic.ContainsKey(key))
                {
                    return _dic[key] as T;
                }
                return null;
            }
            
        }

        public static string GetString(string key,string def="")
        {
            lock(_lock)
            {
                if (_dic.ContainsKey(key))
                {
                    if (_dic[key] is string)
                    {
                        return _dic[key] as string;
                    }
                }
                return def;

            }
        }

        public static int GetInteger(string key,int def=0)
        {
            lock (_lock)
            {
                if (_dic.ContainsKey(key))
                {
                    if (_dic[key] is int)
                    {
                        return (int)_dic[key];
                    }
                }
                return def;

            }
        }
        public static long GetLong(string key, long def = 0)
        {
            lock (_lock)
            {
                if (_dic.ContainsKey(key))
                {
                    if (_dic[key] is long)
                    {
                        return (long)_dic[key];
                    }
                }
                return def;

            }
        }
        public static bool GetBoolean(string key,bool def=false)
        {
            lock (_lock)
            {
                if (_dic.ContainsKey(key))
                {
                    if (_dic[key] is bool)
                    {
                        return (bool)_dic[key];
                    }
                }
                return def;

            }
        }


        public static DateTime GetDateTime(string key)
        {
            lock (_lock)
            {
                if (_dic.ContainsKey(key))
                {
                    if (_dic[key] is DateTime)
                    {
                        return (DateTime)_dic[key];
                    }
                }
                return DateTime.Now;

            }
        }
    }
}
