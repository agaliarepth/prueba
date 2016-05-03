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
    public partial class FormListDistribuidores : Form
    {

      public int id_dist;
        public  string nom;
        public FormListDistribuidores()
        {
            InitializeComponent();
        }

        private void FormListDistribuidores_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'gasolineraDBDataSet.distribuidores' Puede moverla o quitarla según sea necesario.
            this.distribuidoresTableAdapter.Fill(this.gasolineraDBDataSet.distribuidores);

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                id_dist = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                nom = dataGridView1.CurrentRow.Cells[1].Value.ToString() + " " + dataGridView1.CurrentRow.Cells[2].Value.ToString();
            }
            catch
            {
                MessageBox.Show("Registro vacio");
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
