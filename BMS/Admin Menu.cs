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
    public partial class Admin_Menu : Form
    {
        string name;
        string rank;
        public Admin_Menu(string name, string rank)
        {
            InitializeComponent();
            this.name = name;
            this.rank = rank;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addData addData = new addData();
            addData.Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Admin_Menu_Load(object sender, EventArgs e)
        {
            textBox2.Multiline = true;
            textBox2.Height = textBox2.Font.Height * 2 + textBox2.Margin.Vertical;
            textBox2.AppendText("Signed in: " + this.name + Environment.NewLine);
            textBox2.AppendText("Rank: " + this.rank);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UpdateData updateData = new UpdateData();
            updateData.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DelData delData = new DelData();
            delData.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Cut cut  = new Cut();
            cut.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }
    }
}
