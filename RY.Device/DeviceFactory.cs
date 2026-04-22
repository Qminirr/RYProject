using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using RY.Base;
namespace RY.Device
{
    public class DeviceFactory
    {
        public static readonly string PlugInsDir = Application.StartupPath + "\\PlugIns\\";

        public static readonly string SettingPath = Application.StartupPath + "\\Config\\SystemDevs.dat";

        static Dictionary<string,PlugInsInfo> _dicPlug=new Dictionary<string,PlugInsInfo>();

        static Dictionary<string, DeviceBase> _dicDevices=new Dictionary<string, DeviceBase>();


        static Dictionary<string,AxisBase> _dicAxis=new Dictionary<string,AxisBase>();

        public static void InitPlugIn()
        {
            if (!Directory.Exists(PlugInsDir)) return;
            foreach(string dllfile in Directory.GetFiles(PlugInsDir,"*.dll"))
            {
                FileInfo fi=new FileInfo(dllfile);
                if(!fi.Name.StartsWith("RY.PlugIns")) continue;
                Assembly assembly = AppDomain.CurrentDomain.Load(Assembly.LoadFile(fi.FullName).GetName());
                foreach(Type type in assembly.GetTypes())
                {
                    if(typeof(DeviceBase).IsAssignableFrom(type))
                    {
                        PlugInsInfo info = new PlugInsInfo();
                        if(GetPlugInfo(assembly, type, ref info))
                        {
                            _dicPlug[info.Name] = info;
                        }
                        else
                        {
                            UserLog.AddWarnMsg("重建设备失败" + fi.Name);
                        }
                    }
                }
            }
        }

        public static bool GetPlugInfo(Assembly assembly,Type type,ref PlugInsInfo info)
        {
            //object[] displayObjs = type.GetCustomAttributes(typeof(DisplayNameAttribute), true);
            DisplayNameAttribute dispattr = type.GetCustomAttribute(typeof(DisplayNameAttribute), true) as DisplayNameAttribute;
            if(dispattr==null) return false;
            info.Name=dispattr.DisplayName;
            info.ModObjType = type;
            return true;
        }

        static bool ReBuildDevice(string modulename,string name,string jsonstr)
        {
            if (!_dicPlug.ContainsKey(modulename)) return false;
            PlugInsInfo pii = _dicPlug[modulename];
            object[] parameters = new object[1];
            parameters[0] = jsonstr;
            MethodInfo mi = pii.ModObjType.GetMethod("CreateDevice");
            if (mi==null)
            {
                UserLog.AddWarnMsg("重建设备" + name + "失败");
                return false;
            }
            DeviceBase db = (DeviceBase)mi.Invoke(null, parameters);
            if (db == null) return false;
            _dicDevices[name] = db;
            return true; 
        }


