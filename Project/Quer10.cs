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
    public partial class Quer10 : Form
    {
        public Quer10()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(global::_6miniaia.Properties.Settings.Default.DatabaseConnectionString);
            try
            {
                string sql = "SELECT distinct Owners.AFM,Properties.PropertyRegistrationNo from Owners,Properties where Properties.OwnerAFM=Owners.AFM AND Owners.AFM NOT IN (select Owners.AFM from PrivateOwners,Owners where Owners.AFM=PrivateOwners.AFM)";
                SqlCommand exeSql = new SqlCommand(sql, cn);
                cn.Open();
                exeSql.ExecuteNonQuery();
                //MessageBox.Show("Add New record Done!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = exeSql;
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];

                dataGridView1.Dock = DockStyle.Fill;
                button1.Hide();
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

        private void Quer10_Load(object sender, EventArgs e)
        {

        }
    }
}
