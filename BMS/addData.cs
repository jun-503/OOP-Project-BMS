using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BMS.BL;
using BMS.DL;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BMS
{
    public partial class addData : Form
    {
        public addData()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void addData_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Customer.GetCustomers
            .Select(c => new
            {
                // Select the properties you want to display from Customer and Account
                CustomerName = c.Naam,
                CustomerID = c.custID,
                CustomerNumber = c.custNum,
                CustomerAddress = c.Address,
                AccountNumber = c.acc.accNum,
                Balance = c.acc.balance,
                AccountName = c.acc.Holder,
                // Add other properties as needed
            }) 
             .ToList();
            dataGridView1.Refresh();

        }
        private bool signUp()
        {
            string name = textBox1.Text;
            string password = textBox2.Text;
            bool isPresent = MUser_DL.isAlreadyExists(name, password);
            if (isPresent)
            {
                string role = "customer";
                string custid = $" {MUser.users.Count + 1}  + AZ ";
                string address = textBox4.Text;
                string cNum = textBox3.Text;
                string anum = textBox5.Text;
                int aNum = int.Parse(anum);
                string holder = textBox6.Text;
                double balance = double.Parse(textBox7.Text);
                Account a1 = new Account(aNum, holder, balance);
                Bank.accounts.Add(a1);
                Customer c1 = new Customer(custid, cNum, address, a1, name, password, role);
                MUser_DL.addIntoList(c1);
                Customer.addintoCustomerList(c1);
                return true;
            }
            else
            {
                return false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool isSignUp = signUp();
            if (isSignUp)
            {
                MessageBox.Show("Data added successfully ");
                addData_Load(sender, e);
                CustomerDL.writeDatainCustomerFile();
            }
            else
            {
                MessageBox.Show(" credentials already exists ");
                return;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
