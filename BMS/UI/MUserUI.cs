using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BMS.BL;
using System.IO;
using BMS.DL;
using System.Windows.Forms;
using System.Drawing;

namespace BMS.UI
{
    class MUserUI
    {
        private static string usersPath = "E:\\OOP PROJECTS\\BMS\\BMS\\BMS\\users.txt";
        public static MUser takeInputWithoutRole()
        {
            Console.WriteLine("Enter Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Password: ");
            string password = Console.ReadLine();
            if (name != null && password != null)
            {
                MUser user = new MUser(name, password);
                return user;
            }
            return null;

        }

       //public static MUser takeInputWithRole()
       // {
           
       //   //  string name = textBox1.Text;
       //     Console.WriteLine("Enter Password: ");
       //     string password = Console.ReadLine();
            
       //     bool check = MUser_DL.isAlreadyExists(name, password);
       //     if (check == true)
       //     {
       //         MUser user = new MUser(name, password);
       //         return user;
       //         //if (role == "customer")
       //         //{
       //         //    Customer c1 = Customer_UI.takeInput(name, password, role);
       //         //    MUser_DL.addIntoList(c1);
       //         //    return c1;
       //         //}
       //         //else if (role == "employee")
       //         //{
       //         //    Employee e1 = Employee_UI.takeInput(name, password, role);
       //         //    MUser_DL.addIntoList(e1);
       //         //    return e1;
       //         //}
       //     }



       //     return null;
       // }

        //public static bool ReadUsersData()
        //{
        //    if (File.Exists(usersPath))
        //    {
        //        StreamReader fileVariable = new StreamReader(usersPath);
        //        string record;
        //        while ((record = fileVariable.ReadLine()) != null)
        //        {
        //            string[] splittedData = record.Split(',');
        //            string name = splittedData[0];
        //            string password = splittedData[1];
        //            string role = splittedData[2];

        //            MUser user = new MUser(name, password, role);
        //            if (role=="customer")
        //            {
        //                Customer c1 = Customer_UI.readCustomerData(name, password, role);
        //                MUser_DL.addIntoList(c1);
        //            }
        //           else if(role=="employee")
        //            {
        //                Employee e1 = Employee_UI.readEmployeeData(name, password, role);
        //                 MUser_DL.addIntoList(e1);
        //            }
        //        }
        //        fileVariable.Close();
        //        return true;
        //    }
        //    return false;
        //}
    }

}
