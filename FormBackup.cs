using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace gasolinera
{
    public partial class FormBackup : Form
    {
        private Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
        public FormBackup()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = saveFileDialog1.FileName.ToString();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.button1.Enabled = false;
            this.button1.Text = "Copiando...";
            this.button1.Refresh();
            string sBackup = "BACKUP DATABASE  [gasolineraDB]" +
                 " TO DISK = N'" + this.textBox1.Text +
                 "' WITH NOFORMAT, NOINIT, NAME =N'" + this.textBox1.Text +
                 "',SKIP, STATS = 10";
            if (textBox1.Text != "")
            {
                SqlConnection con = new SqlConnection(config.ConnectionStrings.ConnectionStrings[1].ConnectionString.ToString());
                try
                {

                    con.Open();
                    SqlCommand cmdBackUp = new SqlCommand(sBackup, con);

                    cmdBackUp.ExecuteNonQuery();
                    MessageBox.Show("Se ha creado un BackUp de La base de datos satisfactoriamente",
        "Copia de seguridad de base de datos",
        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    con.Close();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString() + "\n" + "Intente Guardar en una Unidad distinta al disco C:");

                }
               
            }
            else
                
            MessageBox.Show("Debe elegir un archivo");
            this.button1.Text ="Guardar";
            this.button1.Enabled = true;
            this.button1.Refresh();
        }
    }
}