        public static int MoveUp(string devname)
        {
            List<string> lstName = _dicDevices.Keys.ToList();
            int idx=lstName.IndexOf(devname);
            if(idx==-1) return idx;
            if (idx == 0) return idx;
            if (lstName.Count == 1) return idx;
            int src = idx;
            int des = idx - 1;
            if (des < 0) return idx;
            string strDes = lstName[des];
            lstName[des] = devname;
            lstName[idx] = strDes;
            Dictionary<string, DeviceBase> dictemp = new Dictionary<string, DeviceBase>();
            foreach(string s in lstName)
            {
                dictemp[s] = _dicDevices[s];
            }
            _dicDevices = dictemp;
            SaveToFile();
            return des;
        }
        public static int MoveDown(string devname)
        {
            List<string> lstName = _dicDevices.Keys.ToList();
            int idx = lstName.IndexOf(devname);
            if (idx == -1) return idx;
            if (idx == (lstName.Count-1)) return idx;
            if (lstName.Count == 1) return idx;
            int src = idx;
            int des = idx +1;
            if (des >= lstName.Count) return idx;
            string strDes = lstName[des];
            lstName[des] = devname;
            lstName[idx] = strDes;
            Dictionary<string, DeviceBase> dictemp = new Dictionary<string, DeviceBase>();
            foreach (string s in lstName)
            {
                dictemp[s] = _dicDevices[s];
            }
            _dicDevices = dictemp;
            SaveToFile();
            return des;
        }
        public static bool SaveToFile(string path="")
        {
            if (string.IsNullOrEmpty(path)) path = SettingPath;
            bool b = false;
            try
            {
                b=JsonHelper.SaveJson(path, _dicDevices);
            }
            catch (Exception ex)
            {
                UserLog.AddErrorMsg(ex.Message);
            }
            return b;
        }
        public static bool LoadFromFile(string path="")
        {
            InitPlugIn();
            if (!Directory.Exists(Application.StartupPath + "\\Config"))
            {
                Directory.CreateDirectory(Application.StartupPath + "\\Config");
            }
            if (string.IsNullOrEmpty(path)) path = SettingPath;
            if (!File.Exists(path)) return false;
            Dictionary<string,object> dic=JsonHelper.ReadJson<Dictionary<string,object>>(path);
            if(dic == null) return false;
            foreach(var s in dic.Keys)
            {
                JObject obj = (JObject)dic[s];
                string modulename = obj["ModuleName"].ToString();
                string devname = obj["Name"].ToString();
                //true/false
                //bool enable = obj["Enable"].ToString().ToLower()=="true"?true:false;
                //if(!enable)
                //{
                //    UserLog.AddWarnMsg(devname + "目前无须挂载入系统");
                //    continue;
                //}
                ReBuildDevice(modulename, devname, obj.ToString());
            }
            //获取系统所有轴对象
            _dicAxis=GetDevices<AxisBase>();
            return true;
        }

        public static bool CreateDevice(string modulename,string devname)
        {
            if(_dicDevices.ContainsKey(devname))
            {
                UserLog.AddWarnMsg("设备已存在，请换个名字");
                return false;
            }
            if(!_dicPlug.ContainsKey(modulename))
            {
                UserLog.AddWarnMsg("硬件插件"+modulename+"不存在");
                return false;
            }
            PlugInsInfo pi=_dicPlug[modulename];
            DeviceBase dev=pi.ModObjType.Assembly.CreateInstance(pi.ModObjType.FullName) as DeviceBase;
            if(dev==null)
            {
                UserLog.AddErrorMsg("创建设备失败" + modulename);
                return false;
            }
            dev.Name = devname;
            return AddDevice(dev);
        }
        public static bool AddDevice(DeviceBase device)
        {
            if(_dicDevices.Keys.Contains(device.Name))
            {
                UserLog.AddWarnMsg("设备名"+device.Name+"已经存在");
                return false;
            }
            _dicDevices[device.Name] = device;
            if(device is AxisBase)
            {
                _dicAxis[device.Name]=device as AxisBase;
            }
            return true;
        }

        public static bool RemoveDevice(string  deviceName)
        {
            if (string.IsNullOrEmpty(deviceName))
            {
                return false;
            }
            if (!_dicDevices.Keys.Contains(deviceName))
            {
                UserLog.AddWarnMsg("设备" + deviceName + "不存在");
                return false;
            }
            _dicDevices.Remove(deviceName);
            if(_dicAxis.ContainsKey(deviceName))
            {
                _dicAxis.Remove(deviceName);
            }
            return true;
        }

        public static List<string> GetDevicesName()
        {
            return _dicDevices.Keys.ToList();
        }
        public static bool ReName(string newname,string oldname)
        {
            if(!_dicDevices.Keys.Contains(oldname))
            {
                UserLog.AddWarnMsg("重命名就设备名" + oldname + "失败，设备不存在");
                return false;
            }
            if(_dicDevices.Keys.Contains(newname))
            {
                UserLog.AddWarnMsg("重命名就设备名" + oldname + "失败，已有同样的设备名");
                return false;
            }
            DeviceBase device = _dicDevices[oldname];
            device.Name = newname;
            _dicDevices.Remove(oldname);
            _dicDevices[newname] = device;

            if(_dicAxis.ContainsKey(oldname))
            {
                AxisBase ab=_dicAxis[oldname];
                _dicAxis.Remove(oldname);
                _dicAxis[newname] = ab;
            }
            return true;
        }

