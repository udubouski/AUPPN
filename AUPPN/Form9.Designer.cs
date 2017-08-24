namespace AUPPN
{
    partial class Form9
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form9));
            this.saleeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bddiplomDataSet = new AUPPN.bddiplomDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.saleeTableAdapter = new AUPPN.bddiplomDataSetTableAdapters.saleeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.saleeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bddiplomDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // saleeBindingSource
            // 
            this.saleeBindingSource.DataMember = "salee";
            this.saleeBindingSource.DataSource = this.bddiplomDataSet;
            // 
            // bddiplomDataSet
            // 
            this.bddiplomDataSet.DataSetName = "bddiplomDataSet";
            this.bddiplomDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.saleeBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "AUPPN.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(632, 327);
            this.reportViewer1.TabIndex = 0;
            // 
            // saleeTableAdapter
            // 
            this.saleeTableAdapter.ClearBeforeFill = true;
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 327);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form9";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Заявка";
            this.Load += new System.EventHandler(this.Form9_Load);
            ((System.ComponentModel.ISupportInitialize)(this.saleeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bddiplomDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource saleeBindingSource;
        private bddiplomDataSet bddiplomDataSet;
        private bddiplomDataSetTableAdapters.saleeTableAdapter saleeTableAdapter;
    }
}