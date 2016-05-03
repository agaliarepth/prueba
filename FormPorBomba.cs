using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using gasolinera;

namespace gasolinera
{
   
    public partial class FormPorBomba : Form
    {
        public int id_bomba;
        public string tipo="id";
        public string f1;
        public string f2;
        public FormPorBomba()
        {
            InitializeComponent();
        }

        private void FormPorBomba_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'gasolineraDBDataSet.bombas' Puede moverla o quitarla según sea necesario.
            this.bombasTableAdapter.Fill(this.gasolineraDBDataSet.bombas);

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            this.id_bomba = Convert.ToInt32(dataGridView1.CurrentRow.Cells["idbombaDataGridViewTextBoxColumn"].Value);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.id_bomba = Convert.ToInt32(dataGridView1.CurrentRow.Cells["idbombaDataGridViewTextBoxColumn"].Value);
            this.f1 = dt_f1.Text.ToString();
            this.f2 = dt_f2.Text.ToString();
            this.tipo = "fecha";
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked) {
                panel3.Enabled = true;
            
            }
            else if (!checkBox1.Checked)
            {
                panel3.Enabled = false;

            }
        }
    }
}
