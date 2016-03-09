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
    public partial class Ins_Vis : Form
    {
        public Ins_Vis()
        {
            InitializeComponent();
        }

        private void Ins_Vis_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.Visits' table. You can move, or remove it, as needed.
            this.visitsTableAdapter.Fill(this.databaseDataSet.Visits);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(global::_6miniaia.Properties.Settings.Default.DatabaseConnectionString);
            try
            {
                string sql = "INSERT INTO Visits (PropertyRegistrationNo,ClientRegistrationNo, DateOfVisit) Values(" + textBox1.Text + ", " + textBox2.Text + ", '" + textBox3.Text + "')";
                SqlCommand exeSql = new SqlCommand(sql, cn);
                cn.Open();
                exeSql.ExecuteNonQuery();
                MessageBox.Show("Add New record Done!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
