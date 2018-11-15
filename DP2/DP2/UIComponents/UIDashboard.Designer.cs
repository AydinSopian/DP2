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
            this.labelDashboardTitle = new System.Windows.Forms.Label();
            this.labelDashboardReport = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttonDashboardGenerate = new System.Windows.Forms.Button();
            this.buttonDashboardTables = new System.Windows.Forms.Button();
            this.buttonDashboardCharts = new System.Windows.Forms.Button();
            this.content = new System.Windows.Forms.Panel();
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
            this.buttonDashboardGenerate.Click += new System.EventHandler(this.buttonDashboardGenerate_Click);
            // 
            // buttonDashboardTables
            // 
            this.buttonDashboardTables.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.buttonDashboardTables.FlatAppearance.BorderSize = 0;
            this.buttonDashboardTables.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDashboardTables.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDashboardTables.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.buttonDashboardTables.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDashboardTables.Location = new System.Drawing.Point(12, 104);
            this.buttonDashboardTables.Name = "buttonDashboardTables";
            this.buttonDashboardTables.Size = new System.Drawing.Size(106, 47);
            this.buttonDashboardTables.TabIndex = 20;
            this.buttonDashboardTables.Text = "TABLES";
            this.buttonDashboardTables.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonDashboardTables.UseVisualStyleBackColor = false;
            this.buttonDashboardTables.Click += new System.EventHandler(this.buttonDashboardTables_Click);
            // 
            // buttonDashboardCharts
            // 
            this.buttonDashboardCharts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.buttonDashboardCharts.FlatAppearance.BorderSize = 0;
            this.buttonDashboardCharts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDashboardCharts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDashboardCharts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.buttonDashboardCharts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDashboardCharts.Location = new System.Drawing.Point(118, 104);
            this.buttonDashboardCharts.Name = "buttonDashboardCharts";
            this.buttonDashboardCharts.Size = new System.Drawing.Size(106, 47);
            this.buttonDashboardCharts.TabIndex = 21;
            this.buttonDashboardCharts.Text = "CHARTS";
            this.buttonDashboardCharts.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonDashboardCharts.UseVisualStyleBackColor = false;
            this.buttonDashboardCharts.Click += new System.EventHandler(this.buttonDashboardCharts_Click);
            // 
            // content
            // 
            this.content.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.content.Location = new System.Drawing.Point(12, 151);
            this.content.Name = "content";
            this.content.Size = new System.Drawing.Size(1016, 566);
            this.content.TabIndex = 22;
            this.content.Paint += new System.Windows.Forms.PaintEventHandler(this.content_Paint);
            // 
            // UIDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1040, 729);
            this.Controls.Add(this.content);
            this.Controls.Add(this.buttonDashboardCharts);
            this.Controls.Add(this.buttonDashboardTables);
            this.Controls.Add(this.buttonDashboardGenerate);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.labelDashboardReport);
            this.Controls.Add(this.labelDashboardTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UIDashboard";
            this.Text = "UIDashboard";
            this.Load += new System.EventHandler(this.UIDashboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDashboardTitle;
        private System.Windows.Forms.Label labelDashboardReport;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttonDashboardGenerate;
        private System.Windows.Forms.Button buttonDashboardTables;
        private System.Windows.Forms.Button buttonDashboardCharts;
        private System.Windows.Forms.Panel content;
    }
}