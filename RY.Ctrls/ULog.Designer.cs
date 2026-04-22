namespace RY.Ctrls
{
    partial class ULog
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ULog));
            this.tabInfo = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lvInfo = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lvWarn = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lvError = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ImgList = new System.Windows.Forms.ImageList(this.components);
            this.tabInfo.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabInfo
            // 
            this.tabInfo.Controls.Add(this.tabPage1);
            this.tabInfo.Controls.Add(this.tabPage2);
            this.tabInfo.Controls.Add(this.tabPage3);
            this.tabInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabInfo.ImageList = this.ImgList;
            this.tabInfo.Location = new System.Drawing.Point(0, 0);
            this.tabInfo.Name = "tabInfo";
            this.tabInfo.SelectedIndex = 0;
            this.tabInfo.Size = new System.Drawing.Size(829, 346);
            this.tabInfo.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lvInfo);
            this.tabPage1.ImageIndex = 0;
            this.tabPage1.Location = new System.Drawing.Point(4, 31);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(821, 311);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "信息";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lvInfo
            // 
            this.lvInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvInfo.FullRowSelect = true;
            this.lvInfo.HideSelection = false;
            this.lvInfo.Location = new System.Drawing.Point(3, 3);
            this.lvInfo.MultiSelect = false;
            this.lvInfo.Name = "lvInfo";
            this.lvInfo.Size = new System.Drawing.Size(815, 305);
            this.lvInfo.TabIndex = 0;
            this.lvInfo.UseCompatibleStateImageBehavior = false;
            this.lvInfo.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "时间";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "信息";
            this.columnHeader2.Width = 900;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lvWarn);
            this.tabPage2.ImageIndex = 1;
            this.tabPage2.Location = new System.Drawing.Point(4, 31);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(821, 311);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "警告";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lvWarn
            // 
            this.lvWarn.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.lvWarn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvWarn.FullRowSelect = true;
            this.lvWarn.HideSelection = false;
            this.lvWarn.Location = new System.Drawing.Point(3, 3);
            this.lvWarn.MultiSelect = false;
            this.lvWarn.Name = "lvWarn";
            this.lvWarn.Size = new System.Drawing.Size(815, 305);
            this.lvWarn.TabIndex = 1;
            this.lvWarn.UseCompatibleStateImageBehavior = false;
            this.lvWarn.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "时间";
            this.columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "信息";
            this.columnHeader4.Width = 900;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.lvError);
            this.tabPage3.ImageIndex = 2;
            this.tabPage3.Location = new System.Drawing.Point(4, 31);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(821, 311);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "报警";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // lvError
            // 
            this.lvError.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6});
            this.lvError.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvError.FullRowSelect = true;
            this.lvError.HideSelection = false;
            this.lvError.Location = new System.Drawing.Point(0, 0);
            this.lvError.MultiSelect = false;
            this.lvError.Name = "lvError";
            this.lvError.Size = new System.Drawing.Size(821, 311);
            this.lvError.TabIndex = 1;
            this.lvError.UseCompatibleStateImageBehavior = false;
            this.lvError.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "时间";
            this.columnHeader5.Width = 150;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "信息";
            this.columnHeader6.Width = 900;
            // 
            // ImgList
            // 
            this.ImgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImgList.ImageStream")));
            this.ImgList.TransparentColor = System.Drawing.Color.Transparent;
            this.ImgList.Images.SetKeyName(0, "info_24px.png");
            this.ImgList.Images.SetKeyName(1, "warning_shield_24px.png");
            this.ImgList.Images.SetKeyName(2, "error_24px.png");
            // 
            // ULog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabInfo);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ULog";
            this.Size = new System.Drawing.Size(829, 346);
            this.tabInfo.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabInfo;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ImageList ImgList;
        private System.Windows.Forms.ListView lvInfo;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ListView lvWarn;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ListView lvError;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}
