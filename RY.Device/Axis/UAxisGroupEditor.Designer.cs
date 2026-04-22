namespace RY.Device
{
    partial class UAxisGroupEditor
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
            this.tabCtrl = new SunnyUI.UITabControl();
            this.tpGen = new System.Windows.Forms.TabPage();
            this.panelCtrl = new System.Windows.Forms.Panel();
            this.tpSet = new System.Windows.Forms.TabPage();
            this.panelLst = new System.Windows.Forms.Panel();
            this.rbZLast = new SunnyUI.UIRadioButton();
            this.rbZFirst = new SunnyUI.UIRadioButton();
            this.rbMoveSameTime = new SunnyUI.UIRadioButton();
            this.btnDel = new SunnyUI.UISymbolButton();
            this.lsbCur = new SunnyUI.UIListBox();
            this.panelAdd = new System.Windows.Forms.Panel();
            this.btnAdd = new SunnyUI.UISymbolButton();
            this.cbAxis = new SunnyUI.UIComboBox();
            this.uiLine1 = new SunnyUI.UILine();
            this.tabCtrl.SuspendLayout();
            this.tpGen.SuspendLayout();
            this.tpSet.SuspendLayout();
            this.panelLst.SuspendLayout();
            this.panelAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabCtrl
            // 
            this.tabCtrl.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabCtrl.Controls.Add(this.tpGen);
            this.tabCtrl.Controls.Add(this.tpSet);
            this.tabCtrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabCtrl.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabCtrl.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabCtrl.ItemSize = new System.Drawing.Size(70, 30);
            this.tabCtrl.Location = new System.Drawing.Point(0, 0);
            this.tabCtrl.MainPage = "";
            this.tabCtrl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabCtrl.Name = "tabCtrl";
            this.tabCtrl.SelectedIndex = 0;
            this.tabCtrl.Size = new System.Drawing.Size(310, 278);
            this.tabCtrl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabCtrl.TabIndex = 0;
            this.tabCtrl.SelectedIndexChanged += new System.EventHandler(this.tabCtrl_SelectedIndexChanged);
            // 
            // tpGen
            // 
            this.tpGen.Controls.Add(this.panelCtrl);
            this.tpGen.Location = new System.Drawing.Point(0, 0);
            this.tpGen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tpGen.Name = "tpGen";
            this.tpGen.Size = new System.Drawing.Size(310, 248);
            this.tpGen.TabIndex = 0;
            this.tpGen.Text = "控制";
            this.tpGen.UseVisualStyleBackColor = true;
            // 
            // panelCtrl
            // 
            this.panelCtrl.AutoScroll = true;
            this.panelCtrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCtrl.Location = new System.Drawing.Point(0, 0);
            this.panelCtrl.Name = "panelCtrl";
            this.panelCtrl.Size = new System.Drawing.Size(310, 248);
            this.panelCtrl.TabIndex = 0;
            // 
            // tpSet
            // 
            this.tpSet.Controls.Add(this.panelLst);
            this.tpSet.Controls.Add(this.panelAdd);
            this.tpSet.Controls.Add(this.uiLine1);
            this.tpSet.Location = new System.Drawing.Point(0, 0);
            this.tpSet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tpSet.Name = "tpSet";
            this.tpSet.Size = new System.Drawing.Size(310, 248);
            this.tpSet.TabIndex = 1;
            this.tpSet.Text = "设置";
            this.tpSet.UseVisualStyleBackColor = true;
            // 
            // panelLst
            // 
            this.panelLst.Controls.Add(this.rbZLast);
            this.panelLst.Controls.Add(this.rbZFirst);
            this.panelLst.Controls.Add(this.rbMoveSameTime);
            this.panelLst.Controls.Add(this.btnDel);
            this.panelLst.Controls.Add(this.lsbCur);
            this.panelLst.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLst.Location = new System.Drawing.Point(0, 62);
            this.panelLst.Name = "panelLst";
            this.panelLst.Size = new System.Drawing.Size(310, 186);
            this.panelLst.TabIndex = 2;
            // 
            // rbZLast
            // 
            this.rbZLast.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbZLast.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rbZLast.Location = new System.Drawing.Point(208, 77);
            this.rbZLast.MinimumSize = new System.Drawing.Size(1, 1);
            this.rbZLast.Name = "rbZLast";
            this.rbZLast.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.rbZLast.Size = new System.Drawing.Size(96, 29);
            this.rbZLast.TabIndex = 5;
            this.rbZLast.Text = "后移动Z";
            this.rbZLast.CheckedChanged += new System.EventHandler(this.rbZLast_CheckedChanged);
            // 
            // rbZFirst
            // 
            this.rbZFirst.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbZFirst.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rbZFirst.Location = new System.Drawing.Point(208, 42);
            this.rbZFirst.MinimumSize = new System.Drawing.Size(1, 1);
            this.rbZFirst.Name = "rbZFirst";
            this.rbZFirst.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.rbZFirst.Size = new System.Drawing.Size(96, 29);
            this.rbZFirst.TabIndex = 4;
            this.rbZFirst.Text = "先移动Z";
            this.rbZFirst.CheckedChanged += new System.EventHandler(this.rbZFirst_CheckedChanged);
            // 
            // rbMoveSameTime
            // 
            this.rbMoveSameTime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbMoveSameTime.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rbMoveSameTime.Location = new System.Drawing.Point(208, 7);
            this.rbMoveSameTime.MinimumSize = new System.Drawing.Size(1, 1);
            this.rbMoveSameTime.Name = "rbMoveSameTime";
            this.rbMoveSameTime.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.rbMoveSameTime.Size = new System.Drawing.Size(96, 29);
            this.rbMoveSameTime.TabIndex = 3;
            this.rbMoveSameTime.Text = "同时移动";
            this.rbMoveSameTime.CheckedChanged += new System.EventHandler(this.rbMoveSameTime_CheckedChanged);
            // 
            // btnDel
            // 
            this.btnDel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDel.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDel.Location = new System.Drawing.Point(202, 150);
            this.btnDel.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(106, 33);
            this.btnDel.Symbol = 559694;
            this.btnDel.TabIndex = 2;
            this.btnDel.Text = "删除选中";
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // lsbCur
            // 
            this.lsbCur.Dock = System.Windows.Forms.DockStyle.Left;
            this.lsbCur.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.lsbCur.FormatString = "";
            this.lsbCur.ItemSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.lsbCur.Location = new System.Drawing.Point(0, 0);
            this.lsbCur.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lsbCur.MinimumSize = new System.Drawing.Size(1, 1);
            this.lsbCur.Name = "lsbCur";
            this.lsbCur.Padding = new System.Windows.Forms.Padding(2);
            this.lsbCur.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lsbCur.Size = new System.Drawing.Size(203, 186);
            this.lsbCur.TabIndex = 0;
            this.lsbCur.Text = "uiListBox1";
            // 
            // panelAdd
            // 
            this.panelAdd.Controls.Add(this.btnAdd);
            this.panelAdd.Controls.Add(this.cbAxis);
            this.panelAdd.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAdd.Location = new System.Drawing.Point(0, 29);
            this.panelAdd.Name = "panelAdd";
            this.panelAdd.Size = new System.Drawing.Size(310, 33);
            this.panelAdd.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAdd.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAdd.Location = new System.Drawing.Point(202, 0);
            this.btnAdd.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(108, 33);
            this.btnAdd.Symbol = 61846;
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "添加轴";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cbAxis
            // 
            this.cbAxis.DataSource = null;
            this.cbAxis.Dock = System.Windows.Forms.DockStyle.Left;
            this.cbAxis.DropDownStyle = SunnyUI.UIDropDownStyle.DropDownList;
            this.cbAxis.FillColor = System.Drawing.Color.White;
            this.cbAxis.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbAxis.Location = new System.Drawing.Point(0, 0);
            this.cbAxis.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbAxis.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbAxis.Name = "cbAxis";
            this.cbAxis.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbAxis.Size = new System.Drawing.Size(203, 33);
            this.cbAxis.TabIndex = 0;
            this.cbAxis.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLine1
            // 
            this.uiLine1.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiLine1.FillColor = System.Drawing.Color.White;
            this.uiLine1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLine1.LineSize = 3;
            this.uiLine1.Location = new System.Drawing.Point(0, 0);
            this.uiLine1.MinimumSize = new System.Drawing.Size(2, 2);
            this.uiLine1.Name = "uiLine1";
            this.uiLine1.Size = new System.Drawing.Size(310, 29);
            this.uiLine1.Style = SunnyUI.UIStyle.Custom;
            this.uiLine1.TabIndex = 0;
            this.uiLine1.Text = "编辑轴";
            // 
            // UAxisGroupEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabCtrl);
            this.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UAxisGroupEditor";
            this.Size = new System.Drawing.Size(310, 278);
            this.tabCtrl.ResumeLayout(false);
            this.tpGen.ResumeLayout(false);
            this.tpSet.ResumeLayout(false);
            this.panelLst.ResumeLayout(false);
            this.panelAdd.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private SunnyUI.UITabControl tabCtrl;
        private System.Windows.Forms.TabPage tpGen;
        private System.Windows.Forms.TabPage tpSet;
        private System.Windows.Forms.Panel panelCtrl;
        private SunnyUI.UILine uiLine1;
        private System.Windows.Forms.Panel panelAdd;
        private SunnyUI.UIComboBox cbAxis;
        private SunnyUI.UISymbolButton btnAdd;
        private System.Windows.Forms.Panel panelLst;
        private SunnyUI.UIListBox lsbCur;
        private SunnyUI.UISymbolButton btnDel;
        private SunnyUI.UIRadioButton rbZLast;
        private SunnyUI.UIRadioButton rbZFirst;
        private SunnyUI.UIRadioButton rbMoveSameTime;
    }
}
