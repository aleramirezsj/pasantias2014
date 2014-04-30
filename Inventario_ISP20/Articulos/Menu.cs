using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Articulos
{
    public partial class Menu : Form
    {
        private SqlConnection miConexion;
        private SqlCommand miComando;
        
        public Menu()
        {
            InitializeComponent();
            EstablecerConexionYComando();
          
        }

        public void EstablecerConexionYComando()
        {
            miConexion = new SqlConnection();
            //levantamos las configuraciones del proyecto y armamos
            //variables para utilizarlas en la cadena de conexión
            /*
            string servidor = Articulos.Properties.Settings.Default.servidor;
            string bbdd = Articulos.Properties.Settings.Default.bbdd;
            string usuario = Articulos.Properties.Settings.Default.usuario;
            string contrasenia = Articulos.Properties.Settings.Default.contrasenia;
            miConexion.ConnectionString = "Data Source= "+servidor;
            miConexion.ConnectionString += " ;Initial Catalog = "+bbdd;
            miConexion.ConnectionString += " ;User Id = "+usuario;
            miConexion.ConnectionString += " ;Password = "+contrasenia;
            */
            miConexion.ConnectionString = ObtenerCadenaConexion();
            //MessageBox.Show(miConexion.ConnectionString);
            try
            {
                miConexion.Open();
            }
            catch
            {
                ParametrosDelSistema parametrosDelSistema = new ParametrosDelSistema(miConexion);
                parametrosDelSistema.ShowDialog();
            }
            //Creamo el objeto sqlcommand
            miComando = new SqlCommand();
            //establecemos con que conexión trabaja
            miComando.Connection = miConexion;
            miComando.CommandType = CommandType.StoredProcedure;
        }

        private void nuevoArtículoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form nuevoArticulo = new AgregarArticulo(miComando);
            nuevoArticulo.ShowDialog();
        }





        private void textBox2_Leave(object sender, EventArgs e)
        {
            //Articulos.Properties.Resources.tituloaplicacion = textBox2.Text;
            //Articulos.Properties.Resources.tituloaplicacion.sa
        }

        private void salirDelSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public static string ObtenerCadenaConexion()
        {
            string servidor = Articulos.Properties.Settings.Default.servidor;
            string bbdd = Articulos.Properties.Settings.Default.bbdd;
            string usuario = Articulos.Properties.Settings.Default.usuario;
            string contrasenia = Articulos.Properties.Settings.Default.contrasenia;
            string cadenaConexion = "Data Source= " + servidor;
            cadenaConexion += " ;Initial Catalog = " + bbdd;
            cadenaConexion += " ;User Id = " + usuario;
            cadenaConexion += " ;Password = " + contrasenia;
            return cadenaConexion;
        }
        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            string mensaje = "¿Está seguro que desea salir del sistema?";
            string titulo = "Salir del sistema";
            DialogResult respuesta=MessageBox.Show(mensaje, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                //si pulsan que si cierra el formulario
                //(no cancela el cierre)
                e.Cancel = false;
            }
            else
            {
                //si pulsan que no cierra el formulario
                //(si cancela el cierre)
                e.Cancel = true;
            }
        }

        private void configuraciónDelServidorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ParametrosDelSistema parametrosDelSistema = new ParametrosDelSistema(miConexion);
            parametrosDelSistema.ShowDialog();
        }





    }
}
