namespace BankApp
{
    partial class Withdraw
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
            this.cmbAccounts = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbAccounts
            // 
            this.cmbAccounts.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 22F);
            this.cmbAccounts.FormattingEnabled = true;
            this.cmbAccounts.Location = new System.Drawing.Point(487, 46);
            this.cmbAccounts.Name = "cmbAccounts";
            this.cmbAccounts.Size = new System.Drawing.Size(507, 50);
            this.cmbAccounts.TabIndex = 0;
            this.cmbAccounts.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(607, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter Withdraw Amount";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.Location = new System.Drawing.Point(639, 206);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(217, 40);
            this.txtAmount.TabIndex = 2;
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWithdraw.Location = new System.Drawing.Point(655, 300);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(188, 65);
            this.btnWithdraw.TabIndex = 3;
            this.btnWithdraw.Text = "Submit";
            this.btnWithdraw.UseVisualStyleBackColor = true;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // Withdraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1614, 960);
            this.Controls.Add(this.btnWithdraw);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbAccounts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Withdraw";
            this.Text = "Withdraw";
            this.Load += new System.EventHandler(this.Withdraw_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbAccounts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Button btnWithdraw;
    }
}