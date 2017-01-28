using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountProject
{
    public class Checking_Account : Bank_Account
    {
        //fields
        string AccountBalance;
        string DateTime;

        //properties
        public new string accountbalance
        {
            get { return this.accountbalance; }
            set { this.accountbalance = value; }
        }

        public new string datetime
        {
            get { return this.datetime; }
            set { this.datetime = value; }
        }
        public new void thebankaccount(string accountbalance, string datetime)
        {
            this.accountbalance = accountbalance;
            this.datetime = datetime;
        }
    }
    }

