using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace RY.Base
{
    public interface IRYModalEditor
    {
        void SetValue(object obj, object instance);

        object GetValue();
    }

    public interface IRYFunc
    {
        string Name { get; set; }

        List<ParameterInfo> ParamList
        { get; set; }


        string Remark
        { get; set; }


        string GetParamInfo();

        bool IsParamOK(params object[] param);
    }
}
