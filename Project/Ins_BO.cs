using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace _6miniaia
{
    public partial class Ins_BO : Form
    {
        public Ins_BO()
        {
            InitializeComponent();
        }

        private void Ins_BO_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.BusinessOwners' table. You can move, or remove it, as needed.
            this.businessOwnersTableAdapter.Fill(this.databaseDataSet.BusinessOwners);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(global::_6miniaia.Properties.Settings.Default.DatabaseConnectionString);
            try
            {
                string sql = "INSERT INTO BusinessOwners (AFM, BusinessName, BusinessType, ContractFirstName, ContractLastName) Values(" + textBox1.Text + ", '" + textBox2.Text + "', '" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "')";
                SqlCommand exeSql = new SqlCommand(sql, cn);
                cn.Open();
                exeSql.ExecuteNonQuery();
                MessageBox.Show("Add New record Done!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.businessOwnersTableAdapter.Fill(this.databaseDataSet.BusinessOwners);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            finally
            {
                cn.Close();
            }
        }
    }
}
