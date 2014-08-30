namespace BankingOperationApp
{
    partial class ReportUI
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bankAccComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.balanceTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.loanAccComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.remainingAmountTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.showButton = new System.Windows.Forms.Button();
            this.nationalIdTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.totalBalanceTextBox = new System.Windows.Forms.TextBox();
            this.remainingLoanAmountTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bankAccComboBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.balanceTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(31, 124);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(363, 96);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Account Information";
            // 
            // bankAccComboBox
            // 
            this.bankAccComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bankAccComboBox.FormattingEnabled = true;
            this.bankAccComboBox.Location = new System.Drawing.Point(125, 32);
            this.bankAccComboBox.Name = "bankAccComboBox";
            this.bankAccComboBox.Size = new System.Drawing.Size(156, 21);
            this.bankAccComboBox.TabIndex = 0;
            this.bankAccComboBox.SelectedIndexChanged += new System.EventHandler(this.bankAccComboBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Account No:";
            // 
            // balanceTextBox
            // 
            this.balanceTextBox.Location = new System.Drawing.Point(125, 67);
            this.balanceTextBox.Name = "balanceTextBox";
            this.balanceTextBox.ReadOnly = true;
            this.balanceTextBox.Size = new System.Drawing.Size(100, 20);
            this.balanceTextBox.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Balance:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.loanAccComboBox);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.remainingAmountTextBox);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(31, 230);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(363, 96);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Account Information";
            // 
            // loanAccComboBox
            // 
            this.loanAccComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.loanAccComboBox.FormattingEnabled = true;
            this.loanAccComboBox.Location = new System.Drawing.Point(125, 26);
            this.loanAccComboBox.Name = "loanAccComboBox";
            this.loanAccComboBox.Size = new System.Drawing.Size(156, 21);
            this.loanAccComboBox.TabIndex = 0;
            this.loanAccComboBox.SelectedIndexChanged += new System.EventHandler(this.loanAccComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Account No:";
            // 
            // remainingAmountTextBox
            // 
            this.remainingAmountTextBox.Location = new System.Drawing.Point(125, 61);
            this.remainingAmountTextBox.Name = "remainingAmountTextBox";
            this.remainingAmountTextBox.ReadOnly = true;
            this.remainingAmountTextBox.Size = new System.Drawing.Size(100, 20);
            this.remainingAmountTextBox.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Remaining Amount:";
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(345, 34);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(75, 23);
            this.showButton.TabIndex = 1;
            this.showButton.Text = "Show";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // nationalIdTextBox
            // 
            this.nationalIdTextBox.Location = new System.Drawing.Point(196, 36);
            this.nationalIdTextBox.Name = "nationalIdTextBox";
            this.nationalIdTextBox.Size = new System.Drawing.Size(143, 20);
            this.nationalIdTextBox.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(129, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "National Id:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(114, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "Total Balance:";
            // 
            // totalBalanceTextBox
            // 
            this.totalBalanceTextBox.Location = new System.Drawing.Point(196, 66);
            this.totalBalanceTextBox.Name = "totalBalanceTextBox";
            this.totalBalanceTextBox.ReadOnly = true;
            this.totalBalanceTextBox.Size = new System.Drawing.Size(100, 20);
            this.totalBalanceTextBox.TabIndex = 31;
            // 
            // remainingLoanAmountTextBox
            // 
            this.remainingLoanAmountTextBox.Location = new System.Drawing.Point(196, 97);
            this.remainingLoanAmountTextBox.Name = "remainingLoanAmountTextBox";
            this.remainingLoanAmountTextBox.ReadOnly = true;
            this.remainingLoanAmountTextBox.Size = new System.Drawing.Size(100, 20);
            this.remainingLoanAmountTextBox.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 13);
            this.label7.TabIndex = 35;
            this.label7.Text = "Total Remaining Loan Amount:";
            // 
            // ReportUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 373);
            this.Controls.Add(this.remainingLoanAmountTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.nationalIdTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.totalBalanceTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ReportUI";
            this.Text = "Report";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox bankAccComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox balanceTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox loanAccComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox remainingAmountTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.TextBox nationalIdTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox totalBalanceTextBox;
        private System.Windows.Forms.TextBox remainingLoanAmountTextBox;
        private System.Windows.Forms.Label label7;
    }
}