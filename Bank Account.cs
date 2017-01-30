using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountProject
{
    public class Bank_Account
    {
        //fields
        string AccountBalance;
        string DateTime;
        string Name;
        string MoneyIn;
        string MoneyOut;
        

        //properties
        public string accountbalance
        {
            get { return this.accountbalance; }
            set { this.accountbalance = value; }
        }

        public string datetime
        {
            get { return this.datetime; }
            set { this.datetime = value; }
        }
        
        //constructor 
        public void thebankaccount (string accountbalance, string datetime)
        {
            this.accountbalance = accountbalance;
            this.datetime = datetime;
        }

        public void MainMenu()
        {
            Console.WriteLine("Welcome to Your Personal Bank");
            Console.WriteLine("Please enter your name");
            Console.ReadLine();
            Console.WriteLine("Welcome to your account, press enter to continue.");
            Console.ReadLine();
            Console.WriteLine("Please enter your account number in whole numbers. When complete, press enter.");
            Console.ReadLine();
            Console.WriteLine("Press 1 to review your account balances");
            Console.ReadLine();
            Console.WriteLine("Your checking account balance is $2,000");
            Console.WriteLine("Your savings account balance is $5,000");
            Console.WriteLine("Your reserve account balance is $10,000");
            Console.WriteLine("Press 6 in order to withdraw funds from checking");
            Console.WriteLine("Press 7 in order to withdraw funds from savings");
            Console.WriteLine("press 8 in order to withdraw funds from reserves");
            Console.WriteLine("Press 9 in order to deposit funds into checking");
            Console.WriteLine("Press 10 to deposit funds into savings");
            Console.WriteLine("Press 11 to deposit funds into reserves");
            Console.WriteLine("Press 12 in order to view your account information");
            int answer = int.Parse(Console.ReadLine());

            while (true)
                if (answer == 6)
                {
                    Console.WriteLine("How much money would you like to withdraw?");
                    double amount = int.Parse(Console.ReadLine());
                    Console.WriteLine(2000 - amount); Console.WriteLine("This is your current balance");
                    Console.ReadLine();

                }


                else if (answer == 7)
                {
                    Console.WriteLine("How much money would you like to withdraw?");
                    double amount = int.Parse(Console.ReadLine());
                    Console.WriteLine(5000 - amount); Console.WriteLine("This is your current balance");
                    Console.ReadLine();

                }

                else if (answer == 8)
                {
                    Console.WriteLine("How much money would you like to withdraw?");
                    double amount = int.Parse(Console.ReadLine());
                    Console.WriteLine(10000 - amount); Console.WriteLine("This is your current balance");
                    Console.ReadLine();
                }

                else if (answer == 9)
                {
                    Console.WriteLine("How much money would you like to deposit?");
                    double amount = int.Parse(Console.ReadLine());
                    Console.WriteLine(2000 + amount); Console.WriteLine("This is your current balance");
                    Console.ReadLine();
                }

                else if (answer == 10)
                {
                    Console.WriteLine("How much money would you like to deposit?");
                    double amount = int.Parse(Console.ReadLine());
                    Console.WriteLine(5000 + amount); Console.WriteLine("This is your current balance");
                    Console.ReadLine();
                }

                else if (answer == 11)
                {
                    Console.WriteLine("How much money would you like to deposit?");
                    double amount = int.Parse(Console.ReadLine());
                    Console.WriteLine(10000 + amount); Console.WriteLine("This is your current balance");
                    Console.ReadLine();
                }

                else if (answer == 12)
                {
                    Console.WriteLine("We take security seriously. For more information:");
                    Console.WriteLine("Call your personal banker at (440) 465-7641");
                    Console.WriteLine("Enjoy your day.");
                    break;
                }



        }
       
    }
}



