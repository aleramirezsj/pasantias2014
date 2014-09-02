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
using AForge.Video;
using AForge.Video.DirectShow;
using MisClases;

namespace Articulos
{
    public partial class AgregarArticulo : Form
    {
        private SqlCommand miComando;

        //propiedades para el uso de la webcam
        private bool existenDispositivos = false;
        private FilterInfoCollection dispositivosDeVideo;
        private VideoCaptureDevice fuenteDeVideo = null;

        public AgregarArticulo(SqlCommand miComand)
        {
            InitializeComponent();
            miComando = miComand;
            //MessageBox.Show("AAA");
            BuscarDispositivos();
            
            
            
        }
        public AgregarArticulo()
        {

        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            miComando.CommandText = "dbo.insertar_articulo";
            miComando.Parameters.Clear();
            //agregamos los parametros que necesita el procedimiento
            //insertar_articulo
            
            byte[] imagenBytes = Utiles.ObtenerImagenEnBytes(pbxImagenArticulo.Image);


            miComando.Parameters.AddWithValue("@det",txtDetalle.Text);
            miComando.Parameters.AddWithValue("@obs", txtObservaciones.Text);
            miComando.Parameters.AddWithValue("@lar", nudLargo.Value);
            miComando.Parameters.AddWithValue("@anc", nudAncho.Value);
            miComando.Parameters.AddWithValue("@img", imagenBytes);

            Utiles.EjecutarComando(miComando, this,"Artículo guardado correctamente");
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

        /*
         *  Identifica los dispositivos disponibles
         */
        private void BuscarDispositivos()
        {
            dispositivosDeVideo = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            if (dispositivosDeVideo.Count == 0)
                existenDispositivos = false;
            else
                existenDispositivos = true;
        }

        //inicia la cámara
        private void InicializarCamara()
        {
            if (existenDispositivos)
            {
                fuenteDeVideo = new VideoCaptureDevice(dispositivosDeVideo[0].MonikerString);
                fuenteDeVideo.NewFrame += new NewFrameEventHandler(MostrarImagen);
                fuenteDeVideo.Start();
            }
            else
            {
                MessageBox.Show("No se encuentra ningún dispositivo de vídeo en el sistema", "Información",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                
            }
        }

        /*
         *  Muestra imagen en el PictureBox
         */
        private void MostrarImagen(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap imagen = (Bitmap)eventArgs.Frame.Clone();
            pbxWebcam.Image = imagen;
        }

        private void btnIniciarCamara_Click(object sender, EventArgs e)
        {
            InicializarCamara();
            btnCapturarFoto.Visible = true;
        }

        private void AgregarArticulo_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (fuenteDeVideo != null)
            {
                if (fuenteDeVideo.IsRunning)
                {
                    fuenteDeVideo.SignalToStop();
                    fuenteDeVideo = null;
                }
            }

            Dispose();
            Close();
        }

        private void CapturarFoto()
        {
            if (fuenteDeVideo != null)
            {
                if (fuenteDeVideo.IsRunning)
                {
                    pbxImagenArticulo.Image = pbxWebcam.Image;
                }
            }
        }

        private void btnCapturarFoto_Click(object sender, EventArgs e)
        {
            CapturarFoto();
        }

    }
}
