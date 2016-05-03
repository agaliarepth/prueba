using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace gasolinera
{
    public partial class FormRegistroDistribuidores : Form
    {
        private int id_dist;
        private string nom;
        private string ape;
        private string dir;
        private string razon;
        private string cinit;
        private string cuenta;
        private string banco;
        private string telf;
        private string obs;
        private Stream MiStream = null;
        private Byte[] foto=null;
        private Image dibujo;
        private bool sw;
        private bool actualizar = false;
        private gasolineraDBDataSetTableAdapters.distribuidoresTableAdapter di = new gasolineraDBDataSetTableAdapters.distribuidoresTableAdapter();
        private gasolineraDBDataSet.distribuidoresDataTable Dt;
        private OpenFileDialog openFileDialog1 = new OpenFileDialog();
       


        public FormRegistroDistribuidores()
        {
            InitializeComponent();
        }
        public FormRegistroDistribuidores(int cod)
        {
            this.id_dist = cod;
            InitializeComponent();
           Dt = di.GetById(this.id_dist);
            rellenarFormulario();
            actualizar = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void AsignarCampos()
        {

            nom = tb_nombre.Text.ToUpper();
            ape = tb_ape.Text.ToUpper();
            telf = tb_telf.Text;
            dir = tb_dir.Text;
            razon = tb_razon.Text;
            cinit = tb_cinit.Text;
            cuenta = tb_cuenta.Text;
            banco = tb_banco.Text;
            guardarFoto();
            obs = tb_obs.Text;
        }
        private void guardarFoto()
        {


            if (openFileDialog1.FileName == "")
            {
                foto = null;
            }
            else if (sw == true)
            {
                dibujo = new Bitmap(openFileDialog1.FileName);

                //Creamos un stream en memoria para guardar la imagen
                MemoryStream memStream = new MemoryStream();
                memStream.SetLength(79000);

                //Guardamos la imagen en nuestro stream especificando el formato (jpg,bmp...) 
                dibujo.Save(memStream, System.Drawing.Imaging.ImageFormat.Jpeg);
                //Guardamos el stream en un array de bytes



                foto = memStream.GetBuffer();
                memStream.Close();


            }
            if (sw == false)
            {

                //dibujo = new Bitmap(pb_foto.Image);

                ////Creamos un stream en memoria para guardar la imagen
                //MemoryStream memStream = new MemoryStream();
                //memStream.SetLength(79000);

                ////Guardamos la imagen en nuestro stream especificando el formato (jpg,bmp...) 
                //dibujo.Save(memStream, System.Drawing.Imaging.ImageFormat.Jpeg);
                ////Guardamos el stream en un array de bytes



                //foto = memStream.GetBuffer();
                //memStream.Close();
            }


        }

        private void guardar()
        {
            AsignarCampos();
            try
            {
                di.Insert(this.nom, this.ape, this.dir, this.razon, this.cinit, this.cuenta, this.banco, this.telf, this.foto, this.obs);
                MessageBox.Show("Los Datos Fueron Registrados Correctamente");
                this.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("No se pudo guardar la informacion" + ex.Message, "Guardar Datos", MessageBoxButtons.OK);

            }



        }
        private void rellenarFormulario()
        {
            tb_codigo.Text = Dt[0]["id_distribuidor"].ToString();
            tb_nombre.Text = Dt[0]["nombre_distri"].ToString();
            tb_ape.Text = Dt[0]["apellido_distri"].ToString();
            tb_dir.Text = Dt[0]["direccion_distri"].ToString();
            tb_razon.Text = Dt[0]["razon_social"].ToString();
            tb_cinit.Text =  Dt[0]["ci_nit"].ToString();
            tb_cuenta.Text = Dt[0]["cuenta_bancaria"].ToString();
            tb_banco.Text = Dt[0]["banco"].ToString();
            tb_telf.Text =  Dt[0]["telefono"].ToString();
           

            if (Dt.Rows[0]["foto"].GetType().ToString() == "System.Byte[]")
            {
                Byte[] imagenByteData = (Byte[])Dt.Rows[0]["foto"];

                MemoryStream memStream = new MemoryStream(imagenByteData);
                pb_foto.Image = new Bitmap(memStream);
                memStream.Close();

            }
            tb_obs.Text = Dt[0]["observaciones"].ToString();


        }
        private bool validarCampos(Control c)
        {
            bool sw = false;
            if (c.Text == "")
            {
                errorProvider1.SetError(c, "Por Favor Introdusca valor");

                c.Focus();
                c.BackColor = Color.AntiqueWhite;


                return sw;

            }


            else
            {
                sw = true;
                return sw;

            }

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (actualizar == false && validarCampos(tb_nombre))
            {


                guardar();


            }
            else if (actualizar == true && validarCampos(tb_nombre) )
                actualizarDatos();
        }
        private void actualizarDatos()
        {
            AsignarCampos();
            Dt = di.GetData();
            DataRow fila = Dt.Rows.Find(this.id_dist);


            fila.BeginEdit();

            fila["nombre_distri"] = this.nom;
            fila["apellido_distri"] = this.ape;
            fila["direccion_distri"] = this.dir;
            fila["razon_social"] = this.razon;
            fila["ci_nit"] = this.cinit;
            fila["cuenta_bancaria"] =this.cuenta;
            fila["banco"] = this.banco;
            fila["telefono"] = this.telf;
          
            guardarFoto();
            fila["foto"] = this.foto;
            fila["observaciones"] = this.obs;

            fila.EndEdit();

            try
            {

                di.Update(fila);
                Dt.AcceptChanges();

                MessageBox.Show("Los datos han sido Actualizados correctamente");

                this.Close();


            }
            catch (SqlException ex)
            {
                MessageBox.Show("no se pudo Actualizar los Datos" + ex.Message, "Actualizar Datos", MessageBoxButtons.OK);



            }
        }

        private void btn_explorar_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "C:\\";
            openFileDialog1.Filter = "JPG(*.jpg)|*.jpg|PNG(*.png)|*.png|GIF(*.gif)|*.gif|Todos(*.Jpg, *.Png, *.Gif, *.Tiff, *.Jpeg, *.Bmp)|*.Jpg; *.Png; *.Gif; *.Tiff; *.Jpeg; *.Bmp";
            //openFileDialog1.Filter = "JPG(*.jpg)|*.jpg ";
            openFileDialog1.FilterIndex = 4;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((MiStream = openFileDialog1.OpenFile()) != null)
                    {
                        using (MiStream)
                        {
                            //string NombreArchivo;
                            //string RutaArchivo;
                            //RutaArchivo = openFileDialog1.FileName.ToString();
                            //NombreArchivo = Path.GetFileName(RutaArchivo);

                            pb_foto.Image = System.Drawing.Bitmap.FromStream(MiStream);
                            System.IO.FileInfo imgInfo1 = new System.IO.FileInfo(openFileDialog1.FileName);
                            if (imgInfo1.Length > 9990000)
                            {
                                MessageBox.Show("El tamaño de la imagen es: " + (Convert.ToDouble(imgInfo1.Length / 1000000)) + "Mb  debe tener un tamaño menor a 1 Mega, Por Favor Redusca el tamaño de la imagen");
                                this.Close();
                            }
                            sw = true;


                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: No se puede carga la imagen " + ex.Message);
                }
            }
        }
    }
}
