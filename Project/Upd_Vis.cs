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
    public partial class Upd_Vis : Form
    {
        public Upd_Vis()
        {
            InitializeComponent();
        }

        private void Upd_Vis_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.Visits' table. You can move, or remove it, as needed.
            this.visitsTableAdapter.Fill(this.databaseDataSet.Visits);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(global::_6miniaia.Properties.Settings.Default.DatabaseConnectionString);
            try
            {
                string sql = "UPDATE Visits SET PropertyRegistrationNo="+textBox4.Text +",ClientRegistrationNo = "+textBox5.Text+",DateOfVisit ='" + textBox6.Text + "' where (PropertyRegistrationNo=" + textBox1.Text + " AND ClientRegistrationNo= " + textBox2.Text + " AND DateOfVisit='" + textBox3.Text + "')";
                SqlCommand exeSql = new SqlCommand(sql, cn);
                cn.Open();
                exeSql.ExecuteNonQuery();
                MessageBox.Show("Update Done!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.visitsTableAdapter.Fill(this.databaseDataSet.Visits);
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
