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
        public UIHome()
        {
            InitializeComponent();
            navIndicator.Height = buttonNavSales.Height;
            navIndicator.Top = buttonNavSales.Top;
        }

        private void home_Load(object sender, EventArgs e)
        {
            UISalesTransaction formSales = new UISalesTransaction();
            formSales.TopLevel = false;
            content.Controls.Clear();
            content.Controls.Add(formSales);
            formSales.Show();
        }

        private void buttonNavSales_Click(object sender, EventArgs e)
        {
            navIndicator.Height = buttonNavSales.Height;
            navIndicator.Top = buttonNavSales.Top;

            UISalesTransaction formSales = new UISalesTransaction();
            formSales.TopLevel = false;
            content.Controls.Clear();
            content.Controls.Add(formSales);
            formSales.Show();
        }



        private void buttonNavInventory_Click(object sender, EventArgs e)
        {
            navIndicator.Height = buttonNavInventory.Height;
            navIndicator.Top = buttonNavInventory.Top;

            UIInventory formInventory = new UIInventory();
            formInventory.TopLevel = false;
            content.Controls.Clear();
            content.Controls.Add(formInventory);
            formInventory.Show();
        }

        private void buttonNavDashboard_Click(object sender, EventArgs e)
        {
            navIndicator.Height = buttonNavDashboard.Height;
            navIndicator.Top = buttonNavDashboard.Top;

            UIComponents.UIDashboard uiDashboard = new UIComponents.UIDashboard();
            uiDashboard.TopLevel = false;
            content.Controls.Clear();
            content.Controls.Add(uiDashboard);
            uiDashboard.Show();
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

        private void buttonNavUsers_Click(object sender, EventArgs e)
        {
            navIndicator.Height = buttonNavUsers.Height;
            navIndicator.Top = buttonNavUsers.Top;

            UIComponents.UIUsers formUsers = new UIComponents.UIUsers();
            formUsers.TopLevel = false;
            content.Controls.Clear();
            content.Controls.Add(formUsers);
            formUsers.Show();
        }


        //Movable title bar

    }
}
