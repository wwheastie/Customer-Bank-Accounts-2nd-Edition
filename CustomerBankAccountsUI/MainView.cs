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
    public partial class baForm : Form
    {
        //Variables
        List<Customer> customers = new List<Customer>();
        BindingSource customersBinding = new BindingSource();
        BindingSource transactionsBinding = new BindingSource();

        //Functions
        public baForm()
        {
            //Default function to set-up form
            InitializeComponent();

            //Set up data for testing
            setup_data(); //This is for testing

            //Bind customer list to baListBox_Customers
            customersBinding.DataSource = customers;
            baListBox_Customers.DataSource = customersBinding;
            baListBox_Customers.DisplayMember = "DisplayName";
            baListBox_Customers.ValueMember = "DisplayName";
        }

        private void baListBox_Customers_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Get what customer is being selected
            Customer selectedCustomer = (Customer)baListBox_Customers.SelectedItem;

            //Change the values of the label boxes
            set_baLabels(selectedCustomer);

            //Clear all items in the transaction listbox and set labels back to default
            clear_taListBox();
        }

        private void set_baLabels(Customer selectedCustomer)
        {
            //Change the values of the label boxes
            baLabel_FirstNameInfo.Text = selectedCustomer.FirstName;
            baLabel_LastNameInfo.Text = selectedCustomer.LastName;
            baLabel_DOBInfo.Text = selectedCustomer.DateOfBirth;
            baLabel_PhoneNumberInfo.Text = selectedCustomer.PhoneNumber;
            baLabel_CityInfo.Text = selectedCustomer.City;
            baLabel_StateInfo.Text = selectedCustomer.State;
            baLabel_BalanceInfo.Text = Convert.ToString(selectedCustomer.CurrentBalance);
        }

        private void baButton_NewCustomer_Click(object sender, EventArgs e)
        {
            //Create a new instance of 'New Customer Form'
            ncForm newCustomerForm = new ncForm();

            //Show 'New Customer Form' dialog box
            newCustomerForm.ShowDialog();

            //Add created customer to list of customers
            if (newCustomerForm.CustomerCreated == true)
            {
                customers.Add(newCustomerForm.add_customer());
            }

            //Reset list of customers view
            customersBinding.ResetBindings(false);

            //Show data of the first customer in 'customers' list if none is displaying
            if(baLabel_FirstName.Text == "N/A")
            {
                set_baLabels(customers[0]);
            }

            //Delete instance of 'New Customer Form'
            newCustomerForm.Dispose();
        }

        private void baButton_ViewTransactions_Click(object sender, EventArgs e)
        {
            //Get what customer is being selected for the customer listbox
            Customer selectedCustomer = (Customer)baListBox_Customers.SelectedItem;

            //Bind that customer's transactions to transactions listbox
            transactionsBinding.DataSource = selectedCustomer.Transactions;
            taListBox_Transactions.DataSource = transactionsBinding;
            taListBox_Transactions.DisplayMember = "Name";
            taListBox_Transactions.ValueMember = "Name";

            //Set the labels to the first transaction in the list
            if (selectedCustomer.Transactions.Count != 0)
            {
                set_taLabels(selectedCustomer.Transactions[0]);
            }
            else
            {
                MessageBox.Show("No transactions recorded!");
            }
        }

        private void taListBox_Transactions_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Get what transaction is being selected
            Transaction selectedTransaction = (Transaction)taListBox_Transactions.SelectedItem;

            //Change the values of the label information
            set_taLabels(selectedTransaction);
        }

        private void taButton_NewTransaction_Click(object sender, EventArgs e)
        {
            //Variables
            Customer selectedCustomer = (Customer)baListBox_Customers.SelectedItem;
            ntForm newTransactionForm = new ntForm();

            //Show new transaction form
            newTransactionForm.ShowDialog();

            //Add transaction to customer's list and adjust balance if transaction was created
            if (newTransactionForm.CreatedTransaction == true)
            {
                //Create new transaction
                Transaction transaction = newTransactionForm.add_transaction();

                //Add transaction to list
                selectedCustomer.Transactions.Add(transaction);

                //Update customer balance
                selectedCustomer.CurrentBalance += selectedCustomer.Transactions[selectedCustomer.Transactions.Count - 1].Amount;

                //Reset transactions bindings
                transactionsBinding.DataSource = selectedCustomer.Transactions;
                taListBox_Transactions.DataSource = transactionsBinding;
                taListBox_Transactions.DisplayMember = "Name";
                taListBox_Transactions.ValueMember = "Name";

                //Update balance label
                set_baLabels(selectedCustomer);

                //Set labels to this transaction if it is the only one
                if (selectedCustomer.Transactions.Count == 1)
                {
                    set_taLabels(selectedCustomer.Transactions[0]);
                }
            }

            //Delete transaction form
            newTransactionForm.Dispose();
        }

        private void set_taLabels(Transaction selectedTransaction)
        {
            if (selectedTransaction != null)
            {
                taLabel_NameInfo.Text = selectedTransaction.Name;
                taLabel_DateInfo.Text = selectedTransaction.Date;
                taLabel_AmountInfo.Text = Convert.ToString(selectedTransaction.Amount);
            }
        }

        private void clear_taListBox()
        {
            //Clear listbox
            taListBox_Transactions.DataSource = null;

            //Set labes to default
            taLabel_NameInfo.Text = "N/A";
            taLabel_DateInfo.Text = "N/A";
            taLabel_AmountInfo.Text = "N/A";
        }

        //Testing Stuff
        private void setup_data()
        {
            //Add Customers to List
            customers.Add(new Customer("William", "Hastings", "07-01-1999", "Houston", "TX", "600-527-0110", 200.00M));
            customers.Add(new Customer("John", "Smith", "12-25-1988", "New Orleans", "LA", "504-487-0943", 50.00M));
            customers.Add(new Customer("Ashley", "Eisa", "07-04-1989", "Miami", "FL", "954-826-7652", 850.50M));

            //Set Whitney's transactions
            customers[0].Transactions.Add(new Transaction ("Walmart", "06/29/2016", 50.00M));
            customers[0].Transactions.Add(new Transaction("Best Buy", "01/12/2016", 100.00M));
            customers[0].Transactions.Add(new Transaction("Academy", "05/19/2015", 50.00M));
        }
    }
}
