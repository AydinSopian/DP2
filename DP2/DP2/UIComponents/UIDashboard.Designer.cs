namespace DP2.UIComponents
{
    partial class UIDashboard
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelDashboardTitle = new System.Windows.Forms.Label();
            this.dataGridDashboard = new System.Windows.Forms.DataGridView();
            this.inventoryNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inventoryItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inventoryCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inventoryPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inventoryQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelDashboardReport = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttonDashboardGenerate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDashboard)).BeginInit();
            this.SuspendLayout();
            // 
            // labelDashboardTitle
            // 
            this.labelDashboardTitle.AutoSize = true;
            this.labelDashboardTitle.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDashboardTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.labelDashboardTitle.Location = new System.Drawing.Point(42, 41);
            this.labelDashboardTitle.Name = "labelDashboardTitle";
            this.labelDashboardTitle.Size = new System.Drawing.Size(179, 33);
            this.labelDashboardTitle.TabIndex = 14;
            this.labelDashboardTitle.Text = "DASHBOARD";
            // 
            // dataGridDashboard
            // 
            this.dataGridDashboard.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridDashboard.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridDashboard.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridDashboard.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridDashboard.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridDashboard.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(20, 10, 0, 10);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridDashboard.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridDashboard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDashboard.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.inventoryNum,
            this.inventoryItem,
            this.inventoryCost,
            this.inventoryPrice,
            this.inventoryQty});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridDashboard.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridDashboard.EnableHeadersVisualStyles = false;
            this.dataGridDashboard.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridDashboard.Location = new System.Drawing.Point(12, 109);
            this.dataGridDashboard.Name = "dataGridDashboard";
            this.dataGridDashboard.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridDashboard.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridDashboard.RowHeadersVisible = false;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(20, 10, 0, 10);
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridDashboard.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridDashboard.RowTemplate.Height = 30;
            this.dataGridDashboard.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridDashboard.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridDashboard.Size = new System.Drawing.Size(1016, 608);
            this.dataGridDashboard.TabIndex = 15;
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
            // labelDashboardReport
            // 
            this.labelDashboardReport.AutoSize = true;
            this.labelDashboardReport.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDashboardReport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.labelDashboardReport.Location = new System.Drawing.Point(633, 52);
            this.labelDashboardReport.Name = "labelDashboardReport";
            this.labelDashboardReport.Size = new System.Drawing.Size(70, 22);
            this.labelDashboardReport.TabIndex = 16;
            this.labelDashboardReport.Text = "Report :";
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(75)))), ((int)(((byte)(85)))));
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.ForeColor = System.Drawing.Color.White;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 22;
            this.listBox1.Items.AddRange(new object[] {
            "Weekly",
            "Montly"});
            this.listBox1.Location = new System.Drawing.Point(709, 52);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 22);
            this.listBox1.TabIndex = 17;
            // 
            // buttonDashboardGenerate
            // 
            this.buttonDashboardGenerate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.buttonDashboardGenerate.FlatAppearance.BorderSize = 0;
            this.buttonDashboardGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDashboardGenerate.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDashboardGenerate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.buttonDashboardGenerate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDashboardGenerate.Location = new System.Drawing.Point(869, 40);
            this.buttonDashboardGenerate.Name = "buttonDashboardGenerate";
            this.buttonDashboardGenerate.Size = new System.Drawing.Size(108, 47);
            this.buttonDashboardGenerate.TabIndex = 18;
            this.buttonDashboardGenerate.Text = "GENERATE";
            this.buttonDashboardGenerate.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonDashboardGenerate.UseVisualStyleBackColor = false;
            // 
            // UIDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1040, 729);
            this.Controls.Add(this.buttonDashboardGenerate);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.labelDashboardReport);
            this.Controls.Add(this.dataGridDashboard);
            this.Controls.Add(this.labelDashboardTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UIDashboard";
            this.Text = "UIDashboard";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDashboard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDashboardTitle;
        private System.Windows.Forms.DataGridView dataGridDashboard;
        private System.Windows.Forms.DataGridViewTextBoxColumn inventoryNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn inventoryItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn inventoryCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn inventoryPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn inventoryQty;
        private System.Windows.Forms.Label labelDashboardReport;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttonDashboardGenerate;
    }
}