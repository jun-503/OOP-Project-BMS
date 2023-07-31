using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using BMS.BL;
using BMS.UI;
using BMS;
using System.Windows.Forms;

namespace BMS.DL
{
    class CustomerDL
    {
       
        private static string customerPath = "E:\\OOP PROJECTS\\BMS\\BMS GUI\\BMS\\BMS\\Data Files\\Customer.txt";
        //public static void writeDatainUsersFile(Customer c1)
        //{
        //    StreamWriter file = new StreamWriter(usersPath, true);
        //    file.WriteLine(c1.Naam + "," + c1.password + "," + c1.role);
        //    file.Flush();
        //    file.Close();
        //}
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
                    int acNum = int.Parse(splittedRecordForAccount[0]);
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

        public static void writeDatainCustomerFile()
        {
            
            StreamWriter file = new StreamWriter(customerPath, false);
            foreach (MUser user in MUser.users)
            {
                if (user is Customer c1)
                {
                    string AccountInfo = c1.acc.accNum + ";" + c1.acc.Holder + ";" + c1.acc.balance;
                    file.WriteLine(c1.Naam + "," + c1.password + "," + c1.role + "," + c1.custID + "," + c1.custNum + "," + c1.Address + "," + AccountInfo);
                    file.Flush();
                }
            }
            file.Close();

        }
        public static bool addComplaints()
        {
           string complaint =  Customer_UI.writeComplaint();
           if(complaint != null) 
           {
                Customer.addintoComplaintsList(complaint);
                return true;
           }
           else 
                return false;
        }
       
        public static Customer showBalance(int accNo)
        {
            foreach(var user in MUser.users)
            {
                if(user is Customer customer)
                {
                    if(accNo == customer.acc.accNum)
                    {
                        return customer;
                    }
                }
            }
            return null;
        }
      
        public static bool changePassword(string password, string newPass)
        {
            
            
            foreach (var user in MUser.users)
            {
                if (user is Customer customer)
                {
                    if (password == customer.password)
                    {
                        customer.password = newPass;
                        return true;
                    }
                }
            }
            return false;
        }
        //public static string sendMoney(int acc1,int acc2,double amount)
        //{
        //    Account a1  = null;
        //    Account a2  = null;
        //    foreach (var user in MUser.users)
        //    {
        //        if(user is Customer c1)
        //        {
        //            if(acc1 == c1.acc.accNum)
        //            {
        //                 a1 = c1.acc;
        //            }
        //            else if(acc2 == c1.acc.accNum)
        //            {
        //                a2 = c1.acc;
        //            }
        //        }
        //    }
        //    if(a1 != null && a2!=null)
        //    {
        //        Bank_DL.sendMoney(a1, amount, a2);
        //        return "true";
        //    }
        //    else if (a1==null && a2==null)
        //    {
        //        return "Both are incorrect";
        //    }
        //    else if(a1==null)
        //    {
        //        return "your account number is incorrect";
        //    }
        //    else 
        //    {
        //        return " Recipient account number  not found ";
        //    }

        //}
        public static Customer findAccount(int accNo)
        {
            foreach (var user in MUser.users)
            {
                if (user is Customer c1)
                {
                    if (accNo == c1.acc.accNum)
                    {
                        return c1;
                    }
                }
            }
            return null;
        }
        //public static Customer withDrawMoney()
        //{

        //    int accNum = Customer_UI.accNo();
        //    double amount = Customer_UI.amount();
        //    foreach (var user in MUser.users)
        //    {
        //        if (user is Customer customer)
        //        {
        //            if (accNum == customer.acc.accNum)
        //            {
        //                Bank_DL.withdraw(acc, amount);
        //                return customer;
        //            }
        //        }

        //    }
        //    return null;
        //}


    }
}
