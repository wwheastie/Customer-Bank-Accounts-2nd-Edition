using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerBankAccountsLibrary
{
    public class Transaction
    {
        //Properties
        public string Name { get; set; }
        public string Date { get; set; }
        public decimal Amount { get; set; }

        //Functions
        public Transaction(string _name, string _date, decimal _amount)
        {
            this.Name = _name;
            this.Date = _date;
            this.Amount = _amount;
        }
    }
}
