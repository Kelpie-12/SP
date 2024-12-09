namespace Hw_manager
{
	partial class MainForm
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
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
			this.menStripMainMenu = new System.Windows.Forms.MenuStrip();
			this.runToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.runToolStripMenuFileRun = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.exitToolStripMenuFileExit = new System.Windows.Forms.ToolStripMenuItem();
			this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.topmostToolStripMenuViewTopmost = new System.Windows.Forms.ToolStripMenuItem();
			this.hideWhenMinimizedToolStripMenuViewHide = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.selectColumnsToolStripMenuViewColums = new System.Windows.Forms.ToolStripMenuItem();
			this.adressToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cPUToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.refreshToolStripMenuViewRefrech = new System.Windows.Forms.ToolStripMenuItem();
			this.refreshRateToolStripMenuRefreshRate = new System.Windows.Forms.ToolStripMenuItem();
			this.hightToolStripMenuViewRateH = new System.Windows.Forms.ToolStripMenuItem();
			this.hightToolStripMenuViewRateN = new System.Windows.Forms.ToolStripMenuItem();
			this.hightToolStripMenuViewRateL = new System.Windows.Forms.ToolStripMenuItem();
			this.tabConMain = new System.Windows.Forms.TabControl();
			this.tabPageProcesses = new System.Windows.Forms.TabPage();
			this.listViewProcesses = new System.Windows.Forms.ListView();
			this.listViewColumnProcessName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.listViewColumnPID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.listViewColumnProcessMemory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.listViewColumnProcessSM = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.listViewColumnProcessRam = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.tabPagePerphormance = new System.Windows.Forms.TabPage();
			this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.timer = new System.Windows.Forms.Timer(this.components);
			this.contextMenuStripProcList = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.openFileLocationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.destroyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.statusStripMain = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.performanceCounterCPU = new System.Diagnostics.PerformanceCounter();
			this.performanceCounterRAM = new System.Diagnostics.PerformanceCounter();
			this.label1 = new System.Windows.Forms.Label();
			this.lablelCpu = new System.Windows.Forms.Label();
			this.menStripMainMenu.SuspendLayout();
			this.tabConMain.SuspendLayout();
			this.tabPageProcesses.SuspendLayout();
			this.tabPagePerphormance.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
			this.contextMenuStripProcList.SuspendLayout();
			this.statusStripMain.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.performanceCounterCPU)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.performanceCounterRAM)).BeginInit();
			this.SuspendLayout();
			// 
			// menStripMainMenu
			// 
			this.menStripMainMenu.Font = new System.Drawing.Font("Segoe UI", 15F);
			this.menStripMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.runToolStripMenuItem,
            this.viewToolStripMenuItem});
			this.menStripMainMenu.Location = new System.Drawing.Point(0, 0);
			this.menStripMainMenu.Name = "menStripMainMenu";
			this.menStripMainMenu.Padding = new System.Windows.Forms.Padding(12, 4, 0, 4);
			this.menStripMainMenu.Size = new System.Drawing.Size(1083, 37);
			this.menStripMainMenu.TabIndex = 4;
			this.menStripMainMenu.Text = "menuStrip1";
			// 
			// runToolStripMenuItem
			// 
			this.runToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.runToolStripMenuFileRun,
            this.toolStripSeparator1,
            this.exitToolStripMenuFileExit});
			this.runToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.runToolStripMenuItem.Name = "runToolStripMenuItem";
			this.runToolStripMenuItem.Size = new System.Drawing.Size(59, 29);
			this.runToolStripMenuItem.Text = "File";
			// 
			// runToolStripMenuFileRun
			// 
			this.runToolStripMenuFileRun.Name = "runToolStripMenuFileRun";
			this.runToolStripMenuFileRun.Size = new System.Drawing.Size(123, 30);
			this.runToolStripMenuFileRun.Text = "Run";
			this.runToolStripMenuFileRun.Click += new System.EventHandler(this.runToolStripMenuFileRun_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(120, 6);
			// 
			// exitToolStripMenuFileExit
			// 
			this.exitToolStripMenuFileExit.Name = "exitToolStripMenuFileExit";
			this.exitToolStripMenuFileExit.Size = new System.Drawing.Size(123, 30);
			this.exitToolStripMenuFileExit.Text = "Exit";
			// 
			// viewToolStripMenuItem
			// 
			this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.topmostToolStripMenuViewTopmost,
            this.hideWhenMinimizedToolStripMenuViewHide,
            this.toolStripSeparator2,
            this.selectColumnsToolStripMenuViewColums,
            this.toolStripSeparator3,
            this.refreshToolStripMenuViewRefrech,
            this.refreshRateToolStripMenuRefreshRate});
			this.viewToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
			this.viewToolStripMenuItem.Size = new System.Drawing.Size(70, 29);
			this.viewToolStripMenuItem.Text = "View";
			// 
			// topmostToolStripMenuViewTopmost
			// 
			this.topmostToolStripMenuViewTopmost.CheckOnClick = true;
			this.topmostToolStripMenuViewTopmost.Name = "topmostToolStripMenuViewTopmost";
			this.topmostToolStripMenuViewTopmost.Size = new System.Drawing.Size(287, 30);
			this.topmostToolStripMenuViewTopmost.Text = "Topmost";
			// 
			// hideWhenMinimizedToolStripMenuViewHide
			// 
			this.hideWhenMinimizedToolStripMenuViewHide.CheckOnClick = true;
			this.hideWhenMinimizedToolStripMenuViewHide.Name = "hideWhenMinimizedToolStripMenuViewHide";
			this.hideWhenMinimizedToolStripMenuViewHide.Size = new System.Drawing.Size(287, 30);
			this.hideWhenMinimizedToolStripMenuViewHide.Text = "Hide when minimized";
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(284, 6);
			// 
			// selectColumnsToolStripMenuViewColums
			// 
			this.selectColumnsToolStripMenuViewColums.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adressToolStripMenuItem,
            this.cPUToolStripMenuItem});
			this.selectColumnsToolStripMenuViewColums.Name = "selectColumnsToolStripMenuViewColums";
			this.selectColumnsToolStripMenuViewColums.Size = new System.Drawing.Size(287, 30);
			this.selectColumnsToolStripMenuViewColums.Text = "Select columns";
			// 
			// adressToolStripMenuItem
			// 
			this.adressToolStripMenuItem.CheckOnClick = true;
			this.adressToolStripMenuItem.Name = "adressToolStripMenuItem";
			this.adressToolStripMenuItem.Size = new System.Drawing.Size(190, 30);
			this.adressToolStripMenuItem.Text = "Memory kb";
			// 
			// cPUToolStripMenuItem
			// 
			this.cPUToolStripMenuItem.Name = "cPUToolStripMenuItem";
			this.cPUToolStripMenuItem.Size = new System.Drawing.Size(190, 30);
			this.cPUToolStripMenuItem.Text = "CPU";
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(284, 6);
			// 
			// refreshToolStripMenuViewRefrech
			// 
			this.refreshToolStripMenuViewRefrech.Name = "refreshToolStripMenuViewRefrech";
			this.refreshToolStripMenuViewRefrech.Size = new System.Drawing.Size(287, 30);
			this.refreshToolStripMenuViewRefrech.Text = "Refresh";
			// 
			// refreshRateToolStripMenuRefreshRate
			// 
			this.refreshRateToolStripMenuRefreshRate.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hightToolStripMenuViewRateH,
            this.hightToolStripMenuViewRateN,
            this.hightToolStripMenuViewRateL});
			this.refreshRateToolStripMenuRefreshRate.Name = "refreshRateToolStripMenuRefreshRate";
			this.refreshRateToolStripMenuRefreshRate.Size = new System.Drawing.Size(287, 30);
			this.refreshRateToolStripMenuRefreshRate.Text = "Refresh rate";
			// 
			// hightToolStripMenuViewRateH
			// 
			this.hightToolStripMenuViewRateH.Name = "hightToolStripMenuViewRateH";
			this.hightToolStripMenuViewRateH.Size = new System.Drawing.Size(152, 30);
			this.hightToolStripMenuViewRateH.Text = "High";
			// 
			// hightToolStripMenuViewRateN
			// 
			this.hightToolStripMenuViewRateN.Name = "hightToolStripMenuViewRateN";
			this.hightToolStripMenuViewRateN.Size = new System.Drawing.Size(152, 30);
			this.hightToolStripMenuViewRateN.Text = "Normal";
			// 
			// hightToolStripMenuViewRateL
			// 
			this.hightToolStripMenuViewRateL.Name = "hightToolStripMenuViewRateL";
			this.hightToolStripMenuViewRateL.Size = new System.Drawing.Size(152, 30);
			this.hightToolStripMenuViewRateL.Text = "Low";
			this.hightToolStripMenuViewRateL.Click += new System.EventHandler(this.hightToolStripMenuViewRateL_Click);
			// 
			// tabConMain
			// 
			this.tabConMain.Controls.Add(this.tabPageProcesses);
			this.tabConMain.Controls.Add(this.tabPagePerphormance);
			this.tabConMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabConMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tabConMain.Location = new System.Drawing.Point(0, 37);
			this.tabConMain.Name = "tabConMain";
			this.tabConMain.SelectedIndex = 0;
			this.tabConMain.Size = new System.Drawing.Size(1083, 553);
			this.tabConMain.TabIndex = 5;
			// 
			// tabPageProcesses
			// 
			this.tabPageProcesses.Controls.Add(this.listViewProcesses);
			this.tabPageProcesses.Location = new System.Drawing.Point(4, 34);
			this.tabPageProcesses.Name = "tabPageProcesses";
			this.tabPageProcesses.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageProcesses.Size = new System.Drawing.Size(1075, 515);
			this.tabPageProcesses.TabIndex = 0;
			this.tabPageProcesses.Text = "Processes";
			this.tabPageProcesses.UseVisualStyleBackColor = true;
			// 
			// listViewProcesses
			// 
			this.listViewProcesses.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.listViewColumnProcessName,
            this.listViewColumnPID,
            this.listViewColumnProcessMemory,
            this.listViewColumnProcessSM,
            this.listViewColumnProcessRam});
			this.listViewProcesses.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listViewProcesses.FullRowSelect = true;
			this.listViewProcesses.GridLines = true;
			this.listViewProcesses.HideSelection = false;
			this.listViewProcesses.Location = new System.Drawing.Point(3, 3);
			this.listViewProcesses.MultiSelect = false;
			this.listViewProcesses.Name = "listViewProcesses";
			this.listViewProcesses.Size = new System.Drawing.Size(1069, 509);
			this.listViewProcesses.Sorting = System.Windows.Forms.SortOrder.Ascending;
			this.listViewProcesses.TabIndex = 0;
			this.listViewProcesses.UseCompatibleStateImageBehavior = false;
			this.listViewProcesses.View = System.Windows.Forms.View.Details;
			this.listViewProcesses.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listViewProcesses_ColumnClick_1);
			// 
			// listViewColumnProcessName
			// 
			this.listViewColumnProcessName.Text = "Name";
			this.listViewColumnProcessName.Width = 138;
			// 
			// listViewColumnPID
			// 
			this.listViewColumnPID.Text = "PID";
			this.listViewColumnPID.Width = 91;
			// 
			// listViewColumnProcessMemory
			// 
			this.listViewColumnProcessMemory.Text = "Memory kb";
			this.listViewColumnProcessMemory.Width = 178;
			// 
			// listViewColumnProcessSM
			// 
			this.listViewColumnProcessSM.Text = "Static memory";
			// 
			// listViewColumnProcessRam
			// 
			this.listViewColumnProcessRam.Text = "RAM";
			// 
			// tabPagePerphormance
			// 
			this.tabPagePerphormance.Controls.Add(this.lablelCpu);
			this.tabPagePerphormance.Controls.Add(this.label1);
			this.tabPagePerphormance.Controls.Add(this.chart);
			this.tabPagePerphormance.Location = new System.Drawing.Point(4, 34);
			this.tabPagePerphormance.Name = "tabPagePerphormance";
			this.tabPagePerphormance.Padding = new System.Windows.Forms.Padding(3);
			this.tabPagePerphormance.Size = new System.Drawing.Size(1075, 515);
			this.tabPagePerphormance.TabIndex = 1;
			this.tabPagePerphormance.Text = "Perphormance";
			this.tabPagePerphormance.UseVisualStyleBackColor = true;
			// 
			// chart
			// 
			chartArea1.Name = "ChartArea1";
			this.chart.ChartAreas.Add(chartArea1);
			legend1.Name = "Legend1";
			this.chart.Legends.Add(legend1);
			this.chart.Location = new System.Drawing.Point(29, 99);
			this.chart.Name = "chart";
			series1.ChartArea = "ChartArea1";
			series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
			series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			series1.Legend = "Legend1";
			series1.MarkerBorderColor = System.Drawing.Color.Red;
			series1.MarkerSize = 10;
			series1.Name = "CPU";
			series2.ChartArea = "ChartArea1";
			series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
			series2.Legend = "Legend1";
			series2.Name = "RAM";
			this.chart.Series.Add(series1);
			this.chart.Series.Add(series2);
			this.chart.Size = new System.Drawing.Size(854, 365);
			this.chart.TabIndex = 0;
			// 
			// timer
			// 
			this.timer.Enabled = true;
			this.timer.Interval = 1000;
			this.timer.Tick += new System.EventHandler(this.timer_Tick);
			// 
			// contextMenuStripProcList
			// 
			this.contextMenuStripProcList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileLocationToolStripMenuItem,
            this.toolStripSeparator4,
            this.destroyToolStripMenuItem});
			this.contextMenuStripProcList.Name = "contextMenuStripProcList";
			this.contextMenuStripProcList.Size = new System.Drawing.Size(169, 54);
			this.contextMenuStripProcList.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStripProcList_Opening);
			// 
			// openFileLocationToolStripMenuItem
			// 
			this.openFileLocationToolStripMenuItem.Name = "openFileLocationToolStripMenuItem";
			this.openFileLocationToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
			this.openFileLocationToolStripMenuItem.Text = "Open file location";
			this.openFileLocationToolStripMenuItem.Click += new System.EventHandler(this.openFileLocationToolStripMenuItem_Click);
			// 
			// toolStripSeparator4
			// 
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new System.Drawing.Size(165, 6);
			// 
			// destroyToolStripMenuItem
			// 
			this.destroyToolStripMenuItem.Name = "destroyToolStripMenuItem";
			this.destroyToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
			this.destroyToolStripMenuItem.Text = "Destroy";
			this.destroyToolStripMenuItem.Click += new System.EventHandler(this.destroyToolStripMenuItem_Click_1);
			// 
			// statusStripMain
			// 
			this.statusStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
			this.statusStripMain.Location = new System.Drawing.Point(0, 568);
			this.statusStripMain.Name = "statusStripMain";
			this.statusStripMain.Padding = new System.Windows.Forms.Padding(2, 0, 28, 0);
			this.statusStripMain.Size = new System.Drawing.Size(1083, 22);
			this.statusStripMain.TabIndex = 7;
			this.statusStripMain.Text = "statusStrip1";
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(112, 17);
			this.toolStripStatusLabel1.Text = "toolStripStatusLabel";
			// 
			// performanceCounterCPU
			// 
			this.performanceCounterCPU.CategoryName = "Processor";
			this.performanceCounterCPU.CounterName = "% Processor Time";
			this.performanceCounterCPU.InstanceName = "_total";
			// 
			// performanceCounterRAM
			// 
			this.performanceCounterRAM.CategoryName = "Memory";
			this.performanceCounterRAM.CounterName = "% Committed Bytes In Use";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(35, 36);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(81, 25);
			this.label1.TabIndex = 1;
			this.label1.Text = "All CPU";
			// 
			// lablelCpu
			// 
			this.lablelCpu.AutoSize = true;
			this.lablelCpu.Location = new System.Drawing.Point(134, 36);
			this.lablelCpu.Name = "lablelCpu";
			this.lablelCpu.Size = new System.Drawing.Size(0, 25);
			this.lablelCpu.TabIndex = 2;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1083, 590);
			this.Controls.Add(this.statusStripMain);
			this.Controls.Add(this.tabConMain);
			this.Controls.Add(this.menStripMainMenu);
			this.DoubleBuffered = true;
			this.Name = "MainForm";
			this.Text = "Manager";
			this.menStripMainMenu.ResumeLayout(false);
			this.menStripMainMenu.PerformLayout();
			this.tabConMain.ResumeLayout(false);
			this.tabPageProcesses.ResumeLayout(false);
			this.tabPagePerphormance.ResumeLayout(false);
			this.tabPagePerphormance.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
			this.contextMenuStripProcList.ResumeLayout(false);
			this.statusStripMain.ResumeLayout(false);
			this.statusStripMain.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.performanceCounterCPU)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.performanceCounterRAM)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.MenuStrip menStripMainMenu;
		private System.Windows.Forms.ToolStripMenuItem runToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem runToolStripMenuFileRun;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuFileExit;
		private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem topmostToolStripMenuViewTopmost;
		private System.Windows.Forms.ToolStripMenuItem hideWhenMinimizedToolStripMenuViewHide;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripMenuItem selectColumnsToolStripMenuViewColums;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuViewRefrech;
		private System.Windows.Forms.ToolStripMenuItem refreshRateToolStripMenuRefreshRate;
		private System.Windows.Forms.ToolStripMenuItem hightToolStripMenuViewRateH;
		private System.Windows.Forms.ToolStripMenuItem hightToolStripMenuViewRateN;
		private System.Windows.Forms.ToolStripMenuItem hightToolStripMenuViewRateL;
		private System.Windows.Forms.TabControl tabConMain;
		private System.Windows.Forms.TabPage tabPageProcesses;
		private System.Windows.Forms.ListView listViewProcesses;
		private System.Windows.Forms.ColumnHeader listViewColumnPID;
		private System.Windows.Forms.ColumnHeader listViewColumnProcessName;
		private System.Windows.Forms.TabPage tabPagePerphormance;
		private System.Windows.Forms.Timer timer;
		private System.Windows.Forms.ColumnHeader listViewColumnProcessMemory;
		private System.Windows.Forms.ToolStripMenuItem adressToolStripMenuItem;
		private System.Windows.Forms.ContextMenuStrip contextMenuStripProcList;
		private System.Windows.Forms.ToolStripMenuItem openFileLocationToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
		private System.Windows.Forms.ToolStripMenuItem destroyToolStripMenuItem;
		private System.Windows.Forms.StatusStrip statusStripMain;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		private System.Windows.Forms.ToolStripMenuItem cPUToolStripMenuItem;
		private System.Windows.Forms.ColumnHeader listViewColumnProcessSM;
		private System.Windows.Forms.ColumnHeader listViewColumnProcessRam;
		private System.Windows.Forms.DataVisualization.Charting.Chart chart;
		private System.Diagnostics.PerformanceCounter performanceCounterCPU;
		private System.Diagnostics.PerformanceCounter performanceCounterRAM;
		private System.Windows.Forms.Label lablelCpu;
		private System.Windows.Forms.Label label1;
	}
}

