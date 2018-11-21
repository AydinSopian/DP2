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
    public partial class UIUsers : Form
    {
        private RequestLog log;
        private DataTable dt;
        private string selectedRow;
        private string _password;
        private string _permissions;

        public UIUsers()
        {
            InitializeComponent();
            BindColumns();
            log = RequestLog.Instance;
            viewUsers();
            
            dataGridUsers.ReadOnly = true;
            dataGridUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            
        }

        private void viewUsers()
        {
            dt = log.RunSelectQuery("UserAccounts", "*", "");
            dataGridUsers.DataSource = dt;
        }

        private void BindColumns()
        {
            dataGridUsers.ColumnCount = 3;

            dataGridUsers.AutoGenerateColumns = false;

            dataGridUsers.Columns[0].Name = "USERNAME";
            dataGridUsers.Columns[0].DataPropertyName = "username";
            dataGridUsers.Columns[1].Name = "PASSWORD";
            dataGridUsers.Columns[1].DataPropertyName = "password";
            dataGridUsers.Columns[2].Name = "PERMISSIONS";
            dataGridUsers.Columns[2].DataPropertyName = "permissions";
            
        }

        public DataTable GetDataTable()
        {
            return dt;
        }

        private void buttonUsersCreate_Click(object sender, EventArgs e)
        {
            UIComponents.UINewUser newUser = new UIComponents.UINewUser();
            newUser.ShowDialog();

            viewUsers();
            dataGridUsers.CurrentCell.Selected = false;
        }

        private void buttonUsersEdit_Click(object sender, EventArgs e)
        {
            //OPEN EDIT WINDOW
            foreach (DataGridViewCell oneCell in dataGridUsers.SelectedCells)
            {
                if (oneCell.Selected)
                {
                    int rowIndex = oneCell.RowIndex;
                    selectedRow = dataGridUsers.Rows[rowIndex].Cells[0].Value.ToString();
                    _password = dataGridUsers.Rows[rowIndex].Cells[1].Value.ToString();
                    _permissions = dataGridUsers.Rows[rowIndex].Cells[2].Value.ToString();

                    UIEditUser editUserForm = new UIEditUser(selectedRow, _password, _permissions);
                    editUserForm.ShowDialog();

                    viewUsers();
                    dataGridUsers.CurrentCell.Selected = false;
                }

            }
        }

        private void buttonUsersDelete_Click(object sender, EventArgs e)
        {
            UIConfirmation confirmation = new UIConfirmation("Are you sure?", "Yes", "Cancel");
            confirmation.ShowDialog();

            if (dataGridUsers.SelectedRows.Count < 1)
            {
                UIError error1 = new UIError("Please select a user","OK");
                error1.ShowDialog();
            }else if(dataGridUsers.SelectedRows.Count > 1)
            {
                UIError error2 = new UIError("Select only ONE user", "OK");
                error2.ShowDialog();
            }
            else
            {
                if (confirmation.isConfirmed)
                {
                    //DELETE ROW
                    foreach (DataGridViewCell oneCell in dataGridUsers.SelectedCells)
                    {
                        if (oneCell.Selected)
                        {
                            int rowIndex = oneCell.RowIndex;
                            selectedRow = dataGridUsers.Rows[rowIndex].Cells[0].Value.ToString();
                            log.RunQuery(2, "UserAccounts ", "", "username=" + "\'" + selectedRow + "\'", "");
                            viewUsers();

                        }

                    }
                    dataGridUsers.CurrentCell.Selected = false;
                }
            }

            
        }

        private void dataGridUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UIUsers_Load(object sender, EventArgs e)
        {
            dataGridUsers.CurrentCell.Selected = false;
        }
    }
}
