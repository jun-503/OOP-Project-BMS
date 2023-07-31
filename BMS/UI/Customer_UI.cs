using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BMS.BL;
using System.IO;
using BMS.DL;
using BMS;

namespace BMS.UI
{
    class Customer_UI
    {
       private static readonly string customerPath = "E:\\OOP PROJECTS\\BMS\\BMS\\BMS\\Customer.txt";
        
        //public static int customerMenu()
        //{
        //    int op;
        //    Console.ForegroundColor = ConsoleColor.DarkCyan;

        //    Console.WriteLine("                             **********   CUSTOMER MENU  *********             ");
        //    Console.WriteLine();
        //    Console.ResetColor();
        //    Console.WriteLine(" Select one option below: ");
        //    Console.WriteLine();
        //    Console.WriteLine("1. Deposit Amount ");
        //    Console.WriteLine();
        //    Console.WriteLine("2. WithDraw Amount");
        //    Console.WriteLine();
        //    Console.WriteLine("3. Balance Enquiry");
        //    Console.WriteLine();
        //    Console.WriteLine("4. Change Password ");
        //    Console.WriteLine();
        //    Console.WriteLine("5. Send money  ");
        //    Console.WriteLine();
        //    Console.WriteLine("6. Account Details ");
        //    Console.WriteLine();
        //    Console.WriteLine("7. Transaction Details ");
        //    Console.WriteLine();
        //    Console.WriteLine("8. Show Notifications ");
        //    Console.WriteLine();
        //    Console.WriteLine("9. Write Complaints ");
        //    Console.ForegroundColor = ConsoleColor.Red;
        //    Console.WriteLine("11. Log out   ");
        //    Console.ResetColor();
        //    Console.WriteLine();

        //    Console.WriteLine();
        //    Console.Write("Enter Option: ");
        //    op = int.Parse(Console.ReadLine());
        //    return op;
        //}
        public static string writeComplaint()
        {
            Console.WriteLine(" Enter your Complaint ");
            string complaint = Console.ReadLine();
            return complaint;
        }
        //public static Customer takeInput()
        //{
          
        //    MUser user = MUserUI.takeInputWithRole();
        //    if (user != null)
        //    {
        //        string name = user.Naam;
        //        string password = user.password;
        //        string role = "Customer";
        //        string custID = $" {MUser.users.Count + 1}  AZ";
        //        Console.WriteLine("Please Enter Your Contact Number: ");
        //        string cNum = Console.ReadLine();
        //        Console.WriteLine("Please Enter Your Address");
        //        string address = Console.ReadLine();
        //        Account a1 = Account_UI.takeInput();
        //        Customer c1 = new Customer(custID, cNum, address, a1, name, password, role);

        //        return c1;
        //    }
        //    return null;
        //}
        public static int accNo()
        {
            Console.WriteLine("Enter your Account Number");
            int accNum = int.Parse(Console.ReadLine());
            return accNum;
        }
        public static int recAccNo()
        {
            Console.WriteLine("Enter recipent Account Number");
            int accNum = int.Parse(Console.ReadLine());
            return accNum;
        }
        public static double amount ()
        {
            Console.WriteLine("Enter the amount ");
            double amount = double.Parse(Console.ReadLine());
            if(amount<0)
            {
                amount = -amount;
            }
            return amount;
        }
        public static bool readCustomerData()
        {
            if (File.Exists(customerPath))
            {
                StreamReader fileVariable = new StreamReader(customerPath);
                string record;
                while ((record = fileVariable.ReadLine()) != null)
                {
                    
                    string[] splittedData = record.Split(',');
                    string name = splittedData[0]; 
                    string password = splittedData[1];
                    string role = splittedData[2];
                    string ID = splittedData[3];

                    string contactNum = splittedData[4];
                    string address = splittedData[5];
                    string[] splittedRecordForAccount = splittedData[6].Split(';');
                    int acNum =int.Parse( splittedRecordForAccount[0]);
                    string acName = splittedRecordForAccount[1];
                    double balance = double.Parse(splittedRecordForAccount[2]);
                    Account a1 = new Account(acNum, acName, balance);
                    Bank.accounts.Add(a1);
                    Customer c1 = new Customer(ID, contactNum, address, a1, name, password, role);
                   
                    MUser_DL.addIntoList(c1);
                    Customer.addintoCustomerList(c1);
                    
                   
                }
                fileVariable.Close();
                return true;
            }
           
            return false;
        }

    }
}
