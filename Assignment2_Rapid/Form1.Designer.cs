namespace Assignment2_Rapid
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.lineChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.textBoxLine1 = new System.Windows.Forms.TextBox();
            this.textBoxLine2 = new System.Windows.Forms.TextBox();
            this.textBoxLine3 = new System.Windows.Forms.TextBox();
            this.textBoxLine4 = new System.Windows.Forms.TextBox();
            this.textBoxLine5 = new System.Windows.Forms.TextBox();
            this.generateChart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.lineChart)).BeginInit();
            this.SuspendLayout();
            // 
            // lineChart
            // 
            chartArea1.Name = "ChartArea1";
            this.lineChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.lineChart.Legends.Add(legend1);
            this.lineChart.Location = new System.Drawing.Point(388, 47);
            this.lineChart.Name = "lineChart";
            this.lineChart.Size = new System.Drawing.Size(916, 625);
            this.lineChart.TabIndex = 0;
            this.lineChart.Text = "lineChart";
            // 
            // textBoxLine1
            // 
            this.textBoxLine1.Location = new System.Drawing.Point(120, 135);
            this.textBoxLine1.Name = "textBoxLine1";
            this.textBoxLine1.Size = new System.Drawing.Size(114, 22);
            this.textBoxLine1.TabIndex = 1;
            // 
            // textBoxLine2
            // 
            this.textBoxLine2.Location = new System.Drawing.Point(120, 185);
            this.textBoxLine2.Name = "textBoxLine2";
            this.textBoxLine2.Size = new System.Drawing.Size(114, 22);
            this.textBoxLine2.TabIndex = 2;
            // 
            // textBoxLine3
            // 
            this.textBoxLine3.Location = new System.Drawing.Point(120, 233);
            this.textBoxLine3.Name = "textBoxLine3";
            this.textBoxLine3.Size = new System.Drawing.Size(114, 22);
            this.textBoxLine3.TabIndex = 3;
            // 
            // textBoxLine4
            // 
            this.textBoxLine4.Location = new System.Drawing.Point(120, 280);
            this.textBoxLine4.Name = "textBoxLine4";
            this.textBoxLine4.Size = new System.Drawing.Size(114, 22);
            this.textBoxLine4.TabIndex = 4;
            // 
            // textBoxLine5
            // 
            this.textBoxLine5.Location = new System.Drawing.Point(120, 328);
            this.textBoxLine5.Name = "textBoxLine5";
            this.textBoxLine5.Size = new System.Drawing.Size(114, 22);
            this.textBoxLine5.TabIndex = 5;
            // 
            // generateChart
            // 
            this.generateChart.Location = new System.Drawing.Point(103, 403);
            this.generateChart.Name = "generateChart";
            this.generateChart.Size = new System.Drawing.Size(151, 49);
            this.generateChart.TabIndex = 6;
            this.generateChart.Text = "Generate";
            this.generateChart.UseVisualStyleBackColor = true;
            this.generateChart.Click += new System.EventHandler(this.GenerateChartButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 32);
            this.label1.TabIndex = 7;
            this.label1.Text = "Line Chart Generator";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1347, 742);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.generateChart);
            this.Controls.Add(this.textBoxLine5);
            this.Controls.Add(this.textBoxLine4);
            this.Controls.Add(this.textBoxLine3);
            this.Controls.Add(this.textBoxLine2);
            this.Controls.Add(this.textBoxLine1);
            this.Controls.Add(this.lineChart);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.lineChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart lineChart;
        private System.Windows.Forms.TextBox textBoxLine1;
        private System.Windows.Forms.TextBox textBoxLine2;
        private System.Windows.Forms.TextBox textBoxLine3;
        private System.Windows.Forms.TextBox textBoxLine4;
        private System.Windows.Forms.TextBox textBoxLine5;
        private System.Windows.Forms.Button generateChart;
        private System.Windows.Forms.Label label1;
    }
}

