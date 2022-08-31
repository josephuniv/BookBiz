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
    public partial class frmBooks : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BookBiz;Integrated Security=True");
        public frmBooks()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtISBN.Text != "" && txtTitle.Text != "" && Validator.IsNumber(txtUnitprice.Text) && Validator.IsNumber(txtYearpublished.Text) && Validator.IsNumber(txtQoh.Text))
            {
                if (UniqueISBN(txtISBN))
                {                    
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = $"INSERT INTO book (isbn,title,unitprice,yearpublished,qoh,category)VALUES('{txtISBN.Text}','{txtTitle.Text}',{Convert.ToInt32(txtUnitprice.Text)},{Convert.ToInt32(txtYearpublished.Text)},{Convert.ToInt32(txtQoh.Text)},'{txtCategory.Text}')";
                    cmd.ExecuteNonQuery();
                    con.Close();
                    disp_data();
                    MessageBox.Show("Record Inserted Successfully");
                    txtISBN.Clear(); txtTitle.Clear(); txtUnitprice.Clear(); txtYearpublished.Clear(); txtQoh.Clear(); txtCategory.Clear();
                }
                else
                    MessageBox.Show("You must enter unique ISBN");
            }
            else
                MessageBox.Show("Please fill the requaired filds and enter a numeric vale in the numeric filds");
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            disp_data();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (cmbSearchBy.SelectedIndex != -1)
            { 
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = $"SELECT * FROM book WHERE {cmbSearchBy.SelectedItem}='{txtSearchBy.Text}'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridViewBook.DataSource = dt;
                con.Close();
            }
            else
                MessageBox.Show("Please select what to search by");
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridViewBook_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void disp_data()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM book";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridViewBook.DataSource = dt;
            con.Close();
        }

        public  bool UniqueISBN(TextBox tb)
        {            
            con.Open();
            SqlCommand command;
            SqlDataReader dataReader;
            String sql;
            sql = $"select * from book where isbn='{tb.Text}'";
            command = new SqlCommand(sql, con);
            dataReader = command.ExecuteReader();            
            if (dataReader.HasRows)
            {
                con.Close();
                return false;
            }
            else
            {
                con.Close();
                return true;
            }           
        }

        private void frmBooks_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
