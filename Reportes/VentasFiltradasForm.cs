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
    public partial class VentasFiltradasForm : Form
    {
       
      
        private gasolineraDBDataSet.ventasDataTable table= new gasolineraDBDataSet.ventasDataTable();
        private string tipoReport;
        Microsoft.Reporting.WinForms.ReportDataSource rds = new Microsoft.Reporting.WinForms.ReportDataSource();

        public VentasFiltradasForm( gasolineraDBDataSet.ventasDataTable t, string tipo)
        {
         
            this.table = t;
            
            this.tipoReport = tipo;

            InitializeComponent();

            
        }

        private void VentasReportForm_Load(object sender, EventArgs e)
        {


           
        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void VentasFiltradasForm_Load(object sender, EventArgs e)
        {
          
           rds.Name = "DataSet1";
           rds.Value = table;
           reportViewer1.LocalReport.DataSources.Add(rds);
           Microsoft.Reporting.WinForms.ReportParameter t = new Microsoft.Reporting.WinForms.ReportParameter();
           t.Name = "clave";
           t.Values.Add(tipoReport);
           reportViewer1.LocalReport.SetParameters(t);
           this.reportViewer1.RefreshReport();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
