using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookBiz.GUI
{
    public partial class frmMainSales : Form
    {
        public frmMainSales()
        {
            InitializeComponent();
        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            Form frm = new frmClients();
            frm.ShowDialog();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show("Are you sure to exit the application?", "Confirmation",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (answer == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {

        }
    }
}
