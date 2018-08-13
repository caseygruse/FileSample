namespace FileSample
{
	partial class Form1
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
			this.label1 = new System.Windows.Forms.Label();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnLoadSchedule = new System.Windows.Forms.Button();
			this.btnAddCourse = new System.Windows.Forms.Button();
			this.txtEnterCourse = new System.Windows.Forms.TextBox();
			this.lstSchedule = new System.Windows.Forms.ListBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(99, 85);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(68, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Enter Course";
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(430, 204);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(122, 37);
			this.btnSave.TabIndex = 1;
			this.btnSave.Text = "Save Schedule";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// btnLoadSchedule
			// 
			this.btnLoadSchedule.Location = new System.Drawing.Point(430, 268);
			this.btnLoadSchedule.Name = "btnLoadSchedule";
			this.btnLoadSchedule.Size = new System.Drawing.Size(122, 39);
			this.btnLoadSchedule.TabIndex = 2;
			this.btnLoadSchedule.Text = "Load Schedule";
			this.btnLoadSchedule.UseVisualStyleBackColor = true;
			this.btnLoadSchedule.Click += new System.EventHandler(this.btnLoadSchedule_Click);
			// 
			// btnAddCourse
			// 
			this.btnAddCourse.Location = new System.Drawing.Point(411, 85);
			this.btnAddCourse.Name = "btnAddCourse";
			this.btnAddCourse.Size = new System.Drawing.Size(141, 39);
			this.btnAddCourse.TabIndex = 3;
			this.btnAddCourse.Text = "Add Course";
			this.btnAddCourse.UseVisualStyleBackColor = true;
			this.btnAddCourse.Click += new System.EventHandler(this.btnAddCourse_Click);
			// 
			// txtEnterCourse
			// 
			this.txtEnterCourse.Location = new System.Drawing.Point(227, 85);
			this.txtEnterCourse.Name = "txtEnterCourse";
			this.txtEnterCourse.Size = new System.Drawing.Size(135, 20);
			this.txtEnterCourse.TabIndex = 4;
			// 
			// lstSchedule
			// 
			this.lstSchedule.FormattingEnabled = true;
			this.lstSchedule.Location = new System.Drawing.Point(102, 160);
			this.lstSchedule.Name = "lstSchedule";
			this.lstSchedule.Size = new System.Drawing.Size(303, 147);
			this.lstSchedule.TabIndex = 5;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.lstSchedule);
			this.Controls.Add(this.txtEnterCourse);
			this.Controls.Add(this.btnAddCourse);
			this.Controls.Add(this.btnLoadSchedule);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnLoadSchedule;
		private System.Windows.Forms.Button btnAddCourse;
		private System.Windows.Forms.TextBox txtEnterCourse;
		private System.Windows.Forms.ListBox lstSchedule;
	}
}

