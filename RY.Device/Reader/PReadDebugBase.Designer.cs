namespace RY.Device
{
    partial class PReadDebugBase
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
            this.lbInfo = new SunnyUI.UIMarkLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbCmd = new SunnyUI.UITextBox();
            this.btSendCmd = new SunnyUI.UISymbolButton();
            this.btRead = new SunnyUI.UISymbolButton();
            this.btStop = new SunnyUI.UISymbolButton();
            this.uiLabel1 = new SunnyUI.UILabel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbInfo
            // 
            this.lbInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbInfo.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbInfo.Location = new System.Drawing.Point(0, 0);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.lbInfo.Size = new System.Drawing.Size(443, 39);
            this.lbInfo.Style = SunnyUI.UIStyle.Custom;
            this.lbInfo.TabIndex = 0;
            this.lbInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.uiLabel1);
            this.groupBox1.Controls.Add(this.btStop);
            this.groupBox1.Controls.Add(this.btRead);
            this.groupBox1.Controls.Add(this.btSendCmd);
            this.groupBox1.Controls.Add(this.tbCmd);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(0, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(443, 224);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "操作";
            // 
            // tbCmd
            // 
            this.tbCmd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbCmd.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbCmd.FillColor = System.Drawing.Color.White;
            this.tbCmd.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbCmd.Location = new System.Drawing.Point(3, 25);
            this.tbCmd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbCmd.Maximum = 2147483647D;
            this.tbCmd.Minimum = -2147483648D;
            this.tbCmd.MinimumSize = new System.Drawing.Size(1, 1);
            this.tbCmd.Name = "tbCmd";
            this.tbCmd.Size = new System.Drawing.Size(437, 29);
            this.tbCmd.Symbol = 563580;
            this.tbCmd.TabIndex = 0;
            this.tbCmd.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btSendCmd
            // 
            this.btSendCmd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSendCmd.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btSendCmd.Location = new System.Drawing.Point(12, 75);
            this.btSendCmd.MinimumSize = new System.Drawing.Size(1, 1);
            this.btSendCmd.Name = "btSendCmd";
            this.btSendCmd.Size = new System.Drawing.Size(100, 35);
            this.btSendCmd.Symbol = 557699;
            this.btSendCmd.TabIndex = 1;
            this.btSendCmd.Text = "发送命令";
            this.btSendCmd.Click += new System.EventHandler(this.btSendCmd_Click);
            // 
            // btRead
            // 
            this.btRead.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btRead.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btRead.Location = new System.Drawing.Point(175, 75);
            this.btRead.MinimumSize = new System.Drawing.Size(1, 1);
            this.btRead.Name = "btRead";
            this.btRead.Size = new System.Drawing.Size(100, 35);
            this.btRead.Symbol = 557699;
            this.btRead.TabIndex = 2;
            this.btRead.Text = "开始读";
            this.btRead.Click += new System.EventHandler(this.btRead_Click);
            // 
            // btStop
            // 
            this.btStop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btStop.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btStop.Location = new System.Drawing.Point(335, 75);
            this.btStop.MinimumSize = new System.Drawing.Size(1, 1);
            this.btStop.Name = "btStop";
            this.btStop.Size = new System.Drawing.Size(100, 35);
            this.btStop.Symbol = 362093;
            this.btStop.TabIndex = 3;
            this.btStop.Text = "停止读";
            this.btStop.Click += new System.EventHandler(this.btStop_Click);
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel1.Location = new System.Drawing.Point(7, 124);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(428, 90);
            this.uiLabel1.TabIndex = 5;
            this.uiLabel1.Text = "1.发送命令：发送文本框命令\r\n2.开始读：发送设定命令\r\n3.停止读：发送停止命令";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PReadDebugBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(443, 263);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbInfo);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "PReadDebugBase";
            this.Style = SunnyUI.UIStyle.Custom;
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private SunnyUI.UIMarkLabel lbInfo;
        private System.Windows.Forms.GroupBox groupBox1;
        private SunnyUI.UITextBox tbCmd;
        private SunnyUI.UISymbolButton btStop;
        private SunnyUI.UISymbolButton btRead;
        private SunnyUI.UISymbolButton btSendCmd;
        private SunnyUI.UILabel uiLabel1;
    }
}
