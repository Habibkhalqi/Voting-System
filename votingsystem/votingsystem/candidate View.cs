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
    public partial class candidate_View : Form
    {
        string confi = System.Configuration.ConfigurationManager.ConnectionStrings["myconstring"].ToString();
        public candidate_View()
        {
            InitializeComponent();
        }

        private void candidate_View_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'voting_systemDataSet5.candidate' table. You can move, or remove it, as needed.
            this.candidateTableAdapter1.Fill(this.voting_systemDataSet5.candidate);

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string Querry = "SELECT * FROM candidate WHERE cname= '" + txt_searchNmae.Text + "' ";

          
            SqlConnection con = new SqlConnection(confi);
                con.Open();
                SqlCommand cmd = new SqlCommand(Querry, con);
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                if (dt.Rows.Count > 0)
                {
                    gridview.DataSource = dt;

                }
                else
                {
                    gridview.DataSource = null;
                }

        
        }
    }
}
