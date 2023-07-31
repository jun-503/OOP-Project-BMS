using BMS.BL;
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

namespace BMS
{
    public partial class DelData : Form
    {
        public DelData()
        {
            InitializeComponent();
        }

        private void DelData_Load(object sender, EventArgs e)
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
        private Customer deleteData()
        {
            string id = textBox1.Text;
            foreach(MUser user in MUser.users)
            {
                if(user is Customer c1)
                {
                    if(c1.custID == id)
                    {
                      
                        return c1;
                    }
                }
            }
            return null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Customer c1 = deleteData();
            if(c1!=null)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to proceed?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    MUser.users.Remove(c1);
                    Customer.GetCustomers.Remove(c1);
                    Bank.accounts.Remove(c1.acc);
                    DelData_Load(sender, e);
                    CustomerDL.writeDatainCustomerFile();

                }
                else
                {
                    return;
                }
            }
            else
            {
                MessageBox.Show(" No record Exists ");
                return;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
