﻿namespace DP2
{
    partial class formInventory
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.textInventoryItem = new System.Windows.Forms.TextBox();
            this.textInventoryCost = new System.Windows.Forms.TextBox();
            this.textInventoryPrice = new System.Windows.Forms.TextBox();
            this.textInventoryQty = new System.Windows.Forms.TextBox();
            this.labelInventoryItem = new System.Windows.Forms.Label();
            this.labelInventoryCost = new System.Windows.Forms.Label();
            this.labelInventoryPrice = new System.Windows.Forms.Label();
            this.labelInventoryQty = new System.Windows.Forms.Label();
            this.dataGridInventory = new System.Windows.Forms.DataGridView();
            this.inventoryNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inventoryItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inventoryCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inventoryPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inventoryQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonInventoryAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridInventory)).BeginInit();
            this.SuspendLayout();
            // 
            // textInventoryItem
            // 
            this.textInventoryItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(75)))), ((int)(((byte)(85)))));
            this.textInventoryItem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textInventoryItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textInventoryItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.textInventoryItem.Location = new System.Drawing.Point(43, 68);
            this.textInventoryItem.Name = "textInventoryItem";
            this.textInventoryItem.Size = new System.Drawing.Size(317, 19);
            this.textInventoryItem.TabIndex = 0;
            // 
            // textInventoryCost
            // 
            this.textInventoryCost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(75)))), ((int)(((byte)(85)))));
            this.textInventoryCost.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textInventoryCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textInventoryCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.textInventoryCost.Location = new System.Drawing.Point(386, 68);
            this.textInventoryCost.Name = "textInventoryCost";
            this.textInventoryCost.Size = new System.Drawing.Size(145, 19);
            this.textInventoryCost.TabIndex = 1;
            // 
            // textInventoryPrice
            // 
            this.textInventoryPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(75)))), ((int)(((byte)(85)))));
            this.textInventoryPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textInventoryPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textInventoryPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.textInventoryPrice.Location = new System.Drawing.Point(556, 68);
            this.textInventoryPrice.Name = "textInventoryPrice";
            this.textInventoryPrice.Size = new System.Drawing.Size(145, 19);
            this.textInventoryPrice.TabIndex = 2;
            // 
            // textInventoryQty
            // 
            this.textInventoryQty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(75)))), ((int)(((byte)(85)))));
            this.textInventoryQty.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textInventoryQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textInventoryQty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.textInventoryQty.Location = new System.Drawing.Point(727, 68);
            this.textInventoryQty.Name = "textInventoryQty";
            this.textInventoryQty.Size = new System.Drawing.Size(101, 19);
            this.textInventoryQty.TabIndex = 3;
            // 
            // labelInventoryItem
            // 
            this.labelInventoryItem.AutoSize = true;
            this.labelInventoryItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInventoryItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.labelInventoryItem.Location = new System.Drawing.Point(39, 39);
            this.labelInventoryItem.Name = "labelInventoryItem";
            this.labelInventoryItem.Size = new System.Drawing.Size(49, 20);
            this.labelInventoryItem.TabIndex = 4;
            this.labelInventoryItem.Text = "Item :";
            // 
            // labelInventoryCost
            // 
            this.labelInventoryCost.AutoSize = true;
            this.labelInventoryCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInventoryCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.labelInventoryCost.Location = new System.Drawing.Point(382, 39);
            this.labelInventoryCost.Name = "labelInventoryCost";
            this.labelInventoryCost.Size = new System.Drawing.Size(111, 20);
            this.labelInventoryCost.TabIndex = 5;
            this.labelInventoryCost.Text = "Cost Per Unit :";
            // 
            // labelInventoryPrice
            // 
            this.labelInventoryPrice.AutoSize = true;
            this.labelInventoryPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInventoryPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.labelInventoryPrice.Location = new System.Drawing.Point(552, 39);
            this.labelInventoryPrice.Name = "labelInventoryPrice";
            this.labelInventoryPrice.Size = new System.Drawing.Size(113, 20);
            this.labelInventoryPrice.TabIndex = 6;
            this.labelInventoryPrice.Text = "Price Per Unit :";
            // 
            // labelInventoryQty
            // 
            this.labelInventoryQty.AutoSize = true;
            this.labelInventoryQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInventoryQty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.labelInventoryQty.Location = new System.Drawing.Point(723, 39);
            this.labelInventoryQty.Name = "labelInventoryQty";
            this.labelInventoryQty.Size = new System.Drawing.Size(41, 20);
            this.labelInventoryQty.TabIndex = 7;
            this.labelInventoryQty.Text = "Qty :";
            // 
            // dataGridInventory
            // 
            this.dataGridInventory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridInventory.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridInventory.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridInventory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridInventory.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridInventory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle9.Padding = new System.Windows.Forms.Padding(20, 10, 0, 10);
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridInventory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridInventory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.inventoryNum,
            this.inventoryItem,
            this.inventoryCost,
            this.inventoryPrice,
            this.inventoryQty});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridInventory.DefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridInventory.EnableHeadersVisualStyles = false;
            this.dataGridInventory.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridInventory.Location = new System.Drawing.Point(12, 128);
            this.dataGridInventory.Name = "dataGridInventory";
            this.dataGridInventory.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridInventory.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridInventory.RowHeadersVisible = false;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Padding = new System.Windows.Forms.Padding(20, 10, 0, 10);
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridInventory.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridInventory.RowTemplate.Height = 30;
            this.dataGridInventory.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridInventory.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridInventory.Size = new System.Drawing.Size(1016, 589);
            this.dataGridInventory.TabIndex = 9;
            this.dataGridInventory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridInventory_CellContentClick);
            // 
            // inventoryNum
            // 
            this.inventoryNum.HeaderText = "NO.";
            this.inventoryNum.Name = "inventoryNum";
            // 
            // inventoryItem
            // 
            this.inventoryItem.HeaderText = "ITEM";
            this.inventoryItem.Name = "inventoryItem";
            // 
            // inventoryCost
            // 
            this.inventoryCost.HeaderText = "COST PER UNIT";
            this.inventoryCost.Name = "inventoryCost";
            // 
            // inventoryPrice
            // 
            this.inventoryPrice.HeaderText = "PRICE PER UNIT";
            this.inventoryPrice.Name = "inventoryPrice";
            // 
            // inventoryQty
            // 
            this.inventoryQty.HeaderText = "QTY";
            this.inventoryQty.Name = "inventoryQty";
            // 
            // buttonInventoryAdd
            // 
            this.buttonInventoryAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.buttonInventoryAdd.FlatAppearance.BorderSize = 0;
            this.buttonInventoryAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInventoryAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInventoryAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.buttonInventoryAdd.Image = global::DP2.Properties.Resources.icons8_plus_math_20;
            this.buttonInventoryAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonInventoryAdd.Location = new System.Drawing.Point(863, 43);
            this.buttonInventoryAdd.Name = "buttonInventoryAdd";
            this.buttonInventoryAdd.Size = new System.Drawing.Size(121, 47);
            this.buttonInventoryAdd.TabIndex = 8;
            this.buttonInventoryAdd.Text = "ADD ITEM";
            this.buttonInventoryAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonInventoryAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonInventoryAdd.UseVisualStyleBackColor = false;
            this.buttonInventoryAdd.Click += new System.EventHandler(this.buttonInventoryAdd_Click);
            // 
            // formInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1040, 729);
            this.Controls.Add(this.dataGridInventory);
            this.Controls.Add(this.buttonInventoryAdd);
            this.Controls.Add(this.labelInventoryQty);
            this.Controls.Add(this.labelInventoryPrice);
            this.Controls.Add(this.labelInventoryCost);
            this.Controls.Add(this.labelInventoryItem);
            this.Controls.Add(this.textInventoryQty);
            this.Controls.Add(this.textInventoryPrice);
            this.Controls.Add(this.textInventoryCost);
            this.Controls.Add(this.textInventoryItem);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formInventory";
            this.Text = "Inventory Managent";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridInventory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textInventoryItem;
        private System.Windows.Forms.TextBox textInventoryCost;
        private System.Windows.Forms.TextBox textInventoryPrice;
        private System.Windows.Forms.TextBox textInventoryQty;
        private System.Windows.Forms.Label labelInventoryItem;
        private System.Windows.Forms.Label labelInventoryCost;
        private System.Windows.Forms.Label labelInventoryPrice;
        private System.Windows.Forms.Label labelInventoryQty;
        private System.Windows.Forms.Button buttonInventoryAdd;
        private System.Windows.Forms.DataGridView dataGridInventory;
        private System.Windows.Forms.DataGridViewTextBoxColumn inventoryNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn inventoryItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn inventoryCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn inventoryPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn inventoryQty;
    }
}