using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMS.BL
{
    class Transaction
    {
        private int TransactionId;
        private DateTime Date;
        private double Amount;
        private string TransactionType;
        private Account Account;

        public Transaction(int TransactionId,DateTime Date,double Amount,string TransactionType,Account Account)
        {
            this.TransactionId = TransactionId;
            this.Date = Date;
            this.Amount = Amount;
            this.TransactionType = TransactionType;
            this.Account = Account;
        }
        public Account acc
        {
            get { return Account; }
        }
        public int TransId
        {
            get { return TransactionId; }
        }
        public DateTime date
        {
            get { return Date; }
        }
        public double amount
        {
            get { return Amount; }
        }
        public string transType
        {
            get { return TransactionType; }
        }
    }
}
