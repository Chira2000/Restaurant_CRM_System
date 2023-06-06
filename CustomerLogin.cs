using Menu;
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
using CustomerRegister;


namespace CustomerLogin
{
    public partial class CustomerLog : Form
    {
        public CustomerLog()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Janora_DB.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter ad = new OleDbDataAdapter();

        private void label6_Click(object sender, EventArgs e)
        {
            new Customer().Show();
            this.Hide();
           

        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string login = "SELECT * FROM Customers WHERE Mobile= '" + txtMobile.Text + "'";
            cmd = new OleDbCommand(login, con);
            OleDbDataReader dr = cmd.ExecuteReader();


            if (dr.Read() == true)
            {
                new Menu.Menupage().Show();
                this.Hide();


                this.Hide();
            }

            else
            {
                MessageBox.Show("Invalid Mobile Number Try Again", "Login Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                txtMobile.Text = "";
                txtMobile.Focus();
               




            }

            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtMobile.Text = "";
        }

        private void txtMobile_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
