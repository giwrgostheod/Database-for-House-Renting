namespace _6miniaia
{
    partial class Del_BO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Del_BO));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.aFMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.businessNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.businessTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactFirstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactLastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.businessOwnersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet = new _6miniaia.DatabaseDataSet();
            this.businessOwnersTableAdapter = new _6miniaia.DatabaseDataSetTableAdapters.BusinessOwnersTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.businessOwnersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.aFMDataGridViewTextBoxColumn,
            this.businessNameDataGridViewTextBoxColumn,
            this.businessTypeDataGridViewTextBoxColumn,
            this.contactFirstNameDataGridViewTextBoxColumn,
            this.contactLastNameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.businessOwnersBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(546, 283);
            this.dataGridView1.TabIndex = 1;
            // 
            // aFMDataGridViewTextBoxColumn
            // 
            this.aFMDataGridViewTextBoxColumn.DataPropertyName = "AFM";
            this.aFMDataGridViewTextBoxColumn.HeaderText = "AFM";
            this.aFMDataGridViewTextBoxColumn.Name = "aFMDataGridViewTextBoxColumn";
            // 
            // businessNameDataGridViewTextBoxColumn
            // 
            this.businessNameDataGridViewTextBoxColumn.DataPropertyName = "BusinessName";
            this.businessNameDataGridViewTextBoxColumn.HeaderText = "BusinessName";
            this.businessNameDataGridViewTextBoxColumn.Name = "businessNameDataGridViewTextBoxColumn";
            // 
            // businessTypeDataGridViewTextBoxColumn
            // 
            this.businessTypeDataGridViewTextBoxColumn.DataPropertyName = "BusinessType";
            this.businessTypeDataGridViewTextBoxColumn.HeaderText = "BusinessType";
            this.businessTypeDataGridViewTextBoxColumn.Name = "businessTypeDataGridViewTextBoxColumn";
            // 
            // contactFirstNameDataGridViewTextBoxColumn
            // 
            this.contactFirstNameDataGridViewTextBoxColumn.DataPropertyName = "ContactFirstName";
            this.contactFirstNameDataGridViewTextBoxColumn.HeaderText = "ContactFirstName";
            this.contactFirstNameDataGridViewTextBoxColumn.Name = "contactFirstNameDataGridViewTextBoxColumn";
            // 
            // contactLastNameDataGridViewTextBoxColumn
            // 
            this.contactLastNameDataGridViewTextBoxColumn.DataPropertyName = "ContactLastName";
            this.contactLastNameDataGridViewTextBoxColumn.HeaderText = "ContactLastName";
            this.contactLastNameDataGridViewTextBoxColumn.Name = "contactLastNameDataGridViewTextBoxColumn";
            // 
            // businessOwnersBindingSource
            // 
            this.businessOwnersBindingSource.DataMember = "BusinessOwners";
            this.businessOwnersBindingSource.DataSource = this.databaseDataSet;
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // businessOwnersTableAdapter
            // 
            this.businessOwnersTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(564, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Choose what you want to Delete by  AFM";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(577, 68);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(124, 20);
            this.textBox1.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(577, 122);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 34);
            this.button1.TabIndex = 7;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Del_BO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 370);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Del_BO";
            this.Text = "Del_BO";
            this.Load += new System.EventHandler(this.Del_BO_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.businessOwnersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource businessOwnersBindingSource;
        private DatabaseDataSetTableAdapters.BusinessOwnersTableAdapter businessOwnersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn aFMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn businessNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn businessTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactFirstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactLastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
    }
}