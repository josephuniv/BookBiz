using BookBiz.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookBiz.GUI
{
    public partial class frmSearchlist : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BookBiz;Integrated Security=True");
        public frmSearchlist()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(cmbClientname.Text != "")
            {            
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = $"SELECT * FROM Orders where client_id in (select client_id from client where name='{cmbClientname.Text}')";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridViewOrders.DataSource = dt;
                con.Close();
            }
            else
                MessageBox.Show("Please select a name");

        }

        private void btnListorders_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Orders";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridViewOrders.DataSource = dt;
            con.Close();
            cmbClientname.Text = "";
        }

        private void frmSearchlist_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand command;
            SqlDataReader dataReader;
            String sql;
            sql = "select name from client";
            command = new SqlCommand(sql, con);
            dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                cmbClientname.Items.Add(dataReader.GetValue(0));
            }
            con.Close();
        }

        private void dataGridViewOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewOrders_SelectionChanged(object sender, EventArgs e)
        {
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void btnListdetails_Click(object sender, EventArgs e)
        {
            if(txtOrderid.Text != "" && Validator.IsNumber(txtOrderid.Text))
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = $"select * from book_orders where order_id={Convert.ToInt32(txtOrderid.Text)}";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridViewDetails.DataSource = dt;
                con.Close();
            }
            else
                MessageBox.Show("Please enter a valid Order Id");

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
