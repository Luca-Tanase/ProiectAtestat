using System;
using System.Windows.Forms;

namespace ProiectAtestat
{
    public partial class mainForm : Form
    {
        private void SetupTestResultsTab()
        {

        }

        private void LoadTestResultsTab()
        {
            testResultsTableAdapter.Fill(testDatabaseDataSet.testResults);
        }
        private void testResultInsertButton_Click(object sender, EventArgs e)
        {
            testResultsTableAdapter.TestResultInsert(
                int.TryParse(testResultTimeTextBox.Text, out int time) ? time : 0,
                decimal.TryParse(testResultForceTextBox.Text, out decimal force) ? force : 0,
                decimal.TryParse(testResultStrainTextBox.Text, out decimal strain) ? strain : 0,
                testResultNotesTextBox.Text,
                int.TryParse(testResultTestIdTextBox.Text, out int testId) ? testId : 1
            );

            testResultsTableAdapter.Fill(testDatabaseDataSet.testResults);
        }

        private void defaultNotesButton_Click(object sender, EventArgs e)
        {
            testResultsTableAdapter.Fill(testDatabaseDataSet.testResults);
        }

        private void hasNotesButton_Click(object sender, EventArgs e)
        {
            testResultsTableAdapter.GetResultsWithNotes(testDatabaseDataSet.testResults);
        }
    }
}