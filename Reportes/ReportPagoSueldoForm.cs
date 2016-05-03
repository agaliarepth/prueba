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
    public partial class ReportPagoSueldoForm : Form
    {
        private int id;
        private string tipo_empleado;
        Microsoft.Reporting.WinForms.ReportDataSource rds = new Microsoft.Reporting.WinForms.ReportDataSource();
        private gasolineraDBDataSetTableAdapters.pagos_sueldosTableAdapter ps = new gasolineraDBDataSetTableAdapters.pagos_sueldosTableAdapter();
        private gasolineraDBDataSet.pagos_sueldosDataTable table = new gasolineraDBDataSet.pagos_sueldosDataTable();
        public ReportPagoSueldoForm()
        {
            InitializeComponent();
        }
        public ReportPagoSueldoForm(int cod,string tipo)
        {
            InitializeComponent();
            this.id = cod;
            this.tipo_empleado = tipo;
           table=ps.GetDataById(this.id);
        }
        private void ReportPagoSueldoForm_Load(object sender, EventArgs e)
        {

            rds.Name = "DataSet1";
            rds.Value = table;
            reportViewer1.LocalReport.DataSources.Add(rds);
         Microsoft.Reporting.WinForms.ReportParameter t = new Microsoft.Reporting.WinForms.ReportParameter();
           t.Name = "tipo";
           t.Values.Add(this.tipo_empleado);
           reportViewer1.LocalReport.SetParameters(t);
            this.reportViewer1.RefreshReport();
        }
    }
}
