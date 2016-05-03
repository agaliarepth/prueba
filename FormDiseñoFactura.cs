using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;

namespace gasolinera
{
    public partial class FormDiseñoFactura : Form
    {
        public FormDiseñoFactura()
        {
            InitializeComponent();
            CargarDatos();
        }

        private void CargarDatos() {
            this.textBox1.Text = (string)(ConfigurationManager.AppSettings["cl1"]);
            this.textBox2.Text = (string)(ConfigurationManager.AppSettings["cl2"]);
            this.textBox3.Text = (string)(ConfigurationManager.AppSettings["cl3"]);
            this.textBox4.Text = (string)(ConfigurationManager.AppSettings["cl4"]);
            this.textBox5.Text = (string)(ConfigurationManager.AppSettings["Pl1"]);
            this.textBox6.Text = (string)(ConfigurationManager.AppSettings["Pl2"]);
            this.textBox7.Text = (string)(ConfigurationManager.AppSettings["Pl3"]);
           
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                config.AppSettings.Settings["cl1"].Value = this.textBox1.Text;
                config.AppSettings.Settings["cl2"].Value = this.textBox2.Text;
                config.AppSettings.Settings["cl3"].Value = this.textBox3.Text;
                config.AppSettings.Settings["cl4"].Value = this.textBox4.Text;
                config.AppSettings.Settings["pl1"].Value = this.textBox5.Text;
                config.AppSettings.Settings["pl2"].Value = this.textBox6.Text;
                config.AppSettings.Settings["pl3"].Value = this.textBox7.Text;
                config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("appSettings");
            }
            catch {

                MessageBox.Show("Hubo un error al guardar los Datos . Intentelo Otra vez");
            
            }

            MessageBox.Show("Datos de la Factura Guardados Correctamente");
            this.Close();
        }
    }
}
