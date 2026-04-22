namespace RY.Device
{
    partial class PDeviceCtrl
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
            this.uiCaption = new SunnyUI.UILine();
            this.tlpctrl = new System.Windows.Forms.TableLayoutPanel();
            this.panelCtrl = new System.Windows.Forms.Panel();
            this.uDevicesCtrl1 = new RY.Device.UDevicesCtrl();
            this.tlpctrl.SuspendLayout();
            this.panelCtrl.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiCaption
            // 
            this.uiCaption.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiCaption.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiCaption.LineSize = 3;
            this.uiCaption.Location = new System.Drawing.Point(0, 0);
            this.uiCaption.MinimumSize = new System.Drawing.Size(2, 2);
            this.uiCaption.Name = "uiCaption";
            this.uiCaption.Size = new System.Drawing.Size(800, 24);
            this.uiCaption.TabIndex = 2;
            this.uiCaption.Text = "设备管理";
            // 
            // tlpctrl
            // 
            this.tlpctrl.ColumnCount = 3;
            this.tlpctrl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpctrl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 700F));
            this.tlpctrl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpctrl.Controls.Add(this.panelCtrl, 1, 0);
            this.tlpctrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpctrl.Location = new System.Drawing.Point(0, 24);
            this.tlpctrl.Name = "tlpctrl";
            this.tlpctrl.RowCount = 2;
            this.tlpctrl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tlpctrl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpctrl.Size = new System.Drawing.Size(800, 426);
            this.tlpctrl.TabIndex = 3;
            // 
            // panelCtrl
            // 
            this.panelCtrl.Controls.Add(this.uDevicesCtrl1);
            this.panelCtrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCtrl.Location = new System.Drawing.Point(53, 3);
            this.panelCtrl.Name = "panelCtrl";
            this.panelCtrl.Size = new System.Drawing.Size(694, 377);
            this.panelCtrl.TabIndex = 0;
            // 
            // uDevicesCtrl1
            // 
            this.uDevicesCtrl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uDevicesCtrl1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uDevicesCtrl1.Location = new System.Drawing.Point(0, 0);
            this.uDevicesCtrl1.Margin = new System.Windows.Forms.Padding(4);
            this.uDevicesCtrl1.Name = "uDevicesCtrl1";
            this.uDevicesCtrl1.Size = new System.Drawing.Size(694, 377);
            this.uDevicesCtrl1.TabIndex = 0;
            // 
            // PDeviceCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tlpctrl);
            this.Controls.Add(this.uiCaption);
            this.Name = "PDeviceCtrl";
            this.Symbol = 558165;
            this.Text = "PDeviceCtrl";
            this.tlpctrl.ResumeLayout(false);
            this.panelCtrl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private SunnyUI.UILine uiCaption;
        private System.Windows.Forms.TableLayoutPanel tlpctrl;
        private System.Windows.Forms.Panel panelCtrl;
        private UDevicesCtrl uDevicesCtrl1;
    }
}