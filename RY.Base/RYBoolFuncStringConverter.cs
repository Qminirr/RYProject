using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.TypeConverter;

namespace RY.Base
{
    public class RYBoolFuncStringConverter:StringConverter
    {
        // //[TypeConverter(typeof(RYBoolFuncStringConverter))]
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
            List<string> lst = RYBoolDelegateFactory.GetNames();
            lst.Add("");
            return new StandardValuesCollection(lst);
        }
    }
}
