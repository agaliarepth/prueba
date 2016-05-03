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
    public partial class FormFinanciero : Form
    {
        
        public FormFinanciero()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fecha=dateTimePicker1.Value.ToShortDateString();
            string mes = fecha.Substring(3, 2);
            string anio = fecha.Substring(6, 4);
           
            decimal v = Convert.ToDecimal(ventasTableAdapter1.TotaldeVentas_porFecha(mes,anio));
            decimal c=Convert.ToDecimal(comprasTableAdapter1.totalCompras_porFecha(mes,anio));
            if (v <= 0)
            {
                textBox1.Text = "0";
                textBox2.Text = "0";
                textBox3.Text = "0";
            }
            else
            {
                textBox1.Text = v.ToString();
                textBox2.Text= (v *Convert.ToDecimal( 0.03)).ToString();
                textBox3.Text = (v * Convert.ToDecimal(0.13)).ToString();
            }
            if (c <= 0)
            {
                textBox4.Text = "0";
                textBox5.Text = "0";

            }
            else {
                textBox4.Text = c.ToString();
                textBox5.Text = (c * Convert.ToDecimal(0.13)).ToString();
            
            
            }
            textBox6.Text = textBox2.Text;
            textBox7.Text = (Convert.ToDecimal(textBox3.Text) - Convert.ToDecimal(textBox5.Text)).ToString();
            textBox8.Text = (Convert.ToDecimal(textBox6.Text) + Convert.ToDecimal(textBox7.Text)).ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
