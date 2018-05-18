using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_Test_Application
{
    public partial class User_Update_Info : Form
    {
        public User_Update_Info()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            connection sv = new connection();
            sv.thisConnection.Open();
            OracleCommand thisCommand = sv.thisConnection.CreateCommand();

            thisCommand.CommandText = "update New_User_SignIn set email = '" + textBox1.Text + "',mobile= '" + textBox2.Text + "'where password= '" + textBox3.Text + "'";

            thisCommand.Connection = sv.thisConnection;
            thisCommand.CommandType = CommandType.Text;



            try
            {
                int a = thisCommand.ExecuteNonQuery();
                if (a == 1)
                    MessageBox.Show("Updated Successfully");
                else
                {
                    MessageBox.Show("Not Updated...Insert your old Password Perfectly");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Not Updated");
            }

            sv.thisConnection.Close();
            this.Close();

            User_Options ob = new User_Options();
            ob.Show();
            this.Hide();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = "";
                textBox2.Text = "";
                button6.Enabled = false;

                connection CN = new connection();
                CN.thisConnection.Open();

                OracleCommand thisCommand = CN.thisConnection.CreateCommand();

                thisCommand.CommandText =
                "SELECT * FROM New_User_SignIn where password= '" + textBox3.Text + "'";

                OracleDataReader thisReader = thisCommand.ExecuteReader();


                while (thisReader.Read())
                {

                    textBox1.Text = thisReader["email"].ToString();
                    textBox2.Text = thisReader["mobile"].ToString();


                }
                if (textBox1.Text != "")
                    button6.Enabled = true;

                CN.thisConnection.Close();
            }
            catch (Exception ex)
            {
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            User_Options ob = new User_Options();
            ob.Show();
            this.Hide();
        }
    }
    
    
}
