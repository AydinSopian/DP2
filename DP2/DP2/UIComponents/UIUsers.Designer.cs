namespace DP2.UIComponents
{
    partial class UIUsers
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridUsers = new System.Windows.Forms.DataGridView();
            this.usersUsername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usersPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usersPermissions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonUsersEdit = new System.Windows.Forms.Button();
            this.buttonUsersDelete = new System.Windows.Forms.Button();
            this.buttonUsersCreate = new System.Windows.Forms.Button();
            this.labelDashboardTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridUsers
            // 
            this.dataGridUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridUsers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridUsers.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridUsers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridUsers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridUsers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(20, 10, 0, 10);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.usersUsername,
            this.usersPassword,
            this.usersPermissions});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridUsers.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridUsers.EnableHeadersVisualStyles = false;
            this.dataGridUsers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridUsers.Location = new System.Drawing.Point(55, 172);
            this.dataGridUsers.Name = "dataGridUsers";
            this.dataGridUsers.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridUsers.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridUsers.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(20, 10, 0, 10);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridUsers.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridUsers.RowTemplate.Height = 30;
            this.dataGridUsers.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridUsers.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridUsers.Size = new System.Drawing.Size(931, 412);
            this.dataGridUsers.TabIndex = 10;
            this.dataGridUsers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridUsers_CellContentClick);
            // 
            // usersUsername
            // 
            this.usersUsername.HeaderText = "USERNAME";
            this.usersUsername.Name = "usersUsername";
            // 
            // usersPassword
            // 
            this.usersPassword.HeaderText = "PASSWORD";
            this.usersPassword.Name = "usersPassword";
            // 
            // usersPermissions
            // 
            this.usersPermissions.HeaderText = "PERMISSIONS";
            this.usersPermissions.Name = "usersPermissions";
            // 
            // buttonUsersEdit
            // 
            this.buttonUsersEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.buttonUsersEdit.FlatAppearance.BorderSize = 0;
            this.buttonUsersEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUsersEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUsersEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.buttonUsersEdit.Image = global::DP2.Properties.Resources.icons8_edit_25;
            this.buttonUsersEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonUsersEdit.Location = new System.Drawing.Point(722, 623);
            this.buttonUsersEdit.Name = "buttonUsersEdit";
            this.buttonUsersEdit.Size = new System.Drawing.Size(97, 47);
            this.buttonUsersEdit.TabIndex = 19;
            this.buttonUsersEdit.Text = "EDIT";
            this.buttonUsersEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonUsersEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonUsersEdit.UseVisualStyleBackColor = false;
            this.buttonUsersEdit.Click += new System.EventHandler(this.buttonUsersEdit_Click);
            // 
            // buttonUsersDelete
            // 
            this.buttonUsersDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.buttonUsersDelete.FlatAppearance.BorderSize = 0;
            this.buttonUsersDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUsersDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUsersDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.buttonUsersDelete.Image = global::DP2.Properties.Resources.icons8_trash_25;
            this.buttonUsersDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonUsersDelete.Location = new System.Drawing.Point(865, 623);
            this.buttonUsersDelete.Name = "buttonUsersDelete";
            this.buttonUsersDelete.Size = new System.Drawing.Size(121, 47);
            this.buttonUsersDelete.TabIndex = 18;
            this.buttonUsersDelete.Text = "DELETE";
            this.buttonUsersDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonUsersDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonUsersDelete.UseVisualStyleBackColor = false;
            this.buttonUsersDelete.Click += new System.EventHandler(this.buttonUsersDelete_Click);
            // 
            // buttonUsersCreate
            // 
            this.buttonUsersCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.buttonUsersCreate.FlatAppearance.BorderSize = 0;
            this.buttonUsersCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUsersCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUsersCreate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.buttonUsersCreate.Image = global::DP2.Properties.Resources.icons8_plus_math_20;
            this.buttonUsersCreate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonUsersCreate.Location = new System.Drawing.Point(819, 77);
            this.buttonUsersCreate.Name = "buttonUsersCreate";
            this.buttonUsersCreate.Size = new System.Drawing.Size(167, 58);
            this.buttonUsersCreate.TabIndex = 17;
            this.buttonUsersCreate.Text = "CREATE USER";
            this.buttonUsersCreate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonUsersCreate.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonUsersCreate.UseVisualStyleBackColor = false;
            this.buttonUsersCreate.Click += new System.EventHandler(this.buttonUsersCreate_Click);
            // 
            // labelDashboardTitle
            // 
            this.labelDashboardTitle.AutoSize = true;
            this.labelDashboardTitle.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDashboardTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.labelDashboardTitle.Location = new System.Drawing.Point(61, 54);
            this.labelDashboardTitle.Name = "labelDashboardTitle";
            this.labelDashboardTitle.Size = new System.Drawing.Size(273, 33);
            this.labelDashboardTitle.TabIndex = 20;
            this.labelDashboardTitle.Text = "USER MANAGEMENT";
            // 
            // UIUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1040, 729);
            this.Controls.Add(this.labelDashboardTitle);
            this.Controls.Add(this.buttonUsersEdit);
            this.Controls.Add(this.buttonUsersDelete);
            this.Controls.Add(this.buttonUsersCreate);
            this.Controls.Add(this.dataGridUsers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UIUsers";
            this.Text = "UIUsers";
            this.Load += new System.EventHandler(this.UIUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridUsers;
        private System.Windows.Forms.Button buttonUsersCreate;
        private System.Windows.Forms.DataGridViewTextBoxColumn usersUsername;
        private System.Windows.Forms.DataGridViewTextBoxColumn usersPassword;
        private System.Windows.Forms.DataGridViewTextBoxColumn usersPermissions;
        private System.Windows.Forms.Button buttonUsersDelete;
        private System.Windows.Forms.Button buttonUsersEdit;
        private System.Windows.Forms.Label labelDashboardTitle;
    }
}