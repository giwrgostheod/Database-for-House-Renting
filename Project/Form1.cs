using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace _6miniaia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {     
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Employees")
            {
                Ins_Emp f2 = new Ins_Emp();
                f2.Show();
            }
            if (comboBox1.Text == "Advertisements")
            {
                Ins_Adv f2 = new Ins_Adv();
                f2.Show();
            }
            if (comboBox1.Text == "BusinessOwners")
            {
                Ins_BO f2 = new Ins_BO();
                f2.Show();
            }
            if (comboBox1.Text == "ClientPhones")
            {
                Ins_CP f2 = new Ins_CP();
                f2.Show();
            }
            if (comboBox1.Text == "Clients")
            {
                Ins_Cl f2 = new Ins_Cl();
                f2.Show();
            }
            if (comboBox1.Text == "Contracts")
            {
                v f2 = new v();
                f2.Show();
            }
            if (comboBox1.Text == "Newspapers")
            {
                Ins_New f2 = new Ins_New();
                f2.Show();
            }
            if (comboBox1.Text == "OwnerPhones")
            {
                Ins_OP f2 = new Ins_OP();
                f2.Show();
            }
            if (comboBox1.Text == "Owners")
            {
                Ins_Own f2 = new Ins_Own();
                f2.Show();
            }
            if (comboBox1.Text == "PrivateOwners")
            {
                Ins_POw f2 = new Ins_POw();
                f2.Show();
            }
            if (comboBox1.Text == "Properties")
            {
                Ins_Prop f2 = new Ins_Prop();
                f2.Show();
            }
            if (comboBox1.Text == "PropertyTypes")
            {
                Ins_PrT f2 = new Ins_PrT();
                f2.Show();
            }
            if (comboBox1.Text == "Visits")
            {
                Ins_Vis f2 = new Ins_Vis();
                f2.Show();
            }
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox2.Text == "Employees")
            {
                Del_Emp f3 = new Del_Emp();
                f3.Show();
            }
            if (comboBox2.Text == "Advertisements")
            {
                Del_Adv f2 = new Del_Adv();
                f2.Show();
            }
            if (comboBox2.Text == "BusinessOwners")
            {
                Del_BO f2 = new Del_BO();
                f2.Show();
            }
            if (comboBox2.Text == "ClientPhones")
            {
                Del_CP f2 = new Del_CP();
                f2.Show();
            }
            if (comboBox2.Text == "Clients")
            {
                Del_C f2 = new Del_C();
                f2.Show();
            }
            if (comboBox2.Text == "Contracts")
            {
                Del_Con f2 = new Del_Con();
                f2.Show();
            }
            if (comboBox2.Text == "Newspapers")
            {
                Del_New f2 = new Del_New();
                f2.Show();
            }
            if (comboBox2.Text == "OwnerPhones")
            {
                Del_OP f2 = new Del_OP();
                f2.Show();
            }
            if (comboBox2.Text == "Owners")
            {
                Del_Own f2 = new Del_Own();
                f2.Show();
            }
            if (comboBox2.Text == "PrivateOwners")
            {
                Del_POw f2 = new Del_POw();
                f2.Show();
            }
            if (comboBox2.Text == "Properties")
            {
                Del_Prop f2 = new Del_Prop();
                f2.Show();
            }
            if (comboBox2.Text == "PropertyType")
            {
                Del_PrT f2 = new Del_PrT();
                f2.Show();
            }
            if (comboBox2.Text == "Visits")
            {
                Del_Vis f2 = new Del_Vis();
                f2.Show();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox3.Text == "Employees")
            {
                Upd_Emp f2 = new Upd_Emp();
                f2.Show();
            }
            if (comboBox3.Text == "Advertisements")
            {
                Upd_Adv f2 = new Upd_Adv();
                f2.Show();
            }
            if (comboBox3.Text == "BusinessOwners")
            {
                Upd_BO f2 = new Upd_BO();
                f2.Show();
            }
            if (comboBox3.Text == "ClientPhones")
            {
                Upd_CP f2 = new Upd_CP();
                f2.Show();
            }
            if (comboBox3.Text == "Clients")
            {
                Upd_Cl f2 = new Upd_Cl();
                f2.Show();
            }
            if (comboBox3.Text == "Contracts")
            {
                Upd_Con f2 = new Upd_Con();
                f2.Show();
            }
            if (comboBox3.Text == "Newspapers")
            {
                Upd_New f2 = new Upd_New();
                f2.Show();
            }
            if (comboBox3.Text == "OwnerPhones")
            {
                Upd_OP f2 = new Upd_OP();
                f2.Show();
            }
            if (comboBox3.Text == "Owners")
            {
                Upd_Own f2 = new Upd_Own();
                f2.Show();
            }
            if (comboBox3.Text == "PrivateOwners")
            {
                Upd_POw f2 = new Upd_POw();
                f2.Show();
            }
            if (comboBox3.Text == "Properties")
            {
                Upd_Prop f2 = new Upd_Prop();
                f2.Show();
            }
            if (comboBox3.Text == "PropertyTypes")
            {
                Upd_PrT f2 = new Upd_PrT();
                f2.Show();
            }
            if (comboBox3.Text == "Visits")
            {
                Upd_Vis f2 = new Upd_Vis();
                f2.Show();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (comboBox4.Text == "Choose all the attributes from tables Employees and Properties with Rent>= the number you enter")
            {
                Quer1 f4 = new Quer1();
                f4.Show();
            }

            if (comboBox4.Text == "See the advertisments in Newspaper Kathimerinh")
            {
                Quer2 f4 = new Quer2();
                f4.Show();
            }
            if (comboBox4.Text == "See the minimum,maximum and average Rents that are signed in Contracts")
            {
                Quer3 f4 = new Quer3();
                f4.Show();
            }
            if (comboBox4.Text == "See the number of contracts each emplyoee has signed")
            {
                Quer4 f4 = new Quer4();
                f4.Show();
            }
            if (comboBox4.Text == "See the number of Properties have the owners from a choosen number of Properties and above")
            {
                Quer5 f4 = new Quer5();
                f4.Show();
            }
            if (comboBox4.Text == "See the summary of cost in Advertisements of Properties equal or above the number you choose")
            {
                Quer6 f4 = new Quer6();
                f4.Show();
            }
            if (comboBox4.Text == "See Employees AFM and Salary with Salary greater than a choosen Employee")
            {
                Quer7 f4 = new Quer7();
                f4.Show();
            }
            if (comboBox4.Text == "See all the Visits except the ones that the Client you chose made")
            {
                Quer8 f4 = new Quer8();
                f4.Show();
            }
            if (comboBox4.Text == "Find a Client by his Last Name")
            {
                Quer9 f4 = new Quer9();
                f4.Show();
            }
            if (comboBox4.Text == "Select all the Business Owners and show their AFMs and Properties")
            {
                Quer10 f4 = new Quer10();
                f4.Show();
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            if (comboBox5.Text == "View1_Updatable")
            {
                View1 f4 = new View1();
                f4.Show();
            }

            if (comboBox5.Text == "View2_Not_Updatable")
            {
                View2 f4 = new View2();
                f4.Show();
            }
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
           
        }
    }
}
