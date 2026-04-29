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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.dashboardPage = new System.Windows.Forms.TabPage();
            this.testNumLabel = new System.Windows.Forms.Label();
            this.materialNumLabel = new System.Windows.Forms.Label();
            this.fileModelDownload = new System.Windows.Forms.Button();
            this.fileImportButton = new System.Windows.Forms.Button();
            this.fileImportComboBox = new System.Windows.Forms.ComboBox();
            this.fileImportLabel = new System.Windows.Forms.Label();
            this.lastTestLabel = new System.Windows.Forms.Label();
            this.lastTestDataGridView = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.testDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.testMaxForce = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.testMaxStrain = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.testDatabaseDataSet = new ProiectAtestat.TestDatabaseDataSet();
            this.materialPage = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.maxForceTestsButton = new System.Windows.Forms.Button();
            this.testReassignButton = new System.Windows.Forms.Button();
            this.avgMaxForceButton = new System.Windows.Forms.Button();
            this.findForceVariationButton = new System.Windows.Forms.Button();
            this.forceVariationPanel = new System.Windows.Forms.Panel();
            this.showVariationResultButton = new System.Windows.Forms.Button();
            this.minTestNumTextBox = new System.Windows.Forms.TextBox();
            this.minForceVariationTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.forceVariationLabel = new System.Windows.Forms.Label();
            this.maxForceTestsPanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.averageForcePanel = new System.Windows.Forms.Panel();
            this.showResultButton = new System.Windows.Forms.Button();
            this.minNumTestsTextBox = new System.Windows.Forms.TextBox();
            this.minAvgForceTextBox = new System.Windows.Forms.TextBox();
            this.testNumberLabel = new System.Windows.Forms.Label();
            this.minimumAverageMaxForceLabel = new System.Windows.Forms.Label();
            this.averageForceLabel = new System.Windows.Forms.Label();
            this.reassignPanel = new System.Windows.Forms.Panel();
            this.reassignLabel = new System.Windows.Forms.Label();
            this.sourceMaterialNameLabel = new System.Windows.Forms.Label();
            this.targetMaterialNameLabel = new System.Windows.Forms.Label();
            this.targetMaterialComboBox = new System.Windows.Forms.ComboBox();
            this.cancelReassignButton = new System.Windows.Forms.Button();
            this.confirmReassignButton = new System.Windows.Forms.Button();
            this.materialsOutputDataGridView = new System.Windows.Forms.DataGridView();
            this.materialDeleteButton = new System.Windows.Forms.Button();
            this.materialsInputDataGridView = new System.Windows.Forms.DataGridView();
            this.materialsInputId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialsInputName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialsInputType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialsInputDensity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialsInputYoungModulus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialsInputNotes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialNotesTextBox = new System.Windows.Forms.TextBox();
            this.materialInsertButton = new System.Windows.Forms.Button();
            this.materialYoungModulusTextBox = new System.Windows.Forms.TextBox();
            this.materialDensityTextBox = new System.Windows.Forms.TextBox();
            this.materialTypeTextBox = new System.Windows.Forms.TextBox();
            this.materialNameTextBox = new System.Windows.Forms.TextBox();
            this.materialInsertLabel = new System.Windows.Forms.Label();
            this.testPage = new System.Windows.Forms.TabPage();
            this.testStatisticsUpdateButton = new System.Windows.Forms.Button();
            this.testsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.testsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.testInsertButton = new System.Windows.Forms.Button();
            this.testMaterialIdTextBox = new System.Windows.Forms.TextBox();
            this.testNotesTextBox = new System.Windows.Forms.TextBox();
            this.testTypeTextBox = new System.Windows.Forms.TextBox();
            this.testInsertLabel = new System.Windows.Forms.Label();
            this.testResultPage = new System.Windows.Forms.TabPage();
            this.hasNotesButton = new System.Windows.Forms.Button();
            this.defaultNotesButton = new System.Windows.Forms.Button();
            this.testResultsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.testResultsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.testResultTestIdTextBox = new System.Windows.Forms.TextBox();
            this.testResultInsertButton = new System.Windows.Forms.Button();
            this.testResultNotesTextBox = new System.Windows.Forms.TextBox();
            this.testResultStrainTextBox = new System.Windows.Forms.TextBox();
            this.testResultForceTextBox = new System.Windows.Forms.TextBox();
            this.testResultTimeTextBox = new System.Windows.Forms.TextBox();
            this.testResultInsertLabel = new System.Windows.Forms.Label();
            this.graphPage = new System.Windows.Forms.TabPage();
            this.executeGraphicButton = new System.Windows.Forms.Button();
            this.chooseGraphicComboBox = new System.Windows.Forms.ComboBox();
            this.chooseTestDataGridView = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxForceNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxStrainDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.youngModulusEstGPaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.graphicsChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.exportPage = new System.Windows.Forms.TabPage();
            this.exportWithoutIdCheckBox = new System.Windows.Forms.CheckBox();
            this.tableExportComboBox = new System.Windows.Forms.ComboBox();
            this.exportTableButton = new System.Windows.Forms.Button();
            this.materialsForceFilteredBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.materialsTableAdapter = new ProiectAtestat.TestDatabaseDataSetTableAdapters.materialsTableAdapter();
            this.tableAdapterManager = new ProiectAtestat.TestDatabaseDataSetTableAdapters.TableAdapterManager();
            this.testResultsTableAdapter = new ProiectAtestat.TestDatabaseDataSetTableAdapters.testResultsTableAdapter();
            this.testsTableAdapter = new ProiectAtestat.TestDatabaseDataSetTableAdapters.testsTableAdapter();
            this.materialsForceFilteredTableAdapter = new ProiectAtestat.TestDatabaseDataSetTableAdapters.materialsForceFilteredTableAdapter();
            this.materialsMaxForceTestsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.materialsMaxForceTestsTableAdapter = new ProiectAtestat.TestDatabaseDataSetTableAdapters.materialsMaxForceTestsTableAdapter();
            this.materialsForceVariationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.materialsForceVariationTableAdapter = new ProiectAtestat.TestDatabaseDataSetTableAdapters.materialsForceVariationTableAdapter();
            this.materialsDashboardBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.materialsDashboardTableAdapter = new ProiectAtestat.TestDatabaseDataSetTableAdapters.materialsDashboardTableAdapter();
            this.tabControl.SuspendLayout();
            this.dashboardPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lastTestDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDatabaseDataSet)).BeginInit();
            this.materialPage.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.forceVariationPanel.SuspendLayout();
            this.maxForceTestsPanel.SuspendLayout();
            this.averageForcePanel.SuspendLayout();
            this.reassignPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.materialsOutputDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialsInputDataGridView)).BeginInit();
            this.testPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.testsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testsBindingSource)).BeginInit();
            this.testResultPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.testResultsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testResultsBindingSource)).BeginInit();
            this.graphPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chooseTestDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graphicsChart)).BeginInit();
            this.exportPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.materialsForceFilteredBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialsMaxForceTestsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialsForceVariationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialsDashboardBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.dashboardPage);
            this.tabControl.Controls.Add(this.materialPage);
            this.tabControl.Controls.Add(this.testPage);
            this.tabControl.Controls.Add(this.testResultPage);
            this.tabControl.Controls.Add(this.graphPage);
            this.tabControl.Controls.Add(this.exportPage);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1116, 869);
            this.tabControl.TabIndex = 0;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // dashboardPage
            // 
            this.dashboardPage.AutoScroll = true;
            this.dashboardPage.Controls.Add(this.testNumLabel);
            this.dashboardPage.Controls.Add(this.materialNumLabel);
            this.dashboardPage.Controls.Add(this.fileModelDownload);
            this.dashboardPage.Controls.Add(this.fileImportButton);
            this.dashboardPage.Controls.Add(this.fileImportComboBox);
            this.dashboardPage.Controls.Add(this.fileImportLabel);
            this.dashboardPage.Controls.Add(this.lastTestLabel);
            this.dashboardPage.Controls.Add(this.lastTestDataGridView);
            this.dashboardPage.Location = new System.Drawing.Point(4, 25);
            this.dashboardPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dashboardPage.Name = "dashboardPage";
            this.dashboardPage.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dashboardPage.Size = new System.Drawing.Size(1108, 840);
            this.dashboardPage.TabIndex = 0;
            this.dashboardPage.Text = "Dashboard";
            this.dashboardPage.UseVisualStyleBackColor = true;
            // 
            // testNumLabel
            // 
            this.testNumLabel.AutoSize = true;
            this.testNumLabel.Location = new System.Drawing.Point(8, 43);
            this.testNumLabel.Name = "testNumLabel";
            this.testNumLabel.Size = new System.Drawing.Size(101, 16);
            this.testNumLabel.TabIndex = 7;
            this.testNumLabel.Text = "Număr de teste:";
            // 
            // materialNumLabel
            // 
            this.materialNumLabel.AutoSize = true;
            this.materialNumLabel.Location = new System.Drawing.Point(8, 14);
            this.materialNumLabel.Name = "materialNumLabel";
            this.materialNumLabel.Size = new System.Drawing.Size(128, 16);
            this.materialNumLabel.TabIndex = 6;
            this.materialNumLabel.Text = "Număr de materiale:";
            // 
            // fileModelDownload
            // 
            this.fileModelDownload.Location = new System.Drawing.Point(675, 154);
            this.fileModelDownload.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fileModelDownload.Name = "fileModelDownload";
            this.fileModelDownload.Size = new System.Drawing.Size(169, 30);
            this.fileModelDownload.TabIndex = 5;
            this.fileModelDownload.Text = "Descarcă model CSV";
            this.fileModelDownload.UseVisualStyleBackColor = true;
            this.fileModelDownload.Click += new System.EventHandler(this.fileModelDownload_Click);
            // 
            // fileImportButton
            // 
            this.fileImportButton.Location = new System.Drawing.Point(675, 118);
            this.fileImportButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fileImportButton.Name = "fileImportButton";
            this.fileImportButton.Size = new System.Drawing.Size(128, 30);
            this.fileImportButton.TabIndex = 4;
            this.fileImportButton.Text = "Importă date";
            this.fileImportButton.UseVisualStyleBackColor = true;
            this.fileImportButton.Click += new System.EventHandler(this.fileImportButton_Click);
            // 
            // fileImportComboBox
            // 
            this.fileImportComboBox.FormattingEnabled = true;
            this.fileImportComboBox.Location = new System.Drawing.Point(675, 68);
            this.fileImportComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fileImportComboBox.Name = "fileImportComboBox";
            this.fileImportComboBox.Size = new System.Drawing.Size(159, 24);
            this.fileImportComboBox.TabIndex = 3;
            // 
            // fileImportLabel
            // 
            this.fileImportLabel.AutoSize = true;
            this.fileImportLabel.Location = new System.Drawing.Point(672, 32);
            this.fileImportLabel.Name = "fileImportLabel";
            this.fileImportLabel.Size = new System.Drawing.Size(186, 16);
            this.fileImportLabel.TabIndex = 2;
            this.fileImportLabel.Text = "Importează date din fișier CSV";
            // 
            // lastTestLabel
            // 
            this.lastTestLabel.AutoSize = true;
            this.lastTestLabel.Location = new System.Drawing.Point(8, 94);
            this.lastTestLabel.Name = "lastTestLabel";
            this.lastTestLabel.Size = new System.Drawing.Size(185, 16);
            this.lastTestLabel.TabIndex = 1;
            this.lastTestLabel.Text = "Ultimul test al fiecărui material:";
            // 
            // lastTestDataGridView
            // 
            this.lastTestDataGridView.AutoGenerateColumns = false;
            this.lastTestDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lastTestDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.testDate,
            this.testMaxForce,
            this.testMaxStrain});
            this.lastTestDataGridView.DataSource = this.materialsBindingSource;
            this.lastTestDataGridView.Location = new System.Drawing.Point(11, 118);
            this.lastTestDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lastTestDataGridView.Name = "lastTestDataGridView";
            this.lastTestDataGridView.RowHeadersWidth = 51;
            this.lastTestDataGridView.RowTemplate.Height = 24;
            this.lastTestDataGridView.Size = new System.Drawing.Size(552, 142);
            this.lastTestDataGridView.TabIndex = 0;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // testDate
            // 
            this.testDate.DataPropertyName = "date";
            this.testDate.HeaderText = "Date";
            this.testDate.MinimumWidth = 6;
            this.testDate.Name = "testDate";
            this.testDate.Width = 125;
            // 
            // testMaxForce
            // 
            this.testMaxForce.DataPropertyName = "maxForce_N";
            this.testMaxForce.HeaderText = "Max Force ";
            this.testMaxForce.MinimumWidth = 6;
            this.testMaxForce.Name = "testMaxForce";
            this.testMaxForce.Width = 125;
            // 
            // testMaxStrain
            // 
            this.testMaxStrain.DataPropertyName = "maxStrain";
            this.testMaxStrain.HeaderText = "Max Strain";
            this.testMaxStrain.MinimumWidth = 6;
            this.testMaxStrain.Name = "testMaxStrain";
            this.testMaxStrain.Width = 125;
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
            // materialPage
            // 
            this.materialPage.AutoScroll = true;
            this.materialPage.Controls.Add(this.flowLayoutPanel1);
            this.materialPage.Controls.Add(this.forceVariationPanel);
            this.materialPage.Controls.Add(this.maxForceTestsPanel);
            this.materialPage.Controls.Add(this.averageForcePanel);
            this.materialPage.Controls.Add(this.reassignPanel);
            this.materialPage.Controls.Add(this.materialsOutputDataGridView);
            this.materialPage.Controls.Add(this.materialDeleteButton);
            this.materialPage.Controls.Add(this.materialsInputDataGridView);
            this.materialPage.Controls.Add(this.materialNotesTextBox);
            this.materialPage.Controls.Add(this.materialInsertButton);
            this.materialPage.Controls.Add(this.materialYoungModulusTextBox);
            this.materialPage.Controls.Add(this.materialDensityTextBox);
            this.materialPage.Controls.Add(this.materialTypeTextBox);
            this.materialPage.Controls.Add(this.materialNameTextBox);
            this.materialPage.Controls.Add(this.materialInsertLabel);
            this.materialPage.Location = new System.Drawing.Point(4, 25);
            this.materialPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.materialPage.Name = "materialPage";
            this.materialPage.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.materialPage.Size = new System.Drawing.Size(1108, 840);
            this.materialPage.TabIndex = 1;
            this.materialPage.Text = "Materiale";
            this.materialPage.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.maxForceTestsButton);
            this.flowLayoutPanel1.Controls.Add(this.testReassignButton);
            this.flowLayoutPanel1.Controls.Add(this.avgMaxForceButton);
            this.flowLayoutPanel1.Controls.Add(this.findForceVariationButton);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(11, 444);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(645, 50);
            this.flowLayoutPanel1.TabIndex = 27;
            // 
            // maxForceTestsButton
            // 
            this.maxForceTestsButton.Location = new System.Drawing.Point(3, 2);
            this.maxForceTestsButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.maxForceTestsButton.Name = "maxForceTestsButton";
            this.maxForceTestsButton.Size = new System.Drawing.Size(125, 46);
            this.maxForceTestsButton.TabIndex = 11;
            this.maxForceTestsButton.Text = "Afișare teste cu forță maximă";
            this.maxForceTestsButton.UseVisualStyleBackColor = true;
            this.maxForceTestsButton.Click += new System.EventHandler(this.maxForceTestsButton_Click);
            // 
            // testReassignButton
            // 
            this.testReassignButton.Location = new System.Drawing.Point(134, 2);
            this.testReassignButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.testReassignButton.Name = "testReassignButton";
            this.testReassignButton.Size = new System.Drawing.Size(125, 32);
            this.testReassignButton.TabIndex = 8;
            this.testReassignButton.Text = "Reatribuie teste";
            this.testReassignButton.UseVisualStyleBackColor = true;
            this.testReassignButton.Click += new System.EventHandler(this.testReassignButton_Click);
            // 
            // avgMaxForceButton
            // 
            this.avgMaxForceButton.Location = new System.Drawing.Point(265, 2);
            this.avgMaxForceButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.avgMaxForceButton.Name = "avgMaxForceButton";
            this.avgMaxForceButton.Size = new System.Drawing.Size(125, 46);
            this.avgMaxForceButton.TabIndex = 10;
            this.avgMaxForceButton.Text = "Calculează forța maximă medie";
            this.avgMaxForceButton.UseVisualStyleBackColor = true;
            this.avgMaxForceButton.Click += new System.EventHandler(this.avgMaxForceButton_Click);
            // 
            // findForceVariationButton
            // 
            this.findForceVariationButton.Location = new System.Drawing.Point(396, 2);
            this.findForceVariationButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.findForceVariationButton.Name = "findForceVariationButton";
            this.findForceVariationButton.Size = new System.Drawing.Size(215, 46);
            this.findForceVariationButton.TabIndex = 12;
            this.findForceVariationButton.Text = "Găsește materiale cu variație mare a forței maxime aplicate";
            this.findForceVariationButton.UseVisualStyleBackColor = true;
            this.findForceVariationButton.Click += new System.EventHandler(this.findForceVariationButton_Click);
            // 
            // forceVariationPanel
            // 
            this.forceVariationPanel.Controls.Add(this.showVariationResultButton);
            this.forceVariationPanel.Controls.Add(this.minTestNumTextBox);
            this.forceVariationPanel.Controls.Add(this.minForceVariationTextBox);
            this.forceVariationPanel.Controls.Add(this.label2);
            this.forceVariationPanel.Controls.Add(this.label1);
            this.forceVariationPanel.Controls.Add(this.forceVariationLabel);
            this.forceVariationPanel.Location = new System.Drawing.Point(824, 537);
            this.forceVariationPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.forceVariationPanel.Name = "forceVariationPanel";
            this.forceVariationPanel.Size = new System.Drawing.Size(255, 282);
            this.forceVariationPanel.TabIndex = 26;
            this.forceVariationPanel.Visible = false;
            // 
            // showVariationResultButton
            // 
            this.showVariationResultButton.Location = new System.Drawing.Point(11, 202);
            this.showVariationResultButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.showVariationResultButton.Name = "showVariationResultButton";
            this.showVariationResultButton.Size = new System.Drawing.Size(141, 36);
            this.showVariationResultButton.TabIndex = 25;
            this.showVariationResultButton.Text = "Afișează rezultate";
            this.showVariationResultButton.UseVisualStyleBackColor = true;
            this.showVariationResultButton.Click += new System.EventHandler(this.showVariationResultButton_Click);
            // 
            // minTestNumTextBox
            // 
            this.minTestNumTextBox.Location = new System.Drawing.Point(11, 146);
            this.minTestNumTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.minTestNumTextBox.Name = "minTestNumTextBox";
            this.minTestNumTextBox.Size = new System.Drawing.Size(95, 22);
            this.minTestNumTextBox.TabIndex = 23;
            // 
            // minForceVariationTextBox
            // 
            this.minForceVariationTextBox.Location = new System.Drawing.Point(11, 90);
            this.minForceVariationTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.minForceVariationTextBox.Name = "minForceVariationTextBox";
            this.minForceVariationTextBox.Size = new System.Drawing.Size(95, 22);
            this.minForceVariationTextBox.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "Număr minim de teste:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "Variație minimă a forței:";
            // 
            // forceVariationLabel
            // 
            this.forceVariationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forceVariationLabel.Location = new System.Drawing.Point(3, 14);
            this.forceVariationLabel.Name = "forceVariationLabel";
            this.forceVariationLabel.Size = new System.Drawing.Size(237, 36);
            this.forceVariationLabel.TabIndex = 19;
            this.forceVariationLabel.Text = "Găsire materiale cu variație mare a forței maxime aplicate";
            // 
            // maxForceTestsPanel
            // 
            this.maxForceTestsPanel.Controls.Add(this.label3);
            this.maxForceTestsPanel.Location = new System.Drawing.Point(824, 537);
            this.maxForceTestsPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.maxForceTestsPanel.Name = "maxForceTestsPanel";
            this.maxForceTestsPanel.Size = new System.Drawing.Size(255, 282);
            this.maxForceTestsPanel.TabIndex = 25;
            this.maxForceTestsPanel.Visible = false;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(237, 36);
            this.label3.TabIndex = 19;
            this.label3.Text = "Afișare teste cu forță maximă";
            // 
            // averageForcePanel
            // 
            this.averageForcePanel.Controls.Add(this.showResultButton);
            this.averageForcePanel.Controls.Add(this.minNumTestsTextBox);
            this.averageForcePanel.Controls.Add(this.minAvgForceTextBox);
            this.averageForcePanel.Controls.Add(this.testNumberLabel);
            this.averageForcePanel.Controls.Add(this.minimumAverageMaxForceLabel);
            this.averageForcePanel.Controls.Add(this.averageForceLabel);
            this.averageForcePanel.Location = new System.Drawing.Point(824, 537);
            this.averageForcePanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.averageForcePanel.Name = "averageForcePanel";
            this.averageForcePanel.Size = new System.Drawing.Size(255, 282);
            this.averageForcePanel.TabIndex = 21;
            this.averageForcePanel.Visible = false;
            // 
            // showResultButton
            // 
            this.showResultButton.Location = new System.Drawing.Point(5, 215);
            this.showResultButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.showResultButton.Name = "showResultButton";
            this.showResultButton.Size = new System.Drawing.Size(141, 36);
            this.showResultButton.TabIndex = 24;
            this.showResultButton.Text = "Afișează rezultate";
            this.showResultButton.UseVisualStyleBackColor = true;
            this.showResultButton.Click += new System.EventHandler(this.showResultButton_Click);
            // 
            // minNumTestsTextBox
            // 
            this.minNumTestsTextBox.Location = new System.Drawing.Point(5, 167);
            this.minNumTestsTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.minNumTestsTextBox.Name = "minNumTestsTextBox";
            this.minNumTestsTextBox.Size = new System.Drawing.Size(100, 22);
            this.minNumTestsTextBox.TabIndex = 23;
            // 
            // minAvgForceTextBox
            // 
            this.minAvgForceTextBox.Location = new System.Drawing.Point(5, 84);
            this.minAvgForceTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.minAvgForceTextBox.Name = "minAvgForceTextBox";
            this.minAvgForceTextBox.Size = new System.Drawing.Size(100, 22);
            this.minAvgForceTextBox.TabIndex = 22;
            // 
            // testNumberLabel
            // 
            this.testNumberLabel.AutoSize = true;
            this.testNumberLabel.Location = new System.Drawing.Point(3, 149);
            this.testNumberLabel.Name = "testNumberLabel";
            this.testNumberLabel.Size = new System.Drawing.Size(139, 16);
            this.testNumberLabel.TabIndex = 21;
            this.testNumberLabel.Text = "Număr minim de teste:";
            // 
            // minimumAverageMaxForceLabel
            // 
            this.minimumAverageMaxForceLabel.AutoSize = true;
            this.minimumAverageMaxForceLabel.Location = new System.Drawing.Point(3, 65);
            this.minimumAverageMaxForceLabel.Name = "minimumAverageMaxForceLabel";
            this.minimumAverageMaxForceLabel.Size = new System.Drawing.Size(178, 16);
            this.minimumAverageMaxForceLabel.TabIndex = 20;
            this.minimumAverageMaxForceLabel.Text = "Forță maximă medie minimă:";
            // 
            // averageForceLabel
            // 
            this.averageForceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.averageForceLabel.Location = new System.Drawing.Point(3, 14);
            this.averageForceLabel.Name = "averageForceLabel";
            this.averageForceLabel.Size = new System.Drawing.Size(237, 36);
            this.averageForceLabel.TabIndex = 19;
            this.averageForceLabel.Text = "Filtrare materiale după forța maximă medie";
            // 
            // reassignPanel
            // 
            this.reassignPanel.Controls.Add(this.reassignLabel);
            this.reassignPanel.Controls.Add(this.sourceMaterialNameLabel);
            this.reassignPanel.Controls.Add(this.targetMaterialNameLabel);
            this.reassignPanel.Controls.Add(this.targetMaterialComboBox);
            this.reassignPanel.Controls.Add(this.cancelReassignButton);
            this.reassignPanel.Controls.Add(this.confirmReassignButton);
            this.reassignPanel.Location = new System.Drawing.Point(824, 537);
            this.reassignPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reassignPanel.Name = "reassignPanel";
            this.reassignPanel.Size = new System.Drawing.Size(255, 282);
            this.reassignPanel.TabIndex = 20;
            this.reassignPanel.Visible = false;
            // 
            // reassignLabel
            // 
            this.reassignLabel.AutoSize = true;
            this.reassignLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reassignLabel.Location = new System.Drawing.Point(3, 14);
            this.reassignLabel.Name = "reassignLabel";
            this.reassignLabel.Size = new System.Drawing.Size(122, 16);
            this.reassignLabel.TabIndex = 19;
            this.reassignLabel.Text = "Reatribuire teste";
            // 
            // sourceMaterialNameLabel
            // 
            this.sourceMaterialNameLabel.AutoSize = true;
            this.sourceMaterialNameLabel.Location = new System.Drawing.Point(3, 65);
            this.sourceMaterialNameLabel.Name = "sourceMaterialNameLabel";
            this.sourceMaterialNameLabel.Size = new System.Drawing.Size(106, 16);
            this.sourceMaterialNameLabel.TabIndex = 14;
            this.sourceMaterialNameLabel.Text = "De la materialul: ";
            // 
            // targetMaterialNameLabel
            // 
            this.targetMaterialNameLabel.AutoSize = true;
            this.targetMaterialNameLabel.Location = new System.Drawing.Point(3, 124);
            this.targetMaterialNameLabel.Name = "targetMaterialNameLabel";
            this.targetMaterialNameLabel.Size = new System.Drawing.Size(86, 16);
            this.targetMaterialNameLabel.TabIndex = 18;
            this.targetMaterialNameLabel.Text = "La materialul:";
            // 
            // targetMaterialComboBox
            // 
            this.targetMaterialComboBox.FormattingEnabled = true;
            this.targetMaterialComboBox.Location = new System.Drawing.Point(5, 143);
            this.targetMaterialComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.targetMaterialComboBox.Name = "targetMaterialComboBox";
            this.targetMaterialComboBox.Size = new System.Drawing.Size(121, 24);
            this.targetMaterialComboBox.TabIndex = 15;
            // 
            // cancelReassignButton
            // 
            this.cancelReassignButton.Location = new System.Drawing.Point(177, 215);
            this.cancelReassignButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cancelReassignButton.Name = "cancelReassignButton";
            this.cancelReassignButton.Size = new System.Drawing.Size(75, 23);
            this.cancelReassignButton.TabIndex = 17;
            this.cancelReassignButton.Text = "Cancel";
            this.cancelReassignButton.UseVisualStyleBackColor = true;
            this.cancelReassignButton.Click += new System.EventHandler(this.cancelReassignButton_Click);
            // 
            // confirmReassignButton
            // 
            this.confirmReassignButton.Location = new System.Drawing.Point(3, 215);
            this.confirmReassignButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.confirmReassignButton.Name = "confirmReassignButton";
            this.confirmReassignButton.Size = new System.Drawing.Size(75, 23);
            this.confirmReassignButton.TabIndex = 16;
            this.confirmReassignButton.Text = "OK";
            this.confirmReassignButton.UseVisualStyleBackColor = true;
            this.confirmReassignButton.Click += new System.EventHandler(this.confirmReassignButton_Click);
            // 
            // materialsOutputDataGridView
            // 
            this.materialsOutputDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.materialsOutputDataGridView.Location = new System.Drawing.Point(11, 500);
            this.materialsOutputDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.materialsOutputDataGridView.Name = "materialsOutputDataGridView";
            this.materialsOutputDataGridView.RowHeadersWidth = 51;
            this.materialsOutputDataGridView.RowTemplate.Height = 24;
            this.materialsOutputDataGridView.Size = new System.Drawing.Size(803, 334);
            this.materialsOutputDataGridView.TabIndex = 13;
            // 
            // materialDeleteButton
            // 
            this.materialDeleteButton.Location = new System.Drawing.Point(913, 59);
            this.materialDeleteButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.materialDeleteButton.Name = "materialDeleteButton";
            this.materialDeleteButton.Size = new System.Drawing.Size(125, 32);
            this.materialDeleteButton.TabIndex = 9;
            this.materialDeleteButton.Text = "Șterge";
            this.materialDeleteButton.UseVisualStyleBackColor = true;
            this.materialDeleteButton.Click += new System.EventHandler(this.materialDeleteButton_Click);
            // 
            // materialsInputDataGridView
            // 
            this.materialsInputDataGridView.AutoGenerateColumns = false;
            this.materialsInputDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.materialsInputDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.materialsInputId,
            this.materialsInputName,
            this.materialsInputType,
            this.materialsInputDensity,
            this.materialsInputYoungModulus,
            this.materialsInputNotes});
            this.materialsInputDataGridView.DataSource = this.materialsBindingSource;
            this.materialsInputDataGridView.Location = new System.Drawing.Point(11, 142);
            this.materialsInputDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.materialsInputDataGridView.Name = "materialsInputDataGridView";
            this.materialsInputDataGridView.RowHeadersWidth = 51;
            this.materialsInputDataGridView.RowTemplate.Height = 24;
            this.materialsInputDataGridView.Size = new System.Drawing.Size(1068, 300);
            this.materialsInputDataGridView.TabIndex = 7;
            this.materialsInputDataGridView.SelectionChanged += new System.EventHandler(this.materialsInputDataGridView_SelectionChanged);
            // 
            // materialsInputId
            // 
            this.materialsInputId.DataPropertyName = "id";
            this.materialsInputId.HeaderText = "id";
            this.materialsInputId.MinimumWidth = 6;
            this.materialsInputId.Name = "materialsInputId";
            this.materialsInputId.Width = 125;
            // 
            // materialsInputName
            // 
            this.materialsInputName.DataPropertyName = "name";
            this.materialsInputName.HeaderText = "name";
            this.materialsInputName.MinimumWidth = 6;
            this.materialsInputName.Name = "materialsInputName";
            this.materialsInputName.Width = 125;
            // 
            // materialsInputType
            // 
            this.materialsInputType.DataPropertyName = "type";
            this.materialsInputType.HeaderText = "type";
            this.materialsInputType.MinimumWidth = 6;
            this.materialsInputType.Name = "materialsInputType";
            this.materialsInputType.Width = 125;
            // 
            // materialsInputDensity
            // 
            this.materialsInputDensity.DataPropertyName = "density_kg_m3";
            this.materialsInputDensity.HeaderText = "density_kg_m3";
            this.materialsInputDensity.MinimumWidth = 6;
            this.materialsInputDensity.Name = "materialsInputDensity";
            this.materialsInputDensity.Width = 125;
            // 
            // materialsInputYoungModulus
            // 
            this.materialsInputYoungModulus.DataPropertyName = "YoungModulus_GPa";
            this.materialsInputYoungModulus.HeaderText = "YoungModulus_GPa";
            this.materialsInputYoungModulus.MinimumWidth = 6;
            this.materialsInputYoungModulus.Name = "materialsInputYoungModulus";
            this.materialsInputYoungModulus.Width = 125;
            // 
            // materialsInputNotes
            // 
            this.materialsInputNotes.DataPropertyName = "notes";
            this.materialsInputNotes.HeaderText = "notes";
            this.materialsInputNotes.MinimumWidth = 6;
            this.materialsInputNotes.Name = "materialsInputNotes";
            this.materialsInputNotes.Width = 125;
            // 
            // materialNotesTextBox
            // 
            this.materialNotesTextBox.ForeColor = System.Drawing.Color.Gray;
            this.materialNotesTextBox.Location = new System.Drawing.Point(572, 64);
            this.materialNotesTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.materialNotesTextBox.Name = "materialNotesTextBox";
            this.materialNotesTextBox.Size = new System.Drawing.Size(101, 22);
            this.materialNotesTextBox.TabIndex = 6;
            this.materialNotesTextBox.Text = "Descriere (opt)";
            // 
            // materialInsertButton
            // 
            this.materialInsertButton.Location = new System.Drawing.Point(712, 59);
            this.materialInsertButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.materialInsertButton.Name = "materialInsertButton";
            this.materialInsertButton.Size = new System.Drawing.Size(116, 32);
            this.materialInsertButton.TabIndex = 5;
            this.materialInsertButton.Text = "Inserează";
            this.materialInsertButton.UseVisualStyleBackColor = true;
            this.materialInsertButton.Click += new System.EventHandler(this.materialInsertButton_Click);
            // 
            // materialYoungModulusTextBox
            // 
            this.materialYoungModulusTextBox.ForeColor = System.Drawing.Color.Gray;
            this.materialYoungModulusTextBox.Location = new System.Drawing.Point(437, 64);
            this.materialYoungModulusTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.materialYoungModulusTextBox.Name = "materialYoungModulusTextBox";
            this.materialYoungModulusTextBox.Size = new System.Drawing.Size(100, 22);
            this.materialYoungModulusTextBox.TabIndex = 4;
            this.materialYoungModulusTextBox.Text = "Modul Young";
            // 
            // materialDensityTextBox
            // 
            this.materialDensityTextBox.ForeColor = System.Drawing.Color.Gray;
            this.materialDensityTextBox.Location = new System.Drawing.Point(293, 64);
            this.materialDensityTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.materialDensityTextBox.Name = "materialDensityTextBox";
            this.materialDensityTextBox.Size = new System.Drawing.Size(115, 22);
            this.materialDensityTextBox.TabIndex = 3;
            this.materialDensityTextBox.Text = "Densitate";
            // 
            // materialTypeTextBox
            // 
            this.materialTypeTextBox.ForeColor = System.Drawing.Color.Gray;
            this.materialTypeTextBox.Location = new System.Drawing.Point(149, 64);
            this.materialTypeTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.materialTypeTextBox.Name = "materialTypeTextBox";
            this.materialTypeTextBox.Size = new System.Drawing.Size(100, 22);
            this.materialTypeTextBox.TabIndex = 2;
            this.materialTypeTextBox.Text = "Tip";
            // 
            // materialNameTextBox
            // 
            this.materialNameTextBox.ForeColor = System.Drawing.Color.Gray;
            this.materialNameTextBox.Location = new System.Drawing.Point(11, 64);
            this.materialNameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.testPage.Controls.Add(this.testStatisticsUpdateButton);
            this.testPage.Controls.Add(this.testsDataGridView);
            this.testPage.Controls.Add(this.testInsertButton);
            this.testPage.Controls.Add(this.testMaterialIdTextBox);
            this.testPage.Controls.Add(this.testNotesTextBox);
            this.testPage.Controls.Add(this.testTypeTextBox);
            this.testPage.Controls.Add(this.testInsertLabel);
            this.testPage.Location = new System.Drawing.Point(4, 25);
            this.testPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.testPage.Name = "testPage";
            this.testPage.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.testPage.Size = new System.Drawing.Size(1108, 840);
            this.testPage.TabIndex = 2;
            this.testPage.Text = "Teste";
            this.testPage.UseVisualStyleBackColor = true;
            // 
            // testStatisticsUpdateButton
            // 
            this.testStatisticsUpdateButton.Location = new System.Drawing.Point(11, 401);
            this.testStatisticsUpdateButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.testStatisticsUpdateButton.Name = "testStatisticsUpdateButton";
            this.testStatisticsUpdateButton.Size = new System.Drawing.Size(161, 44);
            this.testStatisticsUpdateButton.TabIndex = 13;
            this.testStatisticsUpdateButton.Text = "Computează maxime și modul Young";
            this.testStatisticsUpdateButton.UseVisualStyleBackColor = true;
            this.testStatisticsUpdateButton.Click += new System.EventHandler(this.testStatisticsUpdateButton_Click);
            // 
            // testsDataGridView
            // 
            this.testsDataGridView.AutoGenerateColumns = false;
            this.testsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.testsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14});
            this.testsDataGridView.DataSource = this.testsBindingSource;
            this.testsDataGridView.Location = new System.Drawing.Point(11, 142);
            this.testsDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.testsDataGridView.Name = "testsDataGridView";
            this.testsDataGridView.RowHeadersWidth = 51;
            this.testsDataGridView.RowTemplate.Height = 24;
            this.testsDataGridView.Size = new System.Drawing.Size(1040, 220);
            this.testsDataGridView.TabIndex = 12;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn7.HeaderText = "id";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "type";
            this.dataGridViewTextBoxColumn8.HeaderText = "type";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "date";
            this.dataGridViewTextBoxColumn9.HeaderText = "date";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 125;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "maxForce_N";
            this.dataGridViewTextBoxColumn10.HeaderText = "maxForce_N";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 125;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "maxStrain";
            this.dataGridViewTextBoxColumn11.HeaderText = "maxStrain";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Width = 125;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "YoungModulusEst_GPa";
            this.dataGridViewTextBoxColumn12.HeaderText = "YoungModulusEst_GPa";
            this.dataGridViewTextBoxColumn12.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.Width = 125;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "notes";
            this.dataGridViewTextBoxColumn13.HeaderText = "notes";
            this.dataGridViewTextBoxColumn13.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.Width = 125;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "materialId";
            this.dataGridViewTextBoxColumn14.HeaderText = "materialId";
            this.dataGridViewTextBoxColumn14.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.Width = 125;
            // 
            // testsBindingSource
            // 
            this.testsBindingSource.DataMember = "tests";
            this.testsBindingSource.DataSource = this.testDatabaseDataSet;
            // 
            // testInsertButton
            // 
            this.testInsertButton.Location = new System.Drawing.Point(477, 59);
            this.testInsertButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.testMaterialIdTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.testMaterialIdTextBox.Name = "testMaterialIdTextBox";
            this.testMaterialIdTextBox.Size = new System.Drawing.Size(123, 22);
            this.testMaterialIdTextBox.TabIndex = 10;
            this.testMaterialIdTextBox.Text = "Id material asociat";
            // 
            // testNotesTextBox
            // 
            this.testNotesTextBox.ForeColor = System.Drawing.Color.Gray;
            this.testNotesTextBox.Location = new System.Drawing.Point(149, 64);
            this.testNotesTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.testNotesTextBox.Name = "testNotesTextBox";
            this.testNotesTextBox.Size = new System.Drawing.Size(105, 22);
            this.testNotesTextBox.TabIndex = 9;
            this.testNotesTextBox.Text = "Comentarii (opț.)";
            // 
            // testTypeTextBox
            // 
            this.testTypeTextBox.ForeColor = System.Drawing.Color.Gray;
            this.testTypeTextBox.Location = new System.Drawing.Point(11, 64);
            this.testTypeTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            // testResultPage
            // 
            this.testResultPage.Controls.Add(this.hasNotesButton);
            this.testResultPage.Controls.Add(this.defaultNotesButton);
            this.testResultPage.Controls.Add(this.testResultsDataGridView);
            this.testResultPage.Controls.Add(this.testResultTestIdTextBox);
            this.testResultPage.Controls.Add(this.testResultInsertButton);
            this.testResultPage.Controls.Add(this.testResultNotesTextBox);
            this.testResultPage.Controls.Add(this.testResultStrainTextBox);
            this.testResultPage.Controls.Add(this.testResultForceTextBox);
            this.testResultPage.Controls.Add(this.testResultTimeTextBox);
            this.testResultPage.Controls.Add(this.testResultInsertLabel);
            this.testResultPage.Location = new System.Drawing.Point(4, 25);
            this.testResultPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.testResultPage.Name = "testResultPage";
            this.testResultPage.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.testResultPage.Size = new System.Drawing.Size(1108, 840);
            this.testResultPage.TabIndex = 3;
            this.testResultPage.Text = "Rezultate Teste ";
            this.testResultPage.UseVisualStyleBackColor = true;
            // 
            // hasNotesButton
            // 
            this.hasNotesButton.Location = new System.Drawing.Point(859, 225);
            this.hasNotesButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hasNotesButton.Name = "hasNotesButton";
            this.hasNotesButton.Size = new System.Drawing.Size(163, 33);
            this.hasNotesButton.TabIndex = 15;
            this.hasNotesButton.Text = "Rezultate cu notițe suplimentare";
            this.hasNotesButton.UseVisualStyleBackColor = true;
            this.hasNotesButton.Click += new System.EventHandler(this.hasNotesButton_Click);
            // 
            // defaultNotesButton
            // 
            this.defaultNotesButton.Location = new System.Drawing.Point(893, 160);
            this.defaultNotesButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.defaultNotesButton.Name = "defaultNotesButton";
            this.defaultNotesButton.Size = new System.Drawing.Size(81, 33);
            this.defaultNotesButton.TabIndex = 14;
            this.defaultNotesButton.Text = "Default";
            this.defaultNotesButton.UseVisualStyleBackColor = true;
            this.defaultNotesButton.Click += new System.EventHandler(this.defaultNotesButton_Click);
            // 
            // testResultsDataGridView
            // 
            this.testResultsDataGridView.AutoGenerateColumns = false;
            this.testResultsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.testResultsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.testResultsDataGridView.DataSource = this.testResultsBindingSource;
            this.testResultsDataGridView.Location = new System.Drawing.Point(11, 142);
            this.testResultsDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.testResultsDataGridView.Name = "testResultsDataGridView";
            this.testResultsDataGridView.RowHeadersWidth = 51;
            this.testResultsDataGridView.RowTemplate.Height = 24;
            this.testResultsDataGridView.Size = new System.Drawing.Size(800, 220);
            this.testResultsDataGridView.TabIndex = 13;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "time_s";
            this.dataGridViewTextBoxColumn2.HeaderText = "time_s";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "force_N";
            this.dataGridViewTextBoxColumn3.HeaderText = "force_N";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "strain";
            this.dataGridViewTextBoxColumn4.HeaderText = "strain";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "notes";
            this.dataGridViewTextBoxColumn5.HeaderText = "notes";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "testId";
            this.dataGridViewTextBoxColumn6.HeaderText = "testId";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // testResultsBindingSource
            // 
            this.testResultsBindingSource.DataMember = "testResults";
            this.testResultsBindingSource.DataSource = this.testDatabaseDataSet;
            // 
            // testResultTestIdTextBox
            // 
            this.testResultTestIdTextBox.ForeColor = System.Drawing.Color.Gray;
            this.testResultTestIdTextBox.Location = new System.Drawing.Point(571, 64);
            this.testResultTestIdTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.testResultTestIdTextBox.Name = "testResultTestIdTextBox";
            this.testResultTestIdTextBox.Size = new System.Drawing.Size(97, 22);
            this.testResultTestIdTextBox.TabIndex = 13;
            this.testResultTestIdTextBox.Text = "Id test asociat";
            // 
            // testResultInsertButton
            // 
            this.testResultInsertButton.Location = new System.Drawing.Point(755, 59);
            this.testResultInsertButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.testResultNotesTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.testResultNotesTextBox.Name = "testResultNotesTextBox";
            this.testResultNotesTextBox.Size = new System.Drawing.Size(108, 22);
            this.testResultNotesTextBox.TabIndex = 11;
            this.testResultNotesTextBox.Text = "Comentarii (opț.)";
            // 
            // testResultStrainTextBox
            // 
            this.testResultStrainTextBox.ForeColor = System.Drawing.Color.Gray;
            this.testResultStrainTextBox.Location = new System.Drawing.Point(293, 64);
            this.testResultStrainTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.testResultStrainTextBox.Name = "testResultStrainTextBox";
            this.testResultStrainTextBox.Size = new System.Drawing.Size(115, 22);
            this.testResultStrainTextBox.TabIndex = 10;
            this.testResultStrainTextBox.Text = "Alungire relativă";
            // 
            // testResultForceTextBox
            // 
            this.testResultForceTextBox.ForeColor = System.Drawing.Color.Gray;
            this.testResultForceTextBox.Location = new System.Drawing.Point(149, 64);
            this.testResultForceTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.testResultForceTextBox.Name = "testResultForceTextBox";
            this.testResultForceTextBox.Size = new System.Drawing.Size(100, 22);
            this.testResultForceTextBox.TabIndex = 9;
            this.testResultForceTextBox.Text = "Forță";
            // 
            // testResultTimeTextBox
            // 
            this.testResultTimeTextBox.ForeColor = System.Drawing.Color.Gray;
            this.testResultTimeTextBox.Location = new System.Drawing.Point(11, 64);
            this.testResultTimeTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            // graphPage
            // 
            this.graphPage.Controls.Add(this.executeGraphicButton);
            this.graphPage.Controls.Add(this.chooseGraphicComboBox);
            this.graphPage.Controls.Add(this.chooseTestDataGridView);
            this.graphPage.Controls.Add(this.graphicsChart);
            this.graphPage.Location = new System.Drawing.Point(4, 25);
            this.graphPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.graphPage.Name = "graphPage";
            this.graphPage.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.graphPage.Size = new System.Drawing.Size(1108, 840);
            this.graphPage.TabIndex = 4;
            this.graphPage.Text = "Grafice";
            this.graphPage.UseVisualStyleBackColor = true;
            // 
            // executeGraphicButton
            // 
            this.executeGraphicButton.Location = new System.Drawing.Point(941, 281);
            this.executeGraphicButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.executeGraphicButton.Name = "executeGraphicButton";
            this.executeGraphicButton.Size = new System.Drawing.Size(159, 50);
            this.executeGraphicButton.TabIndex = 3;
            this.executeGraphicButton.Text = "Execută grafic";
            this.executeGraphicButton.UseVisualStyleBackColor = true;
            this.executeGraphicButton.Click += new System.EventHandler(this.executeGraphicButton_Click);
            // 
            // chooseGraphicComboBox
            // 
            this.chooseGraphicComboBox.FormattingEnabled = true;
            this.chooseGraphicComboBox.Location = new System.Drawing.Point(865, 77);
            this.chooseGraphicComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chooseGraphicComboBox.Name = "chooseGraphicComboBox";
            this.chooseGraphicComboBox.Size = new System.Drawing.Size(235, 24);
            this.chooseGraphicComboBox.TabIndex = 2;
            // 
            // chooseTestDataGridView
            // 
            this.chooseTestDataGridView.AutoGenerateColumns = false;
            this.chooseTestDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.chooseTestDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.typeDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.maxForceNDataGridViewTextBoxColumn,
            this.maxStrainDataGridViewTextBoxColumn,
            this.youngModulusEstGPaDataGridViewTextBoxColumn,
            this.notesDataGridViewTextBoxColumn,
            this.materialIdDataGridViewTextBoxColumn});
            this.chooseTestDataGridView.DataSource = this.testsBindingSource;
            this.chooseTestDataGridView.Location = new System.Drawing.Point(8, 400);
            this.chooseTestDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chooseTestDataGridView.Name = "chooseTestDataGridView";
            this.chooseTestDataGridView.RowHeadersWidth = 51;
            this.chooseTestDataGridView.RowTemplate.Height = 24;
            this.chooseTestDataGridView.Size = new System.Drawing.Size(1051, 353);
            this.chooseTestDataGridView.TabIndex = 1;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.Width = 125;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "type";
            this.typeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "date";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.Width = 125;
            // 
            // maxForceNDataGridViewTextBoxColumn
            // 
            this.maxForceNDataGridViewTextBoxColumn.DataPropertyName = "maxForce_N";
            this.maxForceNDataGridViewTextBoxColumn.HeaderText = "maxForce_N";
            this.maxForceNDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maxForceNDataGridViewTextBoxColumn.Name = "maxForceNDataGridViewTextBoxColumn";
            this.maxForceNDataGridViewTextBoxColumn.Width = 125;
            // 
            // maxStrainDataGridViewTextBoxColumn
            // 
            this.maxStrainDataGridViewTextBoxColumn.DataPropertyName = "maxStrain";
            this.maxStrainDataGridViewTextBoxColumn.HeaderText = "maxStrain";
            this.maxStrainDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maxStrainDataGridViewTextBoxColumn.Name = "maxStrainDataGridViewTextBoxColumn";
            this.maxStrainDataGridViewTextBoxColumn.Width = 125;
            // 
            // youngModulusEstGPaDataGridViewTextBoxColumn
            // 
            this.youngModulusEstGPaDataGridViewTextBoxColumn.DataPropertyName = "YoungModulusEst_GPa";
            this.youngModulusEstGPaDataGridViewTextBoxColumn.HeaderText = "YoungModulusEst_GPa";
            this.youngModulusEstGPaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.youngModulusEstGPaDataGridViewTextBoxColumn.Name = "youngModulusEstGPaDataGridViewTextBoxColumn";
            this.youngModulusEstGPaDataGridViewTextBoxColumn.Width = 125;
            // 
            // notesDataGridViewTextBoxColumn
            // 
            this.notesDataGridViewTextBoxColumn.DataPropertyName = "notes";
            this.notesDataGridViewTextBoxColumn.HeaderText = "notes";
            this.notesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.notesDataGridViewTextBoxColumn.Name = "notesDataGridViewTextBoxColumn";
            this.notesDataGridViewTextBoxColumn.Width = 125;
            // 
            // materialIdDataGridViewTextBoxColumn
            // 
            this.materialIdDataGridViewTextBoxColumn.DataPropertyName = "materialId";
            this.materialIdDataGridViewTextBoxColumn.HeaderText = "materialId";
            this.materialIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.materialIdDataGridViewTextBoxColumn.Name = "materialIdDataGridViewTextBoxColumn";
            this.materialIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // graphicsChart
            // 
            chartArea3.Name = "ChartArea1";
            this.graphicsChart.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.graphicsChart.Legends.Add(legend3);
            this.graphicsChart.Location = new System.Drawing.Point(7, 7);
            this.graphicsChart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.graphicsChart.Name = "graphicsChart";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.graphicsChart.Series.Add(series3);
            this.graphicsChart.Size = new System.Drawing.Size(887, 386);
            this.graphicsChart.TabIndex = 0;
            this.graphicsChart.Text = "chart1";
            // 
            // exportPage
            // 
            this.exportPage.Controls.Add(this.exportWithoutIdCheckBox);
            this.exportPage.Controls.Add(this.tableExportComboBox);
            this.exportPage.Controls.Add(this.exportTableButton);
            this.exportPage.Location = new System.Drawing.Point(4, 25);
            this.exportPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.exportPage.Name = "exportPage";
            this.exportPage.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.exportPage.Size = new System.Drawing.Size(1108, 840);
            this.exportPage.TabIndex = 5;
            this.exportPage.Text = "Export";
            this.exportPage.UseVisualStyleBackColor = true;
            // 
            // exportWithoutIdCheckBox
            // 
            this.exportWithoutIdCheckBox.AutoSize = true;
            this.exportWithoutIdCheckBox.Location = new System.Drawing.Point(385, 42);
            this.exportWithoutIdCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.exportWithoutIdCheckBox.Name = "exportWithoutIdCheckBox";
            this.exportWithoutIdCheckBox.Size = new System.Drawing.Size(115, 20);
            this.exportWithoutIdCheckBox.TabIndex = 2;
            this.exportWithoutIdCheckBox.Text = "Exportă fără id";
            this.exportWithoutIdCheckBox.UseVisualStyleBackColor = true;
            // 
            // tableExportComboBox
            // 
            this.tableExportComboBox.FormattingEnabled = true;
            this.tableExportComboBox.Location = new System.Drawing.Point(8, 39);
            this.tableExportComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableExportComboBox.Name = "tableExportComboBox";
            this.tableExportComboBox.Size = new System.Drawing.Size(153, 24);
            this.tableExportComboBox.TabIndex = 1;
            // 
            // exportTableButton
            // 
            this.exportTableButton.Location = new System.Drawing.Point(261, 30);
            this.exportTableButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exportTableButton.Name = "exportTableButton";
            this.exportTableButton.Size = new System.Drawing.Size(117, 41);
            this.exportTableButton.TabIndex = 0;
            this.exportTableButton.Text = "Exportă";
            this.exportTableButton.UseVisualStyleBackColor = true;
            this.exportTableButton.Click += new System.EventHandler(this.exportTableButton_Click);
            // 
            // materialsForceFilteredBindingSource
            // 
            this.materialsForceFilteredBindingSource.DataMember = "materialsForceFiltered";
            this.materialsForceFilteredBindingSource.DataSource = this.testDatabaseDataSet;
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
            // materialsForceFilteredTableAdapter
            // 
            this.materialsForceFilteredTableAdapter.ClearBeforeFill = true;
            // 
            // materialsMaxForceTestsBindingSource
            // 
            this.materialsMaxForceTestsBindingSource.DataMember = "materialsMaxForceTests";
            this.materialsMaxForceTestsBindingSource.DataSource = this.testDatabaseDataSet;
            // 
            // materialsMaxForceTestsTableAdapter
            // 
            this.materialsMaxForceTestsTableAdapter.ClearBeforeFill = true;
            // 
            // materialsForceVariationBindingSource
            // 
            this.materialsForceVariationBindingSource.DataMember = "materialsForceVariation";
            this.materialsForceVariationBindingSource.DataSource = this.testDatabaseDataSet;
            // 
            // materialsForceVariationTableAdapter
            // 
            this.materialsForceVariationTableAdapter.ClearBeforeFill = true;
            // 
            // materialsDashboardBindingSource
            // 
            this.materialsDashboardBindingSource.DataMember = "materialsDashboard";
            this.materialsDashboardBindingSource.DataSource = this.testDatabaseDataSet;
            // 
            // materialsDashboardTableAdapter
            // 
            this.materialsDashboardTableAdapter.ClearBeforeFill = true;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 869);
            this.Controls.Add(this.tabControl);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "mainForm";
            this.Text = "Evidență Materiale și Proprietăți Mecanice";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.tabControl.ResumeLayout(false);
            this.dashboardPage.ResumeLayout(false);
            this.dashboardPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lastTestDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDatabaseDataSet)).EndInit();
            this.materialPage.ResumeLayout(false);
            this.materialPage.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.forceVariationPanel.ResumeLayout(false);
            this.forceVariationPanel.PerformLayout();
            this.maxForceTestsPanel.ResumeLayout(false);
            this.averageForcePanel.ResumeLayout(false);
            this.averageForcePanel.PerformLayout();
            this.reassignPanel.ResumeLayout(false);
            this.reassignPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.materialsOutputDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialsInputDataGridView)).EndInit();
            this.testPage.ResumeLayout(false);
            this.testPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.testsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testsBindingSource)).EndInit();
            this.testResultPage.ResumeLayout(false);
            this.testResultPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.testResultsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testResultsBindingSource)).EndInit();
            this.graphPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chooseTestDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graphicsChart)).EndInit();
            this.exportPage.ResumeLayout(false);
            this.exportPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.materialsForceFilteredBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialsMaxForceTestsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialsForceVariationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialsDashboardBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage dashboardPage;
        private System.Windows.Forms.TabPage materialPage;
        private System.Windows.Forms.TabPage testPage;
        private System.Windows.Forms.TabPage testResultPage;
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
        private System.Windows.Forms.DataGridView materialsInputDataGridView;
        private System.Windows.Forms.Button testReassignButton;
        private System.Windows.Forms.Button materialDeleteButton;
        private System.Windows.Forms.DataGridView testsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.Button testStatisticsUpdateButton;
        private System.Windows.Forms.DataGridView lastTestDataGridView;
        private System.Windows.Forms.Label lastTestLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn testDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn testMaxForce;
        private System.Windows.Forms.DataGridViewTextBoxColumn testMaxStrain;
        private System.Windows.Forms.Button avgMaxForceButton;
        private System.Windows.Forms.Button maxForceTestsButton;
        private System.Windows.Forms.Button findForceVariationButton;
        private System.Windows.Forms.DataGridView materialsOutputDataGridView;
        private System.Windows.Forms.Label targetMaterialNameLabel;
        private System.Windows.Forms.Button cancelReassignButton;
        private System.Windows.Forms.Button confirmReassignButton;
        private System.Windows.Forms.ComboBox targetMaterialComboBox;
        private System.Windows.Forms.Label sourceMaterialNameLabel;
        private System.Windows.Forms.Label reassignLabel;
        private System.Windows.Forms.Panel reassignPanel;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialsInputId;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialsInputName;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialsInputType;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialsInputDensity;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialsInputYoungModulus;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialsInputNotes;
        private System.Windows.Forms.Panel averageForcePanel;
        private System.Windows.Forms.Label averageForceLabel;
        private System.Windows.Forms.TextBox minNumTestsTextBox;
        private System.Windows.Forms.TextBox minAvgForceTextBox;
        private System.Windows.Forms.Label testNumberLabel;
        private System.Windows.Forms.Label minimumAverageMaxForceLabel;
        private System.Windows.Forms.Button showResultButton;
        private System.Windows.Forms.BindingSource materialsForceFilteredBindingSource;
        private TestDatabaseDataSetTableAdapters.materialsForceFilteredTableAdapter materialsForceFilteredTableAdapter;
        private System.Windows.Forms.Panel maxForceTestsPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource materialsMaxForceTestsBindingSource;
        private TestDatabaseDataSetTableAdapters.materialsMaxForceTestsTableAdapter materialsMaxForceTestsTableAdapter;
        private System.Windows.Forms.Panel forceVariationPanel;
        private System.Windows.Forms.Label forceVariationLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox minTestNumTextBox;
        private System.Windows.Forms.TextBox minForceVariationTextBox;
        private System.Windows.Forms.Button showVariationResultButton;
        private System.Windows.Forms.BindingSource materialsForceVariationBindingSource;
        private TestDatabaseDataSetTableAdapters.materialsForceVariationTableAdapter materialsForceVariationTableAdapter;
        private System.Windows.Forms.DataGridView testResultsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Button hasNotesButton;
        private System.Windows.Forms.Button defaultNotesButton;
        private System.Windows.Forms.ComboBox fileImportComboBox;
        private System.Windows.Forms.Label fileImportLabel;
        private System.Windows.Forms.Button fileImportButton;
        private System.Windows.Forms.Button fileModelDownload;
        private System.Windows.Forms.ComboBox tableExportComboBox;
        private System.Windows.Forms.Button exportTableButton;
        private System.Windows.Forms.DataGridView chooseTestDataGridView;
        private System.Windows.Forms.DataVisualization.Charting.Chart graphicsChart;
        private System.Windows.Forms.ComboBox chooseGraphicComboBox;
        private System.Windows.Forms.Button executeGraphicButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxForceNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxStrainDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn youngModulusEstGPaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label testNumLabel;
        private System.Windows.Forms.Label materialNumLabel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.BindingSource materialsDashboardBindingSource;
        private TestDatabaseDataSetTableAdapters.materialsDashboardTableAdapter materialsDashboardTableAdapter;
        private System.Windows.Forms.CheckBox exportWithoutIdCheckBox;
    }
}

