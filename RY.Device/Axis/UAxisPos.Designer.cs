namespace RY.Device
{
    partial class UAxisPos
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lbName = new SunnyUI.UIMarkLabel();
            this.lbVal = new SunnyUI.UIMarkLabel();
            this.btnRead = new SunnyUI.UISymbolButton();
            this.btnMove = new SunnyUI.UISymbolButton();
            this.SuspendLayout();
            // 
            // lbName
            // 
            this.lbName.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbName.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbName.Location = new System.Drawing.Point(0, 0);
            this.lbName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbName.Name = "lbName";
            this.lbName.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.lbName.Size = new System.Drawing.Size(104, 25);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "轴名";
            this.lbName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbVal
            // 
            this.lbVal.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbVal.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbVal.Location = new System.Drawing.Point(104, 0);
            this.lbVal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbVal.MarkPos = SunnyUI.UIMarkLabel.UIMarkPos.Bottom;
            this.lbVal.Name = "lbVal";
            this.lbVal.Padding = new System.Windows.Forms.Padding(0, 0, 0, 7);
            this.lbVal.Size = new System.Drawing.Size(77, 25);
            this.lbVal.TabIndex = 1;
            this.lbVal.Text = "0000.000";
            this.lbVal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbVal.DoubleClick += new System.EventHandler(this.lbPos_DoubleClick);
            // 
            // btnRead
            // 
            this.btnRead.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRead.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnRead.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnRead.Location = new System.Drawing.Point(181, 0);
            this.btnRead.Margin = new System.Windows.Forms.Padding(4);
            this.btnRead.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(60, 25);
            this.btnRead.Symbol = 161878;
            this.btnRead.TabIndex = 3;
            this.btnRead.Text = "读取";
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnMove
            // 
            this.btnMove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMove.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMove.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnMove.Location = new System.Drawing.Point(240, 0);
            this.btnMove.Margin = new System.Windows.Forms.Padding(4);
            this.btnMove.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(60, 25);
            this.btnMove.Symbol = 161878;
            this.btnMove.TabIndex = 2;
            this.btnMove.Text = "移动";
            this.btnMove.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // UAxisPos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.btnMove);
            this.Controls.Add(this.lbVal);
            this.Controls.Add(this.lbName);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(300, 25);
            this.MinimumSize = new System.Drawing.Size(300, 25);
            this.Name = "UAxisPos";
            this.Size = new System.Drawing.Size(300, 25);
            this.ResumeLayout(false);

        }

        #endregion

        private SunnyUI.UIMarkLabel lbName;
        private SunnyUI.UIMarkLabel lbVal;
        private SunnyUI.UISymbolButton btnRead;
        private SunnyUI.UISymbolButton btnMove;
    }
}
