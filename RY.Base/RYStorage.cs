using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RY.Base
{
    public class RYStorage
    {
        public RYStorage() 
        { 
            if(File.Exists(_path))
            {
                _dic = JsonHelper.ReadJson<Dictionary<string, object>>(_path);
                if(_dic==null) _dic = new Dictionary<string, object>();
            }
        }
        string _path = Path.Combine(Application.StartupPath,"Storage.dat");
        Dictionary<string, object> _dic = new Dictionary<string, object>();
        static object _lock = new object();
        static RYStorage _storage = null;

        public static RYStorage Instance
        {
            get
            {
                if (_storage != null) return _storage;
                lock (_lock)
                {
                    if (_storage != null) return _storage;
                    _storage = new RYStorage();
                    return _storage;
                }
            }
            
        }

        public void Clear()
        {
            lock (_lock)
            {
                _dic.Clear();
                JsonHelper.SaveJson(_path, _dic, false);
            }
        }
        public void SetObject(string key, object value)
        {
            lock (_lock)
            {
                _dic[key] = value;
                JsonHelper.SaveJson(_path, _dic, false);
            }
        }

        public T GetObject<T>(string key) where T : class
        {
            lock (_lock)
            {
                if (_dic.ContainsKey(key))
                {
                    return _dic[key] as T;
                }
                return null;
            }

        }

        public string GetString(string key, string def = "")
        {
            lock (_lock)
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

        public int GetInteger(string key, int def = 0)
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
        public long GetLong(string key, long def = 0)
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
        public bool GetBoolean(string key, bool def = false)
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


        public DateTime GetDateTime(string key)
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
