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
        }

        private void UILogin_Load(object sender, EventArgs e)
        {

        }

        private void buttonConfirmationContinue_Click(object sender, EventArgs e)
        {
            //DATABASE CONNECTION
            log.RunQuery(1, "UserAccounts", "*", "Username = \"" + textLoginUsername.Text + "\" AND Password = \"" + textLoginPassword.Text + "\"", "");
           
            DataTable UserAccounts = new DataTable();
            UserAccounts = log.GetOutputDataSet.Tables["outputDataTable"];

            log.RunQuery(1, "UserAccounts", "permissions", "Username = \"" + textLoginUsername.Text + "\" AND Password = \"" + textLoginPassword.Text + "\"", "");
            string accountPermissions = log.GetOutputValue.ToString();

            if(UserAccounts.Rows.Count == 1 && accountPermissions == "admin")
            {
                this.Hide();
                UIHome home = new UIHome(true, true, true);
                home.Show();
            }
            else if (UserAccounts.Rows.Count == 1 && accountPermissions == "employee")
            {
                this.Hide();
                UIHome home = new UIHome(false, false, false);
                home.Show();
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
