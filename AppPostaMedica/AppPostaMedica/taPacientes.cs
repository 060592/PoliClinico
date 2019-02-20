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
    public partial class taPacientes : Form
    {
        //...atributos
        private OleDbConnection ConexionBD;
        private DataSet dsConsulta;
        private OleDbCommand ComandoBD;
        private OleDbDataAdapter DataAdapterBD;
        private DataSet Datos;
        public taPacientes(OleDbConnection ConexionBD_)
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
            tbIDpaciente.Text = "";
            tbAP.Text = "";
            tbAM.Text = "";
            tbNombres.Text = "";
            tbDireccion.Text = "";
            tbDNI.Text = "";
            //..poner focus
            tbIDpaciente.Focus();
        }
        private bool ExisteClave()
        {
            //...generar sentencia select
            String TextoSQL = "Select * " +
                              " from taPaciente " +
                              " where IdPaciente = '" + tbIDpaciente.Text + "'";
            //... asinar al DataAdapter
            DataAdapterBD.SelectCommand = new OleDbCommand(TextoSQL, ConexionBD);
            //... recuperar los datos en el DataSet
            Datos = new DataSet();
            DataAdapterBD.Fill(Datos); //...los datos se llenan en el DataSet a Datos
            return (Datos.Tables[0].Rows.Count > 0);
        }
        private void RecuperarRegistro()
        {
            //...recuperar atributos
            tbIDpaciente.Text = Datos.Tables[0].Rows[0]["IdPaciente"].ToString();
            tbAP.Text = Datos.Tables[0].Rows[0]["AP"].ToString();
            tbAM.Text = Datos.Tables[0].Rows[0]["AM"].ToString();
            tbNombres.Text = Datos.Tables[0].Rows[0]["Nombres"].ToString();
            tbDireccion.Text = Datos.Tables[0].Rows[0]["Direccion"].ToString();
            tbDNI.Text = Datos.Tables[0].Rows[0]["DNI"].ToString();
        }
        private void InsertarRegistro()
        {
            try
            {
                //...crear sentencia insert
                String TextoSQL = "INSERT INTO taPaciente" +
                                  " VALUES('" + tbIDpaciente.Text + "'," +
                                  "'" + tbAP.Text + "'," +
                                  "'" + tbAM.Text + "'," +
                                  "'" + tbNombres.Text + "'," +
                                  "'" + tbDireccion.Text + "'," +
                                  "'" + tbDNI.Text + "')";

                //...crear comando SQL
                ComandoBD = new OleDbCommand(TextoSQL, ConexionBD);
                //...ejecutar comando
                ComandoBD.ExecuteNonQuery();//solo 2 caracteres para codigoCP
                MessageBox.Show("SE REGISTRO CORRECTAMENTE", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception)
            {
                MessageBox.Show("ERROR. REVISE LOS CAMPOS", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //throw;
            }
            
        }
        private void ActualizarRegistro()
        {
            //... crear sentencia insert
            String TextoSQL = "UPDATE taPaciente " +
                              " set " +
                              //"IdPaciente = '" + tbIDpaciente.Text + "'," +
                              "AP = '" + tbAP.Text + "'," +
                              "AM = '" + tbAM.Text + "'," +
                              "Nombres = '" + tbNombres.Text + "'," +
                              "Direccion = '" + tbDireccion.Text + "'," +
                              "DNI = '" + tbDNI.Text + "'"+
                              " where IdPaciente = '" + tbIDpaciente.Text + "'";
                                
            //...crear comando SQL
            ComandoBD = new OleDbCommand(TextoSQL, ConexionBD);
            //...ejecutar comando
            ComandoBD.ExecuteNonQuery();
            MessageBox.Show("SE ACTUALIZO CORRECTAMENTE", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            InicializarRegistro();
        }
        private void ProcesarGrabar()
        {
            //...verificar si existe o no en la base de datos
            if (ExisteClave())
                MessageBox.Show("YA EXISTE UN REGISTRO CON ESA CLAVE", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //ActualizarRegistro();
            else
                InsertarRegistro();
            //...inicializar registro
            InicializarRegistro();
        }
        #endregion MÉTODOS

        private void buGrabar_Click(object sender, EventArgs e)
        {
            ProcesarGrabar();
        }

        private void tbIDpaciente_Leave(object sender, EventArgs e)
        {
            if (!buSalir.Focused)
            {
                if (tbIDpaciente.Text.CompareTo("") == 0)
                    tbIDpaciente.Focus();
                else
                    if (ExisteClave())
                        RecuperarRegistro();
            }
        }

        private void buSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ActualizarRegistro();
        }
    }
}
