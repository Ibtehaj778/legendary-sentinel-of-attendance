using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
			chart1.Series["COAL"].Points.AddXY("January", "12");
			chart1.Series["COAL"].Points.AddXY("February", "18");
			chart1.Series["COAL"].Points.AddXY("March", "28");
			chart1.Series["COAL"].Points.AddXY("April", "28");
			chart1.Series["COAL"].Points.AddXY("May", "25");

			chart1.Series["DSA"].Points.AddXY("January", "9");
			chart1.Series["DSA"].Points.AddXY("February", "23");
			chart1.Series["DSA"].Points.AddXY("March", "25");
			chart1.Series["DSA"].Points.AddXY("April", "22");
			chart1.Series["DSA"].Points.AddXY("May", "21");
		}

		private void chart1_Click(object sender, EventArgs e)
		{

		}

		private void chart1_Click_1(object sender, EventArgs e)
		{

		}
	}
}
