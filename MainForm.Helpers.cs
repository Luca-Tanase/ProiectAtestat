using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ProiectAtestat
{
    public partial class mainForm : Form
    {
        private void SetupOutputDataGridView(DataGridView dgv)
        {
            dgv.ReadOnly = true;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
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

            var rand = new Random();

            const int totalPoints = 100;

            // Named constants improve readability
            const decimal yieldPlateauWidth = 0.003m;
            const decimal yieldRiseFraction = 0.15m;
            const double strainStretchExponent = 1.6;

            for (int i = 1; i <= 10; i++)
            {
                testsTableAdapter.TestTestInsert("Tensile Test", (i % 4) + 1);

                decimal yieldForce = (decimal)(rand.NextDouble() * 3000 + 7000);
                decimal yieldStrain = (decimal)(rand.NextDouble() * 0.001 + 0.008);
                decimal maxStrain = (decimal)(rand.NextDouble() * 0.04 + 0.06);

                decimal elasticModulus = yieldForce / yieldStrain;
                decimal maxForce = yieldForce * (decimal)(rand.NextDouble() * 0.3 + 1.2);

                decimal yieldTransitionEndForce =
                    yieldForce + (maxForce - yieldForce) * yieldRiseFraction;

                decimal plasticDenominator =
                    maxStrain - yieldStrain - yieldPlateauWidth;

                // Safety guard (rare but good practice)
                if (plasticDenominator <= 0)
                    plasticDenominator = 0.0001m;

                for (int j = 0; j <= totalPoints; j++)
                {
                    double progress = (double)j / totalPoints;

                    decimal strain =
                        maxStrain *
                        (decimal)Math.Pow(progress, strainStretchExponent);

                    decimal noise =
                        (decimal)(0.999 + 0.002 * rand.NextDouble());

                    decimal force;

                    if (strain < yieldStrain)
                    {
                        // Elastic region
                        force = elasticModulus * strain * noise;
                    }
                    else if (strain < yieldStrain + yieldPlateauWidth)
                    {
                        // Yield transition
                        decimal t =
                            (strain - yieldStrain) /
                            yieldPlateauWidth;

                        double td = Math.Min(1.0, Math.Max(0.0, (double)t));

                        decimal smooth =
                            (decimal)(0.5 * (1 + Math.Tanh(td * 2 - 1)));

                        force =
                            yieldForce +
                            (maxForce - yieldForce) *
                            yieldRiseFraction *
                            smooth;

                        force *= noise;
                    }
                    else
                    {
                        // Plastic region (hardening → necking)

                        decimal t =
                            (strain - yieldStrain - yieldPlateauWidth) /
                            plasticDenominator;

                        double td = Math.Min(1.0, Math.Max(0.0, (double)t));

                        decimal shape =
                            (decimal)(
                                0.9 * Math.Sin(Math.PI * td)
                                - 0.8 * Math.Pow(td, 2.5)
                            );

                        force =
                            yieldTransitionEndForce +
                            (maxForce - yieldTransitionEndForce) *
                            shape;

                        force *= noise;
                    }

                    testResultsTableAdapter.TestTestResultInsert(
                        j,
                        force,
                        strain,
                        i
                    );
                }

                testsTableAdapter.TestStatisticsUpdate(i);
            }

            materialsTableAdapter.Fill(testDatabaseDataSet.materials);
            testsTableAdapter.Fill(testDatabaseDataSet.tests);
            testResultsTableAdapter.Fill(testDatabaseDataSet.testResults);
        }
    }
}