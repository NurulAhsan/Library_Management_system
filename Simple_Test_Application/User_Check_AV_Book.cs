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
    public partial class User_Check_AV_Book : Form
    {
        public User_Check_AV_Book()
        {
            InitializeComponent();
        }

        private void User_Check_AV_Book_Load(object sender, EventArgs e)
        {
           

        }

        private void back_Click(object sender, EventArgs e)
        {
            User_Options ob = new User_Options();
            ob.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {

                if (cb_searchby.Text == "AvaliableBook")
                {

                }
                else if (cb_searchby.Text == "" || textBox1.Text == "")
                {
                    MessageBox.Show("Fill up fields then press ok");
                    return;
                }

                if (cb_searchby.SelectedIndex != 0)
                {
                    connection CN = new connection();
                    CN.thisConnection.Open();



                    OracleCommand thisCommand = new OracleCommand("select BookId,BookName,WriterName,BookPublishYear,QuantityOfBook,CatagoryName,AvaliableBook from bookstore where " + cb_searchby.Text + " like'%" + textBox1.Text + "%'order by BookName");

                    thisCommand.Connection = CN.thisConnection;
                    thisCommand.CommandType = CommandType.Text;

                    OracleDataReader thisReader = thisCommand.ExecuteReader();

                    listView1.Items.Clear();

                    while (thisReader.Read())
                    {

                        ListViewItem lsvItem = new ListViewItem();
                        lsvItem.Text = thisReader["BookId"].ToString();
                        lsvItem.SubItems.Add(thisReader["BookName"].ToString());
                        lsvItem.SubItems.Add(thisReader["WriterName"].ToString());
                        lsvItem.SubItems.Add(thisReader["BookPublishYear"].ToString());
                        lsvItem.SubItems.Add(thisReader["QuantityOfBook"].ToString());
                        lsvItem.SubItems.Add(thisReader["CatagoryName"].ToString());
                        lsvItem.SubItems.Add(thisReader["AvaliableBook"].ToString());

                        listView1.Items.Add(lsvItem);
                    }



                    // thisCommand.Dispose();

                    CN.thisConnection.Close();
                }

            }
            catch (Exception dx)
            {
                MessageBox.Show(dx.ToString());
            }
        }

        private void cb_searchby_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_searchby.SelectedIndex == 0)
            {
                textBox1.Text = "";

                connection CN = new connection();
                CN.thisConnection.Open();



                OracleCommand thisCommand = new OracleCommand("select BookId,BookName,WriterName,BookPublishYear,QuantityOfBook,CatagoryName,AvaliableBook from bookstore where AvaliableBook>0");

                thisCommand.Connection = CN.thisConnection;
                thisCommand.CommandType = CommandType.Text;

                OracleDataReader thisReader = thisCommand.ExecuteReader();

                listView1.Items.Clear();

                while (thisReader.Read())
                {

                    ListViewItem lsvItem = new ListViewItem();
                    lsvItem.Text = thisReader["BookId"].ToString();
                    lsvItem.SubItems.Add(thisReader["BookName"].ToString());
                    lsvItem.SubItems.Add(thisReader["WriterName"].ToString());
                    lsvItem.SubItems.Add(thisReader["BookPublishYear"].ToString());
                    lsvItem.SubItems.Add(thisReader["QuantityOfBook"].ToString());
                    lsvItem.SubItems.Add(thisReader["CatagoryName"].ToString());
                    lsvItem.SubItems.Add(thisReader["AvaliableBook"].ToString());

                    listView1.Items.Add(lsvItem);
                }



                // thisCommand.Dispose();

                CN.thisConnection.Close();

            }
        }

        private void butCancel_Click(object sender, EventArgs e)
        {
            Admin_Options ados = new Admin_Options();
            ados.Show();
            this.Hide();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
