namespace RY.Ctrls
{
    partial class FProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FProduct));
            this.listbProduct = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnChoose = new SunnyUI.UISymbolButton();
            this.btnCancel = new SunnyUI.UISymbolButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listbProduct
            // 
            this.listbProduct.Dock = System.Windows.Forms.DockStyle.Left;
            this.listbProduct.FormattingEnabled = true;
            this.listbProduct.ItemHeight = 17;
            this.listbProduct.Location = new System.Drawing.Point(0, 0);
            this.listbProduct.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listbProduct.Name = "listbProduct";
            this.listbProduct.ScrollAlwaysVisible = true;
            this.listbProduct.Size = new System.Drawing.Size(253, 242);
            this.listbProduct.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnChoose);
            this.panel1.Controls.Add(this.listbProduct);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(419, 242);
            this.panel1.TabIndex = 10;
            // 
            // btnChoose
            // 
            this.btnChoose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChoose.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnChoose.Location = new System.Drawing.Point(290, 39);
            this.btnChoose.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(100, 35);
            this.btnChoose.TabIndex = 10;
            this.btnChoose.Text = "选择";
            this.btnChoose.Click += new System.EventHandler(this.CheckProduct);
            // 
            // btnCancel
            // 
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnCancel.Location = new System.Drawing.Point(290, 167);
            this.btnCancel.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 35);
            this.btnCancel.Symbol = 61453;
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "取消";
            this.btnCancel.Click += new System.EventHandler(this.Cancel);
            // 
            // FProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(419, 277);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FProduct";
            this.ShowInTaskbar = false;
            this.ShowTitleIcon = true;
            this.Style = SunnyUI.UIStyle.Custom;
            this.Text = "选择配方";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FrmProduct_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listbProduct;
        private System.Windows.Forms.Panel panel1;
        private SunnyUI.UISymbolButton btnCancel;
        private SunnyUI.UISymbolButton btnChoose;
    }
}