using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using gasolinera.Reportes;
using System.Diagnostics;

namespace gasolinera
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
      
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }
        

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
      
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
           
          
          

          
        }


        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            

           FormTanque t=new FormTanque();

           t.ShowDialog();
        }
        private void cerrarVentanas(string sw)
        {
            

        }

        private void clientes_btn_Click(object sender, EventArgs e)
        {
           

        }

        private void distribuidores_btn_Click(object sender, EventArgs e)
        {
            FormDistribuidores dis = new FormDistribuidores();
            dis.ShowDialog();

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
           
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
           
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            FormSueldos sueldos=new FormSueldos();
            sueldos.ShowDialog();


        }

        private void configuracionDeLasFacturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void pToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void facturacionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormConfiguracion conf= new FormConfiguracion();
            conf.ShowDialog();
        }

        private void turnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTurnos t = new FormTurnos();
            t.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormTanque t = new FormTanque();

            t.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormBombas b = new FormBombas();

            b.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormCliente c = new FormCliente();
            c.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FormFuncionario empleado = new FormFuncionario();
            empleado.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormDistribuidores dis = new FormDistribuidores();
            dis.ShowDialog();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormCombustible fcombu = new FormCombustible();
            fcombu.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            FormSueldos sueldos = new FormSueldos();
            sueldos.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FormCompras2 c = new FormCompras2();
            c.ShowDialog();
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormFuncionario f = new FormFuncionario();
            f.ShowDialog();
        }

        private void tanquesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTanque t = new FormTanque();
            t.ShowDialog();
        }

        private void bombasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBombas b = new FormBombas();
            b.ShowDialog();
        }

        private void distribuidoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDistribuidores d = new FormDistribuidores();
            d.ShowDialog();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCliente c = new FormCliente();
            c.ShowDialog();
        }

        private void comprasToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FormCompras co = new FormCompras();
            co.ShowDialog();
        }

        private void pagosSalarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSueldos sueldo = new FormSueldos();
            sueldo.ShowDialog();
        }

        private void ventasPorBombaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VentasReportForm report_bombas = new VentasReportForm("bomba");
            report_bombas.ShowDialog();

        }

        private void ventasPorEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VentasReportForm report_bombas = new VentasReportForm("empleado");
            report_bombas.ShowDialog();

        }

        private void ventasPorTurnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VentasReportForm report_bombas = new VentasReportForm("turno");
            report_bombas.ShowDialog();

        }

        private void ventasPorFechaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VentasReportForm report_bombas = new VentasReportForm("fecha");
            report_bombas.ShowDialog();
        }

        private void impresoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormConfImpresora imp = new FormConfImpresora();
            imp.ShowDialog();
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {


            System.Diagnostics.Process proc =new System.Diagnostics.Process();

            proc.EnableRaisingEvents = false;

            proc.StartInfo.FileName = "calc";

            proc.Start();
        }

        private void diseñoFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDiseñoFactura dis = new FormDiseñoFactura();
            dis.ShowDialog();
        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ClientesReportForm cr = new ClientesReportForm();
            cr.ShowDialog();
        }

        private void distribuidoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DistribuidoresReportForm distReport = new DistribuidoresReportForm();
            distReport.ShowDialog();
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMovimientoVentas mv = new FormMovimientoVentas();
            mv.ShowDialog();
        }

        private void financieroToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormFinanciero fi = new FormFinanciero();
            fi.ShowDialog();
        }

        private void copiaDeSeguridadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBackup backup = new FormBackup();
            backup.ShowDialog();
        }

        private void restaurarBaseDeDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRestaurarDataBase resta = new FormRestaurarDataBase();
            resta.ShowDialog();
        }

        private void comprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMovimientoComp compras = new FormMovimientoComp();
            compras.ShowDialog();
        }

        private void datosDeFacturacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormConfiguracion conf = new FormConfiguracion();
            conf.ShowDialog();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 f = new AboutBox1();
            f.ShowDialog();
        }

        private void comprasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
          
            
        }

    }
}
