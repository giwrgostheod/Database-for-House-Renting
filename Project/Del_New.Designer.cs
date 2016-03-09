namespace _6miniaia
{
    partial class Del_New
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Del_New));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.newspaperIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.newspaperNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.newspapersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet = new _6miniaia.DatabaseDataSet();
            this.newspapersTableAdapter = new _6miniaia.DatabaseDataSetTableAdapters.NewspapersTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newspapersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.newspaperIDDataGridViewTextBoxColumn,
            this.newspaperNameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.newspapersBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(82, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(248, 285);
            this.dataGridView1.TabIndex = 2;
            // 
            // newspaperIDDataGridViewTextBoxColumn
            // 
            this.newspaperIDDataGridViewTextBoxColumn.DataPropertyName = "NewspaperID";
            this.newspaperIDDataGridViewTextBoxColumn.HeaderText = "NewspaperID";
            this.newspaperIDDataGridViewTextBoxColumn.Name = "newspaperIDDataGridViewTextBoxColumn";
            // 
            // newspaperNameDataGridViewTextBoxColumn
            // 
            this.newspaperNameDataGridViewTextBoxColumn.DataPropertyName = "NewspaperName";
            this.newspaperNameDataGridViewTextBoxColumn.HeaderText = "NewspaperName";
            this.newspaperNameDataGridViewTextBoxColumn.Name = "newspaperNameDataGridViewTextBoxColumn";
            // 
            // newspapersBindingSource
            // 
            this.newspapersBindingSource.DataMember = "Newspapers";
            this.newspapersBindingSource.DataSource = this.databaseDataSet;
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // newspapersTableAdapter
            // 
            this.newspapersTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(381, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Choose what you want to Delete by  NPid";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(400, 79);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(124, 20);
            this.textBox1.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(430, 145);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 34);
            this.button1.TabIndex = 8;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Del_New
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 403);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Del_New";
            this.Text = "Del_New";
            this.Load += new System.EventHandler(this.Del_New_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newspapersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource newspapersBindingSource;
        private DatabaseDataSetTableAdapters.NewspapersTableAdapter newspapersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn newspaperIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn newspaperNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
    }
}