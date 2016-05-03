using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace gasolinera
{
    public partial class FormAsignarHorarios : Form
    {
        private int id;
        private gasolineraDBDataSetTableAdapters.empleadosTableAdapter em = new gasolineraDBDataSetTableAdapters.empleadosTableAdapter();
        private gasolineraDBDataSet.empleadosDataTable em_dt;
        private gasolineraDBDataSet.turnos_empleadosDataTable dt;
        private gasolineraDBDataSetTableAdapters.turnos_empleadosTableAdapter turno_da = new gasolineraDBDataSetTableAdapters.turnos_empleadosTableAdapter();
        public FormAsignarHorarios()
        {
            InitializeComponent();
        }
        public FormAsignarHorarios(int cod)
        {
            this.id = cod;
            InitializeComponent();
            em_dt = em.GetById(this.id);
            if (em_dt.Rows[0]["foto"].GetType().ToString() == "System.Byte[]")
            {
                Byte[] imagenByteData = (Byte[])em_dt.Rows[0]["foto"];

                MemoryStream memStream = new MemoryStream(imagenByteData);
                pb_foto.Image = new Bitmap(memStream);
                memStream.Close();

                vistaturnosEmpleadosBindingSource.DataSource=vista_turnosEmpleadosTableAdapter.GetByID(this.id);
            }
            label1.Text = em_dt[0]["nombre_empleado"].ToString();

        }

        private void FormAsignarHorarios_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'gasolineraDBDataSet.turnos' Puede moverla o quitarla según sea necesario.
            this.turnosTableAdapter.Fill(this.gasolineraDBDataSet.turnos);

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            dataGridView2.Rows.Add(dataGridView1.CurrentRow.Cells["idturnoDataGridViewTextBoxColumn"].Value.ToString(),
                dataGridView1.CurrentRow.Cells["horainicioDataGridViewTextBoxColumn"].Value.ToString(),
                dataGridView1.CurrentRow.Cells["horafinDataGridViewTextBoxColumn"].Value.ToString(),
                dataGridView1.CurrentRow.Cells["descripcionDataGridViewTextBoxColumn"].Value.ToString(),
                dataGridView1.CurrentRow.Cells["diassemanaDataGridViewTextBoxColumn"].Value.ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Add(dataGridView1.CurrentRow.Cells["idturnoDataGridViewTextBoxColumn"].Value.ToString(),
                           dataGridView1.CurrentRow.Cells["horainicioDataGridViewTextBoxColumn"].Value.ToString(),
                           dataGridView1.CurrentRow.Cells["horafinDataGridViewTextBoxColumn"].Value.ToString(),
                           dataGridView1.CurrentRow.Cells["descripcionDataGridViewTextBoxColumn"].Value.ToString(),
                           dataGridView1.CurrentRow.Cells["diassemanaDataGridViewTextBoxColumn"].Value.ToString());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (dataGridView2.RowCount > 0)
            {
                dataGridView2.Rows.Remove(dataGridView2.CurrentRow);
               
            }
        }

        private void guardar_btn_Click(object sender, EventArgs e)
        {
            int v=0;
            int n;
            dt = new gasolineraDBDataSet.turnos_empleadosDataTable();
            DataRow aux = dt.NewRow();

            foreach (DataGridViewRow row in dataGridView2.Rows)
            {

                n = Convert.ToInt32(row.Cells["id_turno"].Value);
                if (v == n)
                {
                    MessageBox.Show("este turno ya esta designado");
                }
                else
                   
                v = n;
                turno_da.Insert(Convert.ToInt32(n), this.id);
            }

            vistaturnosEmpleadosBindingSource.DataSource = vista_turnosEmpleadosTableAdapter.GetByID(this.id);
            tabControl1.SelectTab(1);
            dataGridView2.Rows.Clear();
            
          
            
            
        }

        private void cancelar_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_quitar_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Esta seguro de Quitar este turno a este Empleado ..?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                try
                {
                    turno_da.DeleteQuery(Convert.ToInt32(dataGridView3.CurrentRow.Cells["dataGridViewTextBoxColumn1"].Value), this.id);
                    vistaturnosEmpleadosBindingSource.DataSource = vista_turnosEmpleadosTableAdapter.GetByID(this.id);
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
    }
}
