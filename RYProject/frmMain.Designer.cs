namespace RYProject
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lbAlarmInfo = new SunnyUI.UIScrollingText();
            this.btnClearAlarm = new SunnyUI.UISymbolLabel();
            this.btnKeyBoard = new SunnyUI.UISymbolLabel();
            this.btnMore = new SunnyUI.UISymbolLabel();
            this.btnLogin = new SunnyUI.UISymbolLabel();
            this.btMin = new SunnyUI.UISymbolLabel();
            this.lbVersion = new SunnyUI.UILabel();
            this.lbLogo = new SunnyUI.UILabel();
            this.btClose = new SunnyUI.UISymbolLabel();
            this.pnlBot = new System.Windows.Forms.Panel();
            this.lbLoadProject = new SunnyUI.UIMarkLabel();
            this.lbTime = new SunnyUI.UIMarkLabel();
            this.lbState = new SunnyUI.UIMarkLabel();
            this.lbLogin = new SunnyUI.UIMarkLabel();
            this.tsMain = new System.Windows.Forms.ToolStrip();
            this.btStart = new System.Windows.Forms.ToolStripButton();
            this.btPause = new System.Windows.Forms.ToolStripButton();
            this.btStop = new System.Windows.Forms.ToolStripButton();
            this.btInitMachine = new System.Windows.Forms.ToolStripButton();
            this.btMainPage = new System.Windows.Forms.ToolStripButton();
            this.btTask = new System.Windows.Forms.ToolStripButton();
            this.btProcessPage = new System.Windows.Forms.ToolStripButton();
            this.btDebug = new System.Windows.Forms.ToolStripButton();
            this.btProductLog = new System.Windows.Forms.ToolStripButton();
            this.btLogPage = new System.Windows.Forms.ToolStripButton();
            this.tbFunc = new System.Windows.Forms.ToolStripButton();
            this.btSysIO = new System.Windows.Forms.ToolStripButton();
            this.btAxisCtrl = new System.Windows.Forms.ToolStripButton();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.ttmain = new System.Windows.Forms.ToolTip(this.components);
            this.menuMore = new SunnyUI.UIContextMenuStrip();
            this.btnChangePWD = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlTop.SuspendLayout();
            this.pnlBot.SuspendLayout();
            this.tsMain.SuspendLayout();
            this.menuMore.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.LightSkyBlue;
            this.pnlTop.Controls.Add(this.lbAlarmInfo);
            this.pnlTop.Controls.Add(this.btnClearAlarm);
            this.pnlTop.Controls.Add(this.btnKeyBoard);
            this.pnlTop.Controls.Add(this.btnMore);
            this.pnlTop.Controls.Add(this.btnLogin);
            this.pnlTop.Controls.Add(this.btMin);
            this.pnlTop.Controls.Add(this.lbVersion);
            this.pnlTop.Controls.Add(this.lbLogo);
            this.pnlTop.Controls.Add(this.btClose);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1094, 50);
            this.pnlTop.TabIndex = 0;
            // 
            // lbAlarmInfo
            // 
            this.lbAlarmInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbAlarmInfo.FillColor = System.Drawing.Color.LightSkyBlue;
            this.lbAlarmInfo.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbAlarmInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbAlarmInfo.Location = new System.Drawing.Point(310, 0);
            this.lbAlarmInfo.MinimumSize = new System.Drawing.Size(1, 1);
            this.lbAlarmInfo.Name = "lbAlarmInfo";
            this.lbAlarmInfo.RadiusSides = SunnyUI.UICornerRadiusSides.None;
            this.lbAlarmInfo.RectColor = System.Drawing.Color.LightSkyBlue;
            this.lbAlarmInfo.Size = new System.Drawing.Size(484, 50);
            this.lbAlarmInfo.Style = SunnyUI.UIStyle.Custom;
            this.lbAlarmInfo.TabIndex = 8;
            this.lbAlarmInfo.Text = "请复位系统";
            // 
            // btnClearAlarm
            // 
            this.btnClearAlarm.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClearAlarm.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnClearAlarm.Location = new System.Drawing.Point(794, 0);
            this.btnClearAlarm.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnClearAlarm.Name = "btnClearAlarm";
            this.btnClearAlarm.Padding = new System.Windows.Forms.Padding(46, 0, 0, 0);
            this.btnClearAlarm.Size = new System.Drawing.Size(50, 50);
            this.btnClearAlarm.Symbol = 557348;
            this.btnClearAlarm.SymbolColor = System.Drawing.Color.Red;
            this.btnClearAlarm.SymbolSize = 42;
            this.btnClearAlarm.TabIndex = 7;
            this.ttmain.SetToolTip(this.btnClearAlarm, "清空报警");
            this.btnClearAlarm.Click += new System.EventHandler(this.btnClearAlarm_Click);
            // 
            // btnKeyBoard
            // 
            this.btnKeyBoard.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnKeyBoard.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnKeyBoard.Location = new System.Drawing.Point(844, 0);
            this.btnKeyBoard.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnKeyBoard.Name = "btnKeyBoard";
            this.btnKeyBoard.Padding = new System.Windows.Forms.Padding(46, 0, 0, 0);
            this.btnKeyBoard.Size = new System.Drawing.Size(50, 50);
            this.btnKeyBoard.Symbol = 558130;
            this.btnKeyBoard.SymbolColor = System.Drawing.Color.DodgerBlue;
            this.btnKeyBoard.SymbolSize = 42;
            this.btnKeyBoard.TabIndex = 6;
            this.ttmain.SetToolTip(this.btnKeyBoard, "打开小键盘");
            this.btnKeyBoard.Click += new System.EventHandler(this.btnKeyBoard_Click);
            // 
            // btnMore
            // 
            this.btnMore.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMore.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnMore.Location = new System.Drawing.Point(894, 0);
            this.btnMore.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnMore.Name = "btnMore";
            this.btnMore.Padding = new System.Windows.Forms.Padding(46, 0, 0, 0);
            this.btnMore.Size = new System.Drawing.Size(50, 50);
            this.btnMore.Symbol = 61641;
            this.btnMore.SymbolColor = System.Drawing.Color.DodgerBlue;
            this.btnMore.SymbolSize = 42;
            this.btnMore.TabIndex = 5;
            this.ttmain.SetToolTip(this.btnMore, "更多功能");
            this.btnMore.Click += new System.EventHandler(this.btnMore_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnLogin.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnLogin.Location = new System.Drawing.Point(944, 0);
            this.btnLogin.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Padding = new System.Windows.Forms.Padding(46, 0, 0, 0);
            this.btnLogin.Size = new System.Drawing.Size(50, 50);
            this.btnLogin.Symbol = 62144;
            this.btnLogin.SymbolColor = System.Drawing.Color.DodgerBlue;
            this.btnLogin.SymbolSize = 42;
            this.btnLogin.TabIndex = 4;
            this.ttmain.SetToolTip(this.btnLogin, "切换权限");
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btMin
            // 
            this.btMin.Dock = System.Windows.Forms.DockStyle.Right;
            this.btMin.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btMin.Location = new System.Drawing.Point(994, 0);
            this.btMin.MinimumSize = new System.Drawing.Size(1, 1);
            this.btMin.Name = "btMin";
            this.btMin.Padding = new System.Windows.Forms.Padding(46, 0, 0, 0);
            this.btMin.Size = new System.Drawing.Size(50, 50);
            this.btMin.Symbol = 61560;
            this.btMin.SymbolColor = System.Drawing.Color.DodgerBlue;
            this.btMin.SymbolSize = 42;
            this.btMin.TabIndex = 3;
            this.ttmain.SetToolTip(this.btMin, "最小化");
            this.btMin.Click += new System.EventHandler(this.btMin_Click);
            // 
            // lbVersion
            // 
            this.lbVersion.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbVersion.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbVersion.ForeColor = System.Drawing.Color.Blue;
            this.lbVersion.Location = new System.Drawing.Point(138, 0);
            this.lbVersion.Name = "lbVersion";
            this.lbVersion.Size = new System.Drawing.Size(172, 50);
            this.lbVersion.TabIndex = 2;
            this.lbVersion.Text = "XX设备V2026.01.01";
            this.lbVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbLogo
            // 
            this.lbLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbLogo.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbLogo.Location = new System.Drawing.Point(0, 0);
            this.lbLogo.Name = "lbLogo";
            this.lbLogo.Size = new System.Drawing.Size(138, 50);
            this.lbLogo.TabIndex = 1;
            this.lbLogo.Text = "XX科技公司";
            this.lbLogo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btClose
            // 
            this.btClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btClose.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btClose.Location = new System.Drawing.Point(1044, 0);
            this.btClose.MinimumSize = new System.Drawing.Size(1, 1);
            this.btClose.Name = "btClose";
            this.btClose.Padding = new System.Windows.Forms.Padding(46, 0, 0, 0);
            this.btClose.Size = new System.Drawing.Size(50, 50);
            this.btClose.Symbol = 61457;
            this.btClose.SymbolColor = System.Drawing.Color.DodgerBlue;
            this.btClose.SymbolSize = 42;
            this.btClose.TabIndex = 0;
            this.ttmain.SetToolTip(this.btClose, "关闭软件");
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // pnlBot
            // 
            this.pnlBot.BackColor = System.Drawing.Color.LightSkyBlue;
            this.pnlBot.Controls.Add(this.lbLoadProject);
            this.pnlBot.Controls.Add(this.lbTime);
            this.pnlBot.Controls.Add(this.lbState);
            this.pnlBot.Controls.Add(this.lbLogin);
            this.pnlBot.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBot.Location = new System.Drawing.Point(0, 667);
            this.pnlBot.Name = "pnlBot";
            this.pnlBot.Size = new System.Drawing.Size(1094, 40);
            this.pnlBot.TabIndex = 1;
            // 
            // lbLoadProject
            // 
            this.lbLoadProject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbLoadProject.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbLoadProject.ForeColor = System.Drawing.Color.Red;
            this.lbLoadProject.Location = new System.Drawing.Point(258, 0);
            this.lbLoadProject.MarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lbLoadProject.MarkPos = SunnyUI.UIMarkLabel.UIMarkPos.Bottom;
            this.lbLoadProject.Name = "lbLoadProject";
            this.lbLoadProject.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lbLoadProject.Size = new System.Drawing.Size(699, 40);
            this.lbLoadProject.TabIndex = 3;
            this.lbLoadProject.Text = "双击加载配方";
            this.lbLoadProject.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbLoadProject.DoubleClick += new System.EventHandler(this.lbLoadProject_DoubleClick);
            // 
            // lbTime
            // 
            this.lbTime.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbTime.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbTime.Location = new System.Drawing.Point(957, 0);
            this.lbTime.MarkColor = System.Drawing.Color.LightSkyBlue;
            this.lbTime.Name = "lbTime";
            this.lbTime.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.lbTime.Size = new System.Drawing.Size(137, 40);
            this.lbTime.TabIndex = 2;
            this.lbTime.Text = "2026.01.01 00:00:00";
            this.lbTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbState
            // 
            this.lbState.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbState.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbState.Location = new System.Drawing.Point(138, 0);
            this.lbState.MarkColor = System.Drawing.Color.Blue;
            this.lbState.Name = "lbState";
            this.lbState.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.lbState.Size = new System.Drawing.Size(120, 40);
            this.lbState.TabIndex = 1;
            this.lbState.Text = "设备状态：停止";
            this.lbState.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbLogin
            // 
            this.lbLogin.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbLogin.Font = new System.Drawing.Font("微软雅黑", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbLogin.Location = new System.Drawing.Point(0, 0);
            this.lbLogin.Name = "lbLogin";
            this.lbLogin.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.lbLogin.Size = new System.Drawing.Size(138, 40);
            this.lbLogin.TabIndex = 0;
            this.lbLogin.Text = "当前用户：管理员";
            this.lbLogin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ttmain.SetToolTip(this.lbLogin, "双击切换到操作员权限");
            this.lbLogin.DoubleClick += new System.EventHandler(this.lbLogin_DoubleClick);
            // 
            // tsMain
            // 
            this.tsMain.AutoSize = false;
            this.tsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btStart,
            this.btPause,
            this.btStop,
            this.btInitMachine,
            this.btMainPage,
            this.btTask,
            this.btProcessPage,
            this.btDebug,
            this.btProductLog,
            this.btLogPage,
            this.tbFunc,
            this.btSysIO,
            this.btAxisCtrl});
            this.tsMain.Location = new System.Drawing.Point(0, 50);
            this.tsMain.Name = "tsMain";
            this.tsMain.Size = new System.Drawing.Size(1094, 66);
            this.tsMain.TabIndex = 2;
            // 
            // btStart
            // 
            this.btStart.AutoSize = false;
            this.btStart.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btStart.Image = global::RYProject.Properties.Resources.play_circle;
            this.btStart.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btStart.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(80, 60);
            this.btStart.Text = "开始";
            this.btStart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // btPause
            // 
            this.btPause.AutoSize = false;
            this.btPause.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btPause.Image = global::RYProject.Properties.Resources.pause_circle;
            this.btPause.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btPause.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btPause.Name = "btPause";
            this.btPause.Size = new System.Drawing.Size(80, 60);
            this.btPause.Text = "暂停";
            this.btPause.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btPause.Click += new System.EventHandler(this.btPause_Click);
            // 
            // btStop
            // 
            this.btStop.AutoSize = false;
            this.btStop.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btStop.Image = global::RYProject.Properties.Resources.stop_circle;
            this.btStop.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btStop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btStop.Name = "btStop";
            this.btStop.Size = new System.Drawing.Size(80, 60);
            this.btStop.Text = "停止";
            this.btStop.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btStop.Click += new System.EventHandler(this.btStop_Click);
            // 
            // btInitMachine
            // 
            this.btInitMachine.AutoSize = false;
            this.btInitMachine.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btInitMachine.Image = global::RYProject.Properties.Resources.复位;
            this.btInitMachine.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btInitMachine.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btInitMachine.Name = "btInitMachine";
            this.btInitMachine.Size = new System.Drawing.Size(80, 60);
            this.btInitMachine.Text = "复位";
            this.btInitMachine.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btInitMachine.Click += new System.EventHandler(this.btInitMachine_Click);
            // 
            // btMainPage
            // 
            this.btMainPage.AutoSize = false;
            this.btMainPage.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btMainPage.Image = global::RYProject.Properties.Resources.monitor_32px;
            this.btMainPage.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btMainPage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btMainPage.Name = "btMainPage";
            this.btMainPage.Size = new System.Drawing.Size(80, 60);
            this.btMainPage.Text = "主页";
            this.btMainPage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btMainPage.Click += new System.EventHandler(this.btMainPage_Click);
            // 
            // btTask
            // 
            this.btTask.AutoSize = false;
            this.btTask.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btTask.Image = global::RYProject.Properties.Resources.task_32px;
            this.btTask.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btTask.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btTask.Name = "btTask";
            this.btTask.Size = new System.Drawing.Size(80, 60);
            this.btTask.Text = "任务";
            this.btTask.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btTask.Click += new System.EventHandler(this.btTask_Click);
            // 
            // btProcessPage
            // 
            this.btProcessPage.AutoSize = false;
            this.btProcessPage.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btProcessPage.Image = global::RYProject.Properties.Resources.process;
            this.btProcessPage.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btProcessPage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btProcessPage.Name = "btProcessPage";
            this.btProcessPage.Size = new System.Drawing.Size(80, 60);
            this.btProcessPage.Text = "流程";
            this.btProcessPage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btProcessPage.Click += new System.EventHandler(this.btProcessPage_Click);
            // 
            // btDebug
            // 
            this.btDebug.AutoSize = false;
            this.btDebug.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btDebug.Image = global::RYProject.Properties.Resources.teach;
            this.btDebug.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btDebug.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btDebug.Name = "btDebug";
            this.btDebug.Size = new System.Drawing.Size(80, 60);
            this.btDebug.Text = "调试";
            this.btDebug.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btDebug.Click += new System.EventHandler(this.btDebug_Click);
            // 
            // btProductLog
            // 
            this.btProductLog.AutoSize = false;
            this.btProductLog.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btProductLog.Image = global::RYProject.Properties.Resources.monitoring;
            this.btProductLog.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btProductLog.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btProductLog.Name = "btProductLog";
            this.btProductLog.Size = new System.Drawing.Size(80, 60);
            this.btProductLog.Text = "生产记录";
            this.btProductLog.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btProductLog.Click += new System.EventHandler(this.btProductLog_Click);
            // 
            // btLogPage
            // 
            this.btLogPage.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btLogPage.AutoSize = false;
            this.btLogPage.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btLogPage.Image = global::RYProject.Properties.Resources.message_32px;
            this.btLogPage.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btLogPage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btLogPage.Name = "btLogPage";
            this.btLogPage.Size = new System.Drawing.Size(80, 60);
            this.btLogPage.Text = "日志消息";
            this.btLogPage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btLogPage.Click += new System.EventHandler(this.btLogPage_Click);
            // 
            // tbFunc
            // 
            this.tbFunc.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tbFunc.AutoSize = false;
            this.tbFunc.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbFunc.Image = global::RYProject.Properties.Resources.electronics_32px;
            this.tbFunc.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tbFunc.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbFunc.Name = "tbFunc";
            this.tbFunc.Size = new System.Drawing.Size(80, 60);
            this.tbFunc.Text = "功能";
            this.tbFunc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tbFunc.Click += new System.EventHandler(this.tbFunc_Click);
            // 
            // btSysIO
            // 
            this.btSysIO.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btSysIO.AutoSize = false;
            this.btSysIO.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btSysIO.Image = global::RYProject.Properties.Resources.io;
            this.btSysIO.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btSysIO.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btSysIO.Name = "btSysIO";
            this.btSysIO.Size = new System.Drawing.Size(80, 60);
            this.btSysIO.Text = "IO";
            this.btSysIO.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btSysIO.Click += new System.EventHandler(this.btSysIO_Click);
            // 
            // btAxisCtrl
            // 
            this.btAxisCtrl.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btAxisCtrl.AutoSize = false;
            this.btAxisCtrl.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btAxisCtrl.Image = global::RYProject.Properties.Resources.coordinate_system_32;
            this.btAxisCtrl.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btAxisCtrl.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btAxisCtrl.Name = "btAxisCtrl";
            this.btAxisCtrl.Size = new System.Drawing.Size(80, 60);
            this.btAxisCtrl.Text = "轴控制";
            this.btAxisCtrl.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btAxisCtrl.Click += new System.EventHandler(this.btAxisCtrl_Click);
            // 
            // pnlContainer
            // 
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Location = new System.Drawing.Point(0, 116);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(1094, 551);
            this.pnlContainer.TabIndex = 3;
            // 
            // menuMore
            // 
            this.menuMore.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.menuMore.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnChangePWD});
            this.menuMore.Name = "menuMore";
            this.menuMore.Size = new System.Drawing.Size(136, 28);
            // 
            // btnChangePWD
            // 
            this.btnChangePWD.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnChangePWD.Image = global::RYProject.Properties.Resources.key_32px;
            this.btnChangePWD.Name = "btnChangePWD";
            this.btnChangePWD.Size = new System.Drawing.Size(135, 24);
            this.btnChangePWD.Text = "更改密码";
            this.btnChangePWD.Click += new System.EventHandler(this.btnChangePWD_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 707);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.tsMain);
            this.Controls.Add(this.pnlBot);
            this.Controls.Add(this.pnlTop);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.Text = "RY示例项目";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlTop.ResumeLayout(false);
            this.pnlBot.ResumeLayout(false);
            this.tsMain.ResumeLayout(false);
            this.tsMain.PerformLayout();
            this.menuMore.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel pnlBot;
        private System.Windows.Forms.ToolStrip tsMain;
        private System.Windows.Forms.Panel pnlContainer;
        private SunnyUI.UISymbolLabel btClose;
        private System.Windows.Forms.ToolTip ttmain;
        private SunnyUI.UILabel lbLogo;
        private SunnyUI.UILabel lbVersion;
        private SunnyUI.UISymbolLabel btMin;
        private System.Windows.Forms.ToolStripButton btStart;
        private SunnyUI.UIMarkLabel lbLogin;
        private SunnyUI.UIMarkLabel lbState;
        private System.Windows.Forms.ToolStripButton btPause;
        private System.Windows.Forms.ToolStripButton btStop;
        private System.Windows.Forms.ToolStripButton btInitMachine;
        private System.Windows.Forms.ToolStripButton btMainPage;
        private System.Windows.Forms.ToolStripButton btLogPage;
        private SunnyUI.UIMarkLabel lbTime;
        private System.Windows.Forms.ToolStripButton btTask;
        private System.Windows.Forms.ToolStripButton btProcessPage;
        private System.Windows.Forms.ToolStripButton btDebug;
        private System.Windows.Forms.ToolStripButton tbFunc;
        private System.Windows.Forms.ToolStripButton btSysIO;
        private System.Windows.Forms.ToolStripButton btAxisCtrl;
        private SunnyUI.UISymbolLabel btnLogin;
        private SunnyUI.UISymbolLabel btnKeyBoard;
        private SunnyUI.UISymbolLabel btnMore;
        private SunnyUI.UIScrollingText lbAlarmInfo;
        private SunnyUI.UISymbolLabel btnClearAlarm;
        private SunnyUI.UIContextMenuStrip menuMore;
        private System.Windows.Forms.ToolStripMenuItem btnChangePWD;
        private SunnyUI.UIMarkLabel lbLoadProject;
        private System.Windows.Forms.ToolStripButton btProductLog;
    }
}