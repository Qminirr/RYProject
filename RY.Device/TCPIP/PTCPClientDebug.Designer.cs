namespace RY.Device
{
    partial class PTCPClientDebug
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
            this.lstMsg = new System.Windows.Forms.ListBox();
            this.gpop = new System.Windows.Forms.GroupBox();
            this.btSend = new SunnyUI.UISymbolButton();
            this.tbMsg = new SunnyUI.UITextBox();
            this.gpop.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstMsg
            // 
            this.lstMsg.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lstMsg.FormattingEnabled = true;
            this.lstMsg.ItemHeight = 19;
            this.lstMsg.Location = new System.Drawing.Point(0, 67);
            this.lstMsg.Name = "lstMsg";
            this.lstMsg.Size = new System.Drawing.Size(541, 327);
            this.lstMsg.TabIndex = 0;
            // 
            // gpop
            // 
            this.gpop.Controls.Add(this.btSend);
            this.gpop.Controls.Add(this.tbMsg);
            this.gpop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpop.Location = new System.Drawing.Point(0, 0);
            this.gpop.Name = "gpop";
            this.gpop.Size = new System.Drawing.Size(541, 67);
            this.gpop.TabIndex = 1;
            this.gpop.TabStop = false;
            this.gpop.Text = "发送信息";
            // 
            // btSend
            // 
            this.btSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSend.Dock = System.Windows.Forms.DockStyle.Right;
            this.btSend.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btSend.Location = new System.Drawing.Point(438, 22);
            this.btSend.MinimumSize = new System.Drawing.Size(1, 1);
            this.btSend.Name = "btSend";
            this.btSend.Size = new System.Drawing.Size(100, 42);
            this.btSend.Style = SunnyUI.UIStyle.Custom;
            this.btSend.Symbol = 557699;
            this.btSend.TabIndex = 1;
            this.btSend.Text = "发送";
            this.btSend.Click += new System.EventHandler(this.btSend_Click);
            // 
            // tbMsg
            // 
            this.tbMsg.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbMsg.Dock = System.Windows.Forms.DockStyle.Left;
            this.tbMsg.FillColor = System.Drawing.Color.White;
            this.tbMsg.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbMsg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.tbMsg.Location = new System.Drawing.Point(3, 22);
            this.tbMsg.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbMsg.Maximum = 2147483647D;
            this.tbMsg.Minimum = -2147483648D;
            this.tbMsg.MinimumSize = new System.Drawing.Size(1, 1);
            this.tbMsg.Name = "tbMsg";
            this.tbMsg.Size = new System.Drawing.Size(428, 39);
            this.tbMsg.Style = SunnyUI.UIStyle.Custom;
            this.tbMsg.Symbol = 112;
            this.tbMsg.TabIndex = 0;
            this.tbMsg.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PTCPClientDebug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(541, 394);
            this.Controls.Add(this.gpop);
            this.Controls.Add(this.lstMsg);
            this.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PTCPClientDebug";
            this.Style = SunnyUI.UIStyle.Custom;
            this.gpop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstMsg;
        private System.Windows.Forms.GroupBox gpop;
        private SunnyUI.UISymbolButton btSend;
        private SunnyUI.UITextBox tbMsg;
    }
}
