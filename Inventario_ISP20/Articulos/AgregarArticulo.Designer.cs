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
            this.txtdetalle = new System.Windows.Forms.TextBox();
            this.lblDetalle = new System.Windows.Forms.Label();
            this.lblObservaciones = new System.Windows.Forms.Label();
            this.txtobservaciones = new System.Windows.Forms.TextBox();
            this.btnguardar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.lbllargo = new System.Windows.Forms.Label();
            this.nudlargo = new System.Windows.Forms.NumericUpDown();
            this.mtbancho = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudlargo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtdetalle
            // 
            this.txtdetalle.Location = new System.Drawing.Point(115, 22);
            this.txtdetalle.Name = "txtdetalle";
            this.txtdetalle.Size = new System.Drawing.Size(203, 20);
            this.txtdetalle.TabIndex = 0;
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
            // txtobservaciones
            // 
            this.txtobservaciones.Location = new System.Drawing.Point(115, 60);
            this.txtobservaciones.Multiline = true;
            this.txtobservaciones.Name = "txtobservaciones";
            this.txtobservaciones.Size = new System.Drawing.Size(203, 55);
            this.txtobservaciones.TabIndex = 2;
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(88, 205);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(75, 23);
            this.btnguardar.TabIndex = 4;
            this.btnguardar.Text = "&Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(190, 205);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(75, 23);
            this.btncancelar.TabIndex = 5;
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
            // nudlargo
            // 
            this.nudlargo.DecimalPlaces = 2;
            this.nudlargo.Location = new System.Drawing.Point(115, 137);
            this.nudlargo.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudlargo.Name = "nudlargo";
            this.nudlargo.Size = new System.Drawing.Size(120, 20);
            this.nudlargo.TabIndex = 8;
            // 
            // mtbancho
            // 
            this.mtbancho.Location = new System.Drawing.Point(115, 173);
            this.mtbancho.Mask = "99.99";
            this.mtbancho.Name = "mtbancho";
            this.mtbancho.Size = new System.Drawing.Size(120, 20);
            this.mtbancho.TabIndex = 9;
            this.mtbancho.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            this.mtbancho.Leave += new System.EventHandler(this.maskedTextBox1_Leave);
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
            // AgregarArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 262);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mtbancho);
            this.Controls.Add(this.nudlargo);
            this.Controls.Add(this.lbllargo);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.lblObservaciones);
            this.Controls.Add(this.txtobservaciones);
            this.Controls.Add(this.lblDetalle);
            this.Controls.Add(this.txtdetalle);
            this.Name = "AgregarArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Articulo";
            ((System.ComponentModel.ISupportInitialize)(this.nudlargo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtdetalle;
        private System.Windows.Forms.Label lblDetalle;
        private System.Windows.Forms.Label lblObservaciones;
        private System.Windows.Forms.TextBox txtobservaciones;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Label lbllargo;
        private System.Windows.Forms.NumericUpDown nudlargo;
        private System.Windows.Forms.MaskedTextBox mtbancho;
        private System.Windows.Forms.Label label1;
    }
}