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
    public partial class Ins_CP : Form
    {
        public Ins_CP()
        {
            InitializeComponent();
        }

        private void Ins_CP_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.ClientPhones_' table. You can move, or remove it, as needed.
            this.clientPhones_TableAdapter.Fill(this.databaseDataSet.ClientPhones_);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(global::_6miniaia.Properties.Settings.Default.DatabaseConnectionString);
            try
            {
                string sql = "INSERT INTO ClientPhones (ClientRegistrationNo,PhoneNumber) Values(" + textBox1.Text + ", '" + textBox2.Text + "')";
                SqlCommand exeSql = new SqlCommand(sql, cn);
                cn.Open();
                exeSql.ExecuteNonQuery();
                MessageBox.Show("Add New record Done!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.clientPhones_TableAdapter.Fill(this.databaseDataSet.ClientPhones_);
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
