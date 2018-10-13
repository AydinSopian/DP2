namespace DP2.UIComponents
{
    partial class UIPayment
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
            this.labelPaymentAmount = new System.Windows.Forms.Label();
            this.textPaymentAmount = new System.Windows.Forms.TextBox();
            this.buttonPaymentCancel = new System.Windows.Forms.Button();
            this.buttonPaymentConfirm = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelPaymentTotal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelPaymentAmount
            // 
            this.labelPaymentAmount.AutoSize = true;
            this.labelPaymentAmount.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPaymentAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.labelPaymentAmount.Location = new System.Drawing.Point(82, 125);
            this.labelPaymentAmount.Name = "labelPaymentAmount";
            this.labelPaymentAmount.Size = new System.Drawing.Size(116, 22);
            this.labelPaymentAmount.TabIndex = 10;
            this.labelPaymentAmount.Text = "Amount Paid :";
            // 
            // textPaymentAmount
            // 
            this.textPaymentAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(75)))), ((int)(((byte)(85)))));
            this.textPaymentAmount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textPaymentAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPaymentAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.textPaymentAmount.Location = new System.Drawing.Point(86, 150);
            this.textPaymentAmount.Name = "textPaymentAmount";
            this.textPaymentAmount.Size = new System.Drawing.Size(188, 19);
            this.textPaymentAmount.TabIndex = 1;
            // 
            // buttonPaymentCancel
            // 
            this.buttonPaymentCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.buttonPaymentCancel.FlatAppearance.BorderSize = 0;
            this.buttonPaymentCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPaymentCancel.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPaymentCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.buttonPaymentCancel.Location = new System.Drawing.Point(187, 214);
            this.buttonPaymentCancel.Name = "buttonPaymentCancel";
            this.buttonPaymentCancel.Size = new System.Drawing.Size(87, 52);
            this.buttonPaymentCancel.TabIndex = 3;
            this.buttonPaymentCancel.TabStop = false;
            this.buttonPaymentCancel.Text = "Cancel";
            this.buttonPaymentCancel.UseVisualStyleBackColor = false;
            this.buttonPaymentCancel.Click += new System.EventHandler(this.buttonPaymentCancel_Click);
            // 
            // buttonPaymentConfirm
            // 
            this.buttonPaymentConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.buttonPaymentConfirm.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.buttonPaymentConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPaymentConfirm.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPaymentConfirm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.buttonPaymentConfirm.Location = new System.Drawing.Point(84, 214);
            this.buttonPaymentConfirm.Name = "buttonPaymentConfirm";
            this.buttonPaymentConfirm.Size = new System.Drawing.Size(87, 52);
            this.buttonPaymentConfirm.TabIndex = 2;
            this.buttonPaymentConfirm.Text = "Confirm";
            this.buttonPaymentConfirm.UseVisualStyleBackColor = false;
            this.buttonPaymentConfirm.Click += new System.EventHandler(this.buttonPaymentConfirm_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panel1.Controls.Add(this.buttonClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(364, 30);
            this.panel1.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.labelPaymentTotal);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(364, 61);
            this.panel2.TabIndex = 16;
            // 
            // labelPaymentTotal
            // 
            this.labelPaymentTotal.AutoSize = true;
            this.labelPaymentTotal.Font = new System.Drawing.Font("Open Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPaymentTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.labelPaymentTotal.Location = new System.Drawing.Point(104, 17);
            this.labelPaymentTotal.Name = "labelPaymentTotal";
            this.labelPaymentTotal.Size = new System.Drawing.Size(44, 28);
            this.labelPaymentTotal.TabIndex = 16;
            this.labelPaymentTotal.Text = "RM";
            this.labelPaymentTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.label1.Location = new System.Drawing.Point(11, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 28);
            this.label1.TabIndex = 15;
            this.label1.Text = "TOTAL :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.buttonClose.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Image = global::DP2.Properties.Resources.icons8_multiply_28;
            this.buttonClose.Location = new System.Drawing.Point(322, 1);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(42, 29);
            this.buttonClose.TabIndex = 3;
            this.buttonClose.TabStop = false;
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // UIPayment
            // 
            this.AcceptButton = this.buttonPaymentConfirm;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(364, 305);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonPaymentCancel);
            this.Controls.Add(this.buttonPaymentConfirm);
            this.Controls.Add(this.labelPaymentAmount);
            this.Controls.Add(this.textPaymentAmount);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UIPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UIPayment";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPaymentAmount;
        private System.Windows.Forms.TextBox textPaymentAmount;
        private System.Windows.Forms.Button buttonPaymentCancel;
        private System.Windows.Forms.Button buttonPaymentConfirm;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelPaymentTotal;
        private System.Windows.Forms.Label label1;
    }
}