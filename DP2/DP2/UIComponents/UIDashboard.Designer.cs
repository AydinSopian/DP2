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
            this.buttonDashboardGenerate = new System.Windows.Forms.Button();
            this.buttonDashboardTables = new System.Windows.Forms.Button();
            this.buttonDashboardCharts = new System.Windows.Forms.Button();
            this.content = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelDashboardTitle
            // 
            this.labelDashboardTitle.AutoSize = true;
            this.labelDashboardTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDashboardTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.labelDashboardTitle.Location = new System.Drawing.Point(42, 41);
            this.labelDashboardTitle.Name = "labelDashboardTitle";
            this.labelDashboardTitle.Size = new System.Drawing.Size(187, 31);
            this.labelDashboardTitle.TabIndex = 14;
            this.labelDashboardTitle.Text = "DASHBOARD";
            // 
            // buttonDashboardGenerate
            // 
            this.buttonDashboardGenerate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.buttonDashboardGenerate.FlatAppearance.BorderSize = 0;
            this.buttonDashboardGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDashboardGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDashboardGenerate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.buttonDashboardGenerate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDashboardGenerate.Location = new System.Drawing.Point(858, 38);
            this.buttonDashboardGenerate.Name = "buttonDashboardGenerate";
            this.buttonDashboardGenerate.Size = new System.Drawing.Size(144, 47);
            this.buttonDashboardGenerate.TabIndex = 18;
            this.buttonDashboardGenerate.Text = "GENERATE CSV";
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
            this.buttonDashboardTables.Text = "TABLE";
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
            this.buttonDashboardCharts.Size = new System.Drawing.Size(125, 47);
            this.buttonDashboardCharts.TabIndex = 21;
            this.buttonDashboardCharts.Text = "LINE CHARTS";
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
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(243, 104);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 47);
            this.button1.TabIndex = 23;
            this.button1.Text = "MOBI";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UIDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1040, 729);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.content);
            this.Controls.Add(this.buttonDashboardCharts);
            this.Controls.Add(this.buttonDashboardTables);
            this.Controls.Add(this.buttonDashboardGenerate);
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
        private System.Windows.Forms.Button buttonDashboardGenerate;
        private System.Windows.Forms.Button buttonDashboardTables;
        private System.Windows.Forms.Button buttonDashboardCharts;
        private System.Windows.Forms.Panel content;
        private System.Windows.Forms.Button button1;
    }
}