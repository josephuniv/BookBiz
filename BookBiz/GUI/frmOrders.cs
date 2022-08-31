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
    public partial class frmOrders : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BookBiz;Integrated Security=True");
        public frmOrders()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void frmOrders_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand command;
            SqlDataReader dataReader;
            String sql;
            sql = "select client_id from client";
            command = new SqlCommand(sql, con);
            dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                cmbClientid.Items.Add(dataReader.GetValue(0));                
            }
            con.Close();

            con.Open();
            SqlCommand command2;
            SqlDataReader dataReader2;
            String sql2;
            sql2 = "select book_id, unitprice from book";
            command2 = new SqlCommand(sql2, con);
            dataReader2 = command2.ExecuteReader();
            while (dataReader2.Read())
            {
                cmbBookid.Items.Add(dataReader2.GetValue(0));                
            }
            con.Close();

            con.Open();
            SqlCommand command3;
            SqlDataReader dataReader3;
            String sql3;
            sql3 = "select order_id from orders";
            command3 = new SqlCommand(sql3, con);
            dataReader3 = command3.ExecuteReader();
            while (dataReader3.Read())
            {
                cmbOrderid.Items.Add(dataReader3.GetValue(0));
            }
            con.Close();

        }

        private void btnAdditem_Click(object sender, EventArgs e)
        {
            if(cmbClientid.Text != "" && cmbBookid.Text != "" && Validator.IsNumber(nudQuantity.Value.ToString()) && Validator.IsNumber(cmbClientid.Text) && Validator.IsNumber(cmbBookid.Text))
            { 
                lstBookid.Items.Add(cmbBookid.Text);
                lstQuantity.Items.Add(nudQuantity.Value);

                con.Open();
                SqlCommand command;
                SqlDataReader dataReader;
                String sql;
                sql = $"select unitprice from book where book_id={cmbBookid.Text}";
                command = new SqlCommand(sql, con);
                dataReader = command.ExecuteReader();
                dataReader.Read();
                lstUnitprice.Items.Add(dataReader.GetValue(0));            

                lstPrice.Items.Add(nudQuantity.Value * Convert.ToDecimal(dataReader.GetValue(0).ToString()));
                txtTotal.Text = Convert.ToString(Convert.ToDecimal(txtTotal.Text)+ (nudQuantity.Value * Convert.ToDecimal(dataReader.GetValue(0).ToString())));                
                cmbBookid.Text = "";
                nudQuantity.Value = 1;
                con.Close();
            }
            else
                MessageBox.Show("Please enter a valid data");
        }

        private void btnPlaceorder_Click(object sender, EventArgs e)
        { 
            if(lstBookid.Items.Count > 0)
            {            
                con.Open();

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = $"INSERT INTO orders (totalprice,client_id)VALUES({Convert.ToDecimal(txtTotal.Text)},{Convert.ToInt32(cmbClientid.Text)})";  //{System.DateTime.Today},
                cmd.ExecuteNonQuery();
                con.Close();

                con.Open();
                SqlCommand command4;
                SqlDataReader dataReader4;
                String sql;
                sql = $"select max(order_id) from orders";
                command4 = new SqlCommand(sql, con);
                dataReader4 = command4.ExecuteReader();
                dataReader4.Read();
                int temp = Convert.ToInt32(dataReader4.GetValue(0));
                con.Close();

                con.Open();
                SqlCommand cmd2 = con.CreateCommand();
                cmd2.CommandType = CommandType.Text;
                for (int i=0; i< lstBookid.Items.Count; i++)
                {
                    cmd2.CommandText = $"INSERT INTO book_orders (book_id,order_id,quantity,price)VALUES({Convert.ToInt32(lstBookid.Items[i].ToString())},{temp},{Convert.ToInt32(lstQuantity.Items[i].ToString())},{Convert.ToInt32(lstPrice.Items[i].ToString())})";
                    cmd2.ExecuteNonQuery();
                }
                con.Close();
                lstBookid.Items.Clear();
                lstQuantity.Items.Clear();
                lstUnitprice.Items.Clear();
                lstPrice.Items.Clear();
                cmbClientid.Text = "";
                txtTotal.Text = "0";
                MessageBox.Show("Record Inserted Successfully");
            }
            else
                MessageBox.Show("You must add an order");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnCancelorder_Click(object sender, EventArgs e)
        {
            if(cmbOrderid.Text != "" && Validator.IsNumber(cmbOrderid.Text) )
            { 
                DialogResult answer = MessageBox.Show("Are you Sure that you want cancel?", "Confirmation",
                                                       MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (answer == DialogResult.Yes)
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = $"delete from orders where order_id={Convert.ToInt32(cmbOrderid.Text)}";
                    cmd.ExecuteNonQuery();                
                    con.Close();

                    con.Open();
                    SqlCommand cmd2 = con.CreateCommand();
                    cmd2.CommandType = CommandType.Text;
                    cmd2.CommandText = $"delete from Book_orders where order_id={Convert.ToInt32(cmbOrderid.Text)}";
                    cmd2.ExecuteNonQuery();                
                    con.Close();

                    MessageBox.Show("Order Canceled");

                }               
            }
            else
                    MessageBox.Show("Please select a valid Order Id to cancel");
        }

        private void btnSearchlist_Click(object sender, EventArgs e)
        {
            Form frm = new frmSearchlist();
            frm.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
