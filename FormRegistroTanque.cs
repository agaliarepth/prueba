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
    public partial class FormRegistroTanque : Form
    {
        private int id_tanque;
        private bool actualizar = false;
        
        private gasolineraDBDataSetTableAdapters.tanquesTableAdapter tanque = new gasolineraDBDataSetTableAdapters.tanquesTableAdapter();
        private gasolineraDBDataSet.tanquesDataTable r;
     
        public FormRegistroTanque()
        {
            InitializeComponent();
            condicionesIniciales();
        }
        public FormRegistroTanque(int cod)
        {
            InitializeComponent();
            this.id_tanque = cod;
            this.actualizar = true;
           r= tanque.GetTanque(id_tanque);
           rellenarFormulario();

            
        }
        private void rellenarFormulario() {
            codigo_tb.Text = r[0]["id_tanque"].ToString();
            codigo_tb.Enabled = false;
            
            capacidad_tb.Text = r[0]["capacidad"].ToString();
            tb_nivel.Text = r[0]["stock_critico"].ToString();

        }
        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void condicionesIniciales() {

           
                    
        }
        private bool validarCampos(Control c)
        {
            bool sw = false;
            if (c.Text == "")
            {
                errorProvider.SetError(c, "Por Favor Introdusca valor");

                c.Focus();
                c.BackColor = Color.AntiqueWhite;


                return sw;

            }


            else
            {
                errorProvider.Clear();
                sw = true;
                return sw;

            }
        }

        private void almacenar() { 
        
        
        
        }
        private void guardarTanque() {
            try
            {
            int id_producto;
            String unidad;
            decimal capacidad ;
            decimal stock_critico;


                //if (validarCampos(codigo_tb))
               id_tanque = Convert.ToInt16(codigo_tb.Text.ToString());

                //if (validarCampos(cb_producto))
               id_producto = Convert.ToInt16(cb_producto.SelectedValue);

                //if (validarCampos(unidad_cb))
                    unidad = unidad_cb.Text.ToString();

                //if (validarCampos(capacidad_tb))
               capacidad = Convert.ToDecimal(capacidad_tb.Text.ToString());

               if (tb_nivel.Text == "")
                   stock_critico = 0;
               else
               stock_critico = Convert.ToDecimal(tb_nivel.Text);

            gasolineraDBDataSetTableAdapters.tanquesTableAdapter tanq =new gasolineraDBDataSetTableAdapters.tanquesTableAdapter();
           
               
                tanq.Insert( unidad, capacidad,stock_critico,0, id_producto,Convert.ToInt32(codigo_tb.Text));
                MessageBox.Show("Los datos se guardaron correctamente ");
                this.Close();
            }
            catch (FormatException e)
            {
                MessageBox.Show(e.Message);
                return;
            }
            catch (SqlException )
            {
                MessageBox.Show("El Codigo del Tanque ya existe , por favor introdusca otro codigo");
                return;
            }
           
        }

        private void guardar_btn_Click(object sender, EventArgs e)
        {
            if (actualizar == false && validarCampos(codigo_tb)&&validarCampos(tb_nivel)&&validarCampos(capacidad_tb))
                guardarTanque();

            else if (actualizar == true)
                actualizarRegistros();


                         
        }
        private void actualizarRegistros(){
            DataRow fila = r.Rows.Find(id_tanque);


            fila.BeginEdit();

            fila["id_tanque"] =Convert.ToInt32(codigo_tb.Text);

            fila["id_producto"] = Convert.ToInt32(cb_producto.SelectedValue);
            fila["unidad"] = unidad_cb.Text;
           
            fila["capacidad"] =Convert.ToDecimal(capacidad_tb.Text);
            fila["stock_critico"] = Convert.ToDecimal(tb_nivel.Text);
            fila.EndEdit();
            try
            {

                tanque.Update(fila);
                r.AcceptChanges();

                //MessageBox.Show("Los datos han sido Actualizados correctamente");

                this.Close();


            }
            catch (SqlException ex)
            {
                MessageBox.Show("no se pudo Actualizar los Datos" + ex.Message, "Actualizar Datos", MessageBoxButtons.OK);



            }

        }

        private void FormRegistroTanque_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'gasolineraDBDataSet.productos' Puede moverla o quitarla según sea necesario.
            this.productosTableAdapter.Fill(this.gasolineraDBDataSet.productos);

        }

        private void codigo_tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar) < 48 && e.KeyChar != 8 && e.KeyChar != 44) || e.KeyChar > 57)
            {

                e.Handled = true;
            }
        }

        private void tb_nivel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar) < 48 && e.KeyChar != 8 && e.KeyChar != 44) || e.KeyChar > 57)
            {

                e.Handled = true;
            }
        }

        private void capacidad_tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar) < 48 && e.KeyChar != 8 && e.KeyChar != 44) || e.KeyChar > 57)
            {

                e.Handled = true;
            }
        }
    }
}
