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
            this.mantenimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraciónDelServidorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirDelSistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuInventario.SuspendLayout();
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
            this.listaDeArtículosToolStripMenuItem});
            this.artículosToolStripMenuItem.Name = "artículosToolStripMenuItem";
            this.artículosToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.artículosToolStripMenuItem.Text = "Artículos";
            // 
            // nuevoArtículoToolStripMenuItem
            // 
            this.nuevoArtículoToolStripMenuItem.Name = "nuevoArtículoToolStripMenuItem";
            this.nuevoArtículoToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.nuevoArtículoToolStripMenuItem.Text = "Nuevo artículo";
            this.nuevoArtículoToolStripMenuItem.Click += new System.EventHandler(this.nuevoArtículoToolStripMenuItem_Click);
            // 
            // listaDeArtículosToolStripMenuItem
            // 
            this.listaDeArtículosToolStripMenuItem.Name = "listaDeArtículosToolStripMenuItem";
            this.listaDeArtículosToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.listaDeArtículosToolStripMenuItem.Text = "Lista de artículos";
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
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
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
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 262);
            this.Controls.Add(this.MenuInventario);
            this.MainMenuStrip = this.MenuInventario;
            this.Name = "Menu";
            this.Text = "Inventario ISP20";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Menu_FormClosing);
            this.MenuInventario.ResumeLayout(false);
            this.MenuInventario.PerformLayout();
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
    }
}

