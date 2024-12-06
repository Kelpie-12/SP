﻿using System;
using System.Collections.Generic;
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
		private string search = "";
		private List<Process> processes = new List<Process>();
		public MainForm()
		{
			InitializeComponent();

		}
		private void LoadProcessesList()
		{
			processes = Process.GetProcesses().ToList();
			for (int i = 0; i < processes.Count; i++)
			{
				string[] row = new string[] { processes[i].Id.ToString(), processes[i].ProcessName, (processes[i].PagedMemorySize / 1024).ToString(), processes[i].ProcessName };
				listViewProcesses.Items.Add(new ListViewItem(row));
			}
			listViewProcesses.Sort();
		}
		private void MainForm_Load(object sender, EventArgs e)
		{
			LoadProcessesList();
		}

		private void timer_Tick(object sender, EventArgs e)
		{
			RefreshProcessesList();
		}

		private void RefreshProcessesList()
		{
			Dictionary<int, Process> newProcess = Process.GetProcesses().ToDictionary(p => p.Id);
			for (int i = listViewProcesses.Items.Count - 1; i >= 0; i--)
			{
				ListViewItem item = listViewProcesses.Items[i];
				if (!newProcess.ContainsKey(Convert.ToInt32(item.Text)))
				{
					listViewProcesses.Items.Remove(item);
				}
			}
			foreach (var item in newProcess)
			{
				if (listViewProcesses.Items.ContainsKey(item.Value.Id.ToString()) == false)
				{
				}
				else
				{
					string [] row = new string[] { item.Value.Id.ToString(), item.Value.ProcessName, (item.Value.PagedMemorySize / 1024).ToString(),item.Value.ProcessName };
					listViewProcesses.Items.Add(new ListViewItem(row));

				}
			}
		}
		

		private void topmostToolStripMenuViewTopmost_Click(object sender, EventArgs e)
		{
			if (topmostToolStripMenuViewTopmost.Checked)
				this.TopMost = true;
			else this.TopMost = false;

		}

		private void adressToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ColumnHeader h = new ColumnHeader();
			h.Name = "Adress";
			h.Width = 120;
			h.Text = "Adress";
			if (adressToolStripMenuItem.Checked)
			{
				listViewProcesses.Columns.Add(h);
				RefreshProcessesList();
			}
			else
			{
				listViewProcesses.Columns.RemoveAt(3);
			}
		}

		private void hightToolStripMenuViewRateL_Click(object sender, EventArgs e)
		{
			timer.Interval= 3000;
		}

		private void listViewProcesses_KeyPress(object sender, KeyPressEventArgs e)
		{
			//if ((!char.IsControl(e.KeyChar)) && (char.IsLetter(e.KeyChar)))
			//{
			//	e.Handled = true;
			//	search += e.KeyChar.ToString();				
			//	ListViewItem item = listViewProcesses.FindItemWithText(search);
			//	listViewProcesses.Items[item.Index].Selected=true;
			//	listViewProcesses.Items[item.Index].Focused= true;
			//	//listViewProcesses.SelectedItems[item.Index].Selected = true;
			//}
			
		}
	}
}
