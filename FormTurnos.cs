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
    public partial class FormTurnos : Form
    {
        public FormTurnos()
        {
            InitializeComponent();
        }

        private void FormTurnos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'gasolineraDBDataSet.turnos' Puede moverla o quitarla según sea necesario.
            this.turnosTableAdapter.Fill(this.gasolineraDBDataSet.turnos);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormRegistroTurnos t=new FormRegistroTurnos();
            t.ShowDialog();
            turnosBindingSource.DataSource = turnosTableAdapter.GetData();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormRegistroTurnos t = new FormRegistroTurnos(Convert.ToInt32(dataGridView1.CurrentRow.Cells["idturnoDataGridViewTextBoxColumn"].Value));
            t.ShowDialog();
            turnosBindingSource.DataSource = turnosTableAdapter.GetData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Esta seguro de Eliminar este Turno  de los Registros", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                try
                {
                    turnosTableAdapter.DeleteQuery(Convert.ToInt32(dataGridView1.CurrentRow.Cells["idturnoDataGridViewTextBoxColumn"].Value));
                    turnosBindingSource.DataSource = turnosTableAdapter.GetData();
                   
                }
                catch 
                {
                    MessageBox.Show("no se pudo Eliminar este Registro", "Eliminar", MessageBoxButtons.OK);

                }
                
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
