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
            this.lastTestLabel = new System.Windows.Forms.Label();
            this.lastTestDataGridView = new System.Windows.Forms.DataGridView();
            this.testDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.testMaxForce = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.testMaxStrain = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialPage = new System.Windows.Forms.TabPage();
            this.materialDeleteButton = new System.Windows.Forms.Button();
            this.testReassignButton = new System.Windows.Forms.Button();
            this.materialsDataGridView = new System.Windows.Forms.DataGridView();
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
            this.testInsertButton = new System.Windows.Forms.Button();
            this.testMaterialIdTextBox = new System.Windows.Forms.TextBox();
            this.testNotesTextBox = new System.Windows.Forms.TextBox();
            this.testTypeTextBox = new System.Windows.Forms.TextBox();
            this.testInsertLabel = new System.Windows.Forms.Label();
            this.testResultPage = new System.Windows.Forms.TabPage();
            this.testResultTestIdTextBox = new System.Windows.Forms.TextBox();
            this.testResultInsertButton = new System.Windows.Forms.Button();
            this.testResultNotesTextBox = new System.Windows.Forms.TextBox();
            this.testResultStrainTextBox = new System.Windows.Forms.TextBox();
            this.testResultForceTextBox = new System.Windows.Forms.TextBox();
            this.testResultTimeTextBox = new System.Windows.Forms.TextBox();
            this.testResultInsertLabel = new System.Windows.Forms.Label();
            this.graphPage = new System.Windows.Forms.TabPage();
            this.exportPage = new System.Windows.Forms.TabPage();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.testDatabaseDataSet = new ProiectAtestat.TestDatabaseDataSet();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.testsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.materialsTableAdapter = new ProiectAtestat.TestDatabaseDataSetTableAdapters.materialsTableAdapter();
            this.tableAdapterManager = new ProiectAtestat.TestDatabaseDataSetTableAdapters.TableAdapterManager();
            this.testResultsTableAdapter = new ProiectAtestat.TestDatabaseDataSetTableAdapters.testResultsTableAdapter();
            this.testsTableAdapter = new ProiectAtestat.TestDatabaseDataSetTableAdapters.testsTableAdapter();
            this.testResultsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.avgMaxForceButton = new System.Windows.Forms.Button();
            this.maxForceTestsButton = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.dashboardPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lastTestDataGridView)).BeginInit();
            this.materialPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.materialsDataGridView)).BeginInit();
            this.testPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.testsDataGridView)).BeginInit();
            this.testResultPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.materialsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testResultsBindingSource)).BeginInit();
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
            this.tabControl.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1067, 554);
            this.tabControl.TabIndex = 0;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // dashboardPage
            // 
            this.dashboardPage.AutoScroll = true;
            this.dashboardPage.Controls.Add(this.lastTestLabel);
            this.dashboardPage.Controls.Add(this.lastTestDataGridView);
            this.dashboardPage.Location = new System.Drawing.Point(4, 25);
            this.dashboardPage.Margin = new System.Windows.Forms.Padding(4);
            this.dashboardPage.Name = "dashboardPage";
            this.dashboardPage.Padding = new System.Windows.Forms.Padding(4);
            this.dashboardPage.Size = new System.Drawing.Size(1059, 525);
            this.dashboardPage.TabIndex = 0;
            this.dashboardPage.Text = "Dashboard";
            this.dashboardPage.UseVisualStyleBackColor = true;
            // 
            // lastTestLabel
            // 
            this.lastTestLabel.AutoSize = true;
            this.lastTestLabel.Location = new System.Drawing.Point(8, 141);
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
            this.lastTestDataGridView.Location = new System.Drawing.Point(11, 179);
            this.lastTestDataGridView.Name = "lastTestDataGridView";
            this.lastTestDataGridView.RowHeadersWidth = 51;
            this.lastTestDataGridView.RowTemplate.Height = 24;
            this.lastTestDataGridView.Size = new System.Drawing.Size(552, 142);
            this.lastTestDataGridView.TabIndex = 0;
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
            // materialPage
            // 
            this.materialPage.Controls.Add(this.maxForceTestsButton);
            this.materialPage.Controls.Add(this.avgMaxForceButton);
            this.materialPage.Controls.Add(this.materialDeleteButton);
            this.materialPage.Controls.Add(this.testReassignButton);
            this.materialPage.Controls.Add(this.materialsDataGridView);
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
            // materialDeleteButton
            // 
            this.materialDeleteButton.Location = new System.Drawing.Point(872, 138);
            this.materialDeleteButton.Name = "materialDeleteButton";
            this.materialDeleteButton.Size = new System.Drawing.Size(126, 32);
            this.materialDeleteButton.TabIndex = 9;
            this.materialDeleteButton.Text = "Șterge";
            this.materialDeleteButton.UseVisualStyleBackColor = true;
            this.materialDeleteButton.Click += new System.EventHandler(this.materialDeleteButton_Click);
            // 
            // testReassignButton
            // 
            this.testReassignButton.Location = new System.Drawing.Point(872, 211);
            this.testReassignButton.Name = "testReassignButton";
            this.testReassignButton.Size = new System.Drawing.Size(126, 32);
            this.testReassignButton.TabIndex = 8;
            this.testReassignButton.Text = "Reatribuie teste";
            this.testReassignButton.UseVisualStyleBackColor = true;
            this.testReassignButton.Click += new System.EventHandler(this.testReassignButton_Click);
            // 
            // materialsDataGridView
            // 
            this.materialsDataGridView.AutoGenerateColumns = false;
            this.materialsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.materialsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.materialsDataGridView.DataSource = this.materialsBindingSource;
            this.materialsDataGridView.Location = new System.Drawing.Point(11, 138);
            this.materialsDataGridView.Name = "materialsDataGridView";
            this.materialsDataGridView.RowHeadersWidth = 51;
            this.materialsDataGridView.RowTemplate.Height = 24;
            this.materialsDataGridView.Size = new System.Drawing.Size(802, 333);
            this.materialsDataGridView.TabIndex = 7;
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
            // materialYoungModulusTextBox
            // 
            this.materialYoungModulusTextBox.ForeColor = System.Drawing.Color.Gray;
            this.materialYoungModulusTextBox.Location = new System.Drawing.Point(437, 64);
            this.materialYoungModulusTextBox.Name = "materialYoungModulusTextBox";
            this.materialYoungModulusTextBox.Size = new System.Drawing.Size(100, 22);
            this.materialYoungModulusTextBox.TabIndex = 4;
            this.materialYoungModulusTextBox.Text = "Modul Young";
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
            // materialTypeTextBox
            // 
            this.materialTypeTextBox.ForeColor = System.Drawing.Color.Gray;
            this.materialTypeTextBox.Location = new System.Drawing.Point(149, 64);
            this.materialTypeTextBox.Name = "materialTypeTextBox";
            this.materialTypeTextBox.Size = new System.Drawing.Size(100, 22);
            this.materialTypeTextBox.TabIndex = 2;
            this.materialTypeTextBox.Text = "Tip";
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
            this.testPage.Controls.Add(this.testStatisticsUpdateButton);
            this.testPage.Controls.Add(this.testsDataGridView);
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
            // testStatisticsUpdateButton
            // 
            this.testStatisticsUpdateButton.Location = new System.Drawing.Point(11, 401);
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
            this.testsDataGridView.Location = new System.Drawing.Point(11, 141);
            this.testsDataGridView.Name = "testsDataGridView";
            this.testsDataGridView.RowHeadersWidth = 51;
            this.testsDataGridView.RowTemplate.Height = 24;
            this.testsDataGridView.Size = new System.Drawing.Size(1040, 220);
            this.testsDataGridView.TabIndex = 12;
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
            // testResultPage
            // 
            this.testResultPage.Controls.Add(this.testResultTestIdTextBox);
            this.testResultPage.Controls.Add(this.testResultInsertButton);
            this.testResultPage.Controls.Add(this.testResultNotesTextBox);
            this.testResultPage.Controls.Add(this.testResultStrainTextBox);
            this.testResultPage.Controls.Add(this.testResultForceTextBox);
            this.testResultPage.Controls.Add(this.testResultTimeTextBox);
            this.testResultPage.Controls.Add(this.testResultInsertLabel);
            this.testResultPage.Location = new System.Drawing.Point(4, 25);
            this.testResultPage.Margin = new System.Windows.Forms.Padding(4);
            this.testResultPage.Name = "testResultPage";
            this.testResultPage.Padding = new System.Windows.Forms.Padding(4);
            this.testResultPage.Size = new System.Drawing.Size(1059, 525);
            this.testResultPage.TabIndex = 3;
            this.testResultPage.Text = "Rezultate Teste ";
            this.testResultPage.UseVisualStyleBackColor = true;
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
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 125;
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
            this.dataGridViewTextBoxColumn2.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn2.HeaderText = "name";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "type";
            this.dataGridViewTextBoxColumn3.HeaderText = "type";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "density_kg_m3";
            this.dataGridViewTextBoxColumn4.HeaderText = "density_kg_m3";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "YoungModulus_GPa";
            this.dataGridViewTextBoxColumn5.HeaderText = "YoungModulus_GPa";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "notes";
            this.dataGridViewTextBoxColumn6.HeaderText = "notes";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
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
            // avgMaxForceButton
            // 
            this.avgMaxForceButton.Location = new System.Drawing.Point(872, 328);
            this.avgMaxForceButton.Name = "avgMaxForceButton";
            this.avgMaxForceButton.Size = new System.Drawing.Size(126, 45);
            this.avgMaxForceButton.TabIndex = 10;
            this.avgMaxForceButton.Text = "Calculează forța maximă medie";
            this.avgMaxForceButton.UseVisualStyleBackColor = true;
            this.avgMaxForceButton.Click += new System.EventHandler(this.avgMaxForceButton_Click);
            // 
            // maxForceTestsButton
            // 
            this.maxForceTestsButton.Location = new System.Drawing.Point(872, 403);
            this.maxForceTestsButton.Name = "maxForceTestsButton";
            this.maxForceTestsButton.Size = new System.Drawing.Size(126, 45);
            this.maxForceTestsButton.TabIndex = 11;
            this.maxForceTestsButton.Text = "Afișare teste cu forță maximă";
            this.maxForceTestsButton.UseVisualStyleBackColor = true;
            this.maxForceTestsButton.Click += new System.EventHandler(this.maxForceTestsButton_Click);
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
            this.dashboardPage.ResumeLayout(false);
            this.dashboardPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lastTestDataGridView)).EndInit();
            this.materialPage.ResumeLayout(false);
            this.materialPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.materialsDataGridView)).EndInit();
            this.testPage.ResumeLayout(false);
            this.testPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.testsDataGridView)).EndInit();
            this.testResultPage.ResumeLayout(false);
            this.testResultPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.materialsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testResultsBindingSource)).EndInit();
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
        private System.Windows.Forms.DataGridView materialsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
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
    }
}

