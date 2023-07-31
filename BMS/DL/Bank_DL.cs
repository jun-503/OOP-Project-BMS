using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using BMS.BL;

namespace BMS.DL
{
    class Bank_DL
    {
        public static void AddAccount(Account account)
        {
            Bank.accounts.Add(account);
        }

        public static void AddTransaction(Transaction transaction)
        {
            Bank.transactions.Add(transaction);
        }

        public static List<Transaction> GetTransactions(Account account)
        {
            return Bank.transactions.Where(t => t.acc == account).ToList();
        }

        public static Account Deposit(int acNum, double amount)
        {
            foreach(Account a1 in Bank.accounts)
            {
                if (a1.accNum == acNum)
                {
                    a1.balance += amount;
                    return a1;
                }

            }
            return null;
        }
        public static Account sendMoney(int acNum1, double amount ,int acNum2)
        {
           bool check  = false;
            bool check1   = false;
            Account account = null;
            foreach (Account a1 in Bank.accounts)
            {
                if (a1.accNum == acNum1)
                {
                   check = true;
                    account = a1;
                }
               

            }
            foreach (Account a1 in Bank.accounts)
            {
                if (a1.accNum == acNum2)
                {
                    
                        check1 = true;
                    
                }


            }
            if(check ==true && check1 ==true)
            {
                withdraw(acNum1, amount);
                Deposit(acNum2, amount);
                return account ;
            }
            else 
                return null;

        }
        public static Account withdraw(int acNum, double amount)
        {
            foreach (Account a1 in Bank.accounts)
            {
                if (a1.accNum == acNum)
                {
                    a1.balance -= amount;
                    return a1;
                }
            }
            return null;    
        }


    }
}
