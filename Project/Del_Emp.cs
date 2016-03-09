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
    public partial class Del_Emp : Form
    {
        public Del_Emp()
        {
            InitializeComponent();
        }

        private void Del_Emp_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.Employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this.databaseDataSet.Employees);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(global::_6miniaia.Properties.Settings.Default.DatabaseConnectionString);
            try
            {
                string sql = "DELETE FROM Employees WHERE AFM = "+textBox2.Text;
                SqlCommand exeSql = new SqlCommand(sql, cn);
                cn.Open();
                exeSql.ExecuteNonQuery();
                MessageBox.Show("Deletion Done!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.employeesTableAdapter.Fill(this.databaseDataSet.Employees);
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

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
