using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
			//listViewProcesses.Clear();
			processes = Process.GetProcesses().ToDictionary(i => i.Id);

			foreach (KeyValuePair<int, Process> p in processes)
				listViewProcesses.Items.Add(p.Key.ToString()).SubItems.Add(p.Value.ProcessName).Name = p.Value.ProcessName;
		}
		void AddNewProcesses()
		{
			foreach (KeyValuePair<int, Process> p in processes)
				if (!listViewProcesses.Items.ContainsKey(p.Key.ToString()))
					listViewProcesses.Items.Add(p.Key.ToString()).SubItems.Add(p.Value.ProcessName);


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
		}
	}
}
