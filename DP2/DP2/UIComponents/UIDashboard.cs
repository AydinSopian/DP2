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
        }

        MySqlConnection cn;
        MySqlDataAdapter da;
        DataSet ds;
        DataTable dt;

        private void buttonDashboardGenerate_Click(object sender, EventArgs e)
        {
            cn = new MySqlConnection("datasource=35.198.212.34;port=3306;username=root;password=;database=dp2;sslmode=none");
            da = new MySqlDataAdapter("select * from Inventory", cn);
            ds = new DataSet();
            dt = new DataTable();

            da.Fill(ds, "invt");
            dt = ds.Tables["invt"];
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
    }
}
