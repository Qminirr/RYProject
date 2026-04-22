namespace RY.Ctrls
{
    partial class FLog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FLog));
            this.uLog1 = new RY.Ctrls.ULog();
            this.SuspendLayout();
            // 
            // uLog1
            // 
            this.uLog1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uLog1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uLog1.Location = new System.Drawing.Point(0, 35);
            this.uLog1.Margin = new System.Windows.Forms.Padding(4);
            this.uLog1.Name = "uLog1";
            this.uLog1.Size = new System.Drawing.Size(726, 296);
            this.uLog1.TabIndex = 0;
            // 
            // FLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 331);
            this.Controls.Add(this.uLog1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FLog";
            this.ShowIcon = true;
            this.ShowInTaskbar = false;
            this.ShowTitleIcon = true;
            this.Text = "日志";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FLog_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private ULog uLog1;
    }
}