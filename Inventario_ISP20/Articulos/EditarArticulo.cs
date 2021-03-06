﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

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
            pbxImagenArticulo.Image = obtenerImagen(idModificado);

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

        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            miComando.CommandText = "dbo.modificar_articulo";
            miComando.Parameters.Clear();

            MemoryStream imagenStream = new MemoryStream();
            pbxImagenArticulo.Image.Save(imagenStream, System.Drawing.Imaging.ImageFormat.Jpeg);
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

        private void btnExaminar_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdAbrirArchivo = new OpenFileDialog();
            string filtro = "Todas las imágenes|*.jpg;*.png;*.gif;*.bmp";
            filtro += "|JPG (*.jpg)|*.jpg";
            filtro += "|GIF (*.gif)|*.gif";
            filtro += "|PNG (*.png)|*.png";
            filtro += "|BMP (*.bmp)|*.bmp";
            ofdAbrirArchivo.Filter = filtro;
            ofdAbrirArchivo.ShowDialog();
            if (ofdAbrirArchivo.FileName != "")
                pbxImagenArticulo.ImageLocation = ofdAbrirArchivo.FileName;

        }
    }
}
