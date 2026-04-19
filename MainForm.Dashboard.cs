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

            materialsTableAdapter.GetLatestTests(testDatabaseDataSet.materials);
            DataTable table = testDatabaseDataSet.materials;

            lastTestDataGridView.DataSource = table;
        }
        private void LoadDashboard()
        {
            materialsTableAdapter.GetLatestTests(testDatabaseDataSet.materials);
        }
    }
}