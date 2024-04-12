namespace votingsystem
{
    partial class editvoter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(editvoter));
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_update = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_dob = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_security = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_eligibilty = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_cnic = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_contact = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_editname = new System.Windows.Forms.ComboBox();
            this.voting_systemDataSet6 = new votingsystem.voting_systemDataSet6();
            this.votersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.votersTableAdapter = new votingsystem.voting_systemDataSet6TableAdapters.votersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.voting_systemDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.votersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(740, 334);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 39);
            this.button1.TabIndex = 41;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 117);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(274, 328);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            // 
            // btn_update
            // 
            this.btn_update.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.Location = new System.Drawing.Point(850, 334);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(89, 39);
            this.btn_update.TabIndex = 39;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 469);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(981, 62);
            this.panel3.TabIndex = 38;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(277, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(458, 51);
            this.label9.TabIndex = 19;
            this.label9.Text = "Edit Voter Registration";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.label9);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(981, 92);
            this.panel2.TabIndex = 17;
            // 
            // txt_dob
            // 
            this.txt_dob.Location = new System.Drawing.Point(413, 221);
            this.txt_dob.Name = "txt_dob";
            this.txt_dob.Size = new System.Drawing.Size(200, 26);
            this.txt_dob.TabIndex = 27;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(981, 92);
            this.panel1.TabIndex = 37;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(313, 164);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 19);
            this.label8.TabIndex = 36;
            this.label8.Text = "Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(639, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 19);
            this.label6.TabIndex = 35;
            this.label6.Text = "Security:";
            // 
            // txt_security
            // 
            this.txt_security.Location = new System.Drawing.Point(740, 282);
            this.txt_security.Name = "txt_security";
            this.txt_security.Size = new System.Drawing.Size(199, 26);
            this.txt_security.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(639, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 19);
            this.label5.TabIndex = 34;
            this.label5.Text = "Eligibility:";
            // 
            // txt_eligibilty
            // 
            this.txt_eligibilty.Location = new System.Drawing.Point(740, 221);
            this.txt_eligibilty.Name = "txt_eligibilty";
            this.txt_eligibilty.Size = new System.Drawing.Size(199, 26);
            this.txt_eligibilty.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(638, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 19);
            this.label4.TabIndex = 33;
            this.label4.Text = "CNIC:";
            // 
            // txt_cnic
            // 
            this.txt_cnic.Location = new System.Drawing.Point(739, 164);
            this.txt_cnic.Name = "txt_cnic";
            this.txt_cnic.Size = new System.Drawing.Size(200, 26);
            this.txt_cnic.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(316, 355);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 19);
            this.label3.TabIndex = 29;
            this.label3.Text = "Contact:";
            // 
            // txt_contact
            // 
            this.txt_contact.Location = new System.Drawing.Point(414, 348);
            this.txt_contact.Name = "txt_contact";
            this.txt_contact.Size = new System.Drawing.Size(199, 26);
            this.txt_contact.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(313, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 19);
            this.label2.TabIndex = 26;
            this.label2.Text = "Address:";
            // 
            // txt_address
            // 
            this.txt_address.Location = new System.Drawing.Point(414, 282);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(199, 26);
            this.txt_address.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(313, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 19);
            this.label1.TabIndex = 24;
            this.label1.Text = "DOB";
            // 
            // cmb_editname
            // 
            this.cmb_editname.DataSource = this.votersBindingSource;
            this.cmb_editname.DisplayMember = "vname";
            this.cmb_editname.FormattingEnabled = true;
            this.cmb_editname.Location = new System.Drawing.Point(414, 154);
            this.cmb_editname.Name = "cmb_editname";
            this.cmb_editname.Size = new System.Drawing.Size(199, 28);
            this.cmb_editname.TabIndex = 42;
            this.cmb_editname.SelectedIndexChanged += new System.EventHandler(this.cmb_editname_SelectedIndexChanged);
            // 
            // voting_systemDataSet6
            // 
            this.voting_systemDataSet6.DataSetName = "voting_systemDataSet6";
            this.voting_systemDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // votersBindingSource
            // 
            this.votersBindingSource.DataMember = "voters";
            this.votersBindingSource.DataSource = this.voting_systemDataSet6;
            // 
            // votersTableAdapter
            // 
            this.votersTableAdapter.ClearBeforeFill = true;
            // 
            // editvoter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 531);
            this.Controls.Add(this.cmb_editname);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.txt_dob);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_security);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_eligibilty);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_cnic);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_contact);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_address);
            this.Controls.Add(this.label1);
            this.Name = "editvoter";
            this.Text = "editvoter";
            this.Load += new System.EventHandler(this.editvoter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.voting_systemDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.votersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker txt_dob;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_security;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_eligibilty;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_cnic;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_contact;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_editname;
        private voting_systemDataSet6 voting_systemDataSet6;
        private System.Windows.Forms.BindingSource votersBindingSource;
        private voting_systemDataSet6TableAdapters.votersTableAdapter votersTableAdapter;
    }
}