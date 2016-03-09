namespace _6miniaia
{
    partial class View2
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
            this.viewexampleBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet = new _6miniaia.DatabaseDataSet();
            this.viewexampleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.viewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.viewTableAdapter = new _6miniaia.DatabaseDataSetTableAdapters.ViewTableAdapter();
            this.view_exampleTableAdapter = new _6miniaia.DatabaseDataSetTableAdapters.view_exampleTableAdapter();
            this.viewexampleBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.view2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.view2_TableAdapter = new _6miniaia.DatabaseDataSetTableAdapters.view2_TableAdapter();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workPhoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.viewexampleBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewexampleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewexampleBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view2BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // viewexampleBindingSource1
            // 
            this.viewexampleBindingSource1.DataMember = "view_example";
            this.viewexampleBindingSource1.DataSource = this.databaseDataSet;
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // viewexampleBindingSource
            // 
            this.viewexampleBindingSource.DataMember = "view_example";
            this.viewexampleBindingSource.DataSource = this.databaseDataSet;
            // 
            // viewBindingSource
            // 
            this.viewBindingSource.DataMember = "View";
            this.viewBindingSource.DataSource = this.databaseDataSet;
            // 
            // viewTableAdapter
            // 
            this.viewTableAdapter.ClearBeforeFill = true;
            // 
            // view_exampleTableAdapter
            // 
            this.view_exampleTableAdapter.ClearBeforeFill = true;
            // 
            // viewexampleBindingSource2
            // 
            this.viewexampleBindingSource2.DataMember = "view_example";
            this.viewexampleBindingSource2.DataSource = this.databaseDataSet;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.workPhoneNumberDataGridViewTextBoxColumn,
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
            this.dataGridView1.DataSource = this.view2BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(50, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1140, 327);
            this.dataGridView1.TabIndex = 0;
            // 
            // view2BindingSource
            // 
            this.view2BindingSource.DataMember = "view2\t";
            this.view2BindingSource.DataSource = this.databaseDataSet;
            // 
            // view2_TableAdapter
            // 
            this.view2_TableAdapter.ClearBeforeFill = true;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // workPhoneNumberDataGridViewTextBoxColumn
            // 
            this.workPhoneNumberDataGridViewTextBoxColumn.DataPropertyName = "WorkPhoneNumber";
            this.workPhoneNumberDataGridViewTextBoxColumn.HeaderText = "WorkPhoneNumber";
            this.workPhoneNumberDataGridViewTextBoxColumn.Name = "workPhoneNumberDataGridViewTextBoxColumn";
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
            // View2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 360);
            this.Controls.Add(this.dataGridView1);
            this.Name = "View2";
            this.Text = "View2";
            this.Load += new System.EventHandler(this.View2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viewexampleBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewexampleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewexampleBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view2BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource viewBindingSource;
        private DatabaseDataSetTableAdapters.ViewTableAdapter viewTableAdapter;
        private System.Windows.Forms.BindingSource viewexampleBindingSource;
        private DatabaseDataSetTableAdapters.view_exampleTableAdapter view_exampleTableAdapter;
        private System.Windows.Forms.BindingSource viewexampleBindingSource1;
        private System.Windows.Forms.BindingSource viewexampleBindingSource2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource view2BindingSource;
        private DatabaseDataSetTableAdapters.view2_TableAdapter view2_TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workPhoneNumberDataGridViewTextBoxColumn;
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
    }
}