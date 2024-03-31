using System;
using System.Collections.Generic;
using System.ComponentModel;
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
	public partial class Attendancepp : UserControl
	{
		public Attendancepp()
		{
			InitializeComponent();
		}
		FaceRec faceRec = new FaceRec();
		char ctr = '1';

		private void button1_Click(object sender, EventArgs e)
		{
			faceRec.openCamera(pictureBox1, pictureBox2);
			button3.Enabled = true;
		}


		private void button3_Click(object sender, EventArgs e)
		{
			faceRec.isTrained = true;
			if (faceRec.Name == null)
			{
				label3.Text = "Image Name is NULL";
				return;
			}

			faceRec.getPersonName(label3);
			button1.Enabled = false;
			button3.Enabled = false;
		}

		private void button10_Click(object sender, EventArgs e)
		{
			if (label3.Text.Length > 3)
				label4.Text = "Roll Number: " + label3.Text.Substring(0, label3.Text.Length - 3);
			pictureBox1.Enabled = false;
			faceRec.Dispose();

			button1.Enabled = true;
		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void Attendancepp_Load(object sender, EventArgs e)
		{

		}
	}
}
