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
    public partial class UIEditUser : Form
    {
        private RequestLog log;
        private DataTable dt;
        private string _selectedRow;
        private string _username;
        private string _password;
        private string _permissions;

        public UIEditUser(string username, string password, string permissions)
        {
            InitializeComponent();
            _selectedRow = username;
            _username = username;
            _password = password;
            _permissions = permissions;

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonEditUserCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void buttonEditUserEdit_Click(object sender, EventArgs e)
        {
            UIConfirmation confirmation = new UIConfirmation("Are you sure?", "Yes", "Cancel");
            confirmation.ShowDialog();

            if (confirmation.isConfirmed)
            {
                //UPDATE DATABASE TO NEW VALUES
                string newUsername = textEditUserUsername.Text;
                string newPassword = textEditUserPassword.Text;
                string newPermissions = textEditUserPermissions.Text;

                if(textEditUserUsername.Text == "")
                {
                    newUsername = _username;
                }

                if (textEditUserPassword.Text == "")
                {
                    newPassword = _password;
                }

                if (textEditUserPermissions.Text == "")
                {
                    newPermissions = _permissions;
                }

                log.RunQuery(4, "UserAccounts", "", "username=" + _selectedRow, "username = " + newUsername + "," + "password =" + newPassword + "," + "permissions = " + newPermissions);
                
            }
        }
    }
}
