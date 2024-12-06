﻿namespace Hw_manager
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
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.refreshToolStripMenuViewRefrech = new System.Windows.Forms.ToolStripMenuItem();
			this.refreshRateToolStripMenuRefreshRate = new System.Windows.Forms.ToolStripMenuItem();
			this.hightToolStripMenuViewRateH = new System.Windows.Forms.ToolStripMenuItem();
			this.hightToolStripMenuViewRateN = new System.Windows.Forms.ToolStripMenuItem();
			this.hightToolStripMenuViewRateL = new System.Windows.Forms.ToolStripMenuItem();
			this.tabConMain = new System.Windows.Forms.TabControl();
			this.tabPageProcesses = new System.Windows.Forms.TabPage();
			this.listViewProcesses = new System.Windows.Forms.ListView();
			this.listViewColumnPID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.listViewColumnProcessName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.listViewColumnProcessMemory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.tabPagePerphormance = new System.Windows.Forms.TabPage();
			this.timer = new System.Windows.Forms.Timer(this.components);
			this.menStripMainMenu.SuspendLayout();
			this.tabConMain.SuspendLayout();
			this.tabPageProcesses.SuspendLayout();
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
			this.menStripMainMenu.Size = new System.Drawing.Size(757, 37);
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
			this.topmostToolStripMenuViewTopmost.Click += new System.EventHandler(this.topmostToolStripMenuViewTopmost_Click);
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
            this.adressToolStripMenuItem});
			this.selectColumnsToolStripMenuViewColums.Name = "selectColumnsToolStripMenuViewColums";
			this.selectColumnsToolStripMenuViewColums.Size = new System.Drawing.Size(287, 30);
			this.selectColumnsToolStripMenuViewColums.Text = "Select columns";
			// 
			// adressToolStripMenuItem
			// 
			this.adressToolStripMenuItem.CheckOnClick = true;
			this.adressToolStripMenuItem.Name = "adressToolStripMenuItem";
			this.adressToolStripMenuItem.Size = new System.Drawing.Size(151, 30);
			this.adressToolStripMenuItem.Text = "Adress";
			this.adressToolStripMenuItem.Click += new System.EventHandler(this.adressToolStripMenuItem_Click);
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
			this.tabConMain.Size = new System.Drawing.Size(757, 413);
			this.tabConMain.TabIndex = 5;
			// 
			// tabPageProcesses
			// 
			this.tabPageProcesses.Controls.Add(this.listViewProcesses);
			this.tabPageProcesses.Location = new System.Drawing.Point(4, 34);
			this.tabPageProcesses.Name = "tabPageProcesses";
			this.tabPageProcesses.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageProcesses.Size = new System.Drawing.Size(749, 375);
			this.tabPageProcesses.TabIndex = 0;
			this.tabPageProcesses.Text = "Processes";
			this.tabPageProcesses.UseVisualStyleBackColor = true;
			// 
			// listViewProcesses
			// 
			this.listViewProcesses.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.listViewColumnPID,
            this.listViewColumnProcessName,
            this.listViewColumnProcessMemory});
			this.listViewProcesses.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listViewProcesses.FullRowSelect = true;
			this.listViewProcesses.GridLines = true;
			this.listViewProcesses.HideSelection = false;
			this.listViewProcesses.Location = new System.Drawing.Point(3, 3);
			this.listViewProcesses.MultiSelect = false;
			this.listViewProcesses.Name = "listViewProcesses";
			this.listViewProcesses.Size = new System.Drawing.Size(743, 369);
			this.listViewProcesses.Sorting = System.Windows.Forms.SortOrder.Ascending;
			this.listViewProcesses.TabIndex = 0;
			this.listViewProcesses.UseCompatibleStateImageBehavior = false;
			this.listViewProcesses.View = System.Windows.Forms.View.Details;
			this.listViewProcesses.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.listViewProcesses_KeyPress);
			// 
			// listViewColumnPID
			// 
			this.listViewColumnPID.Text = "PID";
			this.listViewColumnPID.Width = 91;
			// 
			// listViewColumnProcessName
			// 
			this.listViewColumnProcessName.Text = "Name";
			this.listViewColumnProcessName.Width = 138;
			// 
			// listViewColumnProcessMemory
			// 
			this.listViewColumnProcessMemory.Text = "Memory kb";
			this.listViewColumnProcessMemory.Width = 178;
			// 
			// tabPagePerphormance
			// 
			this.tabPagePerphormance.Location = new System.Drawing.Point(4, 34);
			this.tabPagePerphormance.Name = "tabPagePerphormance";
			this.tabPagePerphormance.Padding = new System.Windows.Forms.Padding(3);
			this.tabPagePerphormance.Size = new System.Drawing.Size(749, 375);
			this.tabPagePerphormance.TabIndex = 1;
			this.tabPagePerphormance.Text = "Perphormance";
			this.tabPagePerphormance.UseVisualStyleBackColor = true;
			// 
			// timer
			// 
			this.timer.Enabled = true;
			this.timer.Interval = 1000;
			this.timer.Tick += new System.EventHandler(this.timer_Tick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(757, 450);
			this.Controls.Add(this.tabConMain);
			this.Controls.Add(this.menStripMainMenu);
			this.DoubleBuffered = true;
			this.Name = "MainForm";
			this.Text = "Manager";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.menStripMainMenu.ResumeLayout(false);
			this.menStripMainMenu.PerformLayout();
			this.tabConMain.ResumeLayout(false);
			this.tabPageProcesses.ResumeLayout(false);
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
	}
}

