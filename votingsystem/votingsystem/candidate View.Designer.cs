namespace votingsystem
{
    partial class candidate_View
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
            this.candidateTableAdapter = new votingsystem.voting_systemDataSet4TableAdapters.candidateTableAdapter();
            this.candidateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.voting_systemDataSet4 = new votingsystem.voting_systemDataSet4();
            this.label9 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gridview = new System.Windows.Forms.DataGridView();
            this.voting_systemDataSet5 = new votingsystem.voting_systemDataSet5();
            this.candidateBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.candidateTableAdapter1 = new votingsystem.voting_systemDataSet5TableAdapters.candidateTableAdapter();
            this.cnicDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.affiliationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.constituencyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.biographyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_searchNmae = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.candidateBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.voting_systemDataSet4)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.voting_systemDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.candidateBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // candidateTableAdapter
            // 
            this.candidateTableAdapter.ClearBeforeFill = true;
            // 
            // candidateBindingSource
            // 
            this.candidateBindingSource.DataMember = "candidate";
            this.candidateBindingSource.DataSource = this.voting_systemDataSet4;
            // 
            // voting_systemDataSet4
            // 
            this.voting_systemDataSet4.DataSetName = "voting_systemDataSet4";
            this.voting_systemDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(353, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(300, 51);
            this.label9.TabIndex = 19;
            this.label9.Text = "Candidate List";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.label9);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1013, 92);
            this.panel2.TabIndex = 17;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 566);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1013, 62);
            this.panel3.TabIndex = 72;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1013, 92);
            this.panel1.TabIndex = 71;
            // 
            // gridview
            // 
            this.gridview.AutoGenerateColumns = false;
            this.gridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cnicDataGridViewTextBoxColumn,
            this.cnameDataGridViewTextBoxColumn,
            this.affiliationDataGridViewTextBoxColumn,
            this.constituencyDataGridViewTextBoxColumn,
            this.contactDataGridViewTextBoxColumn,
            this.biographyDataGridViewTextBoxColumn});
            this.gridview.DataSource = this.candidateBindingSource1;
            this.gridview.Location = new System.Drawing.Point(12, 223);
            this.gridview.Name = "gridview";
            this.gridview.RowHeadersWidth = 62;
            this.gridview.RowTemplate.Height = 28;
            this.gridview.Size = new System.Drawing.Size(995, 337);
            this.gridview.TabIndex = 73;
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
            // candidateTableAdapter1
            // 
            this.candidateTableAdapter1.ClearBeforeFill = true;
            // 
            // cnicDataGridViewTextBoxColumn
            // 
            this.cnicDataGridViewTextBoxColumn.DataPropertyName = "cnic";
            this.cnicDataGridViewTextBoxColumn.HeaderText = "cnic";
            this.cnicDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.cnicDataGridViewTextBoxColumn.Name = "cnicDataGridViewTextBoxColumn";
            this.cnicDataGridViewTextBoxColumn.Width = 150;
            // 
            // cnameDataGridViewTextBoxColumn
            // 
            this.cnameDataGridViewTextBoxColumn.DataPropertyName = "cname";
            this.cnameDataGridViewTextBoxColumn.HeaderText = "cname";
            this.cnameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.cnameDataGridViewTextBoxColumn.Name = "cnameDataGridViewTextBoxColumn";
            this.cnameDataGridViewTextBoxColumn.Width = 150;
            // 
            // affiliationDataGridViewTextBoxColumn
            // 
            this.affiliationDataGridViewTextBoxColumn.DataPropertyName = "affiliation";
            this.affiliationDataGridViewTextBoxColumn.HeaderText = "affiliation";
            this.affiliationDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.affiliationDataGridViewTextBoxColumn.Name = "affiliationDataGridViewTextBoxColumn";
            this.affiliationDataGridViewTextBoxColumn.Width = 150;
            // 
            // constituencyDataGridViewTextBoxColumn
            // 
            this.constituencyDataGridViewTextBoxColumn.DataPropertyName = "constituency";
            this.constituencyDataGridViewTextBoxColumn.HeaderText = "constituency";
            this.constituencyDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.constituencyDataGridViewTextBoxColumn.Name = "constituencyDataGridViewTextBoxColumn";
            this.constituencyDataGridViewTextBoxColumn.Width = 150;
            // 
            // contactDataGridViewTextBoxColumn
            // 
            this.contactDataGridViewTextBoxColumn.DataPropertyName = "contact";
            this.contactDataGridViewTextBoxColumn.HeaderText = "contact";
            this.contactDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.contactDataGridViewTextBoxColumn.Name = "contactDataGridViewTextBoxColumn";
            this.contactDataGridViewTextBoxColumn.Width = 150;
            // 
            // biographyDataGridViewTextBoxColumn
            // 
            this.biographyDataGridViewTextBoxColumn.DataPropertyName = "biography";
            this.biographyDataGridViewTextBoxColumn.HeaderText = "biography";
            this.biographyDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.biographyDataGridViewTextBoxColumn.Name = "biographyDataGridViewTextBoxColumn";
            this.biographyDataGridViewTextBoxColumn.Width = 150;
            // 
            // txt_searchNmae
            // 
            this.txt_searchNmae.Location = new System.Drawing.Point(388, 145);
            this.txt_searchNmae.Name = "txt_searchNmae";
            this.txt_searchNmae.Size = new System.Drawing.Size(198, 26);
            this.txt_searchNmae.TabIndex = 74;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(281, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 23);
            this.label1.TabIndex = 75;
            this.label1.Text = "Name:";
            // 
            // btn_save
            // 
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_save.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(617, 135);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(100, 43);
            this.btn_save.TabIndex = 76;
            this.btn_save.Text = "Search";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // candidate_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 628);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_searchNmae);
            this.Controls.Add(this.gridview);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "candidate_View";
            this.Text = "candidate_View";
            this.Load += new System.EventHandler(this.candidate_View_Load);
            ((System.ComponentModel.ISupportInitialize)(this.candidateBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.voting_systemDataSet4)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.voting_systemDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.candidateBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private voting_systemDataSet4TableAdapters.candidateTableAdapter candidateTableAdapter;
        private System.Windows.Forms.BindingSource candidateBindingSource;
        private voting_systemDataSet4 voting_systemDataSet4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView gridview;
        private voting_systemDataSet5 voting_systemDataSet5;
        private System.Windows.Forms.BindingSource candidateBindingSource1;
        private voting_systemDataSet5TableAdapters.candidateTableAdapter candidateTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnicDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn affiliationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn constituencyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn biographyDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txt_searchNmae;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_save;
    }
}