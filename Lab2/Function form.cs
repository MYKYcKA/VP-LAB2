using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double Function(double x)
        {
            return Math.Sin(x) / (2 + Math.Cos(x));
        }

        private void XTextBoxt_Validation(object sender, CancelEventArgs e)
        {
            var textBox = sender as TextBox;
            var validateExpression = new Regex(@"^-?\d*(\,\d+)?$");
            if (!validateExpression.IsMatch(textBox.Text))
            {
                e.Cancel = true;
                textBox.Focus();
                errorProvider1.SetError(textBox, "Invalid number!");
                Generate.Enabled = false;
            }
            else
            {
                Generate.Enabled = true;
                e.Cancel = false;
                errorProvider1.SetError(textBox, "");
            }
        }

        private void NOPTextBox_Validating(object sender, CancelEventArgs e)
        {
            var textBox = sender as TextBox;
            var validateExpression = new Regex(@"^\d*$");
            if (!validateExpression.IsMatch(textBox.Text))
            {
                e.Cancel = true;
                textBox.Focus();
                errorProvider1.SetError(textBox, "Invalid number!");
                Generate.Enabled = false;
            }
            else
            {
                Generate.Enabled = true;
                e.Cancel = false;
                errorProvider1.SetError(textBox, "");
            }
        }

        private void Generate_click(object sender, EventArgs e)
        {
            var xMin = double.Parse(XminTextBox.Text);
            var xMax = double.Parse(XmaxTextBox.Text);
            var NoP = double.Parse(NoPTextBox.Text);
            var step = (Math.Abs(xMin) + Math.Abs(xMax)) / NoP;
            var objChart = chart1.ChartAreas[0];
            var dataSource = new List<Point>();
            objChart.AxisX.IntervalType = DateTimeIntervalType.Number;
            objChart.AxisX.Minimum = xMin;
            objChart.AxisX.Maximum = xMax;

            objChart.AxisY.IntervalType = DateTimeIntervalType.Number;
            objChart.AxisY.Minimum = -3;
            objChart.AxisY.Maximum = 3;

            chart1.Series.Clear();

            var location = "My line";
            var random = new Random();

            chart1.Series.Add(location);
            chart1.Series[location].Color = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
            chart1.Series[location].Legend = "Legend1";
            chart1.Series[location].ChartArea = "ChartArea1";
            chart1.Series[location].ChartType = SeriesChartType.Line;

            for (double i = xMin; i < xMax; i += step)
            {
                chart1.Series[location].Points.AddXY(i, Function(i));
                dataSource.Add(new Point { X = i, Y = Function(i) });
            }
            DataGrid.DataSource = dataSource;

            File.Create("Points.txt").Close();
            using (var fs = new FileStream("Points.txt", FileMode.Append, FileAccess.Write))
            using (var sw = new StreamWriter(fs))
            {
                sw.Flush();
                foreach (var point in dataSource)
                {
                    sw.WriteLine($"X = {point.X}, Y = {point.Y}");
                }
            }

            var fMax = chart1.Series[location].Points.Max(x=>x.YValues.Max());
            var fMin = chart1.Series[location].Points.Min(x=>x.YValues.Min());

            FmaxLabel.Text = $"Fmax = {fMax}";
            FminLabel.Text = $"Fmin = {fMin}";
        }

        private void FromFileButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            using (var sw = new StreamReader(openFileDialog1.FileName))
            {
                XminTextBox.Text = sw.ReadLine();
                XmaxTextBox.Text = sw.ReadLine();
                NoPTextBox.Text = sw.ReadLine();
            }
        }
    }
}
