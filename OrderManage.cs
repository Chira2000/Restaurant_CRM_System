using HomePage;
using Menu;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderManage
{
    public partial class PlaceOrd : Form
    {
        public PlaceOrd()
        {
            InitializeComponent();
        }

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Janora_DB.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter ad = new OleDbDataAdapter();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            con.Open();

            

            string it1 = "INSERT INTO Ord (OrderName,OrderType,Quantity,OrderSize) VALUES (@Value1,@Value2,@Value3,@Value4)";
            cmd = new OleDbCommand(it1, con);
            cmd.Parameters.AddWithValue("@Value1", txtItem1.Text);
            cmd.Parameters.AddWithValue("@Value4", txtType.Text);
            cmd.Parameters.AddWithValue("@Value2", Qty1.Text);
            cmd.Parameters.AddWithValue("@Value3", txtradio1.Text);

            cmd.ExecuteNonQuery();
            

            

            string it2 = "INSERT INTO Ord (OrderName,OrderType,Quantity,OrderSize) VALUES (@Value1,@Value2,@Value3,@Value4)";
            cmd = new OleDbCommand(it2, con);




            cmd.Parameters.AddWithValue("@Value1", txtItem2.Text);
            cmd.Parameters.AddWithValue("@Value4", txtType.Text);
            cmd.Parameters.AddWithValue("@Value2", Qty2.Text);
            cmd.Parameters.AddWithValue("@Value3", radioButton4.Text);
            /*if (txtradio1.Checked == true)
            {
                string OrderSize = txtradio1.Text;

            }

            else 
            {
                string OrderSize = txtradio2.Text;
            }*/
            cmd.ExecuteNonQuery();

            string it3 = "INSERT INTO Ord (OrderName,OrderType,Quantity,OrderSize) VALUES (@Value1,@Value2,@Value3,@Value4)";
            cmd = new OleDbCommand(it3, con);

            cmd.Parameters.AddWithValue("@Value1", txtItem3.Text);
            cmd.Parameters.AddWithValue("@Value4", txtType.Text);
            cmd.Parameters.AddWithValue("@Value2", Qty3.Text);
            cmd.Parameters.AddWithValue("@Value3", radioButton6.Text);


            cmd.ExecuteNonQuery();



            string it4 = "INSERT INTO Ord (OrderName,OrderType,Quantity,OrderSize) VALUES (@Value1,@Value2,@Value3,@Value4)";
            cmd = new OleDbCommand(it4, con);

            cmd.Parameters.AddWithValue("@Value1", txtItem4.Text);
            cmd.Parameters.AddWithValue("@Value4", txtType.Text);
            cmd.Parameters.AddWithValue("@Value2", Qty4.Text);
            cmd.Parameters.AddWithValue("@Value3", radioButton7.Text);


            cmd.ExecuteNonQuery();


            string it5 = "INSERT INTO Ord (OrderName,OrderType,Quantity,OrderSize) VALUES (@Value1,@Value2,@Value3,@Value4)";
            cmd = new OleDbCommand(it5, con);

            cmd.Parameters.AddWithValue("@Value1", txtItem5.Text);
            cmd.Parameters.AddWithValue("@Value4", txtType.Text);
            cmd.Parameters.AddWithValue("@Value2", Qty5.Text);
            cmd.Parameters.AddWithValue("@Value3", radioButton9.Text);


            cmd.ExecuteNonQuery();





            con.Close();

            MessageBox.Show("Your Order has been Successfully Added", "Order Success!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            Homepage obj = new Homepage();
            this.Hide();
            obj.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menupage obj = new Menupage();
            this.Hide();
            obj.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new PlaceOrd().Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            txtItem1.Text = "";
            txtType.Text = "";
            Qty1.Text = "";
            txtItem2.Text = "";
            txtType.Text = "";
            Qty3.Text = "";
            txtItem3.Text = "";
            txtType.Text = "";
            Qty3.Text = "";
            txtItem4.Text = "";
            txtType.Text = "";
            Qty4.Text = "";
            txtItem5.Text = "";
            txtType.Text = "";
            Qty5.Text = "";



        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtradio1_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }

   
}
