using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppPostaMedica
{
    public partial class fmReporteEconomico : Form
    {
        public fmReporteEconomico()
        {
            InitializeComponent();
        }

        private void buReporte_Click(object sender, EventArgs e)
        {
            crReporteEconomico r = new crReporteEconomico();
            crvReporte.ReportSource = r;
        }

        private void buSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
