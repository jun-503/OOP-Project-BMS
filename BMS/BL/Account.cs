using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMS.BL
{
    class Account
    {
        protected int AccountNumber;
        protected string AccountHolder;
        protected double Balance;

        public Account(int AccountNumber, string AccountHolder, double Balance)
        {
            this.AccountNumber = AccountNumber;
            this.AccountHolder = AccountHolder;
            this.Balance = Balance;

        }
        public double balance
        {
            get { return Balance; }
            set { Balance=value; }
        }
        public int accNum
        {
            get { return AccountNumber; }
        }
        public string Holder
        {
            get { return AccountHolder; }
        }
        


    }
}
