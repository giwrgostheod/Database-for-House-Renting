using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6miniaia
{
    public partial class View2 : Form
    {
        public View2()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void View2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet._view2_' table. You can move, or remove it, as needed.
            this.view2_TableAdapter.Fill(this.databaseDataSet._view2_);
            // TODO: This line of code loads data into the 'databaseDataSet.view_example' table. You can move, or remove it, as needed.
            this.view_exampleTableAdapter.Fill(this.databaseDataSet.view_example);
            // TODO: This line of code loads data into the 'databaseDataSet.View' table. You can move, or remove it, as needed.
            this.viewTableAdapter.Fill(this.databaseDataSet.View);

        }
    }
}
