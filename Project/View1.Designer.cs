namespace _6miniaia
{
    partial class View1
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
            this.databaseDataSet = new _6miniaia.DatabaseDataSet();
            this.viewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.viewTableAdapter = new _6miniaia.DatabaseDataSetTableAdapters.ViewTableAdapter();
            this.tableAdapterManager = new _6miniaia.DatabaseDataSetTableAdapters.TableAdapterManager();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.viewBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.clientRegistrationNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxRentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.AdvertisementsTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BusinessOwnersTableAdapter = null;
            this.tableAdapterManager.ClientPhones_TableAdapter = null;
            this.tableAdapterManager.ClientsTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.ContractsTableAdapter = null;
            this.tableAdapterManager.EmployeesTableAdapter = null;
            this.tableAdapterManager.NewspapersTableAdapter = null;
            this.tableAdapterManager.OwnerPhonesTableAdapter = null;
            this.tableAdapterManager.OwnersTableAdapter = null;
            this.tableAdapterManager.PrivateOwnersTableAdapter = null;
            this.tableAdapterManager.PropertiesTableAdapter = null;
            this.tableAdapterManager.PropertyTypesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = _6miniaia.DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VisitsTableAdapter = null;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clientRegistrationNoDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.maxRentDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.viewBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(80, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(446, 397);
            this.dataGridView1.TabIndex = 0;
            // 
            // viewBindingSource1
            // 
            this.viewBindingSource1.DataMember = "View";
            this.viewBindingSource1.DataSource = this.databaseDataSet;
            // 
            // clientRegistrationNoDataGridViewTextBoxColumn
            // 
            this.clientRegistrationNoDataGridViewTextBoxColumn.DataPropertyName = "ClientRegistrationNo";
            this.clientRegistrationNoDataGridViewTextBoxColumn.HeaderText = "ClientRegistrationNo";
            this.clientRegistrationNoDataGridViewTextBoxColumn.Name = "clientRegistrationNoDataGridViewTextBoxColumn";
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
            // maxRentDataGridViewTextBoxColumn
            // 
            this.maxRentDataGridViewTextBoxColumn.DataPropertyName = "MaxRent";
            this.maxRentDataGridViewTextBoxColumn.HeaderText = "MaxRent";
            this.maxRentDataGridViewTextBoxColumn.Name = "maxRentDataGridViewTextBoxColumn";
            // 
            // View1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 402);
            this.Controls.Add(this.dataGridView1);
            this.Name = "View1";
            this.Text = "View1";
            this.Load += new System.EventHandler(this.View1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource viewBindingSource;
        private DatabaseDataSetTableAdapters.ViewTableAdapter viewTableAdapter;
        private DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientRegistrationNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxRentDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource viewBindingSource1;
    }
}