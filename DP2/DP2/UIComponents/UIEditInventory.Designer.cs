namespace DP2.UIComponents
{
    partial class UIEditInventory
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
            this.labelEditInventoryTitle = new System.Windows.Forms.Label();
            this.buttonEditInventoryCancel = new System.Windows.Forms.Button();
            this.buttonEditInventoryEdit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonMinimize = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.textInventoryCategory = new System.Windows.Forms.ComboBox();
            this.labelInventoryCategory = new System.Windows.Forms.Label();
            this.labelInventoryQty = new System.Windows.Forms.Label();
            this.labelInventoryPrice = new System.Windows.Forms.Label();
            this.labelInventoryCost = new System.Windows.Forms.Label();
            this.labelInventoryItem = new System.Windows.Forms.Label();
            this.textInventoryQty = new System.Windows.Forms.TextBox();
            this.textInventoryPrice = new System.Windows.Forms.TextBox();
            this.textInventoryCost = new System.Windows.Forms.TextBox();
            this.textInventoryItem = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelEditInventoryTitle
            // 
            this.labelEditInventoryTitle.AutoSize = true;
            this.labelEditInventoryTitle.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEditInventoryTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.labelEditInventoryTitle.Location = new System.Drawing.Point(123, 59);
            this.labelEditInventoryTitle.Name = "labelEditInventoryTitle";
            this.labelEditInventoryTitle.Size = new System.Drawing.Size(220, 24);
            this.labelEditInventoryTitle.TabIndex = 38;
            this.labelEditInventoryTitle.Text = "EDIT INVENTORY ITEM";
            // 
            // buttonEditInventoryCancel
            // 
            this.buttonEditInventoryCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.buttonEditInventoryCancel.FlatAppearance.BorderSize = 0;
            this.buttonEditInventoryCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditInventoryCancel.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditInventoryCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.buttonEditInventoryCancel.Location = new System.Drawing.Point(247, 387);
            this.buttonEditInventoryCancel.Name = "buttonEditInventoryCancel";
            this.buttonEditInventoryCancel.Size = new System.Drawing.Size(87, 52);
            this.buttonEditInventoryCancel.TabIndex = 36;
            this.buttonEditInventoryCancel.TabStop = false;
            this.buttonEditInventoryCancel.Text = "Cancel";
            this.buttonEditInventoryCancel.UseVisualStyleBackColor = false;
            this.buttonEditInventoryCancel.Click += new System.EventHandler(this.buttonEditInventoryCancel_Click);
            // 
            // buttonEditInventoryEdit
            // 
            this.buttonEditInventoryEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.buttonEditInventoryEdit.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.buttonEditInventoryEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditInventoryEdit.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditInventoryEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.buttonEditInventoryEdit.Location = new System.Drawing.Point(127, 387);
            this.buttonEditInventoryEdit.Name = "buttonEditInventoryEdit";
            this.buttonEditInventoryEdit.Size = new System.Drawing.Size(87, 52);
            this.buttonEditInventoryEdit.TabIndex = 35;
            this.buttonEditInventoryEdit.Text = "Edit";
            this.buttonEditInventoryEdit.UseVisualStyleBackColor = false;
            this.buttonEditInventoryEdit.Click += new System.EventHandler(this.buttonEditInventoryEdit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panel1.Controls.Add(this.buttonMinimize);
            this.panel1.Controls.Add(this.buttonClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(462, 30);
            this.panel1.TabIndex = 30;
            // 
            // buttonMinimize
            // 
            this.buttonMinimize.FlatAppearance.BorderSize = 0;
            this.buttonMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinimize.Image = global::DP2.Properties.Resources.icons8_horizontal_line_15;
            this.buttonMinimize.Location = new System.Drawing.Point(376, 0);
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
            this.buttonClose.Location = new System.Drawing.Point(420, 0);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(42, 29);
            this.buttonClose.TabIndex = 3;
            this.buttonClose.TabStop = false;
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // textInventoryCategory
            // 
            this.textInventoryCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(75)))), ((int)(((byte)(85)))));
            this.textInventoryCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.textInventoryCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textInventoryCategory.ForeColor = System.Drawing.Color.White;
            this.textInventoryCategory.FormattingEnabled = true;
            this.textInventoryCategory.Location = new System.Drawing.Point(186, 119);
            this.textInventoryCategory.Name = "textInventoryCategory";
            this.textInventoryCategory.Size = new System.Drawing.Size(201, 28);
            this.textInventoryCategory.TabIndex = 48;
            // 
            // labelInventoryCategory
            // 
            this.labelInventoryCategory.AutoSize = true;
            this.labelInventoryCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInventoryCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.labelInventoryCategory.Location = new System.Drawing.Point(60, 122);
            this.labelInventoryCategory.Name = "labelInventoryCategory";
            this.labelInventoryCategory.Size = new System.Drawing.Size(117, 20);
            this.labelInventoryCategory.TabIndex = 47;
            this.labelInventoryCategory.Text = "Category          :";
            // 
            // labelInventoryQty
            // 
            this.labelInventoryQty.AutoSize = true;
            this.labelInventoryQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInventoryQty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.labelInventoryQty.Location = new System.Drawing.Point(60, 329);
            this.labelInventoryQty.Name = "labelInventoryQty";
            this.labelInventoryQty.Size = new System.Drawing.Size(117, 20);
            this.labelInventoryQty.TabIndex = 46;
            this.labelInventoryQty.Text = "Qty                    :";
            // 
            // labelInventoryPrice
            // 
            this.labelInventoryPrice.AutoSize = true;
            this.labelInventoryPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInventoryPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.labelInventoryPrice.Location = new System.Drawing.Point(60, 277);
            this.labelInventoryPrice.Name = "labelInventoryPrice";
            this.labelInventoryPrice.Size = new System.Drawing.Size(117, 20);
            this.labelInventoryPrice.TabIndex = 45;
            this.labelInventoryPrice.Text = "Price Per Unit  :";
            // 
            // labelInventoryCost
            // 
            this.labelInventoryCost.AutoSize = true;
            this.labelInventoryCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInventoryCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.labelInventoryCost.Location = new System.Drawing.Point(60, 226);
            this.labelInventoryCost.Name = "labelInventoryCost";
            this.labelInventoryCost.Size = new System.Drawing.Size(115, 20);
            this.labelInventoryCost.TabIndex = 44;
            this.labelInventoryCost.Text = "Cost Per Unit  :";
            // 
            // labelInventoryItem
            // 
            this.labelInventoryItem.AutoSize = true;
            this.labelInventoryItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInventoryItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.labelInventoryItem.Location = new System.Drawing.Point(60, 173);
            this.labelInventoryItem.Name = "labelInventoryItem";
            this.labelInventoryItem.Size = new System.Drawing.Size(117, 20);
            this.labelInventoryItem.TabIndex = 43;
            this.labelInventoryItem.Text = "Item                  :";
            // 
            // textInventoryQty
            // 
            this.textInventoryQty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(75)))), ((int)(((byte)(85)))));
            this.textInventoryQty.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textInventoryQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textInventoryQty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.textInventoryQty.Location = new System.Drawing.Point(186, 330);
            this.textInventoryQty.Name = "textInventoryQty";
            this.textInventoryQty.Size = new System.Drawing.Size(201, 19);
            this.textInventoryQty.TabIndex = 42;
            // 
            // textInventoryPrice
            // 
            this.textInventoryPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(75)))), ((int)(((byte)(85)))));
            this.textInventoryPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textInventoryPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textInventoryPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.textInventoryPrice.Location = new System.Drawing.Point(186, 278);
            this.textInventoryPrice.Name = "textInventoryPrice";
            this.textInventoryPrice.Size = new System.Drawing.Size(201, 19);
            this.textInventoryPrice.TabIndex = 41;
            // 
            // textInventoryCost
            // 
            this.textInventoryCost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(75)))), ((int)(((byte)(85)))));
            this.textInventoryCost.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textInventoryCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textInventoryCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.textInventoryCost.Location = new System.Drawing.Point(186, 226);
            this.textInventoryCost.Name = "textInventoryCost";
            this.textInventoryCost.Size = new System.Drawing.Size(201, 19);
            this.textInventoryCost.TabIndex = 40;
            // 
            // textInventoryItem
            // 
            this.textInventoryItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(75)))), ((int)(((byte)(85)))));
            this.textInventoryItem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textInventoryItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textInventoryItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.textInventoryItem.Location = new System.Drawing.Point(186, 174);
            this.textInventoryItem.Name = "textInventoryItem";
            this.textInventoryItem.Size = new System.Drawing.Size(201, 19);
            this.textInventoryItem.TabIndex = 39;
            // 
            // UIEditInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(462, 462);
            this.Controls.Add(this.textInventoryCategory);
            this.Controls.Add(this.labelInventoryCategory);
            this.Controls.Add(this.labelInventoryQty);
            this.Controls.Add(this.labelInventoryPrice);
            this.Controls.Add(this.labelInventoryCost);
            this.Controls.Add(this.labelInventoryItem);
            this.Controls.Add(this.textInventoryQty);
            this.Controls.Add(this.textInventoryPrice);
            this.Controls.Add(this.textInventoryCost);
            this.Controls.Add(this.textInventoryItem);
            this.Controls.Add(this.labelEditInventoryTitle);
            this.Controls.Add(this.buttonEditInventoryCancel);
            this.Controls.Add(this.buttonEditInventoryEdit);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UIEditInventory";
            this.Text = "UIEditInventory";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelEditInventoryTitle;
        private System.Windows.Forms.Button buttonEditInventoryCancel;
        private System.Windows.Forms.Button buttonEditInventoryEdit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonMinimize;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.ComboBox textInventoryCategory;
        private System.Windows.Forms.Label labelInventoryCategory;
        private System.Windows.Forms.Label labelInventoryQty;
        private System.Windows.Forms.Label labelInventoryPrice;
        private System.Windows.Forms.Label labelInventoryCost;
        private System.Windows.Forms.Label labelInventoryItem;
        private System.Windows.Forms.TextBox textInventoryQty;
        private System.Windows.Forms.TextBox textInventoryPrice;
        private System.Windows.Forms.TextBox textInventoryCost;
        private System.Windows.Forms.TextBox textInventoryItem;
    }
}