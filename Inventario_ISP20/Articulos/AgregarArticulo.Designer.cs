﻿namespace Articulos
{
    partial class AgregarArticulo
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
            this.components = new System.ComponentModel.Container();
            this.txtDetalle = new System.Windows.Forms.TextBox();
            this.lblDetalle = new System.Windows.Forms.Label();
            this.lblObservaciones = new System.Windows.Forms.Label();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.btnguardar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.lbllargo = new System.Windows.Forms.Label();
            this.nudLargo = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nudAncho = new System.Windows.Forms.NumericUpDown();
            this.pbxImagenArticulo = new System.Windows.Forms.PictureBox();
            this.btnExaminar = new System.Windows.Forms.Button();
            this.pbxWebcam = new System.Windows.Forms.PictureBox();
            this.btnIniciarCamara = new System.Windows.Forms.Button();
            this.btnCapturarFoto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudLargo)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAncho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagenArticulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxWebcam)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDetalle
            // 
            this.txtDetalle.Location = new System.Drawing.Point(115, 22);
            this.txtDetalle.Name = "txtDetalle";
            this.txtDetalle.Size = new System.Drawing.Size(203, 20);
            this.txtDetalle.TabIndex = 0;
            this.txtDetalle.TextChanged += new System.EventHandler(this.txtdetalle_TextChanged);
            this.txtDetalle.Enter += new System.EventHandler(this.txtdetalle_Enter);
            this.txtDetalle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdetalle_KeyPress);
            // 
            // lblDetalle
            // 
            this.lblDetalle.AutoSize = true;
            this.lblDetalle.Location = new System.Drawing.Point(33, 22);
            this.lblDetalle.Name = "lblDetalle";
            this.lblDetalle.Size = new System.Drawing.Size(43, 13);
            this.lblDetalle.TabIndex = 1;
            this.lblDetalle.Text = "Detalle:";
            // 
            // lblObservaciones
            // 
            this.lblObservaciones.AutoSize = true;
            this.lblObservaciones.Location = new System.Drawing.Point(33, 60);
            this.lblObservaciones.Name = "lblObservaciones";
            this.lblObservaciones.Size = new System.Drawing.Size(81, 13);
            this.lblObservaciones.TabIndex = 3;
            this.lblObservaciones.Text = "Observaciones:";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(115, 60);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(203, 55);
            this.txtObservaciones.TabIndex = 2;
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(83, 227);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(75, 23);
            this.btnguardar.TabIndex = 5;
            this.btnguardar.Text = "&Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(185, 227);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(75, 23);
            this.btncancelar.TabIndex = 6;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            // 
            // lbllargo
            // 
            this.lbllargo.AutoSize = true;
            this.lbllargo.Location = new System.Drawing.Point(33, 137);
            this.lbllargo.Name = "lbllargo";
            this.lbllargo.Size = new System.Drawing.Size(59, 13);
            this.lbllargo.TabIndex = 6;
            this.lbllargo.Text = "Largo(mts):";
            // 
            // nudLargo
            // 
            this.nudLargo.DecimalPlaces = 2;
            this.nudLargo.Location = new System.Drawing.Point(115, 137);
            this.nudLargo.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudLargo.Name = "nudLargo";
            this.nudLargo.Size = new System.Drawing.Size(120, 20);
            this.nudLargo.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Ancho(mts):";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(97, 26);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // nudAncho
            // 
            this.nudAncho.DecimalPlaces = 2;
            this.nudAncho.Location = new System.Drawing.Point(115, 176);
            this.nudAncho.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudAncho.Name = "nudAncho";
            this.nudAncho.Size = new System.Drawing.Size(120, 20);
            this.nudAncho.TabIndex = 11;
            // 
            // pbxImagenArticulo
            // 
            this.pbxImagenArticulo.Location = new System.Drawing.Point(548, 22);
            this.pbxImagenArticulo.Name = "pbxImagenArticulo";
            this.pbxImagenArticulo.Size = new System.Drawing.Size(127, 106);
            this.pbxImagenArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxImagenArticulo.TabIndex = 12;
            this.pbxImagenArticulo.TabStop = false;
            // 
            // btnExaminar
            // 
            this.btnExaminar.Location = new System.Drawing.Point(577, 155);
            this.btnExaminar.Name = "btnExaminar";
            this.btnExaminar.Size = new System.Drawing.Size(75, 23);
            this.btnExaminar.TabIndex = 13;
            this.btnExaminar.Text = "Examinar";
            this.btnExaminar.UseVisualStyleBackColor = true;
            this.btnExaminar.Click += new System.EventHandler(this.btnExaminar_Click);
            // 
            // pbxWebcam
            // 
            this.pbxWebcam.Location = new System.Drawing.Point(362, 22);
            this.pbxWebcam.Name = "pbxWebcam";
            this.pbxWebcam.Size = new System.Drawing.Size(127, 106);
            this.pbxWebcam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxWebcam.TabIndex = 14;
            this.pbxWebcam.TabStop = false;
            // 
            // btnIniciarCamara
            // 
            this.btnIniciarCamara.Location = new System.Drawing.Point(376, 155);
            this.btnIniciarCamara.Name = "btnIniciarCamara";
            this.btnIniciarCamara.Size = new System.Drawing.Size(103, 23);
            this.btnIniciarCamara.TabIndex = 15;
            this.btnIniciarCamara.Text = "Iniciar cámara";
            this.btnIniciarCamara.UseVisualStyleBackColor = true;
            this.btnIniciarCamara.Click += new System.EventHandler(this.btnIniciarCamara_Click);
            // 
            // btnCapturarFoto
            // 
            this.btnCapturarFoto.Location = new System.Drawing.Point(376, 184);
            this.btnCapturarFoto.Name = "btnCapturarFoto";
            this.btnCapturarFoto.Size = new System.Drawing.Size(103, 23);
            this.btnCapturarFoto.TabIndex = 16;
            this.btnCapturarFoto.Text = "Capturar Foto";
            this.btnCapturarFoto.UseVisualStyleBackColor = true;
            this.btnCapturarFoto.Visible = false;
            this.btnCapturarFoto.Click += new System.EventHandler(this.btnCapturarFoto_Click);
            // 
            // AgregarArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 368);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.btnCapturarFoto);
            this.Controls.Add(this.btnIniciarCamara);
            this.Controls.Add(this.pbxWebcam);
            this.Controls.Add(this.nudAncho);
            this.Controls.Add(this.btnExaminar);
            this.Controls.Add(this.pbxImagenArticulo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudLargo);
            this.Controls.Add(this.lbllargo);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.lblObservaciones);
            this.Controls.Add(this.txtObservaciones);
            this.Controls.Add(this.lblDetalle);
            this.Controls.Add(this.txtDetalle);
            this.Name = "AgregarArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Articulo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AgregarArticulo_FormClosing);
            this.Load += new System.EventHandler(this.AgregarArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudLargo)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudAncho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagenArticulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxWebcam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDetalle;
        private System.Windows.Forms.Label lblDetalle;
        private System.Windows.Forms.Label lblObservaciones;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Label lbllargo;
        private System.Windows.Forms.NumericUpDown nudLargo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.NumericUpDown nudAncho;
        private System.Windows.Forms.PictureBox pbxImagenArticulo;
        private System.Windows.Forms.Button btnExaminar;
        private System.Windows.Forms.PictureBox pbxWebcam;
        private System.Windows.Forms.Button btnIniciarCamara;
        private System.Windows.Forms.Button btnCapturarFoto;
    }
}