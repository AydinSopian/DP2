namespace DP2
{
    partial class formHome
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
            this.navigationBar = new System.Windows.Forms.Panel();
            this.titleBar = new System.Windows.Forms.Panel();
            this.buttonNavSales = new System.Windows.Forms.Button();
            this.buttonNavInventory = new System.Windows.Forms.Button();
            this.buttonNavDashboard = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonMinimize = new System.Windows.Forms.Button();
            this.navIndicator = new System.Windows.Forms.Panel();
            this.logoPanel = new System.Windows.Forms.Panel();
            this.navigationBar.SuspendLayout();
            this.titleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // navigationBar
            // 
            this.navigationBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.navigationBar.Controls.Add(this.logoPanel);
            this.navigationBar.Controls.Add(this.navIndicator);
            this.navigationBar.Controls.Add(this.buttonNavDashboard);
            this.navigationBar.Controls.Add(this.buttonNavInventory);
            this.navigationBar.Controls.Add(this.buttonNavSales);
            this.navigationBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.navigationBar.Location = new System.Drawing.Point(0, 0);
            this.navigationBar.Name = "navigationBar";
            this.navigationBar.Size = new System.Drawing.Size(266, 758);
            this.navigationBar.TabIndex = 0;
            // 
            // titleBar
            // 
            this.titleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.titleBar.Controls.Add(this.buttonMinimize);
            this.titleBar.Controls.Add(this.buttonClose);
            this.titleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleBar.Location = new System.Drawing.Point(266, 0);
            this.titleBar.Name = "titleBar";
            this.titleBar.Size = new System.Drawing.Size(1041, 46);
            this.titleBar.TabIndex = 1;
            // 
            // buttonNavSales
            // 
            this.buttonNavSales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.buttonNavSales.FlatAppearance.BorderSize = 0;
            this.buttonNavSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNavSales.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNavSales.ForeColor = System.Drawing.Color.White;
            this.buttonNavSales.Location = new System.Drawing.Point(0, 139);
            this.buttonNavSales.Name = "buttonNavSales";
            this.buttonNavSales.Size = new System.Drawing.Size(256, 150);
            this.buttonNavSales.TabIndex = 0;
            this.buttonNavSales.Text = "SALES TRANSACTION";
            this.buttonNavSales.UseVisualStyleBackColor = false;
            // 
            // buttonNavInventory
            // 
            this.buttonNavInventory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.buttonNavInventory.FlatAppearance.BorderSize = 0;
            this.buttonNavInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNavInventory.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNavInventory.ForeColor = System.Drawing.Color.White;
            this.buttonNavInventory.Location = new System.Drawing.Point(0, 289);
            this.buttonNavInventory.Name = "buttonNavInventory";
            this.buttonNavInventory.Size = new System.Drawing.Size(256, 150);
            this.buttonNavInventory.TabIndex = 1;
            this.buttonNavInventory.Text = "INVENTORY";
            this.buttonNavInventory.UseVisualStyleBackColor = false;
            // 
            // buttonNavDashboard
            // 
            this.buttonNavDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.buttonNavDashboard.FlatAppearance.BorderSize = 0;
            this.buttonNavDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNavDashboard.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNavDashboard.ForeColor = System.Drawing.Color.White;
            this.buttonNavDashboard.Location = new System.Drawing.Point(0, 435);
            this.buttonNavDashboard.Name = "buttonNavDashboard";
            this.buttonNavDashboard.Size = new System.Drawing.Size(256, 150);
            this.buttonNavDashboard.TabIndex = 2;
            this.buttonNavDashboard.Text = "DASHBOARD";
            this.buttonNavDashboard.UseVisualStyleBackColor = false;
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.buttonClose.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Location = new System.Drawing.Point(971, 0);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(70, 46);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.UseVisualStyleBackColor = false;
            // 
            // buttonMinimize
            // 
            this.buttonMinimize.FlatAppearance.BorderSize = 0;
            this.buttonMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinimize.Location = new System.Drawing.Point(903, 0);
            this.buttonMinimize.Name = "buttonMinimize";
            this.buttonMinimize.Size = new System.Drawing.Size(70, 46);
            this.buttonMinimize.TabIndex = 2;
            this.buttonMinimize.UseVisualStyleBackColor = true;
            // 
            // navIndicator
            // 
            this.navIndicator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.navIndicator.Location = new System.Drawing.Point(256, 139);
            this.navIndicator.Name = "navIndicator";
            this.navIndicator.Size = new System.Drawing.Size(9, 150);
            this.navIndicator.TabIndex = 3;
            // 
            // logoPanel
            // 
            this.logoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.logoPanel.Location = new System.Drawing.Point(0, 0);
            this.logoPanel.Name = "logoPanel";
            this.logoPanel.Size = new System.Drawing.Size(265, 139);
            this.logoPanel.TabIndex = 4;
            // 
            // formHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1307, 758);
            this.Controls.Add(this.titleBar);
            this.Controls.Add(this.navigationBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formHome";
            this.Text = "home";
            this.Load += new System.EventHandler(this.home_Load);
            this.navigationBar.ResumeLayout(false);
            this.titleBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel navigationBar;
        private System.Windows.Forms.Button buttonNavDashboard;
        private System.Windows.Forms.Button buttonNavInventory;
        private System.Windows.Forms.Button buttonNavSales;
        private System.Windows.Forms.Panel titleBar;
        private System.Windows.Forms.Panel navIndicator;
        private System.Windows.Forms.Button buttonMinimize;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Panel logoPanel;
    }
}