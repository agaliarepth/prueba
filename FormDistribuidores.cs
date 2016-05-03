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
    public partial class FormDistribuidores : Form
    {
        public FormDistribuidores()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormRegistroDistribuidores distr = new FormRegistroDistribuidores();
            distr.ShowDialog();
            distribuidoresBindingSource.DataSource = distribuidoresTableAdapter.GetData();
        }

        private void FormDistribuidores_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'gasolineraDBDataSet.distribuidores' Puede moverla o quitarla según sea necesario.
            this.distribuidoresTableAdapter.Fill(this.gasolineraDBDataSet.distribuidores);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormRegistroDistribuidores distr = new FormRegistroDistribuidores( Convert.ToInt32(dataGridView1.CurrentRow.Cells["iddistribuidorDataGridViewTextBoxColumn"].Value));
            distr.ShowDialog();
            distribuidoresBindingSource.DataSource = distribuidoresTableAdapter.GetData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Esta seguro de Eliminar este Distribuidor de los Registros", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                try
                {
                    distribuidoresTableAdapter.DeleteQuery(Convert.ToInt32(dataGridView1.CurrentRow.Cells["iddistribuidorDataGridViewTextBoxColumn"].Value));
                    distribuidoresBindingSource.DataSource = distribuidoresTableAdapter.GetData();
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
            FormRegistroDistribuidores distr = new FormRegistroDistribuidores(Convert.ToInt32(dataGridView1.CurrentRow.Cells["iddistribuidorDataGridViewTextBoxColumn"].Value));
            distr.ShowDialog();
            distribuidoresBindingSource.DataSource = distribuidoresTableAdapter.GetData();
        }
    }
}
