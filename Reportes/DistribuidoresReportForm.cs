﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace gasolinera.Reportes
{
    public partial class DistribuidoresReportForm : Form
    {
        public DistribuidoresReportForm()
        {
            InitializeComponent();
        }

        private void DistribuidoresReportForm_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'gasolineraDBDataSet.distribuidores' Puede moverla o quitarla según sea necesario.
            this.distribuidoresTableAdapter.Fill(this.gasolineraDBDataSet.distribuidores);

            this.reportViewer1.RefreshReport();
        }
    }
}
