using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hw_manager
{
	public partial class MainForm : Form
	{
		Dictionary<int, Process> processes;
		ListViewColumnSorter lvColumnSorter;
		private float cpu;
		private float memory;
		private ulong installedMemory;
		public MainForm()
		{
			InitializeComponent();
			LoadProcesses();
			foreach (ColumnHeader ch in listViewProcesses.Columns)
				ch.Width = -2;
			lvColumnSorter = new ListViewColumnSorter();
			listViewProcesses.ListViewItemSorter = lvColumnSorter;
			MemoryStatisex m = new MemoryStatisex();
			if (GlobalMemoryStatusEx(m))
			{
				installedMemory = m.ullTotaPhys;
			}
			lablelCpu.Text = Convert.ToString(installedMemory/1000000000)+" gb";
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
			item.Name = p.Id.ToString();
			item.Text = p.ProcessName;
			item.SubItems.Add(p.Id.ToString());
			item.SubItems.Add((p.PagedMemorySize / 1024).ToString());// объем страничной памяти в байтах, выделенной для связанного процесса.
			item.SubItems.Add((p.WorkingSet64/1024).ToString());//объем физической памяти в байтах	
			item.SubItems.Add((p.PrivateMemorySize64/1024).ToString());//объем RAM памяти в байтах	
																														
																													
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
			cpu = performanceCounterCPU.NextValue();
			memory = performanceCounterRAM.NextValue();
			labelCPUP.Text = Convert.ToString(Math.Round(cpu, 1))+ " %";
			labelRam.Text= Convert.ToString(Math.Round((memory/100*installedMemory)/1000000000,1))+ " % ";
			chart.Series["CPU"].Points.AddY(cpu);
			chart.Series["RAM"].Points.AddY(memory);
		}

		[DllImport("shell32.dll", EntryPoint = "#61", CharSet = CharSet.Unicode)]
		public static extern int RunFileDlg([In] IntPtr hwnd, [In] IntPtr icon, [In] string path, [In] string title, [In] string promt, [In] uint flags);

		[DllImport("shell32.dll")]
		static extern IntPtr ShellExecute(IntPtr hwnd, string lpOperation, string lpFile, string lpParameters, string lpDirectory, int nCmdShow);


		private void hightToolStripMenuViewRateL_Click(object sender, EventArgs e)
		{
			timer.Interval = 3000;
		}

		private void destroyToolStripMenuItem_Click_1(object sender, EventArgs e)
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

		private void listViewProcesses_ColumnClick_1(object sender, ColumnClickEventArgs e)
		{
			if (e.Column == lvColumnSorter.SortColumn)
			{
				if (lvColumnSorter.Order == SortOrder.Ascending)
					lvColumnSorter.Order = SortOrder.Descending;
				else lvColumnSorter.Order = SortOrder.Ascending;
			}
			else
			{
				lvColumnSorter.SortColumn = e.Column;
				lvColumnSorter.Order = SortOrder.Ascending;
			}
			listViewProcesses.Sort();
		}

		private void openFileLocationToolStripMenuItem_Click(object sender, EventArgs e)
		{
			string filename = processes[Convert.ToInt32(listViewProcesses.SelectedItems[0].Name)].MainModule.FileName;
			ShellExecute(this.Handle, "open", "explorer.exe", $"/select, \"{filename}\"", "", 1);
		}

		private void runToolStripMenuFileRun_Click(object sender, EventArgs e)
		{
			//var allIdle = new PerformanceCounter("Processor", "% Processor Time", "_Total");
			//MessageBox.Show(allIdle.NextValue().ToString());
			RunFileDlg(this.Handle, IntPtr.Zero, "C:\\Windows\\System32\\", null, null, 1);
		}
		[StructLayout(LayoutKind.Sequential,CharSet=CharSet.Auto)]
		private class MemoryStatisex
		{
			public uint dwLength;
			public uint dwMemoryLength;
			public ulong ullTotaPhys;
			public ulong ullAvailPhys;
			public ulong ullTotalPageFile;
			public ulong ullAvailPageFile;
			public ulong ullTotalVirual;
			public ulong ullAvailVirual;
			public ulong ullAvailExtendedVirtual;
			public MemoryStatisex()
			{
				this.dwLength = (uint)Marshal.SizeOf(typeof(MemoryStatisex));	
			}
		}
		[return: MarshalAs(UnmanagedType.Bool)]
		[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		static extern bool GlobalMemoryStatusEx([In,Out] MemoryStatisex lpBuffer);
			
	}
}
