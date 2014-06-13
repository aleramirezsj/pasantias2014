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



    }
}
