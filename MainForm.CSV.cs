using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ProiectAtestat
{
    public partial class mainForm : Form
    {
        private void SetupExportTab()
        {
            PopulateTableComboBox(tableExportComboBox);
        }
        private void LoadExportTab()
        {

        }

        private string[] GetHeadersForTable(string tableName)
        {
            switch (tableName)
            {
                case "materials": return new[] { "name", "type", "density", "youngModulus", "notes" };
                case "tests": return new[] { "type", "notes", "materialId" };
                case "testResults": return new[] { "time_s", "force_N", "strain", "notes", "testId" };
                default: return null;
            }
        }

        private DataTable GetDataTableForExport(string tableName)
        {
            switch (tableName)
            {
                case "materials": return testDatabaseDataSet.materials;
                case "tests": return testDatabaseDataSet.tests;
                case "testResults": return testDatabaseDataSet.testResults;
                default: return null;
            }
        }

        private void ExportDataTableToCSV(DataTable table, string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                for (int i = 0; i < table.Columns.Count; i++)
                {
                    writer.Write(table.Columns[i].ColumnName);
                    if (i < table.Columns.Count - 1) writer.Write(",");
                }
                writer.WriteLine();

                foreach (DataRow row in table.Rows)
                {
                    for (int i = 0; i < table.Columns.Count; i++)
                    {
                        if (row[i] != DBNull.Value) writer.Write(row[i].ToString());
                        if (i < table.Columns.Count - 1) writer.Write(",");
                    }
                    writer.WriteLine();
                }
            }
        }

        private void ExportDataGridViewToCSV(DataGridView grid, string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                for (int i = 0; i < grid.Columns.Count; i++)
                {
                    writer.Write(grid.Columns[i].HeaderText);
                    if (i < grid.Columns.Count - 1) writer.Write(",");
                }
                writer.WriteLine();

                foreach (DataGridViewRow row in grid.Rows)
                {
                    if (row.IsNewRow) continue;

                    for (int i = 0; i < grid.Columns.Count; i++)
                    {
                        if (row.Cells[i].Value != null) writer.Write(row.Cells[i].Value.ToString());
                        if (i < grid.Columns.Count - 1) writer.Write(",");
                    }
                    writer.WriteLine();
                }
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
            string[] expectedHeaders = GetHeadersForTable(tableName);

            if (expectedHeaders == null) { MessageBox.Show("Tabel necunoscut."); return; }

            OpenFileDialog ofd = new OpenFileDialog { Filter = "Fișiere CSV|*.csv" };
            if (ofd.ShowDialog() != DialogResult.OK) return;

            try
            {
                string[] lines = File.ReadAllLines(ofd.FileName);

                if (lines.Length < 2) { MessageBox.Show("Fișierul CSV este gol sau nu are date."); return; }

                string[] headers = lines[0].Split(',');
                if (!headers.Select(h => h.Trim()).SequenceEqual(expectedHeaders))
                {
                    MessageBox.Show($"Antet CSV invalid. Se așteaptă: {string.Join(",", expectedHeaders)}");
                    return;
                }

                int successCount = 0, failCount = 0;

                for (int i = 1; i < lines.Length; i++)
                {
                    string[] parts = lines[i].Split(',');
                    if (parts.Length != expectedHeaders.Length) { failCount++; continue; }

                    try
                    {
                        switch (tableName)
                        {
                            case "materials":
                                materialsTableAdapter.MaterialInsert(
                                    parts[0].Trim(), parts[1].Trim(),
                                    decimal.Parse(parts[2].Trim()), decimal.Parse(parts[3].Trim()),
                                    string.IsNullOrWhiteSpace(parts[4]) ? null : parts[4].Trim());
                                break;

                            case "tests":
                                testsTableAdapter.TestInsert(
                                    parts[0].Trim(),
                                    string.IsNullOrWhiteSpace(parts[1]) ? null : parts[1].Trim(),
                                    int.Parse(parts[2].Trim()));
                                break;

                            case "testResults":
                                testResultsTableAdapter.TestResultInsert(
                                    int.Parse(parts[0].Trim()), decimal.Parse(parts[1].Trim()),
                                    decimal.Parse(parts[2].Trim()),
                                    string.IsNullOrWhiteSpace(parts[3]) ? null : parts[3].Trim(),
                                    int.Parse(parts[4].Trim()));
                                break;
                        }
                        successCount++;
                    }
                    catch { failCount++; }
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
            if (fileImportComboBox.SelectedItem == null) { MessageBox.Show("Selectați tabelul."); return; }

            string tableName = ((KeyValuePair<string, string>)fileImportComboBox.SelectedItem).Value;
            string[] headers = GetHeadersForTable(tableName);

            if (headers == null) { MessageBox.Show("Tabel necunoscut."); return; }

            SaveFileDialog sfd = new SaveFileDialog
            {
                Filter = "CSV files (*.csv)|*.csv",
                FileName = tableName + "_template.csv"
            };

            if (sfd.ShowDialog() != DialogResult.OK) return;

            try
            {
                File.WriteAllText(sfd.FileName, string.Join(",", headers) + Environment.NewLine);
                MessageBox.Show("Template CSV creat cu succes.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la salvare: " + ex.Message);
            }
        }

        private void exportTableButton_Click(object sender, EventArgs e)
        {
            if (tableExportComboBox.SelectedItem == null) { MessageBox.Show("Selectați tabelul."); return; }

            string tableName = ((KeyValuePair<string, string>)tableExportComboBox.SelectedItem).Value;
            DataTable tableToExport = GetDataTableForExport(tableName);

            if (tableToExport == null) { MessageBox.Show("Tabel necunoscut."); return; }

            SaveFileDialog sfd = new SaveFileDialog
            {
                Filter = "CSV files (*.csv)|*.csv",
                FileName = tableName + "_export.csv"
            };

            if (sfd.ShowDialog() != DialogResult.OK) return;

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
    }
}