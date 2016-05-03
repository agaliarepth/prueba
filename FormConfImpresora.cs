using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace gasolinera
{
    public partial class FormConfImpresora : Form
    {
        List<String> impresoras = new List<String>();
        public FormConfImpresora()
        {
            InitializeComponent();
            foreach (String strPrinter in System.Drawing.Printing.PrinterSettings.InstalledPrinters)
            {

                dataGridView1.Rows.Add(strPrinter);

            }
            //dataGridView1.DataSource = impresoras.ToString();
        }
    }
}
