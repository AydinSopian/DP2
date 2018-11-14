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
        //declaring field variables
        private int _rowNum, selectedRowIndex, selectedItemInventoryQty, _colQty;
        private decimal _salesTotal, _colSubtotal;
        private DataTable dt;
        private RequestLog log;
        private string _colItem;
        private decimal _colPricePerUnit;

        //getters and setters for Form Data

        public DataTable GetDataTable
        {
            get { return dt; }
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

            _rowNum = 0;

            dt.Columns.Add("NO.", typeof(int));
            dt.Columns.Add("itemName", typeof(string));
            dt.Columns.Add("QTY", typeof(int));
            dt.Columns.Add("pricePerUnitSold", typeof(decimal));
            dt.Columns.Add("SUBTOTAL", typeof(decimal));
            dt.Columns.Add("itemID", typeof(int));
            
            dataGridSales.DataSource = dt;
            BindColumns();
            dataGridSales.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridSales.ReadOnly = true;

            SetComboBoxes();

        }

        public void ClearData()
        {
            dt.Rows.Clear();
        }

        private void setSalesItemsEvent(object sender, EventArgs e)
        {
            textSalesItem.DataSource = log.RunSelectQuery("Inventory", "itemName, itemId", "quantity>0 AND category=\"" + textSalesCategory.SelectedValue.ToString() + "\"");
            textSalesItem.SelectedIndex = -1;
        }

        public void SetComboBoxes()
        {
            textSalesItem.DropDownStyle = ComboBoxStyle.DropDownList;
            textSalesItem.ValueMember = "itemID";
            textSalesItem.DisplayMember = "itemName";
            textSalesItem.SelectedIndex = -1;

            textSalesCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            textSalesCategory.ValueMember = "category";
            textSalesCategory.DataSource = log.RunSelectQuery("Inventory GROUP BY category", "category", "");
            textSalesCategory.SelectedIndex = -1;
            textSalesCategory.SelectionChangeCommitted += setSalesItemsEvent;

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
            if (e.RowIndex != -1)
            {
                if (dataGridSales.CurrentCell != null)
                {
                    selectedRowIndex = dataGridSales.CurrentCell.RowIndex;
                    selectedItemInventoryQty = Convert.ToInt32(log.RunSelectQuery("Inventory", "quantity", "itemName=\""+dt.Rows[selectedRowIndex][1]+"\"").Rows[0][0]);
                }
                    
            }
        }

        private void BindColumns()
        {
            dataGridSales.AutoGenerateColumns = false;

            dataGridSales.Columns[0].Name = "NO.";
            dataGridSales.Columns[0].DataPropertyName = "NO.";
            dataGridSales.Columns[1].Name = "ITEM";
            dataGridSales.Columns[1].DataPropertyName = "itemName";
            dataGridSales.Columns[2].Name = "QTY";
            dataGridSales.Columns[2].DataPropertyName = "QTY";
            dataGridSales.Columns[3].Name = "PRICE PER UNIT";
            dataGridSales.Columns[3].DataPropertyName = "pricePerUnitSold";
            dataGridSales.Columns[4].Name = "SUBTOTAL";
            dataGridSales.Columns[4].DataPropertyName = "SUBTOTAL";
        }

        private bool ValidateEntry(DataRow validationRow)
        {
            bool isValid = false;

            _colItem = validationRow[0].ToString();
            _colPricePerUnit = Convert.ToDecimal(validationRow[1]);
            int inventoryQty = Convert.ToInt32(validationRow[2]);
            Classes.DataValidation dataValidation = new Classes.DataValidation();

            bool qtyIsValidType = dataValidation.ValidateInteger(textSalesQty.Text);

            if (qtyIsValidType)
            {
                _colQty = int.Parse(textSalesQty.Text);
                _colSubtotal = Convert.ToDecimal(_colQty) * _colPricePerUnit;
                bool qtyIsValidNum = _colQty <= inventoryQty;

                if (qtyIsValidNum)
                {
                    isValid = true;
                }
                else
                {
                    UIComponents.UIError errorMessage = new UIComponents.UIError("Qty exceeds inventory quantity.", "Okay");
                    errorMessage.ShowDialog();
                }
            }
            else
            {
                UIComponents.UIError errorMessage = new UIComponents.UIError("Invalid Input. Please try again.", "Okay");
                errorMessage.ShowDialog();

            }

            return isValid;
        }

        private void buttonSalesAdd_Click(object sender, EventArgs e)
        {
            //VALIDATE DATA
            DataRow validationRow = log.RunSelectQuery("Inventory", "itemName, pricePerUnitSold, quantity", "itemID=" + textSalesItem.SelectedValue.ToString()).Rows[0];
            bool isValid = ValidateEntry(validationRow);

            //IF ALL DATA IS VALID, ADD NEW ROW TO DATAGRIDVIEW
            if (isValid)
            {
                _rowNum++;
                dt.Rows.Add(_rowNum, _colItem, _colQty, decimal.Round(_colPricePerUnit, 2), decimal.Round(_colSubtotal, 2), textSalesItem.SelectedValue);

                setPriceTotal();

                //set cursor focus to category upon adding item AND clear text boxes
                textSalesQty.Clear();
                textSalesItem.Focus();
            }

            dataGridSales.ClearSelection();
        }

        private void setPriceTotal()
        {
            _salesTotal = 0;
            foreach(DataRow r in dt.Rows)
            {
                _salesTotal += Convert.ToDecimal(r[4]);
            }

            labelSalesTotal.Text = "RM " + decimal.Round(_salesTotal, 2, MidpointRounding.AwayFromZero).ToString();
        }

        private void buttonSalesDecrement_Click(object sender, EventArgs e)
        {
            int tempQty = Convert.ToInt32(dt.Rows[selectedRowIndex][2]); ;
            decimal tempSubTotal = Convert.ToDecimal(dt.Rows[selectedRowIndex][4]);

            bool rowSelected = dataGridSales.SelectedRows.Count == 1 && dt.Rows.Count != 0;
            bool canDecrement = tempQty != 1;

            if (rowSelected && canDecrement)
            {
                tempSubTotal -= Convert.ToDecimal(dt.Rows[selectedRowIndex][3]);
                tempQty--;

                dt.Rows[selectedRowIndex][2] = tempQty;
                dt.Rows[selectedRowIndex][4] = tempSubTotal;

                setPriceTotal();

            }
            else
            {
                if(!rowSelected)
                {
                    UIComponents.UIError errorMessage = new UIComponents.UIError("Please select a row to decrement.", "Okay");
                    errorMessage.ShowDialog();
                }
            }
        }

        private void buttonSalesIncrement_Click(object sender, EventArgs e)
        {
            int tempQty = Convert.ToInt32(dt.Rows[selectedRowIndex][2]); ;
            decimal tempSubTotal = Convert.ToDecimal(dt.Rows[selectedRowIndex][4]);

            bool rowSelected = dataGridSales.SelectedRows.Count == 1 && dt.Rows.Count != 0;
            bool canIncrement = tempQty != selectedItemInventoryQty;

            if (rowSelected && canIncrement)
            {
                tempSubTotal += Convert.ToDecimal(dt.Rows[selectedRowIndex][3]);
                tempQty++;

                dt.Rows[selectedRowIndex][2] = tempQty;
                dt.Rows[selectedRowIndex][4] = tempSubTotal;

                setPriceTotal();

            }
            else
            {
                if (!rowSelected)
                {
                    UIComponents.UIError errorMessage = new UIComponents.UIError("Please select a row to increment.", "Okay");
                    errorMessage.ShowDialog();
                }
                if (!canIncrement)
                {
                    UIComponents.UIError errorMessage = new UIComponents.UIError("Qty exceeds inventory quantity.", "Okay");
                    errorMessage.ShowDialog();
                }
            }
        }

        private void buttonSalesDelete_Click(object sender, EventArgs e)
        {
            if(dataGridSales.SelectedRows.Count == 1 && dt.Rows.Count != 0)
            {
                _rowNum = 0;
                _salesTotal -= Convert.ToDecimal(dt.Rows[selectedRowIndex][4]);
                dt.Rows[selectedRowIndex].Delete();
                setPriceTotal();

                foreach (DataRow r in dt.Rows)
                {
                    _rowNum++;
                    r[0] = _rowNum;
                }
            }
            else
            {
                UIComponents.UIError errorMessage = new UIComponents.UIError("Please select a row to delete.", "Okay");
                errorMessage.ShowDialog();
            }
        }

        private void buttonSalesCheckout_Click(object sender, EventArgs e)
        {
            if(dt.Rows.Count != 0)
            {
                //Open payment window
                UIComponents.UIPayment paymentWindow = new UIComponents.UIPayment(this);
                paymentWindow.ShowDialog();
                _salesTotal = 0;
                setPriceTotal();
            }
            else
            {
                UIComponents.UIError errorMessage = new UIComponents.UIError("Please enter items", "Okay");
                errorMessage.ShowDialog();
            }
            
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
