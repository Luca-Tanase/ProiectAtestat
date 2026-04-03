using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace ProiectAtestat
{
    public partial class mainForm : Form
    {
        private void GenerateTestData()
        {
            materialsTableAdapter.TestMaterialInsert("Steel S235", "Metal", 7850, 210);
            materialsTableAdapter.TestMaterialInsert("Aluminum 6061", "Metal", 2700, 69);
            materialsTableAdapter.TestMaterialInsert("Copper C110", "Metal", 8960, 110);
            materialsTableAdapter.TestMaterialInsert("Polycarbonate", "Polymer", 1200, 2.3m);

            for(int i=1; i<=10; i++)
            {
                testsTableAdapter.TestTestInsert("Tensile Test", (i % 4) + 1);
            }

            for(int i=0; i<=100; i++)
            {
                testResultsTableAdapter.TestTestResultInsert(i, i * 50, (decimal)(i * 0.0005), 1);
            }

            testsTableAdapter.TestStatisticsUpdate(1);

            materialsTableAdapter.Fill(testDatabaseDataSet.materials);
            testsTableAdapter.Fill(testDatabaseDataSet.tests);
            testResultsTableAdapter.Fill(testDatabaseDataSet.testResults);
        }
        private void SetEnterLeaveTextBox(TextBox tb, string placeholder)
        {
            tb.Text = placeholder;
            tb.ForeColor = Color.Gray;

            tb.Enter += (s, e) =>
            {
                if (tb.Text == placeholder)
                {
                    tb.Text = "";
                    tb.ForeColor = Color.Black;
                }
            };

            tb.Leave += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(tb.Text))
                {
                    tb.Text = placeholder;
                    tb.ForeColor = Color.Gray;
                }
            };
        }
        private void SetEnterLeaveTextBoxes()
        {
            SetEnterLeaveTextBox(materialNameTextBox, "Nume material");
            SetEnterLeaveTextBox(materialTypeTextBox, "Tip material");
            SetEnterLeaveTextBox(materialDensityTextBox, "Densitate (kg/m³)");
            SetEnterLeaveTextBox(materialYoungModulusTextBox, "Modul Young");
            SetEnterLeaveTextBox(materialNotesTextBox, "Descriere (opț.)");

            SetEnterLeaveTextBox(testTypeTextBox, "Tip test");
            SetEnterLeaveTextBox(testNotesTextBox, "Descriere (opț.)");
            SetEnterLeaveTextBox(testMaterialIdTextBox, "ID material asociat");

            SetEnterLeaveTextBox(testResultTimeTextBox, "Timp (s)");
            SetEnterLeaveTextBox(testResultForceTextBox, "Forță (N)");
            SetEnterLeaveTextBox(testResultStrainTextBox, "Alungire relativă");
            SetEnterLeaveTextBox(testResultNotesTextBox, "Comentarii (opț.)");
            SetEnterLeaveTextBox(testResultTestIdTextBox, "ID test asociat");
        }
        public mainForm()
        {
            InitializeComponent();
        }

        private void materialsBindingNavigatorSaveItem_Click(object sender, System.EventArgs e)
        {
            this.Validate();
            this.materialsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.testDatabaseDataSet);

        }

        private void mainForm_Load(object sender, System.EventArgs e)
        {
            // TODO: This line of code loads data into the 'testDatabaseDataSet.tests' table. You can move, or remove it, as needed.
            this.testsTableAdapter.Fill(this.testDatabaseDataSet.tests);
            // TODO: This line of code loads data into the 'testDatabaseDataSet.testResults' table. You can move, or remove it, as needed.
            this.testResultsTableAdapter.Fill(this.testDatabaseDataSet.testResults);
            // TODO: This line of code loads data into the 'testDatabaseDataSet.materials' table. You can move, or remove it, as needed.
            this.materialsTableAdapter.Fill(this.testDatabaseDataSet.materials);

            testDatabaseDataSet.EnforceConstraints = false;

            GenerateTestData();

            SetEnterLeaveTextBoxes();
        }

        private void materialInsertButton_Click(object sender, EventArgs e)
        {
            // Verifică dacă parametrii sunt valizi înainte de inserare
            materialsTableAdapter.MaterialInsert(
                materialNameTextBox.Text,
                materialTypeTextBox.Text,
                decimal.TryParse(materialDensityTextBox.Text, out decimal density) ? density : 0,
                decimal.TryParse(materialYoungModulusTextBox.Text, out decimal youngModulus) ? youngModulus : 0,
                materialNotesTextBox.Text
            );

            materialsTableAdapter.Fill(testDatabaseDataSet.materials);
        }

        private void testInsertButton_Click(object sender, EventArgs e)
        {
            // Verifică dacă parametrii sunt valizi înainte de inserare
            testsTableAdapter.TestInsert(
                testTypeTextBox.Text,
                testNotesTextBox.Text,
                int.TryParse(testMaterialIdTextBox.Text, out int materialId) ? materialId : 0
            );

            testsTableAdapter.Fill(testDatabaseDataSet.tests);
        }

        private void testResultInsertButton_Click(object sender, EventArgs e)
        {
            // Verifică dacă parametrii sunt valizi înainte de inserare
            testResultsTableAdapter.TestResultInsert(
                int.TryParse(testResultTimeTextBox.Text, out int time) ? time : 0,
                decimal.TryParse(testResultForceTextBox.Text, out decimal force) ? force : 0,
                decimal.TryParse(testResultStrainTextBox.Text, out decimal strain) ? strain : 0,
                testResultNotesTextBox.Text,
                int.TryParse(testResultTestIdTextBox.Text, out int testId) ? testId : 0
            );

            testResultsTableAdapter.Fill(testDatabaseDataSet.testResults);
        }

        private void testReassignButton_Click(object sender, EventArgs e)
        {
            if (materialsBindingSource.Current == null)
                return;

            DataRowView currentRow = (DataRowView)materialsBindingSource.Current;

            int sourceMaterialId = (int)currentRow["id"];
            string sourceMaterialName = currentRow["name"].ToString();

            using (ReassignTestsForm dlg = new ReassignTestsForm())
            {
                dlg.SourceMaterialId = sourceMaterialId;
                dlg.SourceMaterialName = sourceMaterialName;

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    testsTableAdapter.ReassignTests(
                        sourceMaterialId,
                        dlg.TargetMaterialId
                    );

                    testsTableAdapter.Fill(testDatabaseDataSet.tests);
                }
            }
        }

        private void materialDeleteButton_Click(object sender, EventArgs e)
        {
            if (materialsBindingSource.Current == null) return;

            DataRowView row = (DataRowView)materialsBindingSource.Current;
            int materialId = (int)row["id"];
            string materialName = row["name"].ToString();

            // Confirmare
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
