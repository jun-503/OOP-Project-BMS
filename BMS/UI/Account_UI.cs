using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BMS.BL;
using BMS.DL;

namespace BMS.UI
{
    class Account_UI
    {
        public static Account takeInput()
        {
            Console.WriteLine("Please enter your account number");
            int acNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter you account name");
            string acName = Console.ReadLine();
            Console.WriteLine("Enter Amount you Have");
            double balance = double.Parse(Console.ReadLine());
            if(balance<0)
            {
                balance = -balance;
            }
            Account a1 = new Account(acNum, acName, balance);
            Bank_DL.AddAccount(a1);
            return a1;
        }
    }
}
