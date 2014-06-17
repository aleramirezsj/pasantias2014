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
    public partial class EditarArticulo : Form
    {
        private SqlCommand miComando;
        private int idModificado;

        public EditarArticulo(SqlCommand miComand,int idModificar)
        {
            InitializeComponent();
            miComando = miComand;
            idModificado = idModificar;
            CargarDatos();

        }

        private void CargarDatos()
        {
            miComando.CommandText = "dbo.obtener_articulo";
            miComando.Parameters.Clear();

            miComando.Parameters.AddWithValue("id_obt", idModificado);
            SqlDataReader readerArticulo=miComando.ExecuteReader();
            DataTable tablaArticulo= new DataTable();
            tablaArticulo.Load(readerArticulo);
            DataRow registroArticulo = tablaArticulo.Rows[0];

            txtDetalle.Text = (string)registroArticulo["detalle"];
            txtObservaciones.Text = (string)registroArticulo["observaciones"];
            nudAncho.Value = Convert.ToDecimal(registroArticulo["ancho"].ToString());
            nudLargo.Value = Convert.ToDecimal(registroArticulo["largo"].ToString());

        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            miComando.CommandText = "dbo.modificar_articulo";
            miComando.Parameters.Clear();

            miComando.Parameters.AddWithValue("id_mod", idModificado);
            miComando.Parameters.AddWithValue("det", txtDetalle.Text);
            miComando.Parameters.AddWithValue("obs", txtObservaciones.Text);
            miComando.Parameters.AddWithValue("lar", nudLargo.Value);
            miComando.Parameters.AddWithValue("anc", nudAncho.Value);

            if (miComando.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Datos guardados correctamente");
                this.Close();
            }
            else
                MessageBox.Show("Ha ocurrido un problema");

            
        }
       
    }
}
