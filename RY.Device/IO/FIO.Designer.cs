namespace RY.Device
{
    partial class FIO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FIO));
            this.tabCtrl = new System.Windows.Forms.TabControl();
            this.SuspendLayout();
            // 
            // tabCtrl
            // 
            this.tabCtrl.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabCtrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabCtrl.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabCtrl.Location = new System.Drawing.Point(0, 32);
            this.tabCtrl.Name = "tabCtrl";
            this.tabCtrl.SelectedIndex = 0;
            this.tabCtrl.Size = new System.Drawing.Size(609, 428);
            this.tabCtrl.TabIndex = 0;
            // 
            // FIO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(609, 460);
            this.Controls.Add(this.tabCtrl);
            this.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FIO";
            this.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.ShowInTaskbar = false;
            this.ShowTitleIcon = true;
            this.Style = SunnyUI.UIStyle.Custom;
            this.Text = "设备IO";
            this.TopMost = true;
            this.Activated += new System.EventHandler(this.FIO_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FIO_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabCtrl;
    }
}