using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DP2
{
    public partial class UIInventory : Form
    {
        private RequestLog log;
        private DataTable dt;
        private DataTable ndt;
        private string values;
        private string selectedRow;
        private string _itemID;
        private string _itemCategory;
        private string _itemName;
        private string _itemCost;
        private string _itemPrice;
        private string _itemQty;
        

        public UIInventory()
        {
            InitializeComponent();

            log = RequestLog.Instance;

            ViewInventory();
            viewNotifications();
            SetComboBox();

            dataGridNotifications.ReadOnly = true;
            dataGridInventory.ReadOnly = true;

            dataGridInventory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridNotifications.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void SetComboBox()
        {
            textInventoryCategory.ValueMember = "category";
            textInventoryCategory.DataSource = log.RunSelectQuery("Inventory GROUP BY category", "category", "");
            textInventoryCategory.SelectedIndex = -1;
        }

        public void ViewInventory()
        {
            BindInventoryColumns();
            dt = log.RunSelectQuery("Inventory", "itemID, category, itemName, costPerUnitBought, pricePerUnitSold, quantity", "");
            dataGridInventory.DataSource = dt;
        }

        private void viewNotifications()
        {
            BindNotificationsColumns();
            string dateRange = "dateToOrder BETWEEN NOW() AND NOW() + INTERVAL 30 DAY ";
            ndt = log.RunSelectQuery("Inventory", "itemName, quantity, dateToOrder", dateRange);
            dataGridNotifications.DataSource = ndt;
        }

        private void BindNotificationsColumns()
        {
            dataGridNotifications.ColumnCount = 3;

            dataGridNotifications.AutoGenerateColumns = false;

            dataGridNotifications.Columns[0].Name = "ITEM";
            dataGridNotifications.Columns[0].DataPropertyName = "itemName";
            dataGridNotifications.Columns[1].Name = "QTY";
            dataGridNotifications.Columns[1].DataPropertyName = "quantity";
            dataGridNotifications.Columns[2].Name = "DATE TO ORDER";
            dataGridNotifications.Columns[2].DataPropertyName = "dateToOrder";
        }

        private void BindInventoryColumns()
        {
            dataGridInventory.AutoGenerateColumns = false;

            dataGridInventory.Columns[0].Name = "NO.";
            dataGridInventory.Columns[0].DataPropertyName = "itemId";
            dataGridInventory.Columns[1].Name = "CATEGORY";
            dataGridInventory.Columns[1].DataPropertyName = "category";
            dataGridInventory.Columns[2].Name = "ITEM";
            dataGridInventory.Columns[2].DataPropertyName = "itemName";
            dataGridInventory.Columns[3].Name = "COST PER UNIT";
            dataGridInventory.Columns[3].DataPropertyName = "costPerUnitBought";
            dataGridInventory.Columns[4].Name = "PRICE PER UNIT";
            dataGridInventory.Columns[4].DataPropertyName = "pricePerUnitSold";
            dataGridInventory.Columns[5].Name = "QTY";
            dataGridInventory.Columns[5].DataPropertyName = "quantity";
            

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

                MySqlConnection sqlConn = new MySqlConnection("datasource=35.198.212.34;port=3306;username=root;password=;database=dp2;sslmode=none");
                MySqlCommand callEvent = new MySqlCommand("call update_allRateOfSales();", sqlConn);
                sqlConn.Open();

                callEvent.ExecuteScalar();

                callEvent = new MySqlCommand("call update_allDaysUntilDepletion();", sqlConn);

                callEvent.ExecuteScalar();

                callEvent = new MySqlCommand("call update_allDateToOrder();", sqlConn);

                callEvent.ExecuteScalar();

                sqlConn.Close();

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

        private void buttonInventoryEdit_Click(object sender, EventArgs e)
        {
            //OPEN EDIT WINDOW
            foreach (DataGridViewCell oneCell in dataGridInventory.SelectedCells)
            {
                if (oneCell.Selected)
                {
                    int rowIndex = oneCell.RowIndex;
                    _itemID = dataGridInventory.Rows[rowIndex].Cells[0].Value.ToString();
                    _itemCategory = dataGridInventory.Rows[rowIndex].Cells[1].Value.ToString();
                    _itemName = dataGridInventory.Rows[rowIndex].Cells[2].Value.ToString();
                    _itemCost = dataGridInventory.Rows[rowIndex].Cells[3].Value.ToString(); 
                    _itemPrice = dataGridInventory.Rows[rowIndex].Cells[4].Value.ToString();
                    _itemQty = dataGridInventory.Rows[rowIndex].Cells[5].Value.ToString();

                    UIComponents.UIEditInventory editInventoryForm = new UIComponents.UIEditInventory(_itemID, _itemCategory, _itemName, _itemCost, _itemPrice, _itemQty);
                    editInventoryForm.ShowDialog();

                    ViewInventory();

                    MySqlConnection sqlConn = new MySqlConnection("datasource=35.198.212.34;port=3306;username=root;password=;database=dp2;sslmode=none");
                    MySqlCommand callEvent = new MySqlCommand("call update_allRateOfSales();", sqlConn);
                    sqlConn.Open();

                    callEvent.ExecuteScalar();

                    callEvent = new MySqlCommand("call update_allDaysUntilDepletion();", sqlConn);

                    callEvent.ExecuteScalar();

                    callEvent = new MySqlCommand("call update_allDateToOrder();", sqlConn);

                    callEvent.ExecuteScalar();

                    sqlConn.Close();

                }

            }
        }

        private void buttonInventoryDelete_Click(object sender, EventArgs e)
        {
            UIConfirmation confirmation = new UIConfirmation("Are you sure?", "Yes", "Cancel");
            confirmation.ShowDialog();

            if (confirmation.isConfirmed)
            {
                //DELETE ROW
                foreach (DataGridViewCell oneCell in dataGridInventory.SelectedCells)
                {
                    if (oneCell.Selected)
                    {
                        int rowIndex = oneCell.RowIndex;
                        selectedRow = dataGridInventory.Rows[rowIndex].Cells[0].Value.ToString();
                        log.RunQuery(2, "Inventory ", "", "itemID=" + "\'" + selectedRow + "\'", "");
                        ViewInventory();
                    }

                }

            }
        }

        private void dataGridInventory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
