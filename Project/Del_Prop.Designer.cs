namespace _6miniaia
{
    partial class Del_Prop
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
            this.sizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.floorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addrStreetNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addrStreetNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addrPostalCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.propertyTypeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ownerAFMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.managerAFMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.propertiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet = new _6miniaia.DatabaseDataSet();
            this.propertiesTableAdapter = new _6miniaia.DatabaseDataSetTableAdapters.PropertiesTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.propertyRegistrationNoDataGridViewTextBoxColumn,
            this.sizeDataGridViewTextBoxColumn,
            this.floorDataGridViewTextBoxColumn,
            this.rentDataGridViewTextBoxColumn,
            this.addrStreetNameDataGridViewTextBoxColumn,
            this.addrStreetNoDataGridViewTextBoxColumn,
            this.addrPostalCodeDataGridViewTextBoxColumn,
            this.propertyTypeIDDataGridViewTextBoxColumn,
            this.ownerAFMDataGridViewTextBoxColumn,
            this.managerAFMDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.propertiesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(734, 276);
            this.dataGridView1.TabIndex = 2;
            // 
            // propertyRegistrationNoDataGridViewTextBoxColumn
            // 
            this.propertyRegistrationNoDataGridViewTextBoxColumn.DataPropertyName = "PropertyRegistrationNo";
            this.propertyRegistrationNoDataGridViewTextBoxColumn.HeaderText = "PropertyRegistrationNo";
            this.propertyRegistrationNoDataGridViewTextBoxColumn.Name = "propertyRegistrationNoDataGridViewTextBoxColumn";
            // 
            // sizeDataGridViewTextBoxColumn
            // 
            this.sizeDataGridViewTextBoxColumn.DataPropertyName = "Size";
            this.sizeDataGridViewTextBoxColumn.HeaderText = "Size";
            this.sizeDataGridViewTextBoxColumn.Name = "sizeDataGridViewTextBoxColumn";
            // 
            // floorDataGridViewTextBoxColumn
            // 
            this.floorDataGridViewTextBoxColumn.DataPropertyName = "Floor";
            this.floorDataGridViewTextBoxColumn.HeaderText = "Floor";
            this.floorDataGridViewTextBoxColumn.Name = "floorDataGridViewTextBoxColumn";
            // 
            // rentDataGridViewTextBoxColumn
            // 
            this.rentDataGridViewTextBoxColumn.DataPropertyName = "Rent";
            this.rentDataGridViewTextBoxColumn.HeaderText = "Rent";
            this.rentDataGridViewTextBoxColumn.Name = "rentDataGridViewTextBoxColumn";
            // 
            // addrStreetNameDataGridViewTextBoxColumn
            // 
            this.addrStreetNameDataGridViewTextBoxColumn.DataPropertyName = "Addr_StreetName";
            this.addrStreetNameDataGridViewTextBoxColumn.HeaderText = "Addr_StreetName";
            this.addrStreetNameDataGridViewTextBoxColumn.Name = "addrStreetNameDataGridViewTextBoxColumn";
            // 
            // addrStreetNoDataGridViewTextBoxColumn
            // 
            this.addrStreetNoDataGridViewTextBoxColumn.DataPropertyName = "Addr_StreetNo";
            this.addrStreetNoDataGridViewTextBoxColumn.HeaderText = "Addr_StreetNo";
            this.addrStreetNoDataGridViewTextBoxColumn.Name = "addrStreetNoDataGridViewTextBoxColumn";
            // 
            // addrPostalCodeDataGridViewTextBoxColumn
            // 
            this.addrPostalCodeDataGridViewTextBoxColumn.DataPropertyName = "Addr_PostalCode";
            this.addrPostalCodeDataGridViewTextBoxColumn.HeaderText = "Addr_PostalCode";
            this.addrPostalCodeDataGridViewTextBoxColumn.Name = "addrPostalCodeDataGridViewTextBoxColumn";
            // 
            // propertyTypeIDDataGridViewTextBoxColumn
            // 
            this.propertyTypeIDDataGridViewTextBoxColumn.DataPropertyName = "PropertyTypeID";
            this.propertyTypeIDDataGridViewTextBoxColumn.HeaderText = "PropertyTypeID";
            this.propertyTypeIDDataGridViewTextBoxColumn.Name = "propertyTypeIDDataGridViewTextBoxColumn";
            // 
            // ownerAFMDataGridViewTextBoxColumn
            // 
            this.ownerAFMDataGridViewTextBoxColumn.DataPropertyName = "OwnerAFM";
            this.ownerAFMDataGridViewTextBoxColumn.HeaderText = "OwnerAFM";
            this.ownerAFMDataGridViewTextBoxColumn.Name = "ownerAFMDataGridViewTextBoxColumn";
            // 
            // managerAFMDataGridViewTextBoxColumn
            // 
            this.managerAFMDataGridViewTextBoxColumn.DataPropertyName = "ManagerAFM";
            this.managerAFMDataGridViewTextBoxColumn.HeaderText = "ManagerAFM";
            this.managerAFMDataGridViewTextBoxColumn.Name = "managerAFMDataGridViewTextBoxColumn";
            // 
            // propertiesBindingSource
            // 
            this.propertiesBindingSource.DataMember = "Properties";
            this.propertiesBindingSource.DataSource = this.databaseDataSet;
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // propertiesTableAdapter
            // 
            this.propertiesTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(752, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Choose what you want to Delete by RegNo";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(764, 70);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(124, 20);
            this.textBox1.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::_6miniaia.Properties.Resources.delete_2;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(764, 127);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 34);
            this.button1.TabIndex = 8;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Del_Prop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 416);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Del_Prop";
            this.Text = "Del_Prop";
            this.Load += new System.EventHandler(this.Del_Prop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource propertiesBindingSource;
        private DatabaseDataSetTableAdapters.PropertiesTableAdapter propertiesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn propertyRegistrationNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn floorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addrStreetNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addrStreetNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addrPostalCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn propertyTypeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ownerAFMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn managerAFMDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
    }
}