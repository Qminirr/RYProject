using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RY.Base;
using RY.Device;
namespace RYProject
{
    public partial class G:GBase
    {

     
        [RYBoolDelegate("安全门检测", eRYBoolDelegateType.检测, "安全门检测")]
        public static bool SafeCheck()
        {
            ///
            return true;
        }

        [RYBoolDelegate("计算", eRYBoolDelegateType.通用功能, "2个数字相加")]
        public static bool Calc(int a,int b)
        {
            int s = a + b;
            UserLog.AddRunMsg("我的计算结果是"+s.ToString());
            return true;
        }
    }
}
