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
			this.btnRefrech = new System.Windows.Forms.Button();
			this.btnStop = new System.Windows.Forms.Button();
			this.listViewProcess = new System.Windows.Forms.ListView();
			this.colHeadNameProsecc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.lableProcess = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnRefrech
			// 
			this.btnRefrech.AutoSize = true;
			this.btnRefrech.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnRefrech.Location = new System.Drawing.Point(12, 12);
			this.btnRefrech.Name = "btnRefrech";
			this.btnRefrech.Size = new System.Drawing.Size(98, 36);
			this.btnRefrech.TabIndex = 0;
			this.btnRefrech.Text = "Refrech";
			this.btnRefrech.UseVisualStyleBackColor = true;
			this.btnRefrech.Click += new System.EventHandler(this.btnRefrech_Click);
			// 
			// btnStop
			// 
			this.btnStop.AutoSize = true;
			this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnStop.Location = new System.Drawing.Point(129, 12);
			this.btnStop.Name = "btnStop";
			this.btnStop.Size = new System.Drawing.Size(98, 36);
			this.btnStop.TabIndex = 1;
			this.btnStop.Text = "Stop";
			this.btnStop.UseVisualStyleBackColor = true;
			this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
			// 
			// listViewProcess
			// 
			this.listViewProcess.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colHeadNameProsecc});
			this.listViewProcess.GridLines = true;
			this.listViewProcess.HideSelection = false;
			this.listViewProcess.Location = new System.Drawing.Point(12, 84);
			this.listViewProcess.MultiSelect = false;
			this.listViewProcess.Name = "listViewProcess";
			this.listViewProcess.Size = new System.Drawing.Size(407, 354);
			this.listViewProcess.TabIndex = 2;
			this.listViewProcess.UseCompatibleStateImageBehavior = false;
			this.listViewProcess.View = System.Windows.Forms.View.Details;
			// 
			// colHeadNameProsecc
			// 
			this.colHeadNameProsecc.Text = "Name prosecce";
			this.colHeadNameProsecc.Width = 500;
			// 
			// lableProcess
			// 
			this.lableProcess.AutoSize = true;
			this.lableProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lableProcess.Location = new System.Drawing.Point(260, 18);
			this.lableProcess.Name = "lableProcess";
			this.lableProcess.Size = new System.Drawing.Size(0, 26);
			this.lableProcess.TabIndex = 3;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(439, 450);
			this.Controls.Add(this.lableProcess);
			this.Controls.Add(this.listViewProcess);
			this.Controls.Add(this.btnStop);
			this.Controls.Add(this.btnRefrech);
			this.Name = "MainForm";
			this.Text = "Manager";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnRefrech;
		private System.Windows.Forms.Button btnStop;
		private System.Windows.Forms.ListView listViewProcess;
		private System.Windows.Forms.ColumnHeader colHeadNameProsecc;
		private System.Windows.Forms.Label lableProcess;
	}
}

