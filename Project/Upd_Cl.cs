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
    public partial class Upd_Cl : Form
    {
        public Upd_Cl()
        {
            InitializeComponent();
        }

        private void Upd_Cl_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.Clients' table. You can move, or remove it, as needed.
            this.clientsTableAdapter.Fill(this.databaseDataSet.Clients);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(global::_6miniaia.Properties.Settings.Default.DatabaseConnectionString);
            try
            {
                string sql = "SELECT * from Clients where ClientRegistrationNo =" + textBox0.Text;
                SqlCommand exeSql = new SqlCommand(sql, cn);
                cn.Open();

                SqlDataReader dr;
                dr = exeSql.ExecuteReader();





                int Col1 = dr.GetOrdinal("ClientRegistrationNo");
                int Col2 = dr.GetOrdinal("FirstName");
                int Col3 = dr.GetOrdinal("LastName");
                int Col4 = dr.GetOrdinal("Addr_StreetName");
                int Col5 = dr.GetOrdinal("Addr_StreetNo");
                int Col6 = dr.GetOrdinal("Addr_PostalCode");
                int Col7 = dr.GetOrdinal("RegistrationDate");
                int Col8 = dr.GetOrdinal("MaxRent");
                int Col9 = dr.GetOrdinal("Active");
                int Col10 = dr.GetOrdinal("RegisteredBy");
                int Col11 = dr.GetOrdinal("PreferedTypeID");


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
                    string at5 = dr.GetString(Col5);
                    textBox5.Text = at5;
                    string at6 = dr.GetString(Col6);
                    textBox6.Text = at6;
                    string at7 = dr.GetString(Col7);
                    textBox7.Text = at7;
                    string at8 = dr.GetSqlMoney(Col8).ToString();
                    textBox8.Text = at8;
                    string at9 = dr.GetString(Col9);
                    textBox9.Text = at9;
                    string at10 = dr.GetInt32(Col10).ToString();
                    textBox10.Text = at10;
                    string at11 = dr.GetInt32(Col11).ToString();
                    textBox11.Text = at11;
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
                string sql = "UPDATE Clients SET ClientRegistrationNo =" + textBox1.Text + ", FirstName='" + textBox2.Text + "',LastName='" + textBox3.Text + "' , Addr_StreetName = '" + textBox4.Text + "',Addr_StreetNo = '" + textBox5.Text + "',Addr_PostalCode = '" + textBox6.Text + "',RegistrationDate ='" + textBox7.Text + "', MaxRent='" + textBox8.Text + "',Active='"+textBox9.Text+"', RegisteredBy= " + textBox10.Text + ", PreferedTypeID="+textBox11.Text+"  where ClientRegistrationNo=" + textBox0.Text;
                SqlCommand exeSql = new SqlCommand(sql, cn);
                cn.Open();
                exeSql.ExecuteNonQuery();
                MessageBox.Show("Update Done!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.clientsTableAdapter.Fill(this.databaseDataSet.Clients);
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
