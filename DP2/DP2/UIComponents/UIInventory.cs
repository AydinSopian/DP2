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
    public partial class formInventory : Form
    {
        private RequestLog log;

        public formInventory()
        {
            InitializeComponent();
            log = RequestLog.Instance;
            log.GetRequestedQuery(1, "*", "Inventory"); //display all inventory items in datagridview
        }

        private void dataGridInventory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonInventoryAdd_Click(object sender, EventArgs e)
        {
            confirmation1 confirmation = new confirmation1();
            confirmation.ShowDialog();

            if (confirmation.isConfirmed)
            {
                this.Close();
                string values = textInventoryItem.Text + ", " + textInventoryCost.Text + ", " + textInventoryPrice.Text + ", " + textInventoryQty.Text;

                log.GetRequestedQuery(3, "Inventory", "itemName, costPerUnitBought, pricePerUnitSold, quantity", values);
            }
            else
            {
                this.Close();
            }
            
        }

    }
}
