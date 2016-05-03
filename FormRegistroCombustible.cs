using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace gasolinera
{
    public partial class FormRegistroCombustible : Form
    {
        private bool actualizar = false;
        private int cod;
        private string obs, unid, des, mon;
        private decimal pre;
        private gasolineraDBDataSetTableAdapters.productosTableAdapter productoTable = new gasolineraDBDataSetTableAdapters.productosTableAdapter();
        public FormRegistroCombustible()
        {
            InitializeComponent();
            cb_moneda.SelectedIndex = 0;
            cb_unidad.SelectedIndex = 0;
        }

        public FormRegistroCombustible(int codigo,string obs,decimal pre,string unid,string des,string mon)
        {
            this.cod = codigo;
            this.obs = obs;
            this.pre = pre;
            this.unid = unid;
            this.des = des;
            this.mon = mon;
            this.actualizar = true;
            InitializeComponent();
            tb_codigoComb.Enabled = false;
            this.cargarDatos();
        }
        private void cargarDatos() {

            tb_codigoComb.Text = this.cod.ToString();
            tb_descrip.Text = this.des.ToString();
            tb_obs.Text = this.obs.ToString();
            tb_precio.Text = this.pre.ToString();
            

        }
        private void guardarCombustible() {

            string cod = tb_codigoComb.Text.ToUpper().ToString();
            string des = tb_descrip.Text.ToString();
           decimal precio =Convert.ToDecimal(tb_precio.Text);
            string moneda = cb_moneda.Text.ToString();
            string unidad = cb_unidad.Text.ToString();
            string obs = tb_obs.Text.ToString();
            gasolineraDBDataSetTableAdapters.productosTableAdapter comb = new gasolineraDBDataSetTableAdapters.productosTableAdapter();
            try
            {
                comb.Insert(cod,obs,precio,unidad,des,moneda);
                MessageBox.Show("Los datos se guardaron correctamente ");
                this.Close();
            }
            catch (FormatException e)
            {
                MessageBox.Show(e.Message);
                return;
            }
        }

        private void cancelar_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guardarCombustible_btn_Click(object sender, EventArgs e)
        {
            if (!this.actualizar)
                guardarCombustible();
            else
                actualizarDatos();
        }
        private void actualizarDatos() {
            try
            {
                productoTable.UpdateQuery(tb_obs.Text, Convert.ToDecimal(tb_precio.Text), cb_unidad.Text, tb_descrip.Text, cb_moneda.Text, this.cod);
                MessageBox.Show("Los datos se Actualizaron correctamente ");
                this.Close();
            }
            
            catch (FormatException e)
            {
                MessageBox.Show(e.Message);
                return;
            }
        }
    }
}
