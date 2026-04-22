namespace RYProject
{
    partial class FDebug
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
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.navMenu = new SunnyUI.UINavMenu();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pnlMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.Controls.Add(this.navMenu);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(270, 450);
            this.pnlMenu.TabIndex = 0;
            // 
            // navMenu
            // 
            this.navMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.navMenu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.navMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navMenu.DrawMode = System.Windows.Forms.TreeViewDrawMode.OwnerDrawAll;
            this.navMenu.ExpandSelectFirst = true;
            this.navMenu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.navMenu.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.navMenu.ForeColor = System.Drawing.Color.Black;
            this.navMenu.FullRowSelect = true;
            this.navMenu.HoverColor = System.Drawing.Color.DarkGray;
            this.navMenu.ItemHeight = 50;
            this.navMenu.Location = new System.Drawing.Point(0, 0);
            this.navMenu.MenuStyle = SunnyUI.UIMenuStyle.Custom;
            this.navMenu.Name = "navMenu";
            this.navMenu.SecondBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.navMenu.SelectedColor = System.Drawing.Color.Silver;
            this.navMenu.ShowLines = false;
            this.navMenu.Size = new System.Drawing.Size(270, 450);
            this.navMenu.Style = SunnyUI.UIStyle.Custom;
            this.navMenu.TabIndex = 0;
            this.navMenu.MenuItemClick += new SunnyUI.UINavMenu.OnMenuItemClick(this.navMenu_MenuItemClick);
            // 
            // pnlContent
            // 
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(270, 0);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(530, 450);
            this.pnlContent.TabIndex = 1;
            // 
            // FDebug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlMenu);
            this.Name = "FDebug";
            this.Text = "FDebug";
            this.Load += new System.EventHandler(this.FDebug_Load);
            this.pnlMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlContent;
        private SunnyUI.UINavMenu navMenu;
    }
}