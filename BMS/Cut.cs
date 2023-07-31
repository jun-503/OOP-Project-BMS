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
    public partial class Cut : Form
    {
        public Cut()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        
            
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
            label4.Font = new Font(label4.Font.FontFamily, label4.Font.Size - 2, label4.Font.Style);
            label4.BorderStyle = BorderStyle.None;
        }

        private void label4_MouseEnter(object sender, EventArgs e)
        {
            Cursor= Cursors.Hand;
            label4.Font = new Font(label4.Font.FontFamily, label4.Font.Size + 2, label4.Font.Style);
            label4.BorderStyle = BorderStyle.FixedSingle;
            

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            double amount = double.Parse(textBox1.Text);
            if (amount <= 0)
            {
                MessageBox.Show(" Enter Valid Amount ");
                return;
            }

            string message = textBox2.Text;
            bool isCut = EmployeeDL.cuttingDown(amount);
            if (isCut)
            {
                MessageBox.Show(" Amount reducted Successfully ");
                CustomerDL.writeDatainCustomerFile();
                this.Close();
            }
            else
            {
                MessageBox.Show(" No customer have amount greater than 10000 ");
                this.Close();
            }
        }
    }
}
