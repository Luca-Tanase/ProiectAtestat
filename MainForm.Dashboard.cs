using System.Data;
using System.Windows.Forms;

namespace ProiectAtestat
{
    public partial class mainForm : Form
    {
        private void SetupDashboard()
        {
            PopulateTableComboBox(fileImportComboBox);
            SetupOutputDataGridView(lastTestDataGridView);

            DataTable table = materialsDashboardTableAdapter.GetLatestTestsTable();
            lastTestDataGridView.DataSource = table;
        }
        private void LoadDashboard()
        {
            DataTable table = materialsDashboardTableAdapter.GetLatestTestsTable();
            lastTestDataGridView.DataSource = table;

            // Option 1: Use the count of rows in the dataset
            /// materialNumLabel.Text = testDatabaseDataSet.materials.Rows.Count.ToString();
            /// testNumLabel.Text = testDatabaseDataSet.tests.Rows.Count.ToString();

            //Option 2: Use a SQL query to get the count directly from the database
            materialNumLabel.Text = "Număr de materiale: " + materialsTableAdapter.MaterialNumber().ToString();
            testNumLabel.Text = "Număr de teste: " + testsTableAdapter.TestNumber().ToString();
        }
    }
}