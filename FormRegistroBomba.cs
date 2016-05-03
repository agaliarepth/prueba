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
    public partial class FormRegistroBomba : Form
    {
        private bool actualizar = false;
        private int id_bomba;
        private int num_mangueras;
        private string tipo_combustible;
        private int id_tanque;
        private int en_uso;
        public FormRegistroBomba()
        {
            InitializeComponent();
        }
        public FormRegistroBomba(int idBomba,int numMangueras,string tipoCombustible,int idTanque,int enUso)
        {
            InitializeComponent();
           id_bomba=idBomba;
         num_mangueras=numMangueras;
        tipo_combustible=tipoCombustible;
       id_tanque=idTanque;
         en_uso=enUso;
            this.actualizar = true;

            codigo_tb.Enabled = false;
            
            rellenarFormulario();
        }
        private void rellenarFormulario() {


            codigo_tb.Text = id_bomba.ToString();
            combustible_cb.Text = tipo_combustible;
           
            mangueras.Value = num_mangueras;


        }
        private void guardarBomba() {

            short cod = Convert.ToInt16(codigo_tb.Text);
            string com = combustible_cb.Text.ToString();
            int id_tanque = Convert.ToInt16(tabque_cb.Text);
           int man =(int)mangueras.Value;
            Int32 uso=0;
            gasolineraDBDataSetTableAdapters.bombasTableAdapter bomb = new gasolineraDBDataSetTableAdapters.bombasTableAdapter();
            try
            {
                bomb.Insert(com,id_tanque,man);
                MessageBox.Show("Los datos se guardaron correctamente ");
                this.Close();
            }
            catch (FormatException e)
            {
                MessageBox.Show(e.Message);
                return;
            }
            catch (SqlException e)
            {
                MessageBox.Show("El Codigo ya existe , por favor introdusca otro codigo"+e);
                return;
            }
                
               
        
        
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
        private void cancelar_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void actualizarRegistros()
        {
            gasolineraDBDataSet.bombasDataTable r = new gasolinera.gasolineraDBDataSet.bombasDataTable();
            gasolineraDBDataSetTableAdapters.bombasTableAdapter bomb = new gasolineraDBDataSetTableAdapters.bombasTableAdapter();
            r = bomb.GetData();

            DataRow fila = r.Rows.Find(id_bomba);


            fila.BeginEdit();

            fila["id_bomba"] = Convert.ToInt32(codigo_tb.Text);

            fila["num_mangueras"] = Convert.ToInt32(mangueras.Value);
            fila["tipo_combustible"] = combustible_cb.Text;

            fila.EndEdit();
            try
            {

                bomb.Update(fila);
                r.AcceptChanges();

              

                this.Close();


            }
            catch (SqlException ex)
            {
                MessageBox.Show("no se pudo Actualizar los Datos" + ex.Message, "Actualizar Datos", MessageBoxButtons.OK);



            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.actualizar == false && validarCampos(codigo_tb))
                guardarBomba();
            else if (this.actualizar == true)
                actualizarRegistros();
        }

        private void FormRegistroBomba_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'gasolineraDBDataSet.productos' Puede moverla o quitarla según sea necesario.
            this.productosTableAdapter.Fill(this.gasolineraDBDataSet.productos);
            // TODO: esta línea de código carga datos en la tabla 'gasolineraDBDataSet.tanques' Puede moverla o quitarla según sea necesario.
            this.tanquesTableAdapter.Fill(this.gasolineraDBDataSet.tanques);

        }
    }
}
