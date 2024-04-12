namespace votingsystem
{
    partial class Voting_From
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Voting_From));
            this.txt_confirmation = new System.Windows.Forms.ComboBox();
            this.candidateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.voting_systemDataSet1 = new votingsystem.voting_systemDataSet1();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TXT_affiliation = new System.Windows.Forms.TextBox();
            this.CMB_CANDIDATENAME = new System.Windows.Forms.ComboBox();
            this.candidateBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.voting_systemDataSet2 = new votingsystem.voting_systemDataSet2();
            this.voting_systemDataSet = new votingsystem.voting_systemDataSet();
            this.votingsystemDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.candidateTableAdapter = new votingsystem.voting_systemDataSet1TableAdapters.candidateTableAdapter();
            this.txt_votercnic = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.candidateTableAdapter1 = new votingsystem.voting_systemDataSet2TableAdapters.candidateTableAdapter();
            this.voting_systemDataSet3 = new votingsystem.voting_systemDataSet3();
            this.candidateBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.candidateTableAdapter2 = new votingsystem.voting_systemDataSet3TableAdapters.candidateTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.candidateBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.voting_systemDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.candidateBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.voting_systemDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.voting_systemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.votingsystemDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.voting_systemDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.candidateBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_confirmation
            // 
            this.txt_confirmation.DataSource = this.candidateBindingSource2;
            this.txt_confirmation.DisplayMember = "affiliation";
            this.txt_confirmation.FormattingEnabled = true;
            this.txt_confirmation.ItemHeight = 20;
            this.txt_confirmation.Location = new System.Drawing.Point(418, 268);
            this.txt_confirmation.Name = "txt_confirmation";
            this.txt_confirmation.Size = new System.Drawing.Size(202, 28);
            this.txt_confirmation.TabIndex = 60;
            // 
            // candidateBindingSource
            // 
            this.candidateBindingSource.DataMember = "candidate";
            this.candidateBindingSource.DataSource = this.voting_systemDataSet1;
            // 
            // voting_systemDataSet1
            // 
            this.voting_systemDataSet1.DataSetName = "voting_systemDataSet1";
            this.voting_systemDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(421, 318);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 39);
            this.button1.TabIndex = 58;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 120);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(236, 264);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 57;
            this.pictureBox1.TabStop = false;
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(531, 318);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(89, 39);
            this.btn_save.TabIndex = 56;
            this.btn_save.Text = "Voted";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 482);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(777, 62);
            this.panel3.TabIndex = 55;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(777, 92);
            this.panel1.TabIndex = 54;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.label9);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(777, 92);
            this.panel2.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(277, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(258, 51);
            this.label9.TabIndex = 19;
            this.label9.Text = "Voting Form";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(289, 169);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 19);
            this.label8.TabIndex = 53;
            this.label8.Text = "Candidate Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(292, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 19);
            this.label2.TabIndex = 45;
            this.label2.Text = "Confirmation:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(294, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 19);
            this.label1.TabIndex = 44;
            this.label1.Text = "Affiliation:";
            // 
            // TXT_affiliation
            // 
            this.TXT_affiliation.Location = new System.Drawing.Point(421, 221);
            this.TXT_affiliation.Name = "TXT_affiliation";
            this.TXT_affiliation.ReadOnly = true;
            this.TXT_affiliation.Size = new System.Drawing.Size(199, 26);
            this.TXT_affiliation.TabIndex = 3;
            // 
            // CMB_CANDIDATENAME
            // 
            this.CMB_CANDIDATENAME.DataSource = this.candidateBindingSource1;
            this.CMB_CANDIDATENAME.DisplayMember = "cname";
            this.CMB_CANDIDATENAME.FormattingEnabled = true;
            this.CMB_CANDIDATENAME.Location = new System.Drawing.Point(418, 165);
            this.CMB_CANDIDATENAME.Name = "CMB_CANDIDATENAME";
            this.CMB_CANDIDATENAME.Size = new System.Drawing.Size(202, 28);
            this.CMB_CANDIDATENAME.TabIndex = 2;
            this.CMB_CANDIDATENAME.SelectedIndexChanged += new System.EventHandler(this.CMB_CANDIDATENAME_SelectedIndexChanged);
            // 
            // candidateBindingSource1
            // 
            this.candidateBindingSource1.DataMember = "candidate";
            this.candidateBindingSource1.DataSource = this.voting_systemDataSet2;
            // 
            // voting_systemDataSet2
            // 
            this.voting_systemDataSet2.DataSetName = "voting_systemDataSet2";
            this.voting_systemDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // voting_systemDataSet
            // 
            this.voting_systemDataSet.DataSetName = "voting_systemDataSet";
            this.voting_systemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // votingsystemDataSetBindingSource
            // 
            this.votingsystemDataSetBindingSource.DataSource = this.voting_systemDataSet;
            this.votingsystemDataSetBindingSource.Position = 0;
            // 
            // candidateTableAdapter
            // 
            this.candidateTableAdapter.ClearBeforeFill = true;
            // 
            // txt_votercnic
            // 
            this.txt_votercnic.Location = new System.Drawing.Point(421, 114);
            this.txt_votercnic.Name = "txt_votercnic";
            this.txt_votercnic.Size = new System.Drawing.Size(199, 26);
            this.txt_votercnic.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(294, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 19);
            this.label3.TabIndex = 62;
            this.label3.Text = "VoterCNIC:";
            // 
            // candidateTableAdapter1
            // 
            this.candidateTableAdapter1.ClearBeforeFill = true;
            // 
            // voting_systemDataSet3
            // 
            this.voting_systemDataSet3.DataSetName = "voting_systemDataSet3";
            this.voting_systemDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // candidateBindingSource2
            // 
            this.candidateBindingSource2.DataMember = "candidate";
            this.candidateBindingSource2.DataSource = this.voting_systemDataSet3;
            // 
            // candidateTableAdapter2
            // 
            this.candidateTableAdapter2.ClearBeforeFill = true;
            // 
            // Voting_From
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 544);
            this.Controls.Add(this.txt_votercnic);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CMB_CANDIDATENAME);
            this.Controls.Add(this.txt_confirmation);
            this.Controls.Add(this.TXT_affiliation);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Voting_From";
            this.Text = "Voting_From";
            this.Load += new System.EventHandler(this.Voting_From_Load);
            ((System.ComponentModel.ISupportInitialize)(this.candidateBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.voting_systemDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.candidateBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.voting_systemDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.voting_systemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.votingsystemDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.voting_systemDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.candidateBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox txt_confirmation;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXT_affiliation;
        private System.Windows.Forms.ComboBox CMB_CANDIDATENAME;
        private System.Windows.Forms.BindingSource votingsystemDataSetBindingSource;
        private voting_systemDataSet voting_systemDataSet;
        private voting_systemDataSet1 voting_systemDataSet1;
        private System.Windows.Forms.BindingSource candidateBindingSource;
        private voting_systemDataSet1TableAdapters.candidateTableAdapter candidateTableAdapter;
        private System.Windows.Forms.TextBox txt_votercnic;
        private System.Windows.Forms.Label label3;
        private voting_systemDataSet2 voting_systemDataSet2;
        private System.Windows.Forms.BindingSource candidateBindingSource1;
        private voting_systemDataSet2TableAdapters.candidateTableAdapter candidateTableAdapter1;
        private voting_systemDataSet3 voting_systemDataSet3;
        private System.Windows.Forms.BindingSource candidateBindingSource2;
        private voting_systemDataSet3TableAdapters.candidateTableAdapter candidateTableAdapter2;
    }
}