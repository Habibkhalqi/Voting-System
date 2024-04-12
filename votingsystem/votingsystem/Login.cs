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

namespace votingsystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string confi = System.Configuration.ConfigurationManager.ConnectionStrings["myconstring"].ToString();
           if(txt_password.Text==txt_confirmPassword.Text)
            {
                string querry = "SELECT * FROM voters WHERE cnic = '" + txt_usercnic.Text + "' AND security = '" + txt_password.Text + "'";
                SqlConnection con = new SqlConnection(confi);
                con.Open();
                SqlCommand cmd = new SqlCommand(querry, con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    this.Hide();
                    DashBoard db = new DashBoard();
                    db.Show(this);
                }
            }
           else
            {
                MessageBox.Show("usercnic or passoword and confirm password not matching! try Again");
            }
           
        }
    }
}
