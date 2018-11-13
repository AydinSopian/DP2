﻿using System;
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
    public partial class UIInventory : Form
    {
        private RequestLog log;
        private DataTable dt;
        private DataTable ndt;
        private string values;

        public UIInventory()
        {
            InitializeComponent();
            BindColumns();

            log = RequestLog.Instance;

            ViewInventory();
            viewNotifications();
        }

        private void ViewInventory()
        {
            log.RunQuery(1, "Inventory", "*", "", "");
            dt = log.GetOutputDataSet.Tables["outputDataTable"];
            dataGridInventory.DataSource = dt;
        }

        private void viewNotifications()
        {
            string dateRange = "";
            log.RunQuery(1, "Inventory", "itemName, quantity, dateToOrder", dateRange, "");
            ndt = log.GetOutputDataSet.Tables["notificationDataTable"];
            dataGridNotifications.DataSource = ndt;
        }

        private void BindColumns()
        {
            dataGridInventory.ColumnCount = 6;

            dataGridInventory.AutoGenerateColumns = false;

            dataGridInventory.Columns[0].Name = "NO.";
            dataGridInventory.Columns[0].DataPropertyName = "itemId";
            dataGridInventory.Columns[1].Name = "ITEM";
            dataGridInventory.Columns[1].DataPropertyName = "itemName";
            dataGridInventory.Columns[2].Name = "COST PER UNIT";
            dataGridInventory.Columns[2].DataPropertyName = "costPerUnitBought";
            dataGridInventory.Columns[3].Name = "PRICE PER UNIT";
            dataGridInventory.Columns[3].DataPropertyName = "pricePerUnitSold";
            dataGridInventory.Columns[4].Name = "QTY";
            dataGridInventory.Columns[4].DataPropertyName = "quantity";
            dataGridInventory.Columns[5].Name = "CATEGORY";
            dataGridInventory.Columns[5].DataPropertyName = "category";

        }

        private void dataGridInventory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonInventoryAdd_Click(object sender, EventArgs e)
        {
            UIConfirmation confirmation = new UIConfirmation();
            confirmation.ShowDialog();

            if (confirmation.isConfirmed)
            {
                confirmation.Close();

                //INSERT into inventory
                values = "\"" + textInventoryCategory.Text + "\"" + ", \"" + textInventoryItem.Text + "\", " + textInventoryCost.Text + ", " + textInventoryPrice.Text + ", " + textInventoryQty.Text;
                log.RunQuery(3, "Inventory", "category, itemName, costPerUnitBought, pricePerUnitSold, quantity", "", values);
                ViewInventory();
                viewNotifications();
               

                //set cursor focus to category upon adding item AND clear text boxes
                textInventoryItem.Clear();
                textInventoryCost.Clear();
                textInventoryPrice.Clear();
                textInventoryQty.Clear();
                textInventoryItem.Focus();
            }
            else
            {
                confirmation.Close();
            }
            
        }

        private void UIInventory_Load(object sender, EventArgs e)
        {

        }

        private void labelInventoryCategory_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
