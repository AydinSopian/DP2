using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DP2.UIComponents
{
    public partial class UIDashboardTable : Form
    {
        public UIDashboardTable()
        {
            InitializeComponent();
        }

        private void UIDashboardTable_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dp2DataSet.ProductsSold' table. You can move, or remove it, as needed.
            this.productsSoldTableAdapter.Fill(this.dp2DataSet.ProductsSold);
            // TODO: This line of code loads data into the 'dp2DataSet.Sales' table. You can move, or remove it, as needed.
            this.salesTableAdapter.Fill(this.dp2DataSet.Sales);
            // TODO: This line of code loads data into the 'dp2DataSet.Inventory' table. You can move, or remove it, as needed.
            this.inventoryTableAdapter.Fill(this.dp2DataSet.Inventory);

            this.reportViewer1.RefreshReport();
        }
    }
}
