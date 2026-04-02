using System;
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
            GenerateTestData();
        }
    }
}
