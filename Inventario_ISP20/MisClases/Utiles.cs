using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Drawing;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace MisClases
{
    public static class Utiles
    {
        //
        //Resumen:
        // Método que retorna una imagen transformada en un arreglo de bytes
        // lista para ser guardada en una tabla, recibe como parametro una imagen
        // 
        public static byte[] ObtenerImagenEnBytes(Image imagen)
        {
            MemoryStream imagenStream = new MemoryStream();
            imagen.Save(imagenStream, System.Drawing.Imaging.ImageFormat.Jpeg);
            byte[] imagenBytes = imagenStream.ToArray();
            return imagenBytes;
        }

        public static Image ObtenerImagenDesdeBytes(byte[] imagenBytes)
        {

            //creamos un MemoryStream con el arreglo de la imagen
            MemoryStream imagenStream = new MemoryStream(imagenBytes);
            //utilizamos el método FromStream del objeto Image para crear una IMAGEN
            //a partir del MemoryStream creado,y la RETORNAMOS
            return Image.FromStream(imagenStream);



        }
        /// <summary>
        /// Método que ejecuta un SqlCommand, será utilizado desde el botón
        /// guardar, eliminar, modificar
        /// </summary>
        /// <param name="miComand">Espera la referencia al objeto SqlCommand Ej:miComando</param>
        /// <param name="miForm">referencia al formulario actual Ej:this</param>
        /// <param name="miMensaje">texto que se muestra si la ejecución fue satisfactoria Ej:Datos guardados correctamente</param>
        public static void EjecutarComando(SqlCommand miComand, Form miForm, string miMensaje)
        {
            if (miComand.ExecuteNonQuery() == 1)
            {
                MessageBox.Show(miMensaje);
                miComand.Parameters.Clear();
                miForm.Close();
            }
            else
                MessageBox.Show("Ha ocurrido un problema");
        }
        /// <summary>
        /// Método que ejecuta un SqlCommand, será utilizado desde el botón
        /// guardar, eliminar, modificar
        /// </summary>
        /// <param name="miComand">Espera la referencia al objeto SqlCommand Ej:miComando</param>
        /// <param name="miForm">referencia al formulario actual Ej:this</param>
        /// <param name="miMensaje">texto que se muestra si la ejecución fue satisfactoria Ej:Datos guardados correctamente</param>
        public static bool EjecutarComandoEliminar(SqlCommand miComand, string miMensaje)
        {
            if (miComand.ExecuteNonQuery() == 1)
            {
                MessageBox.Show(miMensaje);
                miComand.Parameters.Clear();
                return true;
            }
            else
            {
                MessageBox.Show("Ha ocurrido un problema");
                return false;
            }
        }
        /// <summary>
        /// Método que abre un cuadro de dialogo para buscar imágenes
        /// del tipo JPG, GIF, PNG y BMP, 
        /// Retorna un string con la ubicación de la imagen
        /// en disco o retorna vacío si el usuario no eligió ninguna imagen,
        /// es decir, pulsó el botón cancelar
        /// </summary>
        /// <returns></returns>
        public static string BuscarArchivoDeImagen()
        {
            OpenFileDialog ofdAbrirArchivo = new OpenFileDialog();
            string filtro = "Todas las imágenes|*.jpg;*.png;*.gif;*.bmp";
            filtro += "|JPG (*.jpg)|*.jpg";
            filtro += "|GIF (*.gif)|*.gif";
            filtro += "|PNG (*.png)|*.png";
            filtro += "|BMP (*.bmp)|*.bmp";
            ofdAbrirArchivo.Filter = filtro;
            ofdAbrirArchivo.ShowDialog();
            return ofdAbrirArchivo.FileName;
        }


        /// <summary>
        /// Método que busca en una base de datos una imagen a partir de pasarle
        /// por parametros un SqlCommand donde realizará la busqueda, un procedimiento
        /// almacenado, el nombre del campoId y el nombre del campoImagen.
        /// Método especialmente diseñado para responder al movimiento en grillas y
        /// actualizar algún picturebox que refleje el cliente/producto/etc.. 
        /// seleccionado, retorna la imagen, para poder hacer directamente la asignación
        /// de la imagen al picturebox.
        /// Ej: pbxImagen.image=utiles.obtenerImagenBBDD(miComando,"ObtenerImagen"...)
        /// </summary>
        /// <param name="miComand"></param>
        /// <param name="procedimientoAlmacenado"></param>
        /// <param name="campoId"></param>
        /// <param name="idObtener"></param>
        /// <param name="campoImagen"></param>
        /// <returns></returns>
        public static Image obtenerImagenBBDD(SqlCommand miComand, string procedimientoAlmacenado, string campoId,int idObtener, string campoImagen )
        {
            miComand.CommandText = procedimientoAlmacenado;
            miComand.Parameters.Clear();
            miComand.Parameters.AddWithValue(campoId, idObtener);

            DataTable tablaImagen = new DataTable();
            SqlDataReader readerImagen= miComand.ExecuteReader(CommandBehavior.SingleRow);
            tablaImagen.Load(readerImagen);
            readerImagen.Close();

            DataRow registroObtenido = tablaImagen.Rows[0];

            //evaluamos si existe una imagen para el id seleccionado
            if (registroObtenido[campoImagen] == System.DBNull.Value)
                return null;//no tiene una imagen por ello retorn null
            else
            {
                //si tiene una imagen
                byte[] bytesImagen = new byte[0];//creamos una arreglo de bytes
                //cargamos en el arreglo el arreglo de bytes almacenado en la base de datos
                bytesImagen = (byte[])registroObtenido[campoImagen];

                //creamos un MemoryStream con el arreglo de la imagen
                MemoryStream imagenStream = new MemoryStream(bytesImagen);
                //utilizamos el método FromStream del objeto Image para crear una IMAGEN
                //a partir del MemoryStream creado,y la RETORNAMOS
                return Image.FromStream(imagenStream);
            }

        }
    }
}
