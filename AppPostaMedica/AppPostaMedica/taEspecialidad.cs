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

namespace AppPostaMedica//andreEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEE
{
    public partial class taEspecialidad : Form
    {
        //...atributos
        private OleDbConnection ConexionBD;
        private DataSet dsConsulta;
        private OleDbCommand ComandoBD;
        private OleDbDataAdapter DataAdapterBD;
        private DataSet Datos;
        public taEspecialidad(OleDbConnection ConexionBD_)
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
            tbIDespecial.Text = "";
            tbNombreEspecial.Text = "";
            tbCostoAtencion.Text = "";
            //..poner focus
            tbIDespecial.Focus();
        }
        private bool ExisteClave()
        {
            //...generar sentencia select
            String TextoSQL = "Select * " +
                              " from taEspecialidad " +
                              " where IdEspecialidad = '" + tbIDespecial.Text + "'";
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
            tbIDespecial.Text = Datos.Tables[0].Rows[0]["IdEspecialidad"].ToString();
            tbNombreEspecial.Text = Datos.Tables[0].Rows[0]["NombreEspecialidad"].ToString();
            tbCostoAtencion.Text = Datos.Tables[0].Rows[0]["CostoAtencion"].ToString();
        }
        public void InsertarRegistro()
        {
            try
            {
                //...crear sentencia insert
                String TextoSQL = "INSERT INTO taEspecialidad" +
                                  " VALUES('" + tbIDespecial.Text + "'," +
                                  "'" + tbNombreEspecial.Text + "'," +
                                  "'" + tbCostoAtencion.Text + "')";

                //...crear comando SQL
                ComandoBD = new OleDbCommand(TextoSQL, ConexionBD);
                //...ejecutar comando
                ComandoBD.ExecuteNonQuery();//solo 2 caracteres para codigoCP
                MessageBox.Show("SE REGISTRO CORRECTAMENTE", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }
            catch (Exception)
            {
                MessageBox.Show("EL CAMPO COSTO DEBE SER NUMÉRICO", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //throw;
            }
            
        }
        private void ActualizarRegistro()
        {
            //clave = tbIDespecial.Text;
            //... crear sentencia insert
            String TextoSQL = "UPDATE taEspecialidad " +
                              " set " +
                              //"IdEspecialidad = '" + tbIDespecial.Text + "'," +
                              "NombreEspecialidad = '" + tbNombreEspecial.Text + "'," +
                              "CostoAtencion = '" + tbCostoAtencion.Text + "' "+
                              " where IdEspecialidad = '" + tbIDespecial.Text + "'";
                              //"CostoAtencion = '" + tbCostoAtencion.Text + "',";
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
            if (ExisteClave()){

                //MessageBox.Show("YA EXISTE UN REGISTRO CON ESA CLAVE");


                 MessageBox.Show("YA EXISTE UN REGISTRO CON ESA CLAVE","ATENCIÓN",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
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

        private void tbIDespecial_Leave(object sender, EventArgs e)
        {
            if (!buSalir.Focused)
            {
                if (tbIDespecial.Text.CompareTo("") == 0)
                    tbIDespecial.Focus();
                else
                    if (ExisteClave())
                        RecuperarRegistro();
            }
        }

        private void buSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buActualizar_Click(object sender, EventArgs e)
        {
            ActualizarRegistro();
        }
    }
}
