namespace TiernoTiranosaurioI
{
    partial class ImpresionCotizacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImpresionCotizacion));
            this.btSalir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbilustracion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txDatosMascota = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txDatosUsuario = new System.Windows.Forms.TextBox();
            this.lbFecha = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btSalir
            // 
            resources.ApplyResources(this.btSalir, "btSalir");
            this.btSalir.Name = "btSalir";
            this.btSalir.UseVisualStyleBackColor = true;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // lbilustracion
            // 
            this.lbilustracion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.lbilustracion, "lbilustracion");
            this.lbilustracion.Name = "lbilustracion";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txDatosMascota
            // 
            this.txDatosMascota.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txDatosMascota.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.txDatosMascota, "txDatosMascota");
            this.txDatosMascota.Name = "txDatosMascota";
            this.txDatosMascota.TextChanged += new System.EventHandler(this.txDatosMascota_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lbFecha);
            this.panel1.Controls.Add(this.txDatosUsuario);
            this.panel1.Controls.Add(this.txDatosMascota);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lbilustracion);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // txDatosUsuario
            // 
            this.txDatosUsuario.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txDatosUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.txDatosUsuario, "txDatosUsuario");
            this.txDatosUsuario.Name = "txDatosUsuario";
            // 
            // lbFecha
            // 
            resources.ApplyResources(this.lbFecha, "lbFecha");
            this.lbFecha.Name = "lbFecha";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // ImpresionCotizacion
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.panel1);
            this.Name = "ImpresionCotizacion";
            this.Load += new System.EventHandler(this.ImpresionCotizacion_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btSalir;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox lbilustracion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txDatosMascota;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.TextBox txDatosUsuario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbFecha;
    }
}