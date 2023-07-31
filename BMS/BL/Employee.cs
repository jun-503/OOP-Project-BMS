using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net.Http;

namespace BMS.BL
{
    class Employee:MUser
    {
        private string employeeID;
        private string email;
        private string rank;
        private string contactNumber;
        private static List<Employee> employees = new List<Employee>();
        private static List <string> messages = new List<string>();
        public Employee(string mName,string mPassword,string mRole,string employeeID,string email,string rank,string contactNumber):base(mName,mPassword,mRole)
        {
            this.employeeID = employeeID;
            this.email = email;
            this.rank = rank;
            this.contactNumber = contactNumber;
        }
        public string empID
        {
            get { return employeeID; }
        }

        public string Email
        {
            get { return email; }
        }
        public static List<Employee> getEmployees
        {
            get { return employees; }
        }
        public string Rank
        {
            get { return rank; }
        }
        public string cNum
        {
            get { return contactNumber; }
        }
        public static void addIntoList(Employee e1)
        {
            employees.Add(e1);
        }
        public static void addMessage(string message)
        {
            messages.Add(message);
        }
        public static List<String> getMessages
        {
            get { return messages; }
        }
        public override string toString()
        {
            return base.toString() + $" Employee ID is {employeeID} and rank is {Rank} and Conatct Number is {contactNumber} ";
        }
        //public override string saveDataInFile(string Path,StreamWriter f1)
        //{

        //    f1.WriteLine(base.saveDataInFile(Path,f1) + "," + employeeID + "," + email + "," + rank + "," + contactNumber);
        //    f1.Flush();
        //    f1.Close();
        //    return null;
        //}
    }
}
