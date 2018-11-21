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

        UIComponents.UIDashboardTable formDashboardTable;
        UIComponents.UIDashboardCharts formDashboardCharts;

        private void buttonDashboardGenerate_Click(object sender, EventArgs e)
        {
            string filename = OpenSavefileDialog();
            UIDashboardTable.dt.ToCSV(filename);
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
