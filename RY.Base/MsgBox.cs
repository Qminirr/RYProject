using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SunnyUI;
using System.Collections;
using System.Drawing;
using System.ComponentModel;
using System.Windows.Forms;

namespace RY.Base
{
    public class MsgBox
    {

        /// <summary>
        /// 显示进度提示窗
        /// </summary>
        /// <param name="desc">描述文字</param>
        /// <param name="maximum">最大进度值</param>
        /// <param name="decimalCount">显示进度条小数个数</param>
        public void ShowStatusForm(int maximum = 100, string desc = "系统正在处理中，请稍候...", int decimalCount = 1)
        {
            UIStatusFormService.ShowStatusForm(maximum, desc, decimalCount);
        }

        /// <summary>
        /// 隐藏进度提示窗
        /// </summary>
        public void HideStatusForm()
        {
            UIStatusFormService.HideStatusForm();
        }

        /// <summary>
        /// 设置进度提示窗步进值加1
        /// </summary>
        public void StatusFormStepIt()
        {
            UIStatusFormService.StepIt();
        }

        /// <summary>
        /// 设置进度提示窗描述文字
        /// </summary>
        /// <param name="desc">描述文字</param>
        public void SetStatusFormDescription(string desc)
        {
            UIStatusFormService.SetDescription(desc);
        }
        private static bool Show(string message,string title="提示",bool isShowCancel=true, string btnOKText = "确定", string btnCancelText = "取消",UIStyle style=UIStyle.Blue,bool showMask=true,bool topMost=true)
        {
            return UIMessageDialog.ShowMessageDialog(message, title, isShowCancel, btnOKText,btnCancelText, style, showMask, topMost);
        }

        public static void ShowOnly(string message,string title="提示")
        {
            Show(message, title, false);
        }
        public static bool ShowWarning(string message, string btnOKText = "确定", string btnCancelText = "取消",UIStyle style=UIStyle.Orange, bool showMask = true, bool topMost = true)
        {
            return Show(message, "警告", false, btnOKText, btnCancelText, style,showMask,topMost);
        }

        public static bool ShowTimeOutDialog(string msg, string title="等待选择", int timeoutsec=5, bool timeoutresult=true, bool showCancel=true, UIStyle style = UIStyle.Blue, bool showMask = true, bool topMost = true)
        {
            return UITimeOutDialog.ShowTimeOutDialog(msg, title, timeoutsec, timeoutresult, showCancel, style, showMask, topMost);
        }
        public static bool ShowError(string message, string btnOKText = "确定", string btnCancelText = "取消",UIStyle style=UIStyle.Red, bool showMask = true, bool topMost = true)
        {
            return Show(message, "错误", false, btnOKText, btnCancelText, style, showMask,topMost);
        }
        
        public static bool ShowAsk(string message, string btnOKText = "确定", string btnCancelText = "取消",UIStyle style=UIStyle.Blue, bool showMask = true, bool topMost = true)
        {
            return Show(message, "请选择", true, btnOKText, btnCancelText, style, showMask,topMost);
        }

        public static int ShowAsk3(string message,string btnleft="下一个",string btnmid="重试",string btnright="取消", UIStyle style = UIStyle.Blue, bool showMask = true, bool topMost = true)
        {
            return UIMessageDialog.ShowAsk3Dialog(message, "请确认", style, btnleft, btnmid, btnright, showMask, topMost);
        }

        public static int ShowAsk4(string message, string btnleft = "确定", string btnmidleft = "重试", string btnmidright = "下一个", string btnright = "取消", UIStyle style = UIStyle.Blue, bool showMask = true, bool topMost = true)
        {
            return UIMessageDialog.ShowAsk4Dialog(message, "请确认", style, btnleft, btnmidleft,btnmidright, btnright, showMask, topMost);
        }

        public static bool ShowSelect(ref int selectIndex, IList items, string title="提示", string description="请选择", UIStyle style = UIStyle.Blue, bool showMask = true, bool topMost = true)
        {
            return UIMessageDialog.ShowSelectDialog(ref selectIndex, items, title, description, style, showMask, topMost);
        }

