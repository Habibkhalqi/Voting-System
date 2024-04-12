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
    public partial class editcandidate : Form
    {
        public editcandidate()
        {
            InitializeComponent();
        }
        string confi = System.Configuration.ConfigurationManager.ConnectionStrings["myconstring"].ToString();
        private void editcandidate_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'voting_systemDataSet4.candidate' table. You can move, or remove it, as needed.
            this.candidateTableAdapter.Fill(this.voting_systemDataSet4.candidate);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            string squery = "Select * from candidate where cname='" + cmb_editname.Text + "'";
            SqlConnection con = new SqlConnection(confi);
            con.Open();
            SqlCommand cmd = new SqlCommand(squery, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if(dr.Read())
            {
                txt_CCNIC.Text = dr["cnic"].ToString();
                txt_affiliation.Text = dr["affiliation"].ToString() ;
                txt_biogram.Text = dr["biography"].ToString();
                txt_contafct.Text = dr["contact"].ToString();
                cmb_constituency.Text = dr["constituency"].ToString();
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string updatequerry = "UPDATE candidate set cname = '" + cmb_editname.Text + "',cnic='"+txt_CCNIC.Text+"',affiliation = '"+txt_affiliation.Text+ "',biography='"+txt_biogram.Text+ "',contact='"+txt_contafct.Text+ "',constituency='"+cmb_constituency.Text+"'";
            SqlConnection con = new SqlConnection(confi);
            con.Open();
            SqlCommand cmd = new SqlCommand(updatequerry,con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Update Record Successfully");
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
            string deltequery = "DELETE FROM candidate where cname = '" + cmb_editname.Text + "'";
            SqlConnection con = new SqlConnection(confi);
            con.Open();
            SqlCommand cmd = new SqlCommand(deltequery,con);   
            cmd.ExecuteNonQuery();
            MessageBox.Show("DELETE Record Successfully");
            foreach (var item in this.Controls)
            {
                if(item is TextBox)
                {
                    TextBox txt = (TextBox)item;
                    txt.Clear();
                }
            }
        }
    }
}
