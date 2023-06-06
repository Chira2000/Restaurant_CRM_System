using CustomerLogin;
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

namespace CustomerRegister
{
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Janora_DB.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter ad = new OleDbDataAdapter();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" && txtMobile.Text == "")
            {
                MessageBox.Show("Username or Mobile Empty", "Registeration Failed!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else 
            {
                con.Open();
                string register = "INSERT INTO Customers (Username,Mobile) VALUES('" + txtUsername.Text + "','" + txtMobile.Text + "')";
                cmd = new OleDbCommand(register, con);
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Your Account has been Successfully Created", "Registration Success!", MessageBoxButtons.OK, MessageBoxIcon.None);
            } 

            /*else
            {
                MessageBox.Show("Password or Username Does Not Match Please Re-enter", "Registration Failed!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txtUsername.Text = "";
                txtMobile.Text = "";
                txtMobile.Focus();
            }*/
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtMobile.Text = "";
            txtMobile.Focus();

        }

        private void txtMobile_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            CustomerLog obj = new CustomerLog();
            this.Hide();
            obj.Show();

        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }

