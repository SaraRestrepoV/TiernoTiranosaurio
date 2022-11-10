using System.Threading;

namespace TiernoTiranosaurioI
{
    partial class Facturacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Facturacion));
            this.btBuscarCodigo = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txPrecio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txCantidad = new System.Windows.Forms.TextBox();
            this.btCargar = new System.Windows.Forms.Button();
            this.dgvLista = new System.Windows.Forms.DataGridView();
            this.IdMascota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IVA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.lbFecha = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txEfectivo = new System.Windows.Forms.TextBox();
            this.txTotalPagar = new System.Windows.Forms.TextBox();
            this.txTotalIVA = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txDevolucion = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbCodigo = new System.Windows.Forms.ComboBox();
            this.tIERNOTIRANOSAURIODataSet = new TiernoTiranosaurioI.TIERNOTIRANOSAURIODataSet();
            this.tIERNOTIRANOSAURIODataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mASCOTASBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mASCOTASTableAdapter = new TiernoTiranosaurioI.TIERNOTIRANOSAURIODataSetTableAdapters.MASCOTASTableAdapter();
            this.mASCOTASBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btBuscarNombre = new System.Windows.Forms.Button();
            this.cbNombre = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tIERNOTIRANOSAURIODataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tIERNOTIRANOSAURIODataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mASCOTASBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mASCOTASBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btBuscarCodigo
            // 
            this.btBuscarCodigo.Image = ((System.Drawing.Image)(resources.GetObject("btBuscarCodigo.Image")));
            this.btBuscarCodigo.Location = new System.Drawing.Point(336, 100);
            this.btBuscarCodigo.Name = "btBuscarCodigo";
            this.btBuscarCodigo.Size = new System.Drawing.Size(105, 28);
            this.btBuscarCodigo.TabIndex = 0;
            this.btBuscarCodigo.UseVisualStyleBackColor = true;
            this.btBuscarCodigo.Click += new System.EventHandler(this.btBuscarCodigo_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.YellowGreen;
            this.panel1.Controls.Add(this.label10);
            this.panel1.Location = new System.Drawing.Point(0, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(809, 62);
            this.panel1.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(30, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(271, 29);
            this.label10.TabIndex = 21;
            this.label10.Text = "Módulo de facturación";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Código producto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(90, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(103, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Precio:";
            // 
            // txPrecio
            // 
            this.txPrecio.Location = new System.Drawing.Point(171, 197);
            this.txPrecio.Name = "txPrecio";
            this.txPrecio.Size = new System.Drawing.Size(130, 20);
            this.txPrecio.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(82, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Cantidad:";
            // 
            // txCantidad
            // 
            this.txCantidad.Location = new System.Drawing.Point(171, 240);
            this.txCantidad.Name = "txCantidad";
            this.txCantidad.Size = new System.Drawing.Size(130, 20);
            this.txCantidad.TabIndex = 8;
            // 
            // btCargar
            // 
            this.btCargar.Location = new System.Drawing.Point(347, 232);
            this.btCargar.Name = "btCargar";
            this.btCargar.Size = new System.Drawing.Size(105, 28);
            this.btCargar.TabIndex = 10;
            this.btCargar.Text = "Cargar a lista";
            this.btCargar.UseVisualStyleBackColor = true;
            this.btCargar.Click += new System.EventHandler(this.btCargar_Click);
            // 
            // dgvLista
            // 
            this.dgvLista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdMascota,
            this.Nombre,
            this.Precio,
            this.Cantidad,
            this.Subtotal,
            this.IVA});
            this.dgvLista.Location = new System.Drawing.Point(39, 308);
            this.dgvLista.Name = "dgvLista";
            this.dgvLista.Size = new System.Drawing.Size(532, 150);
            this.dgvLista.TabIndex = 11;
            // 
            // IdMascota
            // 
            this.IdMascota.HeaderText = "IdMascota";
            this.IdMascota.Name = "IdMascota";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // Subtotal
            // 
            this.Subtotal.HeaderText = "Subtotal";
            this.Subtotal.Name = "Subtotal";
            // 
            // IVA
            // 
            this.IVA.HeaderText = "IVA 19%";
            this.IVA.Name = "IVA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(505, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Fecha:";
            // 
            // lbFecha
            // 
            this.lbFecha.AutoSize = true;
            this.lbFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFecha.Location = new System.Drawing.Point(606, 105);
            this.lbFecha.Name = "lbFecha";
            this.lbFecha.Size = new System.Drawing.Size(21, 20);
            this.lbFecha.TabIndex = 13;
            this.lbFecha.Text = "...";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(505, 167);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Total a pagar:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(505, 207);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Total IVA:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(606, 285);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "Efectivo";
            // 
            // txEfectivo
            // 
            this.txEfectivo.Location = new System.Drawing.Point(610, 308);
            this.txEfectivo.Multiline = true;
            this.txEfectivo.Name = "txEfectivo";
            this.txEfectivo.Size = new System.Drawing.Size(148, 22);
            this.txEfectivo.TabIndex = 17;
            this.txEfectivo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txTotalPagar
            // 
            this.txTotalPagar.BackColor = System.Drawing.SystemColors.MenuText;
            this.txTotalPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txTotalPagar.ForeColor = System.Drawing.Color.Crimson;
            this.txTotalPagar.Location = new System.Drawing.Point(610, 167);
            this.txTotalPagar.Name = "txTotalPagar";
            this.txTotalPagar.ReadOnly = true;
            this.txTotalPagar.Size = new System.Drawing.Size(130, 20);
            this.txTotalPagar.TabIndex = 18;
            // 
            // txTotalIVA
            // 
            this.txTotalIVA.BackColor = System.Drawing.SystemColors.MenuText;
            this.txTotalIVA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txTotalIVA.ForeColor = System.Drawing.Color.Crimson;
            this.txTotalIVA.Location = new System.Drawing.Point(610, 207);
            this.txTotalIVA.Name = "txTotalIVA";
            this.txTotalIVA.ReadOnly = true;
            this.txTotalIVA.Size = new System.Drawing.Size(130, 20);
            this.txTotalIVA.TabIndex = 19;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(610, 430);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 28);
            this.button1.TabIndex = 20;
            this.button1.Text = "Vender";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TiernoTiranosaurioI.Properties.Resources.Diseño_sin_título__3__removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(713, 69);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(82, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // txDevolucion
            // 
            this.txDevolucion.BackColor = System.Drawing.SystemColors.MenuText;
            this.txDevolucion.ForeColor = System.Drawing.Color.Lime;
            this.txDevolucion.Location = new System.Drawing.Point(610, 385);
            this.txDevolucion.Name = "txDevolucion";
            this.txDevolucion.ReadOnly = true;
            this.txDevolucion.Size = new System.Drawing.Size(130, 20);
            this.txDevolucion.TabIndex = 24;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(606, 362);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 20);
            this.label11.TabIndex = 23;
            this.label11.Text = "Devolución:";
            // 
            // cbCodigo
            // 
            this.cbCodigo.Cursor = System.Windows.Forms.Cursors.Default;
            this.cbCodigo.FormattingEnabled = true;
            this.cbCodigo.Items.AddRange(new object[] {
            "Seleccione un elemento"});
            this.cbCodigo.Location = new System.Drawing.Point(171, 105);
            this.cbCodigo.Name = "cbCodigo";
            this.cbCodigo.Size = new System.Drawing.Size(141, 21);
            this.cbCodigo.TabIndex = 25;
            // 
            // tIERNOTIRANOSAURIODataSet
            // 
            this.tIERNOTIRANOSAURIODataSet.DataSetName = "TIERNOTIRANOSAURIODataSet";
            this.tIERNOTIRANOSAURIODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tIERNOTIRANOSAURIODataSetBindingSource
            // 
            this.tIERNOTIRANOSAURIODataSetBindingSource.DataSource = this.tIERNOTIRANOSAURIODataSet;
            this.tIERNOTIRANOSAURIODataSetBindingSource.Position = 0;
            // 
            // mASCOTASBindingSource
            // 
            this.mASCOTASBindingSource.DataMember = "MASCOTAS";
            this.mASCOTASBindingSource.DataSource = this.tIERNOTIRANOSAURIODataSetBindingSource;
            // 
            // mASCOTASTableAdapter
            // 
            this.mASCOTASTableAdapter.ClearBeforeFill = true;
            // 
            // mASCOTASBindingSource1
            // 
            this.mASCOTASBindingSource1.DataMember = "MASCOTAS";
            this.mASCOTASBindingSource1.DataSource = this.tIERNOTIRANOSAURIODataSetBindingSource;
            // 
            // btBuscarNombre
            // 
            this.btBuscarNombre.Image = ((System.Drawing.Image)(resources.GetObject("btBuscarNombre.Image")));
            this.btBuscarNombre.Location = new System.Drawing.Point(336, 147);
            this.btBuscarNombre.Name = "btBuscarNombre";
            this.btBuscarNombre.Size = new System.Drawing.Size(105, 28);
            this.btBuscarNombre.TabIndex = 26;
            this.btBuscarNombre.UseVisualStyleBackColor = true;
            this.btBuscarNombre.Click += new System.EventHandler(this.btBuscarNombre_Click);
            // 
            // cbNombre
            // 
            this.cbNombre.Cursor = System.Windows.Forms.Cursors.Default;
            this.cbNombre.FormattingEnabled = true;
            this.cbNombre.Items.AddRange(new object[] {
            "Seleccione un elemento"});
            this.cbNombre.Location = new System.Drawing.Point(171, 148);
            this.cbNombre.Name = "cbNombre";
            this.cbNombre.Size = new System.Drawing.Size(141, 21);
            this.cbNombre.TabIndex = 27;
            // 
            // Facturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 482);
            this.Controls.Add(this.cbNombre);
            this.Controls.Add(this.btBuscarNombre);
            this.Controls.Add(this.cbCodigo);
            this.Controls.Add(this.txDevolucion);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txTotalIVA);
            this.Controls.Add(this.txTotalPagar);
            this.Controls.Add(this.txEfectivo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbFecha);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvLista);
            this.Controls.Add(this.btCargar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txCantidad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txPrecio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btBuscarCodigo);
            this.Name = "Facturacion";
            this.Text = "Facturacion";
            this.Load += new System.EventHandler(this.Facturacion_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tIERNOTIRANOSAURIODataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tIERNOTIRANOSAURIODataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mASCOTASBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mASCOTASBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btBuscarCodigo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txPrecio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txCantidad;
        private System.Windows.Forms.Button btCargar;
        private System.Windows.Forms.DataGridView dgvLista;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbFecha;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txEfectivo;
        private System.Windows.Forms.TextBox txTotalPagar;
        private System.Windows.Forms.TextBox txTotalIVA;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txDevolucion;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdMascota;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subtotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn IVA;
        private System.Windows.Forms.ComboBox cbCodigo;
        private System.Windows.Forms.BindingSource tIERNOTIRANOSAURIODataSetBindingSource;
        private TIERNOTIRANOSAURIODataSet tIERNOTIRANOSAURIODataSet;
        private System.Windows.Forms.BindingSource mASCOTASBindingSource;
        private TIERNOTIRANOSAURIODataSetTableAdapters.MASCOTASTableAdapter mASCOTASTableAdapter;
        private System.Windows.Forms.BindingSource mASCOTASBindingSource1;
        private System.Windows.Forms.Button btBuscarNombre;
        private System.Windows.Forms.ComboBox cbNombre;
    }
}