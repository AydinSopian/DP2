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

        MySqlConnection cn;
        MySqlDataAdapter da;
        DataSet ds;
        DataTable dt;

        private void Weekb_Click(object sender, EventArgs e)
        {
            cn = new MySqlConnection("datasource=35.198.212.34;port=3306;username=root;password=;database=dp2;sslmode=none");
            da = new MySqlDataAdapter("SELECT DAYNAME(dateTime) as 'Day', dateTime as 'Date & Time', ProductsSold.itemID as 'Item ID', ProductsSold.quantity as 'Item Quantity', ROUND(SUM((pricePerUnitSold - costPerUnitBought) * ProductsSold.quantity), 2) as 'Profit' FROM ProductsSold INNER JOIN Inventory ON ProductsSold.itemID = Inventory.itemID WHERE WEEK(dateTime) = WEEK(CURDATE()) GROUP BY ProductsSold.dateTime, ProductsSold.itemID", cn);
            ds = new DataSet();
            dt = new DataTable();

            da.Fill(ds, "data");

            this.chart1.Titles.Clear();
            chart1.DataSource = ds.Tables["data"];
            chart1.Series["Products Sold"].XValueMember = "Item ID";
            chart1.Series["Products Sold"].YValueMembers = "Item Quantity";
            this.chart1.Titles.Add("Weekly Report (Products Sold)");
            chart1.Series["Products Sold"].ChartType = SeriesChartType.Line;
            chart1.Series["Products Sold"].IsValueShownAsLabel = true;

            this.chart2.Titles.Clear();
            chart2.DataSource = ds.Tables["data"];
            chart2.Series["Profit"].XValueMember = "Item ID";
            chart2.Series["Profit"].YValueMembers = "Profit";
            this.chart2.Titles.Add("Weekly Report (Profit)");
            chart2.Series["Profit"].ChartType = SeriesChartType.Line;
            chart2.Series["Profit"].IsValueShownAsLabel = true;
        }

        private void Monthb_Click(object sender, EventArgs e)
        {
            cn = new MySqlConnection("datasource=35.198.212.34;port=3306;username=root;password=;database=dp2;sslmode=none");
            da = new MySqlDataAdapter("SELECT dateTime as 'Date & Time', ProductsSold.itemID as 'Item ID', ProductsSold.quantity as 'Item Quantity', ROUND(SUM((pricePerUnitSold - costPerUnitBought) * ProductsSold.quantity), 2) as 'Profit' FROM ProductsSold INNER JOIN Inventory ON ProductsSold.itemID = Inventory.itemID WHERE MONTH(dateTime) = MONTH(CURDATE()) GROUP BY ProductsSold.dateTime, ProductsSold.itemID", cn);
            ds = new DataSet();
            dt = new DataTable();

            da.Fill(ds, "data");

            this.chart1.Titles.Clear();
            chart1.DataSource = ds.Tables["data"];
            chart1.Series["Products Sold"].XValueMember = "Item ID";
            chart1.Series["Products Sold"].YValueMembers = "Item Quantity";
            this.chart1.Titles.Add("Monthly Report (Products Sold)");
            chart1.Series["Products Sold"].ChartType = SeriesChartType.Line;
            chart1.Series["Products Sold"].IsValueShownAsLabel = true;

            this.chart2.Titles.Clear();
            chart2.DataSource = ds.Tables["data"];
            chart2.Series["Profit"].XValueMember = "Item ID";
            chart2.Series["Profit"].YValueMembers = "Profit";
            this.chart2.Titles.Add("Monthly Report (Profit)");
            chart2.Series["Profit"].ChartType = SeriesChartType.Line;
            chart2.Series["Profit"].IsValueShownAsLabel = true;
        }

        private void UIDashboardCharts_Load(object sender, EventArgs e)
        {
           
        }

        private void chart1_Click(object sender, EventArgs e)
        {
    
        }

        private void chart2_Click(object sender, EventArgs e)
        {

        }
    }
}
