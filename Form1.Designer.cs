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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.dashboardPage = new System.Windows.Forms.TabPage();
            this.materialPage = new System.Windows.Forms.TabPage();
            this.testPage = new System.Windows.Forms.TabPage();
            this.resultPage = new System.Windows.Forms.TabPage();
            this.graphPage = new System.Windows.Forms.TabPage();
            this.exportPage = new System.Windows.Forms.TabPage();
            this.tabControl.SuspendLayout();
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
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(800, 450);
            this.tabControl.TabIndex = 0;
            // 
            // dashboardPage
            // 
            this.dashboardPage.Location = new System.Drawing.Point(4, 22);
            this.dashboardPage.Name = "dashboardPage";
            this.dashboardPage.Padding = new System.Windows.Forms.Padding(3);
            this.dashboardPage.Size = new System.Drawing.Size(792, 424);
            this.dashboardPage.TabIndex = 0;
            this.dashboardPage.Text = "Dashboard";
            this.dashboardPage.UseVisualStyleBackColor = true;
            // 
            // materialPage
            // 
            this.materialPage.Location = new System.Drawing.Point(4, 22);
            this.materialPage.Name = "materialPage";
            this.materialPage.Padding = new System.Windows.Forms.Padding(3);
            this.materialPage.Size = new System.Drawing.Size(792, 424);
            this.materialPage.TabIndex = 1;
            this.materialPage.Text = "Materiale";
            this.materialPage.UseVisualStyleBackColor = true;
            // 
            // testPage
            // 
            this.testPage.Location = new System.Drawing.Point(4, 22);
            this.testPage.Name = "testPage";
            this.testPage.Padding = new System.Windows.Forms.Padding(3);
            this.testPage.Size = new System.Drawing.Size(792, 424);
            this.testPage.TabIndex = 2;
            this.testPage.Text = "Teste";
            this.testPage.UseVisualStyleBackColor = true;
            // 
            // resultPage
            // 
            this.resultPage.Location = new System.Drawing.Point(4, 22);
            this.resultPage.Name = "resultPage";
            this.resultPage.Padding = new System.Windows.Forms.Padding(3);
            this.resultPage.Size = new System.Drawing.Size(792, 424);
            this.resultPage.TabIndex = 3;
            this.resultPage.Text = "Rezultate Teste ";
            this.resultPage.UseVisualStyleBackColor = true;
            // 
            // graphPage
            // 
            this.graphPage.Location = new System.Drawing.Point(4, 22);
            this.graphPage.Name = "graphPage";
            this.graphPage.Padding = new System.Windows.Forms.Padding(3);
            this.graphPage.Size = new System.Drawing.Size(792, 424);
            this.graphPage.TabIndex = 4;
            this.graphPage.Text = "Grafuri";
            this.graphPage.UseVisualStyleBackColor = true;
            // 
            // exportPage
            // 
            this.exportPage.Location = new System.Drawing.Point(4, 22);
            this.exportPage.Name = "exportPage";
            this.exportPage.Padding = new System.Windows.Forms.Padding(3);
            this.exportPage.Size = new System.Drawing.Size(792, 424);
            this.exportPage.TabIndex = 5;
            this.exportPage.Text = "Export";
            this.exportPage.UseVisualStyleBackColor = true;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl);
            this.Name = "mainForm";
            this.Text = "Evidență Materiale și Proprietăți mecanice";
            this.tabControl.ResumeLayout(false);
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
    }
}

