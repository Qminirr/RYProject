using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RY.Device.Helper
{
    public class RYClientConnectedEventArgs
    {
        public RYClientConnectedEventArgs(string msg,object clientObj)
        {
            Client=clientObj;
            Msg=msg;
        }

        public object Client
        { get; private set; } = null;

        public string Msg
        { get; private set; } = "";

    }
}
