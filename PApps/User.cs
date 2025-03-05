using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PApps
{
    public class BankAccount
    {
        public int AccountNumber { get; private set; }
        public string AccountHolder { get; set; }
        public decimal Balance { get; set; }

        public BankAccount(int ac, string ach, decimal bal)
        {

            AccountNumber = ac;
            AccountHolder = ach;
            Balance = bal;

        }
    }
}
