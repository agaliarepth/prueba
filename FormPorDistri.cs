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
    public partial class FormPorDistri : Form
    {
        public int id;
        public string nombre;
        public FormPorDistri()
        {
            InitializeComponent();
        }

        private void FormPorDistri_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'gasolineraDBDataSet.distribuidores' Puede moverla o quitarla según sea necesario.
            this.distribuidoresTableAdapter.Fill(this.gasolineraDBDataSet.distribuidores);

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            this.id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["iddistribuidorDataGridViewTextBoxColumn"].Value);
            this.nombre = dataGridView1.CurrentRow.Cells["nombredistriDataGridViewTextBoxColumn"].Value.ToString() + " " + dataGridView1.CurrentRow.Cells["apellidodistriDataGridViewTextBoxColumn"].Value.ToString();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
