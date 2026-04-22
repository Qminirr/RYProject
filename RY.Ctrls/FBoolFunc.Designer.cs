namespace RY.Ctrls
{
    partial class FBoolFunc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FBoolFunc));
            this.tabCtrl = new SunnyUI.UITabControl();
            this.SuspendLayout();
            // 
            // tabCtrl
            // 
            this.tabCtrl.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabCtrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabCtrl.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabCtrl.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabCtrl.ItemSize = new System.Drawing.Size(150, 40);
            this.tabCtrl.Location = new System.Drawing.Point(0, 35);
            this.tabCtrl.MainPage = "";
            this.tabCtrl.MenuStyle = SunnyUI.UIMenuStyle.Custom;
            this.tabCtrl.Name = "tabCtrl";
            this.tabCtrl.SelectedIndex = 0;
            this.tabCtrl.Size = new System.Drawing.Size(454, 415);
            this.tabCtrl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabCtrl.TabBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.tabCtrl.TabIndex = 0;
            this.tabCtrl.TabSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.tabCtrl.TabUnSelectedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            // 
            // FBoolFunc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 450);
            this.Controls.Add(this.tabCtrl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FBoolFunc";
            this.ShowIcon = true;
            this.ShowInTaskbar = false;
            this.ShowTitleIcon = true;
            this.Text = "通用功能";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FBoolFunc_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private SunnyUI.UITabControl tabCtrl;
    }
}