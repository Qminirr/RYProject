namespace RY.Ctrls
{
    partial class FProjectManager
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
            this.lHeader = new SunnyUI.UILine();
            this.panelContent = new System.Windows.Forms.Panel();
            this.tlpCtrl = new System.Windows.Forms.TableLayoutPanel();
            this.lsbProjectNames = new System.Windows.Forms.ListBox();
            this.pg = new System.Windows.Forms.PropertyGrid();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btNew = new SunnyUI.UISymbolButton();
            this.btCopy = new SunnyUI.UISymbolButton();
            this.btRename = new SunnyUI.UISymbolButton();
            this.btDel = new SunnyUI.UISymbolButton();
            this.btSave = new SunnyUI.UISymbolButton();
            this.panelContent.SuspendLayout();
            this.tlpCtrl.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lHeader
            // 
            this.lHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.lHeader.FillColor = System.Drawing.Color.White;
            this.lHeader.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lHeader.LineSize = 3;
            this.lHeader.Location = new System.Drawing.Point(0, 0);
            this.lHeader.MinimumSize = new System.Drawing.Size(2, 2);
            this.lHeader.Name = "lHeader";
            this.lHeader.Size = new System.Drawing.Size(738, 26);
            this.lHeader.Style = SunnyUI.UIStyle.Custom;
            this.lHeader.TabIndex = 0;
            this.lHeader.Text = "工程管理";
            // 
            // panelContent
            // 
            this.panelContent.Controls.Add(this.tlpCtrl);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(0, 26);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(738, 415);
            this.panelContent.TabIndex = 1;
            // 
            // tlpCtrl
            // 
            this.tlpCtrl.ColumnCount = 5;
            this.tlpCtrl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpCtrl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpCtrl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tlpCtrl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpCtrl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpCtrl.Controls.Add(this.lsbProjectNames, 1, 1);
            this.tlpCtrl.Controls.Add(this.pg, 3, 1);
            this.tlpCtrl.Controls.Add(this.flowLayoutPanel1, 2, 1);
            this.tlpCtrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpCtrl.Location = new System.Drawing.Point(0, 0);
            this.tlpCtrl.Name = "tlpCtrl";
            this.tlpCtrl.RowCount = 2;
            this.tlpCtrl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpCtrl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpCtrl.Size = new System.Drawing.Size(738, 415);
            this.tlpCtrl.TabIndex = 0;
            // 
            // lsbProjectNames
            // 
            this.lsbProjectNames.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsbProjectNames.FormattingEnabled = true;
            this.lsbProjectNames.ItemHeight = 19;
            this.lsbProjectNames.Location = new System.Drawing.Point(67, 13);
            this.lsbProjectNames.Name = "lsbProjectNames";
            this.lsbProjectNames.Size = new System.Drawing.Size(188, 399);
            this.lsbProjectNames.TabIndex = 0;
            this.lsbProjectNames.SelectedIndexChanged += new System.EventHandler(this.lsbProjectNames_SelectedIndexChanged);
            // 
            // pg
            // 
            this.pg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pg.Location = new System.Drawing.Point(351, 13);
            this.pg.Name = "pg";
            this.pg.Size = new System.Drawing.Size(318, 399);
            this.pg.TabIndex = 1;
            this.pg.ToolbarVisible = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btNew);
            this.flowLayoutPanel1.Controls.Add(this.btCopy);
            this.flowLayoutPanel1.Controls.Add(this.btRename);
            this.flowLayoutPanel1.Controls.Add(this.btDel);
            this.flowLayoutPanel1.Controls.Add(this.btSave);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(261, 13);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(84, 399);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // btNew
            // 
            this.btNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btNew.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btNew.Location = new System.Drawing.Point(3, 3);
            this.btNew.MinimumSize = new System.Drawing.Size(1, 1);
            this.btNew.Name = "btNew";
            this.btNew.Size = new System.Drawing.Size(81, 35);
            this.btNew.Symbol = 557403;
            this.btNew.TabIndex = 0;
            this.btNew.Text = "新建";
            this.btNew.Click += new System.EventHandler(this.btNew_Click);
            // 
            // btCopy
            // 
            this.btCopy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCopy.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btCopy.Location = new System.Drawing.Point(3, 44);
            this.btCopy.MinimumSize = new System.Drawing.Size(1, 1);
            this.btCopy.Name = "btCopy";
            this.btCopy.Size = new System.Drawing.Size(81, 35);
            this.btCopy.Symbol = 261637;
            this.btCopy.TabIndex = 1;
            this.btCopy.Text = "复制";
            this.btCopy.Click += new System.EventHandler(this.btCopy_Click);
            // 
            // btRename
            // 
            this.btRename.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btRename.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btRename.Location = new System.Drawing.Point(3, 85);
            this.btRename.MinimumSize = new System.Drawing.Size(1, 1);
            this.btRename.Name = "btRename";
            this.btRename.Size = new System.Drawing.Size(81, 35);
            this.btRename.Symbol = 559810;
            this.btRename.TabIndex = 2;
            this.btRename.Text = "重命名";
            this.btRename.Click += new System.EventHandler(this.btRename_Click);
            // 
            // btDel
            // 
            this.btDel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btDel.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btDel.Location = new System.Drawing.Point(3, 126);
            this.btDel.MinimumSize = new System.Drawing.Size(1, 1);
            this.btDel.Name = "btDel";
            this.btDel.Size = new System.Drawing.Size(81, 35);
            this.btDel.Symbol = 559691;
            this.btDel.TabIndex = 3;
            this.btDel.Text = "删除";
            this.btDel.Click += new System.EventHandler(this.btDel_Click);
            // 
            // btSave
            // 
            this.btSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSave.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btSave.Location = new System.Drawing.Point(3, 167);
            this.btSave.MinimumSize = new System.Drawing.Size(1, 1);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(81, 35);
            this.btSave.Symbol = 557697;
            this.btSave.TabIndex = 4;
            this.btSave.Text = "保存";
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // FProjectManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(738, 441);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.lHeader);
            this.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FProjectManager";
            this.Style = SunnyUI.UIStyle.Custom;
            this.Text = "FProjectManager";
            this.panelContent.ResumeLayout(false);
            this.tlpCtrl.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private SunnyUI.UILine lHeader;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.TableLayoutPanel tlpCtrl;
        private System.Windows.Forms.ListBox lsbProjectNames;
        private System.Windows.Forms.PropertyGrid pg;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private SunnyUI.UISymbolButton btNew;
        private SunnyUI.UISymbolButton btCopy;
        private SunnyUI.UISymbolButton btRename;
        private SunnyUI.UISymbolButton btDel;
        private SunnyUI.UISymbolButton btSave;
    }
}