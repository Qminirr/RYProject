using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace RY.Base
{
    public class RYModalEditor<T>:UITypeEditor where T:UserControl,IRYModalEditor,new()
    {
        public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context)
        {
            return UITypeEditorEditStyle.Modal;
        }
        public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value)
        {
            var edsvc = provider.GetService(typeof(IWindowsFormsEditorService)) as IWindowsFormsEditorService;
            if (edsvc != null)
            {

                var dev = context.Instance;
                var popControl = new T();
                popControl.SetValue(value, dev);

                edsvc.DropDownControl(popControl);
                value = popControl.GetValue();
            }
            return base.EditValue(context, provider, value);
        }
    }
}
