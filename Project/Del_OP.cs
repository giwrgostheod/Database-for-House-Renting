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
    public partial class Del_OP : Form
    {
        public Del_OP()
        {
            InitializeComponent();
        }

        private void Del_OP_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.OwnerPhones' table. You can move, or remove it, as needed.
            this.ownerPhonesTableAdapter.Fill(this.databaseDataSet.OwnerPhones);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(global::_6miniaia.Properties.Settings.Default.DatabaseConnectionString);
            try
            {
                string sql = "DELETE FROM OwnerPhones WHERE AFM = " + textBox1.Text + " and PhoneNumber= '" + textBox2.Text + "'";
                SqlCommand exeSql = new SqlCommand(sql, cn);
                cn.Open();
                exeSql.ExecuteNonQuery();
                MessageBox.Show("Deletion Done!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.ownerPhonesTableAdapter.Fill(this.databaseDataSet.OwnerPhones);
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
