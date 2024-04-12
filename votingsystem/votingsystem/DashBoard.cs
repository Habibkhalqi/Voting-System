using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace votingsystem
{
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
        }

        private void registerCandidateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CandidateRegisterform cr = new CandidateRegisterform();
            cr.Show(this);
        }

        private void registerVoterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Voterregsiter vg = new Voterregsiter();
            vg.Show(this);
        }

        private void votingFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Voting_From vf = new Voting_From();
            vf.Show(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CandidateRegisterform cr = new CandidateRegisterform();
            cr.Show(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Voterregsiter vg = new Voterregsiter();
            vg.Show(this);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Voting_From vf = new Voting_From();
            vf.Show(this);
        }

        private void editRegisterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editcandidate ec = new editcandidate();
            ec.Show(this);
        }
    }
}
