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
    public partial class fmAtencion : Form
    {
        //...atributos
        private OleDbConnection ConexionBD;
        private DataSet dsConsulta;
        private OleDbCommand ComandoBD;
        private OleDbDataAdapter DataAdapterBD;
        private DataSet Datos;
        public fmAtencion(OleDbConnection ConexionBD_)
        {
            InitializeComponent();
            //ConexionBD.Open();
            ConexionBD = ConexionBD_;
            DataAdapterBD = new OleDbDataAdapter();
            dsConsulta = new DataSet();
        }
        
        #region *********** MÉTODOS ************
        private void Inicializar()
        {
            tbNroRecibo.Focus();
            //dgvMatricula.Rows.Add(8);
        }
        private void InicializarRegistro()
        {
            // ..... inicializar atributos
            tbNroRecibo.Text = "";
            tbIDmedico.Text = "";
            tbDiagnostico.Text = "";
            tbTratamiento.Text = "";
            //..poner focus
            //tbNroRecibo.Focus();***
        }

        private bool ExisteClave()
        {
            //...generar sentencia select
            String TextoSQL = "Select * " +
                              " from taAtencion " +
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
            tbIDmedico.Text = Datos.Tables[0].Rows[0]["IdMedico"].ToString();
            tbDiagnostico.Text = Datos.Tables[0].Rows[0]["Diagnostico"].ToString();
            tbTratamiento.Text = Datos.Tables[0].Rows[0]["Tratamiento"].ToString();
           // tbIDespecialidad.Text = Datos.Tables[0].Rows[0]["IdEspecialidad"].ToString();
        }
        private void InsertarRegistro()
        {
            //...crear sentencia insert
            String TextoSQL = "INSERT INTO taAtencion " +
                              " VALUES('" + tbNroRecibo.Text + "'," +
                              "'" + tbIDmedico.Text + "'," +
                              "'" + tbDiagnostico.Text + "'," +
                              "'" + tbTratamiento.Text + "')";                            
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
                              "IdMedico = '" + tbIDmedico.Text + "'," +
                              "Diagnostico = '" + tbDiagnostico.Text + "'," +
                              "Tratamiento = '" + tbIDpaciente.Text + "'";

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
        public void RecuperarDatosIDpaciente()
        {
            if (tbNroRecibo.Text != "")
            {
                //crear sentencia select
                String TextoSQL = "SELECT *" +
                                  " from taPagoAtencion " +
                                  " where NroRecibo = '" + tbNroRecibo.Text + "'";
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
                    tbIDpaciente.Text = dsConsulta.Tables[0].Rows[0]["IdPaciente"].ToString();
                    
                }
                else
                {
                    MessageBox.Show("Código del paciente no existe en la base de datos ...aa");
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
        public void RecuperarDatosIDespecialidad()
        {
            if (tbNroRecibo.Text != "")
            {
                //crear sentencia select
                String TextoSQL = "SELECT *" +
                                  " from taPagoAtencion " +
                                  " where NroRecibo = '" + tbNroRecibo.Text + "'";
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
                    tbIDespecialidad.Text = dsConsulta.Tables[0].Rows[0]["IdEspecialidad"].ToString();

                }
            }
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
                }
                else
                {
                    MessageBox.Show("Código del paciente no existe en la base de datos ...");
                    tbIDpaciente.Focus();
                }
            }
        }
        #endregion MÉTODOS

        private void buConsulta_Click(object sender, EventArgs e)
        {
            fmConsultaPagoAtencion aa = new fmConsultaPagoAtencion(ConexionBD);
            if (aa.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                tbNroRecibo.Text = aa.RecuperarCodigo();
            tbNroRecibo.Focus();
        }

        private void tbNroRecibo_Leave(object sender, EventArgs e)
        {
            tbIDmedico.Clear();
            tbDiagnostico.Clear();
            tbTratamiento.Clear();
            if (!buSalir.Focused)
            {
                if (tbNroRecibo.Text.CompareTo("") == 0)
                    tbNroRecibo.Focus();
                else
                    if (ExisteClave())
                        RecuperarRegistro();
            }
            RecuperarDatosIDpaciente();
            RecuperarDatosPaciente();
            RecuperarDatosIDespecialidad();
            RecuperarDatosEspecialidad();
        }

        private void buConsultaMedico_Click(object sender, EventArgs e)
        {
            fmConsultaMedicos ofmConCarr = new fmConsultaMedicos(ConexionBD);
            if (ofmConCarr.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                tbIDmedico.Text = ofmConCarr.RecuperarCodigo();
            tbIDmedico.Focus();
        }

        private void buSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buGrabar_Click(object sender, EventArgs e)
        {
            ProcesarGrabar();
        }
    }
}
