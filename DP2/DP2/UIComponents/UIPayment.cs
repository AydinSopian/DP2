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
        private formSales _parentForm;

        public UIPayment(formSales parentForm)
        {
            InitializeComponent();
            _parentForm = parentForm;
        }

        private void buttonPaymentConfirm_Click(object sender, EventArgs e)
        {
            
            confirmation1 confirmation = new confirmation1();
            confirmation.ShowDialog();

            if (confirmation.isConfirmed)
            {
                this.Close();

                //Show change
                UIChange change = new UIChange();
                change.ShowDialog();

                //INSERT into Sales Table dataTime & Total

                //foreach row in dataGridSales, Insert into ProductsSold (dateTime, productId, Qty)

                //Clear dataGridSales

                //reset Incrmenters

                //Clear dataGridSales
                _parentForm.ClearData();
            }


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
