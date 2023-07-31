using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMS.BL
{
    class Bank
    {
        
        private static List<Account> Accounts = new List<Account>();
        private static List<Transaction> Transactions = new List<Transaction>();
        public static List<Account> accounts
        {
            get { return Accounts; }
        }
        public static List<Transaction> transactions
        {
            get { return Transactions; }
        }

        internal Transaction Transaction
        {
            get => default;
            set
            {
            }
        }

        internal Account Account
        {
            get => default;
            set
            {
            }
        }
    }
}
