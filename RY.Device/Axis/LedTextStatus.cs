using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SunnyUI;
using System.Drawing.Design;

namespace RY.Device
{
    [DefaultEvent("Click")]
    [DefaultProperty("State")]
    public partial class LedTextStatus : Control
    {
        public LedTextStatus()
        {
           
        }


        private string txt = "";
        public override string Text
        {
            get
            {
                return txt;
            }
            set
            {
                txt = value;
                RePaint();
            }
        }
        void RePaint()
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() =>
                {
                    RePaint();
                }));

            }
            else
            {
                Invalidate();
            }
        }

        public Color OnColor
        { get; set; } = Color.Green;

        public Color OffColor
        { get; set; } = Color.Gray;


        bool _canClick =false ;
        public bool CanClick
        {
            get
            {
                return _canClick;
            }
            set
            {
                _canClick = value;
                RePaint();
            }
        }

        protected override void OnClick(EventArgs e)
        {
            if(CanClick)
            {
                State = !State;
                base.OnClick(e);
            }
                
        }

        public void DrawEllipse(Brush bush)
        {
            float x, y;
            float d = Width / 2;

            x =Width/(2f*2);
            y = 1;
            float cx, cy;
            using (Graphics gra = this.CreateGraphics())
            {
                gra.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                gra.FillEllipse(bush, x, y, d-1, d-1);//画填充椭圆的方法
                cx = x + d / 2.0f;
                cy = y + d / 2.0f;
                if (CanClick&&Symbol > 0)
                {
                    SizeF ImageSize = new SizeF(0, 0);
                    Font ft = FontImageHelper.GetFont(Symbol, SymbolSize);
                    if (ft != null)
                    {
                        ImageSize = gra.MeasureString(char.ConvertFromUtf32(Symbol), ft);
                        float fx = ImageSize.Width / 2.0f;
                        float fy = ImageSize.Height / 2.0f;
                        FontImageHelper.DrawFontImage(Symbol, SymbolSize, Color.White, new RectangleF(cx-fx, cy-fy, ImageSize.Width, ImageSize.Height), gra);
                    }
                }
                if (!string.IsNullOrEmpty(txt))
                {
                    SizeF sf = gra.MeasureString(txt, Font);
                    float left = (Width - sf.Width) / 2f;
                    gra.DrawString(txt, Font, ForeColor, left, y+d+1);
                }
                

            }

        }


        bool _state = false;
        public bool State
        {
            get
            {
                return _state;
            }
            set
            {
                if(_state!=value)
                {
                    _state = value;
                    RePaint();
                }
                
            }
        }
        private int _symbolSize = 24;
        [DefaultValue(24)]
        [Description("字体图标大小"), Category("HZUI")]
        public int SymbolSize
        {
            get
            {
                return _symbolSize;
            }
            set
            {
                _symbolSize = Math.Max(value, 16);
                _symbolSize = Math.Min(value, 128);
                RePaint();
            }
            }

            private int _symbol = 559234;
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Editor(typeof(UIImagePropertyEditor),typeof(UITypeEditor))]
        [DefaultValue(559234)]
        public int Symbol
        {
            get
            {
                return _symbol;
            }
            set
            {
                _symbol = value;
                RePaint();
            }
        }

        protected override Size DefaultSize
        {
            get
            {
                return new Size(25, 50);
            }
        }

        protected override Padding DefaultPadding
        {
            get
            {
                return new Padding(0);
            }
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            Brush b = null;
            if(State)
            {
                b = new SolidBrush(OnColor);
            }
            else
            {
                b = new SolidBrush(OffColor);
            }
            DrawEllipse(b);
        }
    }
}
