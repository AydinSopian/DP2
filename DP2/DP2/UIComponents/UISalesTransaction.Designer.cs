namespace DP2
{
    partial class UISalesTransaction
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelSalesItem = new System.Windows.Forms.Label();
            this.labelSalesQty = new System.Windows.Forms.Label();
            this.dataGridSales = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelSalesTotal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textSalesItem = new System.Windows.Forms.ComboBox();
            this.textSalesQty = new System.Windows.Forms.TextBox();
            this.buttonSalesAdd = new System.Windows.Forms.Button();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.buttonSalesCheckout = new System.Windows.Forms.Button();
            this.salesDeleteRow = new System.Windows.Forms.DataGridViewImageColumn();
            this.salesNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.labelSalesItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSalesItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.labelSalesItem.Location = new System.Drawing.Point(189, 42);
            this.labelSalesItem.Name = "labelSalesItem";
            this.labelSalesItem.Size = new System.Drawing.Size(49, 20);
            this.labelSalesItem.TabIndex = 6;
            this.labelSalesItem.Text = "Item :";
            // 
            // labelSalesQty
            // 
            this.labelSalesQty.AutoSize = true;
            this.labelSalesQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSalesQty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.labelSalesQty.Location = new System.Drawing.Point(511, 42);
            this.labelSalesQty.Name = "labelSalesQty";
            this.labelSalesQty.Size = new System.Drawing.Size(41, 20);
            this.labelSalesQty.TabIndex = 8;
            this.labelSalesQty.Text = "Qty :";
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(20, 10, 0, 10);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridSales.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.salesNum,
            this.salesItem,
            this.salesQty,
            this.salesPrice,
            this.salesSubtotal,
            this.salesDeleteRow});
            this.dataGridSales.DataSource = this.salesTransactionBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridSales.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridSales.EnableHeadersVisualStyles = false;
            this.dataGridSales.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridSales.Location = new System.Drawing.Point(107, 135);
            this.dataGridSales.Name = "dataGridSales";
            this.dataGridSales.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridSales.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridSales.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(20, 10, 0, 10);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridSales.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridSales.RowTemplate.Height = 30;
            this.dataGridSales.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridSales.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridSales.Size = new System.Drawing.Size(828, 446);
            this.dataGridSales.TabIndex = 10;
            this.dataGridSales.TabStop = false;
            this.dataGridSales.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridSales_CellContentClick);
            this.dataGridSales.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridSales_CellFormatting);
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
            this.labelSalesTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSalesTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.labelSalesTotal.Location = new System.Drawing.Point(630, 29);
            this.labelSalesTotal.Name = "labelSalesTotal";
            this.labelSalesTotal.Size = new System.Drawing.Size(45, 25);
            this.labelSalesTotal.TabIndex = 2;
            this.labelSalesTotal.Text = "RM";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.label1.Location = new System.Drawing.Point(537, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "TOTAL :";
            // 
            // textSalesItem
            // 
            this.textSalesItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(75)))), ((int)(((byte)(85)))));
            this.textSalesItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.textSalesItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSalesItem.ForeColor = System.Drawing.Color.White;
            this.textSalesItem.FormattingEnabled = true;
            this.textSalesItem.Location = new System.Drawing.Point(193, 73);
            this.textSalesItem.Name = "textSalesItem";
            this.textSalesItem.Size = new System.Drawing.Size(223, 28);
            this.textSalesItem.TabIndex = 1;
            this.textSalesItem.SelectedIndexChanged += new System.EventHandler(this.textSalesItem_SelectedIndexChanged);
            // 
            // textSalesQty
            // 
            this.textSalesQty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(75)))), ((int)(((byte)(85)))));
            this.textSalesQty.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textSalesQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSalesQty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.textSalesQty.Location = new System.Drawing.Point(515, 73);
            this.textSalesQty.Name = "textSalesQty";
            this.textSalesQty.Size = new System.Drawing.Size(101, 19);
            this.textSalesQty.TabIndex = 3;
            // 
            // buttonSalesAdd
            // 
            this.buttonSalesAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.buttonSalesAdd.FlatAppearance.BorderSize = 0;
            this.buttonSalesAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSalesAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalesAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.buttonSalesAdd.Image = global::DP2.Properties.Resources.icons8_plus_math_20;
            this.buttonSalesAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSalesAdd.Location = new System.Drawing.Point(692, 54);
            this.buttonSalesAdd.Name = "buttonSalesAdd";
            this.buttonSalesAdd.Size = new System.Drawing.Size(121, 47);
            this.buttonSalesAdd.TabIndex = 4;
            this.buttonSalesAdd.Text = "ADD ITEM";
            this.buttonSalesAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSalesAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonSalesAdd.UseVisualStyleBackColor = false;
            this.buttonSalesAdd.Click += new System.EventHandler(this.buttonSalesAdd_Click);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.FillWeight = 55.50259F;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::DP2.Properties.Resources.icons8_trash_25;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageColumn1.Width = 828;
            // 
            // buttonSalesCheckout
            // 
            this.buttonSalesCheckout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.buttonSalesCheckout.FlatAppearance.BorderSize = 0;
            this.buttonSalesCheckout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSalesCheckout.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            // salesDeleteRow
            // 
            this.salesDeleteRow.FillWeight = 55.50259F;
            this.salesDeleteRow.HeaderText = "";
            this.salesDeleteRow.Image = global::DP2.Properties.Resources.icons8_trash_25;
            this.salesDeleteRow.Name = "salesDeleteRow";
            this.salesDeleteRow.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.salesDeleteRow.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // salesNum
            // 
            this.salesNum.DataPropertyName = "number";
            this.salesNum.HeaderText = "NO.";
            this.salesNum.Name = "salesNum";
            // 
            // salesItem
            // 
            this.salesItem.DataPropertyName = "item";
            this.salesItem.HeaderText = "ITEM";
            this.salesItem.Name = "salesItem";
            // 
            // salesQty
            // 
            this.salesQty.DataPropertyName = "qty";
            this.salesQty.HeaderText = "QTY";
            this.salesQty.Name = "salesQty";
            // 
            // salesPrice
            // 
            this.salesPrice.DataPropertyName = "pricePerUnit";
            this.salesPrice.HeaderText = "PRICE PER UNIT";
            this.salesPrice.Name = "salesPrice";
            // 
            // salesSubtotal
            // 
            this.salesSubtotal.DataPropertyName = "subtotal";
            this.salesSubtotal.HeaderText = "SUBTOTAL";
            this.salesSubtotal.Name = "salesSubtotal";
            // 
            // salesTransactionBindingSource
            // 
            this.salesTransactionBindingSource.DataSource = typeof(DP2.Classes.salesTransaction);
            // 
            // UISalesTransaction
            // 
            this.AcceptButton = this.buttonSalesAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1040, 729);
            this.Controls.Add(this.textSalesQty);
            this.Controls.Add(this.textSalesItem);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridSales);
            this.Controls.Add(this.buttonSalesAdd);
            this.Controls.Add(this.labelSalesQty);
            this.Controls.Add(this.labelSalesItem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UISalesTransaction";
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
        private System.Windows.Forms.Label labelSalesQty;
        private System.Windows.Forms.Button buttonSalesAdd;
        private System.Windows.Forms.DataGridView dataGridSales;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonSalesCheckout;
        private System.Windows.Forms.Label labelSalesTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource salesTransactionBindingSource;
        private System.Windows.Forms.ComboBox textSalesItem;
        private System.Windows.Forms.TextBox textSalesQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesSubtotal;
        private System.Windows.Forms.DataGridViewImageColumn salesDeleteRow;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
    }
}