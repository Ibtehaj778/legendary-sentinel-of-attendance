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
using FaceRecognition;



namespace WindowsFormsApp1
{
	public partial class RegisterNew : UserControl
	{
		public RegisterNew()
		{
			InitializeComponent();
			button3.Enabled = false;
			button10.Enabled = false;
			label2.Text = "";

		}
		FaceRec faceRec = new FaceRec();
		char ctr = '1';

		private void button1_Click(object sender, EventArgs e)
		{
			faceRec.openCamera(pictureBox1, pictureBox2);
			pictureBox2.Hide();

			richTextBox1.Enabled = true;
			button3.Enabled = true;
			button10.Enabled = true;
		}


		private void button3_Click(object sender, EventArgs e)
		{
			if (richTextBox1.Text.Length != 4 || richTextBox2.Text == "" || richTextBox3.Text == "")
			{
				label3.Text = "Image Failed";
				MessageBox.Show("Image failed due to invalid data");
				return;
			}


			faceRec.Save_IMAGE(domainUpDown2.Text + numericUpDown3.Value.ToString() + richTextBox1.Text + "(" + ctr + ")");
			label3.Text = "Image Saved Succesfully: " + ctr + "/8";
			ctr++;
			if (ctr == '9')
			{
				MessageBox.Show("Maximum Images Added (Keep on clicking if you need to retake images)");
				ctr = '1';
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


		private void button10_Click(object sender, EventArgs e)
		{

			if (richTextBox1.Text.Length == 4 || richTextBox2.Text != "" || richTextBox3.Text != "")
			{
				string what_to_store = domainUpDown2.Text + numericUpDown3.Value.ToString() + richTextBox1.Text + ",";
				what_to_store = what_to_store + richTextBox2.Text + ",";
				what_to_store = what_to_store + richTextBox3.Text + ",";
				what_to_store = what_to_store + domainUpDown1.Text + "-" + numericUpDown1.Value.ToString() + ",";
				what_to_store = what_to_store + numericUpDown2.Value.ToString() + ",";
				what_to_store = what_to_store + "Overall Attendance,0,0,0,0,0";

				string fp = Path.Combine(Application.StartupPath, "Student.txt");


				List<List<object>> csvData = ReadCSVFile(fp);
				try
				{
					bool isadded = false;
					foreach (List<object> row in csvData)
					{
						if ((string)row[0] == (domainUpDown2.Text + numericUpDown3.Value.ToString() + richTextBox1.Text))
						{
							MessageBox.Show("student already registered!!!");
							isadded = true;
						}
					}
					if (!isadded)
					{
						try
						{
							using (StreamWriter writer = new StreamWriter(fp, true))
							{
								writer.WriteLine(what_to_store);
							}
							MessageBox.Show("Student registered successfully!");
						}
						catch (Exception ex)
						{
							MessageBox.Show("Error registering student: " + ex.Message);
						}
					}

				}
				catch (Exception ex)
				{
				}
			}
			else
			{
				MessageBox.Show("Invalid Data\n1. Roll=4 Digits\n2. Names>1 Letter");
			}
		}
	}
}
