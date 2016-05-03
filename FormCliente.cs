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
    public partial class FormCliente : Form
    {
        public FormCliente()
        {
            InitializeComponent();
        }

        private void FormCliente_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'gasolineraDBDataSet.clientes' Puede moverla o quitarla según sea necesario.
            this.clientesTableAdapter.Fill(this.gasolineraDBDataSet.clientes);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormRegistroCliente cliente = new FormRegistroCliente();
            cliente.ShowDialog();
            clientesBindingSource.DataSource = clientesTableAdapter.GetData();
        }

        private void salir_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            eliminarRegistro();
        }
        private void eliminarRegistro()
        {
            DialogResult res = MessageBox.Show("Esta seguro de Eliminar este Cliente de los Registros", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                try
                {
                    clientesTableAdapter.DeleteQuery(Convert.ToInt32(dataGridView1.CurrentRow.Cells["Column1"].Value));
                    clientesBindingSource.DataSource = clientesTableAdapter.GetData();
                   
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("no se pudo Eliminar este Registro" + ex, "Eliminar", MessageBoxButtons.OK);

                }
                catch (NullReferenceException)
                {

                    MessageBox.Show("No hay Registros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            actulizarREgistro();
        }
        private void actulizarREgistro()
        {
            try
            {
                int cod = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Column1"].Value);
               FormRegistroCliente cliente = new FormRegistroCliente(cod);
                cliente.ShowDialog();
                clientesBindingSource.DataSource = clientesTableAdapter.GetData();

            }
            catch (NullReferenceException)
            {

                MessageBox.Show("No hay Registros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

    }
}
