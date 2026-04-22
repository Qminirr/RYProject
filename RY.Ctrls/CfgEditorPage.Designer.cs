namespace RY.Ctrls
{
    partial class CfgEditorPage
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
            this.pg = new System.Windows.Forms.PropertyGrid();
            this.uiCaption = new SunnyUI.UILine();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btSave = new SunnyUI.UISymbolButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.pg, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.uiCaption, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(866, 593);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pg
            // 
            this.pg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pg.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pg.Location = new System.Drawing.Point(176, 73);
            this.pg.Name = "pg";
            this.pg.Size = new System.Drawing.Size(513, 517);
            this.pg.TabIndex = 0;
            // 
            // uiCaption
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.uiCaption, 3);
            this.uiCaption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiCaption.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiCaption.LineSize = 3;
            this.uiCaption.Location = new System.Drawing.Point(3, 3);
            this.uiCaption.MinimumSize = new System.Drawing.Size(2, 2);
            this.uiCaption.Name = "uiCaption";
            this.uiCaption.Size = new System.Drawing.Size(860, 24);
            this.uiCaption.TabIndex = 1;
            this.uiCaption.Text = "配置更改";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btSave);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(176, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(513, 34);
            this.panel1.TabIndex = 3;
            // 
            // btSave
            // 
            this.btSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSave.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btSave.Location = new System.Drawing.Point(0, 0);
            this.btSave.MinimumSize = new System.Drawing.Size(1, 1);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(100, 35);
            this.btSave.Symbol = 61639;
            this.btSave.TabIndex = 2;
            this.btSave.Text = "保存";
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // CfgEditorPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 593);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "CfgEditorPage";
            this.Symbol = 61447;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PropertyGrid pg;
        private SunnyUI.UILine uiCaption;
        private System.Windows.Forms.Panel panel1;
        private SunnyUI.UISymbolButton btSave;
    }
}
