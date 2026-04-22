namespace RY.Device
{
    partial class FAxisContainer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FAxisContainer));
            this.tcAllAxis = new SunnyUI.UITabControl();
            this.SuspendLayout();
            // 
            // tcAllAxis
            // 
            this.tcAllAxis.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tcAllAxis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcAllAxis.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tcAllAxis.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tcAllAxis.ItemSize = new System.Drawing.Size(80, 30);
            this.tcAllAxis.Location = new System.Drawing.Point(0, 35);
            this.tcAllAxis.MainPage = "";
            this.tcAllAxis.MenuStyle = SunnyUI.UIMenuStyle.Custom;
            this.tcAllAxis.Name = "tcAllAxis";
            this.tcAllAxis.SelectedIndex = 0;
            this.tcAllAxis.Size = new System.Drawing.Size(535, 271);
            this.tcAllAxis.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tcAllAxis.StyleCustomMode = true;
            this.tcAllAxis.TabBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.tcAllAxis.TabIndex = 0;
            this.tcAllAxis.TabSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.tcAllAxis.TabUnSelectedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            // 
            // FAxisContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 306);
            this.Controls.Add(this.tcAllAxis);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FAxisContainer";
            this.ShowInTaskbar = false;
            this.ShowTitleIcon = true;
            this.Text = "轴控制";
            this.TopMost = true;
            this.Activated += new System.EventHandler(this.FAxisContainer_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FAxisContainer_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private SunnyUI.UITabControl tcAllAxis;
    }
}