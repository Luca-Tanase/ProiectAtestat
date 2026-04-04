namespace ProiectAtestat
{
    partial class MaxForceTestsForm
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
            this.maxForceTestsDataGridView = new System.Windows.Forms.DataGridView();
            this.materialsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.testDatabaseDataSet = new ProiectAtestat.TestDatabaseDataSet();
            this.materialsTableAdapter = new ProiectAtestat.TestDatabaseDataSetTableAdapters.materialsTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxForce = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.maxForceTestsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDatabaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // maxForceTestsDataGridView
            // 
            this.maxForceTestsDataGridView.AutoGenerateColumns = false;
            this.maxForceTestsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.maxForceTestsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.type,
            this.date,
            this.maxForce});
            this.maxForceTestsDataGridView.DataSource = this.materialsBindingSource;
            this.maxForceTestsDataGridView.Location = new System.Drawing.Point(12, 12);
            this.maxForceTestsDataGridView.Name = "maxForceTestsDataGridView";
            this.maxForceTestsDataGridView.RowHeadersWidth = 51;
            this.maxForceTestsDataGridView.RowTemplate.Height = 24;
            this.maxForceTestsDataGridView.Size = new System.Drawing.Size(776, 426);
            this.maxForceTestsDataGridView.TabIndex = 0;
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
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // type
            // 
            this.type.DataPropertyName = "type";
            this.type.HeaderText = "type";
            this.type.MinimumWidth = 6;
            this.type.Name = "type";
            this.type.Width = 125;
            // 
            // date
            // 
            this.date.DataPropertyName = "date";
            this.date.HeaderText = "date";
            this.date.MinimumWidth = 6;
            this.date.Name = "date";
            this.date.Width = 125;
            // 
            // maxForce
            // 
            this.maxForce.DataPropertyName = "maxForce_N";
            this.maxForce.HeaderText = "maxForce";
            this.maxForce.MinimumWidth = 6;
            this.maxForce.Name = "maxForce";
            this.maxForce.Width = 125;
            // 
            // MaxForceTestsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.maxForceTestsDataGridView);
            this.Name = "MaxForceTestsForm";
            this.Text = "Teste de forță maximă";
            this.Load += new System.EventHandler(this.MaxForceTestsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.maxForceTestsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDatabaseDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView maxForceTestsDataGridView;
        private TestDatabaseDataSet testDatabaseDataSet;
        private System.Windows.Forms.BindingSource materialsBindingSource;
        private TestDatabaseDataSetTableAdapters.materialsTableAdapter materialsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxForce;
    }
}