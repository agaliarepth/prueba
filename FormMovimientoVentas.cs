using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using gasolinera.Reportes;

namespace gasolinera
{
    public partial class FormMovimientoVentas : Form
    {
       
        private gasolineraDBDataSet.ventasDataTable table=new gasolineraDBDataSet.ventasDataTable();
        private string tipo;
        private gasolineraDBDataSetTableAdapters.ventasTableAdapter v = new gasolineraDBDataSetTableAdapters.ventasTableAdapter();
        private gasolineraDBDataSetTableAdapters.ViewDetalleFacturaTableAdapter det = new gasolineraDBDataSetTableAdapters.ViewDetalleFacturaTableAdapter();


        public FormMovimientoVentas()
        {
            //this.id = cod;
            //this.nom = nombre;

            InitializeComponent();

            dataGridView1.DataSource = v.GetData();
            //table = v.Get_todos(this.id);
            tipo = "TODAS LAS VENTAS  HASTA HOY";
            dataGridView1.Focus();
            condicionesIniciales();
        }

        private void condicionesIniciales()
        {
            dataGridView1.Columns["id_cliente"].Visible = false;
            dataGridView1.Columns["nombre_cliente"].Visible = false;
            dataGridView1.Columns["nitci_cliente"].Visible = false;
            dataGridView1.Columns["id_empleado"].Visible = false;
            dataGridView1.Columns["monto_total"].Visible = false;
            dataGridView1.Columns["num_placa"].Visible = false;
            dataGridView1.Columns["numero_autorizacion"].Visible = false;
            dataGridView1.Columns["id_ventas"].Visible = false;
            dataGridView1.Columns["id_turno"].Visible = false;


            dataGridView1.Columns["id_bomba"].HeaderText = "BOMBA";
            dataGridView1.Columns["id_bomba"].Width = 50;
            dataGridView1.Columns["id_bomba"].DisplayIndex = 6;

            dataGridView1.Columns["numero_factura"].HeaderText = "Nº FACTURA";
            dataGridView1.Columns["fecha"].HeaderText = "FECHA";
            dataGridView1.Columns["hora"].HeaderText = "Hrs";
            dataGridView1.Columns["codigo_control"].HeaderText = "CODIGO CONTROL";
            dataGridView1.Columns["codigo_control"].Width = 150;
            dataGridView1.Columns["codigo_control"].DisplayIndex = 3;
            try
            {
                DataGridViewRow row = dataGridView1.Rows[0];
                numDoc.Text = row.Cells[1].Value.ToString();
            }
            catch {
                MessageBox.Show("No existen Ventas Registradas");
            }



          

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ClassNumeroLetra letra = new ClassNumeroLetra();
            label3.Text ="Son:"+ letra.Convertir(label6.Text.ToString(), true);
            numDoc.Text = dataGridView1.CurrentRow.Cells["id_cliente"].Value.ToString();
            tb_nombre.Text = dataGridView1.CurrentRow.Cells["nombre_cliente"].Value.ToString();
            tb_cinit.Text = dataGridView1.CurrentRow.Cells["nitci_cliente"].Value.ToString();
            tb_placa.Text = dataGridView1.CurrentRow.Cells["num_placa"].Value.ToString();
            tb_fecha.Text = dataGridView1.CurrentRow.Cells["fecha"].Value.ToString();
            tb_numControl.Text = dataGridView1.CurrentRow.Cells["codigo_control"].Value.ToString();

            distri.Text = dataGridView1.CurrentRow.Cells["numero_autorizacion"].Value.ToString();
            label6.Text = dataGridView1.CurrentRow.Cells["monto_total"].Value.ToString();

            dataGridView2.DataSource = det.GetData(Convert.ToInt32(dataGridView1.CurrentRow.Cells["id_ventas"].Value));
            //table = det.GetData_idVentas(Convert.ToInt32(dataGridView1.CurrentRow.Cells["id_ventas"].Value));
        }

        private void get_todosToolStripButton_Click(object sender, EventArgs e)
        {


        }

        private void button4_Click(object sender, EventArgs e)
        {

            dataGridView1.DataSource = v.GetBy_fecha(dt_f1.Text, dt_f2.Text);
            table = v.GetBy_fecha(dt_f1.Text, dt_f2.Text);

            tipo = "VENTAS  DE " + dt_f1.Text + " HASTA " + dt_f2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = v.GetData();
            table = v.GetData();
            tipo = "TODAS LAS VENTAS  HASTA HOY";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string f1 = DateTime.Now.ToShortDateString();
            string f2 = DateTime.Now.ToLongDateString();
            dataGridView1.DataSource = v.GetBy_fecha(f1, f1);
            table = v.GetBy_fecha(f1, f1);
            tipo = "VENTAS " + f2;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (dataGridView2.RowCount > 0)
                imprimirFactura();
            else
                MessageBox.Show("Eliga Una Factura de La Lista");

        }
        private void imprimirFactura()
        {
            Ticket ticket = new Ticket();
            //ticket.HeaderImage = "C:\imagen.jpg"; //esta propiedad no es obligatoria 

            ticket.AddHeaderLine("GASOLINERA");
            ticket.AddHeaderLine("EXPEDIDO EN:ORURO");
            ticket.AddHeaderLine("DIRERCION");

            ticket.AddHeaderLine("NIT: 506632585");

            //El metodo AddSubHeaderLine es lo mismo al de AddHeaderLine con la diferencia 
            //de que al final de cada linea agrega una linea punteada "==========" 
            ticket.AddSubHeaderLine("BOMBA #  - FACTURA #");
            ticket.AddSubHeaderLine("Le atendió: EMPLEADO");
            ticket.AddSubHeaderLine(DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString());

            //El metodo AddItem requeire 3 parametros, el primero es cantidad, el segundo es la descripcion 
            //del producto y el tercero es el precio 
            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                ticket.AddItem(row.Cells["cantidad"].Value.ToString(), row.Cells["descripcion_producto"].Value.ToString() + "-" + row.Cells["precio_producto"].Value.ToString(), row.Cells["total"].Value.ToString());




            }

