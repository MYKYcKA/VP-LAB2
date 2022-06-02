using ParametricFunctionPlot;
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

namespace Parametric_function_plot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double XFunc(double t)
        {
            return Math.Pow(Math.Cos(t), 4);
        }

        private double YFunc(double t)
        {
            return Math.Pow(Math.Sin(t), 4);
        }

        private double YXFunc(double t)
        {
            return Math.Pow(Math.Sin(Math.Pow(Math.Cos(t), 4)), 4);
        }

        private double XYFunc(double t)
        {
            return Math.Pow(Math.Sin(Math.Pow(Math.Sin(t), 4)), 4);
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
            var tMin = double.Parse(TminTextBox.Text);
            var tMax = double.Parse(TmaxTextBox.Text);
            var NoP = double.Parse(NoPTextBox.Text);
            var step = (Math.Abs(tMin) + Math.Abs(tMax)) / NoP;
            var dataSource = new List<ParametricPoint>();
            var chartList = new Dictionary<string,Chart>() { { "X(t)", chart1 }, { "Y(t)", chart2 }, { "X(y)", chart3 }, { "Y(x)", chart4 } };
            var colors = new Dictionary<string, Color> { { "X(t)", Color.DarkRed }, { "Y(t)", Color.DarkGreen }, { "X(y)", Color.DarkBlue }, { "Y(x)", Color.Black } };
            foreach (var chart in chartList.Values)
            {
                var objChart = chart.ChartAreas[0];
                var location = chartList.FirstOrDefault(x => x.Value == chart).Key;
                objChart.AxisX.IntervalType = DateTimeIntervalType.Number;
                objChart.AxisX.Minimum = tMin;
                objChart.AxisX.Maximum = tMax;

                objChart.AxisY.IntervalType = DateTimeIntervalType.Number;
                objChart.AxisY.Minimum = -1;
                objChart.AxisY.Maximum = 1;
                chart.Series.Clear();

                chart.Series.Add(location);
                chart.Series[location].Color = colors[location];
                chart.Series[location].Legend = "Legend1";
                chart.Series[location].ChartArea = "ChartArea1";
                chart.Series[location].ChartType = SeriesChartType.Line;
            }

            for (double i = tMin; i < tMax; i += step)
            {
                chart1.Series["X(t)"].Points.AddXY(i, XFunc(i));
                chart2.Series["Y(t)"].Points.AddXY(i, YFunc(i));
                chart3.Series["X(y)"].Points.AddXY(i, XYFunc(i));
                chart4.Series["Y(x)"].Points.AddXY(i, YXFunc(i));
                dataSource.Add(new ParametricPoint { T = i, XFromT = XFunc(i), YFromT = YFunc(i), XFromY = XYFunc(i), YFromX = YXFunc(i) });
            }
            dataGridView1.DataSource = dataSource;

            File.Create("Points.txt").Close();
            using (var fs = new FileStream("Points.txt", FileMode.Append, FileAccess.Write))
            using (var sw = new StreamWriter(fs))
            {
                sw.Flush();
                foreach (var point in dataSource)
                {
                    sw.WriteLine($"t = {point.T}, X(t) = {point.XFromT}, Y(t) = {point.YFromT}, X(Y) = {point.XFromY}, Y(X) = {point.YFromX}");
                }
            }

            XTmaxLabel.Text = $"X(t)max = {chart1.Series["X(t)"].Points.Max(x => x.YValues.Max())}";
            XTminLabel.Text = $"X(t)min = {chart1.Series["X(t)"].Points.Min(x => x.YValues.Min())}";
            YTmaxLabel.Text = $"Y(t)max = {chart2.Series["Y(t)"].Points.Max(x => x.YValues.Max())}";
            YTminLabel.Text = $"Y(t)min = {chart2.Series["Y(t)"].Points.Min(x => x.YValues.Min())}";
            XYmaxLabel.Text = $"X(y)max = {chart3.Series["X(y)"].Points.Max(x => x.YValues.Max())}";
            XYminLabel.Text = $"X(y)min = {chart3.Series["X(y)"].Points.Min(x => x.YValues.Min())}";
            YXmaxLabel.Text = $"Y(x)max = {chart4.Series["Y(x)"].Points.Max(x => x.YValues.Max())}";
            YXminLabel.Text = $"Y(X)min = {chart4.Series["Y(x)"].Points.Min(x => x.YValues.Min())}";
        }

        private void FromFileButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            using (var sw = new StreamReader(openFileDialog1.FileName))
            {
                TminTextBox.Text = sw.ReadLine();
                TmaxTextBox.Text = sw.ReadLine();
                NoPTextBox.Text = sw.ReadLine();
            }
        }
    }
}
