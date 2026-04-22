namespace RY.Ctrls
{
    partial class UBoolFuncEditor
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
            this.tblCtrl = new System.Windows.Forms.TableLayoutPanel();
            this.tbSearch = new SunnyUI.UITextBox();
            this.lsbNames = new System.Windows.Forms.ListBox();
            this.btConfirm = new SunnyUI.UISymbolButton();
            this.lbCmd = new SunnyUI.UISymbolLabel();
            this.panelCtrl = new System.Windows.Forms.Panel();
            this.tblCtrl.SuspendLayout();
            this.panelCtrl.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblCtrl
            // 
            this.tblCtrl.ColumnCount = 2;
            this.tblCtrl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblCtrl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tblCtrl.Controls.Add(this.tbSearch, 0, 0);
            this.tblCtrl.Controls.Add(this.lsbNames, 0, 1);
            this.tblCtrl.Controls.Add(this.btConfirm, 1, 0);
            this.tblCtrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblCtrl.Location = new System.Drawing.Point(0, 0);
            this.tblCtrl.Name = "tblCtrl";
            this.tblCtrl.RowCount = 2;
            this.tblCtrl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tblCtrl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblCtrl.Size = new System.Drawing.Size(370, 273);
            this.tblCtrl.TabIndex = 0;
            // 
            // tbSearch
            // 
            this.tbSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbSearch.FillColor = System.Drawing.Color.White;
            this.tbSearch.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.tbSearch.Location = new System.Drawing.Point(4, 5);
            this.tbSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbSearch.Maximum = 2147483647D;
            this.tbSearch.Minimum = -2147483648D;
            this.tbSearch.MinimumSize = new System.Drawing.Size(1, 1);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(252, 30);
            this.tbSearch.Symbol = 61442;
            this.tbSearch.TabIndex = 0;
            this.tbSearch.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // lsbNames
            // 
            this.lsbNames.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsbNames.FormattingEnabled = true;
            this.lsbNames.ItemHeight = 17;
            this.lsbNames.Location = new System.Drawing.Point(3, 43);
            this.lsbNames.Name = "lsbNames";
            this.lsbNames.Size = new System.Drawing.Size(254, 227);
            this.lsbNames.TabIndex = 1;
            // 
            // btConfirm
            // 
            this.btConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btConfirm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btConfirm.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btConfirm.Location = new System.Drawing.Point(263, 3);
            this.btConfirm.MinimumSize = new System.Drawing.Size(1, 1);
            this.btConfirm.Name = "btConfirm";
            this.btConfirm.Size = new System.Drawing.Size(104, 34);
            this.btConfirm.Symbol = 261528;
            this.btConfirm.TabIndex = 2;
            this.btConfirm.Text = "修改";
            this.btConfirm.Click += new System.EventHandler(this.btConfirm_Click);
            // 
            // lbCmd
            // 
            this.lbCmd.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbCmd.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbCmd.Location = new System.Drawing.Point(0, 0);
            this.lbCmd.MinimumSize = new System.Drawing.Size(1, 1);
            this.lbCmd.Name = "lbCmd";
            this.lbCmd.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.lbCmd.Size = new System.Drawing.Size(370, 35);
            this.lbCmd.Symbol = 61737;
            this.lbCmd.TabIndex = 1;
            this.lbCmd.Text = "当前命令：开灯(0)";
            this.lbCmd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelCtrl
            // 
            this.panelCtrl.Controls.Add(this.tblCtrl);
            this.panelCtrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCtrl.Location = new System.Drawing.Point(0, 35);
            this.panelCtrl.Name = "panelCtrl";
            this.panelCtrl.Size = new System.Drawing.Size(370, 273);
            this.panelCtrl.TabIndex = 2;
            // 
            // UBoolFuncEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelCtrl);
            this.Controls.Add(this.lbCmd);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UBoolFuncEditor";
            this.Size = new System.Drawing.Size(370, 308);
            this.tblCtrl.ResumeLayout(false);
            this.panelCtrl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblCtrl;
        private SunnyUI.UISymbolLabel lbCmd;
        private System.Windows.Forms.Panel panelCtrl;
        private SunnyUI.UITextBox tbSearch;
        private System.Windows.Forms.ListBox lsbNames;
        private SunnyUI.UISymbolButton btConfirm;
    }
}
