namespace RY.Ctrls
{
    partial class PProcess
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lineHeader = new SunnyUI.UILine();
            this.panelTop = new System.Windows.Forms.Panel();
            this.tbpTop = new System.Windows.Forms.TableLayoutPanel();
            this.cbProcess = new SunnyUI.UIComboBox();
            this.pnlTopButton = new System.Windows.Forms.FlowLayoutPanel();
            this.btAddProcess = new SunnyUI.UISymbolButton();
            this.btCopyProcess = new SunnyUI.UISymbolButton();
            this.btDelProcess = new SunnyUI.UISymbolButton();
            this.panelCtrl = new System.Windows.Forms.Panel();
            this.tbpCtrl = new System.Windows.Forms.TableLayoutPanel();
            this.lbCtrlLeftHeader = new SunnyUI.UISymbolLabel();
            this.lbCtrlMidHeader = new SunnyUI.UISymbolLabel();
            this.lbCtrlRightHeader = new SunnyUI.UISymbolLabel();
            this.dgvCurProcess = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.参数 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvAllProcess = new System.Windows.Forms.DataGridView();
            this.序号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.名称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.类型 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.说明 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.uiLabel1 = new SunnyUI.UILabel();
            this.tbSearch = new SunnyUI.UITextBox();
            this.flpOp = new System.Windows.Forms.FlowLayoutPanel();
            this.btMoveUp = new SunnyUI.UISymbolButton();
            this.btMoveDown = new SunnyUI.UISymbolButton();
            this.btAddIn = new SunnyUI.UISymbolButton();
            this.btDelCur = new SunnyUI.UISymbolButton();
            this.panelTop.SuspendLayout();
            this.tbpTop.SuspendLayout();
            this.pnlTopButton.SuspendLayout();
            this.panelCtrl.SuspendLayout();
            this.tbpCtrl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurProcess)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllProcess)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.flpOp.SuspendLayout();
            this.SuspendLayout();
            // 
            // lineHeader
            // 
            this.lineHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.lineHeader.FillColor = System.Drawing.Color.White;
            this.lineHeader.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lineHeader.LineSize = 3;
            this.lineHeader.Location = new System.Drawing.Point(0, 0);
            this.lineHeader.MinimumSize = new System.Drawing.Size(2, 2);
            this.lineHeader.Name = "lineHeader";
            this.lineHeader.Size = new System.Drawing.Size(960, 26);
            this.lineHeader.Style = SunnyUI.UIStyle.Custom;
            this.lineHeader.TabIndex = 0;
            this.lineHeader.Text = "流程管理";
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.tbpTop);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 26);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(960, 52);
            this.panelTop.TabIndex = 1;
            // 
            // tbpTop
            // 
            this.tbpTop.ColumnCount = 2;
            this.tbpTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.54546F));
            this.tbpTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.45454F));
            this.tbpTop.Controls.Add(this.cbProcess, 0, 0);
            this.tbpTop.Controls.Add(this.pnlTopButton, 1, 0);
            this.tbpTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbpTop.Location = new System.Drawing.Point(0, 0);
            this.tbpTop.Name = "tbpTop";
            this.tbpTop.RowCount = 1;
            this.tbpTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbpTop.Size = new System.Drawing.Size(960, 52);
            this.tbpTop.TabIndex = 0;
            // 
            // cbProcess
            // 
            this.cbProcess.DataSource = null;
            this.cbProcess.Dock = System.Windows.Forms.DockStyle.Right;
            this.cbProcess.DropDownStyle = SunnyUI.UIDropDownStyle.DropDownList;
            this.cbProcess.FillColor = System.Drawing.Color.White;
            this.cbProcess.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbProcess.Location = new System.Drawing.Point(223, 5);
            this.cbProcess.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbProcess.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbProcess.Name = "cbProcess";
            this.cbProcess.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbProcess.Size = new System.Drawing.Size(296, 42);
            this.cbProcess.TabIndex = 0;
            this.cbProcess.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbProcess.SelectedIndexChanged += new System.EventHandler(this.cbProcess_SelectedIndexChanged);
            // 
            // pnlTopButton
            // 
            this.pnlTopButton.Controls.Add(this.btAddProcess);
            this.pnlTopButton.Controls.Add(this.btCopyProcess);
            this.pnlTopButton.Controls.Add(this.btDelProcess);
            this.pnlTopButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTopButton.Location = new System.Drawing.Point(526, 3);
            this.pnlTopButton.Name = "pnlTopButton";
            this.pnlTopButton.Size = new System.Drawing.Size(431, 46);
            this.pnlTopButton.TabIndex = 1;
            // 
            // btAddProcess
            // 
            this.btAddProcess.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAddProcess.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btAddProcess.Location = new System.Drawing.Point(3, 3);
            this.btAddProcess.MinimumSize = new System.Drawing.Size(1, 1);
            this.btAddProcess.Name = "btAddProcess";
            this.btAddProcess.Size = new System.Drawing.Size(105, 40);
            this.btAddProcess.Symbol = 557403;
            this.btAddProcess.TabIndex = 0;
            this.btAddProcess.Text = "新建";
            this.btAddProcess.Click += new System.EventHandler(this.btAddProcess_Click);
            // 
            // btCopyProcess
            // 
            this.btCopyProcess.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCopyProcess.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btCopyProcess.Location = new System.Drawing.Point(114, 3);
            this.btCopyProcess.MinimumSize = new System.Drawing.Size(1, 1);
            this.btCopyProcess.Name = "btCopyProcess";
            this.btCopyProcess.Size = new System.Drawing.Size(105, 40);
            this.btCopyProcess.Symbol = 261637;
            this.btCopyProcess.TabIndex = 1;
            this.btCopyProcess.Text = "复制";
            this.btCopyProcess.Click += new System.EventHandler(this.btCopyProcess_Click);
            // 
            // btDelProcess
            // 
            this.btDelProcess.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btDelProcess.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btDelProcess.Location = new System.Drawing.Point(225, 3);
            this.btDelProcess.MinimumSize = new System.Drawing.Size(1, 1);
            this.btDelProcess.Name = "btDelProcess";
            this.btDelProcess.Size = new System.Drawing.Size(105, 40);
            this.btDelProcess.Symbol = 559694;
            this.btDelProcess.TabIndex = 2;
            this.btDelProcess.Text = "删除";
            this.btDelProcess.Click += new System.EventHandler(this.btDelProcess_Click);
            // 
            // panelCtrl
            // 
            this.panelCtrl.Controls.Add(this.tbpCtrl);
            this.panelCtrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCtrl.Location = new System.Drawing.Point(0, 78);
            this.panelCtrl.Name = "panelCtrl";
            this.panelCtrl.Size = new System.Drawing.Size(960, 448);
            this.panelCtrl.TabIndex = 2;
            // 
            // tbpCtrl
            // 
            this.tbpCtrl.ColumnCount = 3;
            this.tbpCtrl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbpCtrl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tbpCtrl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbpCtrl.Controls.Add(this.lbCtrlLeftHeader, 0, 0);
            this.tbpCtrl.Controls.Add(this.lbCtrlMidHeader, 1, 0);
            this.tbpCtrl.Controls.Add(this.lbCtrlRightHeader, 2, 0);
            this.tbpCtrl.Controls.Add(this.dgvCurProcess, 0, 2);
            this.tbpCtrl.Controls.Add(this.dgvAllProcess, 2, 2);
            this.tbpCtrl.Controls.Add(this.tableLayoutPanel1, 2, 1);
            this.tbpCtrl.Controls.Add(this.flpOp, 1, 2);
            this.tbpCtrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbpCtrl.Location = new System.Drawing.Point(0, 0);
            this.tbpCtrl.Name = "tbpCtrl";
            this.tbpCtrl.RowCount = 4;
            this.tbpCtrl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tbpCtrl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tbpCtrl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbpCtrl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tbpCtrl.Size = new System.Drawing.Size(960, 448);
            this.tbpCtrl.TabIndex = 0;
            // 
            // lbCtrlLeftHeader
            // 
            this.lbCtrlLeftHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbCtrlLeftHeader.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbCtrlLeftHeader.Location = new System.Drawing.Point(3, 3);
            this.lbCtrlLeftHeader.MinimumSize = new System.Drawing.Size(1, 1);
            this.lbCtrlLeftHeader.Name = "lbCtrlLeftHeader";
            this.lbCtrlLeftHeader.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.lbCtrlLeftHeader.Size = new System.Drawing.Size(429, 34);
            this.lbCtrlLeftHeader.Symbol = 61987;
            this.lbCtrlLeftHeader.TabIndex = 0;
            this.lbCtrlLeftHeader.Text = "当前任务内容";
            // 
            // lbCtrlMidHeader
            // 
            this.lbCtrlMidHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbCtrlMidHeader.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbCtrlMidHeader.Location = new System.Drawing.Point(438, 3);
            this.lbCtrlMidHeader.MinimumSize = new System.Drawing.Size(1, 1);
            this.lbCtrlMidHeader.Name = "lbCtrlMidHeader";
            this.lbCtrlMidHeader.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.lbCtrlMidHeader.Size = new System.Drawing.Size(84, 34);
            this.lbCtrlMidHeader.Symbol = 561707;
            this.lbCtrlMidHeader.TabIndex = 1;
            this.lbCtrlMidHeader.Text = "操作";
            // 
            // lbCtrlRightHeader
            // 
            this.lbCtrlRightHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbCtrlRightHeader.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbCtrlRightHeader.Location = new System.Drawing.Point(528, 3);
            this.lbCtrlRightHeader.MinimumSize = new System.Drawing.Size(1, 1);
            this.lbCtrlRightHeader.Name = "lbCtrlRightHeader";
            this.lbCtrlRightHeader.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.lbCtrlRightHeader.Size = new System.Drawing.Size(429, 34);
            this.lbCtrlRightHeader.Symbol = 560328;
            this.lbCtrlRightHeader.TabIndex = 2;
            this.lbCtrlRightHeader.Text = "所有执行方法";
            // 
            // dgvCurProcess
            // 
            this.dgvCurProcess.AllowUserToAddRows = false;
            this.dgvCurProcess.AllowUserToDeleteRows = false;
            this.dgvCurProcess.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCurProcess.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.参数,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dgvCurProcess.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCurProcess.Location = new System.Drawing.Point(3, 83);
            this.dgvCurProcess.Name = "dgvCurProcess";
            this.dgvCurProcess.ReadOnly = true;
            this.dgvCurProcess.RowTemplate.Height = 23;
            this.dgvCurProcess.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCurProcess.Size = new System.Drawing.Size(429, 322);
            this.dgvCurProcess.TabIndex = 3;
            this.dgvCurProcess.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvCurProcess_CellMouseDoubleClick);
            this.dgvCurProcess.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvCurProcess_CellMouseDown);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "序号";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn1.Width = 60;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "名称";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // 参数
            // 
            this.参数.HeaderText = "参数";
            this.参数.Name = "参数";
            this.参数.ReadOnly = true;
            this.参数.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.参数.Width = 200;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "说明";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn3.Width = 300;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "类型";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn4.Width = 200;
            // 
            // dgvAllProcess
            // 
            this.dgvAllProcess.AllowUserToAddRows = false;
            this.dgvAllProcess.AllowUserToDeleteRows = false;
            this.dgvAllProcess.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllProcess.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.序号,
            this.名称,
            this.类型,
            this.说明});
            this.dgvAllProcess.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAllProcess.Location = new System.Drawing.Point(528, 83);
            this.dgvAllProcess.MultiSelect = false;
            this.dgvAllProcess.Name = "dgvAllProcess";
            this.dgvAllProcess.ReadOnly = true;
            this.dgvAllProcess.RowTemplate.Height = 23;
            this.dgvAllProcess.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAllProcess.Size = new System.Drawing.Size(429, 322);
            this.dgvAllProcess.TabIndex = 4;
            this.dgvAllProcess.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvAllProcess_CellMouseDoubleClick);
            // 
            // 序号
            // 
            this.序号.HeaderText = "序号";
            this.序号.Name = "序号";
            this.序号.ReadOnly = true;
            this.序号.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.序号.Width = 60;
            // 
            // 名称
            // 
            this.名称.HeaderText = "名称";
            this.名称.Name = "名称";
            this.名称.ReadOnly = true;
            this.名称.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.名称.Width = 200;
            // 
            // 类型
            // 
            this.类型.HeaderText = "类型";
            this.类型.Name = "类型";
            this.类型.ReadOnly = true;
            this.类型.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // 说明
            // 
            this.说明.HeaderText = "说明";
            this.说明.Name = "说明";
            this.说明.ReadOnly = true;
            this.说明.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.说明.Width = 300;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.uiLabel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbSearch, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(528, 43);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(429, 34);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // uiLabel1
            // 
            this.uiLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel1.Location = new System.Drawing.Point(3, 0);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(101, 34);
            this.uiLabel1.Style = SunnyUI.UIStyle.Custom;
            this.uiLabel1.TabIndex = 0;
            this.uiLabel1.Text = "搜索";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbSearch
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.tbSearch, 2);
            this.tbSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbSearch.FillColor = System.Drawing.Color.White;
            this.tbSearch.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbSearch.Location = new System.Drawing.Point(111, 5);
            this.tbSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbSearch.Maximum = 2147483647D;
            this.tbSearch.Minimum = -2147483648D;
            this.tbSearch.MinimumSize = new System.Drawing.Size(1, 1);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(206, 26);
            this.tbSearch.Symbol = 61442;
            this.tbSearch.TabIndex = 1;
            this.tbSearch.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // flpOp
            // 
            this.flpOp.Controls.Add(this.btMoveUp);
            this.flpOp.Controls.Add(this.btMoveDown);
            this.flpOp.Controls.Add(this.btAddIn);
            this.flpOp.Controls.Add(this.btDelCur);
            this.flpOp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpOp.Location = new System.Drawing.Point(438, 83);
            this.flpOp.Name = "flpOp";
            this.flpOp.Size = new System.Drawing.Size(84, 322);
            this.flpOp.TabIndex = 6;
            // 
            // btMoveUp
            // 
            this.btMoveUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btMoveUp.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btMoveUp.Location = new System.Drawing.Point(3, 3);
            this.btMoveUp.MinimumSize = new System.Drawing.Size(1, 1);
            this.btMoveUp.Name = "btMoveUp";
            this.btMoveUp.Size = new System.Drawing.Size(78, 56);
            this.btMoveUp.Symbol = 61538;
            this.btMoveUp.TabIndex = 0;
            this.btMoveUp.Text = "上移";
            this.btMoveUp.Click += new System.EventHandler(this.btMoveUp_Click);
            // 
            // btMoveDown
            // 
            this.btMoveDown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btMoveDown.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btMoveDown.Location = new System.Drawing.Point(3, 65);
            this.btMoveDown.MinimumSize = new System.Drawing.Size(1, 1);
            this.btMoveDown.Name = "btMoveDown";
            this.btMoveDown.Size = new System.Drawing.Size(78, 56);
            this.btMoveDown.Symbol = 61539;
            this.btMoveDown.TabIndex = 1;
            this.btMoveDown.Text = "下移";
            this.btMoveDown.Click += new System.EventHandler(this.btMoveDown_Click);
            // 
            // btAddIn
            // 
            this.btAddIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAddIn.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btAddIn.Location = new System.Drawing.Point(3, 127);
            this.btAddIn.MinimumSize = new System.Drawing.Size(1, 1);
            this.btAddIn.Name = "btAddIn";
            this.btAddIn.Size = new System.Drawing.Size(78, 56);
            this.btAddIn.Symbol = 61536;
            this.btAddIn.TabIndex = 2;
            this.btAddIn.Text = "添加";
            this.btAddIn.Click += new System.EventHandler(this.btAddIn_Click);
            // 
            // btDelCur
            // 
            this.btDelCur.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btDelCur.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btDelCur.Location = new System.Drawing.Point(3, 189);
            this.btDelCur.MinimumSize = new System.Drawing.Size(1, 1);
            this.btDelCur.Name = "btDelCur";
            this.btDelCur.Size = new System.Drawing.Size(78, 56);
            this.btDelCur.Symbol = 61532;
            this.btDelCur.TabIndex = 3;
            this.btDelCur.Text = "删除";
            this.btDelCur.Click += new System.EventHandler(this.btDelCur_Click);
            // 
            // PProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(960, 526);
            this.Controls.Add(this.panelCtrl);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.lineHeader);
            this.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PProcess";
            this.Style = SunnyUI.UIStyle.Custom;
            this.Text = "PTask";
            this.panelTop.ResumeLayout(false);
            this.tbpTop.ResumeLayout(false);
            this.pnlTopButton.ResumeLayout(false);
            this.panelCtrl.ResumeLayout(false);
            this.tbpCtrl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurProcess)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllProcess)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flpOp.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private SunnyUI.UILine lineHeader;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelCtrl;
        private System.Windows.Forms.TableLayoutPanel tbpTop;
        private SunnyUI.UIComboBox cbProcess;
        private System.Windows.Forms.FlowLayoutPanel pnlTopButton;
        private SunnyUI.UISymbolButton btAddProcess;
        private SunnyUI.UISymbolButton btCopyProcess;
        private SunnyUI.UISymbolButton btDelProcess;
        private System.Windows.Forms.TableLayoutPanel tbpCtrl;
        private SunnyUI.UISymbolLabel lbCtrlLeftHeader;
        private SunnyUI.UISymbolLabel lbCtrlMidHeader;
        private SunnyUI.UISymbolLabel lbCtrlRightHeader;
        private System.Windows.Forms.DataGridView dgvCurProcess;
        private System.Windows.Forms.DataGridView dgvAllProcess;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private SunnyUI.UILabel uiLabel1;
        private SunnyUI.UITextBox tbSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn 序号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 名称;
        private System.Windows.Forms.DataGridViewTextBoxColumn 类型;
        private System.Windows.Forms.DataGridViewTextBoxColumn 说明;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn 参数;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.FlowLayoutPanel flpOp;
        private SunnyUI.UISymbolButton btMoveUp;
        private SunnyUI.UISymbolButton btMoveDown;
        private SunnyUI.UISymbolButton btAddIn;
        private SunnyUI.UISymbolButton btDelCur;
    }
}