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


namespace WindowsFormsApp1
{


	public partial class Authenticator : UserControl
	{
		public bool isPassed = false;
		public Authenticator()
		{
			InitializeComponent();
		}

        private void label1_Click(object sender, EventArgs e)
		{

		}


        private void button1_Click(object sender, EventArgs e)
		{
			if (richTextBox1.Text == "Admin" && richTextBox2.Text == "Admin123")
			{
				this.Hide();
				
				isPassed = true;
			}
			else
			{
				MessageBox.Show("Incorrect Password/ID");
			}
		}

		private void richTextBox1_TextChanged(object sender, EventArgs e)
		{

		}
		private void reset(object sender, EventArgs e)
		{
			this.isPassed = false;
			this.richTextBox1.Text = "";
			this.richTextBox2.Text = "";
		}


        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

			
		}

        private void richTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
	
		}
    }
}
