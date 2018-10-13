namespace DP2
{
    partial class formSales
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelSalesItem = new System.Windows.Forms.Label();
            this.textSalesItem = new System.Windows.Forms.TextBox();
            this.labelSalesQty = new System.Windows.Forms.Label();
            this.textSalesQty = new System.Windows.Forms.TextBox();
            this.dataGridSales = new System.Windows.Forms.DataGridView();
            this.salesDeleteRow = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelSalesTotal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSalesCheckout = new System.Windows.Forms.Button();
            this.textSalesCategory = new System.Windows.Forms.TextBox();
            this.labelSalesCategory = new System.Windows.Forms.Label();
            this.buttonSalesAdd = new System.Windows.Forms.Button();
            this.salesNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesSubtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesTransactionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSales)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salesTransactionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // labelSalesItem
            // 
            this.labelSalesItem.AutoSize = true;
            this.labelSalesItem.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSalesItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.labelSalesItem.Location = new System.Drawing.Point(351, 42);
            this.labelSalesItem.Name = "labelSalesItem";
            this.labelSalesItem.Size = new System.Drawing.Size(52, 22);
            this.labelSalesItem.TabIndex = 6;
            this.labelSalesItem.Text = "Item :";
            // 
            // textSalesItem
            // 
            this.textSalesItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(75)))), ((int)(((byte)(85)))));
            this.textSalesItem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textSalesItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSalesItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.textSalesItem.Location = new System.Drawing.Point(355, 67);
            this.textSalesItem.Name = "textSalesItem";
            this.textSalesItem.Size = new System.Drawing.Size(223, 19);
            this.textSalesItem.TabIndex = 2;
            this.textSalesItem.Enter += new System.EventHandler(this.textSalesItem_Enter);
            // 
            // labelSalesQty
            // 
            this.labelSalesQty.AutoSize = true;
            this.labelSalesQty.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSalesQty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.labelSalesQty.Location = new System.Drawing.Point(606, 42);
            this.labelSalesQty.Name = "labelSalesQty";
            this.labelSalesQty.Size = new System.Drawing.Size(44, 22);
            this.labelSalesQty.TabIndex = 8;
            this.labelSalesQty.Text = "Qty :";
            // 
            // textSalesQty
            // 
            this.textSalesQty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(75)))), ((int)(((byte)(85)))));
            this.textSalesQty.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textSalesQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSalesQty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.textSalesQty.Location = new System.Drawing.Point(610, 67);
            this.textSalesQty.Name = "textSalesQty";
            this.textSalesQty.Size = new System.Drawing.Size(138, 19);
            this.textSalesQty.TabIndex = 3;
            this.textSalesQty.Enter += new System.EventHandler(this.textSalesQty_Enter);
            // 
            // dataGridSales
            // 
            this.dataGridSales.AutoGenerateColumns = false;
            this.dataGridSales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridSales.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridSales.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridSales.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridSales.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridSales.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(20, 10, 0, 10);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridSales.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.salesNum,
            this.salesCategory,
            this.salesItem,
            this.salesQty,
            this.salesPrice,
            this.salesSubtotal,
            this.salesDeleteRow});
            this.dataGridSales.DataSource = this.salesTransactionBindingSource;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridSales.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridSales.EnableHeadersVisualStyles = false;
            this.dataGridSales.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridSales.Location = new System.Drawing.Point(107, 135);
            this.dataGridSales.Name = "dataGridSales";
            this.dataGridSales.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridSales.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridSales.RowHeadersVisible = false;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(20, 10, 0, 10);
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridSales.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridSales.RowTemplate.Height = 30;
            this.dataGridSales.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridSales.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridSales.Size = new System.Drawing.Size(828, 446);
            this.dataGridSales.TabIndex = 10;
            this.dataGridSales.TabStop = false;
            this.dataGridSales.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridSales_CellContentClick);
            // 
            // salesDeleteRow
            // 
            this.salesDeleteRow.FillWeight = 55.50259F;
            this.salesDeleteRow.HeaderText = "";
            this.salesDeleteRow.Name = "salesDeleteRow";
            this.salesDeleteRow.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.salesDeleteRow.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.labelSalesTotal);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.buttonSalesCheckout);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 640);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1040, 89);
            this.panel1.TabIndex = 11;
            // 
            // labelSalesTotal
            // 
            this.labelSalesTotal.AutoSize = true;
            this.labelSalesTotal.Font = new System.Drawing.Font("Open Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSalesTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.labelSalesTotal.Location = new System.Drawing.Point(630, 29);
            this.labelSalesTotal.Name = "labelSalesTotal";
            this.labelSalesTotal.Size = new System.Drawing.Size(44, 28);
            this.labelSalesTotal.TabIndex = 2;
            this.labelSalesTotal.Text = "RM";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.label1.Location = new System.Drawing.Point(537, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "TOTAL :";
            // 
            // buttonSalesCheckout
            // 
            this.buttonSalesCheckout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.buttonSalesCheckout.FlatAppearance.BorderSize = 0;
            this.buttonSalesCheckout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSalesCheckout.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalesCheckout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.buttonSalesCheckout.Image = global::DP2.Properties.Resources.icons8_right_35;
            this.buttonSalesCheckout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSalesCheckout.Location = new System.Drawing.Point(849, 0);
            this.buttonSalesCheckout.Name = "buttonSalesCheckout";
            this.buttonSalesCheckout.Size = new System.Drawing.Size(191, 89);
            this.buttonSalesCheckout.TabIndex = 0;
            this.buttonSalesCheckout.Text = "CHECKOUT";
            this.buttonSalesCheckout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSalesCheckout.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonSalesCheckout.UseVisualStyleBackColor = false;
            this.buttonSalesCheckout.Click += new System.EventHandler(this.buttonSalesCheckout_Click);
            // 
            // textSalesCategory
            // 
            this.textSalesCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(75)))), ((int)(((byte)(85)))));
            this.textSalesCategory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textSalesCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSalesCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.textSalesCategory.Location = new System.Drawing.Point(110, 67);
            this.textSalesCategory.Name = "textSalesCategory";
            this.textSalesCategory.Size = new System.Drawing.Size(215, 19);
            this.textSalesCategory.TabIndex = 0;
            this.textSalesCategory.Enter += new System.EventHandler(this.textSalesCategory_Enter);
            // 
            // labelSalesCategory
            // 
            this.labelSalesCategory.AutoSize = true;
            this.labelSalesCategory.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSalesCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.labelSalesCategory.Location = new System.Drawing.Point(106, 42);
            this.labelSalesCategory.Name = "labelSalesCategory";
            this.labelSalesCategory.Size = new System.Drawing.Size(86, 22);
            this.labelSalesCategory.TabIndex = 13;
            this.labelSalesCategory.Text = "Category :";
            // 
            // buttonSalesAdd
            // 
            this.buttonSalesAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.buttonSalesAdd.FlatAppearance.BorderSize = 0;
            this.buttonSalesAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSalesAdd.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalesAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.buttonSalesAdd.Image = global::DP2.Properties.Resources.icons8_plus_math_20;
            this.buttonSalesAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSalesAdd.Location = new System.Drawing.Point(814, 39);
            this.buttonSalesAdd.Name = "buttonSalesAdd";
            this.buttonSalesAdd.Size = new System.Drawing.Size(121, 47);
            this.buttonSalesAdd.TabIndex = 4;
            this.buttonSalesAdd.Text = "ADD ITEM";
            this.buttonSalesAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSalesAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonSalesAdd.UseVisualStyleBackColor = false;
            this.buttonSalesAdd.Click += new System.EventHandler(this.buttonSalesAdd_Click);
            // 
            // salesNum
            // 
            this.salesNum.DataPropertyName = "number";
            this.salesNum.HeaderText = "number";
            this.salesNum.Name = "salesNum";
            // 
            // salesCategory
            // 
            this.salesCategory.DataPropertyName = "category";
            this.salesCategory.HeaderText = "category";
            this.salesCategory.Name = "salesCategory";
            // 
            // salesItem
            // 
            this.salesItem.DataPropertyName = "item";
            this.salesItem.HeaderText = "item";
            this.salesItem.Name = "salesItem";
            // 
            // salesQty
            // 
            this.salesQty.DataPropertyName = "qty";
            this.salesQty.HeaderText = "qty";
            this.salesQty.Name = "salesQty";
            // 
            // salesPrice
            // 
            this.salesPrice.DataPropertyName = "pricePerUnit";
            this.salesPrice.HeaderText = "pricePerUnit";
            this.salesPrice.Name = "salesPrice";
            // 
            // salesSubtotal
            // 
            this.salesSubtotal.DataPropertyName = "subtotal";
            this.salesSubtotal.HeaderText = "subtotal";
            this.salesSubtotal.Name = "salesSubtotal";
            // 
            // salesTransactionBindingSource
            // 
            this.salesTransactionBindingSource.DataSource = typeof(DP2.Classes.salesTransaction);
            // 
            // formSales
            // 
            this.AcceptButton = this.buttonSalesAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1040, 729);
            this.Controls.Add(this.labelSalesCategory);
            this.Controls.Add(this.textSalesCategory);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridSales);
            this.Controls.Add(this.buttonSalesAdd);
            this.Controls.Add(this.labelSalesQty);
            this.Controls.Add(this.textSalesQty);
            this.Controls.Add(this.labelSalesItem);
            this.Controls.Add(this.textSalesItem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formSales";
            this.Text = "salesTransaction";
            this.Load += new System.EventHandler(this.formSales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSales)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salesTransactionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSalesItem;
        private System.Windows.Forms.TextBox textSalesItem;
        private System.Windows.Forms.Label labelSalesQty;
        private System.Windows.Forms.TextBox textSalesQty;
        private System.Windows.Forms.Button buttonSalesAdd;
        private System.Windows.Forms.DataGridView dataGridSales;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonSalesCheckout;
        private System.Windows.Forms.Label labelSalesTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textSalesCategory;
        private System.Windows.Forms.Label labelSalesCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesSubtotal;
        private System.Windows.Forms.DataGridViewButtonColumn salesDeleteRow;
        private System.Windows.Forms.BindingSource salesTransactionBindingSource;
    }
}