namespace DP2
{
    partial class UIHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UIHome));
            this.navigationBar = new System.Windows.Forms.Panel();
            this.logoPanel = new System.Windows.Forms.Panel();
            this.navIndicator = new System.Windows.Forms.Panel();
            this.titleBar = new System.Windows.Forms.Panel();
            this.content = new System.Windows.Forms.Panel();
            this.buttonMinimize = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonNavDashboard = new System.Windows.Forms.Button();
            this.buttonNavInventory = new System.Windows.Forms.Button();
            this.buttonNavSales = new System.Windows.Forms.Button();
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
            // logoPanel
            // 
            this.logoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.logoPanel.Location = new System.Drawing.Point(0, 0);
            this.logoPanel.Name = "logoPanel";
            this.logoPanel.Size = new System.Drawing.Size(265, 139);
            this.logoPanel.TabIndex = 4;
            // 
            // navIndicator
            // 
            this.navIndicator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.navIndicator.Location = new System.Drawing.Point(0, 139);
            this.navIndicator.Name = "navIndicator";
            this.navIndicator.Size = new System.Drawing.Size(25, 150);
            this.navIndicator.TabIndex = 3;
            // 
            // titleBar
            // 
            this.titleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.titleBar.Controls.Add(this.buttonMinimize);
            this.titleBar.Controls.Add(this.buttonClose);
            this.titleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleBar.Location = new System.Drawing.Point(266, 0);
            this.titleBar.Name = "titleBar";
            this.titleBar.Size = new System.Drawing.Size(1041, 29);
            this.titleBar.TabIndex = 1;
            // 
            // content
            // 
            this.content.Cursor = System.Windows.Forms.Cursors.Default;
            this.content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.content.Location = new System.Drawing.Point(266, 29);
            this.content.Name = "content";
            this.content.Size = new System.Drawing.Size(1041, 729);
            this.content.TabIndex = 2;
            this.content.Paint += new System.Windows.Forms.PaintEventHandler(this.content_Paint);
            // 
            // buttonMinimize
            // 
            this.buttonMinimize.FlatAppearance.BorderSize = 0;
            this.buttonMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinimize.Image = global::DP2.Properties.Resources.icons8_horizontal_line_15;
            this.buttonMinimize.Location = new System.Drawing.Point(955, 0);
            this.buttonMinimize.Name = "buttonMinimize";
            this.buttonMinimize.Size = new System.Drawing.Size(42, 29);
            this.buttonMinimize.TabIndex = 2;
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
            this.buttonClose.Location = new System.Drawing.Point(999, 0);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(42, 29);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.TabStop = false;
            this.buttonClose.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonNavDashboard
            // 
            this.buttonNavDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.buttonNavDashboard.FlatAppearance.BorderSize = 0;
            this.buttonNavDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNavDashboard.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNavDashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.buttonNavDashboard.Image = ((System.Drawing.Image)(resources.GetObject("buttonNavDashboard.Image")));
            this.buttonNavDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonNavDashboard.Location = new System.Drawing.Point(0, 440);
            this.buttonNavDashboard.Name = "buttonNavDashboard";
            this.buttonNavDashboard.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.buttonNavDashboard.Size = new System.Drawing.Size(266, 150);
            this.buttonNavDashboard.TabIndex = 3;
            this.buttonNavDashboard.TabStop = false;
            this.buttonNavDashboard.Text = "    Dashboard";
            this.buttonNavDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonNavDashboard.UseVisualStyleBackColor = false;
            this.buttonNavDashboard.Click += new System.EventHandler(this.buttonNavDashboard_Click);
            // 
            // buttonNavInventory
            // 
            this.buttonNavInventory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.buttonNavInventory.FlatAppearance.BorderSize = 0;
            this.buttonNavInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNavInventory.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNavInventory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.buttonNavInventory.Image = global::DP2.Properties.Resources.icons8_empty_box_40;
            this.buttonNavInventory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonNavInventory.Location = new System.Drawing.Point(0, 289);
            this.buttonNavInventory.Name = "buttonNavInventory";
            this.buttonNavInventory.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.buttonNavInventory.Size = new System.Drawing.Size(266, 150);
            this.buttonNavInventory.TabIndex = 2;
            this.buttonNavInventory.TabStop = false;
            this.buttonNavInventory.Text = "   Inventory";
            this.buttonNavInventory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonNavInventory.UseVisualStyleBackColor = false;
            this.buttonNavInventory.Click += new System.EventHandler(this.buttonNavInventory_Click);
            // 
            // buttonNavSales
            // 
            this.buttonNavSales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.buttonNavSales.FlatAppearance.BorderSize = 0;
            this.buttonNavSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNavSales.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNavSales.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.buttonNavSales.Image = global::DP2.Properties.Resources.icons8_cash_register_40;
            this.buttonNavSales.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonNavSales.Location = new System.Drawing.Point(0, 139);
            this.buttonNavSales.Name = "buttonNavSales";
            this.buttonNavSales.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.buttonNavSales.Size = new System.Drawing.Size(266, 150);
            this.buttonNavSales.TabIndex = 1;
            this.buttonNavSales.TabStop = false;
            this.buttonNavSales.Text = "   Sales Transaction";
            this.buttonNavSales.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonNavSales.UseVisualStyleBackColor = false;
            this.buttonNavSales.Click += new System.EventHandler(this.buttonNavSales_Click);
            // 
            // formHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1307, 758);
            this.Controls.Add(this.content);
            this.Controls.Add(this.titleBar);
            this.Controls.Add(this.navigationBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Panel content;
    }
}