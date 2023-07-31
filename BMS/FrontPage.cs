using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace BMS
{
    public partial class FrontPage : Form
    {
        public FrontPage()
        {
            InitializeComponent();
            // showForm1();
            Icon = Properties.Resources.bankIcon;
        }

        private void FrontPage_Load(object sender, EventArgs e)
        {
            
            
        }
        private void showForm1()
        {
            Thread.Sleep(4000);
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void Form_Load(object sender, EventArgs e)
        {

            Form1 form1 = new Form1();
            form1.Show();
            
        }
    }
}
