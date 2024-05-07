namespace WindowsFormsApp1
{
	partial class Form1
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.panel1 = new System.Windows.Forms.Panel();
			this.button3 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button8 = new System.Windows.Forms.Button();
			this.button9 = new System.Windows.Forms.Button();
			this.button11 = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.showAttendance1 = new WindowsFormsApp1.ShowAttendance();
			this.addTeacher1 = new WindowsFormsApp1.AddTeacher();
			this.feedback1 = new WindowsFormsApp1.Feedback();
			this.dashboard1 = new WindowsFormsApp1.Dashboard();
			this.authenticator1 = new WindowsFormsApp1.Authenticator();
			this.registerNew2 = new WindowsFormsApp1.RegisterNew();
			this.attendancepp1 = new WindowsFormsApp1.Attendancepp();
			this.registerNew1 = new WindowsFormsApp1.RegisterNew();
			this.attendancepp2 = new WindowsFormsApp1.Attendancepp();
			this.attendance_Graph1 = new WindowsFormsApp1.Attendance_Graph();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Transparent;
			this.panel1.Controls.Add(this.button3);
			this.panel1.Controls.Add(this.button2);
			this.panel1.Controls.Add(this.button8);
			this.panel1.Controls.Add(this.button9);
			this.panel1.Controls.Add(this.button11);
			this.panel1.Controls.Add(this.button7);
			this.panel1.Controls.Add(this.button6);
			this.panel1.Controls.Add(this.button4);
			this.panel1.Location = new System.Drawing.Point(1, 1);
			this.panel1.Name = "panel1";
			this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.panel1.Size = new System.Drawing.Size(227, 472);
			this.panel1.TabIndex = 13;
			// 
			// button3
			// 
			this.button3.AllowDrop = true;
			this.button3.AutoSize = true;
			this.button3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.button3.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Screenshot_2024_03_25_115638;
			this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button3.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button3.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.button3.Location = new System.Drawing.Point(19, 258);
			this.button3.Margin = new System.Windows.Forms.Padding(2);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(190, 50);
			this.button3.TabIndex = 20;
			this.button3.Text = "SHOW ATTENDANCE";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button2
			// 
			this.button2.AllowDrop = true;
			this.button2.AutoSize = true;
			this.button2.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.button2.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Screenshot_2024_03_25_115638;
			this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button2.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.ForeColor = System.Drawing.Color.White;
			this.button2.Location = new System.Drawing.Point(19, 312);
			this.button2.Margin = new System.Windows.Forms.Padding(2);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(190, 50);
			this.button2.TabIndex = 19;
			this.button2.Text = "ADD TEACHER";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button8
			// 
			this.button8.AllowDrop = true;
			this.button8.AutoSize = true;
			this.button8.BackColor = System.Drawing.Color.SkyBlue;
			this.button8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button8.BackgroundImage")));
			this.button8.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button8.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button8.ForeColor = System.Drawing.Color.White;
			this.button8.Location = new System.Drawing.Point(19, 130);
			this.button8.Margin = new System.Windows.Forms.Padding(2);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(190, 70);
			this.button8.TabIndex = 18;
			this.button8.Text = "++ATTENDANCE";
			this.button8.UseVisualStyleBackColor = false;
			this.button8.Click += new System.EventHandler(this.button8_Click_1);
			// 
			// button9
			// 
			this.button9.AllowDrop = true;
			this.button9.AutoSize = true;
			this.button9.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.button9.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Screenshot_2024_03_25_115638;
			this.button9.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button9.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button9.ForeColor = System.Drawing.Color.White;
			this.button9.Location = new System.Drawing.Point(19, 366);
			this.button9.Margin = new System.Windows.Forms.Padding(2);
			this.button9.Name = "button9";
			this.button9.Size = new System.Drawing.Size(190, 50);
			this.button9.TabIndex = 17;
			this.button9.Text = "FEEDBACK";
			this.button9.UseVisualStyleBackColor = false;
			this.button9.Click += new System.EventHandler(this.button9_Click);
			// 
			// button11
			// 
			this.button11.AllowDrop = true;
			this.button11.AutoSize = true;
			this.button11.BackColor = System.Drawing.Color.Crimson;
			this.button11.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Screenshot_2024_03_25_120856;
			this.button11.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button11.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button11.ForeColor = System.Drawing.SystemColors.Control;
			this.button11.Location = new System.Drawing.Point(19, 420);
			this.button11.Margin = new System.Windows.Forms.Padding(2);
			this.button11.Name = "button11";
			this.button11.Size = new System.Drawing.Size(190, 50);
			this.button11.TabIndex = 16;
			this.button11.Text = "LOG OUT";
			this.button11.UseVisualStyleBackColor = false;
			this.button11.Click += new System.EventHandler(this.button11_Click);
			// 
			// button7
			// 
			this.button7.AllowDrop = true;
			this.button7.AutoSize = true;
			this.button7.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.button7.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Screenshot_2024_03_25_115638;
			this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button7.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button7.ForeColor = System.Drawing.SystemColors.InactiveBorder;
			this.button7.Location = new System.Drawing.Point(18, 5);
			this.button7.Margin = new System.Windows.Forms.Padding(2);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(190, 50);
			this.button7.TabIndex = 15;
			this.button7.Text = "HOME";
			this.button7.UseVisualStyleBackColor = false;
			this.button7.Click += new System.EventHandler(this.button7_Click);
			// 
			// button6
			// 
			this.button6.AllowDrop = true;
			this.button6.AutoSize = true;
			this.button6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.button6.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Screenshot_2024_03_25_115638;
			this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button6.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button6.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.button6.Location = new System.Drawing.Point(19, 204);
			this.button6.Margin = new System.Windows.Forms.Padding(2);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(189, 50);
			this.button6.TabIndex = 14;
			this.button6.Text = "GRAPH";
			this.button6.UseVisualStyleBackColor = false;
			this.button6.Click += new System.EventHandler(this.button6_Click);
			// 
			// button4
			// 
			this.button4.AllowDrop = true;
			this.button4.AutoSize = true;
			this.button4.BackColor = System.Drawing.Color.SkyBlue;
			this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
			this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button4.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button4.ForeColor = System.Drawing.Color.White;
			this.button4.Location = new System.Drawing.Point(19, 59);
			this.button4.Margin = new System.Windows.Forms.Padding(2);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(190, 70);
			this.button4.TabIndex = 12;
			this.button4.Text = "REGISTER NEW";
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += new System.EventHandler(this.button4_Click_1);
			// 
			// button1
			// 
			this.button1.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Screenshot_2024_03_25_115449;
			this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button1.Font = new System.Drawing.Font("Lucida Sans", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.Color.Transparent;
			this.button1.Location = new System.Drawing.Point(855, 6);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(82, 44);
			this.button1.TabIndex = 19;
			this.button1.Text = "OpenMenu";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.2F);
			this.label1.Location = new System.Drawing.Point(245, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(0, 21);
			this.label1.TabIndex = 22;
			// 
			// showAttendance1
			// 
			this.showAttendance1.BackColor = System.Drawing.Color.Transparent;
			this.showAttendance1.Location = new System.Drawing.Point(243, 38);
			this.showAttendance1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.showAttendance1.Name = "showAttendance1";
			this.showAttendance1.Size = new System.Drawing.Size(606, 436);
			this.showAttendance1.TabIndex = 25;
			// 
			// addTeacher1
			// 
			this.addTeacher1.BackColor = System.Drawing.Color.Transparent;
			this.addTeacher1.Location = new System.Drawing.Point(243, 33);
			this.addTeacher1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.addTeacher1.Name = "addTeacher1";
			this.addTeacher1.Size = new System.Drawing.Size(606, 423);
			this.addTeacher1.TabIndex = 24;
			// 
			// feedback1
			// 
			this.feedback1.BackColor = System.Drawing.Color.Transparent;
			this.feedback1.Location = new System.Drawing.Point(228, 38);
			this.feedback1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.feedback1.Name = "feedback1";
			this.feedback1.Size = new System.Drawing.Size(621, 418);
			this.feedback1.TabIndex = 23;
			// 
			// dashboard1
			// 
			this.dashboard1.BackColor = System.Drawing.Color.Transparent;
			this.dashboard1.Location = new System.Drawing.Point(234, 31);
			this.dashboard1.Margin = new System.Windows.Forms.Padding(4);
			this.dashboard1.Name = "dashboard1";
			this.dashboard1.Size = new System.Drawing.Size(615, 425);
			this.dashboard1.TabIndex = 20;
			// 
			// authenticator1
			// 
			this.authenticator1.BackColor = System.Drawing.Color.Transparent;
			this.authenticator1.Location = new System.Drawing.Point(213, 26);
			this.authenticator1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.authenticator1.Name = "authenticator1";
			this.authenticator1.Size = new System.Drawing.Size(722, 448);
			this.authenticator1.TabIndex = 12;
			// 
			// registerNew2
			// 
			this.registerNew2.BackColor = System.Drawing.Color.Transparent;
			this.registerNew2.Location = new System.Drawing.Point(234, 30);
			this.registerNew2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.registerNew2.Name = "registerNew2";
			this.registerNew2.Size = new System.Drawing.Size(706, 425);
			this.registerNew2.TabIndex = 11;
			// 
			// attendancepp1
			// 
			this.attendancepp1.BackColor = System.Drawing.Color.Transparent;
			this.attendancepp1.Location = new System.Drawing.Point(234, 30);
			this.attendancepp1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.attendancepp1.Name = "attendancepp1";
			this.attendancepp1.Size = new System.Drawing.Size(706, 425);
			this.attendancepp1.TabIndex = 10;
			// 
			// registerNew1
			// 
			this.registerNew1.BackColor = System.Drawing.Color.Transparent;
			this.registerNew1.Location = new System.Drawing.Point(234, 30);
			this.registerNew1.Margin = new System.Windows.Forms.Padding(2);
			this.registerNew1.Name = "registerNew1";
			this.registerNew1.Size = new System.Drawing.Size(706, 425);
			this.registerNew1.TabIndex = 15;
			// 
			// attendancepp2
			// 
			this.attendancepp2.BackColor = System.Drawing.Color.Transparent;
			this.attendancepp2.Location = new System.Drawing.Point(234, 30);
			this.attendancepp2.Margin = new System.Windows.Forms.Padding(2);
			this.attendancepp2.Name = "attendancepp2";
			this.attendancepp2.Size = new System.Drawing.Size(706, 425);
			this.attendancepp2.TabIndex = 14;
			// 
			// attendance_Graph1
			// 
			this.attendance_Graph1.BackColor = System.Drawing.Color.Transparent;
			this.attendance_Graph1.Location = new System.Drawing.Point(234, 30);
			this.attendance_Graph1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.attendance_Graph1.Name = "attendance_Graph1";
			this.attendance_Graph1.Size = new System.Drawing.Size(706, 425);
			this.attendance_Graph1.TabIndex = 21;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.bg2__2_;
			this.ClientSize = new System.Drawing.Size(947, 471);
			this.Controls.Add(this.showAttendance1);
			this.Controls.Add(this.addTeacher1);
			this.Controls.Add(this.feedback1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dashboard1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.authenticator1);
			this.Controls.Add(this.registerNew2);
			this.Controls.Add(this.attendancepp1);
			this.Controls.Add(this.registerNew1);
			this.Controls.Add(this.attendancepp2);
			this.Controls.Add(this.attendance_Graph1);
			this.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(2);
			this.MaximumSize = new System.Drawing.Size(965, 518);
			this.MinimumSize = new System.Drawing.Size(965, 518);
			this.Name = "Form1";
			this.Text = "ATTENDANCE++";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.Button button9;
		private System.Windows.Forms.Button button11;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button4;
        
		public Attendancepp attendancepp1;
		public RegisterNew registerNew2;
		public Authenticator authenticator1;
		public Attendancepp attendancepp2;
        public RegisterNew registerNew1;
        public System.Windows.Forms.Button button1;
        public Dashboard dashboard1;
		public Attendance_Graph attendance_Graph1;
		public System.Windows.Forms.Label label1;
		public Feedback feedback1;
		private System.Windows.Forms.Button button2;
		private AddTeacher addTeacher1;
		private System.Windows.Forms.Button button3;
		private ShowAttendance showAttendance1;
	}
}

