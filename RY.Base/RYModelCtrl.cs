using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RY.Base
{

    public class RYModelCtrl
    {
        private Dictionary<string, object> dicModel = new Dictionary<string, object>();
        private Dictionary<string, string> dicPath = new Dictionary<string, string>();

        //模型所在目录
        public string Dir
        { get; set; } = "";

        //模型的后缀名*.proc
        public string DotName
        { get; set; } = "*.*";

        public List<string> ListModel()
        {
            return dicModel.Keys.ToList();

        }

        public bool Exists(string modelName)
        {
            if (string.IsNullOrEmpty(modelName)) return false;
            if (dicModel.ContainsKey(modelName.ToLower())) return true;
            return false;
        }

        public void SetUp()
        {
            string fn = Application.StartupPath;
            if (Dir != "")
            {
                fn += "\\";
                fn += Dir;
            }
            dicModel.Clear();
            dicPath.Clear();
            if (!Directory.Exists(fn))
            {
                Directory.CreateDirectory(fn);
            }
            string[] tFile = Directory.GetFiles(fn, "*" + DotName);
            for (int i = 0; i < tFile.Length; i++)
            {
                FileInfo fileInfo = new FileInfo(tFile[i]);
                dicPath[fileInfo.Name.ToLower()] = tFile[i];
                dicModel[fileInfo.Name.ToLower()] = null;
            }
        }

        public T GetModel<T>(string modelName) where T:ConfigBase
        {
            if (string.IsNullOrEmpty(modelName)) return null;
            string name = modelName.ToLower();
            if (!dicModel.ContainsKey(name)) return null;
            if (dicModel.ContainsKey(name) && dicModel[name] == null)
            {
                T tm = JsonHelper.ReadJson<T>(dicPath[name]);
                if (tm == null)
                {
                    File.Delete(dicPath[name]);
                    dicPath.Remove(name);
                    dicModel.Remove(name);
                    return null;
                }
                tm.Name = modelName;
                tm.SetPath(dicPath[name]);
                dicModel[name] = tm;
            }
            return dicModel[name] as T;
        }

        public Dictionary<string, T> GetExistModel<T>(List<string> lstNames) where T : ConfigBase
        {
            Dictionary<string, T> dic = new Dictionary<string, T>();
            foreach (string k in lstNames)
            {
                T m = GetModel<T>(k);
                if (m == null) continue;
                dic[k] = m;
            }
            return dic;
        }
        public void AddModel(string modelName, object cfg)
        {
            if (dicModel.ContainsKey(modelName.Trim().ToLower()))
            {
                MsgBox.ShowWarning("该名字系统已经存在，请换一个！");
                return;
            }
            dicModel[modelName.ToLower()] = cfg;

            string fn = Application.StartupPath + "\\" + Dir + "\\" + modelName;
            if(cfg is ConfigBase)
            {
                ConfigBase cb= cfg as ConfigBase;
                cb.SetPath(fn);
                cb.Name = modelName;
            }
            JsonHelper.SaveJson(fn, cfg,false);
            dicPath[modelName.ToLower()] = fn;
            MsgBox.ShowSuccess("添加模型成功！");
        }


        public void CopyModel<T>(string oldModelName, string newModelName) where T : ConfigBase
        {
            if (oldModelName.ToLower() == newModelName.Trim().ToLower())
            {
                MsgBox.ShowWarning("两个名字一样，请换一个！");
                return;
            }
            if (!dicModel.ContainsKey(oldModelName.ToLower()))
            {
                MsgBox.ShowWarning("要复制的模型不存在！");
                return;
            }
            if (dicModel.ContainsKey(newModelName.ToLower()))
            {
                MsgBox.ShowWarning("复制到的模型已存在！");
                return;
            }
            string n = Application.StartupPath + "\\" + Dir + "\\" + newModelName;
            string o = Application.StartupPath + "\\" + Dir + "\\" + oldModelName;
            File.Copy(o, n);
            T tm = JsonHelper.ReadJson<T>(n);
            if (tm == null)
            {
                File.Delete(n);
                return;
            }
            tm.SetPath(n);
            tm.Name = newModelName;
            dicModel[newModelName.Trim().ToLower()] = tm;
            dicPath[newModelName.Trim().ToLower()] = n;
            MsgBox.ShowSuccessTip("复制模型成功！");
        }

        public void DeleteModel(string modelName)
        {
            if (dicModel.ContainsKey(modelName.ToLower()))
            {
                dicModel.Remove(modelName.ToLower());
                dicPath.Remove(modelName.ToLower());
            }
            string fn = Application.StartupPath + "\\" + Dir + "\\" + modelName;
            if (File.Exists(fn))
            {
                File.Delete(fn);
            }
            MsgBox.ShowSuccessTip("删除模型成功！");
        }
        public bool SaveModel(string modelName)
        {
            if (!dicModel.ContainsKey(modelName.ToLower()))
            {
                MsgBox.ShowWarning("要保存的模型不存在！");
                return false;
            }
            object tm = dicModel[modelName.ToLower()];
            string fn = Application.StartupPath + "\\" + Dir + "\\" + modelName;
            return JsonHelper.SaveJson(fn, tm,false);
        }

        public bool SaveModel(string modelName, object obj)
        {
            dicModel[modelName] = obj;
            return SaveModel(modelName);
        }
    }

    public class RYTypeModelCtrl
    {
        private Dictionary<string, object> dicModel = new Dictionary<string, object>();
        private Dictionary<string, string> dicPath = new Dictionary<string, string>();

        //模型所在目录
        public string Dir
        { get; set; } = "";

        //模型的后缀名*.proc
        public string DotName
        { get; set; } = "*.*";

        public List<string> ListModel()
        {
            return dicModel.Keys.ToList();

        }

        public bool Exists(string modelName)
        {
            if (string.IsNullOrEmpty(modelName)) return false;
            if (dicModel.ContainsKey(modelName.ToLower())) return true;
            return false;
        }

        Type _type=null;
        public void SetUp(Type type)
        {
            string fn = Application.StartupPath;
            if (Dir != "")
            {
                fn += "\\";
                fn += Dir;
            }
            dicModel.Clear();
            dicPath.Clear();
            _type = type;
            if (!Directory.Exists(fn))
            {
                Directory.CreateDirectory(fn);
            }
            string[] tFile = Directory.GetFiles(fn, "*" + DotName);
            for (int i = 0; i < tFile.Length; i++)
            {
                FileInfo fileInfo = new FileInfo(tFile[i]);
                dicPath[fileInfo.Name.ToLower()] = tFile[i];
                dicModel[fileInfo.Name.ToLower()] = null;
            }
        }

        public object GetModel(string modelName)
        {
            if (string.IsNullOrEmpty(modelName)) return null;
            string name = modelName.ToLower();
            if (!dicModel.ContainsKey(name)) return null;
            if (dicModel.ContainsKey(name) && dicModel[name] == null)
            {
                object tm = JsonHelper.ReadJson(dicPath[name],_type);
                if (tm == null)
                {
                    File.Delete(dicPath[name]);
                    dicPath.Remove(name);
                    dicModel.Remove(name);
                    return null;
                }
                if(tm is ConfigBase)
                {
                    ((ConfigBase)tm).SetPath(dicPath[name]);
                    ((ConfigBase)tm).Name=modelName;
                }
                dicModel[name] = tm;
            }
            return dicModel[name];
        }

        //RYProject
        public T GetModel<T>(string modelName) where T : ConfigBase
        {
            if(GetModel(modelName)== null) return null; 
            return dicModel[modelName] as T;
        }

        public Dictionary<string, T> GetExistModel<T>(List<string> lstNames) where T : ConfigBase
        {
            Dictionary<string, T> dic = new Dictionary<string, T>();
            foreach (string k in lstNames)
            {
                T m = GetModel<T>(k);
                if (m == null) continue;
                dic[k] = m;
            }
            return dic;
        }
        public void AddModel(string modelName)
        {
            if (dicModel.ContainsKey(modelName.Trim().ToLower()))
            {
                MsgBox.ShowWarning("该名字系统已经存在，请换一个！");
                return;
            }
            dicModel[modelName.ToLower()] = Activator.CreateInstance(_type);

            string fn = Application.StartupPath + "\\" + Dir + "\\" + modelName;
            if (dicModel[modelName.ToLower()] is ConfigBase)
            {
                ConfigBase cb = dicModel[modelName.ToLower()] as ConfigBase;
                cb.SetPath(fn);
                cb.Name = modelName;
            }
            JsonHelper.SaveJson(fn, dicModel[modelName.ToLower()], false);
            dicPath[modelName.ToLower()] = fn;
            MsgBox.ShowSuccess("添加模型成功！");
        }

        public void Rename(string oldModelName, string newModelName)
        {
            if (oldModelName.ToLower() == newModelName.Trim().ToLower())
            {
                MsgBox.ShowWarning("两个名字一样，请换一个！");
                return;
            }
            if (!dicModel.ContainsKey(oldModelName.ToLower()))
            {
                MsgBox.ShowWarning("要复制的模型不存在！");
                return;
            }
            if (dicModel.ContainsKey(newModelName.ToLower()))
            {
                MsgBox.ShowWarning("复制到的模型已存在！");
                return;
            }
            string n = Application.StartupPath + "\\" + Dir + "\\" + newModelName;
            string o = Application.StartupPath + "\\" + Dir + "\\" + oldModelName;
            File.Copy(o, n);
            object tm = JsonHelper.ReadJson(n, _type);
            if (tm == null)
            {
                File.Delete(n);
                return;
            }
            if (tm is ConfigBase)
            {
                ((ConfigBase)tm).SetPath(n);
                ((ConfigBase)tm).Name=newModelName;
            }

            dicModel[newModelName.Trim().ToLower()] = tm;
            dicPath[newModelName.Trim().ToLower()] = n;


            if (dicModel.ContainsKey(oldModelName.ToLower()))
            {
                dicModel.Remove(oldModelName.ToLower());
                dicPath.Remove(oldModelName.ToLower());
            }
            string fn = Application.StartupPath + "\\" + Dir + "\\" + oldModelName;
            if (File.Exists(fn))
            {
                File.Delete(fn);
            }
            MsgBox.ShowSuccessTip("重命名模型成功！");
        }

        public void CopyModel(string oldModelName, string newModelName)
        {
            if (oldModelName.ToLower() == newModelName.Trim().ToLower())
            {
                MsgBox.ShowWarning("两个名字一样，请换一个！");
                return;
            }
            if (!dicModel.ContainsKey(oldModelName.ToLower()))
            {
                MsgBox.ShowWarning("要复制的模型不存在！");
                return;
            }
            if (dicModel.ContainsKey(newModelName.ToLower()))
            {
                MsgBox.ShowWarning("复制到的模型已存在！");
                return;
            }
            string n = Application.StartupPath + "\\" + Dir + "\\" + newModelName;
            string o = Application.StartupPath + "\\" + Dir + "\\" + oldModelName;
            File.Copy(o, n);
            object tm = JsonHelper.ReadJson(n,_type);
            if (tm == null)
            {
                File.Delete(n);
                return;
            }
            if(tm is ConfigBase)
            {
                ((ConfigBase)tm).SetPath(n);
                ((ConfigBase)tm).Name=newModelName;
            }
            
            dicModel[newModelName.Trim().ToLower()] = tm;
            dicPath[newModelName.Trim().ToLower()] = n;
            MsgBox.ShowSuccessTip("复制模型成功！");
        }

        public void DeleteModel(string modelName)
        {
            if (dicModel.ContainsKey(modelName.ToLower()))
            {
                dicModel.Remove(modelName.ToLower());
                dicPath.Remove(modelName.ToLower());
            }
            string fn = Application.StartupPath + "\\" + Dir + "\\" + modelName;
            if (File.Exists(fn))
            {
                File.Delete(fn);
            }
            MsgBox.ShowSuccessTip("删除模型成功！");
        }
        public bool SaveModel(string modelName)
        {
            if (!dicModel.ContainsKey(modelName.ToLower()))
            {
                MsgBox.ShowWarning("要保存的模型不存在！");
                return false;
            }
            object tm = dicModel[modelName.ToLower()];
            string fn = Application.StartupPath + "\\" + Dir + "\\" + modelName;
            return JsonHelper.SaveJson(fn, tm, false);
        }

        public bool SaveModel(string modelName, object obj)
        {
            dicModel[modelName] = obj;
            return SaveModel(modelName);
        }
    }
}
