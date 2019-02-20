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
    public partial class fmMenu : Form
    {
        public fmMenu()//hi
        {
            InitializeComponent();
            ConexionBD.Open();
        }

        private void especialidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            taEspecialidad taE = new taEspecialidad(ConexionBD);
            taE.Show();
        }
  
        private void médicosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            taMedicos taM = new taMedicos(ConexionBD);
            taM.Show();
        }
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            taPacientes taP = new taPacientes(ConexionBD);
            taP.Show();
        }

        private void especialidadToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fmConsultaEspecialidad cE = new fmConsultaEspecialidad(ConexionBD);
            cE.Show();
        }

        private void médicosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fmConsultaMedicos cM = new fmConsultaMedicos(ConexionBD);
            cM.Show();
        }

        private void pacientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fmConsultaPacientes cP = new fmConsultaPacientes(ConexionBD);
            cP.Show();
        }

        private void pagoAtenciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmPagoAtencion pPA = new fmPagoAtencion(ConexionBD);
            pPA.Show();
        }

        private void atenciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmAtencion pA = new fmAtencion(ConexionBD);
            pA.Show();
        }

        private void historiaClínicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmConsultaHistoriaClinica cHC = new fmConsultaHistoriaClinica(ConexionBD);//ConexionBD
            cHC.Show();
        }

        private void especialidadToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            fmReporteEspecialidades repE = new fmReporteEspecialidades();
            repE.Show();
        }

        private void médicosToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            fmReporteMedicos repM = new fmReporteMedicos();
            repM.Show();
        }

        private void pacientesToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            fmReportePacientes repP = new fmReportePacientes();
            repP.Show();
        }

        private void historiaClínicaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fmReporteHistoriaClinica repHC = new fmReporteHistoriaClinica();
            repHC.Show();
        }

        private void análisisEconómicoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fmReporteEconomico repEc = new fmReporteEconomico();
            repEc.Show();
        }


    }
}
