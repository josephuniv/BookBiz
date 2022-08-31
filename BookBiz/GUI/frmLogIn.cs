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
    public partial class frmLogIn : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BookBiz;Integrated Security=True");
        public frmLogIn()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtUsername.Text !="" && txtPassword.Text != "" )
            {
                con.Open();
                SqlCommand command;
                SqlDataReader dataReader;
                String sql;
                sql = $"select privilege from users where username='{txtUsername.Text}' and password='{txtPassword.Text}'";
                command = new SqlCommand(sql, con);
                dataReader = command.ExecuteReader();
                int p=0;
                if (dataReader.HasRows)
                {
                    dataReader.Read();                
                    switch(dataReader.GetString(0))
                    {
                        case "MIS":
                            p = 1; 
                            break;
                        case "Sales":
                            p = 2;
                            break;
                        case "Inventory":
                            p = 3;
                            break;
                        case "Order":
                            p = 4;
                            break;
                    }                
                }
                else
                    MessageBox.Show("Invalid Username or Password");
                con.Close();
                if (p==1)
                {
                    Form frm = new frmMainMIS();                    
                    frm.ShowDialog();
                }
                else if (p == 2)
                {
                    Form frm = new frmMainSales();                    
                    frm.ShowDialog();
                }
                else if (p == 3)
                {
                    Form frm = new frmMainInventory();                    
                    frm.ShowDialog();
                }
                else if (p == 4)
                {
                    Form frm = new frmMainOrder();                    
                    frm.ShowDialog();
                }
            }
            else
                MessageBox.Show("Please enter the Username and Password");
            
        }

        private void frmLogIn_Load(object sender, EventArgs e)
        {
            
        }

        private void frmLogIn_Activated(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
        }
    }
}
