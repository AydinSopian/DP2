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
    public partial class UIPayment : Form
    {
        public UIPayment()
        {
            InitializeComponent();
        }

        private void buttonPaymentConfirm_Click(object sender, EventArgs e)
        {
            //Show change
            this.Close();
            UIChange change = new UIChange();
            change.Show();

            //INSERT into Sales Table dataTime & Total

            //foreach row in dataGridSales, Insert into ProductsSold (dateTime, productId, Qty)

            //Clear dataGridSales

            //reset Incrmenters
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonPaymentCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
