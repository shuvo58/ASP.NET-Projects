namespace BankingOperationApp
{
    partial class BankOperationUI
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
            this.createBankAccButton = new System.Windows.Forms.Button();
            this.createLoanAccButton = new System.Windows.Forms.Button();
            this.transcInAccButton = new System.Windows.Forms.Button();
            this.refundInstallmentButton = new System.Windows.Forms.Button();
            this.reportButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // createBankAccButton
            // 
            this.createBankAccButton.Location = new System.Drawing.Point(63, 34);
            this.createBankAccButton.Name = "createBankAccButton";
            this.createBankAccButton.Size = new System.Drawing.Size(180, 50);
            this.createBankAccButton.TabIndex = 0;
            this.createBankAccButton.Text = "Create Bank Account";
            this.createBankAccButton.UseVisualStyleBackColor = true;
            this.createBankAccButton.Click += new System.EventHandler(this.createBankAccButton_Click);
            // 
            // createLoanAccButton
            // 
            this.createLoanAccButton.Location = new System.Drawing.Point(63, 90);
            this.createLoanAccButton.Name = "createLoanAccButton";
            this.createLoanAccButton.Size = new System.Drawing.Size(180, 50);
            this.createLoanAccButton.TabIndex = 1;
            this.createLoanAccButton.Text = "Create Loan Account";
            this.createLoanAccButton.UseVisualStyleBackColor = true;
            this.createLoanAccButton.Click += new System.EventHandler(this.createLoanAccButton_Click);
            // 
            // transcInAccButton
            // 
            this.transcInAccButton.Location = new System.Drawing.Point(63, 146);
            this.transcInAccButton.Name = "transcInAccButton";
            this.transcInAccButton.Size = new System.Drawing.Size(180, 50);
            this.transcInAccButton.TabIndex = 2;
            this.transcInAccButton.Text = "Transaction in Account";
            this.transcInAccButton.UseVisualStyleBackColor = true;
            this.transcInAccButton.Click += new System.EventHandler(this.transcInAccButton_Click);
            // 
            // refundInstallmentButton
            // 
            this.refundInstallmentButton.Location = new System.Drawing.Point(63, 202);
            this.refundInstallmentButton.Name = "refundInstallmentButton";
            this.refundInstallmentButton.Size = new System.Drawing.Size(180, 50);
            this.refundInstallmentButton.TabIndex = 3;
            this.refundInstallmentButton.Text = "Refund Installment of Loan";
            this.refundInstallmentButton.UseVisualStyleBackColor = true;
            this.refundInstallmentButton.Click += new System.EventHandler(this.refundInstallmentButton_Click);
            // 
            // reportButton
            // 
            this.reportButton.Location = new System.Drawing.Point(63, 258);
            this.reportButton.Name = "reportButton";
            this.reportButton.Size = new System.Drawing.Size(180, 50);
            this.reportButton.TabIndex = 4;
            this.reportButton.Text = "Report";
            this.reportButton.UseVisualStyleBackColor = true;
            this.reportButton.Click += new System.EventHandler(this.reportButton_Click);
            // 
            // BankOperationUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 350);
            this.Controls.Add(this.reportButton);
            this.Controls.Add(this.refundInstallmentButton);
            this.Controls.Add(this.transcInAccButton);
            this.Controls.Add(this.createLoanAccButton);
            this.Controls.Add(this.createBankAccButton);
            this.Name = "BankOperationUI";
            this.Text = "Main Window";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button createBankAccButton;
        private System.Windows.Forms.Button createLoanAccButton;
        private System.Windows.Forms.Button transcInAccButton;
        private System.Windows.Forms.Button refundInstallmentButton;
        private System.Windows.Forms.Button reportButton;
    }
}

