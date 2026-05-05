using System;
using System.Data;
using System.Windows.Forms;

namespace ProiectAtestat
{
    public partial class mainForm : Form
    {
        private void SetupMaterialsTab()
        {
            materialsOutputDataGridView.DataSource = testDatabaseDataSet.materials;
            SetupOutputDataGridView(materialsOutputDataGridView);

            materialsComboBindingSource.DataSource = testDatabaseDataSet.materials;

            targetMaterialComboBox.DataSource = materialsComboBindingSource;
            targetMaterialComboBox.DisplayMember = "name";
            targetMaterialComboBox.ValueMember = "id";
        }
        private void LoadMaterialsTab()
        {
            materialsTableAdapter.Fill(testDatabaseDataSet.materials);
        }
        private void materialInsertButton_Click(object sender, EventArgs e)
        {
            materialsTableAdapter.MaterialInsert(
                materialNameTextBox.Text,
                materialTypeTextBox.Text,
                decimal.TryParse(materialDensityTextBox.Text, out decimal density) ? density : 0,
                decimal.TryParse(materialYoungModulusTextBox.Text, out decimal youngModulus) ? youngModulus : 0,
                !string.IsNullOrEmpty(materialNotesTextBox.Text) ? materialNotesTextBox.Text : null
            );

            materialsTableAdapter.Fill(testDatabaseDataSet.materials);
        }

        private void materialDeleteButton_Click(object sender, EventArgs e)
        {
            if (materialsBindingSource.Current == null) return;

            DataRowView row = (DataRowView)materialsBindingSource.Current;
            int materialId = (int)row["id"];
            string materialName = row["name"].ToString();

            DialogResult result = MessageBox.Show(
                $"Șterge {materialName} și toate testele asociate acesteia?",
                "Confirmare Ștergere",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result != DialogResult.Yes) return;

            materialsTableAdapter.MaterialDelete(materialId);

            materialsTableAdapter.Fill(testDatabaseDataSet.materials);
            testsTableAdapter.Fill(testDatabaseDataSet.tests);
            testResultsTableAdapter.Fill(testDatabaseDataSet.testResults);
        }

        private void materialsInputDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (materialsInputDataGridView.CurrentRow != null &&
        materialsInputDataGridView.CurrentRow.Cells["materialsInputName"].Value != null)
            {
                int materialId = Convert.ToInt32(
                    materialsInputDataGridView.CurrentRow.Cells["materialsInputId"].Value);

                sourceMaterialNameLabel.Text = "De la materialul: " +
                    materialsInputDataGridView.CurrentRow.Cells["materialsInputName"].Value.ToString();

                testNumByMaterialIdLabel.Text =
                    "Număr de teste ale materialului selectat: " +
                    testsTableAdapter.GetTestNumByMaterialId(materialId);
            }
        }

        private void testReassignButton_Click(object sender, EventArgs e)
        {
            if (materialsBindingSource.Current == null)
            {
                MessageBox.Show("Te rog selectează un rând al tabelului", "Atenționare");
                return;
            }

            if (currentPanel != null)
                currentPanel.Visible = false;

            reassignPanel.Visible = true;
            currentPanel = reassignPanel;
        }

        private void cancelReassignButton_Click(object sender, EventArgs e)
        {
            reassignPanel.Visible = false;
            currentPanel = null;
        }

        private void confirmReassignButton_Click(object sender, EventArgs e)
        {
            if (targetMaterialComboBox.SelectedIndex < 0)
            {
                MessageBox.Show("Te rog selectează un material din baza de date", "Atenționare");
                return;
            }

            testsTableAdapter.ReassignTests(
                (int)targetMaterialComboBox.SelectedValue,
                (int)((DataRowView)materialsBindingSource.Current)["id"]
            );
        }

        private void avgMaxForceButton_Click(object sender, EventArgs e)
        {
            if (currentPanel != null)
                currentPanel.Visible = false;

            averageForcePanel.Visible = true;
            currentPanel = averageForcePanel;
        }

        private void maxForceTestsButton_Click(object sender, EventArgs e)
        {
            if (currentPanel != null)
                currentPanel.Visible = false;

            maxForceTestsPanel.Visible = true;
            currentPanel = maxForceTestsPanel;

            DataTable table = materialsMaxForceTestsTableAdapter.GetMaxForceTestsTable();
            materialsOutputDataGridView.DataSource = table;
        }

        private void showResultButton_Click(object sender, EventArgs e)
        {
            DataTable table = materialsForceFilteredTableAdapter.GetAvgMaxForceTable(
                decimal.TryParse(minAvgForceTextBox.Text, out decimal minAvgMaxForce) ? minAvgMaxForce : 0,
                int.TryParse(minNumTestsTextBox.Text, out int minNumTests) ? minNumTests : 0
            );

            materialsOutputDataGridView.DataSource = table;
        }

        private void findForceVariationButton_Click(object sender, EventArgs e)
        {
            if (currentPanel != null)
                currentPanel.Visible = false;

            forceVariationPanel.Visible = true;
            currentPanel = forceVariationPanel;
        }

        private void showVariationResultButton_Click(object sender, EventArgs e)
        {
            DataTable table = materialsForceVariationTableAdapter.GetForceVariationTable(
                decimal.TryParse(minForceVariationTextBox.Text, out decimal minForce) ? minForce : 0,
                decimal.TryParse(minTestNumTextBox.Text, out decimal minTests) ? minTests : 0
            );

            materialsOutputDataGridView.DataSource = table;
        }
    }
}