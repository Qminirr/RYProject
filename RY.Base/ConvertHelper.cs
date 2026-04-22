using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RY.Base
{
    public class ConvertHelper
    {
        public static object ChangeTo(object obj, Type conversionType)
        {
            return ChangeTo(obj, conversionType, Thread.CurrentThread.CurrentCulture);
        }
        public static bool CanChangeTo(object obj, Type conversionType)
        {
            return CanChangeTo(obj, conversionType, Thread.CurrentThread.CurrentCulture);
        }
        public static bool CanChangeTo(object obj, Type conversionType, IFormatProvider provider)
        {
            try
            {
                #region Nullable
                Type nullableType = Nullable.GetUnderlyingType(conversionType);
                if (nullableType != null)
                {
                    if (obj == null)
                    {
                        return true;
                    }
                    return Convert.ChangeType(obj, nullableType, provider) != null;
                }
                #endregion
                if (typeof(System.Enum).IsAssignableFrom(conversionType))
                {
                    object o = Enum.Parse(conversionType, obj.ToString(), true);
                    if (o == null) return false;
                    if (Enum.GetName(conversionType, o) == null) return false;
                    return true;
                }
                return Convert.ChangeType(obj, conversionType, provider) != null;
            }
            catch(Exception ex) 
            {
                return false;
            }
            return false;
        }
        public static object ChangeTo(object obj, Type conversionType, IFormatProvider provider)
        {
            #region Nullable
            Type nullableType = Nullable.GetUnderlyingType(conversionType);
            if (nullableType != null)
            {
                if (obj == null)
                {
                    return null;
                }
                return Convert.ChangeType(obj, nullableType, provider);
            }
            #endregion
            if (typeof(System.Enum).IsAssignableFrom(conversionType))
            {
                object o = Enum.Parse(conversionType, obj.ToString(), true);
                if (o == null) return o;
                if (Enum.GetName(conversionType, o) == null) return null;
                return o;
            }
            return Convert.ChangeType(obj, conversionType, provider);
        }
    }
}
