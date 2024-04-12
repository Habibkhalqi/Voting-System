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
    public partial class Voterregsiter : Form
    {
        public Voterregsiter()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string confi = System.Configuration.ConfigurationManager.ConnectionStrings["myconstring"].ToString();
           
            string query = "INSERT INTO voters VALUES('" + txt_name.Text + "','" + txt_dob.Text + "','" + txt_address.Text + "','" + txt_contact.Text + "','" + txt_cnic.Text + "','" + txt_eligibilty.Text + "','"+txt_security.Text+"')";
            SqlConnection con = new SqlConnection(confi);
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record Save Successfully!!");
            foreach (var item in this.Controls)
            {
                if (item is TextBox)
                {
                    TextBox tb = (TextBox)item;
                    tb.Clear();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var item in this.Controls)
            {
                if(item is TextBox)
                {
                    TextBox tb = (TextBox)item;
                    tb.Clear();
                }
            }
        }
    }
}
