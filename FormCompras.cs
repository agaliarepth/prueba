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
    public partial class FormCompras : Form
    {
        
        private int id_dist;
        private gasolineraDBDataSetTableAdapters.detalle_comprasTableAdapter det_compra = new gasolineraDBDataSetTableAdapters.detalle_comprasTableAdapter();
        private gasolineraDBDataSetTableAdapters.comprasTableAdapter compras = new gasolineraDBDataSetTableAdapters.comprasTableAdapter();
        public FormCompras()
        {
            InitializeComponent();
            cb_tipo.SelectedIndex = 0;
         
        }

        private void FormCompras_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'gasolineraDBDataSet.bombas' Puede moverla o quitarla según sea necesario.
            this.bombasTableAdapter.Fill(this.gasolineraDBDataSet.bombas);
            // TODO: esta línea de código carga datos en la tabla 'gasolineraDBDataSet.clientes' Puede moverla o quitarla según sea necesario.
            this.clientesTableAdapter.Fill(this.gasolineraDBDataSet.clientes);
            
            this.productosTableAdapter.Fill(this.gasolineraDBDataSet.productos);

        }

        private void dg_prod_DoubleClick(object sender, EventArgs e)
        {
            
        }
        private void adicionarFila() {

            
        }
        private void guardar() {

            int max = 0;
            string dia = dt_fecha.Text.Substring(0, 2);
            string mes = dt_fecha.Text.Substring(3, 2);
            string anio =dt_fecha.Text.Substring(6, 4);
            try
            {
                compras.Insert(Convert.ToDecimal(lb_total.Text.ToString()), tb_doc.Text.ToString(),cb_tipo.Text,dt_fecha.Text.ToString(), this.id_dist,mes,anio);
               
              max = Convert.ToInt32(compras.max_id());
             
                  foreach (DataGridViewRow row in dataGridView1.Rows)


                      det_compra.Insert(Convert.ToInt32(row.Cells["descripcion"].Value), Convert.ToDecimal(row.Cells["cantidad_prod"].Value), Convert.ToDecimal(row.Cells["monto_total"].Value), max);

            
             
            }
            catch(Exception e)
            {
                MessageBox.Show("No se puede Guardar La Compra"+e, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            MessageBox.Show("Los datos se Guardaron Correctamente");
            this.Close();
            
        }
        
        private void guardar_btn_Click(object sender, EventArgs e)
        {

            if (validarCampos(tb_nom) && validadDataGrid() && dataGridView1.RowCount>0)
            {
                actualizarNivel();
                guardar();

            }
        }
        private void actualizarNivel() {

            gasolineraDBDataSet.tanquesDataTable r = new gasolinera.gasolineraDBDataSet.tanquesDataTable();
            r = tanquesTableAdapter1.GetData();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
               
                DataRow fila = r.Rows.Find(Convert.ToInt32(row.Cells["descripcion"].Value));
                fila.BeginEdit();
                decimal c = Convert.ToDecimal(fila["stock"]);
                fila["stock"] = c+Convert.ToDecimal(row.Cells["cantidad_prod"].Value);


                fila.EndEdit();
                try
                {

                    tanquesTableAdapter1.Update(fila);
                    r.AcceptChanges();




                }
                catch (SqlException ex)
                {
                    MessageBox.Show("no se pudo Actualizar los Datos" + ex.Message, "Actualizar Datos", MessageBoxButtons.OK);



                }
            }

            


           
           
        }

        private bool validarCampos(Control c)
        {
            bool sw = false;
            if (c.Text == "")
            {
                //errorProvider.SetError(c, "Por Favor Introdusca valor");

                c.Focus();
                c.BackColor = Color.AntiqueWhite;


                return sw;

            }


            else
            {
                //errorProvider.Clear();
                sw = true;
                return sw;

            }
        }
        private decimal sumCantidad()
        {
            decimal sum_total = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                sum_total += Convert.ToDecimal(row.Cells["cantidad_prod"].Value);
            }

            return sum_total;
            


        }
        private decimal sumTotal()
        {
            decimal sum_total = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                sum_total += Convert.ToDecimal(row.Cells["monto_total"].Value);
            }

            return sum_total;

        }
      
       
        
       
        private void dataGridView1_CellEndEdit_1(object sender, DataGridViewCellEventArgs e)
        {

           
                DataGridViewRow fila = dataGridView1.CurrentRow;
                try
                {
                    fila.Cells["monto_total"].Value = Math.Round((Convert.ToDecimal(fila.Cells["cantidad_prod"].Value) * Convert.ToDecimal(fila.Cells["precio_producto"].Value)), 2);
                }
                catch (FormatException ex)
                {

                    MessageBox.Show("ERROR " + ex.Message, "ERROR DE FORMATO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


                if (fila.Cells["cantidad_prod"] != null)
                    lb_total.Text = sumTotal().ToString();
            }
            
        
     
        private void button4_Click(object sender, EventArgs e)
        {
            if ( validadDataGrid())
            {
                dataGridView1.Rows.Add();


               lb_total.Text = sumTotal().ToString();

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount > 0)
            {
                dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
                lb_total.Text = sumTotal().ToString();
            }
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


        private int NivelTanque(int id_tanque)
        {
            gasolineraDBDataSetTableAdapters.tanquesTableAdapter taDA = new gasolineraDBDataSetTableAdapters.tanquesTableAdapter();


            return (Convert.ToInt32(taDA.NivelTanque(id_tanque)));


        }
       
        
        
        private bool validadDataGrid(){
            bool result = true;
            int stock;
      foreach (DataGridViewRow row in dataGridView1.Rows)

{

row.ErrorText = "";
          
//stock=NivelTanque(Convert.ToInt32(row.Cells["descripcion"].Value));
 
if (string.IsNullOrEmpty(Convert.ToString(row.Cells["descripcion"].Value)))

{

row.ErrorText = "Debe seleccionar in item de compra.";

result = false;

}

 

if (string.IsNullOrEmpty(Convert.ToString(row.Cells["cantidad_prod"].Value)))

{

row.ErrorText = "Debe ingresar una cantidad";

result = false;

}
   

else

{



//if (!Int32.TryParse(Convert.ToString(row.Cells["cantidad_prod"].Value), out cantidad))
//{

//    row.ErrorText = "La cantidad ingresada debe ser un valor numerico";

//    result = false;

//}

}
if (string.IsNullOrEmpty(Convert.ToString(row.Cells["precio_producto"].Value)))
{

    row.ErrorText = "Debe ingresar un precio";

    result = false;

}

else
{

    


}

 

}

 

return result;

}

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cancelar_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tanquesBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        

        
    }
}
