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
    public partial class Voting_From : Form
    {
        public Voting_From()
        {
            InitializeComponent();
        }

        private void Voting_From_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'voting_systemDataSet3.candidate' table. You can move, or remove it, as needed.
            this.candidateTableAdapter2.Fill(this.voting_systemDataSet3.candidate);
            // TODO: This line of code loads data into the 'voting_systemDataSet2.candidate' table. You can move, or remove it, as needed.
            this.candidateTableAdapter1.Fill(this.voting_systemDataSet2.candidate);
         
        }

       
        

        private void btn_save_Click(object sender, EventArgs e)
        {
            string confi = System.Configuration.ConfigurationManager.ConnectionStrings["myconstring"].ToString();
           
            if(TXT_affiliation.Text == txt_confirmation.Text )
            {
                    string querry = "INSERT INTO votingform VALUES('" + txt_votercnic.Text + "','" + CMB_CANDIDATENAME.Text + "','" + TXT_affiliation.Text + "')";

                    SqlConnection con = new SqlConnection(confi);
                    con.Open();
                    SqlCommand cmd = new SqlCommand(querry, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Congratulation You Cast the Vote Successfully!!");
              
            }
            else
            {
                MessageBox.Show("Affliation and Comfirm Affliaton is not matching please try again...");
            }

        }

        private void CMB_CANDIDATENAME_SelectedIndexChanged(object sender, EventArgs e)
        {
            string confi = System.Configuration.ConfigurationManager.ConnectionStrings["myconstring"].ToString();

            string query = "SELECT * FROM candidate WHERE cname ='" + CMB_CANDIDATENAME.Text + "'";

            SqlConnection con = new SqlConnection(confi);
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                TXT_affiliation.Text = dr["affiliation"].ToString();

            }

        }

        private void txt_votercnic_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
