using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RY.Base
{
    [Serializable]
    public abstract class ConfigBase
    {

        string _path = "";

        [JsonIgnore]
        [Browsable(false)]
        public string Name
        { get; set; } = "";

        public void SetPath(string path)
        {
            _path = path;
        }


        public bool Save()
        {
            if(string.IsNullOrEmpty(_path))
            {
                UserLog.AddErrorMsg("无法保存配置");
                return false;
            }
            return JsonHelper.SaveJson(_path, this,false);
        }
    }
}
