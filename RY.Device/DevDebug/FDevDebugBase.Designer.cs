namespace RY.Device
{
    partial class FDevDebugBase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FDevDebugBase));
            this.tlpCtrl = new System.Windows.Forms.TableLayoutPanel();
            this.panelTop = new System.Windows.Forms.Panel();
            this.panelCtrl = new System.Windows.Forms.Panel();
            this.btOpenDev = new SunnyUI.UISymbolButton();
            this.btCloseDev = new SunnyUI.UISymbolButton();
            this.lbInfo = new SunnyUI.UISymbolLabel();
            this.tlpCtrl.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpCtrl
            // 
            this.tlpCtrl.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tlpCtrl.ColumnCount = 1;
            this.tlpCtrl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpCtrl.Controls.Add(this.panelTop, 0, 0);
            this.tlpCtrl.Controls.Add(this.panelCtrl, 0, 1);
            this.tlpCtrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpCtrl.Location = new System.Drawing.Point(0, 35);
            this.tlpCtrl.Name = "tlpCtrl";
            this.tlpCtrl.RowCount = 2;
            this.tlpCtrl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tlpCtrl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpCtrl.Size = new System.Drawing.Size(735, 579);
            this.tlpCtrl.TabIndex = 0;
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.lbInfo);
            this.panelTop.Controls.Add(this.btCloseDev);
            this.panelTop.Controls.Add(this.btOpenDev);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTop.Location = new System.Drawing.Point(4, 4);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(727, 39);
            this.panelTop.TabIndex = 0;
            // 
            // panelCtrl
            // 
            this.panelCtrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCtrl.Location = new System.Drawing.Point(4, 50);
            this.panelCtrl.Name = "panelCtrl";
            this.panelCtrl.Size = new System.Drawing.Size(727, 525);
            this.panelCtrl.TabIndex = 1;
            // 
            // btOpenDev
            // 
            this.btOpenDev.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btOpenDev.Dock = System.Windows.Forms.DockStyle.Left;
            this.btOpenDev.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btOpenDev.Location = new System.Drawing.Point(0, 0);
            this.btOpenDev.MinimumSize = new System.Drawing.Size(1, 1);
            this.btOpenDev.Name = "btOpenDev";
            this.btOpenDev.Size = new System.Drawing.Size(100, 39);
            this.btOpenDev.Symbol = 362401;
            this.btOpenDev.TabIndex = 0;
            this.btOpenDev.Text = "打开设备";
            this.btOpenDev.Click += new System.EventHandler(this.btOpenDev_Click);
            // 
            // btCloseDev
            // 
            this.btCloseDev.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCloseDev.Dock = System.Windows.Forms.DockStyle.Left;
            this.btCloseDev.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btCloseDev.Location = new System.Drawing.Point(100, 0);
            this.btCloseDev.MinimumSize = new System.Drawing.Size(1, 1);
            this.btCloseDev.Name = "btCloseDev";
            this.btCloseDev.Size = new System.Drawing.Size(100, 39);
            this.btCloseDev.Symbol = 61475;
            this.btCloseDev.TabIndex = 1;
            this.btCloseDev.Text = "关闭设备";
            this.btCloseDev.Click += new System.EventHandler(this.btCloseDev_Click);
            // 
            // lbInfo
            // 
            this.lbInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbInfo.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbInfo.Location = new System.Drawing.Point(200, 0);
            this.lbInfo.MinimumSize = new System.Drawing.Size(1, 1);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.lbInfo.Size = new System.Drawing.Size(527, 39);
            this.lbInfo.Symbol = 61738;
            this.lbInfo.TabIndex = 2;
            this.lbInfo.Text = "当前设备：";
            // 
            // FDevDebugBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(735, 614);
            this.Controls.Add(this.tlpCtrl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FDevDebugBase";
            this.ShowTitleIcon = true;
            this.Style = SunnyUI.UIStyle.Custom;
            this.Text = "设备调试";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FDevDebugBase_FormClosing);
            this.tlpCtrl.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpCtrl;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelCtrl;
        private SunnyUI.UISymbolButton btOpenDev;
        private SunnyUI.UISymbolButton btCloseDev;
        private SunnyUI.UISymbolLabel lbInfo;
    }
}