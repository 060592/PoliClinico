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
    public partial class taMedicos : Form
    {
        //...atributos
        private OleDbConnection ConexionBD;
        private DataSet dsConsulta;
        private OleDbCommand ComandoBD;
        private OleDbDataAdapter DataAdapterBD;
        private DataSet Datos;
        public taMedicos(OleDbConnection ConexionBD_)
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
            tbIDmedico.Text = "";
            tbAP.Text = "";
            tbAM.Text = "";
            tbNombres.Text = "";
            tbIDespecial.Text = "";
            //..poner focus
            tbIDespecial.Focus();
        }
        private bool ExisteClave()
        {
            //...generar sentencia select
            String TextoSQL = "Select * " +
                              " from taMedico " +
                              " where IdMedico = '" + tbIDmedico.Text + "'";
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
            tbIDmedico.Text = Datos.Tables[0].Rows[0]["IdMedico"].ToString();
            tbAP.Text = Datos.Tables[0].Rows[0]["AP"].ToString();
            tbAM.Text = Datos.Tables[0].Rows[0]["AM"].ToString();
            tbNombres.Text = Datos.Tables[0].Rows[0]["Nombres"].ToString();
            tbIDespecial.Text = Datos.Tables[0].Rows[0]["IdEspecialidad"].ToString();
        }
        private void InsertarRegistro()
        {
            try
            {
                //...crear sentencia insert
                String TextoSQL = "INSERT INTO taMedico" +
                                  " VALUES('" + tbIDmedico.Text + "'," +
                                  "'" + tbAP.Text + "'," +
                                  "'" + tbAM.Text + "'," +
                                  "'" + tbNombres.Text + "'," +
                                  "'" + tbIDespecial.Text + "')";

                //...crear comando SQL
                ComandoBD = new OleDbCommand(TextoSQL, ConexionBD);
                //...ejecutar comando
                ComandoBD.ExecuteNonQuery();//solo 2 caracteres para codigoCP
                MessageBox.Show("SE REGISTRO CORRECTAMENTE", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception)
            {
                MessageBox.Show("DEBE INGRESAR UNA ESPECIALIDAD EXISTENTE", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //throw;
            }
            
        }
        private void ActualizarRegistro()
        {
            //... crear sentencia insert
            String TextoSQL = "UPDATE taMedico " +
                              " set " +
                              //"IdMedico = '" + tbIDmedico.Text + "'," +
                              "AP = '" + tbAP.Text + "'," +
                              "AM = '" + tbAM.Text + "'," +
                              "Nombres = '" + tbNombres.Text + "'," +
                              "IdEspecialidad = '" + tbIDespecial.Text + "'"+
                              " where IdMedico = '" + tbIDmedico.Text + "'";
                
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
                //ActualizarRegistro();
                MessageBox.Show("YA EXISTE UN REGISTRO CON ESA CLAVE", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        private void tbIDmedico_Leave(object sender, EventArgs e)
        {
            if (!buSalir.Focused)
            {
                if (tbIDmedico.Text.CompareTo("") == 0)
                    tbIDmedico.Focus();
                else
                    if (ExisteClave())
                        RecuperarRegistro();
            }
        }

        private void buSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buConsulta_Click(object sender, EventArgs e)
        {
            fmConsultaEspecialidad Oce = new fmConsultaEspecialidad(ConexionBD);
            if (Oce.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                tbIDespecial.Text = Oce.RecuperarCodigo();
            tbIDespecial.Focus();
        }

        private void buActualizar_Click(object sender, EventArgs e)
        {
            ActualizarRegistro();
        }
    }
}
