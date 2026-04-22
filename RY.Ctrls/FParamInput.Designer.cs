namespace RY.Ctrls
{
    partial class FParamInput
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
            this.tbParam = new SunnyUI.UITextBox();
            this.btConfirm = new SunnyUI.UISymbolButton();
            this.btCancel = new SunnyUI.UISymbolButton();
            this.lbRemark = new SunnyUI.UISymbolLabel();
            this.lbParamInfo = new SunnyUI.UISymbolLabel();
            this.SuspendLayout();
            // 
            // tbParam
            // 
            this.tbParam.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbParam.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbParam.FillColor = System.Drawing.Color.White;
            this.tbParam.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbParam.Location = new System.Drawing.Point(5, 131);
            this.tbParam.Margin = new System.Windows.Forms.Padding(10);
            this.tbParam.Maximum = 2147483647D;
            this.tbParam.Minimum = -2147483648D;
            this.tbParam.MinimumSize = new System.Drawing.Size(1, 1);
            this.tbParam.Name = "tbParam";
            this.tbParam.Size = new System.Drawing.Size(551, 47);
            this.tbParam.Style = SunnyUI.UIStyle.Custom;
            this.tbParam.TabIndex = 1;
            this.tbParam.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.tbParam.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbParam_KeyDown);
            // 
            // btConfirm
            // 
            this.btConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btConfirm.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btConfirm.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btConfirm.Location = new System.Drawing.Point(118, 271);
            this.btConfirm.MinimumSize = new System.Drawing.Size(1, 1);
            this.btConfirm.Name = "btConfirm";
            this.btConfirm.Size = new System.Drawing.Size(100, 35);
            this.btConfirm.Style = SunnyUI.UIStyle.Custom;
            this.btConfirm.TabIndex = 3;
            this.btConfirm.Text = "确认";
            this.btConfirm.Click += new System.EventHandler(this.btConfirm_Click);
            // 
            // btCancel
            // 
            this.btCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancel.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btCancel.Location = new System.Drawing.Point(339, 271);
            this.btCancel.MinimumSize = new System.Drawing.Size(1, 1);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(100, 35);
            this.btCancel.Style = SunnyUI.UIStyle.Custom;
            this.btCancel.Symbol = 61453;
            this.btCancel.TabIndex = 4;
            this.btCancel.Text = "取消";
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // lbRemark
            // 
            this.lbRemark.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbRemark.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.lbRemark.Location = new System.Drawing.Point(5, 178);
            this.lbRemark.MinimumSize = new System.Drawing.Size(1, 1);
            this.lbRemark.Name = "lbRemark";
            this.lbRemark.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.lbRemark.Size = new System.Drawing.Size(551, 72);
            this.lbRemark.Style = SunnyUI.UIStyle.Custom;
            this.lbRemark.TabIndex = 5;
            this.lbRemark.Text = "说明：";
            this.lbRemark.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbParamInfo
            // 
            this.lbParamInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbParamInfo.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbParamInfo.Location = new System.Drawing.Point(5, 37);
            this.lbParamInfo.MinimumSize = new System.Drawing.Size(1, 1);
            this.lbParamInfo.Name = "lbParamInfo";
            this.lbParamInfo.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.lbParamInfo.Size = new System.Drawing.Size(551, 94);
            this.lbParamInfo.Style = SunnyUI.UIStyle.Custom;
            this.lbParamInfo.Symbol = 559536;
            this.lbParamInfo.TabIndex = 6;
            this.lbParamInfo.Text = "参数输入说明";
            this.lbParamInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FParamInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 342);
            this.ControlBox = false;
            this.Controls.Add(this.lbRemark);
            this.Controls.Add(this.tbParam);
            this.Controls.Add(this.lbParamInfo);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btConfirm);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FParamInput";
            this.Padding = new System.Windows.Forms.Padding(5, 37, 5, 0);
            this.RectColor = System.Drawing.SystemColors.ActiveCaption;
            this.Style = SunnyUI.UIStyle.Custom;
            this.Text = "请输入执行参数";
            this.TitleColor = System.Drawing.SystemColors.ActiveCaption;
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion
        private SunnyUI.UITextBox tbParam;
        private SunnyUI.UISymbolButton btConfirm;
        private SunnyUI.UISymbolButton btCancel;
        private SunnyUI.UISymbolLabel lbRemark;
        private SunnyUI.UISymbolLabel lbParamInfo;
    }
}