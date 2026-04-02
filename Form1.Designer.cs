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
            this.testPage = new System.Windows.Forms.TabPage();
            this.resultPage = new System.Windows.Forms.TabPage();
            this.graphPage = new System.Windows.Forms.TabPage();
            this.exportPage = new System.Windows.Forms.TabPage();
            this.testDatabaseDataSet = new ProiectAtestat.TestDatabaseDataSet();
            this.materialsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.materialsTableAdapter = new ProiectAtestat.TestDatabaseDataSetTableAdapters.materialsTableAdapter();
            this.tableAdapterManager = new ProiectAtestat.TestDatabaseDataSetTableAdapters.TableAdapterManager();
            this.testResultsTableAdapter = new ProiectAtestat.TestDatabaseDataSetTableAdapters.testResultsTableAdapter();
            this.testsTableAdapter = new ProiectAtestat.TestDatabaseDataSetTableAdapters.testsTableAdapter();
            this.testResultsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.testsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl.SuspendLayout();
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
            this.materialPage.Location = new System.Drawing.Point(4, 25);
            this.materialPage.Margin = new System.Windows.Forms.Padding(4);
            this.materialPage.Name = "materialPage";
            this.materialPage.Padding = new System.Windows.Forms.Padding(4);
            this.materialPage.Size = new System.Drawing.Size(1059, 525);
            this.materialPage.TabIndex = 1;
            this.materialPage.Text = "Materiale";
            this.materialPage.UseVisualStyleBackColor = true;
            // 
            // testPage
            // 
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
    }
}

