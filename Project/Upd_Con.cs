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
    public partial class Upd_Con : Form
    {
        public Upd_Con()
        {
            InitializeComponent();
        }

        private void Upd_Con_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.Contracts' table. You can move, or remove it, as needed.
            this.contractsTableAdapter.Fill(this.databaseDataSet.Contracts);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(global::_6miniaia.Properties.Settings.Default.DatabaseConnectionString);
            try
            {
                string sql = "SELECT * from Contracts where ContractNo =" + textBox0.Text;
                SqlCommand exeSql = new SqlCommand(sql, cn);
                cn.Open();

                SqlDataReader dr;
                dr = exeSql.ExecuteReader();

                int Col1 = dr.GetOrdinal("ContractNo");
                int Col2 = dr.GetOrdinal("Rent");
                int Col3 = dr.GetOrdinal("PaymentType");
                int Col4 = dr.GetOrdinal("RentStar");
                int Col5 = dr.GetOrdinal("RentFinish");
                int Col6 = dr.GetOrdinal("ClientRegistrationNo");
                int Col7 = dr.GetOrdinal("PropertyRegistrationNo");


                while (dr.Read())
                {
                    string at1 = dr.GetInt32(Col1).ToString();
                    textBox1.Text = at1;
                    string at2 = dr.GetSqlMoney(Col2).ToString();
                    textBox2.Text = at2;

                    string at3 = dr.GetString(Col3);
                    textBox3.Text = at3;

                    string at4 = dr.GetString(Col4); ;
                    textBox4.Text = at4;
                    string at5 = dr.GetString(Col5);
                    textBox5.Text = at5;
                    string at6 = dr.GetInt32(Col6).ToString();
                    textBox6.Text = at6;
                    string at7 = dr.GetInt32(Col7).ToString();
                    textBox7.Text = at7;
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
                string sql = "UPDATE Contracts SET ContractNo =" + textBox1.Text + ", Rent=" + textBox2.Text + ",PaymentType='" + textBox3.Text + "' ,RentStar='" + textBox4.Text + "', RentFinish = '" + textBox5.Text + "',ClientRegistrationNo = " + textBox6.Text + ",PropertyregistrationNo = " + textBox7.Text + "  where ContractNo=" + textBox0.Text;
                SqlCommand exeSql = new SqlCommand(sql, cn);
                cn.Open();
                exeSql.ExecuteNonQuery();
                MessageBox.Show("Update Done!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.contractsTableAdapter.Fill(this.databaseDataSet.Contracts);
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
