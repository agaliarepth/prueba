namespace gasolinera.Reportes
{
    partial class DistribuidoresReportForm
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.gasolineraDBDataSet = new gasolinera.gasolineraDBDataSet();
            this.distribuidoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.distribuidoresTableAdapter = new gasolinera.gasolineraDBDataSetTableAdapters.distribuidoresTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gasolineraDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.distribuidoresBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.distribuidoresBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "gasolinera.Reportes.DistribuidoresReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(752, 721);
            this.reportViewer1.TabIndex = 0;
            // 
            // gasolineraDBDataSet
            // 
            this.gasolineraDBDataSet.DataSetName = "gasolineraDBDataSet";
            this.gasolineraDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // distribuidoresBindingSource
            // 
            this.distribuidoresBindingSource.DataMember = "distribuidores";
            this.distribuidoresBindingSource.DataSource = this.gasolineraDBDataSet;
            // 
            // distribuidoresTableAdapter
            // 
            this.distribuidoresTableAdapter.ClearBeforeFill = true;
            // 
            // DistribuidoresReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 721);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DistribuidoresReportForm";
            this.Text = "Reporte de Distribuidores";
            this.Load += new System.EventHandler(this.DistribuidoresReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gasolineraDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.distribuidoresBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private gasolineraDBDataSet gasolineraDBDataSet;
        private System.Windows.Forms.BindingSource distribuidoresBindingSource;
        private gasolineraDBDataSetTableAdapters.distribuidoresTableAdapter distribuidoresTableAdapter;
    }
}