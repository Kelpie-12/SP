namespace Process
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
			this.tbxProgram = new System.Windows.Forms.TextBox();
			this.btnStart = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.process = new System.Diagnostics.Process();
			this.cbProcess = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// tbxProgram
			// 
			this.tbxProgram.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.tbxProgram.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllSystemSources;
			this.tbxProgram.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tbxProgram.Location = new System.Drawing.Point(12, 28);
			this.tbxProgram.Name = "tbxProgram";
			this.tbxProgram.Size = new System.Drawing.Size(776, 38);
			this.tbxProgram.TabIndex = 0;
			// 
			// btnStart
			// 
			this.btnStart.AutoSize = true;
			this.btnStart.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnStart.Location = new System.Drawing.Point(555, 176);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(89, 41);
			this.btnStart.TabIndex = 1;
			this.btnStart.Text = "Start";
			this.btnStart.UseVisualStyleBackColor = true;
			this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.AutoSize = true;
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnCancel.Location = new System.Drawing.Point(679, 176);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(109, 41);
			this.btnCancel.TabIndex = 2;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// process
			// 
			this.process.StartInfo.Domain = "";
			this.process.StartInfo.LoadUserProfile = false;
			this.process.StartInfo.Password = null;
			this.process.StartInfo.StandardErrorEncoding = null;
			this.process.StartInfo.StandardOutputEncoding = null;
			this.process.StartInfo.UserName = "";
			this.process.SynchronizingObject = this;
			// 
			// cbProcess
			// 
			this.cbProcess.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.cbProcess.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cbProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.cbProcess.FormattingEnabled = true;
			this.cbProcess.Location = new System.Drawing.Point(12, 81);
			this.cbProcess.Name = "cbProcess";
			this.cbProcess.Size = new System.Drawing.Size(776, 39);
			this.cbProcess.TabIndex = 3;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(796, 225);
			this.Controls.Add(this.cbProcess);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnStart);
			this.Controls.Add(this.tbxProgram);
			this.Name = "MainForm";
			this.Text = "Processes";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox tbxProgram;
		private System.Windows.Forms.Button btnStart;
		private System.Windows.Forms.Button btnCancel;
		private System.Diagnostics.Process process;
		private System.Windows.Forms.ComboBox cbProcess;
	}
}

