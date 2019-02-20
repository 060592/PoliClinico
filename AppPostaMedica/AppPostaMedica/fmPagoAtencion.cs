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
    public partial class fmPagoAtencion : Form
    {
        //...atributos
        private OleDbConnection ConexionBD;
        private DataSet dsConsulta;
        private OleDbCommand ComandoBD;
        private OleDbDataAdapter DataAdapterBD;
        private DataSet Datos;
        public fmPagoAtencion(OleDbConnection ConexionBD_)
        {
            InitializeComponent();
            //ConexionBD.Open();
            ConexionBD = ConexionBD_;
            DataAdapterBD = new OleDbDataAdapter();
            dsConsulta = new DataSet();
        }
        #region *********** MÉTODOS ************
        private void InicializarRegistro()
        {
            // ..... inicializar atributos
            tbNroRecibo.Text = "";
            dtpFecha.Value = DateTime.Now;
            tbImporte.Text = "";
            tbIDpaciente.Text = "";
            tbIDespecialidad.Text = "";
            //..poner focus
            tbNroRecibo.Focus();
        }
        
        private bool ExisteClave()
        {
            //...generar sentencia select
            String TextoSQL = "Select * " +
                              " from taPagoAtencion " +
                              " where NroRecibo = '" + tbNroRecibo.Text + "'";
            //... asignar al DataAdapter
            DataAdapterBD.SelectCommand = new OleDbCommand(TextoSQL, ConexionBD);
            //... recuperar los datos en el DataSet
            Datos = new DataSet();
            DataAdapterBD.Fill(Datos); //...los datos se llenan en el DataSet a Datos
            return (Datos.Tables[0].Rows.Count > 0);
        }
        private void RecuperarRegistro()
        {
            //...recuperar atributos
            tbNroRecibo.Text = Datos.Tables[0].Rows[0]["NroRecibo"].ToString();
            dtpFecha.Text = Datos.Tables[0].Rows[0]["FechaPago"].ToString();
            tbImporte.Text = Datos.Tables[0].Rows[0]["Importe"].ToString();
            tbIDpaciente.Text = Datos.Tables[0].Rows[0]["IdPaciente"].ToString();
            tbIDespecialidad.Text = Datos.Tables[0].Rows[0]["IdEspecialidad"].ToString();
        }
        private void InsertarRegistro()
        {
            //...crear sentencia insert
            String TextoSQL = "INSERT INTO taPagoAtencion " +
                              " VALUES('" + tbNroRecibo.Text + "'," +
                              "'" + dtpFecha.Text + "'," +
                              "'" + tbImporte.Text + "'," +
                              "'" + tbIDpaciente.Text + "'," +
                              "'" + tbIDespecialidad.Text + "')";
            //...crear comando SQL
            ComandoBD = new OleDbCommand(TextoSQL, ConexionBD);
            //...ejecutar comando
            ComandoBD.ExecuteNonQuery();//solo 2 caracteres
        }
        private void ActualizarRegistro()
        {
            //... crear sentencia insert
            String TextoSQL = "UPDATE taPagoAtencion " +
                              " set " +
                              "NroRecibo = '" + tbNroRecibo.Text + "'," +
                              "FechaPago = '" + dtpFecha.Text + "'," +
                              "Importe = '" + tbImporte.Text + "'," +
                              "IdPaciente = '" + tbIDpaciente.Text + "'," +
                              "IdEspecialidad = '" + tbIDespecialidad.Text + "'";

            //...crear comando SQL
            ComandoBD = new OleDbCommand(TextoSQL, ConexionBD);
            //...ejecutar comando
            ComandoBD.ExecuteNonQuery();
        }
        private void ProcesarGrabar()
        {
            //...verificar si existe o no en la base de datos
            if (ExisteClave())
                ActualizarRegistro();
            else
                InsertarRegistro();
            //...inicializar registro
            InicializarRegistro();
        }
        public void RecuperarDatosEspecialidad()
        {
            if (tbIDespecialidad.Text != "")
            {
                //crear sentencia select
                String TextoSQL = "SELECT *" +
                                  " from taEspecialidad " +
                                  " where IdEspecialidad = '" + tbIDespecialidad.Text + "'";
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
                    tbEspecialidad.Text = dsConsulta.Tables[0].Rows[0]["NombreEspecialidad"].ToString();                                   
                    //tbCodigoCP.Text = dsConsulta.Tables[0].Rows[0]["CodigoCP"].ToString();
                    //...recuperar matricula si existe
                    //RecuperarMatricula(tbCodigoAlumno.Text);
                }
                else
                {
                    MessageBox.Show("Código de la especialidad no existe en la base de datos ...");
                    tbIDpaciente.Focus();
                }
            }
        }
        public void RecuperarDatosPaciente()
        {
            if (tbIDpaciente.Text != "")
            {
                //crear sentencia select
                String TextoSQL = "SELECT *" +
                                  " from taPaciente " +
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
                                    dsConsulta.Tables[0].Rows[0]["AM"].ToString() + "    " +
                                    dsConsulta.Tables[0].Rows[0]["Nombres"].ToString();
                }
                else
                {
                    MessageBox.Show("Código del paciente no existe en la base de datos ...");
                    tbIDpaciente.Focus();
                }
            }
        }
        #endregion MÉTODOS

        private void buGrabar_Click(object sender, EventArgs e)
        {
            ProcesarGrabar();
        }

        private void buSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tbNroRecibo_Leave(object sender, EventArgs e)
        {
            if (!buSalir.Focused)
            {
                if (tbNroRecibo.Text.CompareTo("") == 0)
                    tbNroRecibo.Focus();
                else
                    if (ExisteClave())
                        RecuperarRegistro();
            }
            RecuperarDatosPaciente();
            RecuperarDatosEspecialidad();
        }

        private void buConsultaP_Click(object sender, EventArgs e)
        {
            fmConsultaPacientes ofmConCarr = new fmConsultaPacientes(ConexionBD);
            if (ofmConCarr.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                tbIDpaciente.Text = ofmConCarr.RecuperarCodigo();
            tbIDpaciente.Focus();
        }

        private void buConsultaE_Click(object sender, EventArgs e)
        {
            fmConsultaEspecialidad ofmConCarr = new fmConsultaEspecialidad(ConexionBD);
            if (ofmConCarr.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                tbIDespecialidad.Text = ofmConCarr.RecuperarCodigo();
            tbIDespecialidad.Focus();
        }

        private void buConsulta_Click(object sender, EventArgs e)
        {
            fmConsultaPagoAtencion aa = new fmConsultaPagoAtencion(ConexionBD);
            if (aa.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                tbNroRecibo.Text = aa.RecuperarCodigo();
            tbNroRecibo.Focus();
        }

        private void tbIDpaciente_Leave(object sender, EventArgs e)
        {
            RecuperarDatosPaciente();
        }

        private void tbIDespecialidad_Leave(object sender, EventArgs e)
        {
            RecuperarDatosEspecialidad();
        }
    }
}
