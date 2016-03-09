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
    public partial class Upd_Prop : Form
    {
        public Upd_Prop()
        {
            InitializeComponent();
        }

        private void Upd_Prop_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.Properties' table. You can move, or remove it, as needed.
            this.propertiesTableAdapter.Fill(this.databaseDataSet.Properties);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(global::_6miniaia.Properties.Settings.Default.DatabaseConnectionString);
            try
            {
                string sql = "SELECT * from Properties where PropertyRegistrationNo =" + textBox0.Text;
                SqlCommand exeSql = new SqlCommand(sql, cn);
                cn.Open();

                SqlDataReader dr;
                dr = exeSql.ExecuteReader();





                int Col1 = dr.GetOrdinal("PropertyRegistrationNo");
                int Col2 = dr.GetOrdinal("Size");
                int Col3 = dr.GetOrdinal("Floor");
                int Col4 = dr.GetOrdinal("Rent");
                int Col5 = dr.GetOrdinal("Addr_StreetName");
                int Col6 = dr.GetOrdinal("Addr_StreetNo");
                int Col7 = dr.GetOrdinal("Addr_PostalCode");
                int Col8 = dr.GetOrdinal("PropertyTypeID");
                int Col9 = dr.GetOrdinal("OwnerAFM");
                int Col10 = dr.GetOrdinal("ManagerAFM");


                while (dr.Read())
                {
                    string at1 = dr.GetInt32(Col1).ToString();
                    textBox1.Text = at1;
                    string at2 = dr.GetString(Col2);
                    textBox2.Text = at2;

                    string at3 = dr.GetInt32(Col3).ToString();
                    textBox3.Text = at3;

                    string at4 = dr.GetSqlMoney(Col4).ToString();
                    textBox4.Text = at4;
                    string at5 = dr.GetString(Col5);
                    textBox5.Text = at5;
                    string at6 = dr.GetString(Col6);
                    textBox6.Text = at6;
                    string at7 = dr.GetString(Col7);
                    textBox7.Text = at7;
                    string at8 = dr.GetInt32(Col8).ToString();
                    textBox8.Text = at8;
                    string at9 = dr.GetInt32(Col9).ToString();
                    textBox9.Text = at9;
                    string at10 = dr.GetInt32(Col10).ToString();
                    textBox10.Text = at10;
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
                string sql = "UPDATE Properties SET PropertyRegistrationNo =" + textBox1.Text + ", Size='" + textBox2.Text + "',Floor=" + textBox3.Text + " ,Rent='" + textBox4.Text + "', Addr_StreetName = '" + textBox5.Text + "',Addr_StreetNo = '" + textBox6.Text + "',Addr_PostalCode = '" + textBox7.Text + "',PropertyTypeID =" + textBox8.Text + ", OwnerAFM=" + textBox9.Text + ", ManagerAFM= " + textBox10.Text + "  where PropertyRegistrationNo=" + textBox0.Text;
                SqlCommand exeSql = new SqlCommand(sql, cn);
                cn.Open();
                exeSql.ExecuteNonQuery();
                MessageBox.Show("Update Done!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
