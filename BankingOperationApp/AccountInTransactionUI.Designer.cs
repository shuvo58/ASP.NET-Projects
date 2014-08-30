namespace BankingOperationApp
{
    partial class AccountInTransactionUI
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
            this.showButton = new System.Windows.Forms.Button();
            this.accNoTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.balanceTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nidTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.withdrawRadioButton = new System.Windows.Forms.RadioButton();
            this.depositRadioButton = new System.Windows.Forms.RadioButton();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.showButton);
            this.groupBox1.Controls.Add(this.accNoTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.balanceTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.nidTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.nameTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(363, 204);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Account Information";
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(252, 38);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(75, 23);
            this.showButton.TabIndex = 1;
            this.showButton.Text = "Show";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // accNoTextBox
            // 
            this.accNoTextBox.Location = new System.Drawing.Point(103, 40);
            this.accNoTextBox.Name = "accNoTextBox";
            this.accNoTextBox.Size = new System.Drawing.Size(143, 20);
            this.accNoTextBox.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Account No:";
            // 
            // balanceTextBox
            // 
            this.balanceTextBox.Location = new System.Drawing.Point(103, 75);
            this.balanceTextBox.Name = "balanceTextBox";
            this.balanceTextBox.ReadOnly = true;
            this.balanceTextBox.Size = new System.Drawing.Size(100, 20);
            this.balanceTextBox.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Balance:";
            // 
            // nidTextBox
            // 
            this.nidTextBox.Location = new System.Drawing.Point(103, 151);
            this.nidTextBox.Name = "nidTextBox";
            this.nidTextBox.ReadOnly = true;
            this.nidTextBox.Size = new System.Drawing.Size(200, 20);
            this.nidTextBox.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "National Id:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(103, 112);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.ReadOnly = true;
            this.nameTextBox.Size = new System.Drawing.Size(200, 20);
            this.nameTextBox.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Customer Name:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.withdrawRadioButton);
            this.groupBox2.Controls.Add(this.depositRadioButton);
            this.groupBox2.Controls.Add(this.amountTextBox);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.saveButton);
            this.groupBox2.Location = new System.Drawing.Point(12, 222);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(363, 165);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Transaction";
            // 
            // withdrawRadioButton
            // 
            this.withdrawRadioButton.AutoSize = true;
            this.withdrawRadioButton.Location = new System.Drawing.Point(152, 45);
            this.withdrawRadioButton.Name = "withdrawRadioButton";
            this.withdrawRadioButton.Size = new System.Drawing.Size(70, 17);
            this.withdrawRadioButton.TabIndex = 1;
            this.withdrawRadioButton.TabStop = true;
            this.withdrawRadioButton.Text = "Withdraw";
            this.withdrawRadioButton.UseVisualStyleBackColor = true;
            // 
            // depositRadioButton
            // 
            this.depositRadioButton.AutoSize = true;
            this.depositRadioButton.Checked = true;
            this.depositRadioButton.Location = new System.Drawing.Point(89, 45);
            this.depositRadioButton.Name = "depositRadioButton";
            this.depositRadioButton.Size = new System.Drawing.Size(61, 17);
            this.depositRadioButton.TabIndex = 0;
            this.depositRadioButton.TabStop = true;
            this.depositRadioButton.Text = "Deposit";
            this.depositRadioButton.UseVisualStyleBackColor = true;
            // 
            // amountTextBox
            // 
            this.amountTextBox.Location = new System.Drawing.Point(146, 70);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(100, 20);
            this.amountTextBox.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(86, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Ammount:";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(171, 106);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 3;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // AccountInTransactionUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 397);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "AccountInTransactionUI";
            this.Text = "AccountIn Transaction";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox accNoTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox balanceTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nidTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.RadioButton withdrawRadioButton;
        private System.Windows.Forms.RadioButton depositRadioButton;
    }
}