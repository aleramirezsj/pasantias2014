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
    public partial class GestionArticulos : Form
    {
        SqlCommand miComando;
        DataTable tablaArticulos;
        SqlDataReader readerArticulos;
        

        public GestionArticulos(SqlCommand miComand)
        {
            InitializeComponent();
            miComando = miComand;
            tablaArticulos = new DataTable();
            CargarGrilla();
            

        }

        private void CargarGrilla()
        {
            miComando.CommandText = "dbo.obtener_articulos";
            miComando.Parameters.Clear();
            readerArticulos = miComando.ExecuteReader();
            
            tablaArticulos.Clear();
            tablaArticulos.Load(readerArticulos);
            
            dataGridArticulos.DataSource = tablaArticulos;

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarArticulo frmAgregarArticulo = new AgregarArticulo(miComando);
            frmAgregarArticulo.ShowDialog();
            CargarGrilla();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            DataGridViewCellCollection celdasFilaActual = dataGridArticulos.CurrentRow.Cells;
            Int16 idSeleccionado = (Int16)celdasFilaActual[0].Value;
            //obtenemos la fila seleccionada actualmente
            int filaSeleccionada = dataGridArticulos.CurrentCell.RowIndex;
            
            EditarArticuloMiWebCam editarArticulo = new EditarArticuloMiWebCam(miComando, idSeleccionado);
            editarArticulo.ShowDialog();
            
            CargarGrilla();

            
            //dataGridArticulos.Rows[0].Selected = false;
            //dataGridArticulos.Rows[filaSeleccionada].Selected = true;
            //definimos la celda actual para hacer que CurrentRow se actualice 
            dataGridArticulos.CurrentCell = dataGridArticulos[0, filaSeleccionada];

            //actualizamos la imagen del articulo modificado
            DataGridViewCellEventArgs celdaSeleccionada = new DataGridViewCellEventArgs(1,filaSeleccionada);
            dataGridArticulos_CellClick(dataGridArticulos, celdaSeleccionada);

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DataGridViewCellCollection celdasFilaActual = dataGridArticulos.CurrentRow.Cells;
            Int16 idSeleccionado = (Int16)celdasFilaActual[0].Value;
            String articuloSeleccionado = (string)celdasFilaActual[1].Value;

            string mensaje = "¿Está seguro que eliminar el artículo:"+articuloSeleccionado+"?";
            string titulo = "Eliminación de un artículo";
            DialogResult respuesta = MessageBox.Show(mensaje, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
            if (respuesta == DialogResult.Yes)
            {
                //si pulsan que si elimina el artículo
                miComando.CommandText="dbo.eliminar_articulo";
                miComando.Parameters.Clear();
                miComando.Parameters.AddWithValue("id_eli", idSeleccionado);

                if (Utiles.EjecutarComandoEliminar(miComando, "Artículo eliminado correctamente"))
                    CargarGrilla();
            }
        }


        private Image obtenerImagen(int idSeleccionado)
        {
            miComando.CommandText = "dbo.obtener_imagen";
            miComando.Parameters.Clear();
            miComando.Parameters.AddWithValue("id", idSeleccionado);
            

            DataTable tablaArticulos = new DataTable();
            readerArticulos.Close();
            readerArticulos = miComando.ExecuteReader(CommandBehavior.SingleRow);
            tablaArticulos.Load(readerArticulos);

            

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

        private void dataGridArticulos_CellClick(object sender, DataGridViewCellEventArgs celdaSeleccionada)
        {
            //obtenemos todas las celdas de la fila actualmente seleccionada
            DataGridViewCellCollection celdasFilaActual = dataGridArticulos.Rows[celdaSeleccionada.RowIndex].Cells;
            //leemos el id de la fila seleccionada, entendiendo que siempre será
            //el primer valor, por ello colocamos el cero
            Int16 idSeleccionado = (Int16)celdasFilaActual[0].Value;

            pbxImagenArticulo.Image = obtenerImagen(idSeleccionado);
        }

        private void GestionArticulos_Shown(object sender, EventArgs e)
        {
            //simulamos hacer un clic en la grilla llamando al método CellClick
            //el método necesita de 2 argumentos, la grilla en si misma, y un objeto
            //del tipo DataGridViewCellEventArgs que dice cual es la celda en la cual 
            //se hizo un click, nosotros le decimos que fue en la fila 0, columna 0
            //con esto logramos que se cargue la imagen en pbxImagenArticulo
            DataGridViewCellEventArgs celdaSeleccionada = new DataGridViewCellEventArgs(0, 0);
            dataGridArticulos_CellClick(dataGridArticulos, celdaSeleccionada);
        }


        //actualiza la imagen cada vez que cambiamos de fila con el teclado
        private void dataGridArticulos_RowEnter(object dataGridArticulos, DataGridViewCellEventArgs celdaSeleccionada)
        {
            dataGridArticulos_CellClick(dataGridArticulos, celdaSeleccionada);
        }




    }
}
