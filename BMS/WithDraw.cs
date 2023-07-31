using BMS.BL;
using BMS.DL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMS
{
    public partial class WithDraw : Form
    {
        int acNum;
        double balance;
        public WithDraw(int acNum, double balance)
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
        private double Amount()
        {

            double amount = double.Parse(textBox3.Text);
            if (!double.TryParse(textBox3.Text, out amount))
            {
                MessageBox.Show(" Please enter valid amount ");
                return 0;
            }
            if (amount <= 0 || amount>this.balance)
            {
                MessageBox.Show(" Please enter valid amount ");
                return 0;
            }
            return amount;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int acNo = takeAcNum();
            double amount = Amount();
            if (amount == 0)
            {
                MessageBox.Show(" Incorrect amount ");
                return;
            }
            Account account = Bank_DL.withdraw(acNo, amount);
            if (account != null)
            {
               
                label3.Text = $" Your Current Balance is PKR {account.balance} ";
                label3.Show();
                CustomerDL.writeDatainCustomerFile();
            }
            else
            {
                MessageBox.Show(" Incorrect account Number");
            }
        }

        private void WithDraw_Load(object sender, EventArgs e)
        {
            label3.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
