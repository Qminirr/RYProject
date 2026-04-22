using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
namespace RY.Base
{
    public class JsonHelper
    {
        /// <summary>
        /// 将json转化为对象
        /// (需要提前构造好结构一致的Model接取数据，且同名字段才可接取数据)
        /// </summary>
        /// <typeparam name="T">对象类型</typeparam>
        /// <param name="json">Json字符串</param>
        /// <returns></returns>
        //public static T ConvertJsonToObject<T>(string json)
        //{
        //    try
        //    {
        //        DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(T));  //传入对象类型               
        //        MemoryStream stream = new MemoryStream(Encoding.UTF8.GetBytes(json));   //把Json传入内存流中保存               
        //        T obj = (T)serializer.ReadObject(stream);   //使用ReadObject方法反序列化成对象
        //        return obj;
        //    }
        //    catch(Exception ex) { throw ex; }

        //}

        /// <summary>
        /// 将对象转化为Json
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static string ConvertObjectToJson(object obj)
        {
            try
            {
                //string jsonstr=
                string jsonStr = JsonConvert.SerializeObject(obj);  //序列化对象
                return jsonStr;
            }
            catch (Exception ex) { throw ex; }
        }

        private static void writeJsonFile(string path, string jsonConents)
        {
            using (FileStream fs = new FileStream(path, FileMode.Create, System.IO.FileAccess.ReadWrite, FileShare.ReadWrite))
            {
                using (StreamWriter sw = new StreamWriter(fs, Encoding.UTF8))
                {
                    sw.WriteLine(jsonConents);
                }
            }
        }

        private static string GetJsonFile(string filepath)
        {
            string json = string.Empty;
            using (FileStream fs = new FileStream(filepath, FileMode.OpenOrCreate, System.IO.FileAccess.ReadWrite, FileShare.ReadWrite))
            {
                using (StreamReader sr = new StreamReader(fs, Encoding.UTF8))
                {
                    json = sr.ReadToEnd().ToString();
                }
            }
            return json;

        }

        public static bool SaveJson(string filepath, object obj, bool ForceBackup = true)
        {
            try
            {
                //if (File.Exists(filepath) && ForceBackup)
                //{
                //    FileInfo inf = new FileInfo(filepath);
                //    string dir = inf.DirectoryName;
                //    string backupPath = dir + "\\backup\\";
                //    if (!Directory.Exists(backupPath))
                //    {
                //        Directory.CreateDirectory(backupPath);
                //    }
                //    string newfile = backupPath + inf.Name;
                //    File.Copy(filepath, newfile, true);
                //    //File.Delete(filepath);
                //}
                string json = JsonConvert.SerializeObject(obj);
                writeJsonFile(filepath, json);
                return true;
            }
            catch (Exception ex)
            {
                UserLog.AddErrorMsg("保存Json文件失败" + ex.Message);
                return false;
            }

        }

        public static T ReadJson<T>(string filepath)
        {
            string jsonData = GetJsonFile(filepath);
            //return ConvertJsonToObject<T>(jsonData);
            return JsonConvert.DeserializeObject<T>(jsonData);
        }

        public static object ReadJson(string filepath,Type targettype)
        {
            string jsonData = GetJsonFile(filepath);
            return JsonConvert.DeserializeObject(jsonData, targettype);
        }
        public static T ParseJson<T>(string jsonData)
        {
            return JsonConvert.DeserializeObject<T>(jsonData);
        }

        public static T ParseArray<T>(object obj) where T : class
        {
            JArray j = obj as JArray;
            if (j == null) return null;
            T t = j.ToObject<T>();
            return t;


        }

    }
}
