using System;
using System.Data;
using System.Windows.Forms;

namespace ProiectAtestat
{
    public partial class mainForm : Form
    {
        private void SetupTestsTab()
        {

        }
        private void LoadTestsTab()
        {
            testsTableAdapter.Fill(testDatabaseDataSet.tests);
        }
        private void testInsertButton_Click(object sender, EventArgs e)
        {
            testsTableAdapter.TestInsert(
                testTypeTextBox.Text,
                testNotesTextBox.Text,
                int.TryParse(testMaterialIdTextBox.Text, out int materialId) ? materialId : 1
            );

            testsTableAdapter.Fill(testDatabaseDataSet.tests);
        }

        private void testStatisticsUpdateButton_Click(object sender, EventArgs e)
        {
            if (testsBindingSource.Current == null) return;

            DataRowView row = (DataRowView)testsBindingSource.Current;
            int testId = (int)row["id"];

            testsTableAdapter.TestStatisticsUpdate(testId);
            testsTableAdapter.Fill(testDatabaseDataSet.tests);
        }
    }
}