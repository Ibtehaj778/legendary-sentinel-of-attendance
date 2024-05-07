using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FaceRecognition;
using System.Runtime.InteropServices;



namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
		public string teacherID;

        public Form1()
        {
            InitializeComponent();
			showAttendance1.Hide();
			registerNew1.Hide();
			dashboard1.Hide();
			attendancepp1.Hide();
			attendancepp2.Hide();
			panel1.Hide();
			attendance_Graph1.Hide();
			authenticator1.Hide();
            feedback1.Hide();
			addTeacher1.Hide();
            authenticator1.Show();
			dashboard1.label10.Text = authenticator1.richTextBox1.Text;
            label1.Text = (DateTime.Now.ToString()).Substring(0, 10);

		}

		private void button7_Click(object sender, EventArgs e)
        {
            if (authenticator1.isPassed == true)
            {
                dashboard1.label10.Text = authenticator1.richTextBox1.Text;
                dashboard1.fetchdetails();
				showAttendance1.Hide();
				dashboard1.Hide();
                registerNew1.Hide();
                attendancepp1.Hide();
                attendancepp2.Hide();
                panel1.Hide();
                registerNew2.Hide();
                attendance_Graph1.Hide();
                authenticator1.Hide(); 
				feedback1.Hide();
				addTeacher1.Hide();
				dashboard1.Show();
                panel1.Show();
            }
            else
            {
                MessageBox.Show("Authentication Uncleared");
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
		{
			if (authenticator1.isPassed == true)
			{
                dashboard1.label10.Text = authenticator1.richTextBox1.Text;
                dashboard1.Hide();
				showAttendance1.Hide();
				registerNew1.Hide();
                attendancepp1.Hide();
                attendancepp2.Hide();
                panel1.Hide();
                registerNew2.Hide();
                attendance_Graph1.Hide();
                authenticator1.Hide();
				feedback1.Hide();
				addTeacher1.Hide();
				registerNew2.Show(); 
				panel1.Show();
            }
			else
			{
				MessageBox.Show("Authentication Uncleared");
			}
		}

		private void button8_Click_1(object sender, EventArgs e)
		{
			if (authenticator1.isPassed == true)
			{
                dashboard1.label10.Text = authenticator1.richTextBox1.Text;
                dashboard1.Hide();
				showAttendance1.Hide();
				registerNew1.Hide();
                attendancepp1.Hide();
                attendancepp2.Hide();
                panel1.Hide();
                registerNew2.Hide();
                attendance_Graph1.Hide();
                authenticator1.Hide();
				feedback1.Hide();
				addTeacher1.Hide();
				attendancepp1.teacher_registered_sections = dashboard1.label16.Text;
				attendancepp1.Show(); 
				panel1.Show();
            }
			else
			{
				MessageBox.Show("Authentication Uncleared");
			}
		}

		private void button11_Click(object sender, EventArgs e)
		{
			if (authenticator1.isPassed == true)
			{
                dashboard1.label10.Text = authenticator1.richTextBox1.Text;
                dashboard1.Hide();
				showAttendance1.Hide();
				registerNew1.Hide();
                attendancepp1.Hide();
                attendancepp2.Hide();
                panel1.Hide();
                registerNew2.Hide();
                attendance_Graph1.Hide();
                authenticator1.Hide();
				feedback1.Hide();
				addTeacher1.Hide();
				authenticator1.Show();
				authenticator1.isPassed = false;

				if (!authenticator1.isSave())
				{
					authenticator1.reset();
				}

				button1.Text = "OpenMenu";
                attendance_Graph1.chart1.Series.Clear();
            }
			else
			{
				MessageBox.Show("Authentication Uncleared");
			}

		}


        private void button1_Click(object sender, EventArgs e)
        {
			if (button1.Text == "OpenMenu" && authenticator1.isPassed == true)
			{
				panel1.Show();
				button1.Text = "HideMenu";
			}
			else if (button1.Text == "HideMenu" && authenticator1.isPassed == true)
			{
				panel1.Hide();
				button1.Text = "OpenMenu";
			}
			else
            {
				MessageBox.Show("Authentication Unclear");
            }
        }

		private void button6_Click(object sender, EventArgs e)
		{
			if (authenticator1.isPassed == true)
			{
                dashboard1.label10.Text = authenticator1.richTextBox1.Text;
                attendance_Graph1.formgraph(dashboard1.label10.Text);
                dashboard1.Hide();
				showAttendance1.Hide();
				registerNew1.Hide();
                attendancepp1.Hide();
                attendancepp2.Hide();
                panel1.Hide();
                registerNew2.Hide();
                attendance_Graph1.Hide();
                authenticator1.Hide();
				feedback1.Hide();
				addTeacher1.Hide();
				attendance_Graph1.Show();
				panel1.Show();
			}
			else
			{
				MessageBox.Show("Authentication Uncleared");
			}
		}

		private void button9_Click(object sender, EventArgs e)
		{
			dashboard1.label10.Text = authenticator1.richTextBox1.Text;
			dashboard1.Hide();
			registerNew1.Hide();
			showAttendance1.Hide();
			attendancepp1.Hide();
			attendancepp2.Hide();
			panel1.Hide();
			registerNew2.Hide();
			attendance_Graph1.Hide();
			authenticator1.Hide();
			addTeacher1.Hide();
			feedback1.Show();
			feedback1.username = authenticator1.richTextBox1.Text;
			panel1.Show();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			if (authenticator1.isPassed == true)
			{
				dashboard1.label10.Text = authenticator1.richTextBox1.Text;
				attendance_Graph1.formgraph(dashboard1.label10.Text);
				dashboard1.Hide();
				registerNew1.Hide();
				attendancepp1.Hide();
				attendancepp2.Hide();
				panel1.Hide();
				showAttendance1.Hide();
				registerNew2.Hide();
				attendance_Graph1.Hide();
				authenticator1.Hide();
				feedback1.Hide();
				addTeacher1.Show();
				panel1.Show();
			}
			else
			{
				MessageBox.Show("Authentication Uncleared");
			}
		}

		private void button3_Click(object sender, EventArgs e)
		{
			if (authenticator1.isPassed == true)
			{
				dashboard1.Hide();
				addTeacher1.Hide();
				registerNew1.Hide();
				attendancepp1.Hide();
				attendancepp2.Hide();
				panel1.Hide();
				showAttendance1.Hide();
				registerNew2.Hide();
				attendance_Graph1.Hide();
				authenticator1.Hide();
				feedback1.Hide();
				showAttendance1.Show();
				panel1.Show();
			}
			else
			{
				MessageBox.Show("Authentication Uncleared");
			}
		}
	}
}

