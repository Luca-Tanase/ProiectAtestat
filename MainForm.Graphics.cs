using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProiectAtestat
{
    public partial class mainForm : Form
    {
        private void SetupGraphicsTab()
        {
            chooseTestDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            chooseTestDataGridView.MultiSelect = false;
            chooseTestDataGridView.ReadOnly = true;

            chooseGraphicComboBox.Items.Clear();
            chooseGraphicComboBox.Items.Add(new KeyValuePair<string, string>("Forță vs Deformație specifică", "ForceStrain"));
            chooseGraphicComboBox.Items.Add(new KeyValuePair<string, string>("Deformație specifică vs Timp", "StrainTime"));
            chooseGraphicComboBox.Items.Add(new KeyValuePair<string, string>("Forță vs Timp", "ForceTime"));
            chooseGraphicComboBox.DisplayMember = "Key";
            chooseGraphicComboBox.ValueMember = "Value";
            chooseGraphicComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            chooseGraphicComboBox.SelectedIndex = 0;

            graphicsChart.Series.Clear();
            graphicsChart.ChartAreas[0].AxisX.Title = "";
            graphicsChart.ChartAreas[0].AxisY.Title = "";
        }
        private void LoadGraphicsTab()
        {
            
        }

        private void DrawGraph(int testId, string graphType)
        {
            graphicsChart.Series.Clear();

            var series = graphicsChart.Series.Add("Rezultate");
            series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

            string xLabel = "";
            string yLabel = "";

            switch (graphType)
            {
                case "ForceStrain": xLabel = "Deformație specifică"; yLabel = "Forță (N)"; break;
                case "StrainTime": xLabel = "Timp (s)"; yLabel = "Deformație specifică"; break;
                case "ForceTime": xLabel = "Timp (s)"; yLabel = "Forță (N)"; break;
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
                    case "ForceStrain": xValue = row.strain; yValue = row.force_N; break;
                    case "StrainTime": xValue = row.time_s; yValue = row.strain; break;
                    case "ForceTime": xValue = row.time_s; yValue = row.force_N; break;
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

            int testId = Convert.ToInt32(
                chooseTestDataGridView.SelectedRows[0].Cells["id"].Value);

            string graphType =
                ((KeyValuePair<string, string>)chooseGraphicComboBox.SelectedItem).Value;

            DrawGraph(testId, graphType);
        }
    }
}