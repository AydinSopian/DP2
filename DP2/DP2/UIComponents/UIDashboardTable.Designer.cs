namespace DP2.UIComponents
{
    partial class UIDashboardTable
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelDashboardReport = new System.Windows.Forms.Label();
            this.Weekb = new System.Windows.Forms.Button();
            this.Monthb = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "TABLES";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 82);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(989, 452);
            this.dataGridView1.TabIndex = 2;
            // 
            // labelDashboardReport
            // 
            this.labelDashboardReport.AutoSize = true;
            this.labelDashboardReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDashboardReport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.labelDashboardReport.Location = new System.Drawing.Point(762, 43);
            this.labelDashboardReport.Name = "labelDashboardReport";
            this.labelDashboardReport.Size = new System.Drawing.Size(66, 20);
            this.labelDashboardReport.TabIndex = 25;
            this.labelDashboardReport.Text = "Report :";
            this.labelDashboardReport.Click += new System.EventHandler(this.labelDashboardReport_Click);
            // 
            // Weekb
            // 
            this.Weekb.Location = new System.Drawing.Point(830, 43);
            this.Weekb.Name = "Weekb";
            this.Weekb.Size = new System.Drawing.Size(75, 23);
            this.Weekb.TabIndex = 26;
            this.Weekb.Text = "Weekly";
            this.Weekb.UseVisualStyleBackColor = true;
            this.Weekb.Click += new System.EventHandler(this.Weekb_Click);
            // 
            // Monthb
            // 
            this.Monthb.Location = new System.Drawing.Point(911, 43);
            this.Monthb.Name = "Monthb";
            this.Monthb.Size = new System.Drawing.Size(75, 23);
            this.Monthb.TabIndex = 27;
            this.Monthb.Text = "Monthly";
            this.Monthb.UseVisualStyleBackColor = true;
            this.Monthb.Click += new System.EventHandler(this.Monthb_Click);
            // 
            // UIDashboardTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1016, 566);
            this.Controls.Add(this.Monthb);
            this.Controls.Add(this.Weekb);
            this.Controls.Add(this.labelDashboardReport);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UIDashboardTable";
            this.Text = "UIDashboardTable";
            this.Load += new System.EventHandler(this.UIDashboardTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelDashboardReport;
        private System.Windows.Forms.Button Weekb;
        private System.Windows.Forms.Button Monthb;
    }
}