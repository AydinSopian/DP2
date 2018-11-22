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
            this.buttonDashboardMCSV = new System.Windows.Forms.Button();
            this.buttonDashboardTables = new System.Windows.Forms.Button();
            this.buttonDashboardCharts = new System.Windows.Forms.Button();
            this.content = new System.Windows.Forms.Panel();
            this.buttonDashboardWCSV = new System.Windows.Forms.Button();
            this.buttonDashboardCharts2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelDashboardTitle
            // 
            this.labelDashboardTitle.AutoSize = true;
            this.labelDashboardTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDashboardTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.labelDashboardTitle.Location = new System.Drawing.Point(56, 50);
            this.labelDashboardTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDashboardTitle.Name = "labelDashboardTitle";
            this.labelDashboardTitle.Size = new System.Drawing.Size(235, 39);
            this.labelDashboardTitle.TabIndex = 14;
            this.labelDashboardTitle.Text = "DASHBOARD";
            // 
            // buttonDashboardMCSV
            // 
            this.buttonDashboardMCSV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.buttonDashboardMCSV.FlatAppearance.BorderSize = 0;
            this.buttonDashboardMCSV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDashboardMCSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDashboardMCSV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.buttonDashboardMCSV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDashboardMCSV.Location = new System.Drawing.Point(1167, 47);
            this.buttonDashboardMCSV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonDashboardMCSV.Name = "buttonDashboardMCSV";
            this.buttonDashboardMCSV.Size = new System.Drawing.Size(169, 58);
            this.buttonDashboardMCSV.TabIndex = 18;
            this.buttonDashboardMCSV.Text = "Monthly CSV";
            this.buttonDashboardMCSV.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonDashboardMCSV.UseVisualStyleBackColor = false;
            this.buttonDashboardMCSV.Click += new System.EventHandler(this.buttonDashboardGenerate_Click);
            // 
            // buttonDashboardTables
            // 
            this.buttonDashboardTables.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.buttonDashboardTables.FlatAppearance.BorderSize = 0;
            this.buttonDashboardTables.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDashboardTables.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDashboardTables.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.buttonDashboardTables.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDashboardTables.Location = new System.Drawing.Point(16, 128);
            this.buttonDashboardTables.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonDashboardTables.Name = "buttonDashboardTables";
            this.buttonDashboardTables.Size = new System.Drawing.Size(141, 58);
            this.buttonDashboardTables.TabIndex = 20;
            this.buttonDashboardTables.Text = "Weekly Report Table";
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
            this.buttonDashboardCharts.Location = new System.Drawing.Point(157, 128);
            this.buttonDashboardCharts.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonDashboardCharts.Name = "buttonDashboardCharts";
            this.buttonDashboardCharts.Size = new System.Drawing.Size(141, 58);
            this.buttonDashboardCharts.TabIndex = 21;
            this.buttonDashboardCharts.Text = "Line Charts";
            this.buttonDashboardCharts.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonDashboardCharts.UseVisualStyleBackColor = false;
            this.buttonDashboardCharts.Click += new System.EventHandler(this.buttonDashboardCharts_Click);
            // 
            // content
            // 
            this.content.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.content.Location = new System.Drawing.Point(16, 186);
            this.content.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.content.Name = "content";
            this.content.Size = new System.Drawing.Size(1355, 697);
            this.content.TabIndex = 22;
            this.content.Paint += new System.Windows.Forms.PaintEventHandler(this.content_Paint);
            // 
            // buttonDashboardWCSV
            // 
            this.buttonDashboardWCSV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.buttonDashboardWCSV.FlatAppearance.BorderSize = 0;
            this.buttonDashboardWCSV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDashboardWCSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDashboardWCSV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.buttonDashboardWCSV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDashboardWCSV.Location = new System.Drawing.Point(963, 47);
            this.buttonDashboardWCSV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonDashboardWCSV.Name = "buttonDashboardWCSV";
            this.buttonDashboardWCSV.Size = new System.Drawing.Size(169, 58);
            this.buttonDashboardWCSV.TabIndex = 23;
            this.buttonDashboardWCSV.Text = "Weekly CSV";
            this.buttonDashboardWCSV.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonDashboardWCSV.UseVisualStyleBackColor = false;
            // 
            // buttonDashboardCharts2
            // 
            this.buttonDashboardCharts2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.buttonDashboardCharts2.FlatAppearance.BorderSize = 0;
            this.buttonDashboardCharts2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDashboardCharts2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDashboardCharts2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.buttonDashboardCharts2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDashboardCharts2.Location = new System.Drawing.Point(299, 128);
            this.buttonDashboardCharts2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonDashboardCharts2.Name = "buttonDashboardCharts2";
            this.buttonDashboardCharts2.Size = new System.Drawing.Size(141, 58);
            this.buttonDashboardCharts2.TabIndex = 24;
            this.buttonDashboardCharts2.Text = "Analysis Charts";
            this.buttonDashboardCharts2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonDashboardCharts2.UseVisualStyleBackColor = false;
            this.buttonDashboardCharts2.Click += new System.EventHandler(this.buttonDashboardCharts2_Click);
            // 
            // UIDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1387, 897);
            this.Controls.Add(this.buttonDashboardCharts2);
            this.Controls.Add(this.buttonDashboardWCSV);
            this.Controls.Add(this.content);
            this.Controls.Add(this.buttonDashboardCharts);
            this.Controls.Add(this.buttonDashboardTables);
            this.Controls.Add(this.buttonDashboardMCSV);
            this.Controls.Add(this.labelDashboardTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UIDashboard";
            this.Text = "UIDashboard";
            this.Load += new System.EventHandler(this.UIDashboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDashboardTitle;
        private System.Windows.Forms.Button buttonDashboardMCSV;
        private System.Windows.Forms.Button buttonDashboardTables;
        private System.Windows.Forms.Button buttonDashboardCharts;
        private System.Windows.Forms.Panel content;
        private System.Windows.Forms.Button buttonDashboardWCSV;
        private System.Windows.Forms.Button buttonDashboardCharts2;
    }
}