using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BMS.BL;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BMS
{
    public partial class CustomerMenu : Form
    {
        string name;
        int acNum;
        double balance;
        public CustomerMenu(string name,int acNum, double balance)
        {
            InitializeComponent();
            this.name = name;
            this.acNum = acNum;
            this.balance = balance;
        }

        public void CustomerMenu_Load(object sender, EventArgs e)
        {
            textBox2.Multiline = true;
            textBox2.Height = textBox2.Font.Height * 2 + textBox2.Margin.Vertical;
            textBox2.AppendText ("Signed in: " + this.name + Environment.NewLine);
            textBox2.AppendText(" Balance: " + this.balance);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Deposit deposit = new Deposit(acNum);
            deposit.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           WithDraw withDraw = new WithDraw(acNum,balance);
            withDraw.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            send send = new send(acNum,balance);
            send.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Settings s1 = new Settings(acNum);
            s1.Show();
        }
    }
}
