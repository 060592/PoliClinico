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
    public partial class fmConsultaHistoriaClinica : Form
    {
        //...atributos
        private OleDbConnection ConexionBD;
        private DataSet dsConsulta;
        //private OleDbCommand ComandoBD;
        private OleDbDataAdapter DataAdapterBD;
        //private DataSet Datos;
        public fmConsultaHistoriaClinica(OleDbConnection ConexionBD_)
        {
            InitializeComponent();
            //ConexionBD.Open();
            //... inicializar componentes de acceso a la base de datos
            ConexionBD = ConexionBD_;
            DataAdapterBD = new OleDbDataAdapter();
            dsConsulta = new DataSet();
        }
        public void RecuperarDatosPaciente()
        {
            if (tbIDpaciente.Text != "")
            {
                //crear sentencia select
                String TextoSQL = "SELECT *" +
                                  " from taPaciente" +
                                  " where IdPaciente = '" + tbIDpaciente.Text + "'";
                // asignar al DATAAdapter
                DataAdapterBD = new OleDbDataAdapter();
                DataAdapterBD.SelectCommand = new OleDbCommand(TextoSQL, ConexionBD);
                // recuperar los datos en el dataset
                dsConsulta = new DataSet();
                DataAdapterBD.Fill(dsConsulta);//..los datos se llenan en el dataset a datos
                //recuperar datos
                //int NroRegistros = dsConsultaAux.Tables[0].Rows.Count;
                if (dsConsulta.Tables[0].Rows.Count > 0)
                {
                    tbPaciente.Text = dsConsulta.Tables[0].Rows[0]["AP"].ToString() + " " +
                                    dsConsulta.Tables[0].Rows[0]["AM"].ToString() + " " +
                                    dsConsulta.Tables[0].Rows[0]["Nombres"].ToString();
                    //tbDptoAcademico.Text = dsConsulta.Tables[0].Rows[0]["DptoAcademico"].ToString();
                    //...recuperar matricula si existe
                    // RecuperarMatricula(tbCodigoAlumno.Text);
                }
                else
                {
                    MessageBox.Show("Id del paciente no existe en la base de datos ...");
                    tbIDpaciente.Focus();
                }
            }
        }
        private void ProcesarConsultaNuevo()
        {
            // ... generar sentencia select

            //String TextoSQL = " Select taDocente.AP,taDocente.Nombres,taAsignatura.CodigoAsignatura,taAsignatura.Nombre,taAsignatura.Creditos " +
            //                  " from taAsignatura, taDocente " +
            //                  " where (taAsignatura.CodigoDoc = taDocente.CodigoDoc) and (taAsignatura.CodigoDoc = '" + tbCodigoDoc.Text + "')";

            //String TextoSQL = " Select D.AP,D.Nombres,A.CodigoAsignatura,A.Nombre,A.Creditos " +
            //                  " from taAsignatura A, taDocente D " +
            //                  " where (A.CodigoDoc = D.CodigoDoc) and (A.CodigoDoc = '" + tbCodigoDoc.Text + "')";
            String TextoSQL = " Select P.FechaPago,P.IdEspecialidad,A.Diagnostico,A.Tratamiento,A.IdMedico,A.NroRecibo " +
                              " from taPagoAtencion P, taAtencion A " +
                              " where (A.NroRecibo = P.NroRecibo) and (P.IdPaciente = '" + tbIDpaciente.Text + "')";//falta verificar
            // asignar al DATAAdapter
            DataAdapterBD.SelectCommand = new OleDbCommand(TextoSQL, ConexionBD);
            //... recuperar los datos en el dataset
            dsConsulta.Clear();
            DataAdapterBD.Fill(dsConsulta); //...los datos se llenan en el dataset a aDatos
            //...enlazar al data grid
            dgvConsultar.DataSource = dsConsulta;
            dgvConsultar.DataMember = "Table";
        }
        public string RecuperarCodigo()
        {
            return dgvConsultar.CurrentRow.Cells[0].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fmConsultaPacientes d = new fmConsultaPacientes(ConexionBD);
            if (d.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                tbIDpaciente.Text = d.RecuperarCodigo();
            tbIDpaciente.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tbIDpaciente_Leave(object sender, EventArgs e)
        {
            ProcesarConsultaNuevo();
            RecuperarDatosPaciente();
        }

       
    }
}
