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
using BMS.UI;
using System.Threading;

namespace BMS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            FrontPage frontPage = new FrontPage();
            frontPage.Close();
            bool check = CustomerDL.readCustomerData();
            bool check1 = EmployeeDL.readEmployeeData();
            if (check && check1)
            {
                MessageBox.Show(" Data Loaded Succcessfully");
            }
            else
            {
                MessageBox.Show(" Error Loading Data ");
            }
        }
        private MUser signin()
        {
            string name = textBox1.Text;
            textBox2.UseSystemPasswordChar = true;
            string password = textBox2.Text; 
            
            MUser user = MUser_DL.signIn(name, password);
            return user;
        }
        private void clearSignIn()
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {
            MUser user = signin();
            if(user!=null)
            {
                if (user.role =="customer")
                {
                    if (user is Customer c1)
                    {
                        clearSignIn();
                        CustomerMenu customerMenu = new CustomerMenu(c1.Naam,c1.acc.accNum,c1.acc.balance);

                        customerMenu.Show(this);
                    }
                    
                }
                else if(user.role =="employee")
                {
                    if (user is Employee e1)
                    {
                        clearSignIn();
                        Admin_Menu adminMenu = new Admin_Menu(e1.Naam, e1.Rank);
                        adminMenu.Show(this);
                    }
                }
              
            }
            else
            {
                MessageBox.Show("Account Not Found");
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void signUp_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked==true)
            {
                SignupForm form = new SignupForm();
                form.Show();
                checkBox1.Checked = false;
            }
            else if(checkBox2.Checked==true) {
                Cust_Sign_Up cust_Sign_Up = new Cust_Sign_Up();
                cust_Sign_Up.Show();
                checkBox2.Checked = false;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
