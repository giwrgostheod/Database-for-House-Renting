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
    public partial class Upd_OP : Form
    {
        public Upd_OP()
        {
            InitializeComponent();
        }

        private void Upd_OP_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.OwnerPhones' table. You can move, or remove it, as needed.
            this.ownerPhonesTableAdapter.Fill(this.databaseDataSet.OwnerPhones);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(global::_6miniaia.Properties.Settings.Default.DatabaseConnectionString);
            try
            {
                string sql = "UPDATE OwnerPhones SET AFM =" + textBox0.Text + ", PhoneNumber= '" + textBox1.Text + "' where (AFM=" + textBox2.Text+" And PhoneNumber= '" + textBox3.Text+"')" ;
                SqlCommand exeSql = new SqlCommand(sql, cn);
                cn.Open();
                exeSql.ExecuteNonQuery();
                MessageBox.Show("Update Done!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
