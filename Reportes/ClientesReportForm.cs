using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace gasolinera.Reportes
{
    public partial class ClientesReportForm : Form
    {
        public ClientesReportForm()
        {
            InitializeComponent();
        }

        private void ClientesReportForm_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'gasolineraDBDataSet.clientes' Puede moverla o quitarla según sea necesario.
            this.clientesTableAdapter.Fill(this.gasolineraDBDataSet.clientes);

            this.reportViewer1.RefreshReport();
        }
    }
}
