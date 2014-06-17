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
        private ParametrosDelSistema parametrosDelSistema;
        
        public Menu()
        {
            InitializeComponent();
            //EstablecerConexionYComando();
            parametrosDelSistema = null;
            
        }

        public void EstablecerConexionYComando(ParametrosDelSistema frmParametros)
        {
            miConexion = new SqlConnection();
            
            //levantamos las configuraciones del proyecto y armamos
            //variables para utilizarlas en la cadena de conexión
            
            miConexion.ConnectionString = ObtenerCadenaConexion();
            //MessageBox.Show(miConexion.ConnectionString);
            try
            {
                string mensaje = "Estableciendo conexión con el servidor de bases de datos...";
                EstablecerTextoEnBarraDeEstado(mensaje);
                miConexion.Close();
                miConexion.Open();
                mensaje = "Conexión establecida";
                EstablecerTextoEnBarraDeEstado(mensaje);
                if (frmParametros != null)
                {
                    frmParametros.Close();
                }
            }
            catch
            {
                string mensaje = "Error... la conexión al servidor no fue establecida, intente nuevamente... ";
                EstablecerTextoEnBarraDeEstado(mensaje);
                //MessageBox.Show(parametrosDelSistema.Visible.ToString());
                if (frmParametros == null)
                {
                    parametrosDelSistema = new ParametrosDelSistema(miConexion,this);
                    parametrosDelSistema.ShowDialog();
                    
                }
                else
                {
                    frmParametros.Activate();
                }

            }

           
            //tslMensajeBarraEstado.Text = "";
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
            ParametrosDelSistema parametrosDelSistema = new ParametrosDelSistema(miConexion,this);
            parametrosDelSistema.ShowDialog();
        }

        private void Menu_Shown(object sender, EventArgs e)
        {
            EstablecerFondo();
            EstablecerConexionYComando(parametrosDelSistema);
            
            
        }

        public void EstablecerFondo()
        {
            pbxImagenFondo.ImageLocation = Articulos.Properties.Settings.Default.imagenFondo;
        }

        public void EstablecerTextoEnBarraDeEstado(string texto)
        {
            tslMensajeBarraEstado.Text = texto;
            this.Refresh();
        }

        private void listaDeArtículosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionArticulos gestionArticulos = new GestionArticulos(miComando);
            gestionArticulos.ShowDialog();
        }

        private void editarArtículoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditarArticulo editarArticulo = new EditarArticulo(miComando, 1);
            editarArticulo.ShowDialog();
        }







    }
}
