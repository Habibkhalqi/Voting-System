namespace votingsystem
{
    partial class voterform
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
            this.btn_save = new System.Windows.Forms.Button();
            this.txt_searchNmae = new System.Windows.Forms.TextBox();
            this.candidateTableAdapter1 = new votingsystem.voting_systemDataSet5TableAdapters.candidateTableAdapter();
            this.voting_systemDataSet5 = new votingsystem.voting_systemDataSet5();
            this.candidateBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.voting_systemDataSet4 = new votingsystem.voting_systemDataSet4();
            this.candidateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.candidateTableAdapter = new votingsystem.voting_systemDataSet4TableAdapters.candidateTableAdapter();
            this.voting_systemDataSet7 = new votingsystem.voting_systemDataSet7();
            this.votersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.votersTableAdapter = new votingsystem.voting_systemDataSet7TableAdapters.votersTableAdapter();
            this.voting_systemDataSet8 = new votingsystem.voting_systemDataSet8();
            this.votersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.votersTableAdapter1 = new votingsystem.voting_systemDataSet8TableAdapters.votersTableAdapter();
            this.gridview = new System.Windows.Forms.DataGridView();
            this.voting_systemDataSet9 = new votingsystem.voting_systemDataSet9();
            this.votersBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.votersTableAdapter2 = new votingsystem.voting_systemDataSet9TableAdapters.votersTableAdapter();
            this.vnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dobDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnicDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eligiblityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.securityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.voting_systemDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.candidateBindingSource1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.voting_systemDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.candidateBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.voting_systemDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.votersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.voting_systemDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.votersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.voting_systemDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.votersBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_save
            // 
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_save.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(636, 109);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(100, 43);
            this.btn_save.TabIndex = 82;
            this.btn_save.Text = "Search";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // txt_searchNmae
            // 
            this.txt_searchNmae.Location = new System.Drawing.Point(407, 119);
            this.txt_searchNmae.Name = "txt_searchNmae";
            this.txt_searchNmae.Size = new System.Drawing.Size(198, 26);
            this.txt_searchNmae.TabIndex = 80;
            // 
            // candidateTableAdapter1
            // 
            this.candidateTableAdapter1.ClearBeforeFill = true;
            // 
            // voting_systemDataSet5
            // 
            this.voting_systemDataSet5.DataSetName = "voting_systemDataSet5";
            this.voting_systemDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // candidateBindingSource1
            // 
            this.candidateBindingSource1.DataMember = "candidate";
            this.candidateBindingSource1.DataSource = this.voting_systemDataSet5;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 548);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1109, 62);
            this.panel3.TabIndex = 78;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1109, 92);
            this.panel1.TabIndex = 77;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.label9);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1109, 92);
            this.panel2.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(396, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(209, 51);
            this.label9.TabIndex = 19;
            this.label9.Text = "Voter List";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(300, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 23);
            this.label1.TabIndex = 81;
            this.label1.Text = "Name:";
            // 
            // candidateTableAdapter
            // 
            this.candidateTableAdapter.ClearBeforeFill = true;
            // 
            // voting_systemDataSet7
            // 
            this.voting_systemDataSet7.DataSetName = "voting_systemDataSet7";
            this.voting_systemDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // votersBindingSource
            // 
            this.votersBindingSource.DataMember = "voters";
            this.votersBindingSource.DataSource = this.voting_systemDataSet7;
            // 
            // votersTableAdapter
            // 
            this.votersTableAdapter.ClearBeforeFill = true;
            // 
            // voting_systemDataSet8
            // 
            this.voting_systemDataSet8.DataSetName = "voting_systemDataSet8";
            this.voting_systemDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // votersBindingSource1
            // 
            this.votersBindingSource1.DataMember = "voters";
            this.votersBindingSource1.DataSource = this.voting_systemDataSet8;
            // 
            // votersTableAdapter1
            // 
            this.votersTableAdapter1.ClearBeforeFill = true;
            // 
            // gridview
            // 
            this.gridview.AutoGenerateColumns = false;
            this.gridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vnameDataGridViewTextBoxColumn,
            this.dobDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.contactDataGridViewTextBoxColumn,
            this.cnicDataGridViewTextBoxColumn,
            this.eligiblityDataGridViewTextBoxColumn,
            this.securityDataGridViewTextBoxColumn});
            this.gridview.DataSource = this.votersBindingSource2;
            this.gridview.Location = new System.Drawing.Point(12, 183);
            this.gridview.Name = "gridview";
            this.gridview.RowHeadersWidth = 62;
            this.gridview.RowTemplate.Height = 28;
            this.gridview.Size = new System.Drawing.Size(1058, 341);
            this.gridview.TabIndex = 83;
            // 
            // voting_systemDataSet9
            // 
            this.voting_systemDataSet9.DataSetName = "voting_systemDataSet9";
            this.voting_systemDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // votersBindingSource2
            // 
            this.votersBindingSource2.DataMember = "voters";
            this.votersBindingSource2.DataSource = this.voting_systemDataSet9;
            // 
            // votersTableAdapter2
            // 
            this.votersTableAdapter2.ClearBeforeFill = true;
            // 
            // vnameDataGridViewTextBoxColumn
            // 
            this.vnameDataGridViewTextBoxColumn.DataPropertyName = "vname";
            this.vnameDataGridViewTextBoxColumn.HeaderText = "vname";
            this.vnameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.vnameDataGridViewTextBoxColumn.Name = "vnameDataGridViewTextBoxColumn";
            this.vnameDataGridViewTextBoxColumn.Width = 150;
            // 
            // dobDataGridViewTextBoxColumn
            // 
            this.dobDataGridViewTextBoxColumn.DataPropertyName = "dob";
            this.dobDataGridViewTextBoxColumn.HeaderText = "dob";
            this.dobDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dobDataGridViewTextBoxColumn.Name = "dobDataGridViewTextBoxColumn";
            this.dobDataGridViewTextBoxColumn.Width = 150;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "address";
            this.addressDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.Width = 150;
            // 
            // contactDataGridViewTextBoxColumn
            // 
            this.contactDataGridViewTextBoxColumn.DataPropertyName = "contact";
            this.contactDataGridViewTextBoxColumn.HeaderText = "contact";
            this.contactDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.contactDataGridViewTextBoxColumn.Name = "contactDataGridViewTextBoxColumn";
            this.contactDataGridViewTextBoxColumn.Width = 150;
            // 
            // cnicDataGridViewTextBoxColumn
            // 
            this.cnicDataGridViewTextBoxColumn.DataPropertyName = "cnic";
            this.cnicDataGridViewTextBoxColumn.HeaderText = "cnic";
            this.cnicDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.cnicDataGridViewTextBoxColumn.Name = "cnicDataGridViewTextBoxColumn";
            this.cnicDataGridViewTextBoxColumn.Width = 150;
            // 
            // eligiblityDataGridViewTextBoxColumn
            // 
            this.eligiblityDataGridViewTextBoxColumn.DataPropertyName = "eligiblity";
            this.eligiblityDataGridViewTextBoxColumn.HeaderText = "eligiblity";
            this.eligiblityDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.eligiblityDataGridViewTextBoxColumn.Name = "eligiblityDataGridViewTextBoxColumn";
            this.eligiblityDataGridViewTextBoxColumn.Width = 150;
            // 
            // securityDataGridViewTextBoxColumn
            // 
            this.securityDataGridViewTextBoxColumn.DataPropertyName = "security";
            this.securityDataGridViewTextBoxColumn.HeaderText = "security";
            this.securityDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.securityDataGridViewTextBoxColumn.Name = "securityDataGridViewTextBoxColumn";
            this.securityDataGridViewTextBoxColumn.Width = 150;
            // 
            // voterform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 610);
            this.Controls.Add(this.gridview);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.txt_searchNmae);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "voterform";
            this.Text = "viewvoterform";
            this.Load += new System.EventHandler(this.voterform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.voting_systemDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.candidateBindingSource1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.voting_systemDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.candidateBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.voting_systemDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.votersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.voting_systemDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.votersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.voting_systemDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.votersBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.TextBox txt_searchNmae;
        private voting_systemDataSet5TableAdapters.candidateTableAdapter candidateTableAdapter1;
        private voting_systemDataSet5 voting_systemDataSet5;
        private System.Windows.Forms.BindingSource candidateBindingSource1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
        private voting_systemDataSet4 voting_systemDataSet4;
        private System.Windows.Forms.BindingSource candidateBindingSource;
        private System.Windows.Forms.Label label1;
        private voting_systemDataSet4TableAdapters.candidateTableAdapter candidateTableAdapter;
        private voting_systemDataSet7 voting_systemDataSet7;
        private System.Windows.Forms.BindingSource votersBindingSource;
        private voting_systemDataSet7TableAdapters.votersTableAdapter votersTableAdapter;
        private voting_systemDataSet8 voting_systemDataSet8;
        private System.Windows.Forms.BindingSource votersBindingSource1;
        private voting_systemDataSet8TableAdapters.votersTableAdapter votersTableAdapter1;
        private System.Windows.Forms.DataGridView gridview;
        private voting_systemDataSet9 voting_systemDataSet9;
        private System.Windows.Forms.BindingSource votersBindingSource2;
        private voting_systemDataSet9TableAdapters.votersTableAdapter votersTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn vnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dobDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnicDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eligiblityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn securityDataGridViewTextBoxColumn;
    }
}