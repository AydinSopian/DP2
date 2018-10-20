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
    public partial class UISalesTransaction: Form
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


        public UISalesTransaction()
        {
            InitializeComponent();
            log = RequestLog.Instance;
           
            _colNum = 0;

            textSalesItem.ValueMember = "itemName";
            textSalesItem.DataSource = log.RunQuery(1, "Inventory", "itemName", "", "");

            textSalesItem.SelectedIndex = -1;
            
        }

        private void buttonSalesCheckout_Click(object sender, EventArgs e)
        {
            //set _salesTotal
            

            //Open payment window
            UIComponents.UIPayment paymentWindow = new UIComponents.UIPayment(this);
            paymentWindow.ShowDialog();
        }

        private void formSales_Load(object sender, EventArgs e)
        {
            foreach(var column in dataGridSales.Columns)
            {
                if (column is DataGridViewImageColumn)
                {
                    (column as DataGridViewImageColumn).DefaultCellStyle.NullValue = null;
                }
                    
            }
          
        }


        private void dataGridSales_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridSales.Columns[e.ColumnIndex].Name == "salesDeleteRow")
            {
                salesTransactionBindingSource.RemoveCurrent();
            }
            

        }

        private void dataGridSales_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            
        }

        private void textSalesItem_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonSalesAdd_Click(object sender, EventArgs e)
        {
            //VALIDATE DATA
            Classes.DataValidation dataValidation = new Classes.DataValidation();

            bool itemIsValid = dataValidation.ValidateString(textSalesItem.Text);
            bool qtyIsValid = dataValidation.ValidateInteger(textSalesQty.Text);

            //UPDATE FIELDS      
            //IF DATA IS VALID, STORE THEM IN RESPECTIVE VARIABLES

            if (itemIsValid)
            {
                string queryCondition = "itemName = " + "\"" + _colItem + "\"";
                log.RunQuery(1, "Inventory", "costPerUnitBought", queryCondition,"");
                
                //_colPricePerUnit = ???
                _colItem = textSalesItem.Text;
            }

            if (qtyIsValid)
            {
                _colQty = int.Parse(textSalesQty.Text);
                //_colSubtotal = _colQty * _colPricePerUnit;
            }

            //IF ALL DATA IS VALID, ADD NEW ROW TO DATAGRIDVIEW
            if (itemIsValid && qtyIsValid)
            {
                _colNum++;
                salesTransactionBindingSource.Add(new Classes.salesTransaction()
                {
                    number = _colNum,
                    category = _colCategory,
                    item = _colItem,
                    qty = _colQty
                    //, pricePerUnit = colPricePerUnit,
                    //subtotal = colSubtotal
                });

                //set cursor focus to category upon adding item AND clear text boxes
                textSalesQty.Clear();
                textSalesItem.Focus();

            }
            else
            {
                UIComponents.UIError errorMessage = new UIComponents.UIError("Invalid Input. Please try again.", "Okay");
                errorMessage.ShowDialog();
            }

            DataTable dt = new DataTable();
            
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
