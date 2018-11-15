namespace DP2.UIComponents
{
    partial class UIEditUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonMinimize = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.textEditUserPermissions = new System.Windows.Forms.ComboBox();
            this.labelEditUserTitle = new System.Windows.Forms.Label();
            this.labelNewUserPermissions = new System.Windows.Forms.Label();
            this.buttonEditUserCancel = new System.Windows.Forms.Button();
            this.buttonEditUserEdit = new System.Windows.Forms.Button();
            this.labelNewUserPassword = new System.Windows.Forms.Label();
            this.labelNewUserUsername = new System.Windows.Forms.Label();
            this.textEditUserUsername = new System.Windows.Forms.TextBox();
            this.textEditUserPassword = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panel1.Controls.Add(this.buttonMinimize);
            this.panel1.Controls.Add(this.buttonClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(336, 30);
            this.panel1.TabIndex = 11;
            // 
            // buttonMinimize
            // 
            this.buttonMinimize.FlatAppearance.BorderSize = 0;
            this.buttonMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinimize.Image = global::DP2.Properties.Resources.icons8_horizontal_line_15;
            this.buttonMinimize.Location = new System.Drawing.Point(248, 0);
            this.buttonMinimize.Name = "buttonMinimize";
            this.buttonMinimize.Size = new System.Drawing.Size(42, 29);
            this.buttonMinimize.TabIndex = 4;
            this.buttonMinimize.TabStop = false;
            this.buttonMinimize.UseVisualStyleBackColor = true;
            this.buttonMinimize.Click += new System.EventHandler(this.buttonMinimize_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.buttonClose.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Image = global::DP2.Properties.Resources.icons8_multiply_28;
            this.buttonClose.Location = new System.Drawing.Point(292, 0);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(42, 29);
            this.buttonClose.TabIndex = 3;
            this.buttonClose.TabStop = false;
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // textEditUserPermissions
            // 
            this.textEditUserPermissions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(75)))), ((int)(((byte)(85)))));
            this.textEditUserPermissions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.textEditUserPermissions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEditUserPermissions.ForeColor = System.Drawing.Color.White;
            this.textEditUserPermissions.FormattingEnabled = true;
            this.textEditUserPermissions.Location = new System.Drawing.Point(66, 278);
            this.textEditUserPermissions.Name = "textEditUserPermissions";
            this.textEditUserPermissions.Size = new System.Drawing.Size(207, 28);
            this.textEditUserPermissions.TabIndex = 29;
            // 
            // labelEditUserTitle
            // 
            this.labelEditUserTitle.AutoSize = true;
            this.labelEditUserTitle.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEditUserTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.labelEditUserTitle.Location = new System.Drawing.Point(72, 58);
            this.labelEditUserTitle.Name = "labelEditUserTitle";
            this.labelEditUserTitle.Size = new System.Drawing.Size(195, 24);
            this.labelEditUserTitle.TabIndex = 28;
            this.labelEditUserTitle.Text = "EDIT EXISTING USER";
            // 
            // labelNewUserPermissions
            // 
            this.labelNewUserPermissions.AutoSize = true;
            this.labelNewUserPermissions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNewUserPermissions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.labelNewUserPermissions.Location = new System.Drawing.Point(62, 255);
            this.labelNewUserPermissions.Name = "labelNewUserPermissions";
            this.labelNewUserPermissions.Size = new System.Drawing.Size(102, 20);
            this.labelNewUserPermissions.TabIndex = 27;
            this.labelNewUserPermissions.Text = "Permissions :";
            // 
            // buttonEditUserCancel
            // 
            this.buttonEditUserCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.buttonEditUserCancel.FlatAppearance.BorderSize = 0;
            this.buttonEditUserCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditUserCancel.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditUserCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.buttonEditUserCancel.Location = new System.Drawing.Point(186, 345);
            this.buttonEditUserCancel.Name = "buttonEditUserCancel";
            this.buttonEditUserCancel.Size = new System.Drawing.Size(87, 52);
            this.buttonEditUserCancel.TabIndex = 26;
            this.buttonEditUserCancel.TabStop = false;
            this.buttonEditUserCancel.Text = "Cancel";
            this.buttonEditUserCancel.UseVisualStyleBackColor = false;
            this.buttonEditUserCancel.Click += new System.EventHandler(this.buttonEditUserCancel_Click);
            // 
            // buttonEditUserEdit
            // 
            this.buttonEditUserEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.buttonEditUserEdit.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.buttonEditUserEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditUserEdit.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditUserEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.buttonEditUserEdit.Location = new System.Drawing.Point(66, 345);
            this.buttonEditUserEdit.Name = "buttonEditUserEdit";
            this.buttonEditUserEdit.Size = new System.Drawing.Size(87, 52);
            this.buttonEditUserEdit.TabIndex = 25;
            this.buttonEditUserEdit.Text = "Edit";
            this.buttonEditUserEdit.UseVisualStyleBackColor = false;
            this.buttonEditUserEdit.Click += new System.EventHandler(this.buttonEditUserEdit_Click);
            // 
            // labelNewUserPassword
            // 
            this.labelNewUserPassword.AutoSize = true;
            this.labelNewUserPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNewUserPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.labelNewUserPassword.Location = new System.Drawing.Point(62, 185);
            this.labelNewUserPassword.Name = "labelNewUserPassword";
            this.labelNewUserPassword.Size = new System.Drawing.Size(86, 20);
            this.labelNewUserPassword.TabIndex = 24;
            this.labelNewUserPassword.Text = "Password :";
            // 
            // labelNewUserUsername
            // 
            this.labelNewUserUsername.AutoSize = true;
            this.labelNewUserUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNewUserUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.labelNewUserUsername.Location = new System.Drawing.Point(62, 117);
            this.labelNewUserUsername.Name = "labelNewUserUsername";
            this.labelNewUserUsername.Size = new System.Drawing.Size(91, 20);
            this.labelNewUserUsername.TabIndex = 23;
            this.labelNewUserUsername.Text = "Username :";
            // 
            // textEditUserUsername
            // 
            this.textEditUserUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(75)))), ((int)(((byte)(85)))));
            this.textEditUserUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textEditUserUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEditUserUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.textEditUserUsername.Location = new System.Drawing.Point(66, 140);
            this.textEditUserUsername.Name = "textEditUserUsername";
            this.textEditUserUsername.Size = new System.Drawing.Size(207, 19);
            this.textEditUserUsername.TabIndex = 21;
            // 
            // textEditUserPassword
            // 
            this.textEditUserPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(75)))), ((int)(((byte)(85)))));
            this.textEditUserPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textEditUserPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEditUserPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.textEditUserPassword.Location = new System.Drawing.Point(66, 208);
            this.textEditUserPassword.Name = "textEditUserPassword";
            this.textEditUserPassword.Size = new System.Drawing.Size(207, 19);
            this.textEditUserPassword.TabIndex = 22;
            // 
            // UIEditUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(336, 419);
            this.Controls.Add(this.textEditUserPermissions);
            this.Controls.Add(this.labelEditUserTitle);
            this.Controls.Add(this.labelNewUserPermissions);
            this.Controls.Add(this.buttonEditUserCancel);
            this.Controls.Add(this.buttonEditUserEdit);
            this.Controls.Add(this.labelNewUserPassword);
            this.Controls.Add(this.labelNewUserUsername);
            this.Controls.Add(this.textEditUserUsername);
            this.Controls.Add(this.textEditUserPassword);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UIEditUser";
            this.Text = "UIEditUser";
            this.Load += new System.EventHandler(this.UIEditUser_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonMinimize;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.ComboBox textEditUserPermissions;
        private System.Windows.Forms.Label labelEditUserTitle;
        private System.Windows.Forms.Label labelNewUserPermissions;
        private System.Windows.Forms.Button buttonEditUserCancel;
        private System.Windows.Forms.Button buttonEditUserEdit;
        private System.Windows.Forms.Label labelNewUserPassword;
        private System.Windows.Forms.Label labelNewUserUsername;
        private System.Windows.Forms.TextBox textEditUserUsername;
        private System.Windows.Forms.TextBox textEditUserPassword;
    }
}