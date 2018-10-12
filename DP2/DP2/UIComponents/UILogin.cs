using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DP2.UIComponents
{
    public partial class UILogin : Form
    {
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
            /*SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\dingk\Documents\Data.mdf; Integrated Security = True; Connect Timeout = 30");
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) From Login where Username = '" + textLoginUsername.Text + "' and Password = '" + textLoginPassword.Text + "'", con);
            DataTable Table2 = new DataTable();
            sda.Fill(Table2);

            if(Table2.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                formSales ss = new formSales();
                ss.Show();
            }
            else
            {
                MessageBox.Show("Wrong Username or Password");
            }*/

            //TEMPORARY USER VERIFICATION
            String userAdmin = "admin";
            String passwordAdmin = "admin";
            String userEmployee = "employee";
            String passwordEmployee = "employee";

            if(textLoginUsername.Text == userAdmin && textLoginPassword.Text == passwordAdmin)
            {
                this.Hide();
                formHome ss = new formHome();
                ss.Show();
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
