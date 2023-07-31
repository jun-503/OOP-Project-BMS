using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BMS.BL
{
    class Customer:MUser
    {
        private string CustomerID;
        private string contactNumber;
        private string address;
        private Account account;
        private static List<Customer> customers = new List<Customer>();
        private static List<String > complaints = new List<String>();

        public Customer(string CustomerID, string contactNumber, string address, Account account,string mName,string mPassword,string mRole) : base(mName, mPassword, mRole)
        {
            
            this.CustomerID = CustomerID;
            this.contactNumber = contactNumber;
            this.address = address;
            this.account = account;
        }
        
        public Account acc
        {
            get { return account; }
        }
        public string custID
        {
            get
            {
                return CustomerID;
            }
        }
        public static void addintoCustomerList(Customer c1)
        {
            GetCustomers.Add(c1);
        }
        public static List<Customer> GetCustomers
        {
            get { return customers; }
        }
        public static void addintoComplaintsList(string complaint)
        {
            complaints.Add(complaint);
        }
        public static List<string> GetComplaints
        {
            get { return complaints; }
        }
        public string custNum
        {
            get
            {
                return contactNumber;
            }
        }
        public string Address
        {
            get
            {
                return address;
            }
        }
        
        public override string toString()
        {
            return base.toString() + $"Customer ID is {CustomerID} and contact Number is {contactNumber} and account Number is {account.accNum} and balance is {account.balance}";
        }

        internal Account Account
        {
            get => default;
            set
            {
            }
        }
        //public override string saveDataInFile(string Path,StreamWriter f1)
        //{

        //    string AccountInfo = acc.accNum + ";" + acc.Holder + ";" + acc.balance;
        //    f1.WriteLine(base.saveDataInFile(Path,f1) + "," + CustomerID + "," + contactNumber + "," + AccountInfo);
        //    f1.Flush();
        //    f1.Close();
        //    return null;
        //}
        //public static List<Customer> customer
        //{
        //    get { return customers; }
        //}
        //public static void addIntoList(Customer c1)
        //{
        //    customers.Add(c1);
        //}
    }
}
