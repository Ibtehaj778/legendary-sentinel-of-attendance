using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FaceRecognition;
using System.Runtime.InteropServices;
using System.IO;
using System.Web.UI.Design.WebControls;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
	public partial class Attendancepp : UserControl
	{
		public Attendancepp()
		{
			InitializeComponent();
			button3.Enabled = false;
			button10.Enabled = false;
		}
		FaceRec faceRec = new FaceRec();
		char ctr = '1';

		private void button1_Click(object sender, EventArgs e)
		{
			faceRec.openCamera(pictureBox1, pictureBox2);
			button10.Enabled = true;
			button1.Enabled = false;
			faceRec.isTrained = true;
			if (faceRec.Name == null)
			{
				label3.Text = "Image Name is NULL";
				return;
			}

			faceRec.getPersonName(label3);
			faceRec.Dispose();
		}

		string roll = "";
		public string teacher_registered_sections = "";
		private void button3_Click(object sender, EventArgs e)
		{
			try
			{
				if (comboBox1.SelectedItem == null)
				{
					MessageBox.Show("Please select a section.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
					return;
				}

				if (comboBox2.SelectedItem == null)
				{
					MessageBox.Show("Please select a subject.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
					return;
				}

				string selectedSection = comboBox1.SelectedItem.ToString();

				List<string> registeredSections = teacher_registered_sections.Split(';').ToList();

				if (!registeredSections.Contains(selectedSection))
				{
					MessageBox.Show("You are not registered to mark attendance for this section.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}

				string selectedSubject = comboBox2.SelectedItem.ToString();

				string currentDate = DateTime.Now.ToString("yyyy-MM-dd");

				string filePath = Path.Combine(Application.StartupPath, $"{currentDate}.csv");

				bool fileExists = File.Exists(filePath);

				if (!fileExists)
				{
					using (StreamWriter sw = new StreamWriter(filePath))
					{
						sw.WriteLine("Roll,Section,Subject,Present");
					}
				}

				List<List<object>> csvData = ReadCSVFile(filePath);
				foreach (List<object> row in csvData)
				{
					if ((string)row[0] == roll && (string)row[1] == selectedSection)
					{
						MessageBox.Show("Student with the same section is already marked.", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						return;
					}
				}

				using (StreamWriter sw = new StreamWriter(filePath, true))
				{
					sw.WriteLine($"{roll},{selectedSection},{selectedSubject},P");
				}

				MessageBox.Show("Attendance marked successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}



		private void button10_Click(object sender, EventArgs e)
		{
			if (label3.Text.Length > 3)
			{
				string temp = label3.Text.Substring(0, label3.Text.Length - 3);
				label4.Text = "Roll Number: " + temp;
				roll = temp;
				fetchdetails(temp);
			}
			pictureBox1.Enabled = false;



			faceRec.Dispose();

		}

		public void fetchdetails(string roll)
		{

			string fp = Path.Combine(Application.StartupPath, "Student.txt");


			List<List<object>> csvData = ReadCSVFile(fp);
			try
			{
				bool isadded = false;
				foreach (List<object> row in csvData)
				{
					if ((string)row[0] == roll)
					{
						label4.Text = "Roll Number: " + row[0];
						label5.Text = "Name: " + row[1];
						label6.Text = "Father Name: " + row[2];
						label7.Text = "Batch: " + row[3];
						label8.Text = "CGPA: " + row[4];
						isadded = true;


						chart1.Series.Add((string)row[5]);

						chart1.Series[(string)row[5]].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line; // Set the chart type to line
						chart1.Series[(string)row[5]].BorderWidth = 5;
						chart1.Series[(string)row[5]].Color = Color.Green;
						chart1.Series[(string)row[5]].Points.AddXY("January", Convert.ToDouble(row[6]));
						chart1.Series[(string)row[5]].Points.AddXY("February", Convert.ToDouble(row[7]));
						chart1.Series[(string)row[5]].Points.AddXY("March", Convert.ToDouble(row[8]));
						chart1.Series[(string)row[5]].Points.AddXY("April", Convert.ToDouble(row[9]));
						chart1.Series[(string)row[5]].Points.AddXY("May", Convert.ToDouble(row[10]));

					}
				}
				if (!isadded)
					MessageBox.Show("Student Data Missing in StudentData!!");
				else
					button3.Enabled = true;

			}
			catch (Exception ex)
			{
			}

		}


		static List<List<object>> ReadCSVFile(string filePath)
		{
			List<List<object>> data = new List<List<object>>();

			try
			{
				using (StreamReader reader = new StreamReader(filePath))
				{
					string line;
					while ((line = reader.ReadLine()) != null)
					{
						string[] values = line.Split(',');

						List<object> row = new List<object>();
						foreach (string value in values)
						{
							row.Add(value.Trim());
						}

						data.Add(row);
					}
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine("Error reading file: " + ex.Message);
			}
			return data;
		}

	}
}
