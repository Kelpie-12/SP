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
			item.Name = item.Text = p.Id.ToString();
			item.SubItems.Add(p.ProcessName);
			listViewProcesses.Items.Add(item);
		}
		void RemoveOldProcesses()
		{
			foreach (ListViewItem i in listViewProcesses.Items)
			{
				if (!processes.ContainsKey(Convert.ToInt32(i.SubItems[0].Text)))
					listViewProcesses.Items.Remove(i);
			}
		}
		void RefreshProcesses()
		{
			processes = Process.GetProcesses().ToDictionary(i => i.Id);
			RemoveOldProcesses();
			AddNewProcesses();
		}
		private void timer_Tick(object sender, EventArgs e)
		{
			RefreshProcesses();
			toolStripStatusLabel1.Text= $"Processes count: {listViewProcesses.Items.Count}";


		}

		private void runToolStripMenuFileRun_Click(object sender, EventArgs e)
		{
			RunFileDlg(this.Handle, IntPtr.Zero, "C:\\Windows\\System32\\", null, null, 1);
		}

		[DllImport("shell32.dll", EntryPoint = "#61", CharSet = CharSet.Unicode)]
		public static extern int RunFileDlg([In] IntPtr hwnd, [In] IntPtr icon, [In] string path, [In] string title, [In] string promt, [In] uint flags);
	}
}
