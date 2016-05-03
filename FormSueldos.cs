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
    public partial class FormSueldos : Form
    {

       
        private gasolineraDBDataSetTableAdapters.pagos_sueldosTableAdapter ps = new gasolineraDBDataSetTableAdapters.pagos_sueldosTableAdapter();
        private gasolineraDBDataSetTableAdapters.pagos_empleadosTableAdapter pe = new gasolineraDBDataSetTableAdapters.pagos_empleadosTableAdapter();
        gasolineraDBDataSetTableAdapters.Vista_PagosSueldosTableAdapter pagos = new gasolineraDBDataSetTableAdapters.Vista_PagosSueldosTableAdapter();
        public FormSueldos()
        {
            InitializeComponent();
        

        }

        private void FormSueldos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'gasolineraDBDataSet1.empleados' Puede moverla o quitarla según sea necesario.
            this.empleadosTableAdapter.Fill(this.gasolineraDBDataSet1.empleados);
           
            tb_total.Text = "0";
            // TODO: esta línea de código carga datos en la tabla 'gasolineraDBDataSet.pagos_sueldos' Puede moverla o quitarla según sea necesario.
            this.pagos_sueldosTableAdapter.Fill(this.gasolineraDBDataSet.pagos_sueldos);
            // TODO: esta línea de código carga datos en la tabla 'gasolineraDBDataSet.pagos_empleados' Puede moverla o quitarla según sea necesario.
           
            this.empleadosTableAdapter.Fill(this.gasolineraDBDataSet.empleados);

        }
        private bool validarGrilla() {
            bool res = true;
            int c = 0;
            foreach (DataGridViewRow r in dataGridView2.Rows)
            {

                DataGridViewCheckBoxCell cellSelecion = r.Cells["seleccion"] as DataGridViewCheckBoxCell;


                if (Convert.ToBoolean(cellSelecion.Value))
                {

                    c++;

                }
                


            }
            if (c <= 0)
            {
                res = false;
                MessageBox.Show("Debe seleccionar al menos un Empleado");
                
            }

            
            return res;

        
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (validarCampos(textBox2) && validarCampos(textBox3) && validarCampos(textBox4) && validarCampos(textBox5) && validarCampos(textBox6) && validarCampos(textBox8))
                guardar();
           
        }
        private bool validarCampos(Control c)
        {
            bool sw = false;
            if (c.Text == "")
            {
                errorProvider.SetError(c, "Por Favor Introdusca valor");

                c.Focus();
                c.BackColor = Color.AntiqueWhite;


                return sw;

            }


            else
            {
                sw = true;
                return sw;

            }

        }
        private void guardar()
        {
            decimal x1 = Convert.ToDecimal(textBox2.Text);
            decimal x2 = Convert.ToDecimal(textBox3.Text);
            decimal x3 = Convert.ToDecimal(textBox4.Text);
            decimal x4 = Convert.ToDecimal(textBox5.Text);
            decimal x5 = Convert.ToDecimal(textBox6.Text);
            decimal x6 = Convert.ToDecimal(textBox8.Text);
            decimal t = Convert.ToDecimal(tb_total.Text);
          
            try
            {


                ps.Insert(t, DateTime.Now.ToShortDateString(), "mensual", Convert.ToInt32(dataGridView2.CurrentRow.Cells["idempleadoDataGridViewTextBoxColumn"].Value), dateTimePicker1.Value.Month.ToString(), dateTimePicker1.Value.Year.ToString(), lb_nombre.Text, Convert.ToDecimal(lb_sueldo.Text), x1, x2, x3, x4, x5, x6, label28.Text);
               

                    DialogResult res = MessageBox.Show("Los Datos se guardaron corectamente , Desea Imprimir un Recibo?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information);


                    if (res == DialogResult.Yes)
                    {
                        int cod=Convert.ToInt32(ps.getMax());
                        ReportPagoSueldoForm sueldo = new ReportPagoSueldoForm(cod,label12.Text);
                        sueldo.ShowDialog();
                        this.Close();



                    }
                    else
                        this.Close();
                }

            
            catch (Exception e)
            {
                MessageBox.Show("no se pudo realizar la operacion" + e);
            }



        }
       

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();

           
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

 
        }

        private void dataGridView2_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            
        }

        private void cb_tipo_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void cb_tipo_SelectedValueChanged(object sender, EventArgs e)
        {
         
        }

        private void cb_tipo_SelectionChangeCommitted(object sender, EventArgs e)
        {
          
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void dataGridView2_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lb_ingreso.Text=dataGridView2.CurrentRow.Cells["fecha_ingreso"].Value.ToString();
            lb_nombre.Text = dataGridView2.CurrentRow.Cells["nombre"].Value.ToString();
            lb_sueldo.Text = dataGridView2.CurrentRow.Cells["sueldoempleadoDataGridViewTextBoxColumn"].Value.ToString();
            label12.Text = dataGridView2.CurrentRow.Cells["tipo_empeado"].Value.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            calcular();
        }

        private void textBox2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBox2.Enabled = true;
        }

        private void textBox3_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBox3.Enabled = true;
        }

        private void textBox4_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBox4.Enabled = true;
        }

        private void textBox5_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBox5.Enabled = true;
        }

        private void textBox6_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBox6.Enabled = true;
        }

        private void textBox8_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBox8.Enabled = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            calcular();
        }
        private void calcular() {
            decimal t1 = Convert.ToDecimal(lb_sueldo.Text) + Convert.ToDecimal(textBox2.Text) + Convert.ToDecimal(textBox3.Text) + Convert.ToDecimal(textBox4.Text);
            decimal t2 = Convert.ToDecimal(textBox5.Text) + Convert.ToDecimal(textBox6.Text) + Convert.ToDecimal(textBox8.Text);
            decimal total = t1 - t2;
            lb_tde.Text = t2.ToString();
            lb_tper.Text = t1.ToString();
            tb_total.Text = total.ToString();
            ClassNumeroLetra num = new ClassNumeroLetra();
            label28.Text = num.Convertir(tb_total.Text, false);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked) {
                textBox2.Enabled = true;
                textBox3.Enabled = true;
                textBox4.Enabled = true;
                textBox5.Enabled = true;
                textBox6.Enabled = true;
                textBox8.Enabled = true;
                
            
            
            }
            else if (!checkBox1.Checked) {

                textBox2.Enabled = false;
                textBox3.Enabled = false;
                textBox4.Enabled = true;
                textBox5.Enabled = false;
                textBox6.Enabled = false;
                textBox8.Enabled = false;
                
            
            
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            calcular();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            calcular();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            calcular();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            calcular();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            calcular();
        }

        private void Bs(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int cod=Convert.ToInt32(dataGridView1.CurrentRow.Cells["idpagosDataGridViewTextBoxColumn"].Value);
                        
            ReportPagoSueldoForm sueldo = new ReportPagoSueldoForm(cod,label12.Text);
            sueldo.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Esta seguro de Eliminar este Pago de los Registros", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                try
                {
                    ps.DeleteQuery(Convert.ToInt32(dataGridView1.CurrentRow.Cells["idpagosDataGridViewTextBoxColumn"].Value));
                    dataGridView1.DataSource = ps.GetData();

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
       

    }
}