            ClassNumeroLetra letra = new ClassNumeroLetra();
           
            //El metodo AddTotal requiere 2 parametros, la descripcion del total, y el precio 
            //ticket.AddTotal("SUBTOTAL", "29.75");
            //ticket.AddTotal("IVA", "5.25");
            ticket.AddTotal("TOTAL", label6.Text.ToString());
            ticket.AddTotal("son:", letra.Convertir(label6.Text.ToString(), true)); //Ponemos un total en blanco que sirve de espacio 
            ticket.AddTotal("CODIGO CONTROL", this.tb_numControl.ToString());
            
            //ticket.AddTotal("CAMBIO", "15.00");
            //ticket.AddTotal("", "");
            //ticket.AddTotal("USTED AHORRO", "0.00");

            //El metodo AddFooterLine funciona igual que la cabecera 
            ticket.AddFooterLine("GRACIAS POR SU PREFERENCIA...");
            ticket.AddFooterLine("*VUELVA PRONTO *");


            //Y por ultimo llamamos al metodo PrintTicket para imprimir el ticket, este metodo necesita un 
            //parametro de tipo string que debe de ser el nombre de la impresora. 
            //printDialog1.ShowDialog();

            string nombreImpresora = printDialog1.PrinterSettings.PrinterName.ToString();
            //string nombreImpresora = (string)(ConfigurationManager.AppSettings["impresora"]);
            ticket.PrintTicket(nombreImpresora);

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            //VentasReportForm report = new VentasReportForm(this.nom, this.table, this.tipo);
            //report.ShowDialog();
        }

        private void FormMovimientoVentas_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            FormPorEmpleado pe = new FormPorEmpleado();

            if (pe.ShowDialog() == DialogResult.OK && pe.tipo == "id")
            {

                dataGridView1.DataSource = v.GetDataByEmpleado(pe.id);
                table = v.GetDataBy_bomba(pe.id);
                tipo = "TODAS LAS VENTAS  POR EMPLEADO";
            }
            else if (pe.ShowDialog() == DialogResult.Cancel && pe.tipo == "fecha")
            {

                dataGridView1.DataSource = v.GetBy_idEmpleado( pe.f1, pe.f2,pe.id);
                table = v.GetBy_idBomba(pe.id, pe.f1, pe.f2);
                tipo = "TODAS LAS VENTAS  EMPLEADO DE " + pe.f1.ToString() + " A " + pe.f2.ToString();

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormPorBomba por_bomba = new FormPorBomba();
            if (por_bomba.ShowDialog() == DialogResult.OK && por_bomba.tipo=="id")
            {

                dataGridView1.DataSource = v.GetDataBy_bomba(por_bomba.id_bomba);
                table = v.GetDataBy_bomba(por_bomba.id_bomba);
                tipo = "TODAS LAS VENTAS  POR BOMBA";
            }
            else if (por_bomba.ShowDialog() == DialogResult.OK && por_bomba.tipo == "fecha") {

                dataGridView1.DataSource = v.GetBy_idBomba(por_bomba.id_bomba,por_bomba.f1,por_bomba.f2);
                table = v.GetBy_idBomba(por_bomba.id_bomba, por_bomba.f1, por_bomba.f2);
                tipo = "TODAS LAS VENTAS  BOMBA DE "+por_bomba.f1.ToString()+" A "+por_bomba.f2.ToString();
            
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormPorTanque por_tanque = new FormPorTanque();
            if (por_tanque.ShowDialog() == DialogResult.OK && por_tanque.tipo == "id")
            {

                dataGridView1.DataSource = v.GetDataBy_idTurno(por_tanque.id_tanque);
                table = v.GetDataBy_idTurno(por_tanque.id_tanque);
                tipo = "TODAS LAS VENTAS  POR TURNOS";
            }
            else if (por_tanque.ShowDialog() == DialogResult.Cancel && por_tanque.tipo == "fecha")
            {

                dataGridView1.DataSource = v.GetBy_idTurno(por_tanque.id_tanque, por_tanque.f1, por_tanque.f2);
                table = v.GetBy_idTurno(por_tanque.id_tanque, por_tanque.f1, por_tanque.f2);
                tipo = "TODAS LAS VENTAS POR TURNOS DE " + por_tanque.f1.ToString() + " A " + por_tanque.f2.ToString();
            }

        }

        private void linkLabel2_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            VentasFiltradasForm report = new VentasFiltradasForm( this.table, this.tipo);
            report.ShowDialog();
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (dataGridView2.RowCount > 0)
                imprimirFactura();
            else
                MessageBox.Show("Eliga Una Factura de La Lista");

        }


    }
}
