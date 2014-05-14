namespace Articulos
{
    partial class ParametrosDelSistema
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
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbcParametros = new System.Windows.Forms.TabControl();
            this.tbpServidor = new System.Windows.Forms.TabPage();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblContrasenia = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblBbdd = new System.Windows.Forms.Label();
            this.lblServidor = new System.Windows.Forms.Label();
            this.tbpImagenFondo = new System.Windows.Forms.TabPage();
            this.txtContrasenia = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtBbdd = new System.Windows.Forms.TextBox();
            this.txtServidor = new System.Windows.Forms.TextBox();
            this.lblImagenFondo = new System.Windows.Forms.Label();
            this.pbxImagenFondo = new System.Windows.Forms.PictureBox();
            this.btnExaminar = new System.Windows.Forms.Button();
            this.btnAplicar = new System.Windows.Forms.Button();
            this.tbcParametros.SuspendLayout();
            this.tbpServidor.SuspendLayout();
            this.tbpImagenFondo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagenFondo)).BeginInit();
            this.SuspendLayout();
            // 
            // tbcParametros
            // 
            this.tbcParametros.Controls.Add(this.tbpServidor);
            this.tbcParametros.Controls.Add(this.tbpImagenFondo);
            this.tbcParametros.Location = new System.Drawing.Point(13, 13);
            this.tbcParametros.Name = "tbcParametros";
            this.tbcParametros.SelectedIndex = 0;
            this.tbcParametros.Size = new System.Drawing.Size(329, 255);
            this.tbcParametros.TabIndex = 0;
            // 
            // tbpServidor
            // 
            this.tbpServidor.Controls.Add(this.btnCancelar);
            this.tbpServidor.Controls.Add(this.btnGuardar);
            this.tbpServidor.Controls.Add(this.lblContrasenia);
            this.tbpServidor.Controls.Add(this.txtContrasenia);
            this.tbpServidor.Controls.Add(this.lblUsuario);
            this.tbpServidor.Controls.Add(this.txtUsuario);
            this.tbpServidor.Controls.Add(this.lblBbdd);
            this.tbpServidor.Controls.Add(this.txtBbdd);
            this.tbpServidor.Controls.Add(this.lblServidor);
            this.tbpServidor.Controls.Add(this.txtServidor);
            this.tbpServidor.Location = new System.Drawing.Point(4, 22);
            this.tbpServidor.Name = "tbpServidor";
            this.tbpServidor.Padding = new System.Windows.Forms.Padding(3);
            this.tbpServidor.Size = new System.Drawing.Size(321, 229);
            this.tbpServidor.TabIndex = 0;
            this.tbpServidor.Text = "Configuraciones de conexión";
            this.tbpServidor.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(164, 185);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(123, 23);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Enabled = false;
            this.btnGuardar.Location = new System.Drawing.Point(31, 185);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(123, 23);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar configuración";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblContrasenia
            // 
            this.lblContrasenia.AutoSize = true;
            this.lblContrasenia.Location = new System.Drawing.Point(28, 137);
            this.lblContrasenia.Name = "lblContrasenia";
            this.lblContrasenia.Size = new System.Drawing.Size(64, 13);
            this.lblContrasenia.TabIndex = 7;
            this.lblContrasenia.Text = "Contraseña:";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(28, 105);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(46, 13);
            this.lblUsuario.TabIndex = 5;
            this.lblUsuario.Text = "Usuario:";
            // 
            // lblBbdd
            // 
            this.lblBbdd.AutoSize = true;
            this.lblBbdd.Location = new System.Drawing.Point(28, 67);
            this.lblBbdd.Name = "lblBbdd";
            this.lblBbdd.Size = new System.Drawing.Size(78, 13);
            this.lblBbdd.TabIndex = 3;
            this.lblBbdd.Text = "Base de datos:";
            // 
            // lblServidor
            // 
            this.lblServidor.AutoSize = true;
            this.lblServidor.Location = new System.Drawing.Point(28, 31);
            this.lblServidor.Name = "lblServidor";
            this.lblServidor.Size = new System.Drawing.Size(49, 13);
            this.lblServidor.TabIndex = 1;
            this.lblServidor.Text = "Servidor:";
            // 
            // tbpImagenFondo
            // 
            this.tbpImagenFondo.Controls.Add(this.btnAplicar);
            this.tbpImagenFondo.Controls.Add(this.btnExaminar);
            this.tbpImagenFondo.Controls.Add(this.pbxImagenFondo);
            this.tbpImagenFondo.Controls.Add(this.lblImagenFondo);
            this.tbpImagenFondo.Location = new System.Drawing.Point(4, 22);
            this.tbpImagenFondo.Name = "tbpImagenFondo";
            this.tbpImagenFondo.Padding = new System.Windows.Forms.Padding(3);
            this.tbpImagenFondo.Size = new System.Drawing.Size(321, 229);
            this.tbpImagenFondo.TabIndex = 1;
            this.tbpImagenFondo.Text = "Imagen de fondo";
            this.tbpImagenFondo.UseVisualStyleBackColor = true;
            // 
            // txtContrasenia
            // 
            this.txtContrasenia.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Articulos.Properties.Settings.Default, "contrasenia", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtContrasenia.Location = new System.Drawing.Point(110, 137);
            this.txtContrasenia.Name = "txtContrasenia";
            this.txtContrasenia.PasswordChar = '*';
            this.txtContrasenia.Size = new System.Drawing.Size(177, 20);
            this.txtContrasenia.TabIndex = 6;
            this.txtContrasenia.Text = global::Articulos.Properties.Settings.Default.contrasenia;
            this.txtContrasenia.TextChanged += new System.EventHandler(this.txtContrasenia_TextChanged);
            // 
            // txtUsuario
            // 
            this.txtUsuario.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Articulos.Properties.Settings.Default, "usuario", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtUsuario.Location = new System.Drawing.Point(110, 102);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(177, 20);
            this.txtUsuario.TabIndex = 4;
            this.txtUsuario.Text = global::Articulos.Properties.Settings.Default.usuario;
            this.txtUsuario.TextChanged += new System.EventHandler(this.txtUsuario_TextChanged);
            // 
            // txtBbdd
            // 
            this.txtBbdd.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Articulos.Properties.Settings.Default, "bbdd", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtBbdd.Location = new System.Drawing.Point(110, 67);
            this.txtBbdd.Name = "txtBbdd";
            this.txtBbdd.Size = new System.Drawing.Size(177, 20);
            this.txtBbdd.TabIndex = 2;
            this.txtBbdd.Text = global::Articulos.Properties.Settings.Default.bbdd;
            this.txtBbdd.TextChanged += new System.EventHandler(this.txtBbdd_TextChanged);
            // 
            // txtServidor
            // 
            this.txtServidor.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Articulos.Properties.Settings.Default, "servidor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtServidor.Location = new System.Drawing.Point(110, 31);
            this.txtServidor.Name = "txtServidor";
            this.txtServidor.Size = new System.Drawing.Size(177, 20);
            this.txtServidor.TabIndex = 0;
            this.txtServidor.Text = global::Articulos.Properties.Settings.Default.servidor;
            this.txtServidor.TextChanged += new System.EventHandler(this.txtServidor_TextChanged);
            // 
            // lblImagenFondo
            // 
            this.lblImagenFondo.AutoSize = true;
            this.lblImagenFondo.Location = new System.Drawing.Point(22, 8);
            this.lblImagenFondo.Name = "lblImagenFondo";
            this.lblImagenFondo.Size = new System.Drawing.Size(87, 13);
            this.lblImagenFondo.TabIndex = 0;
            this.lblImagenFondo.Text = "Imagen de fondo";
            // 
            // pbxImagenFondo
            // 
            this.pbxImagenFondo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbxImagenFondo.Location = new System.Drawing.Point(25, 32);
            this.pbxImagenFondo.Name = "pbxImagenFondo";
            this.pbxImagenFondo.Size = new System.Drawing.Size(136, 126);
            this.pbxImagenFondo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxImagenFondo.TabIndex = 1;
            this.pbxImagenFondo.TabStop = false;
            // 
            // btnExaminar
            // 
            this.btnExaminar.Location = new System.Drawing.Point(42, 180);
            this.btnExaminar.Name = "btnExaminar";
            this.btnExaminar.Size = new System.Drawing.Size(84, 27);
            this.btnExaminar.TabIndex = 2;
            this.btnExaminar.Text = "Examinar";
            this.btnExaminar.UseVisualStyleBackColor = true;
            this.btnExaminar.Click += new System.EventHandler(this.btnExaminar_Click);
            // 
            // btnAplicar
            // 
            this.btnAplicar.Location = new System.Drawing.Point(174, 180);
            this.btnAplicar.Name = "btnAplicar";
            this.btnAplicar.Size = new System.Drawing.Size(84, 27);
            this.btnAplicar.TabIndex = 3;
            this.btnAplicar.Text = "Aplicar";
            this.btnAplicar.UseVisualStyleBackColor = true;
            this.btnAplicar.Click += new System.EventHandler(this.btnAplicar_Click);
            // 
            // ParametrosDelSistema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 280);
            this.Controls.Add(this.tbcParametros);
            this.Name = "ParametrosDelSistema";
            this.Text = "ParametrosDelSistema";
            this.tbcParametros.ResumeLayout(false);
            this.tbpServidor.ResumeLayout(false);
            this.tbpServidor.PerformLayout();
            this.tbpImagenFondo.ResumeLayout(false);
            this.tbpImagenFondo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagenFondo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcParametros;
        private System.Windows.Forms.TabPage tbpServidor;
        private System.Windows.Forms.Label lblContrasenia;
        private System.Windows.Forms.TextBox txtContrasenia;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblBbdd;
        private System.Windows.Forms.TextBox txtBbdd;
        private System.Windows.Forms.Label lblServidor;
        private System.Windows.Forms.TextBox txtServidor;
        private System.Windows.Forms.TabPage tbpImagenFondo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAplicar;
        private System.Windows.Forms.Button btnExaminar;
        private System.Windows.Forms.PictureBox pbxImagenFondo;
        private System.Windows.Forms.Label lblImagenFondo;
    }
}