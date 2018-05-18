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
    public partial class AdminNewBookEntry : Form
    {
        public AdminNewBookEntry()
        {
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Admin_Options ob = new Admin_Options();
            ob.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            connection sv = new connection();
            sv.thisConnection.Open();

            OracleCommand thisCommand = sv.thisConnection.CreateCommand();

            thisCommand.CommandText = "select BookId from bookstore where BookId= '" + textBox4.Text + "'";

            thisCommand.Connection = sv.thisConnection;
            thisCommand.CommandType = CommandType.Text;

            try
            {
                OracleDataReader thisReader = thisCommand.ExecuteReader();

                while (thisReader.Read())
                {

                    string sp = thisReader["BookId"].ToString();


                    try
                    {
                        if (sp != "")
                        {
                            MessageBox.Show("Book Id Already exists try another code then press ok!!!");
                            sv.thisConnection.Close();
                            // textBox3.Text = "";
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
                MessageBox.Show(ex.ToString());
                return;
            }


            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || comboBox2.Text == "")
            {
                MessageBox.Show("Fill up fields then press ok");
                return;
            }



            OracleDataAdapter thisAdapter = new OracleDataAdapter("SELECT * FROM bookstore", sv.thisConnection);

            OracleCommandBuilder thisBuilder = new OracleCommandBuilder(thisAdapter);

            DataSet thisDataSet = new DataSet();
            thisAdapter.Fill(thisDataSet, "bookstore");

            DataRow thisRow = thisDataSet.Tables["bookstore"].NewRow();
            try
            {
                thisRow["BookId"] = textBox4.Text;
                thisRow["BookName"] = textBox1.Text;
                thisRow["BookPublishYear"] = textBox5.Text;
                thisRow["WriterName"] = textBox2.Text;
                thisRow["QuantityOfBook"] = textBox3.Text;
                thisRow["CatagoryName"] = comboBox2.Text;
                thisRow["EntryDate"] = dateTimePicker1.Value.Date.ToString();     //dateTimePicker1.Value.Year.ToString();
                thisRow["AvaliableBook"] = textBox3.Text;
                thisRow["SaleBook"] = 0;

                thisDataSet.Tables["bookstore"].Rows.Add(thisRow);



                thisAdapter.Update(thisDataSet, "bookstore");


                MessageBox.Show("Add");


                Admin_Options ob = new Admin_Options();
                ob.Show();
                this.Hide();
            }


            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Fill up all fields");
            }
            sv.thisConnection.Close();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Admin_Edit_Book_Info ob = new Admin_Edit_Book_Info();
            ob.Show();
            this.Hide();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
