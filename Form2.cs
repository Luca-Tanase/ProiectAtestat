using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectAtestat
{
    public partial class ReassignTestsForm : Form
    {
        public int SourceMaterialId { get; set; }
        public string SourceMaterialName {
            get => sourceMaterialNameLabel.Text;
            set => sourceMaterialNameLabel.Text += value;
        }
        public int TargetMaterialId { get; set; }

        public ReassignTestsForm()
        {
            InitializeComponent();
        }

        private void ReassignTestsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'testDatabaseDataSet.materials' table. You can move, or remove it, as needed.
            this.materialsTableAdapter.Fill(this.testDatabaseDataSet.materials);

            targetMaterialComboBox.SelectedIndex = -1;
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            if (targetMaterialComboBox.SelectedIndex < 0) return;
            TargetMaterialId = (int)targetMaterialComboBox.SelectedValue;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
