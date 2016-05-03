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
    
    public partial class FormRestaurarDataBase : Form
    {
          private Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
        public FormRestaurarDataBase()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtBackup.Text = openFileDialog1.FileName.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.btnRestore.Enabled = false;
            this.btnRestore.Text = "Restaurando...";
            this.btnRestore.Refresh();

            string sBackup = "RESTORE DATABASE gasolineraDB " + 
                             " FROM DISK = '" + this.txtBackup.Text + "'" +
                             " WITH REPLACE";
            SqlConnectionStringBuilder csb = new SqlConnectionStringBuilder();
            csb.DataSource = ".\\SQLEXPRESS";
            // Es mejor abrir la conexión con la base Master
            csb.InitialCatalog = "master";
            csb.IntegratedSecurity = true;

            SqlConnection con = new SqlConnection(csb.ConnectionString);
            //SqlConnection con = new SqlConnection(config.ConnectionStrings.ConnectionStrings[1].ConnectionString.ToString());
            con.Close();
            {
                try
                {
                    con.Open();

                    SqlCommand cmdBackUp = new SqlCommand(sBackup, con);
                    cmdBackUp.ExecuteNonQuery();
                    MessageBox.Show("Se ha restaurado la copia de la base de datos.", 
                                    "Restaurar base de datos", 
                                    MessageBoxButtons.OK, 
                                    MessageBoxIcon.Information);

                    con.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, 
                                    "Error al restaurar la base de datos", 
                                    MessageBoxButtons.OK, 
                                    MessageBoxIcon.Error);
                }
            }

            this.btnRestore.Text = "Restaurar copia";
            this.btnRestore.Enabled = true;
            this.btnRestore.Refresh();
        }
        }
    }

