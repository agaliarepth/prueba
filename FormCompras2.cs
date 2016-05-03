using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace gasolinera
{
    public partial class FormCompras2 : Form
    {
        private int id_dist;
        private gasolineraDBDataSetTableAdapters.detalle_comprasTableAdapter det_compra = new gasolineraDBDataSetTableAdapters.detalle_comprasTableAdapter();
        private gasolineraDBDataSetTableAdapters.comprasTableAdapter compras = new gasolineraDBDataSetTableAdapters.comprasTableAdapter();

        private gasolineraDBDataSetTableAdapters.Vista_TanqueCombustibleTableAdapter tc = new gasolineraDBDataSetTableAdapters.Vista_TanqueCombustibleTableAdapter();
        public FormCompras2()
        {
            InitializeComponent();
            cb_tipo.SelectedIndex = 0;
            dataGridView2.DataSource = tc.GetData();
            InicializarGrilla();

        }
        private void InicializarGrilla(){
            dataGridView2.Columns["id_tanque"].Visible = false;
            dataGridView2.Columns["id_combustible"].Visible = false;
            dataGridView2.Columns["unidad"].Visible = false;
            dataGridView2.Columns["capacidad"].Visible = false;

            dataGridView2.Columns["num_tanque"].HeaderText = "Tanque";
            dataGridView2.Columns["num_tanque"].DisplayIndex = 0;
            dataGridView2.Columns["num_tanque"].Width = 35;

            dataGridView2.Columns["descripcion_producto"].HeaderText = "Descripcion";
            dataGridView2.Columns["descripcion_producto"].DisplayIndex = 1;
            dataGridView2.Columns["descripcion_producto"].Width = 180;

            dataGridView2.Columns["unidad_producto"].HeaderText = "Unid";
            dataGridView2.Columns["unidad_producto"].DisplayIndex = 2;
            dataGridView2.Columns["unidad_producto"].Width = 50;

            dataGridView2.Columns["stock"].HeaderText = "Nivel Actual";
            dataGridView2.Columns["stock"].DisplayIndex =3;
            dataGridView2.Columns["stock"].Width = 100;


        
        }

        private void FormCompras2_Load(object sender, EventArgs e)
        {
            

        }

        private bool validadDataGrid()
        {

            return true;
        }



        private decimal sumTotal()
        {
            decimal sum_total = 0;
           
            return sum_total;

        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }


        private decimal sumCantidad()
        {
            decimal sum_total = 0;
            foreach (DataGridViewRow row in detalle.Rows)
            {
                sum_total += Convert.ToDecimal(row.Cells["cantidad_prod"].Value);
            }

            return sum_total;



        }
        private decimal CalcTotal()
        {
            decimal sum_total = 0;
            foreach (DataGridViewRow row in detalle.Rows)
            {
                sum_total += Convert.ToDecimal(row.Cells["total"].Value);
            }

            return sum_total;

        }


        private void actualizarNivel()
        {

            gasolineraDBDataSetTableAdapters.tanquesTableAdapter tanquesDA = new gasolineraDBDataSetTableAdapters.tanquesTableAdapter();
            decimal sum = 0;
            foreach (DataGridViewRow row in detalle.Rows)
            {

                int tanque  = Convert.ToInt32(row.Cells["tanque"].Value);
                tanquesDA.NivelTanque(tanque);
                sum = sum + Convert.ToDecimal(tanquesDA.NivelTanque(tanque))+ Convert.ToDecimal(row.Cells["Cantidad"].Value);



             
                try
                {
                    tanquesDA.UpdateQueryStock(sum, tanque);
                    sum = 0;
                 




                }
                catch (SqlException ex)
                {
                    MessageBox.Show("no se pudo Actualizar los Datos" + ex.Message, "Actualizar Datos", MessageBoxButtons.OK);



                }
            }






        }

        private void guardar()
        {

            int max = 0;
            string dia = dt_fecha.Text.Substring(0, 2);
            string mes = dt_fecha.Text.Substring(3, 2);
            string anio = dt_fecha.Text.Substring(6, 4);
            try
            {
                compras.Insert(Convert.ToDecimal(total_tb.Text.ToString()), tb_doc.Text.ToString(), cb_tipo.Text, dt_fecha.Text.ToString(), this.id_dist, mes, anio);

                max = Convert.ToInt32(compras.max_id());

                foreach (DataGridViewRow row in detalle.Rows)


                    det_compra.Insert(Convert.ToInt32(row.Cells["id_producto"].Value), Convert.ToDecimal(row.Cells["Cantidad"].Value), Convert.ToDecimal(row.Cells["total"].Value), max);



            }
            catch (Exception e)
            {
                MessageBox.Show("No se puede Guardar La Compra" + e, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            MessageBox.Show("Los datos se Guardaron Correctamente");
            this.Close();

        }
      
        private void dataGridView2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                if (dataGridView2.RowCount <= 0)
                {
                    MessageBox.Show("No existen Tanques Registrados");

                    this.Close();

                }
                else
                {
                    FormCompraDetalle compra = new FormCompraDetalle(dataGridView2.CurrentRow.Cells["num_tanque"].Value.ToString(), dataGridView2.CurrentRow.Cells["descripcion_producto"].Value.ToString(), dataGridView2.CurrentRow.Cells["stock"].Value.ToString(), dataGridView2.CurrentRow.Cells["capacidad"].Value.ToString(), dataGridView2.CurrentRow.Cells["unidad_producto"].Value.ToString(), dataGridView2.CurrentRow.Cells["id_tanque"].Value.ToString());
                    if (compra.ShowDialog() == DialogResult.OK)
                    {

                        detalle.Rows.Add(compra.cantidad, compra.descripcion, compra.unidad, compra.precio, compra.subtotal, compra.id_tanque, dataGridView2.CurrentRow.Cells["id_combustible"].Value.ToString());
                        total_tb.Text = CalcTotal().ToString();
                    }


                }
            }
        }

        private void guardar_btn_Click(object sender, EventArgs e)
        {
            if (tb_nom.Text == "")
                MessageBox.Show("falta Elegir Un Proveedor");
            else
            {
                guardar();
                actualizarNivel();
            }

        }

        private void dataGridView2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
          
                if (dataGridView2.RowCount <= 0)
                {
                    MessageBox.Show("No existen Tanques Registrados");

                    this.Close();

                }
                else
                {
                    FormCompraDetalle compra = new FormCompraDetalle(dataGridView2.CurrentRow.Cells["num_tanque"].Value.ToString(), dataGridView2.CurrentRow.Cells["descripcion_producto"].Value.ToString(), dataGridView2.CurrentRow.Cells["stock"].Value.ToString(), dataGridView2.CurrentRow.Cells["capacidad"].Value.ToString(), dataGridView2.CurrentRow.Cells["unidad_producto"].Value.ToString(), dataGridView2.CurrentRow.Cells["id_tanque"].Value.ToString());
                    if (compra.ShowDialog() == DialogResult.OK)
                    {
                        //MessageBox.Show(det.precio.ToString()+"/"+det.cantidad.ToString()+"/"+det.total.ToString());
                        detalle.Rows.Add(compra.cantidad, compra.descripcion, compra.unidad, compra.precio, compra.subtotal, dataGridView2.CurrentRow.Cells["id_tanque"].Value.ToString(), dataGridView2.CurrentRow.Cells["id_combustible"].Value.ToString());
                        total_tb.Text = CalcTotal().ToString();
                    }


                }
            
        }

        private void cancelar_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                FormListDistribuidores dist = new FormListDistribuidores();

                if (dist.ShowDialog() == DialogResult.OK)
                {

                    tb_nom.Text = dist.nom.ToString();
                    id_dist = dist.id_dist;



                }
            }
            catch { }
        }
    


      
    }
}
