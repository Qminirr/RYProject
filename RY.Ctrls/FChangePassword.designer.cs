namespace RY.Ctrls
{
    partial class FChangePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FChangePassword));
            this.lbText = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.combUser = new System.Windows.Forms.ComboBox();
            this.tbNewPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNewPassword2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnConfirm = new SunnyUI.UISymbolButton();
            this.btnCancel = new SunnyUI.UISymbolButton();
            this.SuspendLayout();
            // 
            // lbText
            // 
            this.lbText.Font = new System.Drawing.Font("微软雅黑", 8F);
            this.lbText.ForeColor = System.Drawing.Color.Red;
            this.lbText.Location = new System.Drawing.Point(32, 192);
            this.lbText.Name = "lbText";
            this.lbText.Size = new System.Drawing.Size(224, 24);
            this.lbText.TabIndex = 15;
            this.lbText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(105, 80);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(121, 23);
            this.tbPassword.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "当前用户密码 ：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "改密用户 ：";
            // 
            // combUser
            // 
            this.combUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combUser.FormattingEnabled = true;
            this.combUser.Location = new System.Drawing.Point(105, 46);
            this.combUser.Name = "combUser";
            this.combUser.Size = new System.Drawing.Size(121, 25);
            this.combUser.TabIndex = 11;
            // 
            // tbNewPassword
            // 
            this.tbNewPassword.Location = new System.Drawing.Point(105, 120);
            this.tbNewPassword.Name = "tbNewPassword";
            this.tbNewPassword.PasswordChar = '*';
            this.tbNewPassword.Size = new System.Drawing.Size(121, 23);
            this.tbNewPassword.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "新密码 ：";
            // 
            // tbNewPassword2
            // 
            this.tbNewPassword2.Location = new System.Drawing.Point(105, 156);
            this.tbNewPassword2.Name = "tbNewPassword2";
            this.tbNewPassword2.PasswordChar = '*';
            this.tbNewPassword2.Size = new System.Drawing.Size(121, 23);
            this.tbNewPassword2.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "再次输入密码 ：";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirm.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnConfirm.Location = new System.Drawing.Point(22, 228);
            this.btnConfirm.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(100, 35);
            this.btnConfirm.TabIndex = 20;
            this.btnConfirm.Text = "确认";
            this.btnConfirm.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnCancel.Location = new System.Drawing.Point(156, 228);
            this.btnCancel.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 35);
            this.btnCancel.Symbol = 61453;
            this.btnCancel.TabIndex = 21;
            this.btnCancel.Text = "取消";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FrmChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 279);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.tbNewPassword2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbNewPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbText);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.combUser);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmChangePassword";
            this.ShowIcon = true;
            this.ShowInTaskbar = false;
            this.ShowTitleIcon = true;
            this.Text = "更改密码";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FrmChangePassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbText;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox combUser;
        private System.Windows.Forms.TextBox tbNewPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNewPassword2;
        private System.Windows.Forms.Label label4;
        private SunnyUI.UISymbolButton btnConfirm;
        private SunnyUI.UISymbolButton btnCancel;
    }
}