namespace votingsystem
{
    partial class editcandidate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(editcandidate));
            this.cmb_constituency = new System.Windows.Forms.ComboBox();
            this.txt_affiliation = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_CCNIC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_contafct = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_biogram = new System.Windows.Forms.TextBox();
            this.cmb_editname = new System.Windows.Forms.ComboBox();
            this.voting_systemDataSet4 = new votingsystem.voting_systemDataSet4();
            this.candidateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.candidateTableAdapter = new votingsystem.voting_systemDataSet4TableAdapters.candidateTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.voting_systemDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.candidateBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_constituency
            // 
            this.cmb_constituency.FormattingEnabled = true;
            this.cmb_constituency.Items.AddRange(new object[] {
            "MPA",
            "MNA"});
            this.cmb_constituency.Location = new System.Drawing.Point(430, 322);
            this.cmb_constituency.Name = "cmb_constituency";
            this.cmb_constituency.Size = new System.Drawing.Size(199, 28);
            this.cmb_constituency.TabIndex = 45;
            // 
            // txt_affiliation
            // 
            this.txt_affiliation.Location = new System.Drawing.Point(430, 259);
            this.txt_affiliation.Name = "txt_affiliation";
            this.txt_affiliation.Size = new System.Drawing.Size(199, 26);
            this.txt_affiliation.TabIndex = 44;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(748, 316);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 39);
            this.button1.TabIndex = 58;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(23, 129);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(274, 328);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 57;
            this.pictureBox1.TabStop = false;
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(858, 316);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(89, 39);
            this.btn_save.TabIndex = 56;
            this.btn_save.Text = "Update";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 476);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1039, 62);
            this.panel3.TabIndex = 55;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1039, 92);
            this.panel1.TabIndex = 54;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.label9);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1039, 92);
            this.panel2.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(277, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(574, 51);
            this.label9.TabIndex = 19;
            this.label9.Text = "Candidate Registration Form";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(320, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 19);
            this.label8.TabIndex = 53;
            this.label8.Text = "Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(647, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 19);
            this.label5.TabIndex = 52;
            this.label5.Text = "Biographpy:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(326, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 19);
            this.label4.TabIndex = 51;
            this.label4.Text = "CNIC:";
            // 
            // txt_CCNIC
            // 
            this.txt_CCNIC.Location = new System.Drawing.Point(430, 197);
            this.txt_CCNIC.Name = "txt_CCNIC";
            this.txt_CCNIC.Size = new System.Drawing.Size(199, 26);
            this.txt_CCNIC.TabIndex = 42;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(650, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 19);
            this.label3.TabIndex = 50;
            this.label3.Text = "Contact ";
            // 
            // txt_contafct
            // 
            this.txt_contafct.Location = new System.Drawing.Point(748, 140);
            this.txt_contafct.Name = "txt_contafct";
            this.txt_contafct.Size = new System.Drawing.Size(199, 26);
            this.txt_contafct.TabIndex = 46;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(320, 322);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 19);
            this.label2.TabIndex = 49;
            this.label2.Text = "Constituency:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(320, 258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 19);
            this.label1.TabIndex = 48;
            this.label1.Text = "Affiliation:";
            // 
            // txt_biogram
            // 
            this.txt_biogram.Location = new System.Drawing.Point(748, 188);
            this.txt_biogram.Multiline = true;
            this.txt_biogram.Name = "txt_biogram";
            this.txt_biogram.Size = new System.Drawing.Size(199, 115);
            this.txt_biogram.TabIndex = 47;
            // 
            // cmb_editname
            // 
            this.cmb_editname.DataSource = this.candidateBindingSource;
            this.cmb_editname.DisplayMember = "cname";
            this.cmb_editname.FormattingEnabled = true;
            this.cmb_editname.Location = new System.Drawing.Point(430, 136);
            this.cmb_editname.Name = "cmb_editname";
            this.cmb_editname.Size = new System.Drawing.Size(199, 28);
            this.cmb_editname.TabIndex = 59;
            this.cmb_editname.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // voting_systemDataSet4
            // 
            this.voting_systemDataSet4.DataSetName = "voting_systemDataSet4";
            this.voting_systemDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // candidateBindingSource
            // 
            this.candidateBindingSource.DataMember = "candidate";
            this.candidateBindingSource.DataSource = this.voting_systemDataSet4;
            // 
            // candidateTableAdapter
            // 
            this.candidateTableAdapter.ClearBeforeFill = true;
            // 
            // editcandidate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 538);
            this.Controls.Add(this.cmb_editname);
            this.Controls.Add(this.cmb_constituency);
            this.Controls.Add(this.txt_affiliation);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_CCNIC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_contafct);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_biogram);
            this.Name = "editcandidate";
            this.Text = "editcandidate";
            this.Load += new System.EventHandler(this.editcandidate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.voting_systemDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.candidateBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_constituency;
        private System.Windows.Forms.TextBox txt_affiliation;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_CCNIC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_contafct;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_biogram;
        private System.Windows.Forms.ComboBox cmb_editname;
        private voting_systemDataSet4 voting_systemDataSet4;
        private System.Windows.Forms.BindingSource candidateBindingSource;
        private voting_systemDataSet4TableAdapters.candidateTableAdapter candidateTableAdapter;
    }
}