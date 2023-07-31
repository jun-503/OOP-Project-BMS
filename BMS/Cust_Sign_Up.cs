using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BMS.UI;
using BMS.DL;
using BMS.BL;

namespace BMS
{
    public partial class Cust_Sign_Up : Form
    {
        public Cust_Sign_Up()
        {
            InitializeComponent();
            
           
        }
        

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private string signUp()
        {
            string name = textBox1.Text;
            string password = textBox2.Text;
            if(name!="" && password!="" )
            {
                bool isPresent = MUser_DL.isAlreadyExists(name, password);
                if (isPresent)
                {
                    string role = "customer";
                    string custid = $"{MUser.users.Count + 1}AZ";
                    string address = textBox4.Text;
                    string cNum = textBox5.Text;
                    string anum = textBox6.Text;
                    int aNum = int.Parse(anum);
                    string holder = textBox7.Text;
                    double balance = double.Parse(textBox8.Text);
                    Account a1 = new Account(aNum, holder, balance);
                    Bank.accounts.Add(a1);
                    Customer c1 = new Customer(custid, cNum, address, a1, name, password, role);
                    MUser_DL.addIntoList(c1);
                    Customer.addintoCustomerList(c1);
                    return "ok";
                }
                else
                {
                    return "already exists";
                }
            }
            else
            {
                return "empty";
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
          string message =  signUp();
            if (message == "ok")
            {
                MessageBox.Show("SignUp Successfully");
                CustomerDL.writeDatainCustomerFile();
                Close();
            }
            else if (message == "already exists")
            {
                MessageBox.Show(" Credentials Already Exists. Try with other name and Password ");
                return;
            }
            else
            {
                MessageBox.Show(" EMPTY FIELDS ");
                return;
            }

        }
    }
}
