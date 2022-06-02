namespace Lab2
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Generate = new System.Windows.Forms.Button();
            this.XminLabel = new System.Windows.Forms.Label();
            this.XminTextBox = new System.Windows.Forms.TextBox();
            this.XmaxTextBox = new System.Windows.Forms.TextBox();
            this.XmaxLabel = new System.Windows.Forms.Label();
            this.NoPTextBox = new System.Windows.Forms.TextBox();
            this.TabulationCount = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.FmaxLabel = new System.Windows.Forms.Label();
            this.FminLabel = new System.Windows.Forms.Label();
            this.DataGrid = new System.Windows.Forms.DataGridView();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.xDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pointBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.FromFileButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(27, 22);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(802, 553);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // Generate
            // 
            this.Generate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Generate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Generate.Location = new System.Drawing.Point(986, 164);
            this.Generate.Name = "Generate";
            this.Generate.Size = new System.Drawing.Size(145, 53);
            this.Generate.TabIndex = 1;
            this.Generate.TabStop = false;
            this.Generate.Text = "Generate";
            this.Generate.UseVisualStyleBackColor = true;
            this.Generate.Click += new System.EventHandler(this.Generate_click);
            // 
            // XminLabel
            // 
            this.XminLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.XminLabel.AutoSize = true;
            this.XminLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.XminLabel.Location = new System.Drawing.Point(921, 25);
            this.XminLabel.Name = "XminLabel";
            this.XminLabel.Size = new System.Drawing.Size(47, 20);
            this.XminLabel.TabIndex = 2;
            this.XminLabel.Text = "Xmin";
            // 
            // XminTextBox
            // 
            this.XminTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.XminTextBox.Location = new System.Drawing.Point(892, 48);
            this.XminTextBox.Name = "XminTextBox";
            this.XminTextBox.Size = new System.Drawing.Size(100, 22);
            this.XminTextBox.TabIndex = 3;
            this.XminTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.XTextBoxt_Validation);
            // 
            // XmaxTextBox
            // 
            this.XmaxTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.XmaxTextBox.Location = new System.Drawing.Point(1009, 48);
            this.XmaxTextBox.Name = "XmaxTextBox";
            this.XmaxTextBox.Size = new System.Drawing.Size(100, 22);
            this.XmaxTextBox.TabIndex = 5;
            // 
            // XmaxLabel
            // 
            this.XmaxLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.XmaxLabel.AutoSize = true;
            this.XmaxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.XmaxLabel.Location = new System.Drawing.Point(1027, 25);
            this.XmaxLabel.Name = "XmaxLabel";
            this.XmaxLabel.Size = new System.Drawing.Size(51, 20);
            this.XmaxLabel.TabIndex = 4;
            this.XmaxLabel.Text = "Xmax";
            // 
            // NoPTextBox
            // 
            this.NoPTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NoPTextBox.Location = new System.Drawing.Point(951, 117);
            this.NoPTextBox.Name = "NoPTextBox";
            this.NoPTextBox.Size = new System.Drawing.Size(100, 22);
            this.NoPTextBox.TabIndex = 7;
            this.NoPTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.NOPTextBox_Validating);
            // 
            // TabulationCount
            // 
            this.TabulationCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TabulationCount.AutoSize = true;
            this.TabulationCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TabulationCount.Location = new System.Drawing.Point(941, 94);
            this.TabulationCount.Name = "TabulationCount";
            this.TabulationCount.Size = new System.Drawing.Size(137, 20);
            this.TabulationCount.TabIndex = 6;
            this.TabulationCount.Text = "Number of points";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FmaxLabel
            // 
            this.FmaxLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FmaxLabel.AutoSize = true;
            this.FmaxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FmaxLabel.Location = new System.Drawing.Point(888, 259);
            this.FmaxLabel.Name = "FmaxLabel";
            this.FmaxLabel.Size = new System.Drawing.Size(0, 20);
            this.FmaxLabel.TabIndex = 8;
            // 
            // FminLabel
            // 
            this.FminLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FminLabel.AutoSize = true;
            this.FminLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FminLabel.Location = new System.Drawing.Point(889, 294);
            this.FminLabel.Name = "FminLabel";
            this.FminLabel.Size = new System.Drawing.Size(0, 20);
            this.FminLabel.TabIndex = 9;
            // 
            // DataGrid
            // 
            this.DataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGrid.AutoGenerateColumns = false;
            this.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.xDataGridViewTextBoxColumn,
            this.yDataGridViewTextBoxColumn});
            this.DataGrid.DataSource = this.pointBindingSource;
            this.DataGrid.Location = new System.Drawing.Point(835, 341);
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.RowHeadersWidth = 51;
            this.DataGrid.RowTemplate.Height = 24;
            this.DataGrid.Size = new System.Drawing.Size(304, 234);
            this.DataGrid.TabIndex = 10;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // xDataGridViewTextBoxColumn
            // 
            this.xDataGridViewTextBoxColumn.DataPropertyName = "X";
            this.xDataGridViewTextBoxColumn.HeaderText = "X";
            this.xDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.xDataGridViewTextBoxColumn.Name = "xDataGridViewTextBoxColumn";
            this.xDataGridViewTextBoxColumn.Width = 125;
            // 
            // yDataGridViewTextBoxColumn
            // 
            this.yDataGridViewTextBoxColumn.DataPropertyName = "Y";
            this.yDataGridViewTextBoxColumn.HeaderText = "Y";
            this.yDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.yDataGridViewTextBoxColumn.Name = "yDataGridViewTextBoxColumn";
            this.yDataGridViewTextBoxColumn.Width = 125;
            // 
            // pointBindingSource
            // 
            this.pointBindingSource.DataSource = typeof(Lab2.Point);
            // 
            // FromFileButton
            // 
            this.FromFileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FromFileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FromFileButton.Location = new System.Drawing.Point(835, 164);
            this.FromFileButton.Name = "FromFileButton";
            this.FromFileButton.Size = new System.Drawing.Size(145, 53);
            this.FromFileButton.TabIndex = 11;
            this.FromFileButton.TabStop = false;
            this.FromFileButton.Text = "Read from file";
            this.FromFileButton.UseVisualStyleBackColor = true;
            this.FromFileButton.Click += new System.EventHandler(this.FromFileButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1143, 587);
            this.Controls.Add(this.FromFileButton);
            this.Controls.Add(this.DataGrid);
            this.Controls.Add(this.FminLabel);
            this.Controls.Add(this.FmaxLabel);
            this.Controls.Add(this.NoPTextBox);
            this.Controls.Add(this.TabulationCount);
            this.Controls.Add(this.XmaxTextBox);
            this.Controls.Add(this.XmaxLabel);
            this.Controls.Add(this.XminTextBox);
            this.Controls.Add(this.XminLabel);
            this.Controls.Add(this.Generate);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button Generate;
        private System.Windows.Forms.Label XminLabel;
        private System.Windows.Forms.TextBox XminTextBox;
        private System.Windows.Forms.TextBox XmaxTextBox;
        private System.Windows.Forms.Label XmaxLabel;
        private System.Windows.Forms.TextBox NoPTextBox;
        private System.Windows.Forms.Label TabulationCount;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label FminLabel;
        private System.Windows.Forms.Label FmaxLabel;
        private System.Windows.Forms.DataGridView DataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn xDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource pointBindingSource;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Button FromFileButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

