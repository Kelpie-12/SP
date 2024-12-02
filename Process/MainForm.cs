using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Process
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();

		}

		private void btnStart_Click(object sender, EventArgs e)
		{

			string cmd = tbxProgram.Text;
			if (cbProcess.Text != string.Empty)
				cmd = cbProcess.Text;
			string[] splitted = cmd.Split(' ');
			string file = splitted[0];
			string arg = string.Empty;
			if (splitted.Length > 1)
			{
				arg = cmd.Remove(0, cmd.IndexOf(' '));
			}
			process.StartInfo.FileName = file;
			process.StartInfo.Arguments = arg;
			try
			{
				process.Start();
				if (!cbProcess.Items.Contains(cmd))
					cbProcess.Items.Add(cmd);
			}
			catch (Exception ex)
			{
				MessageBox.Show(this, ex.Message);
			}
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
