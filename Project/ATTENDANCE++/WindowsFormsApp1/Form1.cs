﻿using System;
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
			registerNew2.Hide();
			attendancepp1.Hide();
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
				registerNew2.Hide();
				attendancepp1.Hide();
				authenticator1.Hide();
				registerNew2.Show();
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
				registerNew2.Hide();
				attendancepp1.Hide();
				authenticator1.Hide();
				attendancepp1.Show();
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
				attendancepp1.Hide();
				authenticator1.Hide();
				registerNew2.Show();
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
				attendancepp1.Hide();
				authenticator1.Hide();
				attendancepp1.Show();
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
				attendancepp1.Hide();
				authenticator1.Show();
				authenticator1.ResetText();
				authenticator1.isPassed = false;
			}
			else
			{
				MessageBox.Show("Authentication Uncleared");
			}

		}

		private void authenticator1_Load(object sender, EventArgs e)
		{

		}
	}
}

