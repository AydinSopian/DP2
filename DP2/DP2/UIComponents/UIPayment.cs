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
        private UISalesTransaction _parentForm;
        private double amountPaid;

        public UIPayment(UISalesTransaction parentForm)
        {
            InitializeComponent();
            _parentForm = parentForm;
        }

        private void buttonPaymentConfirm_Click(object sender, EventArgs e)
        {
            //DATA VALIDATION
            Classes.DataValidation dataValidation = new Classes.DataValidation();
            bool amountIsValid = dataValidation.ValidateDouble(textPaymentAmount.Text);

            if (amountIsValid)
            {
                amountPaid = Double.Parse(textPaymentAmount.Text);

                //check to see if amountPaid is greater than total
                if (amountPaid >= _parentForm.SalesTotal)
                {
                    UIConfirmation confirmation = new UIConfirmation("Do you want to continue?", "Continue", "Cancel");
                    confirmation.ShowDialog();

                    if (confirmation.isConfirmed)
                    {

                        this.Close();
                        _parentForm.ColNum = 0;
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
                    else
                    {
                        UIError error = new UIError("Amount paid not sufficient", "OK");
                        error.ShowDialog();
                    }

                
                }
            } else
            {
                UIError error = new UIError("Please enter a valid amount", "OK");
                error.ShowDialog();
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

        private void UIPayment_Load(object sender, EventArgs e)
        {

        }
    }
}
