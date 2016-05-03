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
    public partial class FormConfiguracion : Form
    {
       
        private gasolineraDBDataSetTableAdapters.configuracionTableAdapter conf = new gasolineraDBDataSetTableAdapters.configuracionTableAdapter();
        private gasolineraDBDataSet.configuracionDataTable dt = new gasolineraDBDataSet.configuracionDataTable();
        public FormConfiguracion()
        {
            InitializeComponent();
            dt = conf.GetData();

            tb_auto.Text = dt.Rows[0]["numero_autorizacion"].ToString();
            tb_en1.Text = dt.Rows[0]["encabezado1"].ToString();
            tb_en2.Text = dt.Rows[0]["encabezado2"].ToString();
            tb_en3.Text = dt.Rows[0]["encabezado3"].ToString();
            tb_en4.Text = dt.Rows[0]["encabezado4"].ToString();
            tb_llave.Text = dt.Rows[0]["clave_dosificacion"].ToString();
            tb_nit.Text = dt.Rows[0]["nit"].ToString();
            tb_pie1.Text = dt.Rows[0]["pie_factura1"].ToString();
            tb_pie2.Text = dt.Rows[0]["pie_factura2"].ToString();
            dt_fechaLimite.Text = dt.Rows[0]["fecha_limite"].ToString();
        }
        

        private void cancelar_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guardar(object sender, EventArgs e)
        {
            DataRow fila =dt.Rows[0]; 


            fila.BeginEdit();

            fila["nit"] =tb_nit.Text.ToString();
                       
            fila["numero_autorizacion"] =tb_auto.Text;
           
            fila["clave_dosificacion"] =tb_llave.Text;
            fila["fecha_limite"] = dt_fechaLimite.Value.ToShortDateString();
            fila["pie_factura1"]=tb_pie1.Text;
            fila["pie_factura2"] = tb_pie2.Text;
            fila["encabezado1"]=tb_en1.Text;
            fila["encabezado2"] = tb_en2.Text;
            fila["encabezado3"] = tb_en3.Text;
            fila["encabezado4"] = tb_en4.Text;
            fila.EndEdit();
            try
            {

                conf.Update(fila);
                dt.AcceptChanges();

                MessageBox.Show("Los datos han sido Actualizados correctamente");

                this.Close();


            }
            catch 
            {
                MessageBox.Show("no se pudo Actualizar los Datos" , "Actualizar Datos", MessageBoxButtons.OK);



            }

            
            
            
        }
    }
}
