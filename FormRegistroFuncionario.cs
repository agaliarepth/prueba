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
    public partial class FormRegistroFuncionario : Form
    {

        private string nombre;
             private string telfono ;
             private double sueldo;
             private string dir;
             private string user;
             private string pass;
        private int id_empleado;
        private Stream MiStream = null;
        private Byte[] foto;
        private Image dibujo;
        private bool sw;
        private bool actualizar = false;
        private gasolineraDBDataSetTableAdapters.empleadosTableAdapter em=new gasolineraDBDataSetTableAdapters.empleadosTableAdapter();
        private gasolineraDBDataSet.empleadosDataTable em_dt;
        private OpenFileDialog openFileDialog1 = new OpenFileDialog(); private gasolineraDBDataSet.empleadosDataTable emp_dt;
        public FormRegistroFuncionario()
        {
            InitializeComponent();
        }
        public FormRegistroFuncionario(int cod)
        {
            this.id_empleado = cod;
            InitializeComponent();
            em_dt = em.GetById(this.id_empleado);
            rellenarFormulario();
            actualizar = true;

        }
        private void rellenarFormulario() {
            tb_id.Text = em_dt[0]["id_empleado"].ToString();
            tb_nombre.Text = em_dt[0]["nombre_empleado"].ToString();
            tb_telf.Text = em_dt[0]["telefono_empleado"].ToString();
            tb_sueldo.Text = em_dt[0]["sueldo_empleado"].ToString();
            tb_dir.Text = em_dt[0]["direccion_empleado"].ToString();
            if (em_dt.Rows[0]["foto"].GetType().ToString() == "System.Byte[]")
            {
                Byte[] imagenByteData = (Byte[])em_dt.Rows[0]["foto"];

                MemoryStream memStream = new MemoryStream(imagenByteData);
                pb_foto.Image = new Bitmap(memStream);
                memStream.Close();

            }
            tb_username.Text = em_dt[0]["username_empledo"].ToString();
            tb_pass.Text = em_dt[0]["password_empleado"].ToString();

        
        }
        private void AsignarCampos() {
        
            nombre = tb_nombre.Text.ToUpper();
             telfono = tb_telf.Text;
            sueldo = Convert.ToDouble(tb_sueldo.Text);
             dir = tb_dir.Text;
             user = tb_username.Text;
             pass = tb_pass.Text;
            guardarFoto();
        }

        private void guardar() {
            AsignarCampos();
            try
            {
                em.Insert(nombre, telfono, sueldo, dir, this.foto, user, pass,DateTime.Now.ToShortDateString(),tb_tipo.Text);
                MessageBox.Show("Los Datos Fueron Registrados Correctamente");
                this.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("No se pudo guardar la informacion" + ex.Message, "Guardar Datos", MessageBoxButtons.OK);

            }
        
        
        
        }

        private void button3_Click(object sender, EventArgs e)
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

        private void button5_Click(object sender, EventArgs e)
        {
            if (actualizar == false && validarCampos(tb_sueldo) && validarCampos(tb_nombre) && validarCampos(tb_username)&& validarCampos(tb_pass)&& validarCampos(tb_tipo) )
            {


                guardar();


            }
            else if (actualizar == true && validarCampos(tb_sueldo) && validarCampos(tb_nombre) && validarCampos(tb_username) && validarCampos(tb_pass))
                actualizarDatos();

        }

        private void actualizarDatos(){
            AsignarCampos();
            emp_dt = em.GetData();
            DataRow fila = emp_dt.Rows.Find(id_empleado);


            fila.BeginEdit();

            fila["nombre_empleado"] = this.nombre;
            fila["telefono_empleado"] = this.telfono;
            fila["sueldo_empleado"] = this.sueldo;
            fila["direccion_empleado"] = this.dir;
            guardarFoto();
            fila["foto"] = this.foto;
            fila["username_empledo"] =this.user;
            fila["password_empleado"] = this.pass;
            
            fila.EndEdit();

            try
            {

                em.Update(fila);
               emp_dt.AcceptChanges();

                MessageBox.Show("Los datos han sido Actualizados correctamente");

                this.Close();


            }
            catch (SqlException ex)
            {
                MessageBox.Show("no se pudo Actualizar los Datos" + ex.Message, "Actualizar Datos", MessageBoxButtons.OK);



            }
        }
        private void  guardarFoto() {

            
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

                dibujo = new Bitmap(pb_foto.Image);

                //Creamos un stream en memoria para guardar la imagen
                MemoryStream memStream = new MemoryStream();
                memStream.SetLength(79000);

                //Guardamos la imagen en nuestro stream especificando el formato (jpg,bmp...) 
                dibujo.Save(memStream, System.Drawing.Imaging.ImageFormat.Jpeg);
                //Guardamos el stream en un array de bytes



                foto = memStream.GetBuffer();
                memStream.Close();
            }
          
        
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

        private void tb_id_Validating(object sender, CancelEventArgs e)
        {


            if (tb_id.Text == "" || tb_id.Text.Length < 3)
            {
                errorProvider1.SetError(tb_id, "Introdusca Un Codigo Valido");
                tb_id.BackColor = Color.AntiqueWhite;
                tb_id.Focus();

                button5.Enabled = false;
            }
            else
            {
                errorProvider1.Clear();
                tb_id.BackColor = Color.White;
                button5.Enabled = true;
            }

        }

        private void tb_nombre_Validating(object sender, CancelEventArgs e)
        {
            if (tb_nombre.Text == "" || tb_nombre.Text.Length < 3)
            {
                errorProvider1.SetError(tb_nombre, "Introdusca Nombre");
                tb_nombre.BackColor = Color.AntiqueWhite;
                tb_nombre.Focus();
                button5.Enabled = false;
            }
            else
            {
                errorProvider1.Clear();
                tb_nombre.BackColor = Color.White;
                button5.Enabled = true;
            }
        }

        private void tb_username_Validating(object sender, CancelEventArgs e)
        {
            if (tb_username.Text == "" || tb_username.Text.Length < 3)
            {
                errorProvider1.SetError(tb_username, "Introdusca un username valido");
                tb_username.BackColor = Color.AntiqueWhite;
                tb_username.Focus();
                button5.Enabled = false;
            }
            else
            {
                errorProvider1.Clear();
                tb_username.BackColor = Color.White;
                button5.Enabled = true;
            }
            
        }

        private void tb_pass_Validating(object sender, CancelEventArgs e)
        {
            if (tb_pass.Text == "" || tb_pass.Text.Length < 3)
            {
                errorProvider1.SetError(tb_pass, "Introdusca una Contraseña");
                tb_pass.BackColor = Color.AntiqueWhite;
                tb_pass.Focus();
                button5.Enabled = false;
            }
            else
            {
                errorProvider1.Clear();
                tb_pass.BackColor = Color.White;
                button5.Enabled = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
