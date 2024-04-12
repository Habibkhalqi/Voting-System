namespace votingsystem
{
    partial class resulsts
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.voting_systemDataSet10 = new votingsystem.voting_systemDataSet10();
            this.votingformBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.votingformTableAdapter = new votingsystem.voting_systemDataSet10TableAdapters.votingformTableAdapter();
            this.voterIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.candidateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.affiliationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.voting_systemDataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.votingformBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.voterIDDataGridViewTextBoxColumn,
            this.candidateDataGridViewTextBoxColumn,
            this.affiliationDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.votingformBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(35, 157);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(781, 395);
            this.dataGridView1.TabIndex = 0;
            // 
            // voting_systemDataSet10
            // 
            this.voting_systemDataSet10.DataSetName = "voting_systemDataSet10";
            this.voting_systemDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // votingformBindingSource
            // 
            this.votingformBindingSource.DataMember = "votingform";
            this.votingformBindingSource.DataSource = this.voting_systemDataSet10;
            // 
            // votingformTableAdapter
            // 
            this.votingformTableAdapter.ClearBeforeFill = true;
            // 
            // voterIDDataGridViewTextBoxColumn
            // 
            this.voterIDDataGridViewTextBoxColumn.DataPropertyName = "VoterID";
            this.voterIDDataGridViewTextBoxColumn.HeaderText = "VoterID";
            this.voterIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.voterIDDataGridViewTextBoxColumn.Name = "voterIDDataGridViewTextBoxColumn";
            this.voterIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // candidateDataGridViewTextBoxColumn
            // 
            this.candidateDataGridViewTextBoxColumn.DataPropertyName = "candidate";
            this.candidateDataGridViewTextBoxColumn.HeaderText = "candidate";
            this.candidateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.candidateDataGridViewTextBoxColumn.Name = "candidateDataGridViewTextBoxColumn";
            this.candidateDataGridViewTextBoxColumn.Width = 150;
            // 
            // affiliationDataGridViewTextBoxColumn
            // 
            this.affiliationDataGridViewTextBoxColumn.DataPropertyName = "affiliation";
            this.affiliationDataGridViewTextBoxColumn.HeaderText = "affiliation";
            this.affiliationDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.affiliationDataGridViewTextBoxColumn.Name = "affiliationDataGridViewTextBoxColumn";
            this.affiliationDataGridViewTextBoxColumn.Width = 150;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(263, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "Voting Results Forms";
            // 
            // resulsts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 580);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "resulsts";
            this.Text = "resulsts";
            this.Load += new System.EventHandler(this.resulsts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.voting_systemDataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.votingformBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private voting_systemDataSet10 voting_systemDataSet10;
        private System.Windows.Forms.BindingSource votingformBindingSource;
        private voting_systemDataSet10TableAdapters.votingformTableAdapter votingformTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn voterIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn candidateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn affiliationDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
    }
}