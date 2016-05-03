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
    public partial class FormPorTanque : Form
    {
        public int id_tanque;
        public string tipo="id";
        public string f1;
        public string f2;
        public FormPorTanque()
        {
            InitializeComponent();
        }

        private void FormPorTanque_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'gasolineraDBDataSet.turnos' Puede moverla o quitarla según sea necesario.
            this.turnosTableAdapter.Fill(this.gasolineraDBDataSet.turnos);
          

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                panel3.Enabled = true;

            }
            else if (!checkBox1.Checked)
            {
                panel3.Enabled = false;

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.id_tanque = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Column1"].Value);
            this.f1 = dt_f1.Text.ToString();
            this.f2 = dt_f2.Text.ToString();
            this.tipo = "fecha";
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.id_tanque = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Column1"].Value);
            this.tipo = "id";
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
