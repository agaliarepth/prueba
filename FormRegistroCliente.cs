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
    public partial class FormRegistroCliente : Form
    {
        private gasolineraDBDataSetTableAdapters.clientesTableAdapter cliente = new gasolineraDBDataSetTableAdapters.clientesTableAdapter();
        private gasolineraDBDataSet.clientesDataTable c;
        private Int32 id_cliente;
        private bool actualizar = false;
        public FormRegistroCliente()
        {
            InitializeComponent();
        }
        public FormRegistroCliente(int  cod)
        {
            InitializeComponent();
            this.id_cliente = cod;
            c = cliente.GetCliente(this.id_cliente);
            rellenarFormulario();
            actualizar = true;
         
        }

        private void rellenarFormulario() {

            //tb_codCliente.Text = c[0]["id_cliente"].ToString();
            //tb_codCliente.Enabled = false;
            tb_nombre.Text = c[0]["nombre_cliente"].ToString();
            tb_apellido.Text = c[0]["apellido_cliente"].ToString();
            tb_direccion.Text = c[0]["direccion_cliente"].ToString();
            tb_numPlaca.Text = c[0]["num_placa"].ToString();
            tb_ci.Text = c[0]["ci_nit"].ToString();
            tb_observaciones.Text = c[0]["observaciones"].ToString();
            if (c[0]["sexo"].ToString() == "Hombre")
                rb_hombre.Checked = true;
            else
                rb_mujer.Checked = true;
        
        }
        private void guardarCliente(){
            //string cod = tb_codCliente.Text.ToUpper().ToString();
            string nom = tb_nombre.Text.ToUpper().ToString();
            string ape = tb_apellido.Text.ToUpper().ToString();
            string ci = tb_ci.Text.ToUpper().ToString();
            string tel = tb_telefono.Text.ToString();
            string dir = tb_direccion.Text.ToString();
            string obs = tb_observaciones.Text.ToString();
            string placa = tb_numPlaca.Text.ToUpper().ToString();
            string pais = cb_pais.Text.ToUpper().ToString();
            string sexo=rb_hombre.Checked?"Hombre":"Mujer";

            try
            {
                cliente.Insert(nom, ape, tel, dir, placa, pais, ci, sexo, obs);
                MessageBox.Show("Los datos se guardaron correctamente ");
                this.Close();
            }
            catch (FormatException e)
            {
                MessageBox.Show(e.Message);
                return;
            }
            catch (SqlException e) {
                MessageBox.Show(e.Message);
                return;
            
            }
        
        
        }

        private void cancelar_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (actualizar == false )
                guardarCliente();

            else if (actualizar == true)
                actualizarRegistros();
        }
        private void actualizarRegistros()
        {
            DataRow fila = c.Rows.Find(this.id_cliente);

            MessageBox.Show(this.id_cliente.ToString());
            fila.BeginEdit();
            //string cod = tb_codCliente.Text.ToUpper().ToString();
            string nom = tb_nombre.Text.ToUpper().ToString();
            string ape = tb_apellido.Text.ToUpper().ToString();
            string ci = tb_ci.Text.ToUpper().ToString();
            string tel = tb_telefono.Text.ToString();
            string dir = tb_direccion.Text.ToString();
            string obs = tb_observaciones.Text.ToString();
            string placa = tb_numPlaca.Text.ToUpper().ToString();
            string pais = cb_pais.Text.ToUpper().ToString();
            string sexo = rb_hombre.Checked ? "Hombre" : "Mujer";
            fila["nombre_cliente"] = nom;
            fila["apellido_cliente"] = ape;
            fila["telefono_cliente"] = tel;
            fila["direccion_cliente"] =dir;
            fila["num_placa"] = placa;
            fila["pais_placa"] =pais;
            fila["ci_nit"] =ci;
            if(rb_hombre.Checked)
            fila["sexo"] ="Hombre";
            else if(rb_mujer.Checked)
                fila["sexo"] ="Mujer";
            fila["observaciones"] = obs;
            fila.EndEdit();
            try
            {

                cliente.Update(fila);
                c.AcceptChanges();

                MessageBox.Show("Los datos han sido Actualizados correctamente");

                this.Close();


            }
            catch (SqlException ex)
            {
                MessageBox.Show("no se pudo Actualizar los Datos" + ex.Message, "Actualizar Datos", MessageBoxButtons.OK);



            }

        }

    }
}
