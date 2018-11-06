﻿using System;
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

        public UIUsers()
        {
            InitializeComponent();
            BindColumns();
            log = RequestLog.Instance;
            viewUsers();
        }

        private void viewUsers()
        {
            log.RunQuery(1, "UserAccounts", "*", "", "");
            dt = log.GetOutputDataSet.Tables["outputDataTable"];
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


        private void buttonUsersCreate_Click(object sender, EventArgs e)
        {
            UIComponents.UINewUser newUser = new UIComponents.UINewUser();
            newUser.ShowDialog();
        }

        private void buttonUsersEdit_Click(object sender, EventArgs e)
        {
            //OPEN EDIT WINDOW
        }

        private void buttonUsersDelete_Click(object sender, EventArgs e)
        {
            UIConfirmation confirmation = new UIConfirmation("Are you sure?", "Yes", "Cancel");
            confirmation.ShowDialog();

            if (confirmation.isConfirmed)
            {
                //DELETE ROW
            }
        }
    }
}
