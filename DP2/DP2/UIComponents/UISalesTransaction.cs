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
        private DataTable dt;


        //declaring field variables
        private int _colNum, _colQty;
        private string _colItem;
        private decimal _colPricePerUnit, _colSubtotal, _salesTotal;

        private int _rowNum;

        //getters and setters for Form Data
        
        public DataTable GetDataTable()
        {
            return dt;
        }

        public int GetQuantity()
        {
            return _colQty;
        }

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
            dt = new DataTable();

            dt.Columns.Add();
            dt.Columns.Add();
            dt.Columns.Add();

            _colNum = 0;
            _rowNum = 0;

            textSalesItem.ValueMember = "itemName";
            SetComboBox();
        }

        private void SetComboBox()
        {
            textSalesItem.DropDownStyle = ComboBoxStyle.DropDownList;
            textSalesItem.ValueMember = "itemId";
            textSalesItem.DisplayMember = "itemName";
            log.RunQuery(1, "Inventory", "itemName, itemId", "quantity>0", "");
            textSalesItem.DataSource = log.GetOutputDataSet.Tables["outputDataTable"];
            textSalesItem.SelectedIndex = -1;
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

                _salesTotal -= 0;

                foreach (DataRow dtr in dt.Rows)
                {
                    foreach(DataGridViewRow dgvr in dataGridSales.Rows)
                    {
                        if(dtr[1] == dgvr.Cells[1].Value)
                        {
                            dt.Rows.Remove(dtr);
                        }
                    }
                }
            }
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
                //store values into temporary variables
                selectedId = textSalesItem.SelectedValue.ToString();
                log.RunQuery(1, "Inventory", "itemName", "itemId=" + selectedId, "");
                _colItem = log.GetOutputValue.ToString();

                log.RunQuery(1, "Inventory", "pricePerUnitSold", "itemId=" + selectedId, "");
                _colPricePerUnit = Convert.ToDecimal(log.GetOutputValue);
                _colQty = int.Parse(textSalesQty.Text);
                _colSubtotal = Convert.ToDecimal(_colQty) * _colPricePerUnit;

                //check to ensure items purchased do not exceed stock amount
                log.RunQuery(1, "Inventory", "quantity", "itemId=" + selectedId, "");
                int inventoryQty = Convert.ToInt32(log.GetOutputValue);

                if(_colQty > inventoryQty)
                {
                    UIComponents.UIError errorMessage = new UIComponents.UIError("Qty exceeds inventory quantity", "Okay");
                    errorMessage.ShowDialog();
                }
                else
                {
                    _rowNum++;
                    _colNum++;

                    //create new salesTransaction using temporaray variables
                    salesTransactionBindingSource.Add(new Classes.salesTransaction()
                    {
                        number = _colNum,
                        item = _colItem,
                        qty = _colQty,
                        pricePerUnit = decimal.Round(_colPricePerUnit, 2),
                        subtotal = decimal.Round(_colSubtotal, 2)
                    });


                    _salesTotal += _colSubtotal;

                    labelSalesTotal.Text = "RM " + decimal.Round(_salesTotal, 2, MidpointRounding.AwayFromZero).ToString();

                    //set cursor focus to category upon adding item AND clear text boxes
                    textSalesQty.Clear();
                    textSalesItem.Focus();
                }
            }
            else
            {
                UIComponents.UIError errorMessage = new UIComponents.UIError("Invalid Input. Please try again.", "Okay");
                errorMessage.ShowDialog();
            }

            log.RunQuery(1, "Inventory", "itemid", "itemname=\"" + _colItem + "\"", "");

            DataRow dr = dt.NewRow();

            dr[0] = log.GetOutputValue;
            dr[1] = _colItem;
            dr[2] = _colQty;

            dt.Rows.Add(dr);

            SetComboBox();
           
        }

        private void buttonSalesCheckout_Click(object sender, EventArgs e)
        {
            //Open payment window
            UIComponents.UIPayment paymentWindow = new UIComponents.UIPayment(this);
            paymentWindow.ShowDialog();
            SetComboBox();
            _rowNum = 0;
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
