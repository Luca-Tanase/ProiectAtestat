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
    public partial class AvgMaxForceForm : Form
    {
        public AvgMaxForceForm()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'testDatabaseDataSet.materials' table. You can move, or remove it, as needed.
            this.materialsTableAdapter.Fill(this.testDatabaseDataSet.materials);
            // TODO: This line of code loads data into the 'testDatabaseDataSet.testResults' table. You can move, or remove it, as needed.
            this.testResultsTableAdapter.Fill(this.testDatabaseDataSet.testResults);

            testDatabaseDataSet.EnforceConstraints = false;

            avgMaxForceDataGridView.ReadOnly = true;
            avgMaxForceDataGridView.AllowUserToAddRows = false;
            avgMaxForceDataGridView.AllowUserToDeleteRows = false;
            avgMaxForceDataGridView.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void showResultButton_Click(object sender, EventArgs e)
        {
            materialsTableAdapter.GetAvgMaxForce(testDatabaseDataSet.materials, 
                decimal.TryParse(minAvgForceTextBox.Text, out decimal minAvgMaxForce) ? minAvgMaxForce : 0, 
                int.TryParse(minNumTestsTextBox.Text, out int minNumTests) ? minNumTests : 0);

            DataTable table = testDatabaseDataSet.materials;

            avgMaxForceDataGridView.DataSource = table;
        }
    }
}
