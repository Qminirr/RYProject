using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RY.Base
{
    public class WaitTimer
    {
        public static bool Wait(double ms,Func<bool> func)
        {
            DateTime start = DateTime.Now;
            while(true)
            {
                if(func()) return true;
                double t = DateTime.Now.Subtract(start).TotalMilliseconds;
                if(t > ms) return false;
                Application.DoEvents();
                Thread.Sleep(5);
            }
        }

        public static void Sleep(double ms)
        {
            DateTime start = DateTime.Now;
            while (true)
            {
                double t = DateTime.Now.Subtract(start).TotalMilliseconds;
                if (t > ms) return;
                Application.DoEvents();
                Thread.Sleep(5);
            }
        }
    }
}
