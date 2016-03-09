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
    public partial class Upd_Adv : Form
    {
        public Upd_Adv()
        {
            InitializeComponent();
        }

        private void Upd_Adv_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.Advertisements' table. You can move, or remove it, as needed.
            this.advertisementsTableAdapter.Fill(this.databaseDataSet.Advertisements);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(global::_6miniaia.Properties.Settings.Default.DatabaseConnectionString);
            try
            {
                string sql = "SELECT * from Advertisements where (PropertyRegistrationNo =" + textBox0.Text+" and NewspaperID=" + textBox00.Text+" and DateOfPublish= '" + textBox000.Text+"')"  ;
                SqlCommand exeSql = new SqlCommand(sql, cn);
                cn.Open();

                SqlDataReader dr;
                dr = exeSql.ExecuteReader();





                int Col1 = dr.GetOrdinal("PropertyRegistrationNo");
                int Col2 = dr.GetOrdinal("NewspaperID");
                int Col3 = dr.GetOrdinal("DateOfPublish");
                int Col4 = dr.GetOrdinal("Cost");
                int Col5 = dr.GetOrdinal("Duration");
               


                while (dr.Read())
                {
                    string at1 = dr.GetInt32(Col1).ToString();
                    textBox1.Text = at1;
                    string at2 = dr.GetInt32(Col2).ToString();
                    textBox2.Text = at2;

                    string at3 = dr.GetString(Col3);
                    textBox3.Text = at3;

                    string at4 = dr.GetSqlMoney(Col4).ToString();
                    textBox4.Text = at4;
                    string at5 = dr.GetString(Col5);
                    textBox5.Text = at5;
                    
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

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(global::_6miniaia.Properties.Settings.Default.DatabaseConnectionString);
            try
            {
                string sql = "UPDATE Advertisements SET PropertyRegistrationNo =" + textBox1.Text + ", NewspaperID=" + textBox2.Text + " , DateOfPublish= '" + textBox3.Text + "', Cost='" + textBox4.Text + "' ,Duration= '" + textBox5.Text + "' where (PropertyRegistrationNo =" + textBox0.Text + " and NewspaperID=" + textBox00.Text + " and DateOfPublish= '" + textBox000.Text + "')";
                SqlCommand exeSql = new SqlCommand(sql, cn);
                cn.Open();
                exeSql.ExecuteNonQuery();
                MessageBox.Show("Update Done!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.advertisementsTableAdapter.Fill(this.databaseDataSet.Advertisements);
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