        public static bool ShowSelectString(ref string selectText, IList items, string title, string description, UIStyle style = UIStyle.Blue, bool showMask = true, bool topMost = true)
        {
            return UIMessageDialog.ShowSelectStringDialog(ref selectText, items, title, description, style, showMask, topMost);
        }
        public static bool ShowSuccess(string message,string title="成功", string btnOKText = "确定", string btnCancelText = "取消", UIStyle style=UIStyle.Green, bool showMask = true, bool topMost = true)
        {
            return Show(message, title, false, btnOKText, btnCancelText, style, showMask,topMost);
        }
        public static bool ShowInfo(string message, string title = "信息", string btnOKText = "确定", string btnCancelText = "取消", UIStyle style = UIStyle.Gray, bool showMask = true, bool topMost = true)
        {
            return Show(message, title, false, btnOKText, btnCancelText, style, showMask, topMost);
        }
        public static bool ShowInputString(ref string value,bool checkEmpty=true,string desc="请输入字符串:",UIStyle style=UIStyle.Blue,bool topMost=true)
        {
            UIInputForm frm = new UIInputForm();
            frm.TopMost = topMost;
            frm.Style = style;
            frm.Editor.Text = value;
            frm.Text = UILocalize.InputTitle;
            frm.Label.Text = desc;
            frm.CheckInputEmpty = checkEmpty;
            frm.ShowDialog();
            if (frm.IsOK)
            {
                value = frm.Editor.Text;
                return true;
            }

            return false;
        }

        
        private static bool ShowInputPassword(ref string value, bool checkEmpty = true, string desc = "请输入密码：", UIStyle style = UIStyle.Blue, bool topMost = false)
        {
            UIInputForm frm = new UIInputForm();
            frm.TopMost = topMost;
            frm.Style = style;
            frm.Text = UILocalize.InputTitle;
            frm.Label.Text = desc;
            frm.Editor.PasswordChar = '*';
            frm.CheckInputEmpty = checkEmpty;
            frm.ShowDialog();
            if (frm.IsOK)
            {
                value = frm.Editor.Text;
                return true;
            }

            return false;
        }

        public static void ShowWait(string desc="系统正在处理中，请稍候...",string title="请稍等",bool showModal=false)
        {
            UIWaitFormService.ShowWaitForm(desc,title,showModal);
        }

        public static void SetWaitDescription(string desc)
        {
            UIWaitFormService.SetDescription(desc);
        }
        public static void HideWait()
        {
            UIWaitFormService.HideWaitForm();
        }
        public static bool ShowInputInteger(ref int value, bool checkEmpty = true, string desc = "请输入数字：", UIStyle style = UIStyle.Blue, bool topMost = false)
        {
            UIInputForm frm = new UIInputForm();
            frm.TopMost = topMost;
            frm.Style = style;
            frm.Editor.Type = UITextBox.UIEditType.Integer;
            frm.Editor.IntValue = value;
            frm.Text = UILocalize.InputTitle;
            frm.Label.Text = desc;
            frm.CheckInputEmpty = checkEmpty;
            frm.ShowDialog();
            if (frm.IsOK)
            {
                value = frm.Editor.IntValue;
                return true;
            }

            return false;
        }

        public static bool ShowInputInteger(ref int value, int minimum, int maximum, bool checkEmpty = true, string desc = "请输入数字：", UIStyle style = UIStyle.Blue, bool topMost = false)
        {
            UIInputForm frm = new UIInputForm();
            frm.TopMost = topMost;
            frm.Style = style;
            frm.Editor.Type = UITextBox.UIEditType.Integer;
            frm.Editor.IntValue = value;
            frm.Text = UILocalize.InputTitle;
            frm.Label.Text = desc;
            frm.CheckInputEmpty = checkEmpty;
            frm.Editor.MaxLength = 11;
            frm.Editor.Minimum = minimum;
            frm.Editor.Maximum = maximum;
            frm.Editor.HasMaximum = true;
            frm.Editor.HasMinimum = true;
            frm.ShowDialog();
            if (frm.IsOK)
            {
                value = frm.Editor.IntValue;
                return true;
            }

            return false;
        }
        public static bool ShowInputDouble(ref double value, int decimals = 2, bool checkEmpty = true, string desc = "请输入数字：", UIStyle style = UIStyle.Blue, bool topMost = false)
        {
            UIInputForm frm = new UIInputForm();
            frm.TopMost = topMost;
            frm.Style = style;
            frm.Editor.Type = UITextBox.UIEditType.Double;
            frm.Editor.DecLength = decimals;
            frm.Editor.DoubleValue = value;
            frm.Text = UILocalize.InputTitle;
            frm.Label.Text = desc;
            frm.CheckInputEmpty = checkEmpty;
            frm.ShowDialog();
            if (frm.IsOK)
            {
                value = frm.Editor.DoubleValue;
                return true;
            }

            return false;
        }

        public static bool ShowInputDouble(ref double value, double minimum, double maximum, int decimals = 2, bool checkEmpty = true, string desc = "请输入数字：", UIStyle style = UIStyle.Blue, bool topMost = false)
        {
            UIInputForm frm = new UIInputForm();
            frm.TopMost = topMost;
            frm.Style = style;
            frm.Editor.Type = UITextBox.UIEditType.Double;
            frm.Editor.DecLength = decimals;
            frm.Editor.DoubleValue = value;
            frm.Text = UILocalize.InputTitle;
            frm.Label.Text = desc;
            frm.CheckInputEmpty = checkEmpty;
            frm.Editor.Minimum = minimum;
            frm.Editor.Maximum = maximum;
            frm.Editor.HasMaximum = true;
            frm.Editor.HasMinimum = true;
            frm.ShowDialog();
            if (frm.IsOK)
            {
                value = frm.Editor.DoubleValue;
                return true;
            }

            return false;
        }


