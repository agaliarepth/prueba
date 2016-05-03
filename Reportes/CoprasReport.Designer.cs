namespace gasolinera.Reportes
{
    partial class CoprasReport
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
            this.gasolineraVistasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gasolineraVistas = new gasolinera.gasolineraVistas();
            this.gasolineraDBDataSet = new gasolinera.gasolineraDBDataSet();
            this.gasolineraDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.distribuidoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.distribuidoresTableAdapter = new gasolinera.gasolineraDBDataSetTableAdapters.distribuidoresTableAdapter();
            this.Vista_comprasDistribuidorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vistacomprasDistribuidorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vista_comprasDistribuidorTableAdapter = new gasolinera.gasolineraDBDataSetTableAdapters.Vista_comprasDistribuidorTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.gasolineraVistasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gasolineraVistas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gasolineraDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gasolineraDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.distribuidoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Vista_comprasDistribuidorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistacomprasDistribuidorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gasolineraVistasBindingSource
            // 
            this.gasolineraVistasBindingSource.DataSource = this.gasolineraVistas;
            this.gasolineraVistasBindingSource.Position = 0;
            // 
            // gasolineraVistas
            // 
            this.gasolineraVistas.DataSetName = "gasolineraVistas";
            this.gasolineraVistas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gasolineraDBDataSet
            // 
            this.gasolineraDBDataSet.DataSetName = "gasolineraDBDataSet";
            this.gasolineraDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gasolineraDBDataSetBindingSource
            // 
            this.gasolineraDBDataSetBindingSource.DataSource = this.gasolineraDBDataSet;
            this.gasolineraDBDataSetBindingSource.Position = 0;
            // 
            // distribuidoresBindingSource
            // 
            this.distribuidoresBindingSource.DataMember = "distribuidores";
            this.distribuidoresBindingSource.DataSource = this.gasolineraDBDataSetBindingSource;
            // 
            // distribuidoresTableAdapter
            // 
            this.distribuidoresTableAdapter.ClearBeforeFill = true;
            // 
            // Vista_comprasDistribuidorBindingSource
            // 
            this.Vista_comprasDistribuidorBindingSource.DataMember = "Vista_comprasDistribuidor";
            this.Vista_comprasDistribuidorBindingSource.DataSource = this.gasolineraDBDataSet;
            // 
            // vistacomprasDistribuidorBindingSource
            // 
            this.vistacomprasDistribuidorBindingSource.DataMember = "Vista_comprasDistribuidor";
            this.vistacomprasDistribuidorBindingSource.DataSource = this.gasolineraDBDataSet;
            // 
            // vista_comprasDistribuidorTableAdapter
            // 
            this.vista_comprasDistribuidorTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "gasolinera.Reportes.ComprasDist.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(766, 601);
            this.reportViewer1.TabIndex = 2;
            // 
            // CoprasReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 601);
            this.Controls.Add(this.reportViewer1);
            this.Name = "CoprasReport";
            this.Text = "CoprasReport";
            this.Load += new System.EventHandler(this.CoprasReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gasolineraVistasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gasolineraVistas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gasolineraDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gasolineraDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.distribuidoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Vista_comprasDistribuidorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistacomprasDistribuidorBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource gasolineraVistasBindingSource;
        private gasolineraVistas gasolineraVistas;
        private gasolineraDBDataSet gasolineraDBDataSet;
        private System.Windows.Forms.BindingSource gasolineraDBDataSetBindingSource;
        private System.Windows.Forms.BindingSource distribuidoresBindingSource;
        private gasolineraDBDataSetTableAdapters.distribuidoresTableAdapter distribuidoresTableAdapter;
        private System.Windows.Forms.BindingSource Vista_comprasDistribuidorBindingSource;
        private System.Windows.Forms.BindingSource vistacomprasDistribuidorBindingSource;
        private gasolineraDBDataSetTableAdapters.Vista_comprasDistribuidorTableAdapter vista_comprasDistribuidorTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}