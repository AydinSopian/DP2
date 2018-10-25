﻿using System;
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
        private decimal _amountPaid;
        private decimal _salesTotal;
        private string values;
        private RequestLog log;

        //getter for _salesTotal
        public decimal SalesTotal {
            get { return _salesTotal; }
        }

        public decimal AmountPaid
        {
            get { return _amountPaid; }
        }

        public UIPayment(UISalesTransaction parentForm)
        {
            InitializeComponent();
            _parentForm = parentForm;
            _salesTotal = _parentForm.SalesTotal;
            labelPaymentTotal.Text = "RM " + _parentForm.SalesTotal.ToString();
            log = RequestLog.Instance;
        }

        private void buttonPaymentConfirm_Click(object sender, EventArgs e)
        {
            //DATA VALIDATION
            Classes.DataValidation dataValidation = new Classes.DataValidation();
            bool amountIsValid = dataValidation.ValidateDouble(textPaymentAmount.Text);

            if (amountIsValid)
            {
                _amountPaid = Decimal.Parse(textPaymentAmount.Text);

                //check to see if amountPaid is greater than total
                if (_amountPaid >= _parentForm.SalesTotal)
                {
                    UIConfirmation confirmation = new UIConfirmation("Do you want to continue?", "Continue", "Cancel");
                    confirmation.ShowDialog();

                    if (confirmation.isConfirmed)
                    {

                        
                        _parentForm.ColNum = 0;
                        //Show change
                        UIChange change = new UIChange(this);
                        change.ShowDialog();
                        this.Close();

                        //INSERT into Sales table, dataTime & priceTotal
                        DateTime currentDateTime = DateTime.Now;
                        string dateTime = currentDateTime.ToString("yyyy-MM-dd HH:mm:ss");
                        string priceTotal = _parentForm.SalesTotal.ToString();
                        values = "\'" + dateTime + "\'" + "," + priceTotal;
                        log.RunQuery(3, "Sales", "dateTime, priceTotal", "", values);


                        //foreach row in dataGridSales, INSERT into ProductsSold (dateTime, productId, quantity)
                       
                        foreach(DataRow dr in _parentForm.GetDataTable().Rows)
                        {
                            log.RunQuery(3, "ProductsSold", "datetime, itemid, quantity", "", "\'"+dateTime+"\', " + dr[0] +", "+ dr[2]);
                        }

                        //foreach row in dataGridSales, UPDATE Inventory table, quantity
                        foreach (DataRow dr in _parentForm.GetDataTable().Rows)
                        {
                            log.RunQuery(4, "Inventory", "", "itemid=" + dr[0], "quantity = quantity - " + dr[2]);
                        }
                        //Clear dataGridSales
                        _parentForm.ClearData();
                    }
                
                }
                else
                {
                    UIError error = new UIError("Amount paid not sufficient", "OK");
                    error.ShowDialog();
                }
            }
            else
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
