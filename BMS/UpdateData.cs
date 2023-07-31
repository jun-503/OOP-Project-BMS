using BMS.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMS
{
    public partial class UpdateData : Form
    {
        int index;
        public UpdateData()
        {
            InitializeComponent();
        }

        private void UpdateData_Load(object sender, EventArgs e)
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[index];
            textBox1.Text = row.Cells[0].Value.ToString();
            textBox2.Text = row.Cells[1].Value.ToString();
            textBox3.Text = row.Cells[2].Value.ToString();
            textBox4.Text = row.Cells[3].Value.ToString();
            textBox5.Text = row.Cells[4].Value.ToString();
            textBox6.Text = row.Cells[6].Value.ToString();
            textBox7.Text = row.Cells[5].Value.ToString();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            

            DataGridViewRow newData = dataGridView1.Rows[index];
            
            newData.Cells[0].Value = textBox1.Text;
            newData.Cells[1].Value = textBox2.Text;
            newData.Cells[2].Value = textBox3.Text;
            newData.Cells[3].Value = textBox4.Text;
            newData.Cells[4].Value = textBox5.Text;
            newData.Cells[5].Value = textBox7.Text;
            newData.Cells[6].Value = textBox6.Text;
            dataGridView1.Refresh();

        }
    }
}
