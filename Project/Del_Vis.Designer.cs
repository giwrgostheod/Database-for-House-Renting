namespace _6miniaia
{
    partial class Del_Vis
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
            this.propertyRegistrationNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientRegistrationNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfVisitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.visitsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet = new _6miniaia.DatabaseDataSet();
            this.visitsTableAdapter = new _6miniaia.DatabaseDataSetTableAdapters.VisitsTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.propertyRegistrationNoDataGridViewTextBoxColumn,
            this.clientRegistrationNoDataGridViewTextBoxColumn,
            this.dateOfVisitDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.visitsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(25, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(348, 276);
            this.dataGridView1.TabIndex = 2;
            // 
            // propertyRegistrationNoDataGridViewTextBoxColumn
            // 
            this.propertyRegistrationNoDataGridViewTextBoxColumn.DataPropertyName = "PropertyRegistrationNo";
            this.propertyRegistrationNoDataGridViewTextBoxColumn.HeaderText = "PropertyRegistrationNo";
            this.propertyRegistrationNoDataGridViewTextBoxColumn.Name = "propertyRegistrationNoDataGridViewTextBoxColumn";
            // 
            // clientRegistrationNoDataGridViewTextBoxColumn
            // 
            this.clientRegistrationNoDataGridViewTextBoxColumn.DataPropertyName = "ClientRegistrationNo";
            this.clientRegistrationNoDataGridViewTextBoxColumn.HeaderText = "ClientRegistrationNo";
            this.clientRegistrationNoDataGridViewTextBoxColumn.Name = "clientRegistrationNoDataGridViewTextBoxColumn";
            // 
            // dateOfVisitDataGridViewTextBoxColumn
            // 
            this.dateOfVisitDataGridViewTextBoxColumn.DataPropertyName = "DateOfVisit";
            this.dateOfVisitDataGridViewTextBoxColumn.HeaderText = "DateOfVisit";
            this.dateOfVisitDataGridViewTextBoxColumn.Name = "dateOfVisitDataGridViewTextBoxColumn";
            // 
            // visitsBindingSource
            // 
            this.visitsBindingSource.DataMember = "Visits";
            this.visitsBindingSource.DataSource = this.databaseDataSet;
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // visitsTableAdapter
            // 
            this.visitsTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(403, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(390, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Choose the Ad you want to Delete by the 3 first Columns";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(406, 124);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(124, 20);
            this.textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(562, 124);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(124, 20);
            this.textBox2.TabIndex = 9;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(706, 124);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(124, 20);
            this.textBox3.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::_6miniaia.Properties.Resources.delete_2;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(406, 187);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 34);
            this.button1.TabIndex = 11;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Del_Vis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 430);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Del_Vis";
            this.Text = "Del_Vis";
            this.Load += new System.EventHandler(this.Del_Vis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource visitsBindingSource;
        private DatabaseDataSetTableAdapters.VisitsTableAdapter visitsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn propertyRegistrationNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientRegistrationNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfVisitDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button1;
    }
}