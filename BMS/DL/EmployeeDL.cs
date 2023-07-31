using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BMS.BL;
using System.IO;



namespace BMS.DL
{
    class EmployeeDL
    {
        private static string employeePath = "E:\\OOP PROJECTS\\BMS\\BMS GUI\\BMS\\BMS\\Data Files\\Employee.txt";
     
        //public static void writeDatainUsersFile(Employee e1)
        //{
        //    StreamWriter file = new StreamWriter(usersPath, true);
        //    file.WriteLine(e1.Naam + "," + e1.password + "," + e1.role);
        //    file.Flush();
        //    file.Close();
        //}
        public static void writeDatainEmployeeFile()
        {
           
            StreamWriter file = new StreamWriter(employeePath, false);
            foreach (MUser user in MUser.users)
            {
                if (user is Employee e1)
                {
                    file.WriteLine(e1.Naam + "," + e1.password + "," + e1.role + "," + e1.empID + "," + e1.Email + "," + e1.Rank + "," + e1.cNum);
                    file.Flush();
                }
            }
            file.Close();
        }
        public static void showCustomerAccounts()
        {
            foreach (MUser user1 in MUser.users)
            {
                if (user1 is Customer c1)
                {
                    Console.WriteLine(c1.toString());
                }
            }
        }
        public static string deleteCustomerAccount(int accNo)
        {
           Customer c1 =  CustomerDL.findAccount(accNo);
            if (c1 != null)
            {
                MUser.users.Remove(c1);
                return "Account deleted";
            }
            else
                return "Account Not Found";

        }
        public static bool readEmployeeData()
        {
            if (File.Exists(employeePath))
            {
                StreamReader fileVariable = new StreamReader(employeePath);
                string record;
                while ((record = fileVariable.ReadLine()) != null)
                {
                    string[] splittedData = record.Split(',');
                    string name = splittedData[0];
                    string password = splittedData[1];
                    string role = splittedData[2];
                    string ID = splittedData[3];
                    string email = splittedData[4];
                    string rank = splittedData[5];
                    string cNum = splittedData[6];
                    Employee e1 = new Employee(name, password, role, ID, email, rank, cNum);
                    MUser_DL.addIntoList(e1);
                    Employee.addIntoList(e1);


                }
                fileVariable.Close();
                return true;
            }
            else
            {
                return false;
            }
        }
        public static void addNewMessage()
        {
            Console.WriteLine(" Enter the Message for cutting out ");
            string message = Console.ReadLine();
            Employee.addMessage(message);
        }
        public static bool changePassword(string password, string newPass)
        {
            foreach (var user in MUser.users)
            {
                if (user is Employee employee)
                {
                    if (password == employee.password)
                    {
                        employee.password = newPass;
                        return true;
                    }
                }
            }
            return false;
        }
        public static bool cuttingDown(double amount)
        {
            int count = 0;
            foreach(MUser user in MUser.users)
            {
                if(user is Customer customer)
                {
                    if (customer.acc.balance > 10000)
                    {
                        customer.acc.balance -= amount;
                        count++;
                       
                    }
                }
            }
            if (count > 0)
            {
                return true;
            }
            return false;
        }



    }
}
