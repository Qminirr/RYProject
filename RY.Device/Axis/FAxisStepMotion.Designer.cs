namespace RY.Device
{
    partial class FAxisStepMotion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FAxisStepMotion));
            this.uiMarkLabel1 = new SunnyUI.UIMarkLabel();
            this.lbCurAxis = new SunnyUI.UIMarkLabel();
            this.lbMsg = new SunnyUI.UIMarkLabel();
            this.mlbMoveSpan = new SunnyUI.UIMarkLabel();
            this.lbCurSpan = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // uiMarkLabel1
            // 
            this.uiMarkLabel1.Font = new System.Drawing.Font("微软雅黑", 7.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiMarkLabel1.ForeColor = System.Drawing.Color.Blue;
            this.uiMarkLabel1.Location = new System.Drawing.Point(2, 38);
            this.uiMarkLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uiMarkLabel1.MarkPos = SunnyUI.UIMarkLabel.UIMarkPos.Top;
            this.uiMarkLabel1.Name = "uiMarkLabel1";
            this.uiMarkLabel1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.uiMarkLabel1.Size = new System.Drawing.Size(331, 105);
            this.uiMarkLabel1.Style = SunnyUI.UIStyle.Custom;
            this.uiMarkLabel1.StyleCustomMode = true;
            this.uiMarkLabel1.TabIndex = 1;
            this.uiMarkLabel1.Text = "左方向键位置-，右方向键位置+";
            this.uiMarkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbCurAxis
            // 
            this.lbCurAxis.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbCurAxis.Location = new System.Drawing.Point(1, 143);
            this.lbCurAxis.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCurAxis.MarkPos = SunnyUI.UIMarkLabel.UIMarkPos.Top;
            this.lbCurAxis.Name = "lbCurAxis";
            this.lbCurAxis.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lbCurAxis.Size = new System.Drawing.Size(331, 74);
            this.lbCurAxis.Style = SunnyUI.UIStyle.Custom;
            this.lbCurAxis.TabIndex = 2;
            this.lbCurAxis.Text = "0.000";
            this.lbCurAxis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbMsg
            // 
            this.lbMsg.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbMsg.Location = new System.Drawing.Point(1, 288);
            this.lbMsg.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMsg.MarkPos = SunnyUI.UIMarkLabel.UIMarkPos.Bottom;
            this.lbMsg.Name = "lbMsg";
            this.lbMsg.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lbMsg.Size = new System.Drawing.Size(331, 61);
            this.lbMsg.Style = SunnyUI.UIStyle.Custom;
            this.lbMsg.TabIndex = 6;
            this.lbMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mlbMoveSpan
            // 
            this.mlbMoveSpan.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.mlbMoveSpan.ForeColor = System.Drawing.Color.Blue;
            this.mlbMoveSpan.Location = new System.Drawing.Point(4, 226);
            this.mlbMoveSpan.Name = "mlbMoveSpan";
            this.mlbMoveSpan.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.mlbMoveSpan.Size = new System.Drawing.Size(329, 23);
            this.mlbMoveSpan.Style = SunnyUI.UIStyle.Custom;
            this.mlbMoveSpan.StyleCustomMode = true;
            this.mlbMoveSpan.TabIndex = 7;
            this.mlbMoveSpan.Text = "双击此处选择移动量";
            this.mlbMoveSpan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mlbMoveSpan.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbSpan_MouseDoubleClick);
            // 
            // lbCurSpan
            // 
            this.lbCurSpan.Location = new System.Drawing.Point(6, 262);
            this.lbCurSpan.Name = "lbCurSpan";
            this.lbCurSpan.Size = new System.Drawing.Size(326, 19);
            this.lbCurSpan.TabIndex = 8;
            this.lbCurSpan.Text = "当前移动量：0.3";
            this.lbCurSpan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FAxisStepMotion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 358);
            this.Controls.Add(this.lbCurSpan);
            this.Controls.Add(this.mlbMoveSpan);
            this.Controls.Add(this.lbMsg);
            this.Controls.Add(this.lbCurAxis);
            this.Controls.Add(this.uiMarkLabel1);
            this.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FAxisStepMotion";
            this.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ShowInTaskbar = false;
            this.ShowTitleIcon = true;
            this.Style = SunnyUI.UIStyle.Custom;
            this.Text = "轴单步移动";
            this.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.TopMost = true;
            this.Activated += new System.EventHandler(this.FAxisStepMotion_Activated);
            this.Deactivate += new System.EventHandler(this.FAxisStepMotion_Deactivate);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FAxisStepMotion_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private SunnyUI.UIMarkLabel uiMarkLabel1;
        private SunnyUI.UIMarkLabel lbCurAxis;
        private SunnyUI.UIMarkLabel lbMsg;
        private SunnyUI.UIMarkLabel mlbMoveSpan;
        private System.Windows.Forms.Label lbCurSpan;
    }
}