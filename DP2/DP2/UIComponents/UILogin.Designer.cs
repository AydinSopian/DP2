namespace DP2.UIComponents
{
    partial class UILogin
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
            this.textLoginPassword = new System.Windows.Forms.TextBox();
            this.textLoginUsername = new System.Windows.Forms.TextBox();
            this.buttonLoginLogin = new System.Windows.Forms.Button();
            this.buttonLoginCancel = new System.Windows.Forms.Button();
            this.labelLoginUsername = new System.Windows.Forms.Label();
            this.labelLoginPassword = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonMinimize = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.linkLabelLoginForgotPassword = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textLoginPassword
            // 
            this.textLoginPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(75)))), ((int)(((byte)(85)))));
            this.textLoginPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textLoginPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textLoginPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.textLoginPassword.Location = new System.Drawing.Point(112, 155);
            this.textLoginPassword.Name = "textLoginPassword";
            this.textLoginPassword.Size = new System.Drawing.Size(190, 19);
            this.textLoginPassword.TabIndex = 2;
            // 
            // textLoginUsername
            // 
            this.textLoginUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(75)))), ((int)(((byte)(85)))));
            this.textLoginUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textLoginUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textLoginUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.textLoginUsername.Location = new System.Drawing.Point(112, 87);
            this.textLoginUsername.Name = "textLoginUsername";
            this.textLoginUsername.Size = new System.Drawing.Size(190, 19);
            this.textLoginUsername.TabIndex = 1;
            // 
            // buttonLoginLogin
            // 
            this.buttonLoginLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.buttonLoginLogin.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.buttonLoginLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLoginLogin.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLoginLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.buttonLoginLogin.Location = new System.Drawing.Point(112, 227);
            this.buttonLoginLogin.Name = "buttonLoginLogin";
            this.buttonLoginLogin.Size = new System.Drawing.Size(87, 52);
            this.buttonLoginLogin.TabIndex = 3;
            this.buttonLoginLogin.Text = "Login";
            this.buttonLoginLogin.UseVisualStyleBackColor = false;
            this.buttonLoginLogin.Click += new System.EventHandler(this.buttonConfirmationContinue_Click);
            // 
            // buttonLoginCancel
            // 
            this.buttonLoginCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.buttonLoginCancel.FlatAppearance.BorderSize = 0;
            this.buttonLoginCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLoginCancel.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLoginCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.buttonLoginCancel.Location = new System.Drawing.Point(215, 227);
            this.buttonLoginCancel.Name = "buttonLoginCancel";
            this.buttonLoginCancel.Size = new System.Drawing.Size(87, 52);
            this.buttonLoginCancel.TabIndex = 4;
            this.buttonLoginCancel.TabStop = false;
            this.buttonLoginCancel.Text = "Cancel";
            this.buttonLoginCancel.UseVisualStyleBackColor = false;
            this.buttonLoginCancel.Click += new System.EventHandler(this.buttonConfirmationCancel_Click);
            // 
            // labelLoginUsername
            // 
            this.labelLoginUsername.AutoSize = true;
            this.labelLoginUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoginUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.labelLoginUsername.Location = new System.Drawing.Point(108, 64);
            this.labelLoginUsername.Name = "labelLoginUsername";
            this.labelLoginUsername.Size = new System.Drawing.Size(91, 20);
            this.labelLoginUsername.TabIndex = 7;
            this.labelLoginUsername.Text = "Username :";
            // 
            // labelLoginPassword
            // 
            this.labelLoginPassword.AutoSize = true;
            this.labelLoginPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoginPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.labelLoginPassword.Location = new System.Drawing.Point(108, 132);
            this.labelLoginPassword.Name = "labelLoginPassword";
            this.labelLoginPassword.Size = new System.Drawing.Size(86, 20);
            this.labelLoginPassword.TabIndex = 8;
            this.labelLoginPassword.Text = "Password :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panel1.Controls.Add(this.buttonMinimize);
            this.panel1.Controls.Add(this.buttonClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(424, 30);
            this.panel1.TabIndex = 9;
            // 
            // buttonMinimize
            // 
            this.buttonMinimize.FlatAppearance.BorderSize = 0;
            this.buttonMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinimize.Image = global::DP2.Properties.Resources.icons8_horizontal_line_15;
            this.buttonMinimize.Location = new System.Drawing.Point(338, 0);
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
            this.buttonClose.Location = new System.Drawing.Point(382, 0);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(42, 29);
            this.buttonClose.TabIndex = 3;
            this.buttonClose.TabStop = false;
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // linkLabelLoginForgotPassword
            // 
            this.linkLabelLoginForgotPassword.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.linkLabelLoginForgotPassword.AutoSize = true;
            this.linkLabelLoginForgotPassword.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelLoginForgotPassword.LinkColor = System.Drawing.Color.Gray;
            this.linkLabelLoginForgotPassword.Location = new System.Drawing.Point(159, 186);
            this.linkLabelLoginForgotPassword.Name = "linkLabelLoginForgotPassword";
            this.linkLabelLoginForgotPassword.Size = new System.Drawing.Size(99, 15);
            this.linkLabelLoginForgotPassword.TabIndex = 10;
            this.linkLabelLoginForgotPassword.Text = "Forgot password?";
            this.linkLabelLoginForgotPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UILogin
            // 
            this.AcceptButton = this.buttonLoginLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(424, 327);
            this.Controls.Add(this.linkLabelLoginForgotPassword);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelLoginPassword);
            this.Controls.Add(this.labelLoginUsername);
            this.Controls.Add(this.buttonLoginCancel);
            this.Controls.Add(this.buttonLoginLogin);
            this.Controls.Add(this.textLoginUsername);
            this.Controls.Add(this.textLoginPassword);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UILogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UILogin";
            this.Load += new System.EventHandler(this.UILogin_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textLoginPassword;
        private System.Windows.Forms.TextBox textLoginUsername;
        private System.Windows.Forms.Button buttonLoginLogin;
        private System.Windows.Forms.Button buttonLoginCancel;
        private System.Windows.Forms.Label labelLoginUsername;
        private System.Windows.Forms.Label labelLoginPassword;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonMinimize;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.LinkLabel linkLabelLoginForgotPassword;
    }
}