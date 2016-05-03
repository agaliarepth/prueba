using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using gasolinera.Reportes;


namespace gasolinera
{
    public partial class FormTanque : Form
    {
        private decimal p;
        private gasolineraDBDataSetTableAdapters.ajuste_tanqueTableAdapter ajuste = new gasolineraDBDataSetTableAdapters.ajuste_tanqueTableAdapter();
        private decimal nivel_actual;
        public FormTanque()
        {
            InitializeComponent();
            tanquesBindingSource.DataSource=tanquesTableAdapter.GetAll();
            dataGridView1.DataSource = tanquesBindingSource;
            dataGridView1.Columns["num_tanque"].HeaderText = "Tanque #";
            dataGridView1.Columns["num_tanque"].Width = 65;
            dataGridView1.Columns["num_tanque"].DisplayIndex = 0;
            dataGridView1.Columns["id_tanque"].Visible = false;

            dataGridView1.Columns["id_producto"].Visible = false;
            dataGridView1.Columns["descripcion_producto"].HeaderText = "Combustible";
            dataGridView1.Columns["descripcion_producto"].Width = 250;
            dataGridView1.Columns["stock_critico"].HeaderText = "Nivel Peligroso";
            dataGridView1.Columns["stock"].HeaderText = "Nivel Actual";
         
                
                
            
        }
        private void  verificarStockCritico(){
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (Convert.ToDecimal(row.Cells["stock"].Value) <= Convert.ToDecimal(row.Cells["stock_critico"].Value)) {

                    row.DefaultCellStyle.BackColor =System.Drawing.Color.Salmon;

                 
                }
            }
        
        
        }
        private decimal nivelTanque(){

            decimal s = Convert.ToDecimal(dataGridView1.CurrentRow.Cells["stock"].Value);
            decimal c = Convert.ToDecimal(dataGridView1.CurrentRow.Cells["capacidad"].Value);
            
            decimal n = (s / c) * 100;
            return n;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            FormRegistroTanque tanq = new FormRegistroTanque();
            tanq.ShowDialog();
            //tanquesTableAdapter.Fill(gasolineraDBDataSet.tanques);
            tanquesBindingSource.DataSource = tanquesTableAdapter.GetAll();
            verificarStockCritico();
        }
       
