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

namespace DP2.UIComponents
{
    public partial class UIDashboardTable : Form
    {
        public UIDashboardTable()
        {
            InitializeComponent();
        }

        public static MySqlConnection cn;
        public static MySqlDataAdapter da;
        public static DataSet ds;
        public static DataTable dt;

        private void UIDashboardTable_Load(object sender, EventArgs e)
        {
            cn = new MySqlConnection("datasource=35.198.212.34;port=3306;username=root;password=;database=dp2;sslmode=none");
            da = new MySqlDataAdapter("SELECT DAYNAME(ProductsSold.dateTime) as 'Day', ProductsSold.dateTime as 'Date & Time', ProductsSold.itemID as 'Item ID', Inventory.itemName as 'Item Name', Sales.priceTotal as 'Price Total', ProductsSold.quantity as 'Item Quantity', ROUND(SUM((pricePerUnitSold - costPerUnitBought) * ProductsSold.quantity), 2) as 'Profit' FROM Inventory INNER JOIN ProductsSold ON Inventory.itemID = ProductsSold.itemID INNER JOIN Sales ON ProductsSold.dateTime = Sales.dateTime WHERE WEEK(ProductsSold.dateTime) = WEEK(CURDATE()) GROUP BY ProductsSold.dateTime, ProductsSold.itemID", cn);
            ds = new DataSet();
            dt = new DataTable();

            dt.Rows.Clear();
            dataGridView1.Refresh();

            da.Fill(ds, "data");
            dt = ds.Tables["data"];
            dataGridView1.DataSource = dt;
        }

        private void labelDashboardReport_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dt.Rows.Clear();
            dataGridView1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cn = new MySqlConnection("datasource=35.198.212.34;port=3306;username=root;password=;database=dp2;sslmode=none");
            da = new MySqlDataAdapter("SELECT DAYNAME(ProductsSold.dateTime) as 'Day', ProductsSold.dateTime as 'Date & Time', ProductsSold.itemID as 'Item ID', Inventory.itemName as 'Item Name', Sales.priceTotal as 'Price Total', ProductsSold.quantity as 'Item Quantity', ROUND(SUM((pricePerUnitSold - costPerUnitBought) * ProductsSold.quantity), 2) as 'Profit' FROM Inventory INNER JOIN ProductsSold ON Inventory.itemID = ProductsSold.itemID INNER JOIN Sales ON ProductsSold.dateTime = Sales.dateTime WHERE ProductsSold.dateTime BETWEEN '" + dateTimePicker1.Value.ToString("yyyy/MM/dd HH:mm:ss") + "' AND '" + dateTimePicker2.Value.ToString("yyyy/MM/dd HH:mm:ss") + "' GROUP BY ProductsSold.dateTime, ProductsSold.itemID", cn);
            ds = new DataSet();
            dt = new DataTable();

            dt.Rows.Clear();
            dataGridView1.Refresh();

            da.Fill(ds, "data");
            dt = ds.Tables["data"];
            dataGridView1.DataSource = dt;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
