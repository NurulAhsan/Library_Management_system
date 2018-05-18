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
    public partial class User_Options : Form
    {
        public User_Options()
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
            User_Password_Change ob = new User_Password_Change();
            ob.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            User_Update_Info ob = new User_Update_Info();
            ob.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            User_Check_AV_Book ob = new User_Check_AV_Book();
            ob.Show();
            this.Hide();
        }
    }
}
