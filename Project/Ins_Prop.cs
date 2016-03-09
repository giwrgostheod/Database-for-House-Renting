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
    public partial class Ins_Prop : Form
    {
        public Ins_Prop()
        {
            InitializeComponent();
        }

        private void Ins_Prop_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.Properties' table. You can move, or remove it, as needed.
            this.propertiesTableAdapter.Fill(this.databaseDataSet.Properties);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(global::_6miniaia.Properties.Settings.Default.DatabaseConnectionString);
            try
            {
                string sql = "INSERT INTO Properties (PropertyRegistrationNo ,Size ,Floor, Rent, Addr_StreetName, Addr_StreetNo, Addr_PostalCode, PropertyTypeID, OwnerAFM, ManagerAFM ) Values(" + textBox1.Text + ", '" + textBox2.Text + "', " + textBox3.Text + "," + textBox4.Text + ",'" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "'," + textBox8.Text + "," + textBox9.Text + "," + textBox10.Text + ")";
                SqlCommand exeSql = new SqlCommand(sql, cn);
                cn.Open();
                exeSql.ExecuteNonQuery();
                MessageBox.Show("Add New record Done!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
