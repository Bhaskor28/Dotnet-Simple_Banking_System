
using PApps;
using System;
using System.Security.Principal;
using System.Threading.Channels;

namespace SBS;
public class Home
{


    public static void Main(string[] args)
    {

        
        Dictionary<int, BankAccount> memo = new Dictionary<int, BankAccount>();
        List<BankAccount>Userlist = new List<BankAccount>();

        void AdUser()
        {
            Console.WriteLine("Enter Account Number: ");
            int acno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Account Holder Name: ");
            string acholder = Console.ReadLine();
            Console.WriteLine("Enter Initial Balance: ");
            decimal bal = Convert.ToDecimal(Console.ReadLine());


            Console.WriteLine("Select Account type:\n1.Regular\n2.Savings");

            int option = Convert.ToInt32(Console.ReadLine());


            if (option == 1)
            {
                memo.Add(acno, new BankAccount(acno, acholder, bal,"R"));
                Userlist.Add(new BankAccount(acno, acholder, bal, "R"));
                Console.WriteLine("1 Regular user Account created successfully.");

            }
            else if (option == 2)
            {
                Console.WriteLine("Enter interest rate: ");
                decimal ir = Convert.ToDecimal(Console.ReadLine());
                memo.Add(acno, new SavingAccount(acno, acholder, bal,"S",ir));
                Userlist.Add(new BankAccount(acno, acholder, bal, "S"));
                Console.WriteLine("1 Savings user Account created successfully.");

            }
            else
            {
                Console.WriteLine("something went wrong");
            }


        }


        void AccountInfo()
        {
            Console.WriteLine("Enter what type of account you want to see: \n1.Savings Account\n2.Regular Account");
            int opt = Convert.ToInt32(Console.ReadLine());


            if (opt == 1)
            {


                var sav = Userlist.FindAll(a => a.Actype == "S");
                sav.ForEach(a => { Console.WriteLine($"Account Number: {a.AccountNumber} Account Holder Name: {a.AccountHolder}  Account Type: Saving"); });




            }
            if (opt == 2)
            {
                var sav = Userlist.FindAll(a => a.Actype == "R");
                sav.ForEach(a => { Console.WriteLine($"Account Number: {a.AccountNumber} Account Holder Name: {a.AccountHolder} Account Balance: {a.Balance} Account Type: Regular"); });


            }


        }

            while (true)
            {
                Screen.ShowScreen();
                Console.WriteLine("Enter any Option:");
                try
                {
                    var option = int.Parse(Console.ReadLine());




                    if (option == 7)
                    {
                        break;
                    }
                    switch (option)
                    {
                        case 1:
                            AdUser();

                            break;
                        case 2:
                            Console.WriteLine("Enter Account Number:");
                            int acno = Convert.ToInt32(Console.ReadLine());
                            //BankAccount ba = userList.findaccount(acno);
                            if (memo.ContainsKey(acno))
                            {

                                Console.WriteLine("Enter Deposit Ammount: ");
                                decimal amount = Convert.ToDecimal(Console.ReadLine());

                                memo[acno].Balance += amount;
                                Console.WriteLine($"previous Balance: {memo[acno].Balance - amount} after deposit {memo[acno].Balance}");


                            }
                            else
                            {
                                Console.WriteLine("Account not found! try again");
                            }
                            break;
                        case 3:
                            Console.WriteLine("Enter Account Number:");
                            int ac = Convert.ToInt32(Console.ReadLine());
                            //BankAccount bali = userList.findaccount(ac);
                            if (memo.ContainsKey(ac))
                            {

                                Console.WriteLine("Enter Withdraw Ammount: ");
                                decimal amount = Convert.ToDecimal(Console.ReadLine());
                                if (memo[ac].Balance >= amount)
                                {
                                    memo[ac].Balance -= amount;

                                    Console.WriteLine($"previous Balance: {memo[ac].Balance + amount} after Withdraw {memo[ac].Balance}");


                                }
                                else
                                {
                                    Console.WriteLine("Not sufficient Balance ");
                                }


                            }
                            else
                            {
                                Console.WriteLine("Account not found! try again");
                            }
                            break;
                        case 4:
                            Console.WriteLine("Enter Account Number:");
                            int bac = Convert.ToInt32(Console.ReadLine());

                            if (memo.ContainsKey(bac))
                            {

                                Console.WriteLine($"Your account Balance is {memo[bac].Balance}");


                            }
                            else
                            {
                                Console.WriteLine("Account not found! try again");
                            }
                            break;
                        case 5:
                            Console.WriteLine("Enter Account Number:");
                            int fac = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter interest rate:");
                            decimal rate = Convert.ToDecimal(Console.ReadLine());
                            if (memo.ContainsKey(fac))
                            {

                                decimal gain = memo[fac].Balance * (rate / 100);
                                memo[fac].Balance += gain;
                                Console.WriteLine($"previous Balance: {memo[fac].Balance - gain} after applying interest rate {memo[fac].Balance}");

                            }



                            break;
                        case 6:
                            AccountInfo();
                            break;
                        default:
                            Console.WriteLine("invalid input");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Please try again with a valid input ");
                }

            }


        }





    
}