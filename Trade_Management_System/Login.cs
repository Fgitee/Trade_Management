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

namespace Trade_Management_System
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Login_Click(object sender, EventArgs e)
        {
            //this checks the login username and password
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-T8QF771;Initial Catalog=Trade_Management_System;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM [dbo].[tblLogin] WHERE Username = '" + txtUsername.Text + "' and Password = '" + txtPassword.Text + "'", con);
            DataTable ta = new DataTable();
            sda.Fill(ta);
            if (ta.Rows.Count == 1)
            {
                this.Hide();
                TradeMain Main = new TradeMain();
                Main.Show();
            }
            else
            {
                MessageBox.Show("Invalid username or password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnClear_Click(sender, e);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Clear();
            txtUsername.Focus();
        }
    }
}
