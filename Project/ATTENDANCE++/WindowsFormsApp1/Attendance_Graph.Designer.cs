namespace WindowsFormsApp1
{
    partial class Attendance_Graph
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
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
			this.SuspendLayout();
			// 
			// chart1
			// 
			this.chart1.BackColor = System.Drawing.Color.Transparent;
			this.chart1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.chart1.BackImageTransparentColor = System.Drawing.Color.Transparent;
			this.chart1.BackSecondaryColor = System.Drawing.Color.Transparent;
			this.chart1.BorderlineColor = System.Drawing.Color.Transparent;
			this.chart1.BorderlineWidth = 4;
			chartArea2.AxisX.Title = "Months";
			chartArea2.AxisX.TitleFont = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			chartArea2.AxisY.Title = "Average Attendance";
			chartArea2.AxisY.TitleFont = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Bold);
			chartArea2.BackColor = System.Drawing.Color.Transparent;
			chartArea2.Name = "ChartArea1";
			this.chart1.ChartAreas.Add(chartArea2);
			legend2.BackColor = System.Drawing.Color.Transparent;
			legend2.Font = new System.Drawing.Font("Lucida Fax", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			legend2.IsTextAutoFit = false;
			legend2.Name = "Legend1";
			legend2.TitleBackColor = System.Drawing.Color.Transparent;
			this.chart1.Legends.Add(legend2);
			this.chart1.Location = new System.Drawing.Point(4, 53);
			this.chart1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.chart1.Name = "chart1";
			this.chart1.Size = new System.Drawing.Size(710, 384);
			this.chart1.TabIndex = 0;
			this.chart1.Text = "chart1";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(13, 7);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(82, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "GRAPH";
			// 
			// Attendance_Graph
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Transparent;
			this.Controls.Add(this.label1);
			this.Controls.Add(this.chart1);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "Attendance_Graph";
			this.Size = new System.Drawing.Size(733, 460);
			((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion

		public System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label1;
    }
}
