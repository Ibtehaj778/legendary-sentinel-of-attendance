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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
	public partial class ShowAttendance : UserControl
	{
		public ShowAttendance()
		{
			InitializeComponent();
			
		}

		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				string selectedDate = dateTimePicker1.Value.ToString("yyyy-MM-dd");
				string filePath = Path.Combine(Application.StartupPath, $"{selectedDate}.csv");

				bool fileExists = File.Exists(filePath);

				if (!fileExists)
				{
					MessageBox.Show("Attendance data for the selected date does not exist.", "No Data Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
					return;
				}

				dataGridView1.Rows.Clear();

				List<List<object>> csvData = ReadCSVFile(filePath);

				if (csvData.Count > 0)
				{
					csvData.RemoveAt(0);
				}
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
				string selectedSubject = comboBox2.SelectedItem.ToString();

				foreach (List<object> row in csvData)
				{
					if ((string)row[1] == selectedSection && (string)row[2] == selectedSubject)
					{
						int rowIndex = dataGridView1.Rows.Add();

						dataGridView1.Rows[rowIndex].Cells["RollNumber"].Value = row[0].ToString();
						dataGridView1.Rows[rowIndex].Cells["AttendanceStatus"].Value = row[3].ToString();
					}
				}

				MessageBox.Show("Attendance data loaded successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
