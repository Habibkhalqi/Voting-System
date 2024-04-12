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

    public partial class voterform : Form
    {
        string confi = System.Configuration.ConfigurationManager.ConnectionStrings["myconstring"].ToString();
        public voterform()
        {
            InitializeComponent();
        }

        private void voterform_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'voting_systemDataSet9.voters' table. You can move, or remove it, as needed.
            this.votersTableAdapter2.Fill(this.voting_systemDataSet9.voters);
            // TODO: This line of code loads data into the 'voting_systemDataSet8.voters' table. You can move, or remove it, as needed.
            this.votersTableAdapter1.Fill(this.voting_systemDataSet8.voters);
            // TODO: This line of code loads data into the 'voting_systemDataSet7.voters' table. You can move, or remove it, as needed.
            this.votersTableAdapter.Fill(this.voting_systemDataSet7.voters);

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string Querry = "SELECT * FROM voters WHERE vname= '" + txt_searchNmae.Text + "' ";


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
