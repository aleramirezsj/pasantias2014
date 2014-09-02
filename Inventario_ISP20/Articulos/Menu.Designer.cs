namespace Articulos
{
    partial class Menu
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
            this.MenuInventario = new System.Windows.Forms.MenuStrip();
            this.artículosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoArtículoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeArtículosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarArtículoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoArtículoClaseMiWebCamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraciónDelServidorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirDelSistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stsBarraEstado = new System.Windows.Forms.StatusStrip();
            this.tslMensajeBarraEstado = new System.Windows.Forms.ToolStripStatusLabel();
            this.pbxImagenFondo = new System.Windows.Forms.PictureBox();
            this.MenuInventario.SuspendLayout();
            this.stsBarraEstado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagenFondo)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuInventario
            // 
            this.MenuInventario.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.artículosToolStripMenuItem,
            this.mantenimientoToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.MenuInventario.Location = new System.Drawing.Point(0, 0);
            this.MenuInventario.Name = "MenuInventario";
            this.MenuInventario.Size = new System.Drawing.Size(478, 24);
            this.MenuInventario.TabIndex = 0;
            this.MenuInventario.Text = "menuInventario";
            // 
            // artículosToolStripMenuItem
            // 
            this.artículosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoArtículoToolStripMenuItem,
            this.listaDeArtículosToolStripMenuItem,
            this.editarArtículoToolStripMenuItem,
            this.nuevoArtículoClaseMiWebCamToolStripMenuItem,
            this.toolStripMenuItem1});
            this.artículosToolStripMenuItem.Name = "artículosToolStripMenuItem";
            this.artículosToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.artículosToolStripMenuItem.Text = "Artículos";
            // 
            // nuevoArtículoToolStripMenuItem
            // 
            this.nuevoArtículoToolStripMenuItem.Name = "nuevoArtículoToolStripMenuItem";
            this.nuevoArtículoToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
            this.nuevoArtículoToolStripMenuItem.Text = "Nuevo artículo";
            this.nuevoArtículoToolStripMenuItem.Click += new System.EventHandler(this.nuevoArtículoToolStripMenuItem_Click);
            // 
            // listaDeArtículosToolStripMenuItem
            // 
            this.listaDeArtículosToolStripMenuItem.Name = "listaDeArtículosToolStripMenuItem";
            this.listaDeArtículosToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
            this.listaDeArtículosToolStripMenuItem.Text = "Lista de artículos";
            this.listaDeArtículosToolStripMenuItem.Click += new System.EventHandler(this.listaDeArtículosToolStripMenuItem_Click);
            // 
            // editarArtículoToolStripMenuItem
            // 
            this.editarArtículoToolStripMenuItem.Name = "editarArtículoToolStripMenuItem";
            this.editarArtículoToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
            this.editarArtículoToolStripMenuItem.Text = "Editar artículo";
            this.editarArtículoToolStripMenuItem.Click += new System.EventHandler(this.editarArtículoToolStripMenuItem_Click);
            // 
            // nuevoArtículoClaseMiWebCamToolStripMenuItem
            // 
            this.nuevoArtículoClaseMiWebCamToolStripMenuItem.Name = "nuevoArtículoClaseMiWebCamToolStripMenuItem";
            this.nuevoArtículoClaseMiWebCamToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
            this.nuevoArtículoClaseMiWebCamToolStripMenuItem.Text = "Nuevo artículo - Clase MiWebCam";
            this.nuevoArtículoClaseMiWebCamToolStripMenuItem.Click += new System.EventHandler(this.nuevoArtículoClaseMiWebCamToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(257, 22);
            this.toolStripMenuItem1.Text = "Editar artículo - Clase MiWebCam";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // mantenimientoToolStripMenuItem
            // 
            this.mantenimientoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configuraciónDelServidorToolStripMenuItem});
            this.mantenimientoToolStripMenuItem.Name = "mantenimientoToolStripMenuItem";
            this.mantenimientoToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.mantenimientoToolStripMenuItem.Text = "Mantenimiento";
            // 
            // configuraciónDelServidorToolStripMenuItem
            // 
            this.configuraciónDelServidorToolStripMenuItem.Name = "configuraciónDelServidorToolStripMenuItem";
            this.configuraciónDelServidorToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.configuraciónDelServidorToolStripMenuItem.Text = "Configuración del servidor";
            this.configuraciónDelServidorToolStripMenuItem.Click += new System.EventHandler(this.configuraciónDelServidorToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirDelSistemaToolStripMenuItem,
            this.acercaDeToolStripMenuItem});
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.salirToolStripMenuItem.Text = "Salir...";
            // 
            // salirDelSistemaToolStripMenuItem
            // 
            this.salirDelSistemaToolStripMenuItem.Name = "salirDelSistemaToolStripMenuItem";
            this.salirDelSistemaToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.salirDelSistemaToolStripMenuItem.Text = "Salir del sistema";
            this.salirDelSistemaToolStripMenuItem.Click += new System.EventHandler(this.salirDelSistemaToolStripMenuItem_Click);
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.acercaDeToolStripMenuItem.Text = "Acerca de...";
            // 
            // stsBarraEstado
            // 
            this.stsBarraEstado.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslMensajeBarraEstado});
            this.stsBarraEstado.Location = new System.Drawing.Point(0, 240);
            this.stsBarraEstado.Name = "stsBarraEstado";
            this.stsBarraEstado.Size = new System.Drawing.Size(478, 22);
            this.stsBarraEstado.TabIndex = 1;
            // 
            // tslMensajeBarraEstado
            // 
            this.tslMensajeBarraEstado.Name = "tslMensajeBarraEstado";
            this.tslMensajeBarraEstado.Size = new System.Drawing.Size(0, 17);
            // 
            // pbxImagenFondo
            // 
            this.pbxImagenFondo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbxImagenFondo.Location = new System.Drawing.Point(0, 24);
            this.pbxImagenFondo.Name = "pbxImagenFondo";
            this.pbxImagenFondo.Size = new System.Drawing.Size(478, 216);
            this.pbxImagenFondo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxImagenFondo.TabIndex = 2;
            this.pbxImagenFondo.TabStop = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 262);
            this.Controls.Add(this.pbxImagenFondo);
            this.Controls.Add(this.stsBarraEstado);
            this.Controls.Add(this.MenuInventario);
            this.MainMenuStrip = this.MenuInventario;
            this.Name = "Menu";
            this.Text = "Inventario ISP20";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Menu_FormClosing);
            this.Shown += new System.EventHandler(this.Menu_Shown);
            this.MenuInventario.ResumeLayout(false);
            this.MenuInventario.PerformLayout();
            this.stsBarraEstado.ResumeLayout(false);
            this.stsBarraEstado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagenFondo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuInventario;
        private System.Windows.Forms.ToolStripMenuItem artículosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoArtículoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDeArtículosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirDelSistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuraciónDelServidorToolStripMenuItem;
        private System.Windows.Forms.StatusStrip stsBarraEstado;
        private System.Windows.Forms.ToolStripStatusLabel tslMensajeBarraEstado;
        private System.Windows.Forms.PictureBox pbxImagenFondo;
        private System.Windows.Forms.ToolStripMenuItem editarArtículoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoArtículoClaseMiWebCamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}

