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
    public partial class UIEditInventory : Form
    {
        private RequestLog log;
        private string _itemID;
        private string _itemCategory;
        private string _itemName;
        private string _itemCost;
        private string _itemPrice;
        private string _itemQty;

        public UIEditInventory(string itemId, string itemCategory, string itemName, string itemCost, string itemPrice, string itemQty)
        {
            InitializeComponent();
            log = RequestLog.Instance;
            _itemID = itemId;
            _itemCategory = itemCategory;
            _itemName = itemName;
            _itemCost = itemCost;
            _itemPrice = itemPrice;
            _itemQty = itemQty;

        }

        private void buttonEditInventoryCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void buttonEditInventoryEdit_Click(object sender, EventArgs e)
        {
            UIConfirmation confirmation = new UIConfirmation("Are you sure?", "Yes", "Cancel");
            confirmation.ShowDialog();

            if (confirmation.isConfirmed)
            {
                //UPDATE DATABASE TO NEW VALUES
                string newCategory = textInventoryCategory.Text;
                string newItemName = textInventoryItem.Text;
                string newCost = textInventoryCost.Text;
                string newPrice = textInventoryPrice.ToString();
                string newQty = textInventoryQty.ToString();

                if (textInventoryCategory.Text == "")
                {
                    newCategory = _itemCategory;
                }

                if (textInventoryItem.Text == "")
                {
                    newItemName = _itemName;
                }

                if (textInventoryCost.Text == "")
                {
                    newCost = _itemCost;
                }

                if (textInventoryPrice.Text == "")
                {
                    newPrice = _itemPrice;
                }

                if (textInventoryQty.Text == "")
                {
                    newQty = _itemQty;
                }

                string queryString = "category=" + "\'" + newCategory + "\'" + "," + "itemName =" + "\'" + newItemName + "\'" + "," + "costPerUnitBought = " + "\'" + newCost + "\'" 
                    + "," + "pricePerUnitSold = " + "\'" + newPrice + "\'"
                    + "," + "quantity = " + "\'" + newQty + "\'";

                log.RunQuery(4, "Inventory", "", "itemID=" + "\'" + _itemID + "\'", queryString);
                this.Close();
            }
        }
    }
}
