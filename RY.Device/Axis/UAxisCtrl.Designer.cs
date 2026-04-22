namespace RY.Device
{
    partial class UAxisCtrl
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
            this.uiMarkLabel1 = new SunnyUI.UIMarkLabel();
            this.tbStart = new SunnyUI.UITextBox();
            this.tbEnd = new SunnyUI.UITextBox();
            this.uiMarkLabel2 = new SunnyUI.UIMarkLabel();
            this.tbWait = new SunnyUI.UITextBox();
            this.uiMarkLabel3 = new SunnyUI.UIMarkLabel();
            this.btStartLoop = new SunnyUI.UISymbolButton();
            this.axisCtrl1 = new RY.Device.AxisCtrl();
            this.SuspendLayout();
            // 
            // uiMarkLabel1
            // 
            this.uiMarkLabel1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiMarkLabel1.Location = new System.Drawing.Point(13, 116);
            this.uiMarkLabel1.MarkPos = SunnyUI.UIMarkLabel.UIMarkPos.Bottom;
            this.uiMarkLabel1.Name = "uiMarkLabel1";
            this.uiMarkLabel1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.uiMarkLabel1.Size = new System.Drawing.Size(100, 23);
            this.uiMarkLabel1.Style = SunnyUI.UIStyle.Custom;
            this.uiMarkLabel1.TabIndex = 1;
            this.uiMarkLabel1.Text = "开始位置";
            this.uiMarkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbStart
            // 
            this.tbStart.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbStart.FillColor = System.Drawing.Color.White;
            this.tbStart.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbStart.Location = new System.Drawing.Point(13, 144);
            this.tbStart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbStart.Maximum = 2147483647D;
            this.tbStart.Minimum = -2147483648D;
            this.tbStart.MinimumSize = new System.Drawing.Size(1, 1);
            this.tbStart.Name = "tbStart";
            this.tbStart.Size = new System.Drawing.Size(100, 29);
            this.tbStart.Style = SunnyUI.UIStyle.Custom;
            this.tbStart.Symbol = 97;
            this.tbStart.TabIndex = 2;
            this.tbStart.Text = "0.00";
            this.tbStart.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbStart.Type = SunnyUI.UITextBox.UIEditType.Double;
            // 
            // tbEnd
            // 
            this.tbEnd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbEnd.DoubleValue = 100D;
            this.tbEnd.FillColor = System.Drawing.Color.White;
            this.tbEnd.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbEnd.Location = new System.Drawing.Point(133, 144);
            this.tbEnd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbEnd.Maximum = 2147483647D;
            this.tbEnd.Minimum = -2147483648D;
            this.tbEnd.MinimumSize = new System.Drawing.Size(1, 1);
            this.tbEnd.Name = "tbEnd";
            this.tbEnd.Size = new System.Drawing.Size(100, 29);
            this.tbEnd.Style = SunnyUI.UIStyle.Custom;
            this.tbEnd.Symbol = 97;
            this.tbEnd.TabIndex = 4;
            this.tbEnd.Text = "100.00";
            this.tbEnd.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbEnd.Type = SunnyUI.UITextBox.UIEditType.Double;
            // 
            // uiMarkLabel2
            // 
            this.uiMarkLabel2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiMarkLabel2.Location = new System.Drawing.Point(133, 116);
            this.uiMarkLabel2.MarkPos = SunnyUI.UIMarkLabel.UIMarkPos.Bottom;
            this.uiMarkLabel2.Name = "uiMarkLabel2";
            this.uiMarkLabel2.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.uiMarkLabel2.Size = new System.Drawing.Size(100, 23);
            this.uiMarkLabel2.Style = SunnyUI.UIStyle.Custom;
            this.uiMarkLabel2.TabIndex = 3;
            this.uiMarkLabel2.Text = "停止位置";
            this.uiMarkLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbWait
            // 
            this.tbWait.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbWait.DoubleValue = 1000D;
            this.tbWait.FillColor = System.Drawing.Color.White;
            this.tbWait.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbWait.IntValue = 1000;
            this.tbWait.Location = new System.Drawing.Point(254, 144);
            this.tbWait.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbWait.Maximum = 2147483647D;
            this.tbWait.Minimum = -2147483648D;
            this.tbWait.MinimumSize = new System.Drawing.Size(1, 1);
            this.tbWait.Name = "tbWait";
            this.tbWait.Size = new System.Drawing.Size(100, 29);
            this.tbWait.Style = SunnyUI.UIStyle.Custom;
            this.tbWait.Symbol = 557746;
            this.tbWait.TabIndex = 6;
            this.tbWait.Text = "1000";
            this.tbWait.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbWait.Type = SunnyUI.UITextBox.UIEditType.Integer;
            // 
            // uiMarkLabel3
            // 
            this.uiMarkLabel3.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiMarkLabel3.Location = new System.Drawing.Point(254, 116);
            this.uiMarkLabel3.MarkPos = SunnyUI.UIMarkLabel.UIMarkPos.Bottom;
            this.uiMarkLabel3.Name = "uiMarkLabel3";
            this.uiMarkLabel3.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.uiMarkLabel3.Size = new System.Drawing.Size(100, 23);
            this.uiMarkLabel3.Style = SunnyUI.UIStyle.Custom;
            this.uiMarkLabel3.TabIndex = 5;
            this.uiMarkLabel3.Text = "等待时间ms";
            this.uiMarkLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btStartLoop
            // 
            this.btStartLoop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btStartLoop.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btStartLoop.Location = new System.Drawing.Point(381, 138);
            this.btStartLoop.MinimumSize = new System.Drawing.Size(1, 1);
            this.btStartLoop.Name = "btStartLoop";
            this.btStartLoop.Size = new System.Drawing.Size(136, 35);
            this.btStartLoop.Style = SunnyUI.UIStyle.Custom;
            this.btStartLoop.Symbol = 557384;
            this.btStartLoop.TabIndex = 7;
            this.btStartLoop.Text = "开始循环运动";
            this.btStartLoop.Click += new System.EventHandler(this.btStartLoop_Click);
            // 
            // axisCtrl1
            // 
            this.axisCtrl1.BackColor = System.Drawing.Color.White;
            this.axisCtrl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.axisCtrl1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.axisCtrl1.Location = new System.Drawing.Point(0, 0);
            this.axisCtrl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.axisCtrl1.Name = "axisCtrl1";
            this.axisCtrl1.Size = new System.Drawing.Size(552, 108);
            this.axisCtrl1.TabIndex = 0;
            this.axisCtrl1.TimeTick = 1000;
            // 
            // UAxisCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(552, 191);
            this.Controls.Add(this.btStartLoop);
            this.Controls.Add(this.tbWait);
            this.Controls.Add(this.uiMarkLabel3);
            this.Controls.Add(this.tbEnd);
            this.Controls.Add(this.uiMarkLabel2);
            this.Controls.Add(this.tbStart);
            this.Controls.Add(this.uiMarkLabel1);
            this.Controls.Add(this.axisCtrl1);
            this.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UAxisCtrl";
            this.Style = SunnyUI.UIStyle.Custom;
            this.ResumeLayout(false);

        }

        #endregion

        private AxisCtrl axisCtrl1;
        private SunnyUI.UIMarkLabel uiMarkLabel1;
        private SunnyUI.UITextBox tbStart;
        private SunnyUI.UITextBox tbEnd;
        private SunnyUI.UIMarkLabel uiMarkLabel2;
        private SunnyUI.UITextBox tbWait;
        private SunnyUI.UIMarkLabel uiMarkLabel3;
        private SunnyUI.UISymbolButton btStartLoop;
    }
}
