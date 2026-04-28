using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Dynamic;

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

            testDatabaseDataSet.EnforceConstraints = false;

            GenerateTestData();

            SetEnterLeaveTextBoxes();

            SetupDashboard();
            LoadDashboard();
            SetupMaterialsTab();
            SetupTestsTab();
            SetupTestResultsTab();
            SetupGraphicsTab();
            SetupExportTab();
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl.SelectedTab == dashboardPage)
                LoadDashboard();
            else if (tabControl.SelectedTab == materialPage)
                LoadMaterialsTab();
            else if (tabControl.SelectedTab == testPage)
                LoadTestsTab();
            else if (tabControl.SelectedTab == testResultPage)
                LoadTestResultsTab();
            else if (tabControl.SelectedTab == graphPage)
                LoadGraphicsTab();
            else if (tabControl.SelectedTab == exportPage)
                LoadExportTab();
        }

        private void materialsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.materialsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.testDatabaseDataSet);
        }
    }
}