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
    public partial class Forgffsdfxm1 : Form
    {
        public Forgffsdfxm1()
        {
            InitializeComponent();
        }

        private void Forgffsdfxm1_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
