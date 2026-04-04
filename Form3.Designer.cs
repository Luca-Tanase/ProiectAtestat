namespace ProiectAtestat
{
    partial class AvgMaxForceForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.minimumAverageMaxForceLabel = new System.Windows.Forms.Label();
            this.testNumberLabel = new System.Windows.Forms.Label();
            this.minAvgForceTextBox = new System.Windows.Forms.TextBox();
            this.minNumTestsTextBox = new System.Windows.Forms.TextBox();
            this.showResultButton = new System.Windows.Forms.Button();
            this.avgMaxForceDataGridView = new System.Windows.Forms.DataGridView();
            this.materialsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.testDatabaseDataSet = new ProiectAtestat.TestDatabaseDataSet();
            this.testResultsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.testResultsTableAdapter = new ProiectAtestat.TestDatabaseDataSetTableAdapters.testResultsTableAdapter();
            this.materialsTableAdapter = new ProiectAtestat.TestDatabaseDataSetTableAdapters.materialsTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.avgMaxForce = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.testCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.avgMaxForceDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testResultsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // minimumAverageMaxForceLabel
            // 
            this.minimumAverageMaxForceLabel.AutoSize = true;
            this.minimumAverageMaxForceLabel.Location = new System.Drawing.Point(12, 9);
            this.minimumAverageMaxForceLabel.Name = "minimumAverageMaxForceLabel";
            this.minimumAverageMaxForceLabel.Size = new System.Drawing.Size(178, 16);
            this.minimumAverageMaxForceLabel.TabIndex = 0;
            this.minimumAverageMaxForceLabel.Text = "Forță maximă medie minimă:";
            // 
            // testNumberLabel
            // 
            this.testNumberLabel.AutoSize = true;
            this.testNumberLabel.Location = new System.Drawing.Point(12, 93);
            this.testNumberLabel.Name = "testNumberLabel";
            this.testNumberLabel.Size = new System.Drawing.Size(139, 16);
            this.testNumberLabel.TabIndex = 1;
            this.testNumberLabel.Text = "Număr minim de teste:";
            // 
            // minAvgForceTextBox
            // 
            this.minAvgForceTextBox.Location = new System.Drawing.Point(15, 28);
            this.minAvgForceTextBox.Name = "minAvgForceTextBox";
            this.minAvgForceTextBox.Size = new System.Drawing.Size(100, 22);
            this.minAvgForceTextBox.TabIndex = 2;
            // 
            // minNumTestsTextBox
            // 
            this.minNumTestsTextBox.Location = new System.Drawing.Point(15, 112);
            this.minNumTestsTextBox.Name = "minNumTestsTextBox";
            this.minNumTestsTextBox.Size = new System.Drawing.Size(100, 22);
            this.minNumTestsTextBox.TabIndex = 3;
            // 
            // showResultButton
            // 
            this.showResultButton.Location = new System.Drawing.Point(521, 63);
            this.showResultButton.Name = "showResultButton";
            this.showResultButton.Size = new System.Drawing.Size(142, 36);
            this.showResultButton.TabIndex = 4;
            this.showResultButton.Text = "Afișează rezultate";
            this.showResultButton.UseVisualStyleBackColor = true;
            this.showResultButton.Click += new System.EventHandler(this.showResultButton_Click);
            // 
            // avgMaxForceDataGridView
            // 
            this.avgMaxForceDataGridView.AutoGenerateColumns = false;
            this.avgMaxForceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.avgMaxForceDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.name,
            this.avgMaxForce,
            this.testCount});
            this.avgMaxForceDataGridView.DataSource = this.materialsBindingSource;
            this.avgMaxForceDataGridView.Location = new System.Drawing.Point(15, 195);
            this.avgMaxForceDataGridView.Name = "avgMaxForceDataGridView";
            this.avgMaxForceDataGridView.RowHeadersWidth = 51;
            this.avgMaxForceDataGridView.RowTemplate.Height = 24;
            this.avgMaxForceDataGridView.Size = new System.Drawing.Size(737, 243);
            this.avgMaxForceDataGridView.TabIndex = 5;
            // 
            // materialsBindingSource
            // 
            this.materialsBindingSource.DataMember = "materials";
            this.materialsBindingSource.DataSource = this.testDatabaseDataSet;
            // 
            // testDatabaseDataSet
            // 
            this.testDatabaseDataSet.DataSetName = "TestDatabaseDataSet";
            this.testDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // testResultsBindingSource
            // 
            this.testResultsBindingSource.DataMember = "testResults";
            this.testResultsBindingSource.DataSource = this.testDatabaseDataSet;
            // 
            // testResultsTableAdapter
            // 
            this.testResultsTableAdapter.ClearBeforeFill = true;
            // 
            // materialsTableAdapter
            // 
            this.materialsTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "name";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.Width = 125;
            // 
            // avgMaxForce
            // 
            this.avgMaxForce.DataPropertyName = "avgMaxForce";
            this.avgMaxForce.HeaderText = "avgMaxForce";
            this.avgMaxForce.MinimumWidth = 6;
            this.avgMaxForce.Name = "avgMaxForce";
            this.avgMaxForce.Width = 125;
            // 
            // testCount
            // 
            this.testCount.DataPropertyName = "testCount";
            this.testCount.HeaderText = "testCount";
            this.testCount.MinimumWidth = 6;
            this.testCount.Name = "testCount";
            this.testCount.Width = 125;
            // 
            // AvgMaxForceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.avgMaxForceDataGridView);
            this.Controls.Add(this.showResultButton);
            this.Controls.Add(this.minNumTestsTextBox);
            this.Controls.Add(this.minAvgForceTextBox);
            this.Controls.Add(this.testNumberLabel);
            this.Controls.Add(this.minimumAverageMaxForceLabel);
            this.Name = "AvgMaxForceForm";
            this.Text = "Filtrare materiale după performanța testelor";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.avgMaxForceDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testResultsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label minimumAverageMaxForceLabel;
        private System.Windows.Forms.Label testNumberLabel;
        private System.Windows.Forms.TextBox minAvgForceTextBox;
        private System.Windows.Forms.TextBox minNumTestsTextBox;
        private System.Windows.Forms.Button showResultButton;
        private System.Windows.Forms.DataGridView avgMaxForceDataGridView;
        private TestDatabaseDataSet testDatabaseDataSet;
        private System.Windows.Forms.BindingSource testResultsBindingSource;
        private TestDatabaseDataSetTableAdapters.testResultsTableAdapter testResultsTableAdapter;
        private System.Windows.Forms.BindingSource materialsBindingSource;
        private TestDatabaseDataSetTableAdapters.materialsTableAdapter materialsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn avgMaxForce;
        private System.Windows.Forms.DataGridViewTextBoxColumn testCount;
    }
}