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
            Console.WriteLine("Press 6 in order to withdraw funds");
            Console.WriteLine("Press 7 in order to deposit funds");
            Console.WriteLine("Press 8 in order to view your account information");
            int answer = int.Parse(Console.ReadLine());

            while (true)
                if (answer == 6)
                {
                    Console.WriteLine("From which account would you like to withdraw?");
                    Console.ReadLine();
                    Console.WriteLine("How much money would you like to withdraw?");
                    Console.ReadLine();

                }


                else if (answer == 7)
                {
                    Console.WriteLine("To which account would you like to deposit?");
                    Console.ReadLine();
                    Console.WriteLine("How much money would you like to deposit?");
                    Console.ReadLine();
                    
                }

                else if (answer == 8)
                {
                    Console.WriteLine("We take security seriously. For more information:");
                    Console.WriteLine("Call your personal banker at (440) 465-7641");
                    Console.WriteLine("Enjoy your day.");
                    break;
                }
               



        }
        ////methods
        ////static void BarrytheBlowfish()
        //{
        //    while (true)
        //    {
        //        Console.WriteLine("1. Barry needs food, press 1 to feed him");
        //        Console.WriteLine("2. Barry needs water, press 2 to give him something to drink");
        //        Console.WriteLine("3. Barry is bored and wants to play. Press 3 to play with him");
        //        Console.WriteLine("4. Barry is satisfied and needs no care!");
        //        int answer = int.Parse(Console.ReadLine());
        //        if (answer == 1)
        //        {
        //            Console.WriteLine("Barry is now full.He has full hunger of 10");
        //        }
        //        else if (answer == 2)
        //        {
        //            Console.WriteLine("Barry is now fully hydrated.He has full thirst of 10");
        //        }
        //        else if (answer == 3)
        //        {
        //            Console.WriteLine("Barry is now happy and energized. His boredom is full at 10");
        //            break;
        //        }
        //        else
        //        {
        //            Console.WriteLine("Barry has been well taken care of. Thank you for caring for him and go back to your day");
        //        }
    }
}
