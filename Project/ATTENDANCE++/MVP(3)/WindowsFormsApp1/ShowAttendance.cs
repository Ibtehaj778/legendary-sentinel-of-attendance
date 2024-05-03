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
	public partial class ShowAttendance : UserControl
	{
		public ShowAttendance()
		{
			InitializeComponent();
			
		}

		private void button1_Click(object sender, EventArgs e)
		{
			string studentName = "Student1";
			string attendanceStatus = "P";

			int rowIndex = dataGridView1.Rows.Add();

			dataGridView1.Rows[rowIndex].Cells[0].Value = studentName;
			dataGridView1.Rows[rowIndex].Cells[1].Value = attendanceStatus;
		}

		private void Subject_SelectedItemChanged(object sender, EventArgs e)
		{

		}

		private void ShowAttendance_Load(object sender, EventArgs e)
		{

		}
	}
}
