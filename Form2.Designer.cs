namespace ProiectAtestat
{
    partial class ReassignTestsForm
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
            this.sourceMaterialNameLabel = new System.Windows.Forms.Label();
            this.targetMaterialComboBox = new System.Windows.Forms.ComboBox();
            this.materialsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.testDatabaseDataSet = new ProiectAtestat.TestDatabaseDataSet();
            this.materialsTableAdapter = new ProiectAtestat.TestDatabaseDataSetTableAdapters.materialsTableAdapter();
            this.confirmButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.targetMaterialLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.materialsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDatabaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // sourceMaterialNameLabel
            // 
            this.sourceMaterialNameLabel.AutoSize = true;
            this.sourceMaterialNameLabel.Location = new System.Drawing.Point(12, 9);
            this.sourceMaterialNameLabel.Name = "sourceMaterialNameLabel";
            this.sourceMaterialNameLabel.Size = new System.Drawing.Size(106, 16);
            this.sourceMaterialNameLabel.TabIndex = 0;
            this.sourceMaterialNameLabel.Text = "De la materialul: ";
            // 
            // targetMaterialComboBox
            // 
            this.targetMaterialComboBox.DataSource = this.materialsBindingSource;
            this.targetMaterialComboBox.DisplayMember = "name";
            this.targetMaterialComboBox.FormattingEnabled = true;
            this.targetMaterialComboBox.Location = new System.Drawing.Point(15, 87);
            this.targetMaterialComboBox.Name = "targetMaterialComboBox";
            this.targetMaterialComboBox.Size = new System.Drawing.Size(121, 24);
            this.targetMaterialComboBox.TabIndex = 1;
            this.targetMaterialComboBox.ValueMember = "id";
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
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(12, 180);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(75, 23);
            this.confirmButton.TabIndex = 2;
            this.confirmButton.Text = "OK";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(256, 180);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // targetMaterialLabel
            // 
            this.targetMaterialLabel.AutoSize = true;
            this.targetMaterialLabel.Location = new System.Drawing.Point(12, 68);
            this.targetMaterialLabel.Name = "targetMaterialLabel";
            this.targetMaterialLabel.Size = new System.Drawing.Size(86, 16);
            this.targetMaterialLabel.TabIndex = 4;
            this.targetMaterialLabel.Text = "La materialul:";
            // 
            // ReassignTestsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 227);
            this.Controls.Add(this.targetMaterialLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.targetMaterialComboBox);
            this.Controls.Add(this.sourceMaterialNameLabel);
            this.Name = "ReassignTestsForm";
            this.Text = "Reatribuie teste";
            this.Load += new System.EventHandler(this.ReassignTestsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.materialsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDatabaseDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label sourceMaterialNameLabel;
        private System.Windows.Forms.ComboBox targetMaterialComboBox;
        private TestDatabaseDataSet testDatabaseDataSet;
        private System.Windows.Forms.BindingSource materialsBindingSource;
        private TestDatabaseDataSetTableAdapters.materialsTableAdapter materialsTableAdapter;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label targetMaterialLabel;
    }
}