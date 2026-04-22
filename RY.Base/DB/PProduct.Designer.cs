namespace RY.Base
{
    partial class PProduct
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PProduct));
            this.tabCtrl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1Fill = new System.Windows.Forms.Panel();
            this.dvAll = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.日期 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.结果 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1Left = new System.Windows.Forms.Panel();
            this.btExport = new SunnyUI.UISymbolButton();
            this.btQuery = new SunnyUI.UISymbolButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbp1product = new System.Windows.Forms.ComboBox();
            this.uiMarkLabel4 = new SunnyUI.UIMarkLabel();
            this.uiMarkLabel3 = new SunnyUI.UIMarkLabel();
            this.cbp1select = new System.Windows.Forms.ComboBox();
            this.uiMarkLabel1 = new SunnyUI.UIMarkLabel();
            this.dtp1to = new System.Windows.Forms.DateTimePicker();
            this.uiMarkLabel2 = new SunnyUI.UIMarkLabel();
            this.dtp1from = new System.Windows.Forms.DateTimePicker();
            this.LineP1 = new SunnyUI.UILine();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel2Fill = new System.Windows.Forms.Panel();
            this.dgvDay = new System.Windows.Forms.DataGridView();
            this.panel2Left = new System.Windows.Forms.Panel();
            this.uiLine1 = new SunnyUI.UILine();
            this.imglst = new System.Windows.Forms.ImageList(this.components);
            this.lbP1QueryInfo = new SunnyUI.UISymbolLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbp2product = new System.Windows.Forms.ComboBox();
            this.uiMarkLabel5 = new SunnyUI.UIMarkLabel();
            this.uiMarkLabel7 = new SunnyUI.UIMarkLabel();
            this.btQuery2 = new SunnyUI.UISymbolButton();
            this.dtp2 = new System.Windows.Forms.DateTimePicker();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel3Left = new System.Windows.Forms.Panel();
            this.btExport3 = new SunnyUI.UISymbolButton();
            this.btQuery3 = new SunnyUI.UISymbolButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cbp3product = new System.Windows.Forms.ComboBox();
            this.uiMarkLabel6 = new SunnyUI.UIMarkLabel();
            this.uiMarkLabel9 = new SunnyUI.UIMarkLabel();
            this.dtp3 = new System.Windows.Forms.DateTimePicker();
            this.uiLine2 = new SunnyUI.UILine();
            this.panel3Fill = new System.Windows.Forms.Panel();
            this.dgvMonth = new System.Windows.Forms.DataGridView();
            this.tabCtrl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1Fill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvAll)).BeginInit();
            this.panel1Left.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel2Fill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDay)).BeginInit();
            this.panel2Left.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel3Left.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3Fill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonth)).BeginInit();
            this.SuspendLayout();
            // 
            // tabCtrl
            // 
            this.tabCtrl.Controls.Add(this.tabPage1);
            this.tabCtrl.Controls.Add(this.tabPage2);
            this.tabCtrl.Controls.Add(this.tabPage3);
            this.tabCtrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabCtrl.ImageList = this.imglst;
            this.tabCtrl.Location = new System.Drawing.Point(0, 0);
            this.tabCtrl.Name = "tabCtrl";
            this.tabCtrl.SelectedIndex = 0;
            this.tabCtrl.Size = new System.Drawing.Size(1132, 777);
            this.tabCtrl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel1Fill);
            this.tabPage1.Controls.Add(this.panel1Left);
            this.tabPage1.ImageIndex = 0;
            this.tabPage1.Location = new System.Drawing.Point(4, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1124, 734);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "记录";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel1Fill
            // 
            this.panel1Fill.Controls.Add(this.dvAll);
            this.panel1Fill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1Fill.Location = new System.Drawing.Point(243, 3);
            this.panel1Fill.Name = "panel1Fill";
            this.panel1Fill.Size = new System.Drawing.Size(878, 728);
            this.panel1Fill.TabIndex = 1;
            // 
            // dvAll
            // 
            this.dvAll.AllowUserToAddRows = false;
            this.dvAll.AllowUserToDeleteRows = false;
            this.dvAll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvAll.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.日期,
            this.Model,
            this.SN,
            this.结果,
            this.Remark});
            this.dvAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvAll.Location = new System.Drawing.Point(0, 0);
            this.dvAll.Name = "dvAll";
            this.dvAll.RowTemplate.Height = 23;
            this.dvAll.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvAll.Size = new System.Drawing.Size(878, 728);
            this.dvAll.TabIndex = 3;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "id";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // 日期
            // 
            this.日期.DataPropertyName = "dt";
            dataGridViewCellStyle2.Format = "yyyy-MM-dd HH:mm:ss";
            this.日期.DefaultCellStyle = dataGridViewCellStyle2;
            this.日期.HeaderText = "日期";
            this.日期.Name = "日期";
            this.日期.Width = 180;
            // 
            // Model
            // 
            this.Model.DataPropertyName = "model";
            this.Model.HeaderText = "机种";
            this.Model.Name = "Model";
            // 
            // SN
            // 
            this.SN.DataPropertyName = "sn";
            this.SN.HeaderText = "SN";
            this.SN.Name = "SN";
            this.SN.Width = 150;
            // 
            // 结果
            // 
            this.结果.DataPropertyName = "result";
            this.结果.HeaderText = "结果";
            this.结果.Name = "结果";
            this.结果.Width = 150;
            // 
            // Remark
            // 
            this.Remark.DataPropertyName = "remark";
            this.Remark.HeaderText = "描述";
            this.Remark.Name = "Remark";
            this.Remark.Width = 200;
            // 
            // panel1Left
            // 
            this.panel1Left.Controls.Add(this.lbP1QueryInfo);
            this.panel1Left.Controls.Add(this.btExport);
            this.panel1Left.Controls.Add(this.btQuery);
            this.panel1Left.Controls.Add(this.panel1);
            this.panel1Left.Controls.Add(this.LineP1);
            this.panel1Left.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1Left.Location = new System.Drawing.Point(3, 3);
            this.panel1Left.Name = "panel1Left";
            this.panel1Left.Size = new System.Drawing.Size(240, 728);
            this.panel1Left.TabIndex = 0;
            // 
            // btExport
            // 
            this.btExport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btExport.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btExport.Location = new System.Drawing.Point(55, 227);
            this.btExport.MinimumSize = new System.Drawing.Size(1, 1);
            this.btExport.Name = "btExport";
            this.btExport.Size = new System.Drawing.Size(129, 35);
            this.btExport.Style = SunnyUI.UIStyle.Custom;
            this.btExport.Symbol = 362830;
            this.btExport.TabIndex = 7;
            this.btExport.Text = "导出";
            // 
            // btQuery
            // 
            this.btQuery.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btQuery.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btQuery.Location = new System.Drawing.Point(55, 184);
            this.btQuery.MinimumSize = new System.Drawing.Size(1, 1);
            this.btQuery.Name = "btQuery";
            this.btQuery.Size = new System.Drawing.Size(129, 35);
            this.btQuery.Style = SunnyUI.UIStyle.Custom;
            this.btQuery.Symbol = 559566;
            this.btQuery.TabIndex = 6;
            this.btQuery.Text = "查询";
            this.btQuery.Click += new System.EventHandler(this.btQuery_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbp1product);
            this.panel1.Controls.Add(this.uiMarkLabel4);
            this.panel1.Controls.Add(this.uiMarkLabel3);
            this.panel1.Controls.Add(this.cbp1select);
            this.panel1.Controls.Add(this.uiMarkLabel1);
            this.panel1.Controls.Add(this.dtp1to);
            this.panel1.Controls.Add(this.uiMarkLabel2);
            this.panel1.Controls.Add(this.dtp1from);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 149);
            this.panel1.TabIndex = 5;
            // 
            // cbp1product
            // 
            this.cbp1product.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbp1product.FormattingEnabled = true;
            this.cbp1product.Items.AddRange(new object[] {
            "当天",
            "本周",
            "本月",
            "上月",
            "半年"});
            this.cbp1product.Location = new System.Drawing.Point(55, 107);
            this.cbp1product.Name = "cbp1product";
            this.cbp1product.Size = new System.Drawing.Size(179, 27);
            this.cbp1product.TabIndex = 8;
            // 
            // uiMarkLabel4
            // 
            this.uiMarkLabel4.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiMarkLabel4.Location = new System.Drawing.Point(3, 108);
            this.uiMarkLabel4.Name = "uiMarkLabel4";
            this.uiMarkLabel4.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.uiMarkLabel4.Size = new System.Drawing.Size(46, 23);
            this.uiMarkLabel4.Style = SunnyUI.UIStyle.Custom;
            this.uiMarkLabel4.TabIndex = 7;
            this.uiMarkLabel4.Text = "产品";
            this.uiMarkLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiMarkLabel3
            // 
            this.uiMarkLabel3.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiMarkLabel3.Location = new System.Drawing.Point(3, 9);
            this.uiMarkLabel3.Name = "uiMarkLabel3";
            this.uiMarkLabel3.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.uiMarkLabel3.Size = new System.Drawing.Size(46, 23);
            this.uiMarkLabel3.Style = SunnyUI.UIStyle.Custom;
            this.uiMarkLabel3.TabIndex = 6;
            this.uiMarkLabel3.Text = "周期";
            this.uiMarkLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbp1select
            // 
            this.cbp1select.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbp1select.FormattingEnabled = true;
            this.cbp1select.Items.AddRange(new object[] {
            "当天",
            "本周",
            "本月",
            "上月",
            "半年"});
            this.cbp1select.Location = new System.Drawing.Point(55, 9);
            this.cbp1select.Name = "cbp1select";
            this.cbp1select.Size = new System.Drawing.Size(179, 27);
            this.cbp1select.TabIndex = 5;
            this.cbp1select.SelectedIndexChanged += new System.EventHandler(this.cbp1select_SelectedIndexChanged);
            // 
            // uiMarkLabel1
            // 
            this.uiMarkLabel1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiMarkLabel1.Location = new System.Drawing.Point(3, 43);
            this.uiMarkLabel1.Name = "uiMarkLabel1";
            this.uiMarkLabel1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.uiMarkLabel1.Size = new System.Drawing.Size(35, 23);
            this.uiMarkLabel1.Style = SunnyUI.UIStyle.Custom;
            this.uiMarkLabel1.TabIndex = 2;
            this.uiMarkLabel1.Text = "从";
            this.uiMarkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtp1to
            // 
            this.dtp1to.Location = new System.Drawing.Point(55, 74);
            this.dtp1to.Name = "dtp1to";
            this.dtp1to.Size = new System.Drawing.Size(179, 26);
            this.dtp1to.TabIndex = 3;
            // 
            // uiMarkLabel2
            // 
            this.uiMarkLabel2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiMarkLabel2.Location = new System.Drawing.Point(3, 75);
            this.uiMarkLabel2.Name = "uiMarkLabel2";
            this.uiMarkLabel2.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.uiMarkLabel2.Size = new System.Drawing.Size(35, 23);
            this.uiMarkLabel2.Style = SunnyUI.UIStyle.Custom;
            this.uiMarkLabel2.TabIndex = 4;
            this.uiMarkLabel2.Text = "到";
            this.uiMarkLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtp1from
            // 
            this.dtp1from.Location = new System.Drawing.Point(55, 42);
            this.dtp1from.Name = "dtp1from";
            this.dtp1from.Size = new System.Drawing.Size(179, 26);
            this.dtp1from.TabIndex = 1;
            // 
            // LineP1
            // 
            this.LineP1.Dock = System.Windows.Forms.DockStyle.Top;
            this.LineP1.FillColor = System.Drawing.Color.White;
            this.LineP1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LineP1.Location = new System.Drawing.Point(0, 0);
            this.LineP1.MinimumSize = new System.Drawing.Size(2, 2);
            this.LineP1.Name = "LineP1";
            this.LineP1.Size = new System.Drawing.Size(240, 29);
            this.LineP1.Style = SunnyUI.UIStyle.Custom;
            this.LineP1.TabIndex = 0;
            this.LineP1.Text = "查询日期";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel2Fill);
            this.tabPage2.Controls.Add(this.panel2Left);
            this.tabPage2.ImageIndex = 1;
            this.tabPage2.Location = new System.Drawing.Point(4, 39);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1124, 734);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "日报";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel2Fill
            // 
            this.panel2Fill.Controls.Add(this.dgvDay);
            this.panel2Fill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2Fill.Location = new System.Drawing.Point(243, 3);
            this.panel2Fill.Name = "panel2Fill";
            this.panel2Fill.Size = new System.Drawing.Size(878, 728);
            this.panel2Fill.TabIndex = 3;
            // 
            // dgvDay
            // 
            this.dgvDay.AllowUserToAddRows = false;
            this.dgvDay.AllowUserToDeleteRows = false;
            this.dgvDay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDay.Location = new System.Drawing.Point(0, 0);
            this.dgvDay.Name = "dgvDay";
            this.dgvDay.RowTemplate.Height = 23;
            this.dgvDay.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDay.Size = new System.Drawing.Size(878, 728);
            this.dgvDay.TabIndex = 2;
            // 
            // panel2Left
            // 
            this.panel2Left.Controls.Add(this.btQuery2);
            this.panel2Left.Controls.Add(this.panel2);
            this.panel2Left.Controls.Add(this.uiLine1);
            this.panel2Left.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2Left.Location = new System.Drawing.Point(3, 3);
            this.panel2Left.Name = "panel2Left";
            this.panel2Left.Size = new System.Drawing.Size(240, 728);
            this.panel2Left.TabIndex = 2;
            // 
            // uiLine1
            // 
            this.uiLine1.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiLine1.FillColor = System.Drawing.Color.White;
            this.uiLine1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLine1.Location = new System.Drawing.Point(0, 0);
            this.uiLine1.MinimumSize = new System.Drawing.Size(2, 2);
            this.uiLine1.Name = "uiLine1";
            this.uiLine1.Size = new System.Drawing.Size(240, 29);
            this.uiLine1.Style = SunnyUI.UIStyle.Custom;
            this.uiLine1.TabIndex = 1;
            this.uiLine1.Text = "查询日期";
            // 
            // imglst
            // 
            this.imglst.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglst.ImageStream")));
            this.imglst.TransparentColor = System.Drawing.Color.Transparent;
            this.imglst.Images.SetKeyName(0, "book_32px.png");
            this.imglst.Images.SetKeyName(1, "sun_32px.png");
            this.imglst.Images.SetKeyName(2, "calendar_32px.png");
            // 
            // lbP1QueryInfo
            // 
            this.lbP1QueryInfo.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbP1QueryInfo.Location = new System.Drawing.Point(3, 268);
            this.lbP1QueryInfo.MinimumSize = new System.Drawing.Size(1, 1);
            this.lbP1QueryInfo.Name = "lbP1QueryInfo";
            this.lbP1QueryInfo.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.lbP1QueryInfo.Size = new System.Drawing.Size(234, 35);
            this.lbP1QueryInfo.Symbol = 0;
            this.lbP1QueryInfo.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtp2);
            this.panel2.Controls.Add(this.cbp2product);
            this.panel2.Controls.Add(this.uiMarkLabel5);
            this.panel2.Controls.Add(this.uiMarkLabel7);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 29);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(240, 81);
            this.panel2.TabIndex = 6;
            // 
            // cbp2product
            // 
            this.cbp2product.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbp2product.FormattingEnabled = true;
            this.cbp2product.Items.AddRange(new object[] {
            "当天",
            "本周",
            "本月",
            "上月",
            "半年"});
            this.cbp2product.Location = new System.Drawing.Point(52, 43);
            this.cbp2product.Name = "cbp2product";
            this.cbp2product.Size = new System.Drawing.Size(185, 27);
            this.cbp2product.TabIndex = 8;
            // 
            // uiMarkLabel5
            // 
            this.uiMarkLabel5.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiMarkLabel5.Location = new System.Drawing.Point(3, 44);
            this.uiMarkLabel5.Name = "uiMarkLabel5";
            this.uiMarkLabel5.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.uiMarkLabel5.Size = new System.Drawing.Size(46, 23);
            this.uiMarkLabel5.Style = SunnyUI.UIStyle.Custom;
            this.uiMarkLabel5.TabIndex = 7;
            this.uiMarkLabel5.Text = "产品";
            this.uiMarkLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiMarkLabel7
            // 
            this.uiMarkLabel7.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiMarkLabel7.Location = new System.Drawing.Point(3, 10);
            this.uiMarkLabel7.Name = "uiMarkLabel7";
            this.uiMarkLabel7.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.uiMarkLabel7.Size = new System.Drawing.Size(43, 23);
            this.uiMarkLabel7.Style = SunnyUI.UIStyle.Custom;
            this.uiMarkLabel7.TabIndex = 2;
            this.uiMarkLabel7.Text = "日期";
            this.uiMarkLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btQuery2
            // 
            this.btQuery2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btQuery2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btQuery2.Location = new System.Drawing.Point(61, 116);
            this.btQuery2.MinimumSize = new System.Drawing.Size(1, 1);
            this.btQuery2.Name = "btQuery2";
            this.btQuery2.Size = new System.Drawing.Size(129, 35);
            this.btQuery2.Style = SunnyUI.UIStyle.Custom;
            this.btQuery2.Symbol = 559566;
            this.btQuery2.TabIndex = 7;
            this.btQuery2.Text = "查询";
            this.btQuery2.Click += new System.EventHandler(this.btQuery2_Click);
            // 
            // dtp2
            // 
            this.dtp2.Location = new System.Drawing.Point(52, 10);
            this.dtp2.Name = "dtp2";
            this.dtp2.Size = new System.Drawing.Size(185, 26);
            this.dtp2.TabIndex = 9;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.panel3Fill);
            this.tabPage3.Controls.Add(this.panel3Left);
            this.tabPage3.ImageIndex = 2;
            this.tabPage3.Location = new System.Drawing.Point(4, 39);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1124, 734);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "月报";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // panel3Left
            // 
            this.panel3Left.Controls.Add(this.btExport3);
            this.panel3Left.Controls.Add(this.btQuery3);
            this.panel3Left.Controls.Add(this.panel4);
            this.panel3Left.Controls.Add(this.uiLine2);
            this.panel3Left.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3Left.Location = new System.Drawing.Point(0, 0);
            this.panel3Left.Name = "panel3Left";
            this.panel3Left.Size = new System.Drawing.Size(240, 734);
            this.panel3Left.TabIndex = 1;
            // 
            // btExport3
            // 
            this.btExport3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btExport3.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btExport3.Location = new System.Drawing.Point(55, 168);
            this.btExport3.MinimumSize = new System.Drawing.Size(1, 1);
            this.btExport3.Name = "btExport3";
            this.btExport3.Size = new System.Drawing.Size(129, 35);
            this.btExport3.Style = SunnyUI.UIStyle.Custom;
            this.btExport3.Symbol = 362830;
            this.btExport3.TabIndex = 7;
            this.btExport3.Text = "导出";
            this.btExport3.Click += new System.EventHandler(this.btExport3_Click);
            // 
            // btQuery3
            // 
            this.btQuery3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btQuery3.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btQuery3.Location = new System.Drawing.Point(55, 125);
            this.btQuery3.MinimumSize = new System.Drawing.Size(1, 1);
            this.btQuery3.Name = "btQuery3";
            this.btQuery3.Size = new System.Drawing.Size(129, 35);
            this.btQuery3.Style = SunnyUI.UIStyle.Custom;
            this.btQuery3.Symbol = 559566;
            this.btQuery3.TabIndex = 6;
            this.btQuery3.Text = "查询";
            this.btQuery3.Click += new System.EventHandler(this.btQuery3_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.cbp3product);
            this.panel4.Controls.Add(this.uiMarkLabel6);
            this.panel4.Controls.Add(this.uiMarkLabel9);
            this.panel4.Controls.Add(this.dtp3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 29);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(240, 86);
            this.panel4.TabIndex = 5;
            // 
            // cbp3product
            // 
            this.cbp3product.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbp3product.FormattingEnabled = true;
            this.cbp3product.Items.AddRange(new object[] {
            "当天",
            "本周",
            "本月",
            "上月",
            "半年"});
            this.cbp3product.Location = new System.Drawing.Point(55, 43);
            this.cbp3product.Name = "cbp3product";
            this.cbp3product.Size = new System.Drawing.Size(179, 27);
            this.cbp3product.TabIndex = 8;
            // 
            // uiMarkLabel6
            // 
            this.uiMarkLabel6.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiMarkLabel6.Location = new System.Drawing.Point(3, 44);
            this.uiMarkLabel6.Name = "uiMarkLabel6";
            this.uiMarkLabel6.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.uiMarkLabel6.Size = new System.Drawing.Size(46, 23);
            this.uiMarkLabel6.Style = SunnyUI.UIStyle.Custom;
            this.uiMarkLabel6.TabIndex = 7;
            this.uiMarkLabel6.Text = "产品";
            this.uiMarkLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiMarkLabel9
            // 
            this.uiMarkLabel9.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiMarkLabel9.Location = new System.Drawing.Point(3, 12);
            this.uiMarkLabel9.Name = "uiMarkLabel9";
            this.uiMarkLabel9.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.uiMarkLabel9.Size = new System.Drawing.Size(35, 23);
            this.uiMarkLabel9.Style = SunnyUI.UIStyle.Custom;
            this.uiMarkLabel9.TabIndex = 2;
            this.uiMarkLabel9.Text = "月";
            this.uiMarkLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtp3
            // 
            this.dtp3.Location = new System.Drawing.Point(55, 11);
            this.dtp3.Name = "dtp3";
            this.dtp3.Size = new System.Drawing.Size(179, 26);
            this.dtp3.TabIndex = 1;
            this.dtp3.Value = new System.DateTime(2026, 4, 1, 0, 0, 0, 0);
            // 
            // uiLine2
            // 
            this.uiLine2.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiLine2.FillColor = System.Drawing.Color.White;
            this.uiLine2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLine2.Location = new System.Drawing.Point(0, 0);
            this.uiLine2.MinimumSize = new System.Drawing.Size(2, 2);
            this.uiLine2.Name = "uiLine2";
            this.uiLine2.Size = new System.Drawing.Size(240, 29);
            this.uiLine2.Style = SunnyUI.UIStyle.Custom;
            this.uiLine2.TabIndex = 0;
            this.uiLine2.Text = "查询所在月";
            // 
            // panel3Fill
            // 
            this.panel3Fill.Controls.Add(this.dgvMonth);
            this.panel3Fill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3Fill.Location = new System.Drawing.Point(240, 0);
            this.panel3Fill.Name = "panel3Fill";
            this.panel3Fill.Size = new System.Drawing.Size(884, 734);
            this.panel3Fill.TabIndex = 2;
            // 
            // dgvMonth
            // 
            this.dgvMonth.AllowUserToAddRows = false;
            this.dgvMonth.AllowUserToDeleteRows = false;
            this.dgvMonth.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMonth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMonth.Location = new System.Drawing.Point(0, 0);
            this.dgvMonth.Name = "dgvMonth";
            this.dgvMonth.RowTemplate.Height = 23;
            this.dgvMonth.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMonth.Size = new System.Drawing.Size(884, 734);
            this.dgvMonth.TabIndex = 3;
            // 
            // PProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1132, 777);
            this.Controls.Add(this.tabCtrl);
            this.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PProduct";
            this.Style = SunnyUI.UIStyle.Custom;
            this.Text = "PProduct";
            this.Load += new System.EventHandler(this.PProduct_Load);
            this.tabCtrl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel1Fill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvAll)).EndInit();
            this.panel1Left.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.panel2Fill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDay)).EndInit();
            this.panel2Left.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.panel3Left.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3Fill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonth)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabCtrl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ImageList imglst;
        private System.Windows.Forms.Panel panel1Fill;
        private System.Windows.Forms.Panel panel1Left;
        private System.Windows.Forms.Panel panel2Fill;
        private System.Windows.Forms.Panel panel2Left;
        private System.Windows.Forms.DataGridView dvAll;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn 日期;
        private System.Windows.Forms.DataGridViewTextBoxColumn Model;
        private System.Windows.Forms.DataGridViewTextBoxColumn SN;
        private System.Windows.Forms.DataGridViewTextBoxColumn 结果;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remark;
        private SunnyUI.UILine LineP1;
        private System.Windows.Forms.DateTimePicker dtp1from;
        private System.Windows.Forms.Panel panel1;
        private SunnyUI.UIMarkLabel uiMarkLabel1;
        private System.Windows.Forms.DateTimePicker dtp1to;
        private SunnyUI.UIMarkLabel uiMarkLabel2;
        private SunnyUI.UISymbolButton btQuery;
        private SunnyUI.UISymbolButton btExport;
        private SunnyUI.UILine uiLine1;
        private System.Windows.Forms.DataGridView dgvDay;
        private System.Windows.Forms.ComboBox cbp1select;
        private SunnyUI.UIMarkLabel uiMarkLabel3;
        private System.Windows.Forms.ComboBox cbp1product;
        private SunnyUI.UIMarkLabel uiMarkLabel4;
        private SunnyUI.UISymbolLabel lbP1QueryInfo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cbp2product;
        private SunnyUI.UIMarkLabel uiMarkLabel5;
        private SunnyUI.UIMarkLabel uiMarkLabel7;
        private SunnyUI.UISymbolButton btQuery2;
        private System.Windows.Forms.DateTimePicker dtp2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel panel3Fill;
        private System.Windows.Forms.DataGridView dgvMonth;
        private System.Windows.Forms.Panel panel3Left;
        private SunnyUI.UISymbolButton btExport3;
        private SunnyUI.UISymbolButton btQuery3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox cbp3product;
        private SunnyUI.UIMarkLabel uiMarkLabel6;
        private SunnyUI.UIMarkLabel uiMarkLabel9;
        private System.Windows.Forms.DateTimePicker dtp3;
        private SunnyUI.UILine uiLine2;
    }
}