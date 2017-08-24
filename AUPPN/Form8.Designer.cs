namespace AUPPN
{
    partial class Form8
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form8));
            this.pricelistBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bddiplomDataSetpricelist = new AUPPN.bddiplomDataSetpricelist();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.pricelistTableAdapter = new AUPPN.bddiplomDataSetpricelistTableAdapters.pricelistTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pricelistBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bddiplomDataSetpricelist)).BeginInit();
            this.SuspendLayout();
            // 
            // pricelistBindingSource
            // 
            this.pricelistBindingSource.DataMember = "pricelist";
            this.pricelistBindingSource.DataSource = this.bddiplomDataSetpricelist;
            // 
            // bddiplomDataSetpricelist
            // 
            this.bddiplomDataSetpricelist.DataSetName = "bddiplomDataSetpricelist";
            this.bddiplomDataSetpricelist.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.DocumentMapWidth = 1;
            reportDataSource1.Name = "pricelist";
            reportDataSource1.Value = this.pricelistBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "AUPPN.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(676, 419);
            this.reportViewer1.TabIndex = 0;
            // 
            // pricelistTableAdapter
            // 
            this.pricelistTableAdapter.ClearBeforeFill = true;
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 419);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form8";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Прайс-лист";
            this.Load += new System.EventHandler(this.Form8_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pricelistBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bddiplomDataSetpricelist)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource pricelistBindingSource;
        private bddiplomDataSetpricelist bddiplomDataSetpricelist;
        private bddiplomDataSetpricelistTableAdapters.pricelistTableAdapter pricelistTableAdapter;



    }
}