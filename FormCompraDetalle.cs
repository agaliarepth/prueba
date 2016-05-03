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
    public partial class FormCompraDetalle : Form
    {
        public string cantidad, descripcion, unidad, precio, subtotal,tanque,id_tanque;
        public FormCompraDetalle(string tanque,string descrip,string nivel, string capacidad,string unidad,string idTanque)
        {
            InitializeComponent();
            lb1.Text = tanque;
            lb2.Text = descrip;
            lb3.Text = nivel;
            lb4.Text = capacidad;
            lb5.Text = unidad;
            this.id_tanque = idTanque;
        }

        private bool validarCant()
        {

            if ((Convert.ToDecimal(cant.Value) + Convert.ToDecimal(lb3.Text))>Convert.ToDecimal(lb4.Text) || cant.Value <= 0)
            {
                MessageBox.Show("No se puede vender Esta cantidad ");

                return false;
            }
            else
                return true;


        }
        private double calcularSubTotal()
        {
            double subtotal = Convert.ToDouble(cant.Value) * Convert.ToDouble(prec.Value);
             return subtotal;


        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void vender_Click(object sender, EventArgs e)
        {
            if (validarCant())
            {
                this.cantidad = cant.Value.ToString();
                this.descripcion = lb2.Text;
                this.unidad = lb5.Text;
                this.precio = prec.Value.ToString();

                this.subtotal = calcularSubTotal().ToString();
                this.tanque = lb1.Text;
             
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