        private void actulizarREgistro()
        {
            try
            {
                int cod = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                FormRegistroTanque t = new FormRegistroTanque(cod);
                t.ShowDialog();
                tanquesBindingSource.DataSource = tanquesTableAdapter.GetAll();
                
            }
            catch (NullReferenceException)
            {

                MessageBox.Show("No hay Registros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void eliminarRegistro() {
            DialogResult res = MessageBox.Show("Esta seguro de Eliminar este Tanque  de los Registros", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                try
                {
                    tanquesTableAdapter.DeleteQuery(Convert.ToInt32(dataGridView1.CurrentRow.Cells["id_tanque"].Value));
                    tanquesBindingSource.DataSource = tanquesTableAdapter.GetAll();
                    verificarStockCritico();
                }
                catch (SqlException ex )
                {
                    MessageBox.Show("no se pudo Eliminar este Registro"+ ex, "Eliminar", MessageBoxButtons.OK);

                }
                catch (NullReferenceException)
                {

                    MessageBox.Show("No hay Registros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormTanque_Load(object sender, EventArgs e)
        {

            // TODO: esta línea de código carga datos en la tabla 'gasolineraDBDataSet.tanques' Puede moverla o quitarla según sea necesario.
            this.tanquesTableAdapter.Fill(this.gasolineraDBDataSet.tanques);
            verificarStockCritico();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            eliminarRegistro();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            actulizarREgistro();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            verificarStockCritico();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            decimal n = nivelTanque();
            pb_nivel.Value = Convert.ToInt32(Math.Round(n, 0));
            lb_porcentaje.Text = Math.Round(n, 2).ToString()+" %";
            this.p = n;
            lb_unidad.Text =  dataGridView1.CurrentRow.Cells["unidad"].Value.ToString();
            tb_nivel.Value = Convert.ToInt32(Math.Round(nivelTanque(), 0));
            tb_stock.Text = dataGridView1.CurrentRow.Cells["stock"].Value.ToString();
           
        }

        private void tb_nivel_Scroll(object sender, EventArgs e)
        {
           
            decimal c = Convert.ToDecimal(dataGridView1.CurrentRow.Cells["capacidad"].Value);
            lb_porcentaje.Text = (tb_nivel.Value).ToString() + " %";
            pb_nivel.Value = tb_nivel.Value;
            lb_unidad.Text = dataGridView1.CurrentRow.Cells["unidad"].Value.ToString();
            tb_stock.Text = ((tb_nivel.Value * c) / 100).ToString();
        }

        private void cb_ajuste_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_ajuste.Checked) {
                this.nivel_actual = Convert.ToDecimal(dataGridView1.CurrentRow.Cells["stock"].Value);
                dataGridView1.Enabled = false;
                this.tb_stock.Clear();
                this.tb_stock.TextChanged += new System.EventHandler(this.tb_stock_TextChanged);
                tb_stock.ReadOnly = false;
                tb_stock.Focus();
                guardar_btn.Enabled = true;
                cancelar_btn.Enabled = true;
                tb_nivel.Enabled = true;
                tb_nivel.Value = Convert.ToInt32(Math.Round(nivelTanque(), 0));
                
                           
            }
            else if (!cb_ajuste.Checked) {
                this.nivel_actual = 0;
                verificarStockCritico();
                dataGridView1.Enabled = true;
                
                tb_stock.ReadOnly = true;
                guardar_btn.Enabled = false;
                cancelar_btn.Enabled = false;
                tb_nivel.Enabled = false;
               this.tb_stock.TextChanged -= new System.EventHandler(this.tb_stock_TextChanged);       
            }


        }

        private void tb_stock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar) < 48 && e.KeyChar != 8 && e.KeyChar != 44) || e.KeyChar > 57)
            {
               
                e.Handled = true;
            }

            
        }

        private void tb_stock_TextChanged(object sender, EventArgs e)
        {

            if (tb_stock.Text =="")
                tb_stock.Text = "1";
            else
            {

                decimal s = Convert.ToDecimal(tb_stock.Text);
                decimal c = Convert.ToDecimal(dataGridView1.CurrentRow.Cells["capacidad"].Value);
                decimal n = (s / c) * 100;

                pb_nivel.Value = Convert.ToInt32(Math.Round(n, 0));
                lb_porcentaje.Text = n.ToString();
            }


        }

        private void guardar_btn_Click(object sender, EventArgs e)
        {
            gasolineraDBDataSet.tanquesDataTable r = new gasolinera.gasolineraDBDataSet.tanquesDataTable();
            r = tanquesTableAdapter.GetData();
            DataRow fila = r.Rows.Find(Convert.ToInt32(dataGridView1.CurrentRow.Cells["id_tanque"].Value));


            fila.BeginEdit();

            fila["stock"] = Convert.ToDecimal(tb_stock.Text);

            
            fila.EndEdit();
            try
            {

                tanquesTableAdapter.Update(fila);
                r.AcceptChanges();
                tanquesBindingSource.DataSource = tanquesTableAdapter.GetAll();
               


                 }
            catch (SqlException ex)
            {
                MessageBox.Show("no se pudo Actualizar los Datos" + ex.Message, "Actualizar Datos", MessageBoxButtons.OK);



            }
            try { 
                DateTime t=new DateTime();
                string fech = t.ToShortDateString();


                ajuste.Insert(this.nivel_actual, Convert.ToDecimal(tb_stock.Text), fech ,Convert.ToInt32(dataGridView1.CurrentRow.Cells["id_tanque"].Value));


            }
            catch (SqlException ex)
            {
                MessageBox.Show("no se pudo guardar en La Tabla Ajuste" + ex.Message, "Ajuste Tanque", MessageBoxButtons.OK);



            }
             
        }

        private void cancelar_btn_Click(object sender, EventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            VentasReportForm re = new VentasReportForm("bomba");
            re.ShowDialog();
            this.Close();
        }

        

       

        

       

      
    }
}
