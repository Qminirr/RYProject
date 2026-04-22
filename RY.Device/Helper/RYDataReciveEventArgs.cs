using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RY.Device
{
    public class RYDataReciveEventArgs
    {
        public RYDataReciveEventArgs(byte[] bt,object source)
        {
            bindata = bt;
            data = System.Text.Encoding.UTF8.GetString(bindata);
            DataSource = source;
        }
        private byte[] bindata;
        private string data;

        public object DataSource
        { get; set; } = "";
        public string Data
        {
            get { return data; }
        }

        public byte[] BinData
        {
            get
            {
                return bindata;
            }
        }
    }
}
