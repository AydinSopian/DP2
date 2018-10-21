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
        private string connectionString;
        private MySqlConnection con;
        public UILogin()
        {
            InitializeComponent();
        }

        private void UILogin_Load(object sender, EventArgs e)
        {

        }

        private void buttonConfirmationContinue_Click(object sender, EventArgs e)
        {
            //TO-DO: ADD DATABASE CONNECTION HERE
            connectionString = "datasource=127.0.0.1;port=3307;username=root;password=;database=dp2;SslMode=none";
            con = new MySqlConnection(connectionString);
            MySqlDataAdapter sda = new MySqlDataAdapter("Select Count(*) From UserAccounts where Username = '" + textLoginUsername.Text + "' and Password = '" + textLoginPassword.Text + "'",con);
           
            DataTable UserAccounts = new DataTable();
            sda.Fill(UserAccounts);

            if(UserAccounts.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                UIHome home = new UIHome();
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
