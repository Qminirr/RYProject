using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RY.Device
{
    public interface IDevice
    {
    }
    public interface IPulseConsume
    {
        int TimeTick
        { get; set; }

        void PulseComing(object sender, EventArgs e);
    }

    public interface IUIControl
    {
        void UIClose();
    }
}
