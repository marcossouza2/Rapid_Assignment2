using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace Assignment2_Rapid
{
    public partial class Form1 : Form
    {
        private const string ExamplePlaceHolder = "Eg: 1, 2, 3, 4, 5";
        private TextBox[] textBoxes;

        public Form1()
        {
            InitializeComponent();
            generateChart.Click += GenerateChartButton_Click;

            textBoxes = new TextBox[] { textBoxLine1, textBoxLine2, textBoxLine3, textBoxLine4, textBoxLine5 };

            foreach (var textBox in textBoxes)
            {
                textBox.Text = ExamplePlaceHolder;
                textBox.ForeColor = Color.Gray;

                textBox.Enter += TextBox_Enter;
                textBox.Leave += TextBox_Leave;
            }
        }
        private void TextBox_Enter(object sender, EventArgs e)
        {
            var textBox = sender as TextBox;
            if (textBox != null && textBox.Text == ExamplePlaceHolder)
            {
                textBox.Text = "";
                textBox.ForeColor = Color.Black;
            }
        }
        private void TextBox_Leave(object sender, EventArgs e)
        {
            var textBox = sender as TextBox;
            if (textBox != null && string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = ExamplePlaceHolder;
                textBox.ForeColor = Color.Gray;
            }
        }

        private void GenerateChartButton_Click(object sender, EventArgs e)
        {
            double[][] data = new double[5][];
            data[0] = ParseData(textBoxLine1.Text);
            data[1] = ParseData(textBoxLine2.Text);
            data[2] = ParseData(textBoxLine3.Text);
            data[3] = ParseData(textBoxLine4.Text);
            data[4] = ParseData(textBoxLine5.Text);

            lineChart.Series.Clear();

            string[] labels = { "Line 1", "Line 2", "Line 3", "Line 4", "Line 5" };
            Color[] colors = { Color.Red, Color.Blue, Color.Green, Color.Purple, Color.DarkSalmon };

            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == null) continue;

                Series series = new Series
                {
                    Name = labels[i],
                    ChartType = SeriesChartType.Line,
                    BorderWidth = 2,
                    Color = colors[i],
                    IsVisibleInLegend = true
                };

                for (int j = 0; j < data[i].Length; j++)
                {
                    series.Points.AddXY(j, data[i][j]);
                }

                lineChart.Series.Add(series);
            }

            lineChart.Legends.Clear();
            lineChart.Legends.Add(new Legend("Legend") { Docking = Docking.Top });
        }
        private double[] ParseData(string input)
        {
            try
            {
                return input.Split(',')
                            .Select(val => double.Parse(val.Trim()))
                            .ToArray();
            }
            catch
            {
                MessageBox.Show("Invalid data format. Please enter comma-separated numbers.");
                return null;
            }
        }
    }
}

}



