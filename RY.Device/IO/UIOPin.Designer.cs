namespace RY.Device
{
    partial class UIOPin
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
            this.tlpSingle = new System.Windows.Forms.TableLayoutPanel();
            this.btSW = new SunnyUI.UISwitch();
            this.lbInfo = new SunnyUI.UILabel();
            this.tlpSingle.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpSingle
            // 
            this.tlpSingle.ColumnCount = 2;
            this.tlpSingle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tlpSingle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSingle.Controls.Add(this.btSW, 0, 0);
            this.tlpSingle.Controls.Add(this.lbInfo, 1, 0);
            this.tlpSingle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSingle.Location = new System.Drawing.Point(0, 0);
            this.tlpSingle.Name = "tlpSingle";
            this.tlpSingle.RowCount = 1;
            this.tlpSingle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpSingle.Size = new System.Drawing.Size(241, 25);
            this.tlpSingle.TabIndex = 0;
            // 
            // btSW
            // 
            this.btSW.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btSW.Location = new System.Drawing.Point(3, 3);
            this.btSW.MinimumSize = new System.Drawing.Size(1, 1);
            this.btSW.Name = "btSW";
            this.btSW.Size = new System.Drawing.Size(64, 19);
            this.btSW.TabIndex = 0;
            this.btSW.Click += new System.EventHandler(this.btSW_Click);
            // 
            // lbInfo
            // 
            this.lbInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbInfo.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbInfo.Location = new System.Drawing.Point(73, 0);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(165, 25);
            this.lbInfo.TabIndex = 1;
            this.lbInfo.Text = "|启动|23";
            this.lbInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UIOPin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlpSingle);
            this.MaximumSize = new System.Drawing.Size(241, 25);
            this.MinimumSize = new System.Drawing.Size(241, 25);
            this.Name = "UIOPin";
            this.Size = new System.Drawing.Size(241, 25);
            this.tlpSingle.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpSingle;
        private SunnyUI.UISwitch btSW;
        private SunnyUI.UILabel lbInfo;
    }
}
