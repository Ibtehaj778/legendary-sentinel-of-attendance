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

            textBox1.Multiline = true;
            textBox1.Height = 32;
            textBox1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
        }
        FaceRec faceRec = new FaceRec();
		char ctr = '1';
		private void button1_Click(object sender, EventArgs e)
		{
			faceRec.openCamera(pictureBox1, pictureBox2);
			textBox1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
        }

		private void button2_Click(object sender, EventArgs e)
		{
			if (textBox1.Text == null)
			{
				label3.Text = "Image Failed";
				return;
			}


            faceRec.Save_IMAGE(textBox1.Text + ctr);
			label3.Text = "Image Saved Succesfully: " + ctr;
			ctr++;
			if (ctr == '9')
			{
				ctr = '1';
			}
        }
		private void button3_Click(object sender, EventArgs e)
		{
			faceRec.isTrained = true;
			if (faceRec.Name == null)
			{
				label3.Text = "Image Name is NULL";
				return;
			}

			faceRec.getPersonName(this); // Assuming you want to display the name on the form itself
										 // Display the form's name in label3
			label3.Text = "Form Name: " + this.Text;
			this.Text = "ATTENDANCE++";

			textBox1.Enabled = false;
		}



		private void label2_Click(object sender, EventArgs e)
		{

		}

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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
    }
}

