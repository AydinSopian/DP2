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
    public partial class UIDashboardCharts2 : Form
    {
        private bool check1 = false, check2 = false, check3 = false, check4 = false;

        public UIDashboardCharts2()
        {
            InitializeComponent();
        }



        private void UIDashboardCharts2_Load(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                check2 = true;
            }
            else { check2 = false; }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                check4 = true;
            }
            else { check4 = false; }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                check1 = true;
            }
            else { check1 = false; }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
                check3 = true;
            }
            else { check3 = false; }
        }

        private void chart2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                check2 = true;
            }
            else { check2 = false; }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string MySQLConnectionString = "datasource=35.198.212.34;port=3306;username=root;password=;database=dp2;sslmode=none";

            MySqlConnection databaseConnection = new MySqlConnection(MySQLConnectionString);


            if (check1 == true)
            {
                string query3 = "select DATE_FORMAT(convert(dateTime,date), '%Y-%m-%d') as Date,count(priceTotal) as Sales from Sales ";
                string date1;
                string date2;

                date1 = " '" + dateTimePicker1.Text + "%" + "' ";
                date2 = " '" + dateTimePicker2.Text + "%" + "' ";

                query3 += "where dateTime between " + date1 + "and" + date2 + "group by DATE_FORMAT(convert(dateTime,date), '%Y-%m-%d');";

                MySqlDataAdapter ad3 = new MySqlDataAdapter(query3, databaseConnection);

                DataTable dt3 = new DataTable();
                DataSet ds3 = new DataSet();
                ad3.Fill(ds3, "data");

                this.chart2.Titles.Clear();
                chart2.DataSource = ds3.Tables["data"];
                chart2.Series["Revenue"].XValueMember = "Date";
                chart2.Series["Revenue"].YValueMembers = "Sales";
                this.chart2.Titles.Add("Sales Per Day");
                chart2.ChartAreas[0].AxisX.Title = "Date";
                chart2.ChartAreas[0].AxisY.Title = "Sales";
                chart2.Series["Revenue"].ChartType = SeriesChartType.Column;
                chart2.Series["Revenue"].IsValueShownAsLabel = true;
            }
            if (check2 == true)
            {
                string query1 = "select DATE_FORMAT(convert(dateTime,date), '%Y-%m-%d') as Date,sum(priceTotal) as Revenue FROM Sales ";
                string date1;
                string date2;

                date1 = " '" + dateTimePicker1.Text + "%" + "' ";
                date2 = " '" + dateTimePicker2.Text + "%" + "' ";

                query1 += "where dateTime between " + date1 + "and" + date2 + "group by DATE_FORMAT(convert(dateTime,date), '%Y-%m-%d');";

                MySqlDataAdapter ad = new MySqlDataAdapter(query1, databaseConnection);

                DataTable dt = new DataTable();
                DataSet ds = new DataSet();
                ad.Fill(ds, "data");

                this.chart2.Titles.Clear();
                chart2.DataSource = ds.Tables["data"];
                chart2.Series["Revenue"].XValueMember = "Date";
                chart2.Series["Revenue"].YValueMembers = "Revenue";
                this.chart2.Titles.Add("Revenue Per Day");
                chart2.ChartAreas[0].AxisX.Title = "Date";
                chart2.ChartAreas[0].AxisY.Title = "Revenue (RM)";
                chart2.Series["Revenue"].ChartType = SeriesChartType.Column;
                chart2.Series["Revenue"].IsValueShownAsLabel = true;
            }

            if (check3 == true)
            {

                string query4 = "select DATE_FORMAT(convert(dateTime,date), '%Y-%m-%d') as Date, (Inventory.pricePerUnitSold - Inventory.costPerUnitBought) * ProductsSold.quantity as Profit from ProductsSold Inner join Inventory on ProductsSold.itemID = Inventory.itemID ";
                string date1;
                string date2;

                date1 = " '" + dateTimePicker1.Text + "%" + "' ";
                date2 = " '" + dateTimePicker2.Text + "%" + "' ";

                query4 += "where dateTime between " + date1 + "and" + date2 + "group by Date,Profit;";

                MySqlDataAdapter ad4 = new MySqlDataAdapter(query4, databaseConnection);

                DataTable dt = new DataTable();
                DataSet ds = new DataSet();
                ad4.Fill(ds, "data");

                this.chart2.Titles.Clear();
                chart2.DataSource = ds.Tables["data"];
                chart2.Series["Revenue"].XValueMember = "Date";
                chart2.Series["Revenue"].YValueMembers = "Profit";
                this.chart2.Titles.Add("Profit");
                chart2.ChartAreas[0].AxisX.Title = "Date";
                chart2.ChartAreas[0].AxisY.Title = "Profit (RM)";
                chart2.Series["Revenue"].ChartType = SeriesChartType.Column;
                chart2.Series["Revenue"].IsValueShownAsLabel = true;
            }

            if (check4 == true)
            {
                string query2 = "select itemName as Item, quantity as Quantity from Inventory;";

                MySqlDataAdapter ad = new MySqlDataAdapter(query2, databaseConnection);

                DataTable dt2 = new DataTable();
                DataSet ds2 = new DataSet();
                ad.Fill(ds2, "data");

                this.chart2.Titles.Clear();
                chart2.DataSource = ds2.Tables["data"];
                chart2.Series["Revenue"].XValueMember = "Item";
                chart2.Series["Revenue"].YValueMembers = "Quantity";
                this.chart2.Titles.Add("Inventory Quantity");
                chart2.ChartAreas[0].AxisX.Title = "Item Name";
                chart2.ChartAreas[0].AxisY.Title = "Quantity";
                chart2.Series["Revenue"].ChartType = SeriesChartType.Column;
                chart2.Series["Revenue"].IsValueShownAsLabel = true;
            }

        }
    }
}
