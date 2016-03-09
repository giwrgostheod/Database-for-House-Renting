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
    public partial class Upd_PrT : Form
    {
        public Upd_PrT()
        {
            InitializeComponent();
        }

        private void Upd_PrT_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.PropertyTypes' table. You can move, or remove it, as needed.
            this.propertyTypesTableAdapter.Fill(this.databaseDataSet.PropertyTypes);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(global::_6miniaia.Properties.Settings.Default.DatabaseConnectionString);
            try
            {
                string sql = "SELECT * from PropertyTypes where PropertyTypeID =" + textBox0.Text;
                SqlCommand exeSql = new SqlCommand(sql, cn);
                cn.Open();

                SqlDataReader dr;
                dr = exeSql.ExecuteReader();





                int Col1 = dr.GetOrdinal("PropertyTypeID");
                int Col2 = dr.GetOrdinal("Description");
                int Col3 = dr.GetOrdinal("Rooms");



                while (dr.Read())
                {
                    string at1 = dr.GetInt32(Col1).ToString();
                    textBox1.Text = at1;
                    string at2 = dr.GetString(Col2);
                    textBox2.Text = at2;
                    string at3 = dr.GetInt32(Col3).ToString();
                    textBox3.Text = at3;

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
                string sql = "UPDATE PropertyTypes SET PropertyTypeID =" + textBox1.Text + ", Description = '" + textBox2.Text + "',Rooms = " + textBox3.Text + " where PropertyTypeID=" + textBox0.Text;
                SqlCommand exeSql = new SqlCommand(sql, cn);
                cn.Open();
                exeSql.ExecuteNonQuery();
                MessageBox.Show("Update Done!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.propertyTypesTableAdapter.Fill(this.databaseDataSet.PropertyTypes);
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
