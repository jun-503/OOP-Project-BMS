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

namespace BMS
{
    public partial class UpdatePassword : Form
    {
        public UpdatePassword()
        {
            InitializeComponent();
        }
        private void changePassword()
        {
            textBox1.UseSystemPasswordChar = true;
            textBox2.UseSystemPasswordChar = true;
            textBox3.UseSystemPasswordChar = true;
            string cPass = textBox1.Text;
            string cPass2 = textBox2.Text;
            string cPass3 = textBox3.Text;

        }

        private void label5_Click(object sender, EventArgs e)
        {
            changePassword();
            if (textBox2.Text != textBox3.Text) {
                MessageBox.Show(" Passwords don't Match! ");
                return;
            }
            else
            {
                bool isChanged  = CustomerDL.changePassword(textBox1.Text, textBox2.Text);
                if (isChanged)
                {
                    MessageBox.Show("Password Updated Successfully");
                    CustomerDL.writeDatainCustomerFile();
                    this.Close();
                }
                else
                {
                    MessageBox.Show(" Incorrect Password ");
                    return;
                }
            }
        }
    }
}