        private static void ShowNotifier(string desc, UINotifierType type = UINotifierType.INFO, string title = "Notifier", bool isDialog = false, int timeout = 0)
        {
            UINotifierHelper.ShowNotifier(desc, type, title, isDialog, timeout);
        }

        public static void ShowInfoNotifier(string desc, bool isDialog = false,int timeout = 2000)
        {
            ShowNotifier(desc, UINotifierType.INFO, UILocalize.InfoTitle, isDialog, timeout);
        }

        public static void ShowSuccessNotifier(string desc, bool isDialog = false,int timeout = 3000)
        {
            ShowNotifier(desc, UINotifierType.OK, UILocalize.SuccessTitle, isDialog, timeout);
        }

        public static void ShowWarningNotifier(string desc, bool isDialog = false,int timeout = 3000)
        {
            ShowNotifier(desc, UINotifierType.WARNING, UILocalize.WarningTitle, isDialog, timeout);
        }

        public static void ShowErrorNotifier(string desc, bool isDialog = false,int timeout = 3000)
        {
            ShowNotifier(desc, UINotifierType.ERROR, UILocalize.ErrorTitle, isDialog, timeout);
        }


        /// <summary>
        /// 显示消息
        /// </summary>
        /// <param name="form">窗体</param>
        /// <param name="text">消息文本</param>
        /// <param name="style">消息样式。不指定则使用默认样式</param>
        /// <param name="delay">消息停留时长(ms)。为负时使用全局时长</param>
        /// <param name="floating">是否漂浮，不指定则使用全局设置</param>
        /// <param name="point">消息窗显示位置。不指定则智能判定，当由工具栏项(ToolStripItem)弹出时，请指定该参数或使用接收控件的重载</param>
        /// <param name="centerByPoint">是否以point参数为中心进行呈现。为false则是在其附近呈现</param>
        public static void ShowInfoTip(string text, TipStyle style = null, int delay = -1, bool? floating = null,
            Point? point = null, bool centerByPoint = false)
            => UIMessageTip.Show(text, style, delay, floating, point, centerByPoint);

        /// <summary>
        /// 在指定控件附近显示消息
        /// </summary>
        /// <param name="form">窗体</param>
        /// <param name="controlOrItem">控件或工具栏项</param>
        /// <param name="text">消息文本</param>
        /// <param name="style">消息样式。不指定则使用默认样式</param>
        /// <param name="delay">消息停留时长(ms)。为负时使用全局时长</param>
        /// <param name="floating">是否漂浮，不指定则使用全局设置</param>
        /// <param name="centerInControl">是否在控件中央显示，不指定则自动判断</param>
        public static void ShowInfoTip(Component controlOrItem, string text, TipStyle style = null, int delay = -1,
            bool? floating = null, bool? centerInControl = null)
            => UIMessageTip.Show(controlOrItem, text, style, delay, floating, centerInControl);

        /// <summary>
        /// 在指定控件附近显示出错消息
        /// </summary>
        /// <param name="form">窗体</param>
        /// <param name="controlOrItem">控件或工具栏项</param>
        /// <param name="text">消息文本</param>
        /// <param name="delay">消息停留时长(ms)。默认1秒，若要使用全局时长请设为-1</param>
        /// <param name="floating">是否漂浮。默认不漂浮。若要使用全局设置请设为null</param>
        /// <param name="centerInControl">是否在控件中央显示，不指定则自动判断</param>
        public static void ShowErrorTip(Component controlOrItem, string text = null, int delay = 1000,
            bool? floating = null, bool? centerInControl = null)
            => UIMessageTip.ShowError(controlOrItem, text, delay, floating, centerInControl);

        /// <summary>
        /// 显示出错消息
        /// </summary>
        /// <param name="form">窗体</param>
        /// <param name="text">消息文本</param>
        /// <param name="delay">消息停留时长(ms)。默认1秒，若要使用全局时长请设为-1</param>
        /// <param name="floating">是否漂浮。默认不漂浮。若要使用全局设置请设为null</param>
        /// <param name="point">消息窗显示位置。不指定则智能判定，当由工具栏项(ToolStripItem)弹出时，请指定该参数或使用接收控件的重载</param>
        /// <param name="centerByPoint">是否以point参数为中心进行呈现。为false则是在其附近呈现</param>
        public static void ShowErrorTip(string text = null, int delay = 1000, bool? floating = null, Point? point = null,
            bool centerByPoint = false)
            => UIMessageTip.ShowError(text, delay, floating, point, centerByPoint);

