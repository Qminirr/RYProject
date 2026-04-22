using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace RY.Base
{
    /// <summary>
    /// 通用集合编辑器：解析Display特性，适配所有类
    /// </summary>
    /// <typeparam name="T">集合元素类型</typeparam>
    public class GenericCollectionEditor<T> : CollectionEditor
    {

        //[Editor(typeof(GenericCollectionEditor<User>), typeof(UITypeEditor))]
        public GenericCollectionEditor() : base(typeof(List<T>)) { }

        protected override string GetDisplayText(object value)
        {
            //if (value is T obj)
            //{
            //    Type type = typeof(T);
            //    // 解析类上的Display特性
            //    var displayAttr = type.GetCustomAttribute<DisplayAttribute>();
            //    if (displayAttr != null)
            //    {
            //        // 若有属性标识“主键/名称”，可拼接（示例：取UserName属性）
            //        PropertyInfo nameProp = type.GetProperty("UserName");
            //        if (nameProp != null && nameProp.GetValue(obj) is string name && !string.IsNullOrEmpty(name))
            //        {
            //            return $"{displayAttr.Name}：{name}";
            //        }
            //        return displayAttr.Name;
            //    }
            //}
            return base.GetDisplayText(value);
        }

        protected override CollectionForm CreateCollectionForm()
        {
            var form = base.CreateCollectionForm();
            Type type = typeof(T);
            var displayAttr = type.GetCustomAttribute<DisplayNameAttribute>();
            form.Text = $"{displayAttr?.DisplayName ?? type.Name}集合编辑器";
            return form;
        }
    }
}
