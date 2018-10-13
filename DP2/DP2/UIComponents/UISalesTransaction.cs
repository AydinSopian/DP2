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
        private int colNum;

        public void ClearData()
        {
            dataGridSales.Rows.Clear();
        }

        public int rowNum
        {
            get { return colNum; }
            set { colNum = value; }
        }

        public formSales()
        {
            InitializeComponent();
            log = RequestLog.Instance;
            colNum = 0;

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
            //set cursor focus to category upon adding item
            textSalesCategory.Focus();

            //declaring field variables
            String colCategory, colItem;
            int colQty;
            Double colPricePerUnit, colSubtotal;

            //filling field variables
            colNum++;
            colCategory = textSalesCategory.Text;
            colItem = textSalesItem.Text;
            colQty = int.Parse(textSalesQty.Text);
            //RETRIEVE PRICE PER UNIT FROM DATABASE
            //subtotal = qty * pricePerUnit;

            //ADD ROW TO DataGridView
            salesTransactionBindingSource.Add(new Classes.salesTransaction() { number = colNum,
                category = colCategory,
                item = colItem,
                qty = colQty
                //, pricePerUnit = colPricePerUnit,
                //subtotal = colSubtotal
            });

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
