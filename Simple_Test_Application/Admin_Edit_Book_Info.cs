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
    public partial class Admin_Edit_Book_Info : Form
    {
        public Admin_Edit_Book_Info()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox6.Text = "";
            textBox2.Text = "";
            comboBox2.Text = "";
            dateTimePicker1.Text = "";
            textBox3.Text = "";

            if (textBox4.Text == "" || cb_searchby.Text == "")
            {
                MessageBox.Show("Fill Up all fields then press ok...");
                return;
            }

            connection CN = new connection();
            CN.thisConnection.Open();

            OracleCommand thisCommand = CN.thisConnection.CreateCommand();

            thisCommand.CommandText =
            "SELECT * FROM bookstore where  " + cb_searchby.Text + "= '" + textBox4.Text + "'";

            //where " + cb_searchby.Text + " like'%" + textBox1.Text + "%'order by BookId");

            OracleDataReader thisReader = thisCommand.ExecuteReader();


            while (thisReader.Read())
            {

                textBox1.Text = thisReader["BookName"].ToString();
                textBox6.Text = thisReader["BookPublishYear"].ToString();
                textBox2.Text = thisReader["WriterName"].ToString();
                comboBox2.Text = thisReader["CatagoryName"].ToString();
                dateTimePicker1.Text = thisReader["EntryDate"].ToString();
                textBox3.Text = thisReader["QuantityOfBook"].ToString();


                try
                {
                     //string filePath = thisReader["picture"].ToString();
                     //this.pb_profilepics.Image = Image.FromFile(filePath);
                }
                catch
                { MessageBox.Show("successfull"); }


            }


            CN.thisConnection.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox5.Text == "")
            {
                MessageBox.Show("Fill Up all fields then press update...");
                return;
            }
            connection sv = new connection();
            sv.thisConnection.Open();
            int newItems = int.Parse(textBox5.Text);

            if (textBox5.Text == "")
                newItems = 0;

            OracleCommand thisCommand = sv.thisConnection.CreateCommand();

            thisCommand.CommandText = "update bookstore set AvaliableBook=AvaliableBook+" + newItems + ",QuantityOfBook=QuantityOfBook+" + newItems + " where BookName= '" + textBox1.Text + "'";

            thisCommand.Connection = sv.thisConnection;
            thisCommand.CommandType = CommandType.Text;

            try
            {                
                thisCommand.ExecuteNonQuery();
                MessageBox.Show("Stock Updated Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Book is not Avaliable");
                return;
            }

            Admin_Options ob = new Admin_Options();
            ob.Show();
            this.Hide();
        }

        private void butCancel_Click(object sender, EventArgs e)
        {
            AdminNewBookEntry ob = new AdminNewBookEntry();
            ob.Show();
            this.Hide();
        }

        private void cb_searchby_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
