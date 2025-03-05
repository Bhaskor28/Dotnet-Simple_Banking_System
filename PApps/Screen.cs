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
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("\t\tWelcome to simple Banking system:");
            Console.WriteLine("-----------------------------------------------------");

            Console.WriteLine("1. Create Account");
                Console.WriteLine("2. Deposit");
                Console.WriteLine("3. Withdraw");
                Console.WriteLine("4. Check Balance");
                Console.WriteLine("5. Apply Interest (Savings Account)");
                Console.WriteLine("6. Account Information");
                Console.WriteLine("7. Exit");
            }

        
    }
}
