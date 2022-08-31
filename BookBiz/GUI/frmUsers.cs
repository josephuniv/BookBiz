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
    
    public partial class frmUsers : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BookBiz;Integrated Security=True");
        public frmUsers()
        {
            InitializeComponent();
        }

        private void lblFirstname_Click(object sender, EventArgs e)
        {

        }

        private void lblLastName_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text != "" && txtPassword.Text != "" && cmbPrivilege.Text != "")
            {
                if (UniqueISBN(txtUsername))
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = $"INSERT INTO users (username,password,privilege)VALUES('{txtUsername.Text}','{txtPassword.Text}','{cmbPrivilege.Text}')";
                    cmd.ExecuteNonQuery();
                    con.Close();
                    disp_data();
                    MessageBox.Show("Record Inserted Successfully");
                    txtUsername.Clear(); txtPassword.Clear(); cmbPrivilege.Text = "";
                }
                else
                    MessageBox.Show("You must enter unique Username");
            }
            else
                MessageBox.Show("Please fill the requaired filds");
        }

        public void disp_data()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM users";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridViewUser.DataSource = dt;
            con.Close();
        }

        public bool UniqueISBN(TextBox tb)
        {
            con.Open();
            SqlCommand command;
            SqlDataReader dataReader;
            String sql;
            sql = $"select * from users where username='{tb.Text}'";
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
                cmd.CommandText = $"SELECT * FROM users WHERE {cmbSearchBy.SelectedItem}='{txtSearchBy.Text}'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridViewUser.DataSource = dt;
                con.Close();
            }
            else
                MessageBox.Show("Please select what to search by");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
