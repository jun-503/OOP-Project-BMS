using BMS.BL;
using BMS.DL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMS
{
    public partial class send : Form
    {
        int acNum;
        double balance;
        public send(int acNum, double balance)
        {
            InitializeComponent();
            this.acNum = acNum;
            this.balance = balance;
        }
        private int takeAcNum()
        {
            int acNo = int.Parse(textBox2.Text);

            return acNo;
        }
        private int takeAcNum1()
        {
            int acNo = int.Parse(textBox4.Text);

            return acNo;
        }
        private double Amount()
        {

            double amount = double.Parse(textBox3.Text);
            if (!double.TryParse(textBox3.Text, out amount))
            {
                MessageBox.Show(" Please enter valid amount ");
                return 0;
            }
            if (amount <= 0 || amount > this.balance)
            {
                MessageBox.Show(" Please enter valid amount ");
                return 0;
            }
            return amount;
        }
        private void send_Load(object sender, EventArgs e)
        {
            label4.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = takeAcNum();
            int num2 = takeAcNum1();
            double amount  = Amount();
            if(amount==0)
            {
                return;
            }
            if(num1==num2)
            {
                MessageBox.Show(" Incorrect account number ");
                return;
            }
            else if(num1!=num2)
            {
                Account account = Bank_DL.sendMoney(num1, amount, num2);
                if(account!=null)
                {
                    label4.Text = $" Your Current Balance is PKR {account.balance} ";
                    label4.Show();
                    CustomerDL.writeDatainCustomerFile();
                }
                else
                {
                    MessageBox.Show(" Please enter valid account numbers");
                    return;
                }
            }
        }
    }
}