        public static DeviceBase GetDeviceByName(string devname)
        {
            if (string.IsNullOrEmpty(devname)) return null;
            if(!_dicDevices.ContainsKey(devname))
            {
                return null;
            }
            return _dicDevices[devname];
        }
        public static List<string> GetModulesName()
        {
            return _dicPlug.Keys.ToList();
        }

        /// <summary>
        /// 获取所有设备
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static Dictionary<string,T> GetDevices<T>() where T:DeviceBase
        {
            Dictionary<string, T> dic=new Dictionary<string, T> ();
            List<T> dev = GetDevicesList<T>();
            foreach(T devElement in dev)
            {
                dic[devElement.Name] = devElement;
            }
            return dic;
        }

        /// <summary>
        /// 获取第一个设备
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static T GetFirstOrDefaultDevice<T>() where T:DeviceBase
        {
            List<DeviceBase> lst = _dicDevices.Values.ToList();
            T device = lst.Find(x => x is T) as T;
            return device;

        }

        /// <summary>
        /// 获取轴
        /// </summary>
        /// <param name="devname"></param>
        /// <returns></returns>
        public static AxisBase GetAxis(string devname)
        {
            if (string.IsNullOrEmpty(devname)) return null;
            if(_dicAxis.ContainsKey (devname)) return _dicAxis[devname];
            return null;
        }

        /// <summary>
        /// 获取系统所有的轴
        /// </summary>
        /// <returns></returns>
        public static List<AxisBase> GetAxisList()
        {
            return _dicAxis.Values.ToList();
        }

        /// <summary>
        /// 获取所有轴的名称
        /// </summary>
        /// <returns></returns>
        public static List<string> GetAxisNames()
        {
            return _dicAxis.Keys.ToList();
        }

        public static bool OpenAllDevice()
        {
            foreach(string k in _dicDevices.Keys)
            {
                DeviceBase dev = _dicDevices[k];
                if(!dev.Enable)
                {
                    UserLog.AddWarnMsg(dev.Name + "非使能状态，无须打开");
                    continue;
                }
                if(!dev.Open())
                {
                    UserLog.AddWarnMsg(dev.Name + "打开失败");
                    continue;
                }
            }
            return true;
        }

        public static bool CloseAllDevice()
        {
            foreach (string k in _dicDevices.Keys)
            {
                DeviceBase dev = _dicDevices[k];
                dev.Close();
            }
            return true;
        }

        public static T GetDevice<T>(string devname) where T:DeviceBase
        {

            if(string.IsNullOrEmpty(devname)||!_dicDevices.ContainsKey(devname))
            {
                UserLog.AddErrorMsg("无法找到设备名为" + devname + "的设备");
                return null;
            }
            return _dicDevices[devname] as T;
        }

        public static List<T> GetDevicesList<T>() where T:DeviceBase
        {
            List<T> lst=new List<T>();
            foreach(DeviceBase db in _dicDevices.Values)
            {
                if(db is T)
                {
                    lst.Add((T)db);
                }
            }
            lst.Sort((x, y) =>
            {
                return x.Order.CompareTo(y.Order);
            });
            return lst;
        }

        public static Dictionary<string,T> GetDevicesDictionary<T>() where T:DeviceBase
        {
            List<T> lst = GetDevicesList<T>();
            Dictionary<string, T> dic = new Dictionary<string, T>();
            foreach(T t in lst)
            {
                dic[t.Name] = t;
            }
            return dic;
        }
    }


    [Serializable]
    public class PlugInsInfo
    {
        public Type ModObjType { get; set; }

        public string Name { get; set; } = "";
    }
}
