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
    public partial class FormRegistroTurnos : Form
    {
        private int id_turno;
        private gasolineraDBDataSetTableAdapters.turnosTableAdapter t = new gasolineraDBDataSetTableAdapters.turnosTableAdapter();
        private string dias;
        private gasolineraDBDataSet.turnosDataTable turno_Dt;
        private bool actualizar = false;
        public FormRegistroTurnos()
        {
            InitializeComponent();
            dias = "Lunes a Domingo";
        }
        public FormRegistroTurnos(int cod)
        {  this.id_turno=cod;
            InitializeComponent();
            turno_Dt = t.GetById(cod);
            tb_inicio.Text = turno_Dt[0]["hora_inicio"].ToString();
            tb_fin.Text = turno_Dt[0]["hora_fin"].ToString();
            tb_des.Text = turno_Dt[0]["descripcion"].ToString();

         }

        private void guardar_btn_Click(object sender, EventArgs e)
        {
            if (actualizar == false)
                guardar();
            else if (actualizar == true)
                actualizarRegistros();


        }
        private void actualizarCampos() { 
        
        
        
        }
        private bool validarCampos(Control c)
        {
            bool sw = false;
            if (c.Text == "__:__")
            {
                errorProvider.SetError(c, "Por Favor Introdusca valor");

                c.Focus();
                c.BackColor = Color.AntiqueWhite;


                return sw;

            }


            else
            {
                errorProvider.Clear();
                sw = true;
                return sw;

            }
        }

        private void guardar() { 


           
        if(validarCampos(tb_inicio)&& validarCampos(tb_fin)){
            
             
        try
        {
            t.Insert(tb_inicio.Text, tb_fin.Text, tb_des.Text, this.dias);
            this.Close();
        }
        catch {
            MessageBox.Show("no se pudo Guardar los Datos", "Insertar Datos", MessageBoxButtons.OK);
        
        }
        
        }
            
        
        }

        private void actualizarRegistros()
        {
            turno_Dt = t.GetData();
            DataRow fila = turno_Dt.Rows.Find(this.id_turno);


            fila.BeginEdit();



            fila["hora_inicio"] = tb_inicio.Text;
            fila["hora_fin"] = tb_fin.Text;

            fila["descripcion"] =tb_des.Text;
            fila["dias_semana"] = this.dias;
            fila.EndEdit();
            try
            {

                t.Update(fila);
                turno_Dt.AcceptChanges();

                //MessageBox.Show("Los datos han sido Actualizados correctamente");

                this.Close();


            }
            catch
            {
                MessageBox.Show("no se pudo Actualizar los Datos" , "Actualizar Datos", MessageBoxButtons.OK);



            }

        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked){
                this.dias = "";
                textBox1.Enabled=true;
                this.dias = textBox1.Text.ToString();
                radioButton1.Enabled=false;
                radioButton2.Enabled=false;
                radioButton3.Enabled=false;
                radioButton4.Enabled=false;
                
                //MessageBox.Show("dsfsd");

            
            }
            else if(checkBox1.Checked==false){
                textBox1.Enabled=false;
                textBox1.Text = "";
                radioButton1.Enabled=true;
                radioButton2.Enabled=true;
                radioButton3.Enabled=true;
                radioButton4.Enabled=true;
                this.dias="";
            
            
            
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked) {
                this.dias = "";
                this.dias = "Lunes a Domingo";
            
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                this.dias = "";
                this.dias = "Lunes a Sabado";

            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                this.dias = "";
                this.dias = "Lunes - Miercoles - Viernes";

            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                this.dias = "";
                this.dias = "Martes - Jueves - Sabado";

            }
        }

        private void cancelar_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }

        
    }

