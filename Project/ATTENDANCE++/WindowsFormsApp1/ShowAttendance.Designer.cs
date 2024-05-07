namespace WindowsFormsApp1
{
	partial class ShowAttendance
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			
			this.label10 = new System.Windows.Forms.Label();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.AttendanceStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.RollNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.button1 = new System.Windows.Forms.Button();
			comboBox2 = new System.Windows.Forms.ComboBox();
			comboBox1 = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(13, 7);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(234, 23);
			this.label10.TabIndex = 13;
			this.label10.Text = "CHECK ATTENDANCE";
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dateTimePicker1.Location = new System.Drawing.Point(18, 87);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(369, 31);
			this.dateTimePicker1.TabIndex = 16;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.dataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Lucida Fax", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AttendanceStatus,
            this.RollNumber});
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Lucida Fax", 10.8F);
			dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
			this.dataGridView1.Location = new System.Drawing.Point(17, 124);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Lucida Fax", 10.8F);
			dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
			this.dataGridView1.RowHeadersWidth = 51;
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Lucida Fax", 10.8F, System.Drawing.FontStyle.Bold);
			this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle6;
			this.dataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Lucida Fax", 10.8F, System.Drawing.FontStyle.Bold);
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.dataGridView1.Size = new System.Drawing.Size(712, 318);
			this.dataGridView1.TabIndex = 19;
			// 
			// AttendanceStatus
			// 
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.AttendanceStatus.DefaultCellStyle = dataGridViewCellStyle2;
			this.AttendanceStatus.HeaderText = "Attendance Status";
			this.AttendanceStatus.MinimumWidth = 270;
			this.AttendanceStatus.Name = "AttendanceStatus";
			this.AttendanceStatus.ReadOnly = true;
			this.AttendanceStatus.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.AttendanceStatus.Width = 300;
			// 
			// RollNumber
			// 
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.RollNumber.DefaultCellStyle = dataGridViewCellStyle3;
			this.RollNumber.HeaderText = "Roll Number(s)";
			this.RollNumber.MinimumWidth = 270;
			this.RollNumber.Name = "RollNumber";
			this.RollNumber.ReadOnly = true;
			this.RollNumber.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.RollNumber.Width = 270;
			// 
			// button1
			// 
			this.button1.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Screenshot_2024_03_25_115940;
			this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button1.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.Color.White;
			this.button1.Location = new System.Drawing.Point(445, 51);
			this.button1.Margin = new System.Windows.Forms.Padding(4);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(215, 66);
			this.button1.TabIndex = 17;
			this.button1.Text = "FETCH ATTENDANCE";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// comboBox2
			// 
			comboBox2.DropDownHeight = 50;
			comboBox2.DropDownWidth = 100;
			comboBox2.Font = new System.Drawing.Font("Lucida Sans", 10.8F, System.Drawing.FontStyle.Bold);
			comboBox2.FormattingEnabled = true;
			comboBox2.IntegralHeight = false;
			comboBox2.Items.AddRange(new object[] {
            "CS2001 (PF)",
            "CS2002 (COAL)",
            "CS2003 (OOP)",
            "CS2004 (FSE)",
            "MT2004 (Calculus)",
            "CS2005 (Algorithms)",
            "CS2006 (Database Systems)",
            "CS2007 (Operating Systems)",
            "CS2008 (Computer Networks)",
            "CS2009 (Software Engineering)",
            "CS2010 (Web Development)",
            "CS2011 (Artificial Intelligence)",
            "CS2012 (Machine Learning)",
            "CS2013 (Natural Language Processing)",
            "CS2014 (Deep Learning)",
            "CS2015 (Computer Vision)",
            "CS2016 (Parallel Computing)",
            "CS2017 (Cybersecurity)",
            "CS2018 (Data Mining)",
            "CS2019 (Information Retrieval)",
            "CS2020 (Robotics)",
            "CS2021 (Cloud Computing)",
            "CS2022 (Mobile App Development)",
            "CS2023 (Game Development)",
            "CS2024 (Blockchain Technologies)"});
			comboBox2.Location = new System.Drawing.Point(145, 52);
			comboBox2.Name = "comboBox2";
			comboBox2.Size = new System.Drawing.Size(170, 29);
			comboBox2.TabIndex = 38;
			comboBox2.Text = "Subject";
			// 
			// comboBox1
			// 
			comboBox1.DropDownHeight = 70;
			comboBox1.DropDownWidth = 150;
			comboBox1.Font = new System.Drawing.Font("Lucida Sans", 10.8F, System.Drawing.FontStyle.Bold);
			comboBox1.FormattingEnabled = true;
			comboBox1.IntegralHeight = false;
			comboBox1.Items.AddRange(new object[] {
            "BCS-2A",
            "BCS-2B",
            "BCS-2C",
            "BCS-4A",
            "BCS-4B",
            "BCS-4C",
            "BCS-6A",
            "BCS-6B",
            "BCS-6C",
            "BCS-8A",
            "BCS-8B",
            "BCS-8C",
            "BDS-2A",
            "BDS-2B",
            "BDS-2C",
            "BDS-4A",
            "BDS-4B",
            "BDS-4C",
            "BDS-6A",
            "BDS-6B",
            "BDS-6C",
            "BDS-8A",
            "BDS-8B",
            "BDS-8C",
            "BSE-2A",
            "BSE-2B",
            "BSE-2C",
            "BSE-2D",
            "BSE-2E",
            "BSE-4A",
            "BSE-4B",
            "BSE-4C",
            "BSE-4D",
            "BSE-4E",
            "BSE-6A",
            "BSE-6B",
            "BSE-6C",
            "BSE-6D",
            "BSE-6E",
            "BSE-8A",
            "BSE-8B",
            "BSE-8C",
            "BSE-8D",
            "BSE-8E"});
			comboBox1.Location = new System.Drawing.Point(18, 52);
			comboBox1.Name = "comboBox1";
			comboBox1.Size = new System.Drawing.Size(121, 29);
			comboBox1.TabIndex = 37;
			comboBox1.Text = "Section";
			// 
			// ShowAttendance
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Transparent;
			this.Controls.Add(comboBox2);
			this.Controls.Add(comboBox1);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.label10);
			this.Name = "ShowAttendance";
			this.Size = new System.Drawing.Size(660, 460);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn AttendanceStatus;
		private System.Windows.Forms.DataGridViewTextBoxColumn RollNumber;
		System.Windows.Forms.ComboBox comboBox2;
		System.Windows.Forms.ComboBox comboBox1;
	}
}
