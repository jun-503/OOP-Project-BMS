using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BMS.DL;
using BMS.BL;

namespace BMS
{
    public partial class Settings : Form
    {
        int accNum;
        public Settings(int accNum)
        {
            InitializeComponent();
            this.accNum = accNum;
            showData();
        }
        public Settings ()
        {
            InitializeComponent();
        }
        private void showData()
        {
         Customer c1  =  CustomerDL.findAccount(accNum);
            textBox2.Multiline = true;
            textBox2.ForeColor = Color.Black;
            textBox2.Height = textBox2.Font.Height * 6 + textBox2.Margin.Vertical;
            textBox2.AppendText(" Name:                              " + c1.Naam + Environment.NewLine);
            textBox2.AppendText(" Passowrd:                          " + "********   " + Environment.NewLine);
            textBox2.AppendText(" Contact Number:                    " + c1.custNum + Environment.NewLine);
            textBox2.AppendText(" Address:                           " + c1.Address + Environment.NewLine);
            textBox2.AppendText(" Account Number:                    " + accNum + Environment.NewLine);
            textBox2.AppendText(" Balance:                           " + c1.acc.balance + Environment.NewLine);
            

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdatePassword updatePassword = new UpdatePassword();
            updatePassword.Show();
        }
    }
}
