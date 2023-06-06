using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using Menu;

namespace HomePage
{
    public partial class OrdManage : Form
    {
        public OrdManage()
        {
            InitializeComponent();
        }

        void GetOrderDetails()
        {

            OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Janora_DB.mdb");
            OleDbCommand cmd = new OleDbCommand();
            DataTable dt = new DataTable();
            OleDbDataAdapter ad = new OleDbDataAdapter("SELECT * FROM Ord",con);
            con.Open();
            ad.Fill(dt);
            dgwOrder.DataSource = dt;
            con.Close();
            

        }

        private void OrdManage_Load(object sender, EventArgs e)
        {
            GetOrderDetails();
        }

        private void txtItem1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
           
           
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Janora_DB.mdb");
            OleDbCommand cmd = new OleDbCommand();
            string query = "INSERT INTO Ord (OrderName,OrderType,Quantity,OrderSize) VALUES (@Value1,@Value2,@Value3,@Value4)";
            cmd = new OleDbCommand(query, con);
            cmd.Parameters.AddWithValue("@Value1", txtItem.Text);
            cmd.Parameters.AddWithValue("@Value4", txtTypee.Text);
            cmd.Parameters.AddWithValue("@Value2", Qty.Text);
            cmd.Parameters.AddWithValue("@Value3", txtradio.Text);

            con.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Order Added Successfullly!");
            con.Close();
            GetOrderDetails();


        }

        private void button5_Click(object sender, EventArgs e)
        {

            OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Janora_DB.mdb");
            OleDbCommand cmd = new OleDbCommand();
            string query = "UPDATE Ord SET OrderName=@Value1,OrderType=@Value2,Quantity=@Value3,OrderSize=@Value4 WHERE ID=@id";
            cmd = new OleDbCommand(query, con);
            cmd.Parameters.AddWithValue("@Value1", txtItem.Text);
            cmd.Parameters.AddWithValue("@Value4", txtTypee.Text);
            cmd.Parameters.AddWithValue("@Value2", Qty.Text);
            cmd.Parameters.AddWithValue("@Value3", txtradio.Text);
            cmd.Parameters.AddWithValue("@id",Convert.ToInt32(id.Text));

            con.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Order Updated Successfullly!");
            con.Close();
            GetOrderDetails();
        }

        private void dgwOrder_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            id.Text = dgwOrder.CurrentRow.Cells[0].Value.ToString();
            txtItem.Text = dgwOrder.CurrentRow.Cells[1].Value.ToString();
            txtTypee.Text = dgwOrder.CurrentRow.Cells[2].Value.ToString();
            Qty.Text = dgwOrder.CurrentRow.Cells[3].Value.ToString();
            txtradio.Text = dgwOrder.CurrentRow.Cells[4].Value.ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Janora_DB.mdb");
            OleDbCommand cmd = new OleDbCommand();
            string query = "DELETE FROM Ord WHERE id=@id";
            cmd = new OleDbCommand(query, con);
           
            cmd.Parameters.AddWithValue("@id", Convert.ToInt32(id.Text));

            con.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Order Deleted Successfullly!");
            con.Close();
            GetOrderDetails();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Menupage().Show();
            this.Hide();
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            new Homepage().Show();
            this.Hide();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
