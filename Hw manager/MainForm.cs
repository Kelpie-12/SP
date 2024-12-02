using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Management;
using System.Windows.Forms;
using System.Diagnostics;

namespace Hw_manager
{
	public partial class MainForm : Form
	{
		private List<Process> processes = null;
		public MainForm()
		{
			InitializeComponent();
		}
		private void GetProcesses()
		{
			processes.Clear();
			processes=Process.GetProcesses().ToList();
		}
		private void RefreshProcessesList()
		{
			listViewProcess.Items.Clear();
			foreach (Process process in processes) 
			{
				string[] row = new string[] { process.ProcessName, };
				listViewProcess.Items.Add(new ListViewItem(row));
				}
			lableProcess.Text = "Запущено " + processes.Count.ToString();
		}
		private void killProcess(Process process)
		{
			process.Kill();
			process.WaitForExit();
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			processes = new List<Process>();
			GetProcesses();
			RefreshProcessesList();
		}

		private void btnRefrech_Click(object sender, EventArgs e)
		{
			GetProcesses();
			RefreshProcessesList();
		}

		private void btnStop_Click(object sender, EventArgs e)
		{
			try
			{
				if (listViewProcess.SelectedItems[0]!=null)
				{
					Process process = processes.Where((x) => x.ProcessName == listViewProcess.SelectedItems[0].SubItems[0].Text).ToList()[0];
					killProcess(process);
					GetProcesses();
					RefreshProcessesList();
				}
			}
			catch (Exception)
			{
				MessageBox.Show("Ошибка! Невозможно завершить процесс");				
			}
		}
	}
}
