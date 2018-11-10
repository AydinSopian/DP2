namespace DP2
{
    partial class UIInventory
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.labelInventoryCategory = new System.Windows.Forms.Label();
            this.textInventoryCategory = new System.Windows.Forms.ComboBox();
            this.buttonInventoryAdd = new System.Windows.Forms.Button();
            this.labelNotificationTitle = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.notificationItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notificationQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notificationDateToOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textInventoryItem
            // 
            this.textInventoryItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(75)))), ((int)(((byte)(85)))));
            this.textInventoryItem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textInventoryItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textInventoryItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.textInventoryItem.Location = new System.Drawing.Point(155, 76);
            this.textInventoryItem.Name = "textInventoryItem";
            this.textInventoryItem.Size = new System.Drawing.Size(201, 19);
            this.textInventoryItem.TabIndex = 0;
            // 
            // textInventoryCost
            // 
            this.textInventoryCost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(75)))), ((int)(((byte)(85)))));
            this.textInventoryCost.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textInventoryCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textInventoryCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.textInventoryCost.Location = new System.Drawing.Point(155, 128);
            this.textInventoryCost.Name = "textInventoryCost";
            this.textInventoryCost.Size = new System.Drawing.Size(201, 19);
            this.textInventoryCost.TabIndex = 1;
            // 
            // textInventoryPrice
            // 
            this.textInventoryPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(75)))), ((int)(((byte)(85)))));
            this.textInventoryPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textInventoryPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textInventoryPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.textInventoryPrice.Location = new System.Drawing.Point(155, 180);
            this.textInventoryPrice.Name = "textInventoryPrice";
            this.textInventoryPrice.Size = new System.Drawing.Size(201, 19);
            this.textInventoryPrice.TabIndex = 2;
            // 
            // textInventoryQty
            // 
            this.textInventoryQty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(75)))), ((int)(((byte)(85)))));
            this.textInventoryQty.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textInventoryQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textInventoryQty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.textInventoryQty.Location = new System.Drawing.Point(155, 232);
            this.textInventoryQty.Name = "textInventoryQty";
            this.textInventoryQty.Size = new System.Drawing.Size(201, 19);
            this.textInventoryQty.TabIndex = 3;
            // 
            // labelInventoryItem
            // 
            this.labelInventoryItem.AutoSize = true;
            this.labelInventoryItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInventoryItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.labelInventoryItem.Location = new System.Drawing.Point(29, 75);
            this.labelInventoryItem.Name = "labelInventoryItem";
            this.labelInventoryItem.Size = new System.Drawing.Size(117, 20);
            this.labelInventoryItem.TabIndex = 4;
            this.labelInventoryItem.Text = "Item                  :";
            // 
            // labelInventoryCost
            // 
            this.labelInventoryCost.AutoSize = true;
            this.labelInventoryCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInventoryCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.labelInventoryCost.Location = new System.Drawing.Point(29, 128);
            this.labelInventoryCost.Name = "labelInventoryCost";
            this.labelInventoryCost.Size = new System.Drawing.Size(115, 20);
            this.labelInventoryCost.TabIndex = 5;
            this.labelInventoryCost.Text = "Cost Per Unit  :";
            // 
            // labelInventoryPrice
            // 
            this.labelInventoryPrice.AutoSize = true;
            this.labelInventoryPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInventoryPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.labelInventoryPrice.Location = new System.Drawing.Point(29, 179);
            this.labelInventoryPrice.Name = "labelInventoryPrice";
            this.labelInventoryPrice.Size = new System.Drawing.Size(117, 20);
            this.labelInventoryPrice.TabIndex = 6;
            this.labelInventoryPrice.Text = "Price Per Unit  :";
            // 
            // labelInventoryQty
            // 
            this.labelInventoryQty.AutoSize = true;
            this.labelInventoryQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInventoryQty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.labelInventoryQty.Location = new System.Drawing.Point(29, 231);
            this.labelInventoryQty.Name = "labelInventoryQty";
            this.labelInventoryQty.Size = new System.Drawing.Size(117, 20);
            this.labelInventoryQty.TabIndex = 7;
            this.labelInventoryQty.Text = "Qty                    :";
            // 
            // dataGridInventory
            // 
            this.dataGridInventory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridInventory.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridInventory.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridInventory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridInventory.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridInventory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(20, 10, 0, 10);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridInventory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridInventory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.inventoryNum,
            this.inventoryItem,
            this.inventoryCost,
            this.inventoryPrice,
            this.inventoryQty});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridInventory.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridInventory.EnableHeadersVisualStyles = false;
            this.dataGridInventory.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridInventory.Location = new System.Drawing.Point(12, 276);
            this.dataGridInventory.Name = "dataGridInventory";
            this.dataGridInventory.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridInventory.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridInventory.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(20, 10, 0, 10);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridInventory.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridInventory.RowTemplate.Height = 30;
            this.dataGridInventory.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridInventory.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridInventory.Size = new System.Drawing.Size(1016, 441);
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
            // labelInventoryCategory
            // 
            this.labelInventoryCategory.AutoSize = true;
            this.labelInventoryCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInventoryCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.labelInventoryCategory.Location = new System.Drawing.Point(29, 24);
            this.labelInventoryCategory.Name = "labelInventoryCategory";
            this.labelInventoryCategory.Size = new System.Drawing.Size(117, 20);
            this.labelInventoryCategory.TabIndex = 11;
            this.labelInventoryCategory.Text = "Category          :";
            this.labelInventoryCategory.Click += new System.EventHandler(this.labelInventoryCategory_Click);
            // 
            // textInventoryCategory
            // 
            this.textInventoryCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(75)))), ((int)(((byte)(85)))));
            this.textInventoryCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.textInventoryCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textInventoryCategory.ForeColor = System.Drawing.Color.White;
            this.textInventoryCategory.FormattingEnabled = true;
            this.textInventoryCategory.Location = new System.Drawing.Point(155, 21);
            this.textInventoryCategory.Name = "textInventoryCategory";
            this.textInventoryCategory.Size = new System.Drawing.Size(201, 28);
            this.textInventoryCategory.TabIndex = 12;
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
            this.buttonInventoryAdd.Location = new System.Drawing.Point(396, 204);
            this.buttonInventoryAdd.Name = "buttonInventoryAdd";
            this.buttonInventoryAdd.Size = new System.Drawing.Size(121, 47);
            this.buttonInventoryAdd.TabIndex = 8;
            this.buttonInventoryAdd.Text = "ADD ITEM";
            this.buttonInventoryAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonInventoryAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonInventoryAdd.UseVisualStyleBackColor = false;
            this.buttonInventoryAdd.Click += new System.EventHandler(this.buttonInventoryAdd_Click);
            // 
            // labelNotificationTitle
            // 
            this.labelNotificationTitle.AutoSize = true;
            this.labelNotificationTitle.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNotificationTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.labelNotificationTitle.Location = new System.Drawing.Point(588, 16);
            this.labelNotificationTitle.Name = "labelNotificationTitle";
            this.labelNotificationTitle.Size = new System.Drawing.Size(208, 33);
            this.labelNotificationTitle.TabIndex = 15;
            this.labelNotificationTitle.Text = "NOTIFICATIONS";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(20, 10, 0, 10);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.notificationItem,
            this.notificationQty,
            this.notificationDateToOrder});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridView1.Location = new System.Drawing.Point(594, 66);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(20, 10, 0, 10);
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(434, 185);
            this.dataGridView1.TabIndex = 16;
            // 
            // notificationItem
            // 
            this.notificationItem.HeaderText = "ITEM";
            this.notificationItem.Name = "notificationItem";
            // 
            // notificationQty
            // 
            this.notificationQty.HeaderText = "QTY";
            this.notificationQty.Name = "notificationQty";
            // 
            // notificationDateToOrder
            // 
            this.notificationDateToOrder.HeaderText = "DATE TO ORDER";
            this.notificationDateToOrder.Name = "notificationDateToOrder";
            // 
            // UIInventory
            // 
            this.AcceptButton = this.buttonInventoryAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1040, 729);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelNotificationTitle);
            this.Controls.Add(this.textInventoryCategory);
            this.Controls.Add(this.labelInventoryCategory);
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
            this.Name = "UIInventory";
            this.Text = "Inventory Managent";
            this.Load += new System.EventHandler(this.UIInventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.Label labelInventoryCategory;
        private System.Windows.Forms.ComboBox textInventoryCategory;
        private System.Windows.Forms.Label labelNotificationTitle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn notificationItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn notificationQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn notificationDateToOrder;
    }
}