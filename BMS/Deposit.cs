using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BMS.BL;
using BMS.DL;

namespace BMS
{
    public partial class Deposit : Form
    {
        int acNum;
        public Deposit(int acNum)
        {
            InitializeComponent();
            this.acNum = acNum;
        }
        private int takeAcNum()
        {
            int acNo = int.Parse(textBox2.Text);
           
            return acNo;
        }
        //private int takeAcNum()
        //{
        //    int attempts = 0;
        //    int maxAttempts = 3;
        //    int acNo = int.Parse(textBox2.Text);

        //    while (true)
        //    {
        //        if (attempts >= maxAttempts)
        //        {
        //            MessageBox.Show(" Please try again later ");
        //            this.Close();
        //            break;

        //        }

        //        if (!int.TryParse(textBox2.Text, out acNo))
        //        {
        //            label4.Show();

        //            break;
        //        }

        //        if (acNo == acNum)
        //        {
        //            break; // Exit the loop when the correct account number is entered
        //        }

        //        label4.Show();
        //        textBox2.Clear();
        //        attempts++;
        //    }

        //    return acNo;
        //}

        private double Amount()
        { 
        
            double amount  = double.Parse(textBox3.Text);
           if(!double.TryParse(textBox3.Text, out amount))
            {
                MessageBox.Show(" Please enter valid amount ");
                return 0;
            }
           if(amount<=0)
            {
                MessageBox.Show(" Please enter valid amount ");
                return 0;
            }
           return amount;
        }

        private void Deposit_Load(object sender, EventArgs e)
        {
            
            label3.Hide();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int acNo = takeAcNum();
            double amount = Amount();
            if(amount==0)
            {
                MessageBox.Show(" Incorrect amount ");
                return;
            }
            Account account = Bank_DL.Deposit(acNo, amount);
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
