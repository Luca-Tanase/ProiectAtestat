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

        public mainForm()
        {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            this.materialsMaxForceTestsTableAdapter.GetMaxForceTests(this.testDatabaseDataSet.materialsMaxForceTests);
            this.testsTableAdapter.Fill(this.testDatabaseDataSet.tests);
            this.testResultsTableAdapter.Fill(this.testDatabaseDataSet.testResults);
            this.materialsTableAdapter.Fill(this.testDatabaseDataSet.materials);

            materialsOutputDataGridView.DataSource = testDatabaseDataSet.materials;
            materialsOutputDataGridView.ReadOnly = true;
            materialsOutputDataGridView.AllowUserToAddRows = false;
            materialsOutputDataGridView.AllowUserToDeleteRows = false;
            materialsOutputDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

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

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl.SelectedTab == dashboardPage)
                LoadDashboard();
            else if (tabControl.SelectedTab == materialPage)
                materialsTableAdapter.Fill(testDatabaseDataSet.materials);
            else if (tabControl.SelectedTab == testPage)
                testsTableAdapter.Fill(testDatabaseDataSet.tests);
            else if (tabControl.SelectedTab == testResultPage)
                testResultsTableAdapter.Fill(testDatabaseDataSet.testResults);
        }

        private void materialsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.materialsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.testDatabaseDataSet);
        }
    }
}