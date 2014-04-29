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

        private void EstablecerConexionYComando()
        {
            miConexion = new SqlConnection();
            miConexion.ConnectionString = "Data Source= NBRAR\\SQLEXPRESS2008 ";
            miConexion.ConnectionString += ";Initial Catalog = inventario_isp20_2014 ";
            miConexion.ConnectionString += ";User Id = sa ";
            miConexion.ConnectionString += ";Password = 123 ";
            miConexion.Open();

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



    }
}
