using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace gasolinera.Reportes
{
    public partial class VentasReportForm : Form
    {
        private string tipo_reporte;

        private gasolineraDBDataSetTableAdapters.ventasTableAdapter ventas_da = new gasolineraDBDataSetTableAdapters.ventasTableAdapter();
        public VentasReportForm(string tipo)
        {
            InitializeComponent();
            this.tipo_reporte = tipo;
            if (this.tipo_reporte == "bomba")
            {

                this.comboBox1.DataSource = this.bombasBindingSource;
                this.comboBox1.DisplayMember = "num_bomba";
                this.comboBox1.ValueMember = "id_bomba";
                label1.Text = "Bombas";
            }
            if (this.tipo_reporte == "empleado")
            {

                this.comboBox1.DataSource = this.empleadosBindingSource;
                this.comboBox1.DisplayMember = "nombre_empleado";
                this.comboBox1.ValueMember = "id_empleado";
                label1.Text = "Empleados";
            }
            if (this.tipo_reporte == "turno")
            {

                this.comboBox1.DataSource = this.turnosBindingSource;
                this.comboBox1.DisplayMember = "descripcion";
                this.comboBox1.ValueMember = "id_turno";
                label1.Text = "Turnos";
            }
            if (this.tipo_reporte == "fecha")
            {

                this.comboBox1.Visible = false;
                label1.Visible = false;
               
            }







        }

        private void VentasTurnoForm_Load(object sender, EventArgs e)
        {

            this.turnosTableAdapter.Fill(this.gasolineraDBDataSet.turnos);
            this.clientesTableAdapter.Fill(this.gasolineraDBDataSet.clientes);
            this.empleadosTableAdapter.Fill(this.gasolineraDBDataSet.empleados);
            this.bombasTableAdapter.Fill(this.gasolineraDBDataSet.bombas);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.DataSources.Clear();



            if (tipo_reporte == "bomba")
            {



                Microsoft.Reporting.WinForms.ReportDataSource rds = new Microsoft.Reporting.WinForms.ReportDataSource();
                rds.Name = "DataSet1";
                rds.Value = ventas_da.GetBy_idBomba(Convert.ToInt32(comboBox1.SelectedValue), dateTimePicker1.Value.ToString("dd/MM/yyyy"), dateTimePicker2.Value.ToString("dd/MM/yyyy"));
                reportViewer1.LocalReport.DataSources.Add(rds);

                Microsoft.Reporting.WinForms.ReportParameter tipo = new Microsoft.Reporting.WinForms.ReportParameter();
                tipo.Name = "clave";
                tipo.Values.Add("VENTAS DE LA BOMBA Nº " + comboBox1.Text.ToString());
                reportViewer1.LocalReport.SetParameters(tipo);
                this.reportViewer1.RefreshReport();
            }
            if (tipo_reporte == "empleado")
            {



                Microsoft.Reporting.WinForms.ReportDataSource rds = new Microsoft.Reporting.WinForms.ReportDataSource();
                rds.Name = "DataSet1";
                rds.Value = ventas_da.GetBy_idEmpleado(dateTimePicker1.Value.ToString("dd/MM/yyyy"), dateTimePicker2.Value.ToString("dd/MM/yyyy"), Convert.ToInt32(comboBox1.SelectedValue));
                reportViewer1.LocalReport.DataSources.Add(rds);

                Microsoft.Reporting.WinForms.ReportParameter tipo = new Microsoft.Reporting.WinForms.ReportParameter();
                tipo.Name = "clave";
                tipo.Values.Add("VENTAS DEL EMPLEADO " + comboBox1.Text.ToString());
                reportViewer1.LocalReport.SetParameters(tipo);
                this.reportViewer1.RefreshReport();
               
            }
            if (tipo_reporte == "turno")
            {



                Microsoft.Reporting.WinForms.ReportDataSource rds = new Microsoft.Reporting.WinForms.ReportDataSource();
                rds.Name = "DataSet1";
                rds.Value = ventas_da.GetBy_idTurno(Convert.ToInt32(comboBox1.SelectedValue), dateTimePicker1.Value.ToString("dd/MM/yyyy"), dateTimePicker2.Value.ToString("dd/MM/yyyy"));
                reportViewer1.LocalReport.DataSources.Add(rds);

                Microsoft.Reporting.WinForms.ReportParameter tipo = new Microsoft.Reporting.WinForms.ReportParameter();
                tipo.Name = "clave";
                tipo.Values.Add("VENTAS DEL " + comboBox1.Text.ToString());
                reportViewer1.LocalReport.SetParameters(tipo);
                this.reportViewer1.RefreshReport();
            }
            if (tipo_reporte == "fecha")
            {



                Microsoft.Reporting.WinForms.ReportDataSource rds = new Microsoft.Reporting.WinForms.ReportDataSource();
                rds.Name = "DataSet1";
                rds.Value = ventas_da.GetBy_fecha(dateTimePicker1.Value.ToString("dd/MM/yyyy"), dateTimePicker2.Value.ToString("dd/MM/yyyy"));
                reportViewer1.LocalReport.DataSources.Add(rds);

                Microsoft.Reporting.WinForms.ReportParameter tipo = new Microsoft.Reporting.WinForms.ReportParameter();
                tipo.Name = "clave";
                tipo.Values.Add("VENTAS POR PERIODO");
                reportViewer1.LocalReport.SetParameters(tipo);
                this.reportViewer1.RefreshReport();
            }
        }

        private void clientesBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
        
    }

