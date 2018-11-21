namespace DP2.UIComponents
{
    partial class UIDashboardCharts
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
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Monthb = new System.Windows.Forms.Button();
            this.Weekb = new System.Windows.Forms.Button();
            this.labelDashboardReport = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // Monthb
            // 
            this.Monthb.Location = new System.Drawing.Point(928, 32);
            this.Monthb.Name = "Monthb";
            this.Monthb.Size = new System.Drawing.Size(75, 23);
            this.Monthb.TabIndex = 30;
            this.Monthb.Text = "Monthly";
            this.Monthb.UseVisualStyleBackColor = true;
            this.Monthb.Click += new System.EventHandler(this.Monthb_Click);
            // 
            // Weekb
            // 
            this.Weekb.Location = new System.Drawing.Point(847, 32);
            this.Weekb.Name = "Weekb";
            this.Weekb.Size = new System.Drawing.Size(75, 23);
            this.Weekb.TabIndex = 29;
            this.Weekb.Text = "Weekly";
            this.Weekb.UseVisualStyleBackColor = true;
            this.Weekb.Click += new System.EventHandler(this.Weekb_Click);
            // 
            // labelDashboardReport
            // 
            this.labelDashboardReport.AutoSize = true;
            this.labelDashboardReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDashboardReport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.labelDashboardReport.Location = new System.Drawing.Point(779, 32);
            this.labelDashboardReport.Name = "labelDashboardReport";
            this.labelDashboardReport.Size = new System.Drawing.Size(66, 20);
            this.labelDashboardReport.TabIndex = 28;
            this.labelDashboardReport.Text = "Report :";
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.DimGray;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(15, 69);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Products Sold";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(481, 452);
            this.chart1.TabIndex = 31;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // chart2
            // 
            this.chart2.BackColor = System.Drawing.Color.DimGray;
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(523, 69);
            this.chart2.Name = "chart2";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Profit";
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(481, 452);
            this.chart2.TabIndex = 32;
            this.chart2.Text = "chart2";
            this.chart2.Click += new System.EventHandler(this.chart2_Click);
            // 
            // UIDashboardCharts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1016, 566);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.Monthb);
            this.Controls.Add(this.Weekb);
            this.Controls.Add(this.labelDashboardReport);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UIDashboardCharts";
            this.Text = "UIDashboardCharts";
            this.Load += new System.EventHandler(this.UIDashboardCharts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Monthb;
        private System.Windows.Forms.Button Weekb;
        private System.Windows.Forms.Label labelDashboardReport;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
    }
}