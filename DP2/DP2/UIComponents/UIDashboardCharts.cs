using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;

namespace DP2.UIComponents
{
    public partial class UIDashboardCharts : Form
    {
        public UIDashboardCharts()
        {
            InitializeComponent();
        }

        private void UIDashboardCharts_Load(object sender, EventArgs e)
        {
            this.chart1.Titles.Clear();
            chart1.DataSource = UIDashboardTable.ds.Tables["data"];
            chart1.Series["Products Sold"].XValueType = ChartValueType.Date;
            chart1.Series["Products Sold"].XValueMember = "Date & Time";
            chart1.Series["Products Sold"].YValueMembers = "Price Total";
            this.chart1.Titles.Add("Price Total");
            chart1.ChartAreas[0].AxisX.Title = "Date";
            chart1.ChartAreas[0].AxisY.Title = "Price Total";
            chart1.Series["Products Sold"].ChartType = SeriesChartType.Line;
            chart1.Series["Products Sold"].Color = System.Drawing.Color.FromArgb(130, 25, 25);
            chart1.ChartAreas[0].AxisY.LabelStyle.Format = "{0:0,,}M";
            chart1.Series["Products Sold"].IsValueShownAsLabel = true;

            this.chart2.Titles.Clear();
            chart2.DataSource = UIDashboardTable.ds.Tables["data"];
            chart2.Series["Profit"].XValueType = ChartValueType.Date;
            chart2.Series["Profit"].XValueMember = "Date & Time";
            chart2.Series["Profit"].YValueMembers = "Profit";
            this.chart2.Titles.Add("Profit");
            chart2.ChartAreas[0].AxisX.Title = "Date";
            chart2.ChartAreas[0].AxisY.Title = "Profit";
            chart2.Series["Profit"].ChartType = SeriesChartType.Line;
            chart2.Series["Profit"].Color = System.Drawing.Color.FromArgb(130, 25, 25);
            chart2.ChartAreas[0].AxisY.LabelStyle.Format = "{0:0,,}M";
            chart2.Series["Profit"].IsValueShownAsLabel = true;
        }

        private void chart1_Click(object sender, EventArgs e)
        {
            
        }

        private void chart2_Click(object sender, EventArgs e)
        {
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.chart1.Titles.Clear();
            chart1.DataSource = UIDashboardTable.ds.Tables["data"];
            chart1.Series["Products Sold"].XValueType = ChartValueType.Date;
            chart1.Series["Products Sold"].XValueMember = "Date & Time";
            chart1.Series["Products Sold"].YValueMembers = "Price Total";
            this.chart1.Titles.Add("Price Total");
            chart1.ChartAreas[0].AxisX.Title = "Date";
            chart1.ChartAreas[0].AxisY.Title = "Price Total";
            chart1.Series["Products Sold"].ChartType = SeriesChartType.Line;
            chart1.Series["Products Sold"].Color = System.Drawing.Color.FromArgb(130, 25, 25);
            chart1.ChartAreas[0].AxisY.LabelStyle.Format = "{0:0,,}M";
            chart1.Series["Products Sold"].IsValueShownAsLabel = true;

            this.chart2.Titles.Clear();
            chart2.DataSource = UIDashboardTable.ds.Tables["data"];
            chart2.Series["Profit"].XValueType = ChartValueType.Date;
            chart2.Series["Profit"].XValueMember = "Date & Time";
            chart2.Series["Profit"].YValueMembers = "Profit";
            this.chart2.Titles.Add("Profit");
            chart2.ChartAreas[0].AxisX.Title = "Date";
            chart2.ChartAreas[0].AxisY.Title = "Profit";
            chart2.Series["Profit"].ChartType = SeriesChartType.Line;
            chart2.Series["Profit"].Color = System.Drawing.Color.FromArgb(130, 25, 25);
            chart2.ChartAreas[0].AxisY.LabelStyle.Format = "{0:0,,}M";
            chart2.Series["Profit"].IsValueShownAsLabel = true;
        }
    }
}
