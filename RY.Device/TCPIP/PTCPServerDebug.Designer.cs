namespace RY.Device
{
    partial class PTCPServerDebug
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
            this.gpop = new System.Windows.Forms.GroupBox();
            this.btSend = new SunnyUI.UISymbolButton();
            this.btSendAll = new SunnyUI.UISymbolButton();
            this.tbMsg = new SunnyUI.UITextBox();
            this.lsbAllClient = new System.Windows.Forms.ListBox();
            this.lsbMsg = new System.Windows.Forms.ListBox();
            this.gpop.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpop
            // 
            this.gpop.Controls.Add(this.btSend);
            this.gpop.Controls.Add(this.btSendAll);
            this.gpop.Controls.Add(this.tbMsg);
            this.gpop.Dock = System.Windows.Forms.DockStyle.Top;
            this.gpop.Location = new System.Drawing.Point(0, 0);
            this.gpop.Name = "gpop";
            this.gpop.Size = new System.Drawing.Size(612, 61);
            this.gpop.TabIndex = 2;
            this.gpop.TabStop = false;
            this.gpop.Text = "发送信息";
            // 
            // btSend
            // 
            this.btSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSend.Dock = System.Windows.Forms.DockStyle.Right;
            this.btSend.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btSend.Location = new System.Drawing.Point(389, 22);
            this.btSend.MinimumSize = new System.Drawing.Size(1, 1);
            this.btSend.Name = "btSend";
            this.btSend.Size = new System.Drawing.Size(110, 36);
            this.btSend.Style = SunnyUI.UIStyle.Custom;
            this.btSend.Symbol = 557699;
            this.btSend.TabIndex = 1;
            this.btSend.Text = "发送";
            this.btSend.Click += new System.EventHandler(this.btSend_Click);
            // 
            // btSendAll
            // 
            this.btSendAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSendAll.Dock = System.Windows.Forms.DockStyle.Right;
            this.btSendAll.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btSendAll.Location = new System.Drawing.Point(499, 22);
            this.btSendAll.MinimumSize = new System.Drawing.Size(1, 1);
            this.btSendAll.Name = "btSendAll";
            this.btSendAll.Size = new System.Drawing.Size(110, 36);
            this.btSendAll.Style = SunnyUI.UIStyle.Custom;
            this.btSendAll.Symbol = 557699;
            this.btSendAll.TabIndex = 2;
            this.btSendAll.Text = "全部发送";
            this.btSendAll.Click += new System.EventHandler(this.btSendAll_Click);
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
            this.tbMsg.Size = new System.Drawing.Size(385, 36);
            this.tbMsg.Style = SunnyUI.UIStyle.Custom;
            this.tbMsg.Symbol = 112;
            this.tbMsg.TabIndex = 0;
            this.tbMsg.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lsbAllClient
            // 
            this.lsbAllClient.Dock = System.Windows.Forms.DockStyle.Left;
            this.lsbAllClient.FormattingEnabled = true;
            this.lsbAllClient.ItemHeight = 19;
            this.lsbAllClient.Location = new System.Drawing.Point(0, 61);
            this.lsbAllClient.Name = "lsbAllClient";
            this.lsbAllClient.Size = new System.Drawing.Size(120, 300);
            this.lsbAllClient.TabIndex = 3;
            // 
            // lsbMsg
            // 
            this.lsbMsg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsbMsg.FormattingEnabled = true;
            this.lsbMsg.ItemHeight = 19;
            this.lsbMsg.Location = new System.Drawing.Point(120, 61);
            this.lsbMsg.Name = "lsbMsg";
            this.lsbMsg.Size = new System.Drawing.Size(492, 300);
            this.lsbMsg.TabIndex = 4;
            // 
            // PTCPServerDebug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(612, 361);
            this.Controls.Add(this.lsbMsg);
            this.Controls.Add(this.lsbAllClient);
            this.Controls.Add(this.gpop);
            this.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PTCPServerDebug";
            this.Style = SunnyUI.UIStyle.Custom;
            this.gpop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpop;
        private SunnyUI.UISymbolButton btSend;
        private SunnyUI.UITextBox tbMsg;
        private SunnyUI.UISymbolButton btSendAll;
        private System.Windows.Forms.ListBox lsbAllClient;
        private System.Windows.Forms.ListBox lsbMsg;
    }
}
