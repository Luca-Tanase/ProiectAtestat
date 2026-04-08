using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ProiectAtestat
{
    public partial class mainForm : Form
    {
        private Panel currentPanel = null;

        private BindingSource materialsComboBindingSource = new BindingSource();
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
        private void LoadDashboard()
        {
            lastTestDataGridView.ReadOnly = true;
            lastTestDataGridView.AllowUserToAddRows = false;
            lastTestDataGridView.AllowUserToDeleteRows = false;
            lastTestDataGridView.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            materialsTableAdapter.GetLatestTests(testDatabaseDataSet.materials);
            DataTable table = testDatabaseDataSet.materials;

            lastTestDataGridView.DataSource = table;

            PopulateTableComboBox(fileImportComboBox);
        }
        private void LoadGraphicsTab()
        {
            chooseTestDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            chooseTestDataGridView.MultiSelect = false;
            chooseTestDataGridView.ReadOnly = true;

            // Populate graph type ComboBox
            chooseGraphicComboBox.Items.Clear();

            chooseGraphicComboBox.Items.Add(
                new KeyValuePair<string, string>(
                    "Forță vs Deformație specifică",
                    "ForceStrain"));

            chooseGraphicComboBox.Items.Add(
                new KeyValuePair<string, string>(
                    "Deformație specifică vs Timp",
                    "StrainTime"));

            chooseGraphicComboBox.Items.Add(
                new KeyValuePair<string, string>(
                    "Forță vs Timp",
                    "ForceTime"));

            chooseGraphicComboBox.DisplayMember = "Key";
            chooseGraphicComboBox.ValueMember = "Value";
            chooseGraphicComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            chooseGraphicComboBox.SelectedIndex = 0;

            // Basic chart setup
            graphicsChart.Series.Clear();

            graphicsChart.ChartAreas[0].AxisX.Title = "";
            graphicsChart.ChartAreas[0].AxisY.Title = "";
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl.SelectedTab == dashboardPage)
            {
                LoadDashboard();
            }
            else if (tabControl.SelectedTab == materialPage)
            {
                materialsTableAdapter.Fill(testDatabaseDataSet.materials);
            }
            else if (tabControl.SelectedTab == testPage)
            {
                testsTableAdapter.Fill(testDatabaseDataSet.tests);
            }
            else if (tabControl.SelectedTab == testResultPage)
            {
                testResultsTableAdapter.Fill(testDatabaseDataSet.testResults);
            }
        }
        private void GenerateTestData()
        {
            materialsTableAdapter.TestMaterialInsert("Steel S235", "Metal", 7850, 210);
            materialsTableAdapter.TestMaterialInsert("Aluminum 6061", "Metal", 2700, 69);
            materialsTableAdapter.TestMaterialInsert("Copper C110", "Metal", 8960, 110);
            materialsTableAdapter.TestMaterialInsert("Polycarbonate", "Polymer", 1200, 2.3m);

            for(int i=1; i<=10; i++)
            {
                testsTableAdapter.TestTestInsert("Tensile Test", (i % 4) + 1);
                for (int j = 0; j <= 100; j++)
                {
                    testResultsTableAdapter.TestTestResultInsert(j, j * 50, (decimal)(j * 0.0005), i);
                }
                testsTableAdapter.TestStatisticsUpdate(i);
            }

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
            // TODO: This line of code loads data into the 'testDatabaseDataSet.materialsMaxForceTests' table. You can move, or remove it, as needed.
            this.materialsMaxForceTestsTableAdapter.GetMaxForceTests(this.testDatabaseDataSet.materialsMaxForceTests);
            // TODO: This line of code loads data into the 'testDatabaseDataSet.tests' table. You can move, or remove it, as needed.
            this.testsTableAdapter.Fill(this.testDatabaseDataSet.tests);
            // TODO: This line of code loads data into the 'testDatabaseDataSet.testResults' table. You can move, or remove it, as needed.
            this.testResultsTableAdapter.Fill(this.testDatabaseDataSet.testResults);
            // TODO: This line of code loads data into the 'testDatabaseDataSet.materials' table. You can move, or remove it, as needed.
            this.materialsTableAdapter.Fill(this.testDatabaseDataSet.materials);

            materialsOutputDataGridView.DataSource = testDatabaseDataSet.materials;
            materialsOutputDataGridView.ReadOnly = true;
            materialsOutputDataGridView.AllowUserToAddRows = false;
            materialsOutputDataGridView.AllowUserToDeleteRows = false;
            materialsOutputDataGridView.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            materialsComboBindingSource.DataSource = testDatabaseDataSet.materials;

            targetMaterialComboBox.DataSource = materialsComboBindingSource;
            targetMaterialComboBox.DisplayMember = "name";
            targetMaterialComboBox.ValueMember = "id";

            PopulateTableComboBox(tableExportComboBox);

            testDatabaseDataSet.EnforceConstraints = false;

            GenerateTestData();

            SetEnterLeaveTextBoxes();

            LoadDashboard();
            LoadGraphicsTab();
        }

        private void materialInsertButton_Click(object sender, EventArgs e)
        {
            // Verifică dacă parametrii sunt valizi înainte de inserare
            materialsTableAdapter.MaterialInsert(
                materialNameTextBox.Text,
                materialTypeTextBox.Text,
                decimal.TryParse(materialDensityTextBox.Text, out decimal density) ? density : 0,
                decimal.TryParse(materialYoungModulusTextBox.Text, out decimal youngModulus) ? youngModulus : 0,
                !string.IsNullOrEmpty(materialNotesTextBox.Text) ? materialNotesTextBox.Text : null
            );

            materialsTableAdapter.Fill(testDatabaseDataSet.materials);
        }

        private void testInsertButton_Click(object sender, EventArgs e)
        {
            // Verifică dacă parametrii sunt valizi înainte de inserare
            testsTableAdapter.TestInsert(
                testTypeTextBox.Text,
                testNotesTextBox.Text,
                int.TryParse(testMaterialIdTextBox.Text, out int materialId) ? materialId : 1
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
                int.TryParse(testResultTestIdTextBox.Text, out int testId) ? testId : 1
            );

            testResultsTableAdapter.Fill(testDatabaseDataSet.testResults);
        }

        private void materialsInputDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (materialsInputDataGridView.CurrentRow != null)
            {
                sourceMaterialNameLabel.Text = "De la materialul: " + materialsInputDataGridView.CurrentRow.Cells["materialsInputName"].Value.ToString();
            }
        }

        private void testReassignButton_Click(object sender, EventArgs e)
        {
            if (materialsBindingSource.Current == null){
                MessageBox.Show(
                $"Te rog selectează un rând al tabelului",
                "Atenționare");

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
            if (targetMaterialComboBox.SelectedIndex < 0) MessageBox.Show(
                $"Te rog selectează un material din baza de date",
                "Atenționare");

            testsTableAdapter.ReassignTests((int)targetMaterialComboBox.SelectedValue, 
                (int)((DataRowView)materialsBindingSource.Current)["id"]);
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

        private void defaultNotesButton_Click(object sender, EventArgs e)
        {
            testResultsTableAdapter.Fill(testDatabaseDataSet.testResults);
        }

        private void hasNotesButton_Click(object sender, EventArgs e)
        {
            testResultsTableAdapter.GetResultsWithNotes(testDatabaseDataSet.testResults);
        }
        private string[] GetHeadersForTable(string tableName)
        {
            switch (tableName)
            {
                case "materials":
                    return new string[]
                    {
                "name",
                "type",
                "density",
                "youngModulus",
                "notes"
                    };

                case "tests":
                    return new string[]
                    {
                "type",
                "notes",
                "materialId"
                    };

                case "testResults":
                    return new string[]
                    {
                "time_s",
                "force_N",
                "strain",
                "notes",
                "testId"
                    };

                default:
                    return null;
            }
        }
        private void fileImportButton_Click(object sender, EventArgs e)
        {
            if (fileImportComboBox.SelectedItem == null)
            {
                MessageBox.Show("Selectați mai întâi tabelul în care doriți să importați datele.");
                return;
            }

            string tableName = ((KeyValuePair<string, string>)fileImportComboBox.SelectedItem).Value;

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Fișiere CSV|*.csv";
            if (ofd.ShowDialog() != DialogResult.OK)
                return;

            string[] lines;

            try
            {
                lines = File.ReadAllLines(ofd.FileName);
                if (lines.Length < 2)
                {
                    MessageBox.Show("Fișierul CSV este gol sau nu are date.");
                    return;
                }

                // Expected headers based on table
                string[] expectedHeaders = GetHeadersForTable(tableName);

                if (expectedHeaders == null)
                {
                    MessageBox.Show("Tabel necunoscut.");
                    return;
                }

                // Validate CSV header
                string[] headers = lines[0].Split(',');
                if (!headers.Select(h => h.Trim()).SequenceEqual(expectedHeaders))
                {
                    MessageBox.Show($"Antet CSV invalid. Se așteaptă: {string.Join(",", expectedHeaders)}");
                    return;
                }

                int successCount = 0;
                int failCount = 0;

                // Insert rows
                for (int i = 1; i < lines.Length; i++)
                {
                    string[] parts = lines[i].Split(',');
                    if (parts.Length != expectedHeaders.Length)
                    {
                        failCount++;
                        continue;
                    }

                    try
                    {
                        switch (tableName)
                        {
                            case "materials":
                                string name = parts[0].Trim();
                                string type = parts[1].Trim();
                                decimal density = decimal.Parse(parts[2].Trim());
                                decimal youngModulus = decimal.Parse(parts[3].Trim());
                                string notes = string.IsNullOrWhiteSpace(parts[4]) ? null : parts[4].Trim();
                                materialsTableAdapter.MaterialInsert(name, type, density, youngModulus, notes);
                                break;

                            case "tests":
                                string testType = parts[0].Trim();
                                string testNotes = string.IsNullOrWhiteSpace(parts[1]) ? null : parts[1].Trim();
                                int materialId = int.Parse(parts[2].Trim());
                                testsTableAdapter.TestInsert(testType, testNotes, materialId);
                                break;

                            case "testResults":
                                int time_s = int.Parse(parts[0].Trim());
                                decimal force_N = decimal.Parse(parts[1].Trim());
                                decimal strain = decimal.Parse(parts[2].Trim());
                                string resultNotes = string.IsNullOrWhiteSpace(parts[3]) ? null : parts[3].Trim();
                                int testId = int.Parse(parts[4].Trim());
                                testResultsTableAdapter.TestResultInsert(time_s, force_N, strain, resultNotes, testId);
                                break;
                        }

                        successCount++;
                    }
                    catch
                    {
                        failCount++;
                    }
                }

                MessageBox.Show($"Import finalizat pentru tabelul {tableName}.\nReușite: {successCount}\nEșuate: {failCount}");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la citirea fișierului: " + ex.Message);
            }
        }

        private void fileModelDownload_Click(object sender, EventArgs e)
        {
            if (fileImportComboBox.SelectedItem == null)
            {
                MessageBox.Show("Selectați tabelul.");
                return;
            }

            string tableName =
                ((KeyValuePair<string, string>)fileImportComboBox.SelectedItem).Value;

            string[] headers = GetHeadersForTable(tableName);

            if (headers == null)
            {
                MessageBox.Show("Tabel necunoscut.");
                return;
            }

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "CSV files (*.csv)|*.csv";
            sfd.FileName = tableName + "_template.csv";

            if (sfd.ShowDialog() != DialogResult.OK)
                return;

            try
            {
                string headerLine = string.Join(",", headers);

                File.WriteAllText(
                    sfd.FileName,
                    headerLine + Environment.NewLine
                );

                MessageBox.Show("Template CSV creat cu succes.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la salvare: " + ex.Message);
            }
        }
        private DataTable GetDataTableForExport(string tableName)
        {
            switch (tableName)
            {
                case "materials":
                    return testDatabaseDataSet.materials;

                case "tests":
                    return testDatabaseDataSet.tests;

                case "testResults":
                    return testDatabaseDataSet.testResults;

                default:
                    return null;
            }
        }
        private void ExportDataTableToCSV(DataTable table, string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                // Write headers
                for (int i = 0; i < table.Columns.Count; i++)
                {
                    writer.Write(table.Columns[i].ColumnName);

                    if (i < table.Columns.Count - 1)
                        writer.Write(",");
                }

                writer.WriteLine();

                // Write rows
                foreach (DataRow row in table.Rows)
                {
                    for (int i = 0; i < table.Columns.Count; i++)
                    {
                        object value = row[i];

                        if (value != DBNull.Value)
                            writer.Write(value.ToString());

                        if (i < table.Columns.Count - 1)
                            writer.Write(",");
                    }

                    writer.WriteLine();
                }
            }
        }
        // Alternative method if you want to export directly from a DataGridView
        private void ExportDataGridViewToCSV(
    DataGridView grid,
    string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                // Write headers
                for (int i = 0; i < grid.Columns.Count; i++)
                {
                    writer.Write(grid.Columns[i].HeaderText);

                    if (i < grid.Columns.Count - 1)
                        writer.Write(",");
                }

                writer.WriteLine();

                // Write rows
                foreach (DataGridViewRow row in grid.Rows)
                {
                    if (row.IsNewRow)
                        continue;

                    for (int i = 0; i < grid.Columns.Count; i++)
                    {
                        object value = row.Cells[i].Value;

                        if (value != null)
                            writer.Write(value.ToString());

                        if (i < grid.Columns.Count - 1)
                            writer.Write(",");
                    }

                    writer.WriteLine();
                }
            }
        }

        private void exportTableButton_Click(object sender, EventArgs e)
        {
            if (tableExportComboBox.SelectedItem == null)
            {
                MessageBox.Show("Selectați tabelul.");
                return;
            }

            string tableName =
                ((KeyValuePair<string, string>)tableExportComboBox.SelectedItem).Value;

            DataTable tableToExport = GetDataTableForExport(tableName);

            if (tableToExport == null)
            {
                MessageBox.Show("Tabel necunoscut.");
                return;
            }

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "CSV files (*.csv)|*.csv";
            sfd.FileName = tableName + "_export.csv";

            if (sfd.ShowDialog() != DialogResult.OK)
                return;

            try
            {
                ExportDataTableToCSV(tableToExport, sfd.FileName);
                MessageBox.Show("Export realizat cu succes.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la export: " + ex.Message);
            }
        }
        private void DrawGraph(int testId, string graphType)
        {
            graphicsChart.Series.Clear();

            var series = graphicsChart.Series.Add("Rezultate");
            series.ChartType =
                System.Windows.Forms.DataVisualization
                .Charting.SeriesChartType.Line;

            string xLabel = "";
            string yLabel = "";

            switch (graphType)
            {
                case "ForceStrain":

                    xLabel = "Deformație specifică";
                    yLabel = "Forță (N)";

                    break;

                case "StrainTime":

                    xLabel = "Timp (s)";
                    yLabel = "Deformație specifică";

                    break;

                case "ForceTime":

                    xLabel = "Timp (s)";
                    yLabel = "Forță (N)";

                    break;
            }

            graphicsChart.ChartAreas[0].AxisX.Title = xLabel;
            graphicsChart.ChartAreas[0].AxisY.Title = yLabel;

            var rows = testResultsTableAdapter.GetTestResultsByTestId(testId);

            if (rows.Count == 0)
            {
                MessageBox.Show("Testul nu are rezultate.");
                return;
            }

            foreach (var row in rows)
            {
                decimal xValue = 0;
                decimal yValue = 0;

                switch (graphType)
                {
                    case "ForceStrain":

                        xValue = row.strain;
                        yValue = row.force_N;

                        break;

                    case "StrainTime":

                        xValue = row.time_s;
                        yValue = row.strain;

                        break;

                    case "ForceTime":

                        xValue = row.time_s;
                        yValue = row.force_N;

                        break;
                }

                series.Points.AddXY(xValue, yValue);
            }
        }

        private void executeGraphicButton_Click(object sender, EventArgs e)
        {
            if (chooseTestDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selectați un test.");
                return;
            }

            if (chooseGraphicComboBox.SelectedItem == null)
            {
                MessageBox.Show("Selectați tipul graficului.");
                return;
            }

            // Get selected testId
            int testId = Convert.ToInt32(
                chooseTestDataGridView
                .SelectedRows[0]
                .Cells["id"]
                .Value);

            // Get selected graph type
            var selectedPair =
                (KeyValuePair<string, string>)
                chooseGraphicComboBox.SelectedItem;

            string graphType = selectedPair.Value;

            DrawGraph(testId, graphType);
        }
    }
}
