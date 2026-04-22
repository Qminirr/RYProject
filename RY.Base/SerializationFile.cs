using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace RY.Base
{
    public class SerializationFile
    {

        /// <summary>
        /// 序列化对象
        /// </summary>
        /// <param name="filePath">序列化保存路径</param>
        /// <param name="obj">序列化对象</param>
        public static bool SerializeObject(string filePath, object obj)//序列化
        {
            bool bOK = false;
            FileInfo fi = new FileInfo(filePath);
            if (!fi.Directory.Exists)
            {
                fi.Directory.Create(); //先创建文件目录，下面创建文件实例，事实上可以用下面一步到位。
            }
            string fakefile = filePath + "f";
            try
            {
                using (FileStream fileStream = new FileStream(fakefile, FileMode.Create))
                {
                    BinaryFormatter b = new BinaryFormatter();
                    b.Serialize(fileStream, obj);
                }

                File.Copy(fakefile, filePath, true);
                File.Delete(fakefile);
                bOK = true;
            }
            catch (OutOfMemoryException ex)
            {
                //UserLog.AddMsg(typeof(SerializationFile), ex);
                throw new Exception("内存不足,请检查设置");
            }
            catch (Exception ex)
            {
                UserLog.AddErrorMsg(string.Format("{0}类型对象序列化失败", obj.GetType()));
                //UserLog.AddMsg(typeof(SerializationFile), ex);
                // throw new Exception("对象未完全初始化,请检查设置");
            }
            return bOK;

        }

        /// <summary>
        /// 反序列化文件
        /// </summary>
        /// <param name="filePath">文件路径</param>
        /// <returns>反序列化后的对象</returns>
        public static object DeserializeObject(string filePath, SerializationBinder binder = null)
        {
            object obj = new object();
            FileStream fileStream = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Read, FileShare.Read);
            try
            {
                BinaryFormatter b = new BinaryFormatter();
                if (binder != null) b.Binder = binder;
                obj = b.Deserialize(fileStream);             //如果是空的，在反序列化时出错。        
            }
            catch (Exception ex)
            {
                obj = null;
                //UserLog.AddMsg(typeof(SerializationFile), ex);
                Debug.WriteLine("反序列化数据失败" + ex.Message);
            }
            finally
            {
                fileStream.Close();
            }
            return obj;
        }

        public static T DeserializeObject<T>(string fn) where T : class
        {
            if (!File.Exists(fn))
            {
                UserLog.AddErrorMsg("模型文件不存在！" + fn);
                return null;
            }
            T obj = DeserializeObject(fn) as T;
            return obj;
        }
        /// <summary>
        /// 深度拷贝对象集合
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="List"></param>
        /// <returns></returns>
        public static List<T> Clone<T>(object List)
        {
            using (Stream objectStream = new MemoryStream())
            {
                IFormatter formatter = new BinaryFormatter();
                formatter.Serialize(objectStream, List);
                objectStream.Seek(0, SeekOrigin.Begin);
                return formatter.Deserialize(objectStream) as List<T>;
            }
        }
    }
}
