using System.Windows.Forms;
namespace MisClases
{
    partial class MiWebCam
    {
        /// <summary> 
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            //MessageBox.Show("eliminando mi webcam de memoria");
            if (disposing && (components != null))
            {
                components.Dispose();
                
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar 
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnCapturarFoto = new System.Windows.Forms.Button();
            this.btnIniciarCamara = new System.Windows.Forms.Button();
            this.pbxCamara = new System.Windows.Forms.PictureBox();
            this.btnExaminar = new System.Windows.Forms.Button();
            this.pbxImagen = new System.Windows.Forms.PictureBox();
            this.tmrApagarCamara = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbxCamara)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCapturarFoto
            // 
            this.btnCapturarFoto.Location = new System.Drawing.Point(26, 144);
            this.btnCapturarFoto.Name = "btnCapturarFoto";
            this.btnCapturarFoto.Size = new System.Drawing.Size(91, 23);
            this.btnCapturarFoto.TabIndex = 21;
            this.btnCapturarFoto.Text = "Capturar Foto";
            this.btnCapturarFoto.UseVisualStyleBackColor = true;
            this.btnCapturarFoto.Visible = false;
            this.btnCapturarFoto.Click += new System.EventHandler(this.btnCapturarFoto_Click);
            // 
            // btnIniciarCamara
            // 
            this.btnIniciarCamara.Location = new System.Drawing.Point(26, 115);
            this.btnIniciarCamara.Name = "btnIniciarCamara";
            this.btnIniciarCamara.Size = new System.Drawing.Size(91, 23);
            this.btnIniciarCamara.TabIndex = 20;
            this.btnIniciarCamara.Text = "Iniciar cámara";
            this.btnIniciarCamara.UseVisualStyleBackColor = true;
            this.btnIniciarCamara.Click += new System.EventHandler(this.btnIniciarCamara_Click);
            // 
            // pbxCamara
            // 
            this.pbxCamara.Location = new System.Drawing.Point(3, 3);
            this.pbxCamara.Name = "pbxCamara";
            this.pbxCamara.Size = new System.Drawing.Size(127, 106);
            this.pbxCamara.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxCamara.TabIndex = 19;
            this.pbxCamara.TabStop = false;
            // 
            // btnExaminar
            // 
            this.btnExaminar.Location = new System.Drawing.Point(163, 115);
            this.btnExaminar.Name = "btnExaminar";
            this.btnExaminar.Size = new System.Drawing.Size(75, 23);
            this.btnExaminar.TabIndex = 18;
            this.btnExaminar.Text = "Examinar";
            this.btnExaminar.UseVisualStyleBackColor = true;
            this.btnExaminar.Click += new System.EventHandler(this.btnExaminar_Click);
            // 
            // pbxImagen
            // 
            this.pbxImagen.Location = new System.Drawing.Point(136, 3);
            this.pbxImagen.Name = "pbxImagen";
            this.pbxImagen.Size = new System.Drawing.Size(127, 106);
            this.pbxImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxImagen.TabIndex = 17;
            this.pbxImagen.TabStop = false;
            // 
            // tmrApagarCamara
            // 
            this.tmrApagarCamara.Interval = 5000;
            this.tmrApagarCamara.Tick += new System.EventHandler(this.tmrApagarCamara_Tick);
            // 
            // MiWebCam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCapturarFoto);
            this.Controls.Add(this.btnIniciarCamara);
            this.Controls.Add(this.pbxCamara);
            this.Controls.Add(this.btnExaminar);
            this.Controls.Add(this.pbxImagen);
            this.Name = "MiWebCam";
            this.Size = new System.Drawing.Size(266, 171);
            
            ((System.ComponentModel.ISupportInitialize)(this.pbxCamara)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCapturarFoto;
        private System.Windows.Forms.Button btnIniciarCamara;
        private System.Windows.Forms.PictureBox pbxCamara;
        private System.Windows.Forms.Button btnExaminar;
        private System.Windows.Forms.PictureBox pbxImagen;
        private Timer tmrApagarCamara;
    }
}
