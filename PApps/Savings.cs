using PApps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBS
{
    public class SavingAccount : BankAccount
    {


        public decimal InterestRate { get; private set; }
        public SavingAccount(int ac, string ach, decimal bal,string ty, decimal ir) : base(ac, ach, bal,ty)
        {
            InterestRate = ir;

        }

        public void ApplyInt(decimal rate)
        {
            decimal p_bal = Balance;
            Balance += (Balance * (rate / 100));

            Console.WriteLine($"Your previous balance was {p_bal} applying interest rate {InterestRate} current balance is {Balance}");

        }


    }
}