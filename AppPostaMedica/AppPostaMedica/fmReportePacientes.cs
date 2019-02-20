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
    public partial class fmReportePacientes : Form
    {
        public fmReportePacientes()
        {
            InitializeComponent();
        }

        private void buReporte_Click(object sender, EventArgs e)
        {
            crReportePacientes p = new crReportePacientes();
            crvReporte.ReportSource = p;
        }

        private void buSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
