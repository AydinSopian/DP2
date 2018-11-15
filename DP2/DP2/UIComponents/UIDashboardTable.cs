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

        MySqlConnection cn;
        MySqlDataAdapter da;
        DataSet ds;
        DataTable dt;

        private void UIDashboardTable_Load(object sender, EventArgs e)
        {
          
        }

        private void Weekb_Click(object sender, EventArgs e)
        {
            cn = new MySqlConnection("datasource=35.198.212.34;port=3306;username=root;password=;database=dp2;sslmode=none");
            da = new MySqlDataAdapter("SELECT DAYNAME(dateTime) as 'Day', dateTime as 'Date & Time', ProductsSold.itemID as 'Item ID', Inventory.itemName as 'Item Name', ProductsSold.quantity as 'Item Quantity', ROUND(SUM((pricePerUnitSold - costPerUnitBought) * ProductsSold.quantity), 2) as 'Profit' FROM ProductsSold INNER JOIN Inventory ON ProductsSold.itemID = Inventory.itemID WHERE WEEK(dateTime) = WEEK(CURDATE()) GROUP BY ProductsSold.dateTime, ProductsSold.itemID", cn);
            ds = new DataSet();
            dt = new DataTable();

            dt.Rows.Clear();
            dataGridView1.Refresh();

            da.Fill(ds, "data");
            dt = ds.Tables["data"];
            dataGridView1.DataSource = dt;
        }

        private void Monthb_Click(object sender, EventArgs e)
        {
            cn = new MySqlConnection("datasource=35.198.212.34;port=3306;username=root;password=;database=dp2;sslmode=none");
            da = new MySqlDataAdapter("SELECT dateTime as 'Date & Time', ProductsSold.itemID as 'Item ID', Inventory.itemName as 'Item Name', ProductsSold.quantity as 'Item Quantity', ROUND(SUM((pricePerUnitSold - costPerUnitBought) * ProductsSold.quantity), 2) as 'Profit' FROM ProductsSold INNER JOIN Inventory ON ProductsSold.itemID = Inventory.itemID WHERE MONTH(dateTime) = MONTH(CURDATE()) GROUP BY ProductsSold.dateTime, ProductsSold.itemID", cn);
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
    }
}
