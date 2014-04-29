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
            //MessageBox.Show("AAA");
            
            
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            miComando.CommandText = "dbo.insertar_articulo";
            //agregamos los parametros que necesita el procedimiento
            //insertar_articulo


            miComando.Parameters.AddWithValue("@det",txtDetalle.Text);
            miComando.Parameters.AddWithValue("@obs", txtObservaciones.Text);
            miComando.Parameters.AddWithValue("@lar", nudLargo.Value);
            miComando.Parameters.AddWithValue("@anc", nudAncho.Value);

            if (miComando.ExecuteNonQuery() == 1)
                MessageBox.Show("Datos guardados correctamente");
            else
                MessageBox.Show("Ha ocurrido un problema");
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        

        private void txtdetalle_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtdetalle_Enter(object sender, EventArgs e)
        {
            //txtdetalle.SelectionStart = 2;
        }

        private void txtdetalle_KeyPress(object sender, KeyPressEventArgs e)
        {
           // MessageBox.Show("A"); 
            if (e.KeyChar == (char)(Keys.Enter))
            {
                //MessageBox.Show("A");
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }        
        }

        private void mtbancho_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void AgregarArticulo_Load(object sender, EventArgs e)
        {

        }

        private void nudlargo_ValueChanged(object sender, EventArgs e)
        {

        }



        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
