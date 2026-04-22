namespace RY.Ctrls
{
    partial class FWelcome
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
            this.bar_step = new System.Windows.Forms.ProgressBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_version = new System.Windows.Forms.Label();
            this.btn_exit = new System.Windows.Forms.Button();
            this.lbl_step = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bar_step
            // 
            this.bar_step.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bar_step.ForeColor = System.Drawing.Color.Green;
            this.bar_step.Location = new System.Drawing.Point(0, 0);
            this.bar_step.Margin = new System.Windows.Forms.Padding(2);
            this.bar_step.Name = "bar_step";
            this.bar_step.Size = new System.Drawing.Size(628, 15);
            this.bar_step.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bar_step);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 481);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(628, 15);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::RY.Ctrls.Properties.Resources.RY;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.lbl_version);
            this.panel2.Controls.Add(this.btn_exit);
            this.panel2.Controls.Add(this.lbl_step);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(628, 481);
            this.panel2.TabIndex = 7;
            // 
            // lbl_version
            // 
            this.lbl_version.AutoSize = true;
            this.lbl_version.BackColor = System.Drawing.Color.Transparent;
            this.lbl_version.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_version.ForeColor = System.Drawing.Color.DimGray;
            this.lbl_version.Location = new System.Drawing.Point(11, 9);
            this.lbl_version.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_version.Name = "lbl_version";
            this.lbl_version.Size = new System.Drawing.Size(71, 22);
            this.lbl_version.TabIndex = 8;
            this.lbl_version.Text = "Version";
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.White;
            this.btn_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_exit.FlatAppearance.BorderSize = 0;
            this.btn_exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Font = new System.Drawing.Font("新宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_exit.ForeColor = System.Drawing.Color.Black;
            this.btn_exit.Location = new System.Drawing.Point(604, 2);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(2);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btn_exit.Size = new System.Drawing.Size(22, 22);
            this.btn_exit.TabIndex = 11;
            this.btn_exit.TabStop = false;
            this.btn_exit.Text = "×";
            this.btn_exit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // lbl_step
            // 
            this.lbl_step.BackColor = System.Drawing.Color.Transparent;
            this.lbl_step.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_step.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_step.ForeColor = System.Drawing.Color.Blue;
            this.lbl_step.Location = new System.Drawing.Point(0, 457);
            this.lbl_step.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_step.Name = "lbl_step";
            this.lbl_step.Size = new System.Drawing.Size(628, 24);
            this.lbl_step.TabIndex = 3;
            this.lbl_step.Text = "正在初始化......";
            // 
            // FWelcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 496);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FWelcome";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "欢迎";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmWelcome_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.setForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.setForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.setForm_MouseUp);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ProgressBar bar_step;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Label lbl_step;
        private System.Windows.Forms.Button btn_exit;
        internal System.Windows.Forms.Label lbl_version;
    }
}