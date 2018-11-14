using System;
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
    public partial class UIHome: Form
    {
        UISalesTransaction formSales;
        UIInventory formInventory;
        UIComponents.UIDashboard formDashboard;
        UIComponents.UIUsers formUsers;
        Boolean _inventory;
        Boolean _dashboard;
        Boolean _users;

        public UIHome(Boolean inventory, Boolean dashboard, Boolean users)
        {
            InitializeComponent();
            navIndicator.Height = buttonNavSales.Height;
            navIndicator.Top = buttonNavSales.Top;
            _inventory = inventory;
            _dashboard = dashboard;
            _users = users;
        }

        private void home_Load(object sender, EventArgs e)
        {
            formSales = new UISalesTransaction();
            formInventory = new UIInventory();
            formDashboard = new UIComponents.UIDashboard();
            formUsers = new UIComponents.UIUsers();

            formSales.TopLevel = false;
            content.Controls.Clear();
            content.Controls.Add(formSales);
            formSales.Show();

            if(!_inventory)
            {
                buttonNavInventory.Visible = false;
            }

            if(!_dashboard)
            {
                buttonNavDashboard.Visible = false;
            }

            if(!_users)
            {
                buttonNavUsers.Visible = false;
            }
        }

        private void buttonNavSales_Click(object sender, EventArgs e)
        {
            navIndicator.Height = buttonNavSales.Height;
            navIndicator.Top = buttonNavSales.Top;

            
            formSales.TopLevel = false;
            content.Controls.Clear();
            content.Controls.Add(formSales);
            formSales.Show();
            formSales.SetComboBox();
        }

        private void buttonNavInventory_Click(object sender, EventArgs e)
        {
            navIndicator.Height = buttonNavInventory.Height;
            navIndicator.Top = buttonNavInventory.Top;

            
            formInventory.TopLevel = false;
            content.Controls.Clear();
            content.Controls.Add(formInventory);
            formInventory.Show();
            formInventory.ViewInventory();
        }

        private void buttonNavDashboard_Click(object sender, EventArgs e)
        {
            navIndicator.Height = buttonNavDashboard.Height;
            navIndicator.Top = buttonNavDashboard.Top;

            formDashboard.TopLevel = false;
            content.Controls.Clear();
            content.Controls.Add(formDashboard);
            formDashboard.Show();
        }

        private void buttonNavUsers_Click(object sender, EventArgs e)
        {
            navIndicator.Height = buttonNavUsers.Height;
            navIndicator.Top = buttonNavUsers.Top;

            formUsers.TopLevel = false;
            content.Controls.Clear();
            content.Controls.Add(formUsers);
            formUsers.Show();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
            this.Close();
        }


        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void content_Paint(object sender, PaintEventArgs e)
        {

        }

        


        //Movable title bar

    }
}
