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

namespace BookBiz
{
    public partial class frmEmployee : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BookBiz;Integrated Security=True");
        public frmEmployee()
        {
            InitializeComponent();
        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtFirstname.Text != "" && txtLastname.Text != "")
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = $"INSERT INTO employee (firstname,lastname,email,department) VALUES('{txtFirstname.Text}','{txtLastname.Text}','{txtEmail.Text}','{txtDepartment.Text}')";
                cmd.ExecuteNonQuery();
                con.Close();
                disp_data();
                MessageBox.Show("Record Inserted Successfully");
                txtFirstname.Clear(); txtLastname.Clear(); txtEmail.Clear(); txtDepartment.Clear();
            }
            else
                MessageBox.Show("Please fill the requaired filds");
        }

        public void disp_data()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM employee";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridViewEmployee.DataSource = dt;
            con.Close();
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
                cmd.CommandText = $"SELECT * FROM employee WHERE {cmbSearchBy.SelectedItem}='{txtSearchBy.Text}'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridViewEmployee.DataSource = dt;
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
