namespace RY.Ctrls
{
    partial class URYBoolDelegate
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btExec = new SunnyUI.UISymbolButton();
            this.lbName = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.btExec, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbName, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(429, 34);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btExec
            // 
            this.btExec.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btExec.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btExec.Location = new System.Drawing.Point(3, 3);
            this.btExec.MinimumSize = new System.Drawing.Size(1, 1);
            this.btExec.Name = "btExec";
            this.btExec.Size = new System.Drawing.Size(94, 28);
            this.btExec.Symbol = 61533;
            this.btExec.TabIndex = 0;
            this.btExec.Text = "执行";
            this.btExec.Click += new System.EventHandler(this.btExec_Click);
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbName.Location = new System.Drawing.Point(103, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(323, 34);
            this.lbName.TabIndex = 1;
            this.lbName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // URYBoolDelegate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "URYBoolDelegate";
            this.Size = new System.Drawing.Size(429, 34);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private SunnyUI.UISymbolButton btExec;
        private System.Windows.Forms.Label lbName;
    }
}
