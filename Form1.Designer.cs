namespace ProiectAtestat
{
    partial class mainForm
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.dashboardPage = new System.Windows.Forms.TabPage();
            this.materialPage = new System.Windows.Forms.TabPage();
            this.materialNameTextBox = new System.Windows.Forms.TextBox();
            this.materialInsertLabel = new System.Windows.Forms.Label();
            this.testPage = new System.Windows.Forms.TabPage();
            this.resultPage = new System.Windows.Forms.TabPage();
            this.graphPage = new System.Windows.Forms.TabPage();
            this.exportPage = new System.Windows.Forms.TabPage();
            this.materialTypeTextBox = new System.Windows.Forms.TextBox();
            this.materialDensityTextBox = new System.Windows.Forms.TextBox();
            this.materialYoungModulusTextBox = new System.Windows.Forms.TextBox();
            this.materialInsertButton = new System.Windows.Forms.Button();
            this.materialNotesTextBox = new System.Windows.Forms.TextBox();
            this.testDatabaseDataSet = new ProiectAtestat.TestDatabaseDataSet();
            this.materialsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.materialsTableAdapter = new ProiectAtestat.TestDatabaseDataSetTableAdapters.materialsTableAdapter();
            this.tableAdapterManager = new ProiectAtestat.TestDatabaseDataSetTableAdapters.TableAdapterManager();
            this.testResultsTableAdapter = new ProiectAtestat.TestDatabaseDataSetTableAdapters.testResultsTableAdapter();
            this.testsTableAdapter = new ProiectAtestat.TestDatabaseDataSetTableAdapters.testsTableAdapter();
            this.testResultsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.testsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.testInsertButton = new System.Windows.Forms.Button();
            this.testMaterialIdTextBox = new System.Windows.Forms.TextBox();
            this.testNotesTextBox = new System.Windows.Forms.TextBox();
            this.testTypeTextBox = new System.Windows.Forms.TextBox();
            this.testInsertLabel = new System.Windows.Forms.Label();
            this.testResultTestIdTextBox = new System.Windows.Forms.TextBox();
            this.testResultInsertButton = new System.Windows.Forms.Button();
            this.testResultNotesTextBox = new System.Windows.Forms.TextBox();
            this.testResultStrainTextBox = new System.Windows.Forms.TextBox();
            this.testResultForceTextBox = new System.Windows.Forms.TextBox();
            this.testResultTimeTextBox = new System.Windows.Forms.TextBox();
            this.testResultInsertLabel = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.materialPage.SuspendLayout();
            this.testPage.SuspendLayout();
            this.resultPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.testDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testResultsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.dashboardPage);
            this.tabControl.Controls.Add(this.materialPage);
            this.tabControl.Controls.Add(this.testPage);
            this.tabControl.Controls.Add(this.resultPage);
            this.tabControl.Controls.Add(this.graphPage);
            this.tabControl.Controls.Add(this.exportPage);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1067, 554);
            this.tabControl.TabIndex = 0;
            // 
            // dashboardPage
            // 
            this.dashboardPage.AutoScroll = true;
            this.dashboardPage.Location = new System.Drawing.Point(4, 25);
            this.dashboardPage.Margin = new System.Windows.Forms.Padding(4);
            this.dashboardPage.Name = "dashboardPage";
            this.dashboardPage.Padding = new System.Windows.Forms.Padding(4);
            this.dashboardPage.Size = new System.Drawing.Size(1059, 525);
            this.dashboardPage.TabIndex = 0;
            this.dashboardPage.Text = "Dashboard";
            this.dashboardPage.UseVisualStyleBackColor = true;
            // 
            // materialPage
            // 
            this.materialPage.Controls.Add(this.materialNotesTextBox);
            this.materialPage.Controls.Add(this.materialInsertButton);
            this.materialPage.Controls.Add(this.materialYoungModulusTextBox);
            this.materialPage.Controls.Add(this.materialDensityTextBox);
            this.materialPage.Controls.Add(this.materialTypeTextBox);
            this.materialPage.Controls.Add(this.materialNameTextBox);
            this.materialPage.Controls.Add(this.materialInsertLabel);
            this.materialPage.Location = new System.Drawing.Point(4, 25);
            this.materialPage.Margin = new System.Windows.Forms.Padding(4);
            this.materialPage.Name = "materialPage";
            this.materialPage.Padding = new System.Windows.Forms.Padding(4);
            this.materialPage.Size = new System.Drawing.Size(1059, 525);
            this.materialPage.TabIndex = 1;
            this.materialPage.Text = "Materiale";
            this.materialPage.UseVisualStyleBackColor = true;
            // 
            // materialNameTextBox
            // 
            this.materialNameTextBox.ForeColor = System.Drawing.Color.Gray;
            this.materialNameTextBox.Location = new System.Drawing.Point(11, 64);
            this.materialNameTextBox.Name = "materialNameTextBox";
            this.materialNameTextBox.Size = new System.Drawing.Size(100, 22);
            this.materialNameTextBox.TabIndex = 1;
            this.materialNameTextBox.Text = "Nume material";
            // 
            // materialInsertLabel
            // 
            this.materialInsertLabel.AutoSize = true;
            this.materialInsertLabel.Location = new System.Drawing.Point(8, 14);
            this.materialInsertLabel.Name = "materialInsertLabel";
            this.materialInsertLabel.Size = new System.Drawing.Size(120, 16);
            this.materialInsertLabel.TabIndex = 0;
            this.materialInsertLabel.Text = "Inserează material:";
            // 
            // testPage
            // 
            this.testPage.Controls.Add(this.testInsertButton);
            this.testPage.Controls.Add(this.testMaterialIdTextBox);
            this.testPage.Controls.Add(this.testNotesTextBox);
            this.testPage.Controls.Add(this.testTypeTextBox);
            this.testPage.Controls.Add(this.testInsertLabel);
            this.testPage.Location = new System.Drawing.Point(4, 25);
            this.testPage.Margin = new System.Windows.Forms.Padding(4);
            this.testPage.Name = "testPage";
            this.testPage.Padding = new System.Windows.Forms.Padding(4);
            this.testPage.Size = new System.Drawing.Size(1059, 525);
            this.testPage.TabIndex = 2;
            this.testPage.Text = "Teste";
            this.testPage.UseVisualStyleBackColor = true;
            // 
            // resultPage
            // 
            this.resultPage.Controls.Add(this.testResultTestIdTextBox);
            this.resultPage.Controls.Add(this.testResultInsertButton);
            this.resultPage.Controls.Add(this.testResultNotesTextBox);
            this.resultPage.Controls.Add(this.testResultStrainTextBox);
            this.resultPage.Controls.Add(this.testResultForceTextBox);
            this.resultPage.Controls.Add(this.testResultTimeTextBox);
            this.resultPage.Controls.Add(this.testResultInsertLabel);
            this.resultPage.Location = new System.Drawing.Point(4, 25);
            this.resultPage.Margin = new System.Windows.Forms.Padding(4);
            this.resultPage.Name = "resultPage";
            this.resultPage.Padding = new System.Windows.Forms.Padding(4);
            this.resultPage.Size = new System.Drawing.Size(1059, 525);
            this.resultPage.TabIndex = 3;
            this.resultPage.Text = "Rezultate Teste ";
            this.resultPage.UseVisualStyleBackColor = true;
            // 
            // graphPage
            // 
            this.graphPage.Location = new System.Drawing.Point(4, 25);
            this.graphPage.Margin = new System.Windows.Forms.Padding(4);
            this.graphPage.Name = "graphPage";
            this.graphPage.Padding = new System.Windows.Forms.Padding(4);
            this.graphPage.Size = new System.Drawing.Size(1059, 525);
            this.graphPage.TabIndex = 4;
            this.graphPage.Text = "Grafice";
            this.graphPage.UseVisualStyleBackColor = true;
            // 
            // exportPage
            // 
            this.exportPage.Location = new System.Drawing.Point(4, 25);
            this.exportPage.Margin = new System.Windows.Forms.Padding(4);
            this.exportPage.Name = "exportPage";
            this.exportPage.Padding = new System.Windows.Forms.Padding(4);
            this.exportPage.Size = new System.Drawing.Size(1059, 525);
            this.exportPage.TabIndex = 5;
            this.exportPage.Text = "Export";
            this.exportPage.UseVisualStyleBackColor = true;
            // 
            // materialTypeTextBox
            // 
            this.materialTypeTextBox.ForeColor = System.Drawing.Color.Gray;
            this.materialTypeTextBox.Location = new System.Drawing.Point(149, 64);
            this.materialTypeTextBox.Name = "materialTypeTextBox";
            this.materialTypeTextBox.Size = new System.Drawing.Size(100, 22);
            this.materialTypeTextBox.TabIndex = 2;
            this.materialTypeTextBox.Text = "Tip";
            // 
            // materialDensityTextBox
            // 
            this.materialDensityTextBox.ForeColor = System.Drawing.Color.Gray;
            this.materialDensityTextBox.Location = new System.Drawing.Point(293, 64);
            this.materialDensityTextBox.Name = "materialDensityTextBox";
            this.materialDensityTextBox.Size = new System.Drawing.Size(115, 22);
            this.materialDensityTextBox.TabIndex = 3;
            this.materialDensityTextBox.Text = "Densitate";
            // 
            // materialYoungModulusTextBox
            // 
            this.materialYoungModulusTextBox.ForeColor = System.Drawing.Color.Gray;
            this.materialYoungModulusTextBox.Location = new System.Drawing.Point(437, 64);
            this.materialYoungModulusTextBox.Name = "materialYoungModulusTextBox";
            this.materialYoungModulusTextBox.Size = new System.Drawing.Size(100, 22);
            this.materialYoungModulusTextBox.TabIndex = 4;
            this.materialYoungModulusTextBox.Text = "Modul Young";
            // 
            // materialInsertButton
            // 
            this.materialInsertButton.Location = new System.Drawing.Point(760, 59);
            this.materialInsertButton.Name = "materialInsertButton";
            this.materialInsertButton.Size = new System.Drawing.Size(116, 32);
            this.materialInsertButton.TabIndex = 5;
            this.materialInsertButton.Text = "Inserează";
            this.materialInsertButton.UseVisualStyleBackColor = true;
            this.materialInsertButton.Click += new System.EventHandler(this.materialInsertButton_Click);
            // 
            // materialNotesTextBox
            // 
            this.materialNotesTextBox.ForeColor = System.Drawing.Color.Gray;
            this.materialNotesTextBox.Location = new System.Drawing.Point(572, 64);
            this.materialNotesTextBox.Name = "materialNotesTextBox";
            this.materialNotesTextBox.Size = new System.Drawing.Size(101, 22);
            this.materialNotesTextBox.TabIndex = 6;
            this.materialNotesTextBox.Text = "Descriere (opt)";
            // 
            // testDatabaseDataSet
            // 
            this.testDatabaseDataSet.DataSetName = "TestDatabaseDataSet";
            this.testDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // materialsBindingSource
            // 
            this.materialsBindingSource.DataMember = "materials";
            this.materialsBindingSource.DataSource = this.testDatabaseDataSet;
            // 
            // materialsTableAdapter
            // 
            this.materialsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.materialsTableAdapter = this.materialsTableAdapter;
            this.tableAdapterManager.testResultsTableAdapter = this.testResultsTableAdapter;
            this.tableAdapterManager.testsTableAdapter = this.testsTableAdapter;
            this.tableAdapterManager.UpdateOrder = ProiectAtestat.TestDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // testResultsTableAdapter
            // 
            this.testResultsTableAdapter.ClearBeforeFill = true;
            // 
            // testsTableAdapter
            // 
            this.testsTableAdapter.ClearBeforeFill = true;
            // 
            // testResultsBindingSource
            // 
            this.testResultsBindingSource.DataMember = "testResults";
            this.testResultsBindingSource.DataSource = this.testDatabaseDataSet;
            // 
            // testsBindingSource
            // 
            this.testsBindingSource.DataMember = "tests";
            this.testsBindingSource.DataSource = this.testDatabaseDataSet;
            // 
            // testInsertButton
            // 
            this.testInsertButton.Location = new System.Drawing.Point(478, 59);
            this.testInsertButton.Name = "testInsertButton";
            this.testInsertButton.Size = new System.Drawing.Size(116, 32);
            this.testInsertButton.TabIndex = 12;
            this.testInsertButton.Text = "Inserează";
            this.testInsertButton.UseVisualStyleBackColor = true;
            this.testInsertButton.Click += new System.EventHandler(this.testInsertButton_Click);
            // 
            // testMaterialIdTextBox
            // 
            this.testMaterialIdTextBox.ForeColor = System.Drawing.Color.Gray;
            this.testMaterialIdTextBox.Location = new System.Drawing.Point(293, 64);
            this.testMaterialIdTextBox.Name = "testMaterialIdTextBox";
            this.testMaterialIdTextBox.Size = new System.Drawing.Size(123, 22);
            this.testMaterialIdTextBox.TabIndex = 10;
            this.testMaterialIdTextBox.Text = "Id material asociat";
            // 
            // testNotesTextBox
            // 
            this.testNotesTextBox.ForeColor = System.Drawing.Color.Gray;
            this.testNotesTextBox.Location = new System.Drawing.Point(149, 64);
            this.testNotesTextBox.Name = "testNotesTextBox";
            this.testNotesTextBox.Size = new System.Drawing.Size(106, 22);
            this.testNotesTextBox.TabIndex = 9;
            this.testNotesTextBox.Text = "Comentarii (opț.)";
            // 
            // testTypeTextBox
            // 
            this.testTypeTextBox.ForeColor = System.Drawing.Color.Gray;
            this.testTypeTextBox.Location = new System.Drawing.Point(11, 64);
            this.testTypeTextBox.Name = "testTypeTextBox";
            this.testTypeTextBox.Size = new System.Drawing.Size(100, 22);
            this.testTypeTextBox.TabIndex = 8;
            this.testTypeTextBox.Text = "Tip test";
            // 
            // testInsertLabel
            // 
            this.testInsertLabel.AutoSize = true;
            this.testInsertLabel.Location = new System.Drawing.Point(8, 14);
            this.testInsertLabel.Name = "testInsertLabel";
            this.testInsertLabel.Size = new System.Drawing.Size(93, 16);
            this.testInsertLabel.TabIndex = 7;
            this.testInsertLabel.Text = "Inserează test:";
            // 
            // testResultTestIdTextBox
            // 
            this.testResultTestIdTextBox.ForeColor = System.Drawing.Color.Gray;
            this.testResultTestIdTextBox.Location = new System.Drawing.Point(570, 64);
            this.testResultTestIdTextBox.Name = "testResultTestIdTextBox";
            this.testResultTestIdTextBox.Size = new System.Drawing.Size(97, 22);
            this.testResultTestIdTextBox.TabIndex = 13;
            this.testResultTestIdTextBox.Text = "Id test asociat";
            // 
            // testResultInsertButton
            // 
            this.testResultInsertButton.Location = new System.Drawing.Point(755, 59);
            this.testResultInsertButton.Name = "testResultInsertButton";
            this.testResultInsertButton.Size = new System.Drawing.Size(116, 32);
            this.testResultInsertButton.TabIndex = 12;
            this.testResultInsertButton.Text = "Inserează";
            this.testResultInsertButton.UseVisualStyleBackColor = true;
            this.testResultInsertButton.Click += new System.EventHandler(this.testResultInsertButton_Click);
            // 
            // testResultNotesTextBox
            // 
            this.testResultNotesTextBox.ForeColor = System.Drawing.Color.Gray;
            this.testResultNotesTextBox.Location = new System.Drawing.Point(433, 64);
            this.testResultNotesTextBox.Name = "testResultNotesTextBox";
            this.testResultNotesTextBox.Size = new System.Drawing.Size(108, 22);
            this.testResultNotesTextBox.TabIndex = 11;
            this.testResultNotesTextBox.Text = "Comentarii (opț.)";
            // 
            // testResultStrainTextBox
            // 
            this.testResultStrainTextBox.ForeColor = System.Drawing.Color.Gray;
            this.testResultStrainTextBox.Location = new System.Drawing.Point(293, 64);
            this.testResultStrainTextBox.Name = "testResultStrainTextBox";
            this.testResultStrainTextBox.Size = new System.Drawing.Size(115, 22);
            this.testResultStrainTextBox.TabIndex = 10;
            this.testResultStrainTextBox.Text = "Alungire relativă";
            // 
            // testResultForceTextBox
            // 
            this.testResultForceTextBox.ForeColor = System.Drawing.Color.Gray;
            this.testResultForceTextBox.Location = new System.Drawing.Point(150, 64);
            this.testResultForceTextBox.Name = "testResultForceTextBox";
            this.testResultForceTextBox.Size = new System.Drawing.Size(100, 22);
            this.testResultForceTextBox.TabIndex = 9;
            this.testResultForceTextBox.Text = "Forță";
            // 
            // testResultTimeTextBox
            // 
            this.testResultTimeTextBox.ForeColor = System.Drawing.Color.Gray;
            this.testResultTimeTextBox.Location = new System.Drawing.Point(11, 64);
            this.testResultTimeTextBox.Name = "testResultTimeTextBox";
            this.testResultTimeTextBox.Size = new System.Drawing.Size(100, 22);
            this.testResultTimeTextBox.TabIndex = 8;
            this.testResultTimeTextBox.Text = "Timp (s)";
            // 
            // testResultInsertLabel
            // 
            this.testResultInsertLabel.AutoSize = true;
            this.testResultInsertLabel.Location = new System.Drawing.Point(8, 14);
            this.testResultInsertLabel.Name = "testResultInsertLabel";
            this.testResultInsertLabel.Size = new System.Drawing.Size(138, 16);
            this.testResultInsertLabel.TabIndex = 7;
            this.testResultInsertLabel.Text = "Inserează rezultat test:";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.tabControl);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "mainForm";
            this.Text = "Evidență Materiale și Proprietăți mecanice";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.tabControl.ResumeLayout(false);
            this.materialPage.ResumeLayout(false);
            this.materialPage.PerformLayout();
            this.testPage.ResumeLayout(false);
            this.testPage.PerformLayout();
            this.resultPage.ResumeLayout(false);
            this.resultPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.testDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testResultsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage dashboardPage;
        private System.Windows.Forms.TabPage materialPage;
        private System.Windows.Forms.TabPage testPage;
        private System.Windows.Forms.TabPage resultPage;
        private System.Windows.Forms.TabPage graphPage;
        private System.Windows.Forms.TabPage exportPage;
        private TestDatabaseDataSet testDatabaseDataSet;
        private System.Windows.Forms.BindingSource materialsBindingSource;
        private TestDatabaseDataSetTableAdapters.materialsTableAdapter materialsTableAdapter;
        private TestDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private TestDatabaseDataSetTableAdapters.testResultsTableAdapter testResultsTableAdapter;
        private System.Windows.Forms.BindingSource testResultsBindingSource;
        private TestDatabaseDataSetTableAdapters.testsTableAdapter testsTableAdapter;
        private System.Windows.Forms.BindingSource testsBindingSource;
        private System.Windows.Forms.Label materialInsertLabel;
        private System.Windows.Forms.TextBox materialNameTextBox;
        private System.Windows.Forms.TextBox materialYoungModulusTextBox;
        private System.Windows.Forms.TextBox materialDensityTextBox;
        private System.Windows.Forms.TextBox materialTypeTextBox;
        private System.Windows.Forms.Button materialInsertButton;
        private System.Windows.Forms.TextBox materialNotesTextBox;
        private System.Windows.Forms.Button testInsertButton;
        private System.Windows.Forms.TextBox testMaterialIdTextBox;
        private System.Windows.Forms.TextBox testNotesTextBox;
        private System.Windows.Forms.TextBox testTypeTextBox;
        private System.Windows.Forms.Label testInsertLabel;
        private System.Windows.Forms.TextBox testResultTestIdTextBox;
        private System.Windows.Forms.Button testResultInsertButton;
        private System.Windows.Forms.TextBox testResultNotesTextBox;
        private System.Windows.Forms.TextBox testResultStrainTextBox;
        private System.Windows.Forms.TextBox testResultForceTextBox;
        private System.Windows.Forms.TextBox testResultTimeTextBox;
        private System.Windows.Forms.Label testResultInsertLabel;
    }
}

