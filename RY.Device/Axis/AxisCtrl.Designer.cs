namespace RY.Device
{
    partial class AxisCtrl
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btPosAdd = new SunnyUI.UISymbolButton();
            this.btPosDec = new SunnyUI.UISymbolButton();
            this.tbSpan = new SunnyUI.UITextBox();
            this.lbCaption = new SunnyUI.UILine();
            this.btnJogNeg = new SunnyUI.UISymbolButton();
            this.btnJogPos = new SunnyUI.UISymbolButton();
            this.uiLabel5 = new SunnyUI.UILabel();
            this.lbSpeed = new SunnyUI.UILabel();
            this.btnHome = new SunnyUI.UISymbolButton();
            this.btnStop = new SunnyUI.UISymbolButton();
            this.uiLabel3 = new SunnyUI.UILabel();
            this.lbEncoderPos = new SunnyUI.UILabel();
            this.uiLabel2 = new SunnyUI.UILabel();
            this.lbCmdPos = new SunnyUI.UILabel();
            this.ledPower = new RY.Device.LedTextStatus();
            this.ledAlarm = new RY.Device.LedTextStatus();
            this.ledMoving = new RY.Device.LedTextStatus();
            this.ledNeg = new RY.Device.LedTextStatus();
            this.ledIsHomed = new RY.Device.LedTextStatus();
            this.ledPrimary = new RY.Device.LedTextStatus();
            this.ledPositive = new RY.Device.LedTextStatus();
            this.tt = new SunnyUI.UIToolTip(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(517, 103);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.btPosAdd);
            this.panel2.Controls.Add(this.btPosDec);
            this.panel2.Controls.Add(this.tbSpan);
            this.panel2.Controls.Add(this.lbCaption);
            this.panel2.Controls.Add(this.btnJogNeg);
            this.panel2.Controls.Add(this.btnJogPos);
            this.panel2.Controls.Add(this.uiLabel5);
            this.panel2.Controls.Add(this.lbSpeed);
            this.panel2.Controls.Add(this.btnHome);
            this.panel2.Controls.Add(this.btnStop);
            this.panel2.Controls.Add(this.uiLabel3);
            this.panel2.Controls.Add(this.lbEncoderPos);
            this.panel2.Controls.Add(this.uiLabel2);
            this.panel2.Controls.Add(this.lbCmdPos);
            this.panel2.Controls.Add(this.ledPower);
            this.panel2.Controls.Add(this.ledAlarm);
            this.panel2.Controls.Add(this.ledMoving);
            this.panel2.Controls.Add(this.ledNeg);
            this.panel2.Controls.Add(this.ledIsHomed);
            this.panel2.Controls.Add(this.ledPrimary);
            this.panel2.Controls.Add(this.ledPositive);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(517, 103);
            this.panel2.TabIndex = 7;
            // 
            // btPosAdd
            // 
            this.btPosAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btPosAdd.FillColor = System.Drawing.Color.White;
            this.btPosAdd.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btPosAdd.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btPosAdd.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btPosAdd.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold);
            this.btPosAdd.ForeColor = System.Drawing.Color.Navy;
            this.btPosAdd.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.btPosAdd.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(131)))), ((int)(((byte)(229)))));
            this.btPosAdd.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(131)))), ((int)(((byte)(229)))));
            this.btPosAdd.Location = new System.Drawing.Point(324, 70);
            this.btPosAdd.MinimumSize = new System.Drawing.Size(1, 1);
            this.btPosAdd.Name = "btPosAdd";
            this.btPosAdd.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(219)))), ((int)(((byte)(227)))));
            this.btPosAdd.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(222)))), ((int)(((byte)(255)))));
            this.btPosAdd.Size = new System.Drawing.Size(35, 28);
            this.btPosAdd.Style = SunnyUI.UIStyle.Custom;
            this.btPosAdd.Symbol = 0;
            this.btPosAdd.TabIndex = 30;
            this.btPosAdd.Text = "+";
            this.tt.SetToolTip(this.btPosAdd, "相对正方向移动");
            this.btPosAdd.Click += new System.EventHandler(this.btPosAdd_Click);
            // 
            // btPosDec
            // 
            this.btPosDec.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btPosDec.FillColor = System.Drawing.Color.White;
            this.btPosDec.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btPosDec.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btPosDec.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btPosDec.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btPosDec.ForeColor = System.Drawing.Color.Navy;
            this.btPosDec.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.btPosDec.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(131)))), ((int)(((byte)(229)))));
            this.btPosDec.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(131)))), ((int)(((byte)(229)))));
            this.btPosDec.Location = new System.Drawing.Point(231, 70);
            this.btPosDec.MinimumSize = new System.Drawing.Size(1, 1);
            this.btPosDec.Name = "btPosDec";
            this.btPosDec.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(219)))), ((int)(((byte)(227)))));
            this.btPosDec.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(222)))), ((int)(((byte)(255)))));
            this.btPosDec.Size = new System.Drawing.Size(35, 28);
            this.btPosDec.Style = SunnyUI.UIStyle.Custom;
            this.btPosDec.Symbol = 0;
            this.btPosDec.TabIndex = 29;
            this.btPosDec.Text = "-";
            this.tt.SetToolTip(this.btPosDec, "相对负方向移动");
            this.btPosDec.Click += new System.EventHandler(this.btPosDec_Click);
            // 
            // tbSpan
            // 
            this.tbSpan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbSpan.DecLength = 4;
            this.tbSpan.DoubleValue = 0.1D;
            this.tbSpan.FillColor = System.Drawing.Color.White;
            this.tbSpan.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold);
            this.tbSpan.Location = new System.Drawing.Point(266, 70);
            this.tbSpan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbSpan.Maximum = 500D;
            this.tbSpan.Minimum = 0.001D;
            this.tbSpan.MinimumSize = new System.Drawing.Size(1, 1);
            this.tbSpan.Name = "tbSpan";
            this.tbSpan.RectColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tbSpan.Size = new System.Drawing.Size(58, 28);
            this.tbSpan.Style = SunnyUI.UIStyle.Custom;
            this.tbSpan.TabIndex = 28;
            this.tbSpan.Text = "0.1000";
            this.tbSpan.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.tt.SetToolTip(this.tbSpan, "相对移动距离");
            this.tbSpan.Type = SunnyUI.UITextBox.UIEditType.Double;
            // 
            // lbCaption
            // 
            this.lbCaption.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbCaption.FillColor = System.Drawing.SystemColors.Control;
            this.lbCaption.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbCaption.LineSize = 3;
            this.lbCaption.Location = new System.Drawing.Point(0, 0);
            this.lbCaption.MinimumSize = new System.Drawing.Size(2, 2);
            this.lbCaption.Name = "lbCaption";
            this.lbCaption.Size = new System.Drawing.Size(517, 27);
            this.lbCaption.Style = SunnyUI.UIStyle.Custom;
            this.lbCaption.StyleCustomMode = true;
            this.lbCaption.TabIndex = 27;
            this.lbCaption.Text = "轴名";
            // 
            // btnJogNeg
            // 
            this.btnJogNeg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnJogNeg.FillColor = System.Drawing.Color.White;
            this.btnJogNeg.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btnJogNeg.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btnJogNeg.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btnJogNeg.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnJogNeg.ForeColor = System.Drawing.Color.Navy;
            this.btnJogNeg.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.btnJogNeg.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(131)))), ((int)(((byte)(229)))));
            this.btnJogNeg.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(131)))), ((int)(((byte)(229)))));
            this.btnJogNeg.Location = new System.Drawing.Point(259, 36);
            this.btnJogNeg.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnJogNeg.Name = "btnJogNeg";
            this.btnJogNeg.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(219)))), ((int)(((byte)(227)))));
            this.btnJogNeg.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(222)))), ((int)(((byte)(255)))));
            this.btnJogNeg.Size = new System.Drawing.Size(35, 28);
            this.btnJogNeg.Style = SunnyUI.UIStyle.Custom;
            this.btnJogNeg.Symbol = 0;
            this.btnJogNeg.TabIndex = 24;
            this.btnJogNeg.Text = "J-";
            this.tt.SetToolTip(this.btnJogNeg, "鼠标按住负方向Jog移动，松开停止");
            this.btnJogNeg.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnJogNeg_MouseDown);
            this.btnJogNeg.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnJogNeg_MouseUp);
            // 
            // btnJogPos
            // 
            this.btnJogPos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnJogPos.FillColor = System.Drawing.Color.White;
            this.btnJogPos.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btnJogPos.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btnJogPos.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btnJogPos.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnJogPos.ForeColor = System.Drawing.Color.Navy;
            this.btnJogPos.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.btnJogPos.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(131)))), ((int)(((byte)(229)))));
            this.btnJogPos.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(131)))), ((int)(((byte)(229)))));
            this.btnJogPos.Location = new System.Drawing.Point(300, 36);
            this.btnJogPos.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnJogPos.Name = "btnJogPos";
            this.btnJogPos.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(219)))), ((int)(((byte)(227)))));
            this.btnJogPos.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(222)))), ((int)(((byte)(255)))));
            this.btnJogPos.Size = new System.Drawing.Size(35, 28);
            this.btnJogPos.Style = SunnyUI.UIStyle.Custom;
            this.btnJogPos.Symbol = 0;
            this.btnJogPos.TabIndex = 23;
            this.btnJogPos.Text = "J+";
            this.tt.SetToolTip(this.btnJogPos, "鼠标按住正方向Jog移动，松开停止");
            this.btnJogPos.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnJogPos_MouseDown);
            this.btnJogPos.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnJogPos_MouseUp);
            // 
            // uiLabel5
            // 
            this.uiLabel5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel5.Location = new System.Drawing.Point(378, 71);
            this.uiLabel5.Margin = new System.Windows.Forms.Padding(0);
            this.uiLabel5.Name = "uiLabel5";
            this.uiLabel5.Size = new System.Drawing.Size(69, 23);
            this.uiLabel5.TabIndex = 15;
            this.uiLabel5.Text = "运动速度：";
            this.uiLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbSpeed
            // 
            this.lbSpeed.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbSpeed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbSpeed.Location = new System.Drawing.Point(449, 71);
            this.lbSpeed.Name = "lbSpeed";
            this.lbSpeed.Size = new System.Drawing.Size(63, 23);
            this.lbSpeed.TabIndex = 14;
            this.lbSpeed.Text = "0000.0";
            this.lbSpeed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tt.SetToolTip(this.lbSpeed, "双击可设置用户速度");
            this.lbSpeed.DoubleClick += new System.EventHandler(this.lbSpeed_DoubleClick);
            // 
            // btnHome
            // 
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.FillColor = System.Drawing.Color.White;
            this.btnHome.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btnHome.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btnHome.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btnHome.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnHome.ForeColor = System.Drawing.Color.Navy;
            this.btnHome.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.btnHome.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(131)))), ((int)(((byte)(229)))));
            this.btnHome.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(131)))), ((int)(((byte)(229)))));
            this.btnHome.Location = new System.Drawing.Point(79, 68);
            this.btnHome.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnHome.Name = "btnHome";
            this.btnHome.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(219)))), ((int)(((byte)(227)))));
            this.btnHome.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(222)))), ((int)(((byte)(255)))));
            this.btnHome.Size = new System.Drawing.Size(65, 30);
            this.btnHome.Style = SunnyUI.UIStyle.Custom;
            this.btnHome.Symbol = 61461;
            this.btnHome.TabIndex = 13;
            this.btnHome.Text = "回原";
            this.tt.SetToolTip(this.btnHome, "轴回原");
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnStop
            // 
            this.btnStop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStop.FillColor = System.Drawing.Color.White;
            this.btnStop.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btnStop.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btnStop.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.btnStop.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnStop.ForeColor = System.Drawing.Color.Navy;
            this.btnStop.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.btnStop.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(131)))), ((int)(((byte)(229)))));
            this.btnStop.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(131)))), ((int)(((byte)(229)))));
            this.btnStop.Location = new System.Drawing.Point(8, 68);
            this.btnStop.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnStop.Name = "btnStop";
            this.btnStop.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(219)))), ((int)(((byte)(227)))));
            this.btnStop.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(222)))), ((int)(((byte)(255)))));
            this.btnStop.Size = new System.Drawing.Size(65, 30);
            this.btnStop.Style = SunnyUI.UIStyle.Custom;
            this.btnStop.Symbol = 62094;
            this.btnStop.TabIndex = 12;
            this.btnStop.Text = "停止";
            this.tt.SetToolTip(this.btnStop, "停止轴运动");
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // uiLabel3
            // 
            this.uiLabel3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel3.Location = new System.Drawing.Point(366, 48);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(81, 23);
            this.uiLabel3.TabIndex = 11;
            this.uiLabel3.Text = "编码器位置：";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbEncoderPos
            // 
            this.lbEncoderPos.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbEncoderPos.Location = new System.Drawing.Point(449, 48);
            this.lbEncoderPos.Name = "lbEncoderPos";
            this.lbEncoderPos.Size = new System.Drawing.Size(63, 23);
            this.lbEncoderPos.TabIndex = 10;
            this.lbEncoderPos.Text = "0000.000";
            this.lbEncoderPos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel2.Location = new System.Drawing.Point(378, 25);
            this.uiLabel2.Margin = new System.Windows.Forms.Padding(0);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(69, 23);
            this.uiLabel2.TabIndex = 9;
            this.uiLabel2.Text = "指令位置：";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbCmdPos
            // 
            this.lbCmdPos.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbCmdPos.Location = new System.Drawing.Point(449, 25);
            this.lbCmdPos.Name = "lbCmdPos";
            this.lbCmdPos.Size = new System.Drawing.Size(63, 23);
            this.lbCmdPos.TabIndex = 8;
            this.lbCmdPos.Text = "0000.000";
            this.lbCmdPos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ledPower
            // 
            this.ledPower.CanClick = true;
            this.ledPower.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ledPower.ForeColor = System.Drawing.Color.Navy;
            this.ledPower.Location = new System.Drawing.Point(213, 30);
            this.ledPower.Margin = new System.Windows.Forms.Padding(0);
            this.ledPower.Name = "ledPower";
            this.ledPower.OffColor = System.Drawing.Color.Gray;
            this.ledPower.OnColor = System.Drawing.Color.Green;
            this.ledPower.Size = new System.Drawing.Size(35, 43);
            this.ledPower.State = true;
            this.ledPower.TabIndex = 7;
            this.ledPower.Text = "上电";
            this.tt.SetToolTip(this.ledPower, "单击控制电机上下电");
            this.ledPower.Click += new System.EventHandler(this.ledPower_Click);
            // 
            // ledAlarm
            // 
            this.ledAlarm.CanClick = true;
            this.ledAlarm.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ledAlarm.ForeColor = System.Drawing.Color.Navy;
            this.ledAlarm.Location = new System.Drawing.Point(3, 30);
            this.ledAlarm.Margin = new System.Windows.Forms.Padding(0);
            this.ledAlarm.Name = "ledAlarm";
            this.ledAlarm.OffColor = System.Drawing.Color.Gray;
            this.ledAlarm.OnColor = System.Drawing.Color.Red;
            this.ledAlarm.Size = new System.Drawing.Size(35, 43);
            this.ledAlarm.State = true;
            this.ledAlarm.TabIndex = 1;
            this.ledAlarm.Text = "报警";
            this.tt.SetToolTip(this.ledAlarm, "点击可以清除报警(部分驱动器)");
            this.ledAlarm.Click += new System.EventHandler(this.ledAlarm_Click);
            // 
            // ledMoving
            // 
            this.ledMoving.CanClick = false;
            this.ledMoving.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ledMoving.ForeColor = System.Drawing.Color.Navy;
            this.ledMoving.Location = new System.Drawing.Point(178, 30);
            this.ledMoving.Margin = new System.Windows.Forms.Padding(0);
            this.ledMoving.Name = "ledMoving";
            this.ledMoving.OffColor = System.Drawing.Color.Gray;
            this.ledMoving.OnColor = System.Drawing.Color.Green;
            this.ledMoving.Size = new System.Drawing.Size(35, 43);
            this.ledMoving.State = true;
            this.ledMoving.TabIndex = 6;
            this.ledMoving.Text = "运动";
            this.tt.SetToolTip(this.ledMoving, "轴是否在运动");
            // 
            // ledNeg
            // 
            this.ledNeg.CanClick = false;
            this.ledNeg.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ledNeg.ForeColor = System.Drawing.Color.Navy;
            this.ledNeg.Location = new System.Drawing.Point(38, 30);
            this.ledNeg.Margin = new System.Windows.Forms.Padding(0);
            this.ledNeg.Name = "ledNeg";
            this.ledNeg.OffColor = System.Drawing.Color.Gray;
            this.ledNeg.OnColor = System.Drawing.Color.Green;
            this.ledNeg.Size = new System.Drawing.Size(35, 43);
            this.ledNeg.State = false;
            this.ledNeg.TabIndex = 2;
            this.ledNeg.Text = "负限";
            this.tt.SetToolTip(this.ledNeg, "负限位");
            // 
            // ledIsHomed
            // 
            this.ledIsHomed.CanClick = false;
            this.ledIsHomed.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ledIsHomed.ForeColor = System.Drawing.Color.Navy;
            this.ledIsHomed.Location = new System.Drawing.Point(144, 30);
            this.ledIsHomed.Margin = new System.Windows.Forms.Padding(0);
            this.ledIsHomed.Name = "ledIsHomed";
            this.ledIsHomed.OffColor = System.Drawing.Color.Gray;
            this.ledIsHomed.OnColor = System.Drawing.Color.Green;
            this.ledIsHomed.Size = new System.Drawing.Size(35, 43);
            this.ledIsHomed.State = false;
            this.ledIsHomed.TabIndex = 5;
            this.ledIsHomed.Text = "回原";
            this.tt.SetToolTip(this.ledIsHomed, "轴是否已回原");
            // 
            // ledPrimary
            // 
            this.ledPrimary.CanClick = false;
            this.ledPrimary.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ledPrimary.ForeColor = System.Drawing.Color.Navy;
            this.ledPrimary.Location = new System.Drawing.Point(73, 30);
            this.ledPrimary.Margin = new System.Windows.Forms.Padding(0);
            this.ledPrimary.Name = "ledPrimary";
            this.ledPrimary.OffColor = System.Drawing.Color.Gray;
            this.ledPrimary.OnColor = System.Drawing.Color.Green;
            this.ledPrimary.Size = new System.Drawing.Size(35, 43);
            this.ledPrimary.State = false;
            this.ledPrimary.TabIndex = 3;
            this.ledPrimary.Text = "原点";
            this.tt.SetToolTip(this.ledPrimary, "原点");
            // 
            // ledPositive
            // 
            this.ledPositive.CanClick = false;
            this.ledPositive.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ledPositive.ForeColor = System.Drawing.Color.Navy;
            this.ledPositive.Location = new System.Drawing.Point(108, 30);
            this.ledPositive.Margin = new System.Windows.Forms.Padding(0);
            this.ledPositive.Name = "ledPositive";
            this.ledPositive.OffColor = System.Drawing.Color.Gray;
            this.ledPositive.OnColor = System.Drawing.Color.Green;
            this.ledPositive.Size = new System.Drawing.Size(35, 43);
            this.ledPositive.State = false;
            this.ledPositive.TabIndex = 4;
            this.ledPositive.Text = "正限";
            this.tt.SetToolTip(this.ledPositive, "正限位");
            // 
            // tt
            // 
            this.tt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.tt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.tt.OwnerDraw = true;
            // 
            // AxisCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AxisCtrl";
            this.Size = new System.Drawing.Size(517, 103);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private LedTextStatus ledAlarm;
        private LedTextStatus ledMoving;
        private LedTextStatus ledIsHomed;
        private LedTextStatus ledPositive;
        private LedTextStatus ledPrimary;
        private LedTextStatus ledNeg;
        private System.Windows.Forms.Panel panel2;
        private LedTextStatus ledPower;
        private SunnyUI.UILabel uiLabel3;
        private SunnyUI.UILabel lbEncoderPos;
        private SunnyUI.UILabel uiLabel2;
        private SunnyUI.UILabel lbCmdPos;
        private SunnyUI.UISymbolButton btnHome;
        private SunnyUI.UISymbolButton btnStop;
        private SunnyUI.UILabel uiLabel5;
        private SunnyUI.UILabel lbSpeed;
        private SunnyUI.UIToolTip tt;
        private SunnyUI.UISymbolButton btnJogNeg;
        private SunnyUI.UISymbolButton btnJogPos;
        private SunnyUI.UILine lbCaption;
        private SunnyUI.UITextBox tbSpan;
        private SunnyUI.UISymbolButton btPosAdd;
        private SunnyUI.UISymbolButton btPosDec;
    }
}
