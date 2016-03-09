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
    public partial class View1 : Form
    {
        public View1()
        {
            InitializeComponent();
        }

        private void View1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet1.View' table. You can move, or remove it, as needed.
            this.viewTableAdapter.Fill(this.databaseDataSet.View);

        }
    }
}
