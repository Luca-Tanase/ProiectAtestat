using System.Data;
using System.Windows.Forms;

namespace ProiectAtestat
{
    public partial class mainForm : Form
    {
        private void LoadDashboard()
        {
            lastTestDataGridView.ReadOnly = true;
            lastTestDataGridView.AllowUserToAddRows = false;
            lastTestDataGridView.AllowUserToDeleteRows = false;
            lastTestDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            materialsTableAdapter.GetLatestTests(testDatabaseDataSet.materials);
            DataTable table = testDatabaseDataSet.materials;

            lastTestDataGridView.DataSource = table;

            PopulateTableComboBox(fileImportComboBox);
        }
    }
}