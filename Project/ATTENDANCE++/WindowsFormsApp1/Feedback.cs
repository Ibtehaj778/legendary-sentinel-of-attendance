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
    public partial class Feedback : UserControl
    {
        public string username = "temp";

		public Feedback()
        {
            InitializeComponent();
            get_feedbacks();
        }


		private void button1_Click(object sender, EventArgs e)
		{
            if (richTextBox1.Text == "")
            {
                MessageBox.Show("No feedback entered to submit");
                return; 
            }
            label1.Text = label2.Text;
            label2.Text = label3.Text;
            label3.Text = label4.Text;
            label4.Text = label5.Text;
            label5.Text = label6.Text;
            if (checkBox1.Checked) label6.Text = "Anonymous: " + richTextBox1.Text;
            else label6.Text = username + ": " + richTextBox1.Text;
            store();
            richTextBox1.Text = "";
		}
        void store()
        {
            string filePath = Path.Combine(Application.StartupPath, "Feedback.txt");
            StreamWriter writer = new StreamWriter(filePath);

            writer.WriteLine(label1.Text);
            writer.WriteLine(label2.Text);
            writer.WriteLine(label3.Text);
            writer.WriteLine(label4.Text);
            writer.WriteLine(label5.Text);
            writer.WriteLine(label6.Text);

            writer.Close();
        }


        static List<object> ReadCSVFile(string filePath)
        {
            List<object> data = new List<object>();

            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        data.Add(line);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error reading file: " + ex.Message);
            }

            return data;
        }
        void get_feedbacks()
        {
            string filePath = Path.Combine(Application.StartupPath, "Feedback.txt");
            List<object> csvData = ReadCSVFile(filePath);
            try
            {
                label1.Text = csvData[0].ToString();
                label2.Text = csvData[1].ToString();
                label3.Text = csvData[2].ToString();
                label4.Text = csvData[3].ToString();
                label5.Text = csvData[4].ToString();
                label6.Text = csvData[5].ToString();
            }
            catch (Exception ex)
            {
            }

        }

	}
}
