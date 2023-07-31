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
using BMS;


namespace BMS
{
    public partial class SignupForm : Form
    {
        public SignupForm()
        {
            InitializeComponent();
        }

        private void SignupForm_Load(object sender, EventArgs e)
        {
           
        }
        private string signUp()
        {
            string name = textBox1.Text;
            string password = textBox2.Text;
            if(name!="" && password!="")
            {
                bool isPresent = MUser_DL.isAlreadyExists(name, password);
                if (isPresent)
                {


                    string role = "employee";
                    string empID = $"{MUser.users.Count + 1}EZ";
                    string rank = textBox4.Text;
                    string email = textBox7.Text;
                    string num = textBox5.Text;
                    Employee e1 = new Employee(name, password, role, empID, rank, email, num);
                    MUser_DL.addIntoList(e1);
                    Employee.addIntoList(e1);

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
          string message = signUp();
            if (message=="ok")
            {
                MessageBox.Show("SignUp Successfully");
                EmployeeDL.writeDatainEmployeeFile();
                Close();
            }
            else if(message=="already exists")
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
