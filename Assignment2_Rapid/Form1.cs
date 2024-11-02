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
}


