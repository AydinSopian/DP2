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

        //declaring field variables
        private int _colNum, _colQty;
        private string _colCategory, _colItem;
        private double _colPricePerUnit, _colSubtotal, _salesTotal;


        //getters and setters for Form Data
        public void ClearData()
        {
            dataGridSales.Rows.Clear();
        }

        public int ColNum
        {
            get { return _colNum; }
            set { _colNum = value; }
        }

        public double SalesTotal
        {
            get { return _salesTotal; }
        }

        /*
        public int ColQty
        {
            get { return _colQty; }
            set { _colQty = value; }
        }

        public string ColCategory
        {
            get { return _colCategory; }
            set { _colCategory = value; }
        }

        public string ColItem
        {
            get { return _colItem; }
            set { _colItem = value; }
        }

        public double ColPricePerUnit
        {
            get { return _colPricePerUnit; }
            set { _colPricePerUnit = value; }
        }

        public double ColSubtotal
        {
            get { return _colSubtotal; }
            set { _colSubtotal = value; }
        }
        
        

        
        /******************************************************************/



        public formSales()
        {
            InitializeComponent();
            log = RequestLog.Instance;
            _colNum = 0;

        }

        private void buttonSalesCheckout_Click(object sender, EventArgs e)
        {
            //Open payment window
            UIComponents.UIPayment paymentWindow = new UIComponents.UIPayment(this);
            paymentWindow.ShowDialog();
        }

        private void formSales_Load(object sender, EventArgs e)
        {
            
        }

        private void dataGridSales_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridSales.Columns[e.ColumnIndex].Name == "salesDeleteRow")
            {
                salesTransactionBindingSource.RemoveCurrent();
            }
        }

        private void buttonSalesAdd_Click(object sender, EventArgs e)
        {
            //VALIDATE DATA
            Classes.DataValidation dataValidation = new Classes.DataValidation();

            bool categoryIsValid = dataValidation.ValidateString(textSalesCategory.Text);
            bool itemIsValid = dataValidation.ValidateString(textSalesItem.Text);
            bool qtyIsValid = dataValidation.ValidateInteger(textSalesQty.Text);

            //UPDATE FIELDS
            _colNum++;
            //_colPricePerUnit = ???

            //IF DATA IS VALID, STORE THEM IN RESPECTIVE VARIABLES
            if (categoryIsValid)
            {
                _colCategory = textSalesCategory.Text;
            }

            if (itemIsValid)
            {
                _colItem = textSalesItem.Text;
            }

            if (qtyIsValid)
            {
                _colQty = int.Parse(textSalesQty.Text);
                //_colSubtotal = _colQty * _colPricePerUnit;
            }

            //IF ALL DATA IS VALID, ADD NEW ROW TO DATAGRIDVIEW
            if (categoryIsValid && itemIsValid && qtyIsValid)
            {
                salesTransactionBindingSource.Add(new Classes.salesTransaction()
                {
                    number = _colNum,
                    category = _colCategory,
                    item = _colItem,
                    qty = _colQty
                    //, pricePerUnit = colPricePerUnit,
                    //subtotal = colSubtotal
                });
            } else
            {

            }
            

            //set cursor focus to category upon adding item AND clear text boxes
            textSalesCategory.Clear();
            textSalesItem.Clear();
            textSalesQty.Clear();
            textSalesCategory.Focus();

        }

        private void textSalesCategory_Enter(object sender, EventArgs e)
        {
            textSalesCategory.SelectionStart = 0;
            textSalesCategory.SelectionLength = Text.Length;
        }

        private void textSalesItem_Enter(object sender, EventArgs e)
        {
            textSalesItem.SelectionStart = 0;
            textSalesItem.SelectionLength = Text.Length;
        }

        private void textSalesQty_Enter(object sender, EventArgs e)
        {
            textSalesQty.SelectionStart = 0;
            textSalesQty.SelectionLength = Text.Length;
        }
    }
}
