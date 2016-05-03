using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace gasolinera
{
    public partial class FormFuncionario : Form
    {
        public FormFuncionario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormRegistroFuncionario f = new FormRegistroFuncionario();
            f.ShowDialog();
            empleadosBindingSource.DataSource = empleadosTableAdapter.GetData();
        }

        private void FormFuncionario_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'gasolineraDBDataSet.empleados' Puede moverla o quitarla según sea necesario.
            this.empleadosTableAdapter.Fill(this.gasolineraDBDataSet.empleados);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormRegistroFuncionario f = new FormRegistroFuncionario(Convert.ToInt32(dataGridView1.CurrentRow.Cells["idempleadoDataGridViewTextBoxColumn"].Value));
            f.ShowDialog();
            empleadosBindingSource.DataSource = empleadosTableAdapter.GetData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Esta seguro de Eliminar este Empleado de los Registros", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                try
                {
                    empleadosTableAdapter.DeleteQuery(Convert.ToInt32(dataGridView1.CurrentRow.Cells["idempleadoDataGridViewTextBoxColumn"].Value));
                    empleadosBindingSource.DataSource = empleadosTableAdapter.GetData();
                }
                catch (SqlException)
                {
                    MessageBox.Show("no se pudo Eliminar este Registro", "Eliminar", MessageBoxButtons.OK);

                }
                catch (NullReferenceException)
                {

                    MessageBox.Show("No hay Registros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            FormRegistroFuncionario f = new FormRegistroFuncionario(Convert.ToInt32(dataGridView1.CurrentRow.Cells["idempleadoDataGridViewTextBoxColumn"].Value));
            f.ShowDialog();
            empleadosBindingSource.DataSource = empleadosTableAdapter.GetData();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FormAsignarHorarios h = new FormAsignarHorarios(Convert.ToInt32(dataGridView1.CurrentRow.Cells["idempleadoDataGridViewTextBoxColumn"].Value));
            h.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
