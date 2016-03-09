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
    public partial class Upd_Own : Form
    {
        public Upd_Own()
        {
            InitializeComponent();
        }

        private void Upd_Own_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.Owners' table. You can move, or remove it, as needed.
            this.ownersTableAdapter.Fill(this.databaseDataSet.Owners);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(global::_6miniaia.Properties.Settings.Default.DatabaseConnectionString);
            try
            {
                string sql = "SELECT * from Owners where AFM =" + textBox0.Text;
                SqlCommand exeSql = new SqlCommand(sql, cn);
                cn.Open();

                SqlDataReader dr;
                dr = exeSql.ExecuteReader();





                int Col1 = dr.GetOrdinal("AFM");
                int Col2 = dr.GetOrdinal("Addr_StreetName");
                int Col3 = dr.GetOrdinal("Addr_StreetNo");
                int Col4 = dr.GetOrdinal("Addr_PostalCode");


                while (dr.Read())
                {
                    string at1 = dr.GetInt32(Col1).ToString();
                    textBox1.Text = at1;
                    string at2 = dr.GetString(Col2);
                    textBox2.Text = at2;
                    string at3 = dr.GetString(Col3);
                    textBox3.Text = at3;
                    string at4 = dr.GetString(Col4);
                    textBox4.Text = at4;
                }


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

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(global::_6miniaia.Properties.Settings.Default.DatabaseConnectionString);
            try
            {
                string sql = "UPDATE Owners SET AFM =" + textBox1.Text + ", Addr_StreetName = '" + textBox2.Text + "',Addr_StreetNo = '" + textBox3.Text + "',Addr_PostalCode = '" + textBox4.Text + "' where AFM=" + textBox0.Text;
                SqlCommand exeSql = new SqlCommand(sql, cn);
                cn.Open();
                exeSql.ExecuteNonQuery();
                MessageBox.Show("Update Done!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
