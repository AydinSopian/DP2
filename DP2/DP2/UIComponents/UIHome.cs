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
    public partial class formHome : Form
    {
        public formHome()
        {
            InitializeComponent();
            navIndicator.Height = buttonNavSales.Height;
            navIndicator.Top = buttonNavSales.Top;
        }

        private void home_Load(object sender, EventArgs e)
        {
            formSales formSales = new formSales();
            formSales.TopLevel = false;
            content.Controls.Clear();
            content.Controls.Add(formSales);
            formSales.Show();
        }

        private void buttonNavSales_Click(object sender, EventArgs e)
        {
            navIndicator.Height = buttonNavSales.Height;
            navIndicator.Top = buttonNavSales.Top;

            formSales formSales = new formSales();
            formSales.TopLevel = false;
            content.Controls.Clear();
            content.Controls.Add(formSales);
            formSales.Show();
        }



        private void buttonNavInventory_Click(object sender, EventArgs e)
        {
            navIndicator.Height = buttonNavInventory.Height;
            navIndicator.Top = buttonNavInventory.Top;

            formInventory formInventory = new formInventory();
            formInventory.TopLevel = false;
            content.Controls.Clear();
            content.Controls.Add(formInventory);
            formInventory.Show();
        }

        private void buttonNavDashboard_Click(object sender, EventArgs e)
        {
            navIndicator.Height = buttonNavDashboard.Height;
            navIndicator.Top = buttonNavDashboard.Top;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        //Movable title bar
        
    }
}
