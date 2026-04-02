using System;
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

            SetEnterLeaveTextBoxes();
        }

        private void materialInsertButton_Click(object sender, EventArgs e)
        {
            // Check that parameters are valid before inserting
            materialsTableAdapter.MaterialInsert(
                materialNameTextBox.Text,
                materialTypeTextBox.Text,
                decimal.TryParse(materialDensityTextBox.Text, out decimal density) ? density : 0,
                decimal.TryParse(materialYoungModulusTextBox.Text, out decimal youngModulus) ? youngModulus : 0,
                materialNoteTextBox.Text
            );
        }
    }
}
