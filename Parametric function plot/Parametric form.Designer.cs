namespace Parametric_function_plot
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.YXminLabel = new System.Windows.Forms.Label();
            this.YXmaxLabel = new System.Windows.Forms.Label();
            this.XYminLabel = new System.Windows.Forms.Label();
            this.XYmaxLabel = new System.Windows.Forms.Label();
            this.YTminLabel = new System.Windows.Forms.Label();
            this.YTmaxLabel = new System.Windows.Forms.Label();
            this.FromFileButton = new System.Windows.Forms.Button();
            this.XTminLabel = new System.Windows.Forms.Label();
            this.XTmaxLabel = new System.Windows.Forms.Label();
            this.NoPTextBox = new System.Windows.Forms.TextBox();
            this.TabulationCount = new System.Windows.Forms.Label();
            this.TmaxTextBox = new System.Windows.Forms.TextBox();
            this.TmaxLabel = new System.Windows.Forms.Label();
            this.TminTextBox = new System.Windows.Forms.TextBox();
            this.TminLabel = new System.Windows.Forms.Label();
            this.Generate = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xFromTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yFromTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xFromYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yFromXDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parametricPointBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart4 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parametricPointBindingSource)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart4)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Controls.Add(this.tabPage4);
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1071, 593);
            this.tabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.YXminLabel);
            this.tabPage1.Controls.Add(this.YXmaxLabel);
            this.tabPage1.Controls.Add(this.XYminLabel);
            this.tabPage1.Controls.Add(this.XYmaxLabel);
            this.tabPage1.Controls.Add(this.YTminLabel);
            this.tabPage1.Controls.Add(this.YTmaxLabel);
            this.tabPage1.Controls.Add(this.FromFileButton);
            this.tabPage1.Controls.Add(this.XTminLabel);
            this.tabPage1.Controls.Add(this.XTmaxLabel);
            this.tabPage1.Controls.Add(this.NoPTextBox);
            this.tabPage1.Controls.Add(this.TabulationCount);
            this.tabPage1.Controls.Add(this.TmaxTextBox);
            this.tabPage1.Controls.Add(this.TmaxLabel);
            this.tabPage1.Controls.Add(this.TminTextBox);
            this.tabPage1.Controls.Add(this.TminLabel);
            this.tabPage1.Controls.Add(this.Generate);
            this.tabPage1.Controls.Add(this.chart1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1063, 564);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Plot 1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.chart2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1063, 564);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Plot 2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tDataGridViewTextBoxColumn,
            this.xFromTDataGridViewTextBoxColumn,
            this.yFromTDataGridViewTextBoxColumn,
            this.xFromYDataGridViewTextBoxColumn,
            this.yFromXDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.parametricPointBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(3, 411);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1057, 150);
            this.dataGridView1.TabIndex = 47;
            // 
            // YXminLabel
            // 
            this.YXminLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.YXminLabel.AutoSize = true;
            this.YXminLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.YXminLabel.Location = new System.Drawing.Point(756, 471);
            this.YXminLabel.Name = "YXminLabel";
            this.YXminLabel.Size = new System.Drawing.Size(0, 20);
            this.YXminLabel.TabIndex = 46;
            // 
            // YXmaxLabel
            // 
            this.YXmaxLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.YXmaxLabel.AutoSize = true;
            this.YXmaxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.YXmaxLabel.Location = new System.Drawing.Point(755, 436);
            this.YXmaxLabel.Name = "YXmaxLabel";
            this.YXmaxLabel.Size = new System.Drawing.Size(0, 20);
            this.YXmaxLabel.TabIndex = 45;
            // 
            // XYminLabel
            // 
            this.XYminLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.XYminLabel.AutoSize = true;
            this.XYminLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.XYminLabel.Location = new System.Drawing.Point(755, 404);
            this.XYminLabel.Name = "XYminLabel";
            this.XYminLabel.Size = new System.Drawing.Size(0, 20);
            this.XYminLabel.TabIndex = 44;
            // 
            // XYmaxLabel
            // 
            this.XYmaxLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.XYmaxLabel.AutoSize = true;
            this.XYmaxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.XYmaxLabel.Location = new System.Drawing.Point(754, 369);
            this.XYmaxLabel.Name = "XYmaxLabel";
            this.XYmaxLabel.Size = new System.Drawing.Size(0, 20);
            this.XYmaxLabel.TabIndex = 43;
            // 
            // YTminLabel
            // 
            this.YTminLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.YTminLabel.AutoSize = true;
            this.YTminLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.YTminLabel.Location = new System.Drawing.Point(755, 337);
            this.YTminLabel.Name = "YTminLabel";
            this.YTminLabel.Size = new System.Drawing.Size(0, 20);
            this.YTminLabel.TabIndex = 42;
            // 
            // YTmaxLabel
            // 
            this.YTmaxLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.YTmaxLabel.AutoSize = true;
            this.YTmaxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.YTmaxLabel.Location = new System.Drawing.Point(754, 302);
            this.YTmaxLabel.Name = "YTmaxLabel";
            this.YTmaxLabel.Size = new System.Drawing.Size(0, 20);
            this.YTmaxLabel.TabIndex = 41;
            // 
            // FromFileButton
            // 
            this.FromFileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FromFileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FromFileButton.Location = new System.Drawing.Point(745, 166);
            this.FromFileButton.Name = "FromFileButton";
            this.FromFileButton.Size = new System.Drawing.Size(145, 48);
            this.FromFileButton.TabIndex = 40;
            this.FromFileButton.TabStop = false;
            this.FromFileButton.Text = "Read from file";
            this.FromFileButton.UseVisualStyleBackColor = true;
            this.FromFileButton.Click += new System.EventHandler(this.FromFileButton_Click);
            // 
            // XTminLabel
            // 
            this.XTminLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.XTminLabel.AutoSize = true;
            this.XTminLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.XTminLabel.Location = new System.Drawing.Point(754, 270);
            this.XTminLabel.Name = "XTminLabel";
            this.XTminLabel.Size = new System.Drawing.Size(0, 20);
            this.XTminLabel.TabIndex = 39;
            // 
            // XTmaxLabel
            // 
            this.XTmaxLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.XTmaxLabel.AutoSize = true;
            this.XTmaxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.XTmaxLabel.Location = new System.Drawing.Point(753, 235);
            this.XTmaxLabel.Name = "XTmaxLabel";
            this.XTmaxLabel.Size = new System.Drawing.Size(0, 20);
            this.XTmaxLabel.TabIndex = 38;
            // 
            // NoPTextBox
            // 
            this.NoPTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NoPTextBox.Location = new System.Drawing.Point(861, 114);
            this.NoPTextBox.Name = "NoPTextBox";
            this.NoPTextBox.Size = new System.Drawing.Size(100, 22);
            this.NoPTextBox.TabIndex = 37;
            // 
            // TabulationCount
            // 
            this.TabulationCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TabulationCount.AutoSize = true;
            this.TabulationCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TabulationCount.Location = new System.Drawing.Point(851, 91);
            this.TabulationCount.Name = "TabulationCount";
            this.TabulationCount.Size = new System.Drawing.Size(137, 20);
            this.TabulationCount.TabIndex = 36;
            this.TabulationCount.Text = "Number of points";
            // 
            // TmaxTextBox
            // 
            this.TmaxTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TmaxTextBox.Location = new System.Drawing.Point(919, 45);
            this.TmaxTextBox.Name = "TmaxTextBox";
            this.TmaxTextBox.Size = new System.Drawing.Size(100, 22);
            this.TmaxTextBox.TabIndex = 35;
            // 
            // TmaxLabel
            // 
            this.TmaxLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TmaxLabel.AutoSize = true;
            this.TmaxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TmaxLabel.Location = new System.Drawing.Point(937, 22);
            this.TmaxLabel.Name = "TmaxLabel";
            this.TmaxLabel.Size = new System.Drawing.Size(50, 20);
            this.TmaxLabel.TabIndex = 34;
            this.TmaxLabel.Text = "Tmax";
            // 
            // TminTextBox
            // 
            this.TminTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TminTextBox.Location = new System.Drawing.Point(802, 45);
            this.TminTextBox.Name = "TminTextBox";
            this.TminTextBox.Size = new System.Drawing.Size(100, 22);
            this.TminTextBox.TabIndex = 33;
            // 
            // TminLabel
            // 
            this.TminLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TminLabel.AutoSize = true;
            this.TminLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TminLabel.Location = new System.Drawing.Point(831, 22);
            this.TminLabel.Name = "TminLabel";
            this.TminLabel.Size = new System.Drawing.Size(46, 20);
            this.TminLabel.TabIndex = 32;
            this.TminLabel.Text = "Tmin";
            // 
            // Generate
            // 
            this.Generate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Generate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Generate.Location = new System.Drawing.Point(896, 166);
            this.Generate.Name = "Generate";
            this.Generate.Size = new System.Drawing.Size(145, 48);
            this.Generate.TabIndex = 31;
            this.Generate.TabStop = false;
            this.Generate.Text = "Generate";
            this.Generate.UseVisualStyleBackColor = true;
            this.Generate.Click += new System.EventHandler(this.Generate_click);
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(21, 10);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(715, 387);
            this.chart1.TabIndex = 30;
            this.chart1.Text = "chart1";
            // 
            // tDataGridViewTextBoxColumn
            // 
            this.tDataGridViewTextBoxColumn.DataPropertyName = "T";
            this.tDataGridViewTextBoxColumn.HeaderText = "T";
            this.tDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tDataGridViewTextBoxColumn.Name = "tDataGridViewTextBoxColumn";
            // 
            // xFromTDataGridViewTextBoxColumn
            // 
            this.xFromTDataGridViewTextBoxColumn.DataPropertyName = "XFromT";
            this.xFromTDataGridViewTextBoxColumn.HeaderText = "XFromT";
            this.xFromTDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.xFromTDataGridViewTextBoxColumn.Name = "xFromTDataGridViewTextBoxColumn";
            // 
            // yFromTDataGridViewTextBoxColumn
            // 
            this.yFromTDataGridViewTextBoxColumn.DataPropertyName = "YFromT";
            this.yFromTDataGridViewTextBoxColumn.HeaderText = "YFromT";
            this.yFromTDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.yFromTDataGridViewTextBoxColumn.Name = "yFromTDataGridViewTextBoxColumn";
            // 
            // xFromYDataGridViewTextBoxColumn
            // 
            this.xFromYDataGridViewTextBoxColumn.DataPropertyName = "XFromY";
            this.xFromYDataGridViewTextBoxColumn.HeaderText = "XFromY";
            this.xFromYDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.xFromYDataGridViewTextBoxColumn.Name = "xFromYDataGridViewTextBoxColumn";
            // 
            // yFromXDataGridViewTextBoxColumn
            // 
            this.yFromXDataGridViewTextBoxColumn.DataPropertyName = "YFromX";
            this.yFromXDataGridViewTextBoxColumn.HeaderText = "YFromX";
            this.yFromXDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.yFromXDataGridViewTextBoxColumn.Name = "yFromXDataGridViewTextBoxColumn";
            // 
            // parametricPointBindingSource
            // 
            this.parametricPointBindingSource.DataSource = typeof(ParametricFunctionPlot.ParametricPoint);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.chart3);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1063, 564);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Plot 3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.chart4);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1063, 564);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Plot 4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // chart2
            // 
            this.chart2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(25, 24);
            this.chart2.Name = "chart2";
            this.chart2.Size = new System.Drawing.Size(1006, 500);
            this.chart2.TabIndex = 31;
            this.chart2.Text = "chart2";
            // 
            // chart3
            // 
            this.chart3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea3.Name = "ChartArea1";
            this.chart3.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart3.Legends.Add(legend3);
            this.chart3.Location = new System.Drawing.Point(25, 22);
            this.chart3.Name = "chart3";
            this.chart3.Size = new System.Drawing.Size(1006, 500);
            this.chart3.TabIndex = 32;
            this.chart3.Text = "chart3";
            // 
            // chart4
            // 
            this.chart4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea4.Name = "ChartArea1";
            this.chart4.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart4.Legends.Add(legend4);
            this.chart4.Location = new System.Drawing.Point(28, 32);
            this.chart4.Name = "chart4";
            this.chart4.Size = new System.Drawing.Size(1006, 500);
            this.chart4.TabIndex = 33;
            this.chart4.Text = "chart4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 586);
            this.Controls.Add(this.tabControl);
            this.Name = "Form1";
            this.Text = "Parametric function";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parametricPointBindingSource)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource parametricPointBindingSource;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn xFromTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yFromTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn xFromYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yFromXDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label YXminLabel;
        private System.Windows.Forms.Label YXmaxLabel;
        private System.Windows.Forms.Label XYminLabel;
        private System.Windows.Forms.Label XYmaxLabel;
        private System.Windows.Forms.Label YTminLabel;
        private System.Windows.Forms.Label YTmaxLabel;
        private System.Windows.Forms.Button FromFileButton;
        private System.Windows.Forms.Label XTminLabel;
        private System.Windows.Forms.Label XTmaxLabel;
        private System.Windows.Forms.TextBox NoPTextBox;
        private System.Windows.Forms.Label TabulationCount;
        private System.Windows.Forms.TextBox TmaxTextBox;
        private System.Windows.Forms.Label TmaxLabel;
        private System.Windows.Forms.TextBox TminTextBox;
        private System.Windows.Forms.Label TminLabel;
        private System.Windows.Forms.Button Generate;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart4;
    }
}

