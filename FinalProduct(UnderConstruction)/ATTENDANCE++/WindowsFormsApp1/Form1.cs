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
        
        public Form1()
        {
            InitializeComponent();
			registerNew1.Hide();
			attendancepp2.Hide();
            panel1.Hide();
			authenticator1.Show();
            
		}


        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void button4_Click(object sender, EventArgs e)
		{
			if (authenticator1.isPassed == true)
			{
				registerNew1.Hide();
				attendancepp2.Hide();
				authenticator1.Hide();
				registerNew2.Show();
                panel1.Show();
            }
			else
			{
				MessageBox.Show("Authentication Uncleared");
			}
		}

		private void registerNew1_Load(object sender, EventArgs e)
		{

		}

		private void button8_Click(object sender, EventArgs e)
		{
			if(authenticator1.isPassed == true)
			{
				registerNew1.Hide();
				attendancepp2.Hide();
				authenticator1.Hide();
				attendancepp1.Show(); panel1.Show();
            }
			else
			{
				MessageBox.Show("Authentication Uncleared");
			}
		}


		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void attendancepp1_Load(object sender, EventArgs e)
		{

		}

		private void attendancepp1_Load_1(object sender, EventArgs e)
		{

		}

		private void registerNew2_Load(object sender, EventArgs e)
		{

		}

		private void button4_Click_1(object sender, EventArgs e)
		{
			if (authenticator1.isPassed == true)
			{
				registerNew2.Hide();
				attendancepp2.Hide();
				authenticator1.Hide();
				registerNew2.Show(); panel1.Show();
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
				registerNew2.Hide();
				attendancepp2.Hide();
				authenticator1.Hide();
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
				registerNew2.Hide();
				attendancepp2.Hide();
				authenticator1.Show();
				authenticator1.ResetText();
				authenticator1.isPassed = false;
                panel1.Hide();
            }
			else
			{
				MessageBox.Show("Authentication Uncleared");
			}

		}

		private void authenticator1_Load(object sender, EventArgs e)
		{

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
    }
}

