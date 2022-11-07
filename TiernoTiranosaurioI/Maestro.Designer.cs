namespace TiernoTiranosaurioI
{
    partial class Menú
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menú));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsOperaciones = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsVentas = new System.Windows.Forms.ToolStripMenuItem();
            this.tsCotizacion = new System.Windows.Forms.ToolStripMenuItem();
            this.tsFactura = new System.Windows.Forms.ToolStripMenuItem();
            this.tsInforme = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porCódigoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.porNombreToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pbDino = new System.Windows.Forms.PictureBox();
            this.panelVerde = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDino)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcionesToolStripMenuItem,
            this.archivoToolStripMenuItem,
            this.consultarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(993, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsSalir});
            this.opcionesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("opcionesToolStripMenuItem.Image")));
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.opcionesToolStripMenuItem.Text = "Opciones";
            // 
            // tsSalir
            // 
            this.tsSalir.Image = ((System.Drawing.Image)(resources.GetObject("tsSalir.Image")));
            this.tsSalir.Name = "tsSalir";
            this.tsSalir.Size = new System.Drawing.Size(96, 22);
            this.tsSalir.Text = "Salir";
            this.tsSalir.Click += new System.EventHandler(this.tsSalir_Click);
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsOperaciones,
            this.toolStripSeparator1,
            this.tsVentas});
            this.archivoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("archivoToolStripMenuItem.Image")));
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // tsOperaciones
            // 
            this.tsOperaciones.Image = ((System.Drawing.Image)(resources.GetObject("tsOperaciones.Image")));
            this.tsOperaciones.Name = "tsOperaciones";
            this.tsOperaciones.Size = new System.Drawing.Size(180, 22);
            this.tsOperaciones.Text = "Operaciones";
            this.tsOperaciones.Click += new System.EventHandler(this.tsOperaciones_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // tsVentas
            // 
            this.tsVentas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsCotizacion,
            this.tsFactura,
            this.tsInforme});
            this.tsVentas.Image = ((System.Drawing.Image)(resources.GetObject("tsVentas.Image")));
            this.tsVentas.Name = "tsVentas";
            this.tsVentas.Size = new System.Drawing.Size(180, 22);
            this.tsVentas.Text = "Módulo ventas";
            // 
            // tsCotizacion
            // 
            this.tsCotizacion.Image = ((System.Drawing.Image)(resources.GetObject("tsCotizacion.Image")));
            this.tsCotizacion.Name = "tsCotizacion";
            this.tsCotizacion.Size = new System.Drawing.Size(153, 22);
            this.tsCotizacion.Text = "Cotización";
            // 
            // tsFactura
            // 
            this.tsFactura.Image = ((System.Drawing.Image)(resources.GetObject("tsFactura.Image")));
            this.tsFactura.Name = "tsFactura";
            this.tsFactura.Size = new System.Drawing.Size(153, 22);
            this.tsFactura.Text = "Factura";
            // 
            // tsInforme
            // 
            this.tsInforme.Image = ((System.Drawing.Image)(resources.GetObject("tsInforme.Image")));
            this.tsInforme.Name = "tsInforme";
            this.tsInforme.Size = new System.Drawing.Size(153, 22);
            this.tsInforme.Text = "Informe ventas";
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.porCódigoToolStripMenuItem1,
            this.porNombreToolStripMenuItem1});
            this.consultarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("consultarToolStripMenuItem.Image")));
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.consultarToolStripMenuItem.Text = "Consultar";
            // 
            // porCódigoToolStripMenuItem1
            // 
            this.porCódigoToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("porCódigoToolStripMenuItem1.Image")));
            this.porCódigoToolStripMenuItem1.Name = "porCódigoToolStripMenuItem1";
            this.porCódigoToolStripMenuItem1.Size = new System.Drawing.Size(137, 22);
            this.porCódigoToolStripMenuItem1.Text = "Por código";
            this.porCódigoToolStripMenuItem1.Click += new System.EventHandler(this.porCódigoToolStripMenuItem1_Click);
            // 
            // porNombreToolStripMenuItem1
            // 
            this.porNombreToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("porNombreToolStripMenuItem1.Image")));
            this.porNombreToolStripMenuItem1.Name = "porNombreToolStripMenuItem1";
            this.porNombreToolStripMenuItem1.Size = new System.Drawing.Size(137, 22);
            this.porNombreToolStripMenuItem1.Text = "Por nombre";
            this.porNombreToolStripMenuItem1.Click += new System.EventHandler(this.porNombreToolStripMenuItem1_Click);
            // 
            // pbDino
            // 
            this.pbDino.Image = ((System.Drawing.Image)(resources.GetObject("pbDino.Image")));
            this.pbDino.Location = new System.Drawing.Point(361, 150);
            this.pbDino.Name = "pbDino";
            this.pbDino.Size = new System.Drawing.Size(284, 248);
            this.pbDino.TabIndex = 1;
            this.pbDino.TabStop = false;
            // 
            // panelVerde
            // 
            this.panelVerde.BackColor = System.Drawing.Color.DarkGreen;
            this.panelVerde.Location = new System.Drawing.Point(0, 484);
            this.panelVerde.Name = "panelVerde";
            this.panelVerde.Size = new System.Drawing.Size(993, 134);
            this.panelVerde.TabIndex = 2;
            // 
            // Menú
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 618);
            this.Controls.Add(this.panelVerde);
            this.Controls.Add(this.pbDino);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menú";
            this.Text = "Menú";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDino)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsSalir;
        private System.Windows.Forms.ToolStripMenuItem tsOperaciones;
        private System.Windows.Forms.ToolStripMenuItem tsVentas;
        private System.Windows.Forms.ToolStripMenuItem tsCotizacion;
        private System.Windows.Forms.ToolStripMenuItem tsFactura;
        private System.Windows.Forms.ToolStripMenuItem tsInforme;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porCódigoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem porNombreToolStripMenuItem1;
        private System.Windows.Forms.PictureBox pbDino;
        private System.Windows.Forms.Panel panelVerde;
    }
}