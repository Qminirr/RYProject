namespace RYProject
{
    partial class Form1
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btFunc = new SunnyUI.UIButton();
            this.btGenExp = new SunnyUI.UISymbolButton();
            this.btSea = new SunnyUI.UIButton();
            this.btDeSea = new SunnyUI.UIButton();
            this.btSave = new SunnyUI.UISymbolButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btFunc
            // 
            this.btFunc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btFunc.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btFunc.Location = new System.Drawing.Point(239, 62);
            this.btFunc.MinimumSize = new System.Drawing.Size(1, 1);
            this.btFunc.Name = "btFunc";
            this.btFunc.Size = new System.Drawing.Size(150, 42);
            this.btFunc.TabIndex = 0;
            this.btFunc.Text = "调用反射";
            this.btFunc.Click += new System.EventHandler(this.btFunc_Click);
            // 
            // btGenExp
            // 
            this.btGenExp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btGenExp.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btGenExp.Location = new System.Drawing.Point(42, 62);
            this.btGenExp.MinimumSize = new System.Drawing.Size(1, 1);
            this.btGenExp.Name = "btGenExp";
            this.btGenExp.Size = new System.Drawing.Size(143, 67);
            this.btGenExp.Symbol = 557697;
            this.btGenExp.TabIndex = 1;
            this.btGenExp.Text = "产生异常";
            this.btGenExp.Click += new System.EventHandler(this.btGenExp_Click);
            // 
            // btSea
            // 
            this.btSea.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSea.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btSea.Location = new System.Drawing.Point(42, 167);
            this.btSea.MinimumSize = new System.Drawing.Size(1, 1);
            this.btSea.Name = "btSea";
            this.btSea.Size = new System.Drawing.Size(100, 35);
            this.btSea.TabIndex = 2;
            this.btSea.Text = "序列化";
            this.btSea.Click += new System.EventHandler(this.btSea_Click);
            // 
            // btDeSea
            // 
            this.btDeSea.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btDeSea.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btDeSea.Location = new System.Drawing.Point(42, 223);
            this.btDeSea.MinimumSize = new System.Drawing.Size(1, 1);
            this.btDeSea.Name = "btDeSea";
            this.btDeSea.Size = new System.Drawing.Size(100, 35);
            this.btDeSea.TabIndex = 3;
            this.btDeSea.Text = "反序列化";
            this.btDeSea.Click += new System.EventHandler(this.btDeSea_Click);
            // 
            // btSave
            // 
            this.btSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSave.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btSave.Location = new System.Drawing.Point(716, 62);
            this.btSave.MinimumSize = new System.Drawing.Size(1, 1);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(136, 35);
            this.btSave.Symbol = 61639;
            this.btSave.TabIndex = 5;
            this.btSave.Text = "保存";
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(288, 150);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(594, 417);
            this.panel1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 570);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.btDeSea);
            this.Controls.Add(this.btSea);
            this.Controls.Add(this.btGenExp);
            this.Controls.Add(this.btFunc);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private SunnyUI.UIButton btFunc;
        private SunnyUI.UISymbolButton btGenExp;
        private SunnyUI.UIButton btSea;
        private SunnyUI.UIButton btDeSea;
        private SunnyUI.UISymbolButton btSave;
        private System.Windows.Forms.Panel panel1;
    }
}

