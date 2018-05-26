namespace CustomerBankAccountsUI
{
    partial class baForm
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
            this.baLabel_Header = new System.Windows.Forms.Label();
            this.baListBox_Customers = new System.Windows.Forms.ListBox();
            this.baLabel_FirstName = new System.Windows.Forms.Label();
            this.baLabel_LastName = new System.Windows.Forms.Label();
            this.baLabel_LastNameInfo = new System.Windows.Forms.Label();
            this.baLabel_DOB = new System.Windows.Forms.Label();
            this.baLabel_DOBInfo = new System.Windows.Forms.Label();
            this.baLabel_City = new System.Windows.Forms.Label();
            this.baLabel_CityInfo = new System.Windows.Forms.Label();
            this.baLabel_State = new System.Windows.Forms.Label();
            this.baLabel_StateInfo = new System.Windows.Forms.Label();
            this.baLabel_PhoneNumber = new System.Windows.Forms.Label();
            this.baLabel_PhoneNumberInfo = new System.Windows.Forms.Label();
            this.baButton_NewCustomer = new System.Windows.Forms.Button();
            this.baButton_ViewTransactions = new System.Windows.Forms.Button();
            this.baGroupBox = new System.Windows.Forms.GroupBox();
            this.baLabel_BalanceInfo = new System.Windows.Forms.Label();
            this.baLabel_Balance = new System.Windows.Forms.Label();
            this.baLabel_FirstNameInfo = new System.Windows.Forms.Label();
            this.taGroupBox = new System.Windows.Forms.GroupBox();
            this.taButton_NewTransaction = new System.Windows.Forms.Button();
            this.taLabel_AmountInfo = new System.Windows.Forms.Label();
            this.taLabel_Amount = new System.Windows.Forms.Label();
            this.taLabel_DateInfo = new System.Windows.Forms.Label();
            this.taLabel_Date = new System.Windows.Forms.Label();
            this.taLabel_NameInfo = new System.Windows.Forms.Label();
            this.taLabel_Name = new System.Windows.Forms.Label();
            this.taListBox_Transactions = new System.Windows.Forms.ListBox();
            this.taLabel_Header = new System.Windows.Forms.Label();
            this.baGroupBox.SuspendLayout();
            this.taGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // baLabel_Header
            // 
            this.baLabel_Header.AutoSize = true;
            this.baLabel_Header.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baLabel_Header.Location = new System.Drawing.Point(127, 7);
            this.baLabel_Header.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.baLabel_Header.Name = "baLabel_Header";
            this.baLabel_Header.Size = new System.Drawing.Size(149, 24);
            this.baLabel_Header.TabIndex = 0;
            this.baLabel_Header.Text = "Bank Accounts";
            // 
            // baListBox_Customers
            // 
            this.baListBox_Customers.FormattingEnabled = true;
            this.baListBox_Customers.ItemHeight = 20;
            this.baListBox_Customers.Location = new System.Drawing.Point(12, 46);
            this.baListBox_Customers.Name = "baListBox_Customers";
            this.baListBox_Customers.Size = new System.Drawing.Size(402, 104);
            this.baListBox_Customers.TabIndex = 1;
            this.baListBox_Customers.SelectedIndexChanged += new System.EventHandler(this.baListBox_Customers_SelectedIndexChanged);
            // 
            // baLabel_FirstName
            // 
            this.baLabel_FirstName.AutoSize = true;
            this.baLabel_FirstName.Location = new System.Drawing.Point(55, 165);
            this.baLabel_FirstName.Name = "baLabel_FirstName";
            this.baLabel_FirstName.Size = new System.Drawing.Size(90, 20);
            this.baLabel_FirstName.TabIndex = 2;
            this.baLabel_FirstName.Text = "First Name:";
            // 
            // baLabel_LastName
            // 
            this.baLabel_LastName.AutoSize = true;
            this.baLabel_LastName.Location = new System.Drawing.Point(235, 165);
            this.baLabel_LastName.Name = "baLabel_LastName";
            this.baLabel_LastName.Size = new System.Drawing.Size(90, 20);
            this.baLabel_LastName.TabIndex = 4;
            this.baLabel_LastName.Text = "Last Name:";
            // 
            // baLabel_LastNameInfo
            // 
            this.baLabel_LastNameInfo.AutoSize = true;
            this.baLabel_LastNameInfo.Location = new System.Drawing.Point(331, 165);
            this.baLabel_LastNameInfo.Name = "baLabel_LastNameInfo";
            this.baLabel_LastNameInfo.Size = new System.Drawing.Size(35, 20);
            this.baLabel_LastNameInfo.TabIndex = 5;
            this.baLabel_LastNameInfo.Text = "N/A";
            // 
            // baLabel_DOB
            // 
            this.baLabel_DOB.AutoSize = true;
            this.baLabel_DOB.Location = new System.Drawing.Point(38, 210);
            this.baLabel_DOB.Name = "baLabel_DOB";
            this.baLabel_DOB.Size = new System.Drawing.Size(107, 20);
            this.baLabel_DOB.TabIndex = 6;
            this.baLabel_DOB.Text = "Date of Birth: ";
            // 
            // baLabel_DOBInfo
            // 
            this.baLabel_DOBInfo.AutoSize = true;
            this.baLabel_DOBInfo.Location = new System.Drawing.Point(151, 210);
            this.baLabel_DOBInfo.Name = "baLabel_DOBInfo";
            this.baLabel_DOBInfo.Size = new System.Drawing.Size(35, 20);
            this.baLabel_DOBInfo.TabIndex = 7;
            this.baLabel_DOBInfo.Text = "N/A";
            // 
            // baLabel_City
            // 
            this.baLabel_City.AutoSize = true;
            this.baLabel_City.Location = new System.Drawing.Point(102, 283);
            this.baLabel_City.Name = "baLabel_City";
            this.baLabel_City.Size = new System.Drawing.Size(43, 20);
            this.baLabel_City.TabIndex = 8;
            this.baLabel_City.Text = "City: ";
            // 
            // baLabel_CityInfo
            // 
            this.baLabel_CityInfo.AutoSize = true;
            this.baLabel_CityInfo.Location = new System.Drawing.Point(151, 283);
            this.baLabel_CityInfo.Name = "baLabel_CityInfo";
            this.baLabel_CityInfo.Size = new System.Drawing.Size(35, 20);
            this.baLabel_CityInfo.TabIndex = 9;
            this.baLabel_CityInfo.Text = "N/A";
            // 
            // baLabel_State
            // 
            this.baLabel_State.AutoSize = true;
            this.baLabel_State.Location = new System.Drawing.Point(269, 283);
            this.baLabel_State.Name = "baLabel_State";
            this.baLabel_State.Size = new System.Drawing.Size(56, 20);
            this.baLabel_State.TabIndex = 10;
            this.baLabel_State.Text = "State: ";
            // 
            // baLabel_StateInfo
            // 
            this.baLabel_StateInfo.AutoSize = true;
            this.baLabel_StateInfo.Location = new System.Drawing.Point(331, 283);
            this.baLabel_StateInfo.Name = "baLabel_StateInfo";
            this.baLabel_StateInfo.Size = new System.Drawing.Size(35, 20);
            this.baLabel_StateInfo.TabIndex = 11;
            this.baLabel_StateInfo.Text = "N/A";
            // 
            // baLabel_PhoneNumber
            // 
            this.baLabel_PhoneNumber.AutoSize = true;
            this.baLabel_PhoneNumber.Location = new System.Drawing.Point(22, 247);
            this.baLabel_PhoneNumber.Name = "baLabel_PhoneNumber";
            this.baLabel_PhoneNumber.Size = new System.Drawing.Size(123, 20);
            this.baLabel_PhoneNumber.TabIndex = 12;
            this.baLabel_PhoneNumber.Text = "Phone Number: ";
            // 
            // baLabel_PhoneNumberInfo
            // 
            this.baLabel_PhoneNumberInfo.AutoSize = true;
            this.baLabel_PhoneNumberInfo.Location = new System.Drawing.Point(151, 247);
            this.baLabel_PhoneNumberInfo.Name = "baLabel_PhoneNumberInfo";
            this.baLabel_PhoneNumberInfo.Size = new System.Drawing.Size(35, 20);
            this.baLabel_PhoneNumberInfo.TabIndex = 13;
            this.baLabel_PhoneNumberInfo.Text = "N/A";
            // 
            // baButton_NewCustomer
            // 
            this.baButton_NewCustomer.Location = new System.Drawing.Point(59, 381);
            this.baButton_NewCustomer.Name = "baButton_NewCustomer";
            this.baButton_NewCustomer.Size = new System.Drawing.Size(112, 49);
            this.baButton_NewCustomer.TabIndex = 14;
            this.baButton_NewCustomer.Text = "New Customer";
            this.baButton_NewCustomer.UseVisualStyleBackColor = true;
            this.baButton_NewCustomer.Click += new System.EventHandler(this.baButton_NewCustomer_Click);
            // 
            // baButton_ViewTransactions
            // 
            this.baButton_ViewTransactions.Location = new System.Drawing.Point(239, 381);
            this.baButton_ViewTransactions.Name = "baButton_ViewTransactions";
            this.baButton_ViewTransactions.Size = new System.Drawing.Size(112, 49);
            this.baButton_ViewTransactions.TabIndex = 15;
            this.baButton_ViewTransactions.Text = "View Transactions";
            this.baButton_ViewTransactions.UseVisualStyleBackColor = true;
            this.baButton_ViewTransactions.Click += new System.EventHandler(this.baButton_ViewTransactions_Click);
            // 
            // baGroupBox
            // 
            this.baGroupBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.baGroupBox.Controls.Add(this.baLabel_BalanceInfo);
            this.baGroupBox.Controls.Add(this.baLabel_Balance);
            this.baGroupBox.Controls.Add(this.baLabel_FirstNameInfo);
            this.baGroupBox.Controls.Add(this.baButton_ViewTransactions);
            this.baGroupBox.Controls.Add(this.baButton_NewCustomer);
            this.baGroupBox.Controls.Add(this.baLabel_PhoneNumberInfo);
            this.baGroupBox.Controls.Add(this.baLabel_PhoneNumber);
            this.baGroupBox.Controls.Add(this.baLabel_StateInfo);
            this.baGroupBox.Controls.Add(this.baLabel_State);
            this.baGroupBox.Controls.Add(this.baLabel_CityInfo);
            this.baGroupBox.Controls.Add(this.baLabel_City);
            this.baGroupBox.Controls.Add(this.baLabel_DOBInfo);
            this.baGroupBox.Controls.Add(this.baLabel_DOB);
            this.baGroupBox.Controls.Add(this.baLabel_LastNameInfo);
            this.baGroupBox.Controls.Add(this.baLabel_LastName);
            this.baGroupBox.Controls.Add(this.baLabel_FirstName);
            this.baGroupBox.Controls.Add(this.baListBox_Customers);
            this.baGroupBox.Controls.Add(this.baLabel_Header);
            this.baGroupBox.Location = new System.Drawing.Point(115, 94);
            this.baGroupBox.Name = "baGroupBox";
            this.baGroupBox.Size = new System.Drawing.Size(431, 465);
            this.baGroupBox.TabIndex = 16;
            this.baGroupBox.TabStop = false;
            // 
            // baLabel_BalanceInfo
            // 
            this.baLabel_BalanceInfo.AutoSize = true;
            this.baLabel_BalanceInfo.Location = new System.Drawing.Point(151, 331);
            this.baLabel_BalanceInfo.Name = "baLabel_BalanceInfo";
            this.baLabel_BalanceInfo.Size = new System.Drawing.Size(35, 20);
            this.baLabel_BalanceInfo.TabIndex = 18;
            this.baLabel_BalanceInfo.Text = "N/A";
            // 
            // baLabel_Balance
            // 
            this.baLabel_Balance.AutoSize = true;
            this.baLabel_Balance.Location = new System.Drawing.Point(79, 331);
            this.baLabel_Balance.Name = "baLabel_Balance";
            this.baLabel_Balance.Size = new System.Drawing.Size(75, 20);
            this.baLabel_Balance.TabIndex = 17;
            this.baLabel_Balance.Text = "Balance: ";
            // 
            // baLabel_FirstNameInfo
            // 
            this.baLabel_FirstNameInfo.AutoSize = true;
            this.baLabel_FirstNameInfo.Location = new System.Drawing.Point(151, 165);
            this.baLabel_FirstNameInfo.Name = "baLabel_FirstNameInfo";
            this.baLabel_FirstNameInfo.Size = new System.Drawing.Size(35, 20);
            this.baLabel_FirstNameInfo.TabIndex = 16;
            this.baLabel_FirstNameInfo.Text = "N/A";
            // 
            // taGroupBox
            // 
            this.taGroupBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.taGroupBox.Controls.Add(this.taButton_NewTransaction);
            this.taGroupBox.Controls.Add(this.taLabel_AmountInfo);
            this.taGroupBox.Controls.Add(this.taLabel_Amount);
            this.taGroupBox.Controls.Add(this.taLabel_DateInfo);
            this.taGroupBox.Controls.Add(this.taLabel_Date);
            this.taGroupBox.Controls.Add(this.taLabel_NameInfo);
            this.taGroupBox.Controls.Add(this.taLabel_Name);
            this.taGroupBox.Controls.Add(this.taListBox_Transactions);
            this.taGroupBox.Controls.Add(this.taLabel_Header);
            this.taGroupBox.Location = new System.Drawing.Point(707, 94);
            this.taGroupBox.Name = "taGroupBox";
            this.taGroupBox.Size = new System.Drawing.Size(431, 465);
            this.taGroupBox.TabIndex = 17;
            this.taGroupBox.TabStop = false;
            // 
            // taButton_NewTransaction
            // 
            this.taButton_NewTransaction.Location = new System.Drawing.Point(166, 317);
            this.taButton_NewTransaction.Name = "taButton_NewTransaction";
            this.taButton_NewTransaction.Size = new System.Drawing.Size(112, 49);
            this.taButton_NewTransaction.TabIndex = 15;
            this.taButton_NewTransaction.Text = "New Transaction";
            this.taButton_NewTransaction.UseVisualStyleBackColor = true;
            this.taButton_NewTransaction.Click += new System.EventHandler(this.taButton_NewTransaction_Click);
            // 
            // taLabel_AmountInfo
            // 
            this.taLabel_AmountInfo.AutoSize = true;
            this.taLabel_AmountInfo.Location = new System.Drawing.Point(212, 259);
            this.taLabel_AmountInfo.Name = "taLabel_AmountInfo";
            this.taLabel_AmountInfo.Size = new System.Drawing.Size(35, 20);
            this.taLabel_AmountInfo.TabIndex = 13;
            this.taLabel_AmountInfo.Text = "N/A";
            // 
            // taLabel_Amount
            // 
            this.taLabel_Amount.AutoSize = true;
            this.taLabel_Amount.Location = new System.Drawing.Point(133, 259);
            this.taLabel_Amount.Name = "taLabel_Amount";
            this.taLabel_Amount.Size = new System.Drawing.Size(73, 20);
            this.taLabel_Amount.TabIndex = 12;
            this.taLabel_Amount.Text = "Amount: ";
            // 
            // taLabel_DateInfo
            // 
            this.taLabel_DateInfo.AutoSize = true;
            this.taLabel_DateInfo.Location = new System.Drawing.Point(212, 220);
            this.taLabel_DateInfo.Name = "taLabel_DateInfo";
            this.taLabel_DateInfo.Size = new System.Drawing.Size(35, 20);
            this.taLabel_DateInfo.TabIndex = 7;
            this.taLabel_DateInfo.Text = "N/A";
            // 
            // taLabel_Date
            // 
            this.taLabel_Date.AutoSize = true;
            this.taLabel_Date.Location = new System.Drawing.Point(154, 220);
            this.taLabel_Date.Name = "taLabel_Date";
            this.taLabel_Date.Size = new System.Drawing.Size(52, 20);
            this.taLabel_Date.TabIndex = 6;
            this.taLabel_Date.Text = "Date: ";
            // 
            // taLabel_NameInfo
            // 
            this.taLabel_NameInfo.AutoSize = true;
            this.taLabel_NameInfo.Location = new System.Drawing.Point(212, 182);
            this.taLabel_NameInfo.Name = "taLabel_NameInfo";
            this.taLabel_NameInfo.Size = new System.Drawing.Size(35, 20);
            this.taLabel_NameInfo.TabIndex = 3;
            this.taLabel_NameInfo.Text = "N/A";
            // 
            // taLabel_Name
            // 
            this.taLabel_Name.AutoSize = true;
            this.taLabel_Name.Location = new System.Drawing.Point(151, 182);
            this.taLabel_Name.Name = "taLabel_Name";
            this.taLabel_Name.Size = new System.Drawing.Size(55, 20);
            this.taLabel_Name.TabIndex = 2;
            this.taLabel_Name.Text = "Name:";
            // 
            // taListBox_Transactions
            // 
            this.taListBox_Transactions.FormattingEnabled = true;
            this.taListBox_Transactions.ItemHeight = 20;
            this.taListBox_Transactions.Location = new System.Drawing.Point(12, 46);
            this.taListBox_Transactions.Name = "taListBox_Transactions";
            this.taListBox_Transactions.Size = new System.Drawing.Size(402, 104);
            this.taListBox_Transactions.TabIndex = 1;
            this.taListBox_Transactions.SelectedIndexChanged += new System.EventHandler(this.taListBox_Transactions_SelectedIndexChanged);
            // 
            // taLabel_Header
            // 
            this.taLabel_Header.AutoSize = true;
            this.taLabel_Header.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taLabel_Header.Location = new System.Drawing.Point(127, 7);
            this.taLabel_Header.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.taLabel_Header.Name = "taLabel_Header";
            this.taLabel_Header.Size = new System.Drawing.Size(129, 24);
            this.taLabel_Header.TabIndex = 0;
            this.taLabel_Header.Text = "Transactions";
            // 
            // baForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1261, 794);
            this.Controls.Add(this.taGroupBox);
            this.Controls.Add(this.baGroupBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "baForm";
            this.Text = "Bank Accounts";
            this.baGroupBox.ResumeLayout(false);
            this.baGroupBox.PerformLayout();
            this.taGroupBox.ResumeLayout(false);
            this.taGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label baLabel_Header;
        private System.Windows.Forms.ListBox baListBox_Customers;
        private System.Windows.Forms.Label baLabel_FirstName;
        private System.Windows.Forms.Label baLabel_LastName;
        private System.Windows.Forms.Label baLabel_LastNameInfo;
        private System.Windows.Forms.Label baLabel_DOB;
        private System.Windows.Forms.Label baLabel_DOBInfo;
        private System.Windows.Forms.Label baLabel_City;
        private System.Windows.Forms.Label baLabel_CityInfo;
        private System.Windows.Forms.Label baLabel_State;
        private System.Windows.Forms.Label baLabel_StateInfo;
        private System.Windows.Forms.Label baLabel_PhoneNumber;
        private System.Windows.Forms.Label baLabel_PhoneNumberInfo;
        private System.Windows.Forms.Button baButton_NewCustomer;
        private System.Windows.Forms.Button baButton_ViewTransactions;
        private System.Windows.Forms.GroupBox baGroupBox;
        private System.Windows.Forms.GroupBox taGroupBox;
        private System.Windows.Forms.Button taButton_NewTransaction;
        private System.Windows.Forms.Label taLabel_AmountInfo;
        private System.Windows.Forms.Label taLabel_Amount;
        private System.Windows.Forms.Label taLabel_DateInfo;
        private System.Windows.Forms.Label taLabel_Date;
        private System.Windows.Forms.Label taLabel_NameInfo;
        private System.Windows.Forms.Label taLabel_Name;
        private System.Windows.Forms.ListBox taListBox_Transactions;
        private System.Windows.Forms.Label taLabel_Header;
        private System.Windows.Forms.Label baLabel_FirstNameInfo;
        private System.Windows.Forms.Label baLabel_BalanceInfo;
        private System.Windows.Forms.Label baLabel_Balance;
    }
}

