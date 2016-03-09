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
    public partial class Ins_Own : Form
    {
        public Ins_Own()
        {
            InitializeComponent();
        }

        private void Ins_Own_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.Owners' table. You can move, or remove it, as needed.
            this.ownersTableAdapter.Fill(this.databaseDataSet.Owners);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(global::_6miniaia.Properties.Settings.Default.DatabaseConnectionString);
            try
            {
                string sql = "INSERT INTO Owners (AFM, Addr_StreetName, Addr_StreetNo, Addr_PostalCode) Values(" + textBox1.Text + ", '" + textBox2.Text + "', '" + textBox3.Text + "','" + textBox4.Text + "')";
                SqlCommand exeSql = new SqlCommand(sql, cn);
                cn.Open();
                exeSql.ExecuteNonQuery();
                MessageBox.Show("Add New record Done!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.ownersTableAdapter.Fill(this.databaseDataSet.Owners);
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
