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
    public partial class fmReporteHistoriaClinica : Form
    {
        public fmReporteHistoriaClinica()
        {
            InitializeComponent();
        }

        private void buReporte_Click(object sender, EventArgs e)
        {
            crReporteHistoriaClinica d = new crReporteHistoriaClinica();
            crvReporte.ReportSource = d;
        }

        private void buSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
