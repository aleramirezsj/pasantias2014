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
    public partial class AgregarArticulo : Form
    {
        private SqlCommand miComando;
        public AgregarArticulo(SqlCommand miComand)
        {
            InitializeComponent();
            miComando = miComand;
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            miComando.CommandText = "dbo.insertar_articulo";
            //creamos los parametros que necesita el procedimiento
            //insertar_articulo


            miComando.Parameters.AddWithValue("@det",txtdetalle.Text);
            miComando.Parameters.AddWithValue("@obs", txtobservaciones.Text);
            miComando.Parameters.AddWithValue("@lar", nudlargo.Value);
            miComando.Parameters.AddWithValue("@anc", Convert.ToDecimal(mtbancho.Text));

            if (miComando.ExecuteNonQuery() == 1)
                MessageBox.Show("Datos guardados correctamente");
            else
                MessageBox.Show("Ha ocurrido un problema");
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox1_Leave(object sender, EventArgs e)
        {
            MessageBox.Show(mtbancho.Text);
        }
    }
}
