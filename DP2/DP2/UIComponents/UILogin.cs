using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using MySql.Data.MySqlClient;
using System.Windows.Forms;


namespace DP2.UIComponents
{
    public partial class UILogin : Form
    {
        private RequestLog log;


        public UILogin()
        {
            InitializeComponent();
            log = RequestLog.Instance;
            textLoginPassword.PasswordChar = '*';
        }

        private void UILogin_Load(object sender, EventArgs e)
        {

        }

        private void buttonConfirmationContinue_Click(object sender, EventArgs e)
        {
            DataTable UserAccounts = new DataTable();
            UserAccounts = log.RunSelectQuery("UserAccounts", "*", "Username = \"" + textLoginUsername.Text + "\" AND Password = \"" + textLoginPassword.Text + "\"");

            if(UserAccounts.Rows.Count == 1)
            {
                string accountPermissions = UserAccounts.Rows[0][2].ToString();
                if (accountPermissions == "admin")
                {
                    this.Hide();
                    UIHome home = new UIHome(true, true, true);
                    home.Show();
                }
                else if (accountPermissions == "employee")
                {
                    this.Hide();
                    UIHome home = new UIHome(false, false, false);
                    home.Show();
                }
            }
            else
            {
                MessageBox.Show("Wrong Username or Password");
            }

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonConfirmationCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
