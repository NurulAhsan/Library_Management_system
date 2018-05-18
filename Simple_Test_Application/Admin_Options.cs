using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_Test_Application
{
    public partial class Admin_Options : Form
    {
        public Admin_Options()
        {
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form1 ob = new Form1();
            ob.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin_Password_Change ob = new Admin_Password_Change();
            ob.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AdminNewBookEntry ob = new AdminNewBookEntry();
            ob.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            User_Check_AV_Book us = new User_Check_AV_Book();
            us.Show();
            this.Hide();
        }
    }
}
