
namespace ShopApp.custom
{
    partial class AdminSalesDOW
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataSet1 = new ShopApp.DataSet1();
            this.pURCHASEVIEWDOW1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pURCHASE_VIEW_DOW1TableAdapter = new ShopApp.DataSet1TableAdapters.PURCHASE_VIEW_DOW1TableAdapter();
            this.dAYOFWEEKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tOTALPRICEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tOTALSTOCKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.chart4 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pURCHASEVIEWDOW1BindingSource)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart4)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("던파 비트비트체 TTF", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1010, 500);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dAYOFWEEKDataGridViewTextBoxColumn,
            this.tOTALPRICEDataGridViewTextBoxColumn,
            this.tOTALSTOCKDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pURCHASEVIEWDOW1BindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(434, 500);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pURCHASEVIEWDOW1BindingSource
            // 
            this.pURCHASEVIEWDOW1BindingSource.DataMember = "PURCHASE_VIEW_DOW1";
            this.pURCHASEVIEWDOW1BindingSource.DataSource = this.dataSet1;
            // 
            // pURCHASE_VIEW_DOW1TableAdapter
            // 
            this.pURCHASE_VIEW_DOW1TableAdapter.ClearBeforeFill = true;
            // 
            // dAYOFWEEKDataGridViewTextBoxColumn
            // 
            this.dAYOFWEEKDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dAYOFWEEKDataGridViewTextBoxColumn.DataPropertyName = "DAY_OF_WEEK";
            this.dAYOFWEEKDataGridViewTextBoxColumn.HeaderText = "요일";
            this.dAYOFWEEKDataGridViewTextBoxColumn.Name = "dAYOFWEEKDataGridViewTextBoxColumn";
            this.dAYOFWEEKDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tOTALPRICEDataGridViewTextBoxColumn
            // 
            this.tOTALPRICEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tOTALPRICEDataGridViewTextBoxColumn.DataPropertyName = "TOTAL_PRICE";
            this.tOTALPRICEDataGridViewTextBoxColumn.HeaderText = "총 판매액";
            this.tOTALPRICEDataGridViewTextBoxColumn.Name = "tOTALPRICEDataGridViewTextBoxColumn";
            this.tOTALPRICEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tOTALSTOCKDataGridViewTextBoxColumn
            // 
            this.tOTALSTOCKDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tOTALSTOCKDataGridViewTextBoxColumn.DataPropertyName = "TOTAL_STOCK";
            this.tOTALSTOCKDataGridViewTextBoxColumn.HeaderText = "총 판매량";
            this.tOTALSTOCKDataGridViewTextBoxColumn.Name = "tOTALSTOCKDataGridViewTextBoxColumn";
            this.tOTALSTOCKDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.tabControl1.Location = new System.Drawing.Point(433, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(577, 500);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.chart1);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(569, 469);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "판매액 차트(PIE)";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            chartArea1.AxisX.Title = "제품명";
            chartArea1.AxisY.Title = "총 매출액";
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.DataSource = this.pURCHASEVIEWDOW1BindingSource;
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(3, 3);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Font = new System.Drawing.Font("던파 비트비트체 TTF", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.XValueMember = "DAY_OF_WEEK";
            series1.YValueMembers = "TOTAL_PRICE";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(563, 463);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.chart3);
            this.tabPage3.Location = new System.Drawing.Point(4, 27);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(569, 469);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "판매액 차트(BAR)";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // chart3
            // 
            chartArea2.AxisX.Title = "요일";
            chartArea2.AxisX.TitleFont = new System.Drawing.Font("던파 비트비트체 TTF", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea2.AxisY.Title = "총 판매액";
            chartArea2.AxisY.TitleFont = new System.Drawing.Font("던파 비트비트체 TTF", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea2.Name = "ChartArea1";
            this.chart3.ChartAreas.Add(chartArea2);
            this.chart3.DataSource = this.pURCHASEVIEWDOW1BindingSource;
            this.chart3.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Enabled = false;
            legend2.Font = new System.Drawing.Font("던파 비트비트체 TTF", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend2.IsTextAutoFit = false;
            legend2.Name = "Legend1";
            this.chart3.Legends.Add(legend2);
            this.chart3.Location = new System.Drawing.Point(3, 3);
            this.chart3.Name = "chart3";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series2.Font = new System.Drawing.Font("던파 비트비트체 TTF", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            series2.XValueMember = "DAY_OF_WEEK";
            series2.YValueMembers = "TOTAL_PRICE";
            this.chart3.Series.Add(series2);
            this.chart3.Size = new System.Drawing.Size(563, 463);
            this.chart3.TabIndex = 2;
            this.chart3.Text = "chart3";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.chart4);
            this.tabPage4.Location = new System.Drawing.Point(4, 27);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(569, 469);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "판매량 차트(PIE)";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // chart4
            // 
            chartArea3.Name = "ChartArea1";
            this.chart4.ChartAreas.Add(chartArea3);
            this.chart4.DataSource = this.pURCHASEVIEWDOW1BindingSource;
            this.chart4.Dock = System.Windows.Forms.DockStyle.Fill;
            legend3.Enabled = false;
            legend3.Name = "Legend1";
            this.chart4.Legends.Add(legend3);
            this.chart4.Location = new System.Drawing.Point(0, 0);
            this.chart4.Name = "chart4";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series3.Font = new System.Drawing.Font("던파 비트비트체 TTF", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            series3.XValueMember = "DAY_OF_WEEK";
            series3.YValueMembers = "TOTAL_STOCK";
            series3.YValuesPerPoint = 3;
            this.chart4.Series.Add(series3);
            this.chart4.Size = new System.Drawing.Size(569, 469);
            this.chart4.TabIndex = 1;
            this.chart4.Text = "chart4";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.chart2);
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(569, 469);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "판매량 차트(BAR)";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // chart2
            // 
            chartArea4.AxisX.Title = "요일";
            chartArea4.AxisX.TitleFont = new System.Drawing.Font("던파 비트비트체 TTF", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            chartArea4.AxisY.Title = "총 판매량";
            chartArea4.AxisY.TitleFont = new System.Drawing.Font("던파 비트비트체 TTF", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            chartArea4.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea4);
            this.chart2.DataSource = this.pURCHASEVIEWDOW1BindingSource;
            this.chart2.Dock = System.Windows.Forms.DockStyle.Fill;
            legend4.Enabled = false;
            legend4.Name = "Legend1";
            this.chart2.Legends.Add(legend4);
            this.chart2.Location = new System.Drawing.Point(3, 3);
            this.chart2.Name = "chart2";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series4.Font = new System.Drawing.Font("던파 비트비트체 TTF", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            series4.XValueMember = "DAY_OF_WEEK";
            series4.YValueMembers = "TOTAL_STOCK";
            series4.YValuesPerPoint = 3;
            this.chart2.Series.Add(series4);
            this.chart2.Size = new System.Drawing.Size(563, 463);
            this.chart2.TabIndex = 0;
            this.chart2.Text = "chart2";
            this.chart2.Click += new System.EventHandler(this.chart2_Click);
            // 
            // AdminSalesDOW
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 500);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminSalesDOW";
            this.Text = "AdminSalesDOW";
            this.Load += new System.EventHandler(this.AdminSalesDOW_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pURCHASEVIEWDOW1BindingSource)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart4)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource pURCHASEVIEWDOW1BindingSource;
        private DataSet1TableAdapters.PURCHASE_VIEW_DOW1TableAdapter pURCHASE_VIEW_DOW1TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dAYOFWEEKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tOTALPRICEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tOTALSTOCKDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart4;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
    }
}