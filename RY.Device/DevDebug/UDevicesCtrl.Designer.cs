namespace RY.Device
{
    partial class UDevicesCtrl
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
            this.panelTop = new System.Windows.Forms.Panel();
            this.tlpTop = new System.Windows.Forms.TableLayoutPanel();
            this.panelTopCtrl = new System.Windows.Forms.Panel();
            this.btSave = new SunnyUI.UISymbolButton();
            this.btAdd = new SunnyUI.UISymbolButton();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lbDes = new SunnyUI.UIMarkLabel();
            this.cbModule = new SunnyUI.UIComboBox();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.lsbDevNames = new SunnyUI.UIListBox();
            this.panelMid = new System.Windows.Forms.Panel();
            this.btDebugForm = new SunnyUI.UISymbolButton();
            this.btDel = new SunnyUI.UISymbolButton();
            this.btRename = new SunnyUI.UISymbolButton();
            this.panelRight = new System.Windows.Forms.Panel();
            this.pg = new System.Windows.Forms.PropertyGrid();
            this.tt = new System.Windows.Forms.ToolTip(this.components);
            this.btUp = new SunnyUI.UISymbolButton();
            this.btDown = new SunnyUI.UISymbolButton();
            this.panelTop.SuspendLayout();
            this.tlpTop.SuspendLayout();
            this.panelTopCtrl.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.panelMid.SuspendLayout();
            this.panelRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.tlpTop);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(4);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(876, 47);
            this.panelTop.TabIndex = 0;
            // 
            // tlpTop
            // 
            this.tlpTop.ColumnCount = 2;
            this.tlpTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tlpTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpTop.Controls.Add(this.panelTopCtrl, 1, 0);
            this.tlpTop.Controls.Add(this.pnlTop, 0, 0);
            this.tlpTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpTop.Location = new System.Drawing.Point(0, 0);
            this.tlpTop.Name = "tlpTop";
            this.tlpTop.RowCount = 1;
            this.tlpTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTop.Size = new System.Drawing.Size(876, 47);
            this.tlpTop.TabIndex = 0;
            // 
            // panelTopCtrl
            // 
            this.panelTopCtrl.Controls.Add(this.btSave);
            this.panelTopCtrl.Controls.Add(this.btAdd);
            this.panelTopCtrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTopCtrl.Location = new System.Drawing.Point(616, 3);
            this.panelTopCtrl.Name = "panelTopCtrl";
            this.panelTopCtrl.Size = new System.Drawing.Size(257, 41);
            this.panelTopCtrl.TabIndex = 1;
            // 
            // btSave
            // 
            this.btSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSave.Dock = System.Windows.Forms.DockStyle.Left;
            this.btSave.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btSave.Location = new System.Drawing.Point(100, 0);
            this.btSave.MinimumSize = new System.Drawing.Size(1, 1);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(100, 41);
            this.btSave.Symbol = 61639;
            this.btSave.TabIndex = 2;
            this.btSave.Text = "保存";
            this.tt.SetToolTip(this.btSave, "保存修改");
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btAdd
            // 
            this.btAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAdd.Dock = System.Windows.Forms.DockStyle.Left;
            this.btAdd.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btAdd.Location = new System.Drawing.Point(0, 0);
            this.btAdd.MinimumSize = new System.Drawing.Size(1, 1);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(100, 41);
            this.btAdd.Symbol = 61543;
            this.btAdd.TabIndex = 1;
            this.btAdd.Text = "添加";
            this.tt.SetToolTip(this.btAdd, "添加硬件");
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.lbDes);
            this.pnlTop.Controls.Add(this.cbModule);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTop.Location = new System.Drawing.Point(3, 3);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(607, 41);
            this.pnlTop.TabIndex = 2;
            // 
            // lbDes
            // 
            this.lbDes.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbDes.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbDes.Location = new System.Drawing.Point(164, 0);
            this.lbDes.Name = "lbDes";
            this.lbDes.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.lbDes.Size = new System.Drawing.Size(162, 41);
            this.lbDes.TabIndex = 2;
            this.lbDes.Text = "当前设备列表：";
            this.lbDes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbModule
            // 
            this.cbModule.DataSource = null;
            this.cbModule.Dock = System.Windows.Forms.DockStyle.Right;
            this.cbModule.DropDownStyle = SunnyUI.UIDropDownStyle.DropDownList;
            this.cbModule.FillColor = System.Drawing.Color.White;
            this.cbModule.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbModule.Location = new System.Drawing.Point(326, 0);
            this.cbModule.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbModule.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbModule.Name = "cbModule";
            this.cbModule.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbModule.Size = new System.Drawing.Size(281, 41);
            this.cbModule.TabIndex = 0;
            this.cbModule.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tt.SetToolTip(this.cbModule, "目前系统所有插件列表");
            // 
            // panelLeft
            // 
            this.panelLeft.Controls.Add(this.lsbDevNames);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 47);
            this.panelLeft.Margin = new System.Windows.Forms.Padding(4);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(197, 452);
            this.panelLeft.TabIndex = 1;
            // 
            // lsbDevNames
            // 
            this.lsbDevNames.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsbDevNames.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lsbDevNames.FormatString = "";
            this.lsbDevNames.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.lsbDevNames.Location = new System.Drawing.Point(0, 0);
            this.lsbDevNames.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lsbDevNames.MinimumSize = new System.Drawing.Size(1, 1);
            this.lsbDevNames.Name = "lsbDevNames";
            this.lsbDevNames.Padding = new System.Windows.Forms.Padding(2);
            this.lsbDevNames.Size = new System.Drawing.Size(197, 452);
            this.lsbDevNames.TabIndex = 0;
            this.lsbDevNames.Text = "uiListBox1";
            this.lsbDevNames.SelectedIndexChanged += new System.EventHandler(this.lbDevNames_SelectedIndexChanged);
            // 
            // panelMid
            // 
            this.panelMid.Controls.Add(this.btDown);
            this.panelMid.Controls.Add(this.btUp);
            this.panelMid.Controls.Add(this.btDebugForm);
            this.panelMid.Controls.Add(this.btDel);
            this.panelMid.Controls.Add(this.btRename);
            this.panelMid.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMid.Location = new System.Drawing.Point(197, 47);
            this.panelMid.Name = "panelMid";
            this.panelMid.Size = new System.Drawing.Size(82, 452);
            this.panelMid.TabIndex = 2;
            // 
            // btDebugForm
            // 
            this.btDebugForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btDebugForm.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btDebugForm.Location = new System.Drawing.Point(7, 89);
            this.btDebugForm.MinimumSize = new System.Drawing.Size(1, 1);
            this.btDebugForm.Name = "btDebugForm";
            this.btDebugForm.Size = new System.Drawing.Size(69, 51);
            this.btDebugForm.Symbol = 61613;
            this.btDebugForm.SymbolOffset = new System.Drawing.Point(0, -10);
            this.btDebugForm.SymbolSize = 32;
            this.btDebugForm.TabIndex = 2;
            this.btDebugForm.Text = "调试";
            this.btDebugForm.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tt.SetToolTip(this.btDebugForm, "调试设备");
            this.btDebugForm.Click += new System.EventHandler(this.btDebugForm_Click);
            // 
            // btDel
            // 
            this.btDel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btDel.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btDel.Location = new System.Drawing.Point(7, 328);
            this.btDel.MinimumSize = new System.Drawing.Size(1, 1);
            this.btDel.Name = "btDel";
            this.btDel.Size = new System.Drawing.Size(69, 51);
            this.btDel.Symbol = 559691;
            this.btDel.SymbolOffset = new System.Drawing.Point(0, -10);
            this.btDel.SymbolSize = 32;
            this.btDel.TabIndex = 1;
            this.btDel.Text = "删除";
            this.btDel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tt.SetToolTip(this.btDel, "删除设备");
            this.btDel.Click += new System.EventHandler(this.btDel_Click);
            // 
            // btRename
            // 
            this.btRename.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btRename.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btRename.Location = new System.Drawing.Point(7, 19);
            this.btRename.MinimumSize = new System.Drawing.Size(1, 1);
            this.btRename.Name = "btRename";
            this.btRename.Size = new System.Drawing.Size(69, 51);
            this.btRename.Symbol = 559810;
            this.btRename.SymbolOffset = new System.Drawing.Point(0, -10);
            this.btRename.SymbolSize = 32;
            this.btRename.TabIndex = 0;
            this.btRename.Text = "重命名";
            this.btRename.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tt.SetToolTip(this.btRename, "重命名设备");
            this.btRename.Click += new System.EventHandler(this.btRename_Click);
            // 
            // panelRight
            // 
            this.panelRight.Controls.Add(this.pg);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight.Location = new System.Drawing.Point(279, 47);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(597, 452);
            this.panelRight.TabIndex = 3;
            // 
            // pg
            // 
            this.pg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pg.Location = new System.Drawing.Point(0, 0);
            this.pg.Name = "pg";
            this.pg.Size = new System.Drawing.Size(597, 452);
            this.pg.TabIndex = 0;
            this.pg.ToolbarVisible = false;
            // 
            // btUp
            // 
            this.btUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btUp.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btUp.Location = new System.Drawing.Point(7, 162);
            this.btUp.MinimumSize = new System.Drawing.Size(1, 1);
            this.btUp.Name = "btUp";
            this.btUp.Size = new System.Drawing.Size(69, 51);
            this.btUp.Symbol = 61538;
            this.btUp.SymbolSize = 32;
            this.btUp.TabIndex = 3;
            this.btUp.Text = "上移";
            this.btUp.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tt.SetToolTip(this.btUp, "上移");
            this.btUp.Click += new System.EventHandler(this.btUp_Click);
            // 
            // btDown
            // 
            this.btDown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btDown.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btDown.Location = new System.Drawing.Point(7, 235);
            this.btDown.MinimumSize = new System.Drawing.Size(1, 1);
            this.btDown.Name = "btDown";
            this.btDown.Size = new System.Drawing.Size(69, 51);
            this.btDown.Symbol = 61539;
            this.btDown.SymbolSize = 32;
            this.btDown.TabIndex = 4;
            this.btDown.Text = "下移";
            this.btDown.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tt.SetToolTip(this.btDown, "下移");
            this.btDown.Click += new System.EventHandler(this.btDown_Click);
            // 
            // UDevicesCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelMid);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelTop);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UDevicesCtrl";
            this.Size = new System.Drawing.Size(876, 499);
            this.Load += new System.EventHandler(this.UDevicesCtrl_Load);
            this.panelTop.ResumeLayout(false);
            this.tlpTop.ResumeLayout(false);
            this.panelTopCtrl.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.panelLeft.ResumeLayout(false);
            this.panelMid.ResumeLayout(false);
            this.panelRight.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelMid;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.TableLayoutPanel tlpTop;
        private SunnyUI.UIComboBox cbModule;
        private System.Windows.Forms.ToolTip tt;
        private SunnyUI.UISymbolButton btAdd;
        private SunnyUI.UIListBox lsbDevNames;
        private SunnyUI.UISymbolButton btDel;
        private SunnyUI.UISymbolButton btRename;
        private System.Windows.Forms.PropertyGrid pg;
        private System.Windows.Forms.Panel panelTopCtrl;
        private SunnyUI.UISymbolButton btSave;
        private System.Windows.Forms.Panel pnlTop;
        private SunnyUI.UIMarkLabel lbDes;
        private SunnyUI.UISymbolButton btDebugForm;
        private SunnyUI.UISymbolButton btDown;
        private SunnyUI.UISymbolButton btUp;
    }
}
