namespace DP2
{
    partial class confirmation1
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
            this.buttonConfirmationContinue = new System.Windows.Forms.Button();
            this.buttonConfirmationCancel = new System.Windows.Forms.Button();
            this.labelConfirmationAreYouSure = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonClose = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonConfirmationContinue
            // 
            this.buttonConfirmationContinue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.buttonConfirmationContinue.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.buttonConfirmationContinue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConfirmationContinue.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfirmationContinue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.buttonConfirmationContinue.Location = new System.Drawing.Point(37, 107);
            this.buttonConfirmationContinue.Name = "buttonConfirmationContinue";
            this.buttonConfirmationContinue.Size = new System.Drawing.Size(87, 52);
            this.buttonConfirmationContinue.TabIndex = 0;
            this.buttonConfirmationContinue.Text = "Continue";
            this.buttonConfirmationContinue.UseVisualStyleBackColor = false;
            this.buttonConfirmationContinue.Click += new System.EventHandler(this.buttonConfirmationContinue_Click);
            // 
            // buttonConfirmationCancel
            // 
            this.buttonConfirmationCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.buttonConfirmationCancel.FlatAppearance.BorderSize = 0;
            this.buttonConfirmationCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConfirmationCancel.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfirmationCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.buttonConfirmationCancel.Location = new System.Drawing.Point(151, 107);
            this.buttonConfirmationCancel.Name = "buttonConfirmationCancel";
            this.buttonConfirmationCancel.Size = new System.Drawing.Size(87, 52);
            this.buttonConfirmationCancel.TabIndex = 1;
            this.buttonConfirmationCancel.Text = "Cancel";
            this.buttonConfirmationCancel.UseVisualStyleBackColor = false;
            this.buttonConfirmationCancel.Click += new System.EventHandler(this.buttonConfirmationCancel_Click);
            // 
            // labelConfirmationAreYouSure
            // 
            this.labelConfirmationAreYouSure.AutoSize = true;
            this.labelConfirmationAreYouSure.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConfirmationAreYouSure.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.labelConfirmationAreYouSure.Location = new System.Drawing.Point(33, 58);
            this.labelConfirmationAreYouSure.Name = "labelConfirmationAreYouSure";
            this.labelConfirmationAreYouSure.Size = new System.Drawing.Size(205, 22);
            this.labelConfirmationAreYouSure.TabIndex = 6;
            this.labelConfirmationAreYouSure.Text = "Do you want to Continue?";
            this.labelConfirmationAreYouSure.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panel1.Controls.Add(this.buttonClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(274, 30);
            this.panel1.TabIndex = 7;
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.buttonClose.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Image = global::DP2.Properties.Resources.icons8_multiply_28;
            this.buttonClose.Location = new System.Drawing.Point(232, 1);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(42, 29);
            this.buttonClose.TabIndex = 3;
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // confirmation1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(274, 193);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelConfirmationAreYouSure);
            this.Controls.Add(this.buttonConfirmationCancel);
            this.Controls.Add(this.buttonConfirmationContinue);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "confirmation1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Are you sure?";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonConfirmationContinue;
        private System.Windows.Forms.Button buttonConfirmationCancel;
        private System.Windows.Forms.Label labelConfirmationAreYouSure;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonClose;
    }
}