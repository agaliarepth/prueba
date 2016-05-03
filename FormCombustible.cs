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
     
   
    public partial class FormCombustible : Form
    {
        public FormCombustible()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormRegistroCombustible combu = new FormRegistroCombustible();

            combu.ShowDialog();
            dataGridView1.DataSource = productosTableAdapter.GetData();
        }

        private void FormCombustible_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'gasolineraDBDataSet.productos' Puede moverla o quitarla según sea necesario.
            this.productosTableAdapter.Fill(this.gasolineraDBDataSet.productos);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Esta seguro de Eliminar esta Bomba  de los Registros", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                try
                {
                    productosTableAdapter.DeleteQueryId(Convert.ToInt32(dataGridView1.CurrentRow.Cells["idproductoDataGridViewTextBoxColumn"].Value));
                    dataGridView1.DataSource = productosTableAdapter.GetData();

                }
                catch (SqlException )
                {
                    MessageBox.Show("No se pudo Eliminar este Registro Debido a que esta Relacionado con con un Tanque " , "Eliminar", MessageBoxButtons.OK);

                }
                catch (NullReferenceException)
                {

                    MessageBox.Show("No hay Registros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["idproductoDataGridViewTextBoxColumn"].Value);
            string obs = dataGridView1.CurrentRow.Cells["observacionproductoDataGridViewTextBoxColumn"].Value.ToString();
            decimal pre = Convert.ToDecimal(dataGridView1.CurrentRow.Cells["precioproductoDataGridViewTextBoxColumn"].Value);
            string unid = dataGridView1.CurrentRow.Cells["unidadproductoDataGridViewTextBoxColumn"].Value.ToString();
            string mon = dataGridView1.CurrentRow.Cells["monedaproductoDataGridViewTextBoxColumn"].Value.ToString();
            string des = dataGridView1.CurrentRow.Cells["descripcionproductoDataGridViewTextBoxColumn"].Value.ToString();
           FormRegistroCombustible combu = new FormRegistroCombustible(id,obs,pre,unid,des,mon);
            combu.ShowDialog();

            dataGridView1.DataSource = productosTableAdapter.GetData();

        }
    }
}
