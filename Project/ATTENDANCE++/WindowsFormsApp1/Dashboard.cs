using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Dashboard : UserControl
    {
        public string username; 
        public Dashboard()
        {
            InitializeComponent();
            username = label10.Text;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        public void fetchdetails()
        {
            
            string fp = Path.Combine(Application.StartupPath, "Teachers.txt");

            List<List<object>> csvData = ReadCSVFile(fp);

            try
            {
                foreach (List<object> row in csvData)
                {
                    if ((string)row[1] == label10.Text)
                    {
                        label9.Text = row[0].ToString();
                        label10.Text = row[1].ToString();
                        label11.Text = row[2].ToString();
                        label12.Text = row[3].ToString();
                        label13.Text = row[4].ToString();
                        label14.Text = row[5].ToString();
                        label15.Text = row[6].ToString();
                        label16.Text = row[7].ToString();
                    }


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
