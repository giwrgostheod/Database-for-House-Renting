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
    public partial class Upd_New : Form
    {
        public Upd_New()
        {
            InitializeComponent();
        }

        private void Upd_New_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.Newspapers' table. You can move, or remove it, as needed.
            this.newspapersTableAdapter.Fill(this.databaseDataSet.Newspapers);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.newspapersTableAdapter.Fill(this.databaseDataSet.Newspapers);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(global::_6miniaia.Properties.Settings.Default.DatabaseConnectionString);
            try
            {
                string sql = "SELECT * from Newspapers where NewspaperID =" + textBox0.Text ;
                SqlCommand exeSql = new SqlCommand(sql, cn);
                cn.Open();
                
                SqlDataReader dr;
                dr = exeSql.ExecuteReader();
               
                
               

                    
                 int ColNid = dr.GetOrdinal("NewspaperID");
                 int ColNN = dr.GetOrdinal("NewspaperName");
                    

                    while (dr.Read())
                    {
                        string Nid = dr.GetInt32(ColNid).ToString();
                        textBox1.Text = Nid;
                        string NN = dr.GetString(ColNN);
                        textBox2.Text = NN;
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
                string sql = "UPDATE Newspapers SET NewspaperID =" + textBox1.Text + ",  NewspaperName= '" + textBox2.Text + "' where NewspaperID="+textBox0.Text;
                SqlCommand exeSql = new SqlCommand(sql, cn);
                cn.Open();
                exeSql.ExecuteNonQuery();
                MessageBox.Show("Update Done!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.newspapersTableAdapter.Fill(this.databaseDataSet.Newspapers);
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
