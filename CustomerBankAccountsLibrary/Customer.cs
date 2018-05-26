using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerBankAccountsLibrary
{
    public class Customer
    {
        //Properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DateOfBirth { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PhoneNumber { get; set; }
        public decimal CurrentBalance { get; set; }
        public List<Transaction> Transactions { get; set; }
        public string DisplayName
        {
            get
            {
                return string.Format("{0}, {1}", LastName, FirstName);
            }
        }

        //Functions
        public Customer(string _firstName, string _lastName, string _dateOfBirth, string _city, string _state, string _phoneNumber, decimal _initialBalance)
        {
            this.FirstName = _firstName;
            this.LastName = _lastName;
            this.DateOfBirth = _dateOfBirth;
            this.City = _city;
            this.State = _state;
            this.PhoneNumber = _phoneNumber;
            this.CurrentBalance = _initialBalance;
            this.Transactions = new List<Transaction>();
        }
    }
}
