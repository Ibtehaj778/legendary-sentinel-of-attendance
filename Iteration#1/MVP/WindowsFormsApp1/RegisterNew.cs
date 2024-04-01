using System;
using Emgu.CV;
using Emgu.CV.UI;
using Emgu.CV.Structure;
using Emgu.CV.Face;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FaceRecognition;



namespace WindowsFormsApp1
{
    public partial class RegisterNew : UserControl
	{
		public Capture _capture;
        public RegisterNew()
		{
			InitializeComponent();
			button3.Enabled = false;
			button10.Enabled = false;
		}
		FaceRec faceRec = new FaceRec();
		char ctr = '1';

		private void label5_Click(object sender, EventArgs e)
		{

		}

		private void RegisterNew_Load(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			faceRec.openCamera(pictureBox1, pictureBox2);
			pictureBox2.Hide();
			_capture = new Capture();
            _capture.Start();

            richTextBox1.Enabled = true;
			button3.Enabled = true;
			button10.Enabled = true;
		}

		private void richTextBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void button3_Click(object sender, EventArgs e)
		{
			if (richTextBox1.Text == "")
			{
				label3.Text = "Image Failed";
				MessageBox.Show("Image Failed");
				return;
			}


			faceRec.Save_IMAGE(richTextBox1.Text + "(" + ctr + ")");
			label3.Text = "Image Saved Succesfully: " + ctr + "/8";
			ctr++;
			if (ctr == '9')
			{
				ctr = '1';
			}
		}

		private void button10_Click(object sender, EventArgs e)
		{
			faceRec.Dispose();
		}
	}
}
