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
    public partial class UIDashboard : Form
    {
        public UIDashboard()
        {
            InitializeComponent();
            this.content.AutoScroll = true;
        }

        MySqlConnection cn;
        MySqlDataAdapter da;
        DataSet ds;
        DataTable dt;
        UIComponents.UIDashboardTable formDashboardTable;
        UIComponents.UIDashboardCharts formDashboardCharts;

        private void buttonDashboardGenerate_Click(object sender, EventArgs e)
        {
            cn = new MySqlConnection("datasource=35.198.212.34;port=3306;username=root;password=;database=dp2;sslmode=none");
            da = new MySqlDataAdapter("SELECT dateTime as 'Date & Time', ProductsSold.itemID as 'Item ID', Inventory.itemName as 'Item Name', ProductsSold.quantity as 'Item Quantity', ROUND(SUM((pricePerUnitSold - costPerUnitBought) * ProductsSold.quantity), 2) as 'Profit' FROM ProductsSold INNER JOIN Inventory ON ProductsSold.itemID = Inventory.itemID WHERE MONTH(dateTime) = MONTH(CURDATE()) GROUP BY ProductsSold.dateTime, ProductsSold.itemID", cn);
            ds = new DataSet();
            dt = new DataTable();

            da.Fill(ds, "data");
            dt = ds.Tables["data"];
            string filename = OpenSavefileDialog();
            dt.ToCSV(filename);
        }

        private void buttonDashboardWCSV_Click(object sender, EventArgs e)
        {
            cn = new MySqlConnection("datasource=35.198.212.34;port=3306;username=root;password=;database=dp2;sslmode=none");
            da = new MySqlDataAdapter("SELECT DAYNAME(dateTime) as 'Day', dateTime as 'Date & Time', ProductsSold.itemID as 'Item ID', Inventory.itemName as 'Item Name', ProductsSold.quantity as 'Item Quantity', ROUND(SUM((pricePerUnitSold - costPerUnitBought) * ProductsSold.quantity), 2) as 'Profit' FROM ProductsSold INNER JOIN Inventory ON ProductsSold.itemID = Inventory.itemID WHERE WEEK(dateTime) = WEEK(CURDATE()) GROUP BY ProductsSold.dateTime, ProductsSold.itemID", cn);
            ds = new DataSet();
            dt = new DataTable();

            da.Fill(ds, "data");
            dt = ds.Tables["data"];
            string filename = OpenSavefileDialog();
            dt.ToCSV(filename);
        }

        private string OpenSavefileDialog()
        {
            string Filename = null;
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "csv File|*.csv";
            saveFileDialog.Title = "Save Report";
            DialogResult dialogResult = saveFileDialog.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                Filename = saveFileDialog.FileName;

            }

            return Filename;


        }

        private void dataGridDashboard_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonDashboardTables_Click(object sender, EventArgs e)
        {
            Control ctrl = ((Control)sender);
            ctrl.BackColor = System.Drawing.ColorTranslator.FromHtml("#404040");
            buttonDashboardCharts.BackColor = System.Drawing.ColorTranslator.FromHtml("#232323");

            
            formDashboardTable.TopLevel = false;
            content.Controls.Clear();
            content.Controls.Add(formDashboardTable);
            formDashboardTable.Show();
        }

        private void buttonDashboardCharts_Click(object sender, EventArgs e)
        {
            Control ctrl = ((Control)sender);
            ctrl.BackColor = System.Drawing.ColorTranslator.FromHtml("#404040");
            buttonDashboardTables.BackColor = System.Drawing.ColorTranslator.FromHtml("#232323");

           
            formDashboardCharts.TopLevel = false;
            content.Controls.Clear();
            content.Controls.Add(formDashboardCharts);
            formDashboardCharts.Show();
        }

        private void UIDashboard_Load(object sender, EventArgs e)
        {
            formDashboardTable = new UIDashboardTable();
            formDashboardCharts = new UIDashboardCharts();

            buttonDashboardTables.BackColor = System.Drawing.ColorTranslator.FromHtml("#404040");
            buttonDashboardCharts.BackColor = System.Drawing.ColorTranslator.FromHtml("#232323");


            formDashboardTable.TopLevel = false;
            content.Controls.Clear();
            content.Controls.Add(formDashboardTable);
            formDashboardTable.Show();
        }

        private void content_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
