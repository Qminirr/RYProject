using SunnyUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RY.Device
{
    public abstract class WCFBase : DeviceBase
    {
        public abstract DateTime GetServerTime();

        public abstract int Add(int a, int b);

        public override UIPage GetDebugPage()
        {
            return null;
        }

    }
}
