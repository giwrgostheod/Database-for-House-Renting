using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace _6miniaia
{
    public partial class Del_Prop : Form
    {
        public Del_Prop()
        {
            InitializeComponent();
        }

        private void Del_Prop_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.Properties' table. You can move, or remove it, as needed.
            this.propertiesTableAdapter.Fill(this.databaseDataSet.Properties);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(global::_6miniaia.Properties.Settings.Default.DatabaseConnectionString);
            try
            {
                string sql = "DELETE FROM   Properties WHERE PropertyRegistrationNo = " + textBox1.Text;
                SqlCommand exeSql = new SqlCommand(sql, cn);
                cn.Open();
                exeSql.ExecuteNonQuery();
                MessageBox.Show("Deletion Done!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.propertiesTableAdapter.Fill(this.databaseDataSet.Properties);
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
