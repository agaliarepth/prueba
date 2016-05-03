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
    public partial class FormBombas : Form
    {
        private int id_bomba;
        private int num_mangueras;
        private string tipo_combustible;
        private int id_tanque;
   
       private gasolineraDBDataSet.bombasDataTable b=new gasolineraDBDataSet.bombasDataTable();
        public FormBombas()
        {
            InitializeComponent();
            
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FormBombas_Load(object sender, EventArgs e)
        {
          
            // TODO: esta línea de código carga datos en la tabla 'gasolineraDBDataSet.bombas' Puede moverla o quitarla según sea necesario.
            this.bombasTableAdapter.Fill(this.gasolineraDBDataSet.bombas);
            b = bombasTableAdapter.GetData();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormRegistroBomba bomba = new FormRegistroBomba();
            bomba.ShowDialog();
            dataGridView1.DataSource = bombasTableAdapter.GetData();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.id_bomba = Convert.ToInt32(dataGridView1.CurrentRow.Cells["idbombaDataGridViewTextBoxColumn"].Value);
            FormRegistroBomba bomba = new FormRegistroBomba(id_bomba,num_mangueras,tipo_combustible,id_tanque,0);
            bomba.ShowDialog();

            dataGridView1.DataSource = bombasTableAdapter.GetData();
        }

        
        private void dataGridView1_MouseClick_1(object sender, MouseEventArgs e)
        {
            this.id_bomba = Convert.ToInt32(dataGridView1.CurrentRow.Cells["idbombaDataGridViewTextBoxColumn"].Value);

            this.id_tanque = Convert.ToInt32(dataGridView1.CurrentRow.Cells["idtanqueDataGridViewTextBoxColumn"].Value);
            this.num_mangueras = Convert.ToInt32(dataGridView1.CurrentRow.Cells["nummanguerasDataGridViewTextBoxColumn"].Value);
            //this.en_uso = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Uso"].Value);
            this.tipo_combustible = dataGridView1.CurrentRow.Cells["tipocombustibleDataGridViewTextBoxColumn"].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
             DialogResult res = MessageBox.Show("Esta seguro de Eliminar esta Bomba  de los Registros", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
             if (res == DialogResult.Yes)
             {
                 try
                 {
                     bombasTableAdapter.DeleteQuery(Convert.ToInt32(dataGridView1.CurrentRow.Cells["idbombaDataGridViewTextBoxColumn"].Value));
                     dataGridView1.DataSource = bombasTableAdapter.GetData();

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

        private void dataRepeater1_CurrentItemIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
