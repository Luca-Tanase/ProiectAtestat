using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectAtestat
{
    public partial class MaxForceTestsForm : Form
    {
        public MaxForceTestsForm()
        {
            InitializeComponent();
        }

        private void MaxForceTestsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'testDatabaseDataSet.materials' table. You can move, or remove it, as needed.
            this.materialsTableAdapter.Fill(this.testDatabaseDataSet.materials);

            testDatabaseDataSet.EnforceConstraints = false;

            maxForceTestsDataGridView.ReadOnly = true;
            maxForceTestsDataGridView.AllowUserToAddRows = false;
            maxForceTestsDataGridView.AllowUserToDeleteRows = false;
            maxForceTestsDataGridView.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            materialsTableAdapter.GetMaxForceTests(testDatabaseDataSet.materials);

            DataTable table = testDatabaseDataSet.materials;

            maxForceTestsDataGridView.DataSource = table;
        }
    }
}
