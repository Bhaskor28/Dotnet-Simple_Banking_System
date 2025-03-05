using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PApps
{
    public class Screen
    {

        
            public static void ShowScreen()
            {
                Console.WriteLine("Welcome to simple Banking system:");

                Console.WriteLine("1. Create Account");
                Console.WriteLine("2. Deposit");
                Console.WriteLine("3. Withdraw");
                Console.WriteLine("4. Check Balance");
                Console.WriteLine("5. Apply Interest (Savings Account)");
                Console.WriteLine("6. Exit");
            }

        
    }
}
