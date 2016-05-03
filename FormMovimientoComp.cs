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
    public partial class FormMovimientoComp : Form
    {
        public FormMovimientoComp()
        {
            InitializeComponent();
        }
        private gasolineraDBDataSetTableAdapters.Vista_comprasDistribuidorTableAdapter compras_da = new gasolineraDBDataSetTableAdapters.Vista_comprasDistribuidorTableAdapter();
        private gasolineraDBDataSetTableAdapters.Vista_detalleComprasTableAdapter detalle = new gasolineraDBDataSetTableAdapters.Vista_detalleComprasTableAdapter();
        gasolineraDBDataSet.Vista_comprasDistribuidorDataTable table = new gasolineraDBDataSet.Vista_comprasDistribuidorDataTable();
        private string tipo;
       
        
        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = compras_da.GetData();
            this.table = compras_da.GetData();
            tipo = "TODAS LAS COMPRAS HASTA LA FECHA";
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = compras_da.GetBy_fechas(dt_f1.Text, dt_f2.Text);
            this.table = compras_da.GetBy_fechas(dt_f1.Text, dt_f2.Text);
            this.tipo = "COMPRAS DE " + dt_f1.Text + " A " + dt_f2.Text;
        }
        private void configuracionesIniciales()
        {

            dataGridView2.Columns["id_detalle_compras"].Visible = false;
            dataGridView2.Columns["descripcion_producto"].Width = 250;

            dataGridView2.Columns["id_compra"].Visible = false;


        }
        private void dataGridView1_Click(object sender, EventArgs e)
        {
            try
            {
                ClassNumeroLetra nl = new ClassNumeroLetra();
                tb_tipo.Text = dataGridView1.CurrentRow.Cells["tipo_documento"].Value.ToString();
                tb_fecha.Text = dataGridView1.CurrentRow.Cells["fecha_compra"].Value.ToString();
                numDoc.Text = dataGridView1.CurrentRow.Cells["numero_documento"].Value.ToString();
                distri.Text = dataGridView1.CurrentRow.Cells["nombre_distri"].Value.ToString() + dataGridView1.CurrentRow.Cells["apellido_distri"].Value.ToString();
                label6.Text = dataGridView1.CurrentRow.Cells["monto_total"].Value.ToString();
                label3.Text = nl.Convertir(label6.Text, true);

                dataGridView2.DataSource = detalle.GetDataBy_idCompra(Convert.ToInt32(dataGridView1.CurrentRow.Cells["id_compra"].Value));
                configuracionesIniciales();
            }
            catch {

                MessageBox.Show("no existe Compras Registradas");
            
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

       

        private void linkLabel2_Click(object sender, EventArgs e)
        {
            CoprasReport com = new CoprasReport(this.table, this.tipo);
            com.ShowDialog();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CoprasReport com = new CoprasReport(this.table, this.tipo);
            com.ShowDialog();
        }

        private void FormMovimientoComp_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = compras_da.GetData();
            this.table = compras_da.GetData();
        }

      
    }
}
