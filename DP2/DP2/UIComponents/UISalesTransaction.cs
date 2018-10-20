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
        private string _colItem;
        private decimal _colPricePerUnit, _colSubtotal, _salesTotal;

        private int _rowNum;


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

        public decimal SalesTotal
        {
            get { return _salesTotal; }
        }


        public UISalesTransaction()
        {
            InitializeComponent();
            log = RequestLog.Instance;
           
            _colNum = 0;
            _rowNum = 0;

            textSalesItem.ValueMember = "itemName";
            SetComboBox();

            textSalesItem.SelectedIndex = -1;
            
        }

        private void SetComboBox()
        {
            textSalesItem.DropDownStyle = ComboBoxStyle.DropDownList;
            textSalesItem.ValueMember = "itemId";
            textSalesItem.DisplayMember = "itemName";
            log.RunQuery(1, "Inventory", "itemName, itemId", "quantity>0", "");
            textSalesItem.DataSource = log.GetOutputDataSet.Tables["outputDataTable"];
        }

            private void buttonSalesCheckout_Click(object sender, EventArgs e)
        {
            //Open payment window
            UIComponents.UIPayment paymentWindow = new UIComponents.UIPayment(this);
            paymentWindow.ShowDialog();

            _rowNum = 0;
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

              
            string selectedId = "";


            //IF ALL DATA IS VALID, ADD NEW ROW TO DATAGRIDVIEW
            if (itemIsValid && qtyIsValid)
            {
                selectedId = textSalesItem.SelectedValue.ToString();
                log.RunQuery(1, "Inventory", "itemName", "itemId=" + selectedId, "");
                _colItem = log.GetOutputValue.ToString();

                log.RunQuery(1, "Inventory", "pricePerUnitSold", "itemId=" + selectedId, "");
                _colPricePerUnit = Convert.ToDecimal(log.GetOutputValue);
                _colQty = int.Parse(textSalesQty.Text);
                _colSubtotal = Convert.ToDecimal(_colQty) * _colPricePerUnit;

                _rowNum++;
                _colNum++;
                salesTransactionBindingSource.Add(new Classes.salesTransaction()
                {
                    number = _colNum,
                    item = _colItem,
                    qty = _colQty,
                    pricePerUnit = decimal.Round(_colPricePerUnit,2),
                    subtotal = decimal.Round(_colSubtotal, 2)
                });

                
                _salesTotal += _colSubtotal;
                

                labelSalesTotal.Text = "RM " + decimal.Round(_salesTotal, 2, MidpointRounding.AwayFromZero).ToString();

                //set cursor focus to category upon adding item AND clear text boxes
                textSalesQty.Clear();
                textSalesItem.Focus();

            }
            else
            {
                UIComponents.UIError errorMessage = new UIComponents.UIError("Invalid Input. Please try again.", "Okay");
                errorMessage.ShowDialog();
            }

            SetComboBox();
           
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
