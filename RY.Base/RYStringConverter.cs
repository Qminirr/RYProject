using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RY.Base
{

    #region 插件dll名字转化
    public class PlugInNameConverter:StringConverter
    {
        //[TypeConverter(typeof(PlugInNameConverter))]
        public override bool GetStandardValuesSupported(ITypeDescriptorContext context)
        {
            return true;
        }

        public override bool GetStandardValuesExclusive(ITypeDescriptorContext context)
        {
            return true;
        }
        public override StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
        {
            string _trayPath = Application.StartupPath + "\\PlugIns\\";
            if (!Directory.Exists(_trayPath))
            {
                Directory.CreateDirectory(_trayPath);
            }
            string[] tFile = Directory.GetFiles(_trayPath, "*.dll");
            List<string> lst = new List<string>();
            for (int i = 0; i < tFile.Length; i++)
            {
                FileInfo fileInfo = new FileInfo(tFile[i]);
                lst.Add(fileInfo.Name.ToLower());

            }
            lst.Add("");
            return new StandardValuesCollection(lst);
        }

    }

    #endregion

    #region 流程名称转化

    public class ProcessNameConverter : StringConverter
    {
        //[TypeConverter(typeof(ProcessNameConverter))]
        public override bool GetStandardValuesSupported(ITypeDescriptorContext context)
        {
            return true;
        }

        public override bool GetStandardValuesExclusive(ITypeDescriptorContext context)
        {
            return true;
        }
        public override StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
        {
            string _trayPath = Application.StartupPath + "\\Process\\";
            if (!Directory.Exists(_trayPath))
            {
                Directory.CreateDirectory(_trayPath);
            }
            string[] tFile = Directory.GetFiles(_trayPath, "*.proc");
            List<string> lst = new List<string>();
            for (int i = 0; i < tFile.Length; i++)
            {
                FileInfo fileInfo = new FileInfo(tFile[i]);
                lst.Add(fileInfo.Name.ToLower());

            }
            lst.Add("");
            return new StandardValuesCollection(lst);
        }

    }
    #endregion
}
