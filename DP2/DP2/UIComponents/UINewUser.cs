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
    public partial class UINewUser : Form
    {
        private RequestLog log;

        public UINewUser()
        {
            InitializeComponent();

            log = RequestLog.Instance;
            textNewUserPassword.PasswordChar = '*';

            textNewUserPermissions.Items.Add("admin");
            textNewUserPermissions.Items.Add("employee");
            this.textNewUserPermissions.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void buttonNewUserCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonNewUserCreate_Click(object sender, EventArgs e)
        {
            UIConfirmation confirmation = new UIConfirmation("Create new User?", "Create", "Cancel");
            confirmation.ShowDialog();

            if (confirmation.isConfirmed)
            {
                //check if fields are empty
                if(textNewUserUsername.Text == "" || textNewUserPassword.Text == "" || textNewUserPermissions.Text == "")
                {
                    UIError error = new UIError("Please fill all fields","OK");
                    error.ShowDialog();
                }else
                {
                    //INSERT new user into UserAccounts Table in DATABASE
                    string username = textNewUserUsername.Text;
                    string password = textNewUserPassword.Text;
                    string permissions = textNewUserPermissions.Text;
                    log.RunQuery(3, "UserAccounts", "username, password, permissions", "", "\'" + username + "\'" + "," + "\'" + password + "\'" + "," + "\'" + permissions + "\'");
                    this.Close();
                }
                
            }
        }
    }
}
