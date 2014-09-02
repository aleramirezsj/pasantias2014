using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;

namespace MisClases
{
    public partial class MiWebCam : UserControl
    {
        //definimos una propiedad que nos permite acceder de forma pública a
        //la imagen que tiene el control MiWebCam.
        //Le definimos el método get y set para controlar que retorna la 
        //propiedad cuando es leida y que almacena cuando le es asignado algún
        //valor
        public Image Imagen
        {
            //cuando sea leída esta propiedad (get) retornará la Imagen
            //que tiene el pbxImagen
            get
            {
                return pbxImagen.Image;
            }
            //cuando intentemos asignarle un valor a esta propiedad pública
            //se ejecutará este método (set) y en el mismo se gestionará
            //el valor asignado con la variable local VALUE
            set
            {
                if (value.GetType() == Type.GetType("System.Drawing.Image"))
                {
                    Imagen = value;
                    pbxImagen.Image = value;
                }
                else
                    Imagen = null;
            }
        }
        //propiedades para el uso de la webcam
        private bool existenDispositivos = false;
        private FilterInfoCollection dispositivosDeVideo;
        private VideoCaptureDevice fuenteDeVideo = null;

        public MiWebCam()
        {
            InitializeComponent();
            //Imagen = pbxImagen.Image;
            BuscarDispositivos();
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
                btnIniciarCamara.Text = "Apagar cámara";
                btnCapturarFoto.Visible = true;
                
            }
            else
            {
                MessageBox.Show("No se encuentra ningún dispositivo de vídeo en el sistema", "Información",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            
        }
        

        /// <summary>
        /// Muestra imagen en el PictureBox
        /// </summary>
        private void MostrarImagen(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap imagen = (Bitmap)eventArgs.Frame.Clone();
            pbxCamara.Image = imagen;
        }

        /// <summary>
        /// método llamado desde el botón examinar
        /// </summary>
        private void Examinar()
        {
            string archivoImagen = Utiles.BuscarArchivoDeImagen();
            if (archivoImagen != "")
            {
                Image imagenElegida = Image.FromFile(archivoImagen);
                pbxImagen.Image = imagenElegida;
                
            }   

            
        }
        /// <summary>
        /// Botón que permite buscar un archivo de imagen en el disco
        /// </summary>
        private void btnExaminar_Click(object sender, EventArgs e)
        {
            Examinar();
           
        }

        private void apagarCamara()
        {
            fuenteDeVideo.SignalToStop();
            fuenteDeVideo = null;
            btnIniciarCamara.Text = "Iniciar cámara";
            btnCapturarFoto.Visible = false;
            tmrApagarCamara.Enabled = false;

        }
        private void apagarCamaraFormularioCerrado()
        {
            FilterInfoCollection dispositivosDeVideo = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            if (dispositivosDeVideo.Count == 0)
            {
                VideoCaptureDevice fuenteDeVideo = new VideoCaptureDevice(dispositivosDeVideo[0].MonikerString);
                fuenteDeVideo.SignalToStop();
                fuenteDeVideo = null;
            }
            

        }

        private void btnIniciarCamara_Click(object sender, EventArgs e)
        {
            if (fuenteDeVideo == null)
            {
                InicializarCamara();
                tmrApagarCamara.Enabled = true;
            }
            else
            {
                apagarCamara();
            }
        }
        /// <summary>
        /// Método que toma la imagen actual del pbxCamara y la copia
        /// al pbxImagen
        /// </summary>
        private void CapturarFoto()
        {

           
            if (fuenteDeVideo != null)
            {
                if (fuenteDeVideo.IsRunning)
                {
                    pbxImagen.Image = pbxCamara.Image;
                    
                }
            }
        }

        private void btnCapturarFoto_Click(object sender, EventArgs e)
        {
            CapturarFoto();
        }

        private void tmrApagarCamara_Tick(object sender, EventArgs e)
        {
            if (this.Parent.Visible == false)
            {
                apagarCamara();
            }
        }


       
        
    }
}
