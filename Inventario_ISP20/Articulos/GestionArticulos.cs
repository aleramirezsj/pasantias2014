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

namespace Articulos
{
    public partial class GestionArticulos : Form
    {
        SqlCommand miComando;
        DataTable tablaArticulos;

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
            SqlDataReader reader_Articulos = miComando.ExecuteReader();
            
            tablaArticulos.Clear();
            tablaArticulos.Load(reader_Articulos);
            
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
            
            EditarArticulo editarArticulo = new EditarArticulo(miComando, idSeleccionado);
            editarArticulo.ShowDialog();
            
            CargarGrilla();

            dataGridArticulos.Rows[0].Selected = false;
            dataGridArticulos.Rows[filaSeleccionada].Selected = true;

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
                if (miComando.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Artículo eliminado correctamente");
                    CargarGrilla();
                }
                else
                    MessageBox.Show("Ha ocurrido un problema al eliminar");
            }
        }


        private Image obtenerImagen(int idSeleccionado)
        {
            miComando.CommandText = "dbo.obtener_imagen";
            miComando.Parameters.Clear();
            miComando.Parameters.AddWithValue("id", idSeleccionado);

            DataTable tablaArticulos = new DataTable();
            SqlDataReader readerArticulos = miComando.ExecuteReader(CommandBehavior.SingleRow);
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

        private void dataGridArticulos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCellCollection celdasFilaActual = dataGridArticulos.CurrentRow.Cells;
            Int16 idSeleccionado = (Int16)celdasFilaActual[0].Value;

            pbxImagenArticulo.Image = obtenerImagen(idSeleccionado);
        }
    }
}
