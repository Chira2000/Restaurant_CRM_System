using EmployeePage;
using Menu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CustomerLogin;
using CustomerRegister;


namespace HomePage
{
    public partial class Homepage : Form
    {
        public Homepage()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Customer().Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            new Menupage().Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            new CustomerLog().Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new AdminPage().Show();
            this.Hide();
        }
    }
}
