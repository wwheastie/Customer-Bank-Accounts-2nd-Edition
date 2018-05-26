using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CustomerBankAccountsLibrary;

namespace CustomerBankAccountsUI
{
    public partial class ntForm : Form
    {
        //Variables
        Transaction transaction;
        public bool CreatedTransaction { get; set; }

        //Functions
        public ntForm()
        {
            InitializeComponent();

            CreatedTransaction = false;
        }

        private void ntButton_Add_Click(object sender, EventArgs e)
        {
            //Variables
            string name, date;
            decimal amount;

            //Get information form textbox
            name = ntTextBox_Name.Text;
            date = ntTextBox_Month.Text + "/" + ntTextBox_Day.Text + "/" + ntTextBox_Year.Text;
            amount = new_amount();

            //Check to see if all fields were entered
            if(invalid_info())
            {
                //Display message box if all information has not been entered
                MessageBox.Show("Please enter information in all fields!");
            }
            else
            {
                //Set newCustomer information if all fields have been entered
                transaction = new Transaction(name, date, amount);
                CreatedTransaction = true;
                Close();
            }
        }

        private void ntButton_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        public Transaction add_transaction()
        {
            return transaction;
        }

        private bool invalid_info()
        {
            if (ntTextBox_Name.Text == "")
            {
                return true;
            }
            else if (ntTextBox_Day.Text == "")
            {
                return true;
            }
            else if (ntTextBox_Month.Text == "")
            {
                return true;
            }
            else if (ntTextBox_Year.Text == "")
            {
                return true;
            }
            else if (ntTextBox_Amount.Text == "")
            {
                return true;
            }

            return false;
        }

        private decimal new_amount()
        {
            if(ntTextBox_Amount.Text != "")
            {
                return decimal.Parse(ntTextBox_Amount.Text);
            }

            return 0.0M;
        }
    }
}
