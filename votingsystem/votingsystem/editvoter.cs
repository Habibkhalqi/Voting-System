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
    public partial class editvoter : Form
    {
        string confi = System.Configuration.ConfigurationManager.ConnectionStrings["myconstring"].ToString();
        public editvoter()
        {
            InitializeComponent();
        }

        private void editvoter_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'voting_systemDataSet6.voters' table. You can move, or remove it, as needed.
            this.votersTableAdapter.Fill(this.voting_systemDataSet6.voters);

        }

        private void cmb_editname_SelectedIndexChanged(object sender, EventArgs e)
        {
            string querry = "select * from voters where vname = '" + cmb_editname.Text + "'";
            SqlConnection con = new SqlConnection(confi);
            con.Open();
            SqlCommand cmd = new SqlCommand(querry, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txt_address.Text = dr["address"].ToString();
                txt_cnic.Text = dr["cnic"].ToString();
                txt_contact.Text = dr["contact"].ToString();
                txt_dob.Text = dr["dob"].ToString();
                txt_eligibilty.Text = dr["eligiblity"].ToString();
                txt_security.Text= dr["security"].ToString();
                
            }

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            string querrry = "update voters set vname='" + cmb_editname.Text + "',address='" + txt_address.Text + "',contact='"+txt_contact.Text+"',dob='"+txt_dob.Text+ "',eligiblity='"+txt_eligibilty.Text+ "',security='"+txt_security.Text+"' where cnic='"+txt_cnic.Text+"'";
            SqlConnection con = new SqlConnection(confi);
            con.Open();
            SqlCommand cmd = new SqlCommand(querrry, con);  
            cmd.ExecuteNonQuery();
            MessageBox.Show("Update Record Successfully!!");
            foreach (var item in this.Controls)
            {
                if(item is TextBox)
                {
                    TextBox txt = (TextBox)item;
                    txt.Clear();
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string querry = "delete from voters where vname='" + cmb_editname.Text + "'";
            SqlConnection con = new SqlConnection(confi);
            con.Open();
            SqlCommand cmd = new SqlCommand(querry, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Delete Record Successfully");
            foreach (var item in this.Controls)
            {
                if (item is TextBox)
                {
                    TextBox txt = (TextBox)item;
                    txt.Clear();
                }
            }
        }
    }
}
