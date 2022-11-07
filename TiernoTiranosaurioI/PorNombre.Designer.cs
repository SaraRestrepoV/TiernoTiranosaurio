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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btSalir = new System.Windows.Forms.Button();
            this.btBorrar = new System.Windows.Forms.Button();
            this.btBuscar = new System.Windows.Forms.Button();
            this.txPrecio = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txCodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbEspecie = new System.Windows.Forms.ComboBox();
            this.cbNombre = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tIERNOTIRANOSAURIODataSet1 = new TiernoTiranosaurioI.TIERNOTIRANOSAURIODataSet1();
            this.eSPECIEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eSPECIETableAdapter = new TiernoTiranosaurioI.TIERNOTIRANOSAURIODataSet1TableAdapters.ESPECIETableAdapter();
            this.fKMASCOTASESPECI4316F928BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mASCOTASTableAdapter = new TiernoTiranosaurioI.TIERNOTIRANOSAURIODataSet1TableAdapters.MASCOTASTableAdapter();
            this.fKIDMASCOTADETALLEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dETALLE_FACTURATableAdapter = new TiernoTiranosaurioI.TIERNOTIRANOSAURIODataSet1TableAdapters.DETALLE_FACTURATableAdapter();
            this.fKMASCOTASESPECI4316F928BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.txCantidad = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tIERNOTIRANOSAURIODataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eSPECIEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKMASCOTASESPECI4316F928BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKIDMASCOTADETALLEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKMASCOTASESPECI4316F928BindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Honeydew;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(376, 589);
            this.panel1.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Quicksand", 16F);
            this.label1.Location = new System.Drawing.Point(9, 347);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(356, 33);
            this.label1.TabIndex = 3;
            this.label1.Text = "Consulta de animales por nombre";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TiernoTiranosaurioI.Properties.Resources.Diseño_sin_título__4__removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(102, 154);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(181, 159);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btSalir
            // 
            this.btSalir.Image = ((System.Drawing.Image)(resources.GetObject("btSalir.Image")));
            this.btSalir.Location = new System.Drawing.Point(674, 508);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(114, 39);
            this.btSalir.TabIndex = 31;
            this.btSalir.UseVisualStyleBackColor = true;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // btBorrar
            // 
            this.btBorrar.Image = ((System.Drawing.Image)(resources.GetObject("btBorrar.Image")));
            this.btBorrar.Location = new System.Drawing.Point(542, 508);
            this.btBorrar.Name = "btBorrar";
            this.btBorrar.Size = new System.Drawing.Size(114, 39);
            this.btBorrar.TabIndex = 30;
            this.btBorrar.UseVisualStyleBackColor = true;
            this.btBorrar.Click += new System.EventHandler(this.btBorrar_Click);
            // 
            // btBuscar
            // 
            this.btBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btBuscar.Image")));
            this.btBuscar.Location = new System.Drawing.Point(411, 508);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(116, 39);
            this.btBuscar.TabIndex = 29;
            this.btBuscar.UseVisualStyleBackColor = true;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // txPrecio
            // 
            this.txPrecio.Location = new System.Drawing.Point(563, 403);
            this.txPrecio.Margin = new System.Windows.Forms.Padding(4);
            this.txPrecio.Name = "txPrecio";
            this.txPrecio.Size = new System.Drawing.Size(171, 20);
            this.txPrecio.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Quicksand", 14F);
            this.label5.Location = new System.Drawing.Point(460, 395);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 28);
            this.label5.TabIndex = 27;
            this.label5.Text = "Precio:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Quicksand", 14F);
            this.label3.Location = new System.Drawing.Point(457, 39);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 28);
            this.label3.TabIndex = 23;
            this.label3.Text = "Especie:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txCodigo
            // 
            this.txCodigo.Location = new System.Drawing.Point(563, 348);
            this.txCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.txCodigo.Name = "txCodigo";
            this.txCodigo.Size = new System.Drawing.Size(171, 20);
            this.txCodigo.TabIndex = 22;
            this.txCodigo.TextChanged += new System.EventHandler(this.txCodigo_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Quicksand", 14F);
            this.label2.Location = new System.Drawing.Point(457, 341);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 28);
            this.label2.TabIndex = 21;
            this.label2.Text = "Código:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // cbEspecie
            // 
            this.cbEspecie.DataSource = this.eSPECIEBindingSource;
            this.cbEspecie.DisplayMember = "NOMBRE";
            this.cbEspecie.FormattingEnabled = true;
            this.cbEspecie.Location = new System.Drawing.Point(563, 46);
            this.cbEspecie.Name = "cbEspecie";
            this.cbEspecie.Size = new System.Drawing.Size(171, 21);
            this.cbEspecie.TabIndex = 32;
            this.cbEspecie.ValueMember = "CODIGO";
            // 
            // cbNombre
            // 
            this.cbNombre.DataSource = this.fKMASCOTASESPECI4316F928BindingSource1;
            this.cbNombre.DisplayMember = "NOMBRE";
            this.cbNombre.FormattingEnabled = true;
            this.cbNombre.Location = new System.Drawing.Point(563, 93);
            this.cbNombre.Name = "cbNombre";
            this.cbNombre.Size = new System.Drawing.Size(171, 21);
            this.cbNombre.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Quicksand", 14F);
            this.label6.Location = new System.Drawing.Point(457, 86);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 28);
            this.label6.TabIndex = 33;
            this.label6.Text = "Nombre:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(443, 150);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(323, 177);
            this.pictureBox2.TabIndex = 35;
            this.pictureBox2.TabStop = false;
            // 
            // tIERNOTIRANOSAURIODataSet1
            // 
            this.tIERNOTIRANOSAURIODataSet1.DataSetName = "TIERNOTIRANOSAURIODataSet1";
            this.tIERNOTIRANOSAURIODataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eSPECIEBindingSource
            // 
            this.eSPECIEBindingSource.DataMember = "ESPECIE";
            this.eSPECIEBindingSource.DataSource = this.tIERNOTIRANOSAURIODataSet1;
            // 
            // eSPECIETableAdapter
            // 
            this.eSPECIETableAdapter.ClearBeforeFill = true;
            // 
            // fKMASCOTASESPECI4316F928BindingSource
            // 
            this.fKMASCOTASESPECI4316F928BindingSource.DataMember = "FK__MASCOTAS__ESPECI__4316F928";
            this.fKMASCOTASESPECI4316F928BindingSource.DataSource = this.eSPECIEBindingSource;
            // 
            // mASCOTASTableAdapter
            // 
            this.mASCOTASTableAdapter.ClearBeforeFill = true;
            // 
            // fKIDMASCOTADETALLEBindingSource
            // 
            this.fKIDMASCOTADETALLEBindingSource.DataMember = "FK_ID_MASCOTA_DETALLE";
            this.fKIDMASCOTADETALLEBindingSource.DataSource = this.fKMASCOTASESPECI4316F928BindingSource;
            // 
            // dETALLE_FACTURATableAdapter
            // 
            this.dETALLE_FACTURATableAdapter.ClearBeforeFill = true;
            // 
            // fKMASCOTASESPECI4316F928BindingSource1
            // 
            this.fKMASCOTASESPECI4316F928BindingSource1.DataMember = "FK__MASCOTAS__ESPECI__4316F928";
            this.fKMASCOTASESPECI4316F928BindingSource1.DataSource = this.eSPECIEBindingSource;
            // 
            // txCantidad
            // 
            this.txCantidad.Location = new System.Drawing.Point(563, 456);
            this.txCantidad.Margin = new System.Windows.Forms.Padding(4);
            this.txCantidad.Name = "txCantidad";
            this.txCantidad.Size = new System.Drawing.Size(171, 20);
            this.txCantidad.TabIndex = 37;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Quicksand", 14F);
            this.label7.Location = new System.Drawing.Point(432, 448);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 28);
            this.label7.TabIndex = 36;
            this.label7.Text = "Cantidad:";
            // 
            // PorNombre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(824, 593);
            this.Controls.Add(this.txCantidad);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.cbNombre);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbEspecie);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.btBorrar);
            this.Controls.Add(this.btBuscar);
            this.Controls.Add(this.txPrecio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txCodigo);
            this.Controls.Add(this.label2);
            this.Name = "PorNombre";
            this.Text = "PorNombre";
            this.Load += new System.EventHandler(this.PorNombre_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tIERNOTIRANOSAURIODataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eSPECIEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKMASCOTASESPECI4316F928BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKIDMASCOTADETALLEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKMASCOTASESPECI4316F928BindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btSalir;
        private System.Windows.Forms.Button btBorrar;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.TextBox txPrecio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txCodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbEspecie;
        private System.Windows.Forms.ComboBox cbNombre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private TIERNOTIRANOSAURIODataSet1 tIERNOTIRANOSAURIODataSet1;
        private System.Windows.Forms.BindingSource eSPECIEBindingSource;
        private TIERNOTIRANOSAURIODataSet1TableAdapters.ESPECIETableAdapter eSPECIETableAdapter;
        private System.Windows.Forms.BindingSource fKMASCOTASESPECI4316F928BindingSource;
        private TIERNOTIRANOSAURIODataSet1TableAdapters.MASCOTASTableAdapter mASCOTASTableAdapter;
        private System.Windows.Forms.BindingSource fKIDMASCOTADETALLEBindingSource;
        private TIERNOTIRANOSAURIODataSet1TableAdapters.DETALLE_FACTURATableAdapter dETALLE_FACTURATableAdapter;
        private System.Windows.Forms.BindingSource fKMASCOTASESPECI4316F928BindingSource1;
        private System.Windows.Forms.TextBox txCantidad;
        private System.Windows.Forms.Label label7;
    }
}