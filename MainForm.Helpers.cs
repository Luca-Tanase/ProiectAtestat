using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ProiectAtestat
{
    public partial class mainForm : Form
    {
        private void PopulateTableComboBox(ComboBox combo)
        {
            combo.Items.Clear();
            combo.Items.Add(new KeyValuePair<string, string>("Materiale", "materials"));
            combo.Items.Add(new KeyValuePair<string, string>("Teste", "tests"));
            combo.Items.Add(new KeyValuePair<string, string>("Rezultate teste", "testResults"));
            combo.DisplayMember = "Key";
            combo.ValueMember = "Value";
            combo.SelectedIndex = 0;
        }

        private void SetEnterLeaveTextBox(TextBox tb, string placeholder)
        {
            tb.Text = placeholder;
            tb.ForeColor = Color.Gray;

            tb.Enter += (s, e) =>
            {
                if (tb.Text == placeholder) { tb.Text = ""; tb.ForeColor = Color.Black; }
            };

            tb.Leave += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(tb.Text)) { tb.Text = placeholder; tb.ForeColor = Color.Gray; }
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

        private void GenerateTestData()
        {
            materialsTableAdapter.TestMaterialInsert("Steel S235", "Metal", 7850, 210);
            materialsTableAdapter.TestMaterialInsert("Aluminum 6061", "Metal", 2700, 69);
            materialsTableAdapter.TestMaterialInsert("Copper C110", "Metal", 8960, 110);
            materialsTableAdapter.TestMaterialInsert("Polycarbonate", "Polymer", 1200, 2.3m);

            for (int i = 1; i <= 10; i++)
            {
                testsTableAdapter.TestTestInsert("Tensile Test", (i % 4) + 1);
                for (int j = 0; j <= 100; j++)
                    testResultsTableAdapter.TestTestResultInsert(j, j * 50, (decimal)(j * 0.0005), i);

                testsTableAdapter.TestStatisticsUpdate(i);
            }

            materialsTableAdapter.Fill(testDatabaseDataSet.materials);
            testsTableAdapter.Fill(testDatabaseDataSet.tests);
            testResultsTableAdapter.Fill(testDatabaseDataSet.testResults);
        }
    }
}