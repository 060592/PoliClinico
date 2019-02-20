using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace AppPostaMedica
{
    public partial class fmConsultaPagoAtencion : Form
    {
        //...atributos
        private OleDbConnection ConexionBD;
        private DataSet dsConsulta;
        //private OleDbCommand ComandoBD;
        private OleDbDataAdapter DataAdapterBD;
        //private DataSet Datos;
        public fmConsultaPagoAtencion(OleDbConnection ConexionBD_)
        {
            InitializeComponent();
            //ConexionBD.Open();
            //... inicializar componentes de acceso a la base de datos
            ConexionBD = ConexionBD_;
            DataAdapterBD = new OleDbDataAdapter();
            dsConsulta = new DataSet();
        }
        private void ProcesarConsulta()
        {
            // ... generar sentencia select
            String TextoSQL = "Select * " +
                              "from taPagoAtencion ";
            // asignar al DATAAdapter
            DataAdapterBD.SelectCommand = new OleDbCommand(TextoSQL,ConexionBD);
            //... recuperar los datos en el dataset
            dsConsulta.Clear();
            DataAdapterBD.Fill(dsConsulta); //...los datos se llenan en el dataset a aDatos
            //...enlazar al data grid
            dgvConsulta.DataSource = dsConsulta;
            dgvConsulta.DataMember = "Table";
        }
        public string RecuperarCodigo()
        {
            return dgvConsulta.CurrentRow.Cells[0].Value.ToString();
        }

        private void fmConsultaPagoAtencion_Shown(object sender, EventArgs e)
        {
            ProcesarConsulta();
        }

        private void buAceptar_Click(object sender, EventArgs e)
        {
            Close();
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void buSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
