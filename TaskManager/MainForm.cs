using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Windows.Forms;

namespace TaskManager
{
	public partial class MainForm : Form
	{
		Dictionary<int, Process> processes;
		public MainForm()
		{
			InitializeComponent();
			LoadProcesses();
		}
		void LoadProcesses()
		{
			processes = Process.GetProcesses().ToDictionary(i => i.Id);
			foreach (KeyValuePair<int, Process> p in processes)
				AddNewProcesses(p.Value);

		}
		void AddNewProcesses()
		{
			foreach (KeyValuePair<int, Process> p in processes)
				if (!listViewProcesses.Items.ContainsKey(p.Key.ToString()))
					AddNewProcesses(p.Value);
		}
		void AddNewProcesses(Process p)
		{
			ListViewItem item = new ListViewItem();
			item.Name =p.Id.ToString();
			item.Text = p.ProcessName;
			item.SubItems.Add(p.Id.ToString());
			listViewProcesses.Items.Add(item);
		}
		void RemoveOldProcesses()
		{
			foreach (ListViewItem i in listViewProcesses.Items)
			{
				if (!processes.ContainsKey(Convert.ToInt32(i.SubItems[1].Text)))
					listViewProcesses.Items.Remove(i);
			}
		}
		void RefreshProcesses()
		{
			processes = Process.GetProcesses().ToDictionary(i => i.Id);
			RemoveOldProcesses();
			AddNewProcesses();
		}
		void DestroyProcess(int pid)
		{
			processes[pid].Kill();
		}
		private void timer_Tick(object sender, EventArgs e)
		{
			RefreshProcesses();
			toolStripStatusLabel1.Text = $"Processes count: {listViewProcesses.Items.Count}";
		}

		private void runToolStripMenuFileRun_Click(object sender, EventArgs e)
		{
			RunFileDlg(this.Handle, IntPtr.Zero, "C:\\Windows\\System32\\", null, null, 1);
		}

		[DllImport("shell32.dll", EntryPoint = "#61", CharSet = CharSet.Unicode)]
		public static extern int RunFileDlg([In] IntPtr hwnd, [In] IntPtr icon, [In] string path, [In] string title, [In] string promt, [In] uint flags);

		private void destroyToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (Convert.ToInt32(listViewProcesses.SelectedItems.Count) > 0)
				DestroyProcess(Convert.ToInt32(listViewProcesses.SelectedItems[0].Name));
		}

		private void contextMenuStripProcList_Opening(object sender, CancelEventArgs e)
		{
			if (Convert.ToInt32(listViewProcesses.SelectedItems.Count) <= 0)
				destroyToolStripMenuItem.Enabled = openFileLocationToolStripMenuItem.Enabled = false;
			else destroyToolStripMenuItem.Enabled = openFileLocationToolStripMenuItem.Enabled = true;
		}

		private void openFileLocationToolStripMenuItem_Click(object sender, EventArgs e)
		{
			string filename=processes[Convert.ToInt32(listViewProcesses.SelectedItems[0].Name)].MainModule.FileName;
			//filename = filename.Remove(filename.LastIndexOf("\\"));
			ShellExecute(this.Handle, "open", "explorer.exe", $"/select, \"{filename}\"", "", 1);
		
			//MessageBox.Show(filename,"Location",MessageBoxButtons.OK,MessageBoxIcon.Information);
		}
		[DllImport("shell32.dll")]
		static extern IntPtr ShellExecute(IntPtr hwnd, string lpOperation, string lpFile, string lpParameters, string lpDirectory,int nCmdShow);
		
	}
}