        /// <summary>
        /// 在指定控件附近显示良好消息
        /// </summary>
        /// <param name="form">窗体</param>
        /// <param name="controlOrItem">控件或工具栏项</param>
        /// <param name="text">消息文本</param>
        /// <param name="delay">消息停留时长(ms)。为负时使用全局时长</param>
        /// <param name="floating">是否漂浮，不指定则使用全局设置</param>
        /// <param name="centerInControl">是否在控件中央显示，不指定则自动判断</param>
        public static void ShowSuccessTip(Component controlOrItem, string text = null, int delay = -1, bool? floating = null,
            bool? centerInControl = null)
            => UIMessageTip.ShowOk(controlOrItem, text, delay, floating, centerInControl);

        /// <summary>
        /// 显示良好消息
        /// </summary>
        /// <param name="form">窗体</param>
        /// <param name="text">消息文本</param>
        /// <param name="delay">消息停留时长(ms)。为负时使用全局时长</param>
        /// <param name="floating">是否漂浮，不指定则使用全局设置</param>
        /// <param name="point">消息窗显示位置。不指定则智能判定，当由工具栏项(ToolStripItem)弹出时，请指定该参数或使用接收控件的重载</param>
        /// <param name="centerByPoint">是否以point参数为中心进行呈现。为false则是在其附近呈现</param>
        public static void ShowSuccessTip(string text = null, int delay = -1, bool? floating = null, Point? point = null,
            bool centerByPoint = false)
            => UIMessageTip.ShowOk(text, delay, floating, point, centerByPoint);

        /// <summary>
        /// 在指定控件附近显示警告消息
        /// </summary>
        /// <param name="form">窗体</param>
        /// <param name="controlOrItem">控件或工具栏项</param>
        /// <param name="text">消息文本</param>
        /// <param name="delay">消息停留时长(ms)。默认1秒，若要使用全局时长请设为-1</param>
        /// <param name="floating">是否漂浮。默认不漂浮。若要使用全局设置请设为null</param>
        /// <param name="centerInControl">是否在控件中央显示，不指定则自动判断</param>
        public static void ShowWarningTip(Component controlOrItem, string text = null, int delay = 1000,
            bool? floating = null, bool? centerInControl = null)
            => UIMessageTip.ShowWarning(controlOrItem, text, delay, floating, centerInControl);

        /// <summary>
        /// 显示警告消息
        /// </summary>
        /// <param name="form">窗体</param>
        /// <param name="text">消息文本</param>
        /// <param name="delay">消息停留时长(ms)。默认1秒，若要使用全局时长请设为-1</param>
        /// <param name="floating">是否漂浮。默认不漂浮。若要使用全局设置请设为null</param>
        /// <param name="point">消息窗显示位置。不指定则智能判定，当由工具栏项(ToolStripItem)弹出时，请指定该参数或使用接收控件的重载</param>
        /// <param name="centerByPoint">是否以point参数为中心进行呈现。为false则是在其附近呈现</param>
        public static void ShowWarningTip(string text = null, int delay = 1000, bool? floating = null, Point? point = null,
            bool centerByPoint = false)
            => UIMessageTip.ShowWarning(text, delay, floating, point, centerByPoint);


        public static bool ShowSelectDialog(ref int selectIndex,IList items,string description="你的选择是：", string title="请选择",UIStyle style=UIStyle.Blue,bool topMost=true)
        {
            UISelectForm frm = new UISelectForm();
            frm.TopMost = topMost;
            frm.Style = style;
            frm.SetItems(items);
            frm.SelectedIndex = selectIndex;
            frm.Title = title;
            frm.Description = description;
            frm.ShowDialog();
            bool result = frm.IsOK;
            if(frm.IsOK)
            {
                selectIndex = frm.SelectedIndex;
            }
            frm.Dispose();
            return result;
        }

       
        public static bool ShowSelectDialog(ref string selectString,IList items, string description = "你的选择是：", string title = "请选择", UIStyle style=UIStyle.Blue,bool topMost=true)
        {
            UISelectForm frm = new UISelectForm();
            frm.TopMost = topMost;
            frm.Style = style;
            frm.SetItems(items);
            int selectIndex = -1;
            for(int i=0;i<items.Count;i++)
            {
                if(items[i].ToString()==selectString)
                {
                    selectIndex = i;
                    break;
                }
            }
            frm.SelectedIndex = selectIndex;
            frm.Title = title;
            frm.Description = description;
            frm.ShowDialog();
            bool result = frm.IsOK;
            if (frm.IsOK)
            {
                selectString = items[frm.SelectedIndex].ToString();
            }
            frm.Dispose();
            return result;
        }
    }
}
