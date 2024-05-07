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
    public partial class Attendance_Graph : UserControl
    {
        public Attendance_Graph()
        {
            InitializeComponent();
			
		}


        public void formgraph(string teacherID)
        {
            string fp = Path.Combine(Application.StartupPath, "Graphs.txt");

            List<List<object>> csvData = ReadCSVFile(fp);

            try
            {

                foreach (List<object> row in csvData)
                {
                    if ((string)row[0] == teacherID)
                    {
                        chart1.Series.Add((string)row[1]);
                        chart1.Series[(string)row[1]].Points.AddXY("January", (string)row[2]);
                        chart1.Series[(string)row[1]].Points.AddXY("February", (string)row[3]);
                        chart1.Series[(string)row[1]].Points.AddXY("March", (string)row[4]);
                        chart1.Series[(string)row[1]].Points.AddXY("April", (string)row[5]);
                        chart1.Series[(string)row[1]].Points.AddXY("May", (string)row[6]);
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
