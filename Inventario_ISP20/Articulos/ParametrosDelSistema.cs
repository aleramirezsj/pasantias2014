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
    public partial class ParametrosDelSistema : Form
    {
        private SqlConnection miConexion;

        public ParametrosDelSistema(SqlConnection miConex)
        {
            InitializeComponent();
            miConexion = miConex;
        }

        private void txtServidor_TextChanged(object sender, EventArgs e)
        {
            btnGuardar.Enabled = true;
        }

        private void txtBbdd_TextChanged(object sender, EventArgs e)
        {
            btnGuardar.Enabled = true;
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            btnGuardar.Enabled = true;
        }

        private void txtContrasenia_TextChanged(object sender, EventArgs e)
        {
            btnGuardar.Enabled = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string mensaje = "¿Está seguro que desea guardar los cambios?";
            string titulo = "Parametros del sistema";
            DialogResult respuesta = MessageBox.Show(mensaje, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                //guarda la configuración
                //apago el formulario para que no puedan hacer cambios
                //hasta que no ser resuelva si se conecta o no
                this.Enabled = false;
                //guardo las propiedades definidas en el formulario
                Articulos.Properties.Settings.Default.Save();
                //cierro la conexión porque si está abierta una conexión no
                //nos deja cambiar su connection string
                miConexion.Close();
                //obtengo el connection string con las nuevas configuraciones
                //utilizando el método estátito asociado a la clase Menu
                //al establecer el método como Public y Static se puede llamar
                //de esta manera especial

                miConexion.ConnectionString = Articulos.Menu.ObtenerCadenaConexion();
                
                //MessageBox.Show(miConexion.ConnectionString);
                try
                {
                    
                    
                    miConexion.Open();
                    MessageBox.Show("Conexión establecida con éxito");
                }
                catch
                {
                    MessageBox.Show("No se pudo establecer la conexión...");
                }
                //enciendo el formulario despues de que se resuelva si
                //se conecta o no
                this.Enabled = true;
            }
            else
            {
                //restaura la configuración a sus valores originales
                Articulos.Properties.Settings.Default.Reset();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Articulos.Properties.Settings.Default.Reset();
            this.Close();
        }





    }
}
