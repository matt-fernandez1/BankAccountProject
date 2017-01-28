using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank_Account client1 = new Bank_Account();
            Checking_Account cclient1 = new Checking_Account();
            Savings_Account sclient1 = new Savings_Account();
            Reserve_Account rclient1 = new Reserve_Account();

            client1.MainMenu();
        }

        
    }
}
