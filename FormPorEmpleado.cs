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
    public partial class FormPorEmpleado : Form
    {
        public int id;
        public string tipo = "id";
        public string f1;
        public string f2;
        public FormPorEmpleado()
        {
            InitializeComponent();
        }

        private void FormPorEmpleado_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'gasolineraDBDataSet.empleados' Puede moverla o quitarla según sea necesario.
            this.empleadosTableAdapter.Fill(this.gasolineraDBDataSet.empleados);

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

        private void button1_Click(object sender, EventArgs e)
        {
            this.id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["idempleadoDataGridViewTextBoxColumn"].Value);
            this.f1 = dt_f1.Text.ToString();
            this.f2 = dt_f2.Text.ToString();
            this.tipo = "fecha";
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["idempleadoDataGridViewTextBoxColumn"].Value);
            this.tipo = "id";
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
