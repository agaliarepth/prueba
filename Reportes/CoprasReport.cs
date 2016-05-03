using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace gasolinera.Reportes
{
    public partial class CoprasReport : Form
    {
        private gasolineraDBDataSet.Vista_comprasDistribuidorDataTable table = new gasolineraDBDataSet.Vista_comprasDistribuidorDataTable();
        private string tipo;
        Microsoft.Reporting.WinForms.ReportDataSource rds = new Microsoft.Reporting.WinForms.ReportDataSource();
        Microsoft.Reporting.WinForms.ReportParameter par = new Microsoft.Reporting.WinForms.ReportParameter();
        public CoprasReport(gasolineraDBDataSet.Vista_comprasDistribuidorDataTable t, string tip)
        {
            this.table = t;
            this.tipo = tip;
            InitializeComponent();
            //Microsoft.Reporting.WinForms.ReportDataSource rds = new Microsoft.Reporting.WinForms.ReportDataSource();
           
            rds.Name = "DataSet1";
            rds.Value = table;
            reportViewer1.LocalReport.DataSources.Add(rds);


            par.Name = "par";
            par.Values.Add(tipo);
            reportViewer1.LocalReport.SetParameters(par);
            this.reportViewer1.RefreshReport();
         
        }
      

        private void CoprasReport_Load(object sender, EventArgs e)
        {
// TODO: esta línea de código carga datos en la tabla 'gasolineraDBDataSet.Vista_comprasDistribuidor' Puede moverla o quitarla según sea necesario.
//this.vista_comprasDistribuidorTableAdapter.(this.gasolineraDBDataSet.Vista_comprasDistribuidor);

            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
