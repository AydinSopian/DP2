using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DP2
{
    public partial class formSales: Form
    {
        private RequestLog log;
        private DataGridViewRow row;
        private int productsSoldIncrement, rowIncrement;

        public formSales()
        {
            InitializeComponent();
            log = RequestLog.Instance;
            productsSoldIncrement = 0;
            rowIncrement = 0;
            row = (DataGridViewRow)dataGridSales.Rows[rowIncrement].Clone();
        }

        private void buttonSalesCheckout_Click(object sender, EventArgs e)
        {
            //INSERT into Sales Table dataTime & Total

            //foreach row in dataGridSales, Insert into ProductsSold dateTime, productId, Qty
        }

        private void buttonSalesAdd_Click(object sender, EventArgs e)
        {
            productsSoldIncrement++;
            row.Cells[0].Value = productsSoldIncrement;
            row.Cells[1].Value = textSalesItem.Text;
            row.Cells[2].Value = textSalesQty.Text;
            //row.Cells[3].Value = pricePerUnit of item
            //row.Cells[4].Value = pricePerUnit of item multiplied by Qty
            dataGridSales.Rows.Add(row);

            rowIncrement++;
            row = (DataGridViewRow)dataGridSales.Rows[rowIncrement].Clone();
        }
    }
}
