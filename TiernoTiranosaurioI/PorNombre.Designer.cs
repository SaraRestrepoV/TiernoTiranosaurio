namespace TiernoTiranosaurioI
{
    partial class PorNombre
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PorNombre));
            this.cbEspecie = new System.Windows.Forms.ComboBox();
            this.txCodigo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txCantidad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txPrecio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbNombre = new System.Windows.Forms.ComboBox();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btSalir = new System.Windows.Forms.Button();
            this.btBorrar = new System.Windows.Forms.Button();
            this.btBuscar = new System.Windows.Forms.Button();
            this.tIERNOTIRANOSAURIODataSet = new TiernoTiranosaurioI.TIERNOTIRANOSAURIODataSet();
            this.eSPECIEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eSPECIETableAdapter = new TiernoTiranosaurioI.TIERNOTIRANOSAURIODataSetTableAdapters.ESPECIETableAdapter();
            this.fKMASCOTASESPECI30F848EDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mASCOTASTableAdapter = new TiernoTiranosaurioI.TIERNOTIRANOSAURIODataSetTableAdapters.MASCOTASTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tIERNOTIRANOSAURIODataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eSPECIEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKMASCOTASESPECI30F848EDBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cbEspecie
            // 
            this.cbEspecie.DataSource = this.eSPECIEBindingSource;
            this.cbEspecie.DisplayMember = "NOMBRE";
            this.cbEspecie.Location = new System.Drawing.Point(568, 28);
            this.cbEspecie.Name = "cbEspecie";
            this.cbEspecie.Size = new System.Drawing.Size(162, 21);
            this.cbEspecie.TabIndex = 53;
            this.cbEspecie.ValueMember = "NOMBRE";
            // 
            // txCodigo
            // 
            this.txCodigo.Enabled = false;
            this.txCodigo.Location = new System.Drawing.Point(568, 325);
            this.txCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.txCodigo.Name = "txCodigo";
            this.txCodigo.Size = new System.Drawing.Size(171, 20);
            this.txCodigo.TabIndex = 67;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label7.Location = new System.Drawing.Point(462, 317);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 24);
            this.label7.TabIndex = 66;
            this.label7.Text = "Código:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label6.Location = new System.Drawing.Point(462, 25);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 24);
            this.label6.TabIndex = 64;
            this.label6.Text = "Especie:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Honeydew;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(8, -69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(376, 589);
            this.panel1.TabIndex = 54;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(27, 347);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Consulta de animales por código";
            // 
            // txCantidad
            // 
            this.txCantidad.Enabled = false;
            this.txCantidad.Location = new System.Drawing.Point(568, 401);
            this.txCantidad.Margin = new System.Windows.Forms.Padding(4);
            this.txCantidad.Name = "txCantidad";
            this.txCantidad.Size = new System.Drawing.Size(171, 20);
            this.txCantidad.TabIndex = 60;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label5.Location = new System.Drawing.Point(453, 393);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 24);
            this.label5.TabIndex = 59;
            this.label5.Text = "Cantidad:";
            // 
            // txPrecio
            // 
            this.txPrecio.Enabled = false;
            this.txPrecio.Location = new System.Drawing.Point(568, 363);
            this.txPrecio.Margin = new System.Windows.Forms.Padding(4);
            this.txPrecio.Name = "txPrecio";
            this.txPrecio.Size = new System.Drawing.Size(171, 20);
            this.txPrecio.TabIndex = 58;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label4.Location = new System.Drawing.Point(480, 355);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 24);
            this.label4.TabIndex = 57;
            this.label4.Text = "Precio:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.Location = new System.Drawing.Point(465, 62);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 24);
            this.label3.TabIndex = 68;
            this.label3.Text = "Nombre:";
            // 
            // cbNombre
            // 
            this.cbNombre.DataSource = this.fKMASCOTASESPECI30F848EDBindingSource;
            this.cbNombre.DisplayMember = "NOMBRE";
            this.cbNombre.Location = new System.Drawing.Point(568, 65);
            this.cbNombre.Name = "cbNombre";
            this.cbNombre.Size = new System.Drawing.Size(162, 21);
            this.cbNombre.TabIndex = 69;
            this.cbNombre.ValueMember = "NOMBRE";
            // 
            // pbFoto
            // 
            this.pbFoto.Location = new System.Drawing.Point(446, 116);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(323, 177);
            this.pbFoto.TabIndex = 65;
            this.pbFoto.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TiernoTiranosaurioI.Properties.Resources.Diseño_sin_título__4__removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(81, 143);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(181, 159);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btSalir
            // 
            this.btSalir.Image = ((System.Drawing.Image)(resources.GetObject("btSalir.Image")));
            this.btSalir.Location = new System.Drawing.Point(686, 451);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(114, 39);
            this.btSalir.TabIndex = 63;
            this.btSalir.UseVisualStyleBackColor = true;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // btBorrar
            // 
            this.btBorrar.Image = ((System.Drawing.Image)(resources.GetObject("btBorrar.Image")));
            this.btBorrar.Location = new System.Drawing.Point(554, 451);
            this.btBorrar.Name = "btBorrar";
            this.btBorrar.Size = new System.Drawing.Size(114, 39);
            this.btBorrar.TabIndex = 62;
            this.btBorrar.UseVisualStyleBackColor = true;
            this.btBorrar.Click += new System.EventHandler(this.btBorrar_Click);
            // 
            // btBuscar
            // 
            this.btBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btBuscar.Image")));
            this.btBuscar.Location = new System.Drawing.Point(423, 451);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(116, 39);
            this.btBuscar.TabIndex = 61;
            this.btBuscar.UseVisualStyleBackColor = true;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // tIERNOTIRANOSAURIODataSet
            // 
            this.tIERNOTIRANOSAURIODataSet.DataSetName = "TIERNOTIRANOSAURIODataSet";
            this.tIERNOTIRANOSAURIODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eSPECIEBindingSource
            // 
            this.eSPECIEBindingSource.DataMember = "ESPECIE";
            this.eSPECIEBindingSource.DataSource = this.tIERNOTIRANOSAURIODataSet;
            // 
            // eSPECIETableAdapter
            // 
            this.eSPECIETableAdapter.ClearBeforeFill = true;
            // 
            // fKMASCOTASESPECI30F848EDBindingSource
            // 
            this.fKMASCOTASESPECI30F848EDBindingSource.DataMember = "FK__MASCOTAS__ESPECI__30F848ED";
            this.fKMASCOTASESPECI30F848EDBindingSource.DataSource = this.eSPECIEBindingSource;
            // 
            // mASCOTASTableAdapter
            // 
            this.mASCOTASTableAdapter.ClearBeforeFill = true;
            // 
            // PorNomb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(833, 506);
            this.Controls.Add(this.cbNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbEspecie);
            this.Controls.Add(this.txCodigo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pbFoto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.btBorrar);
            this.Controls.Add(this.btBuscar);
            this.Controls.Add(this.txCantidad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txPrecio);
            this.Controls.Add(this.label4);
            this.Name = "PorNomb";
            this.Text = "PorNomb";
            this.Load += new System.EventHandler(this.PorNomb_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tIERNOTIRANOSAURIODataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eSPECIEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKMASCOTASESPECI30F848EDBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbEspecie;
        private System.Windows.Forms.TextBox txCodigo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pbFoto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btSalir;
        private System.Windows.Forms.Button btBorrar;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.TextBox txCantidad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txPrecio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbNombre;
        private TIERNOTIRANOSAURIODataSet tIERNOTIRANOSAURIODataSet;
        private System.Windows.Forms.BindingSource eSPECIEBindingSource;
        private TIERNOTIRANOSAURIODataSetTableAdapters.ESPECIETableAdapter eSPECIETableAdapter;
        private System.Windows.Forms.BindingSource fKMASCOTASESPECI30F848EDBindingSource;
        private TIERNOTIRANOSAURIODataSetTableAdapters.MASCOTASTableAdapter mASCOTASTableAdapter;
    }
}