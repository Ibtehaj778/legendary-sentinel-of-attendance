using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;


namespace WindowsFormsApp1
{


    public partial class Authenticator : UserControl
    {
        public bool isPassed = false;
        public Authenticator()
        {
            InitializeComponent();
		}

        public string password = "";
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
        private bool Authenticate(string username, string password)
        {
            string filePath = Path.Combine(Application.StartupPath, "Credentials.txt");
            List<List<object>> csvData = ReadCSVFile(filePath);
            try
            {
                foreach (List<object> row in csvData)
                {
                    if ((string)row[0] == username && (string)row[1] == password)
                    {
                        return true;

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid Address or Whatever");
            }
            return false;
        }

        public bool isSave()
        {
            return checkBox1.Checked; 
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string username = richTextBox1.Text;
            string password = richTextBox2.Text;
            if (Authenticate(username, password))
            {
                this.Hide();
                isPassed = true;
                
            }
            else
            {
                MessageBox.Show("Incorrect Password/ID");
            }
        }

        public void reset()
        {
            this.isPassed = false;
            this.richTextBox1.Text = "";
            this.richTextBox2.Text = "";
        }

    }
}
