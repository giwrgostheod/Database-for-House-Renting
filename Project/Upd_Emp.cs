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
    public partial class Upd_Emp : Form
    {
        public Upd_Emp()
        {
            InitializeComponent();
        }

        private void Upd_Emp_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.Employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this.databaseDataSet.Employees);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(global::_6miniaia.Properties.Settings.Default.DatabaseConnectionString);
            try
            {
                string sql = "UPDATE Employees SET AFM =" + textBox1.Text + ",  EmployeeNo= " + textBox2.Text + ", FirstName= '" + textBox3.Text + "',  LastName='" + textBox4.Text + "', Addr_StreetName='" + textBox5.Text + "', Addr_StreetNo='" + textBox6.Text + "', Addr_PostCode=" + textBox7.Text + ", Salary=" + textBox8.Text + " ,WorkPhoneNumber='" + textBox9.Text + "' ,MobilePhoneNumber='" + textBox10.Text + "', SupervisorAFM='" + textBox1.Text + "' WHERE AFM=" + textBox0.Text;
                SqlCommand exeSql = new SqlCommand(sql, cn);
                cn.Open();
                exeSql.ExecuteNonQuery();
                MessageBox.Show("Update Done!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(global::_6miniaia.Properties.Settings.Default.DatabaseConnectionString);
            try
            {
                string sql = "SELECT * FROM Employees WHERE AFM =" + textBox0.Text;
                SqlCommand exeSql = new SqlCommand(sql, cn);
                cn.Open();
                SqlDataReader dr;
                dr = exeSql.ExecuteReader();

                int AFM = dr.GetOrdinal("AFM");
                int EmployeeNo = dr.GetOrdinal("EmployeeNo");
                int FirstName = dr.GetOrdinal("FirstName");
                int LastName = dr.GetOrdinal("LastName");
                int Addr_StreetName = dr.GetOrdinal("Addr_StreetName");
                int Addr_StreetNo = dr.GetOrdinal("Addr_StreetNo");
                int Addr_PostCode = dr.GetOrdinal("Addr_PostCode");
                int Salary = dr.GetOrdinal("Salary");
                int WorkPhoneNumber = dr.GetOrdinal("WorkPhoneNumber");
                int MobilePhoneNumber = dr.GetOrdinal("MobilePhoneNumber");
                int SupervisorAFM = dr.GetOrdinal("SupervisorAFM");

                while (dr.Read())
                {
                    string sAFM = dr.GetInt32(AFM).ToString();
                    textBox1.Text = sAFM;
                    string sNo = dr.GetInt32(EmployeeNo).ToString();
                    textBox2.Text = sNo;
                    string sFirstName = dr.GetString(FirstName);
                    textBox3.Text = sFirstName;
                    string sLastName = dr.GetString(LastName);
                    textBox4.Text = sLastName;
                    string sAddr_StreetName = dr.GetString(Addr_StreetName);
                    textBox5.Text = sAddr_StreetName;
                    string sAddr_StreetNo = dr.GetString(Addr_StreetNo);
                    textBox6.Text = sAddr_StreetNo;
                    string sAddr_PostCode = dr.GetInt32(Addr_PostCode).ToString();
                    textBox7.Text = sAddr_PostCode;
                    string sSalary = dr.GetSqlMoney(Salary).ToString();
                    textBox8.Text = sSalary;
                    string sWorkPhoneNumber = dr.GetString(WorkPhoneNumber);
                    textBox9.Text = sWorkPhoneNumber;
                    string sMobilePhoneNumber = dr.GetString(MobilePhoneNumber);
                    textBox10.Text = sMobilePhoneNumber;
                    string sSupervisorAFM = dr.GetString(SupervisorAFM);
                    textBox11.Text = sSupervisorAFM;
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
    }
}
