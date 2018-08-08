using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileSample
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		//1. to make an installer you go to build menue
		//2. click publish and add a \"fileNameOfSomeKind".
		//


		private void btnAddCourse_Click(object sender, EventArgs e)
		{
			// add course from text box to list
			lstSchedule.Items.Add(txtEnterCourse.Text);
			//clears text box after you add the course.
			txtEnterCourse.Clear();
			//puts the cursor on the text box.
			txtEnterCourse.Focus();
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			//SaveScheduleBasic();
			SaveBasic();
			MessageBox.Show("Data was saved");
		}

		private void SaveBasic()
		{
			
			SaveFileDialog save = new SaveFileDialog();

			save.Filter = "Data File|*.data";
			save.RestoreDirectory = true;
			if(save.ShowDialog() == DialogResult.OK)
			{
				string path = save.FileName;
				if (path == string.Empty)
					return;
				File.WriteAllText(path, "Test data here....");
			}
			
		}

		private void SaveScheduleBasic()
		{
			//creating a string for all the courses for file input.
			StringBuilder data = new StringBuilder();
			//loops through lstSchedule items and uses string builder to concatenate the strings.
			for (int i = 0; i < lstSchedule.Items.Count; i++)
			{
				data.AppendLine(lstSchedule.Items[i].ToString());
			}

			string folder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
			//the path I want the text to be saved
			//string path = @"c:\test.txt";

			string path = folder + "\\test.data";
			//puts the string into a file with the path name (path) that is above.
			File.WriteAllText(path, data.ToString());
		}
	}
}
