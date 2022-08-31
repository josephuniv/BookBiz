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
    public partial class frmClients : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BookBiz;Integrated Security=True");
        public frmClients()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && Validator.IsNumber(txtCreaditlimit.Text))
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = $"INSERT INTO Client (name,street,city,postalcode,phone,fax,creaditlimit) VALUES('{txtName.Text}','{txtStreet.Text}','{txtCity.Text}','{txtPostalcode.Text}','{txtPhone.Text}','{txtFax.Text}',{Convert.ToInt32(txtCreaditlimit.Text)})";
                cmd.ExecuteNonQuery();
                con.Close();
                disp_data();
                MessageBox.Show("Record Inserted Successfully");
                txtName.Clear(); txtStreet.Clear(); txtCity.Clear(); txtPostalcode.Clear(); txtPhone.Clear(); txtFax.Clear(); txtCreaditlimit.Clear();
            }
            else
                MessageBox.Show("Please fill the requaired filds and enter a numeric vale in the numeric filds");
        }

        public void disp_data()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Client";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridViewClient.DataSource = dt;
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
                cmd.CommandText = $"SELECT * FROM client WHERE {cmbSearchBy.SelectedItem}='{txtSearchBy.Text}'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridViewClient.DataSource = dt;
                con.Close();
            }
            else
                MessageBox.Show("Please select what to search by");
        }

        private void frmClients_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }


}
