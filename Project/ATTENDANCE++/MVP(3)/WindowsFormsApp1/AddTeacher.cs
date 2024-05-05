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

namespace WindowsFormsApp1
{
	public partial class AddTeacher : UserControl
	{
		public AddTeacher()
		{
			InitializeComponent();
		}

		private void label7_Click(object sender, EventArgs e)
		{

		}

		private void label8_Click(object sender, EventArgs e)
		{

		}

		private void button10_Click(object sender, EventArgs e)
		{
			if (richTextBox1.Text.Length != 4 || richTextBox10.Text.Length<8 ||
				 richTextBox3.Text.Length < 1 || richTextBox4.Text.Length < 1 ||
				  richTextBox5.Text.Length != 5 || richTextBox6.Text.Length != 7 
				  || richTextBox7.Text.Length != 1 || richTextBox8.Text.Length < 1
				  || richTextBox9.Text.Length <= 1)
			{
				MessageBox.Show("Invalid Data. \n1. ID=4 Digits\n2. Password>8 Digits\n3. CNIC=13 Digit");
				return;
			}

			string username = domainUpDown2.Text + numericUpDown3.Value.ToString() + richTextBox1.Text;
			string password = richTextBox10.Text;

			string what_to_store = '\n' + username;


			string fp = Path.Combine(Application.StartupPath, "Credentials.txt");


			List<List<object>> csvData = ReadCSVFile(fp);
			try
			{
				bool isadded = false;
				foreach (List<object> row in csvData)
				{
					if ((string)row[0] == username)
					{
						MessageBox.Show("Teacher with same ID already registered \n1. Change TeaceherID\n2. Contact Admin");
						return;
						isadded = true;
					}
				}
				if (!isadded)
				{
					try
					{
						using (StreamWriter writer = new StreamWriter(fp, true))
						{
							writer.WriteLine(username + ',' + password);
						}
						MessageBox.Show("Teacher registered successfully!");
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

			fp = Path.Combine(Application.StartupPath, "Graphs.txt");
			try
			{
				using (StreamWriter writer = new StreamWriter(fp, true))
				{
					writer.WriteLine(username + ",No Sub Added,0,0,0,0,0");
				}
			}
			catch (Exception ex)
			{
			}

			fp = Path.Combine(Application.StartupPath, "Teachers.txt");
			//Emma Brown, Admin, Brown, emma.brown@example.com,246810 - 1357924 - 8,08 / 05 / 1996,Computer Science, BDS-2A; BDS - 5C; BCS - 6A

			what_to_store =  richTextBox2.Text + ',' + username + ',' + richTextBox3.Text + ',' + richTextBox4.Text + "@lhr.nu.edu.pk," + richTextBox5.Text + '-' + richTextBox6.Text + '-' + richTextBox7.Text + ',' + dateTimePicker1.Text + ',' + richTextBox8.Text + ',' + richTextBox9.Text;
			
			try
			{
				using (StreamWriter writer = new StreamWriter(fp, true))
				{
					writer.WriteLine(what_to_store);
				}
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
