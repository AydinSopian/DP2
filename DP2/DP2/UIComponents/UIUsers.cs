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
        }

        private void viewUsers()
        {
            log.RunSelectQuery(dataGridUsers.Name, "UserAccounts", "*", "", "");
            dt = log.GetOutputDataSet.Tables[dataGridUsers.Name];
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

                }

            }
        }

        private void buttonUsersDelete_Click(object sender, EventArgs e)
        {
            UIConfirmation confirmation = new UIConfirmation("Are you sure?", "Yes", "Cancel");
            confirmation.ShowDialog();

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
         
            }
        }

        private void dataGridUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
