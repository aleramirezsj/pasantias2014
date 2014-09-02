using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using MisClases;

namespace Articulos
{
    public partial class EditarArticuloMiWebCam : Form
    {
        private SqlCommand miComando;
        private int idModificado;

        public EditarArticuloMiWebCam(SqlCommand miComand, int idModificar)
        {
            InitializeComponent();
            miComando = miComand;
            idModificado = idModificar;
            CargarDatos();
            //Cargar la imagen del articulo seleccionado para editar
            //miWebCam.Imagen = Utiles.obtenerImagenBBDD(miComando,
            //                  "dbo.obtener_imagen", "id", idModificado, "imagen");

        }

        private void CargarDatos()
        {
            miComando.CommandText = "dbo.obtener_articulo";
            miComando.Parameters.Clear();

            miComando.Parameters.AddWithValue("id_obt", idModificado);
            SqlDataReader readerArticulo=miComando.ExecuteReader();
            DataTable tablaArticulo= new DataTable();
            tablaArticulo.Load(readerArticulo);
            readerArticulo.Close();
            DataRow registroArticulo = tablaArticulo.Rows[0];

            txtDetalle.Text = (string)registroArticulo["detalle"];
            txtObservaciones.Text = (string)registroArticulo["observaciones"];
            nudAncho.Value = Convert.ToDecimal(registroArticulo["ancho"].ToString());
            nudLargo.Value = Convert.ToDecimal(registroArticulo["largo"].ToString());
            miWebCam.Imagen = Utiles.ObtenerImagenDesdeBytes((byte[])registroArticulo["imagen"]);
            /* 3 lineas de código que esclarecen la linea anterior
            //arreglo de bytes
            byte[] ImagenEnBytes = (byte[])registroArticulo["imagen"];
            //creo la imagen a partir del arreglo
            Image imagenArticulo = Utiles.ObtenerImagenDesdeBytes(ImagenEnBytes);
            //asigno la imagen a miWebCam
            miWebCam.Imagen = imagenArticulo;
             */ 
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            miComando.CommandText = "dbo.modificar_articulo";
            miComando.Parameters.Clear();

            MemoryStream imagenStream = new MemoryStream();
            miWebCam.Imagen.Save(imagenStream, System.Drawing.Imaging.ImageFormat.Jpeg);
            byte[] imagenBytes = imagenStream.ToArray();


            miComando.Parameters.AddWithValue("id_mod", idModificado);
            miComando.Parameters.AddWithValue("det", txtDetalle.Text);
            miComando.Parameters.AddWithValue("obs", txtObservaciones.Text);
            miComando.Parameters.AddWithValue("lar", nudLargo.Value);
            miComando.Parameters.AddWithValue("anc", nudAncho.Value);
            miComando.Parameters.AddWithValue("img", imagenBytes);

            if (miComando.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Datos guardados correctamente");
                this.Close();
            }
            else
                MessageBox.Show("Ha ocurrido un problema");

            
        }

        private Image obtenerImagen(int idSeleccionado)
        {
            miComando.CommandText = "dbo.obtener_imagen";
            miComando.Parameters.Clear();
            miComando.Parameters.AddWithValue("id", idSeleccionado);

            DataTable tablaArticulos = new DataTable();
            SqlDataReader readerArticulos = miComando.ExecuteReader(CommandBehavior.SingleRow);
            tablaArticulos.Load(readerArticulos);
            readerArticulos.Close();

            DataRow registroObtenido = tablaArticulos.Rows[0];

            if (registroObtenido["imagen"] == System.DBNull.Value)
                return null;
            else
            {
                byte[] bytesImagen = new byte[0];
                bytesImagen = (byte[])registroObtenido["imagen"];

                MemoryStream imagenStream = new MemoryStream(bytesImagen);
                return Image.FromStream(imagenStream);
            }

        }


    }
}
