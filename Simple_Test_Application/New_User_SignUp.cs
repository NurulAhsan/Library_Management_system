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
using System.Data.OracleClient;


namespace Simple_Test_Application
{
    public partial class New_User_SignUp : Form
    {
        public New_User_SignUp()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            usernamExistCheck();

            
            //////////////////////////////
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("Fill up all the fields");
                return;
            }

            try
            {
                connection cn = new connection();
                cn.thisConnection.Open();

                OracleCommand cmnd;

                string query;

                query = "insert into New_User_SignIn (username,password,email,mobile) values('" + textBox1.Text.ToString() + "'," + "'" + textBox2.Text.ToString() + "'," + "'" + textBox3.Text.ToString() + "'," + "'" + textBox4.Text.ToString() + "')";
                
                cmnd = new OracleCommand(query, cn.thisConnection);
                
                cmnd.ExecuteNonQuery();

                MessageBox.Show("add in database");

                cmnd.Dispose();
                
                cn.thisConnection.Close();

                cn.thisConnection.Dispose();

                Form1 ob = new Form1();
                ob.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Fill up all fields");
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            usernamExistCheck();
        }

        private void usernamExistCheck()
        {
            connection sv = new connection();
            sv.thisConnection.Open();

            OracleCommand thisCommand = sv.thisConnection.CreateCommand();

            thisCommand.CommandText = "select username from New_User_SignIn where username= '" + textBox1.Text + "'";

            thisCommand.Connection = sv.thisConnection;
            thisCommand.CommandType = CommandType.Text;

            try
            {
                OracleDataReader thisReader = thisCommand.ExecuteReader();

                while (thisReader.Read())
                {

                    string sp = thisReader["username"].ToString();


                    try
                    {
                        if (sp != "")
                        {
                            MessageBox.Show("Username Id Already exists try another username then press ok!!!");
                            sv.thisConnection.Close();
                            return;
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Failure");
                    }
                }
                thisReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Username is not Avaliable");
                return;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            User_Login ob = new User_Login();
            ob.Show();
            this.Hide();
        }
    }
}
