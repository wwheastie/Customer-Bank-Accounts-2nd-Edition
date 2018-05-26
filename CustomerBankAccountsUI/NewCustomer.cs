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
    public partial class ncForm : Form
    {
        //Variables
        Customer newCustomer;
        public bool CustomerCreated { get; set; }

        //Functions
        public ncForm()
        {
            InitializeComponent();
            CustomerCreated = false;
        }

        private void ncButton_Add_Click(object sender, EventArgs e)
        {
            //Variables
            string firstName, lastName, dateOfBirth, city, state, phoneNumber;
            decimal initalBalance;

            //Get information for textbox
            firstName = ncTextBox_FirstName.Text;
            lastName = ncTextBox_LastName.Text;
            dateOfBirth = ncTextBox_DOBMonth.Text + "-" + ncTextBox_DOBDay.Text + "-" + ncTextBox_DOBYear.Text;
            city = ncTextBox_City.Text;
            state = ncTextBox_State.Text;
            phoneNumber = ncTextBox_FirstDigits.Text + '-' + ncTextBox_SecondDigits.Text + "-" + ncTextBox_ThirdDigits.Text;
            initalBalance = initial_balance();

            //Check to see if all fields were entered
            if (invalid_info())
            {
                //Display message box if all information has not been entered
                MessageBox.Show("Please enter information in all fields!");
            }
            else
            {
                //Set newCustomer information if all fields have been entered
                newCustomer = new Customer(firstName, lastName, dateOfBirth, city, state, phoneNumber, initalBalance);
                CustomerCreated = true;
                Close();
            }
        }

        private void ncButton_Cancel_Click(object sender, EventArgs e)
        {
            CustomerCreated = false;
            Close();
        }

        public Customer add_customer()
        {
            return newCustomer;
        }

        private bool invalid_info()
        {
            if (ncTextBox_FirstName.Text == "")
            {
                return true;
            }
            else if (ncTextBox_LastName.Text == "")
            {
                return true;
            }
            else if(ncTextBox_DOBDay.Text == "")
            {
                return true;
            }
            else if (ncTextBox_DOBMonth.Text == "")
            {
                return true;
            }
            else if (ncTextBox_DOBYear.Text == "")
            {
                return true;
            }
            else if (ncTextBox_City.Text == "")
            {
                return true;
            }
            else if (ncTextBox_State.Text == "")
            {
                return true;
            }
            else if (ncTextBox_FirstDigits.Text == "")
            {
                return true;
            }
            else if (ncTextBox_SecondDigits.Text == "")
            {
                return true;
            }
            else if (ncTextBox_ThirdDigits.Text == "")
            {
                return true;
            }
            else if(ncTextBox_InitialBalance.Text == "")
            {
                return true;
            }

            return false;
        }

        private decimal initial_balance()
        {
            if (ncTextBox_InitialBalance.Text != "")
            {
                return decimal.Parse(ncTextBox_InitialBalance.Text);
            }

            return 0.0M;
        }
    }
}
