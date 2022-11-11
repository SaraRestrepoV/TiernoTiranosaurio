namespace TiernoTiranosaurioI
{
    partial class Cotizacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cotizacion));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btInsertar = new System.Windows.Forms.Button();
            this.txApellido = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txNombre = new System.Windows.Forms.TextBox();
            this.txCedula = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbFecha = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gbFactura = new System.Windows.Forms.GroupBox();
            this.dgvLista = new System.Windows.Forms.DataGridView();
            this.IdMascota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IVA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbNombre = new System.Windows.Forms.ComboBox();
            this.btCotizar = new System.Windows.Forms.Button();
            this.cbCodigo = new System.Windows.Forms.ComboBox();
            this.btCargar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txTotalIVA = new System.Windows.Forms.TextBox();
            this.txCantidad = new System.Windows.Forms.TextBox();
            this.txTotalPagar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txPrecio = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.btBuscarNombre = new System.Windows.Forms.Button();
            this.btBuscarCodigo = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.gbFactura.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btInsertar);
            this.groupBox1.Controls.Add(this.txApellido);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txNombre);
            this.groupBox1.Controls.Add(this.txCedula);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lbFecha);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(8, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(747, 122);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Usuario";
            // 
            // btInsertar
            // 
            this.btInsertar.Enabled = false;
            this.btInsertar.Location = new System.Drawing.Point(595, 71);
            this.btInsertar.Name = "btInsertar";
            this.btInsertar.Size = new System.Drawing.Size(90, 30);
            this.btInsertar.TabIndex = 30;
            this.btInsertar.Text = "Insertar";
            this.btInsertar.UseVisualStyleBackColor = true;
            this.btInsertar.Click += new System.EventHandler(this.btInsertar_Click);
            // 
            // txApellido
            // 
            this.txApellido.Location = new System.Drawing.Point(397, 32);
            this.txApellido.Name = "txApellido";
            this.txApellido.Size = new System.Drawing.Size(148, 20);
            this.txApellido.TabIndex = 28;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(315, 30);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 20);
            this.label13.TabIndex = 27;
            this.label13.Text = "Apellido:";
            // 
            // txNombre
            // 
            this.txNombre.Location = new System.Drawing.Point(141, 81);
            this.txNombre.Name = "txNombre";
            this.txNombre.Size = new System.Drawing.Size(148, 20);
            this.txNombre.TabIndex = 26;
            // 
            // txCedula
            // 
            this.txCedula.Location = new System.Drawing.Point(141, 30);
            this.txCedula.Name = "txCedula";
            this.txCedula.Size = new System.Drawing.Size(148, 20);
            this.txCedula.TabIndex = 25;
            this.txCedula.Leave += new System.EventHandler(this.txCedula_Leave);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(46, 81);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 20);
            this.label12.TabIndex = 24;
            this.label12.Text = "Nombre:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(52, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 20);
            this.label6.TabIndex = 23;
            this.label6.Text = "Cédula:";
            // 
            // lbFecha
            // 
            this.lbFecha.AutoSize = true;
            this.lbFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFecha.Location = new System.Drawing.Point(393, 81);
            this.lbFecha.Name = "lbFecha";
            this.lbFecha.Size = new System.Drawing.Size(21, 20);
            this.lbFecha.TabIndex = 13;
            this.lbFecha.Text = "...";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(319, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Fecha:";
            // 
            // gbFactura
            // 
            this.gbFactura.Controls.Add(this.dgvLista);
            this.gbFactura.Controls.Add(this.btBuscarNombre);
            this.gbFactura.Controls.Add(this.cbNombre);
            this.gbFactura.Controls.Add(this.btCotizar);
            this.gbFactura.Controls.Add(this.cbCodigo);
            this.gbFactura.Controls.Add(this.btCargar);
            this.gbFactura.Controls.Add(this.label4);
            this.gbFactura.Controls.Add(this.txTotalIVA);
            this.gbFactura.Controls.Add(this.txCantidad);
            this.gbFactura.Controls.Add(this.txTotalPagar);
            this.gbFactura.Controls.Add(this.label3);
            this.gbFactura.Controls.Add(this.label8);
            this.gbFactura.Controls.Add(this.txPrecio);
            this.gbFactura.Controls.Add(this.label7);
            this.gbFactura.Controls.Add(this.btBuscarCodigo);
            this.gbFactura.Controls.Add(this.label2);
            this.gbFactura.Controls.Add(this.label1);
            this.gbFactura.Location = new System.Drawing.Point(8, 137);
            this.gbFactura.Name = "gbFactura";
            this.gbFactura.Size = new System.Drawing.Size(747, 387);
            this.gbFactura.TabIndex = 31;
            this.gbFactura.TabStop = false;
            this.gbFactura.Text = "Cotización";
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
            this.dgvLista.Location = new System.Drawing.Point(13, 212);
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
            // cbNombre
            // 
            this.cbNombre.Cursor = System.Windows.Forms.Cursors.Default;
            this.cbNombre.FormattingEnabled = true;
            this.cbNombre.Items.AddRange(new object[] {
            "Seleccione un elemento"});
            this.cbNombre.Location = new System.Drawing.Point(141, 72);
            this.cbNombre.Name = "cbNombre";
            this.cbNombre.Size = new System.Drawing.Size(141, 21);
            this.cbNombre.TabIndex = 27;
            // 
            // btCotizar
            // 
            this.btCotizar.Location = new System.Drawing.Point(598, 212);
            this.btCotizar.Name = "btCotizar";
            this.btCotizar.Size = new System.Drawing.Size(105, 28);
            this.btCotizar.TabIndex = 20;
            this.btCotizar.Text = "Cotizar";
            this.btCotizar.UseVisualStyleBackColor = true;
            this.btCotizar.Click += new System.EventHandler(this.btCotizar_Click);
            // 
            // cbCodigo
            // 
            this.cbCodigo.Cursor = System.Windows.Forms.Cursors.Default;
            this.cbCodigo.FormattingEnabled = true;
            this.cbCodigo.Items.AddRange(new object[] {
            "Seleccione un elemento"});
            this.cbCodigo.Location = new System.Drawing.Point(141, 29);
            this.cbCodigo.Name = "cbCodigo";
            this.cbCodigo.Size = new System.Drawing.Size(141, 21);
            this.cbCodigo.TabIndex = 25;
            // 
            // btCargar
            // 
            this.btCargar.Location = new System.Drawing.Point(306, 160);
            this.btCargar.Name = "btCargar";
            this.btCargar.Size = new System.Drawing.Size(105, 28);
            this.btCargar.TabIndex = 10;
            this.btCargar.Text = "Cargar a lista";
            this.btCargar.UseVisualStyleBackColor = true;
            this.btCargar.Click += new System.EventHandler(this.btCargar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(52, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Cantidad:";
            // 
            // txTotalIVA
            // 
            this.txTotalIVA.BackColor = System.Drawing.SystemColors.MenuText;
            this.txTotalIVA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txTotalIVA.ForeColor = System.Drawing.Color.Crimson;
            this.txTotalIVA.Location = new System.Drawing.Point(598, 76);
            this.txTotalIVA.Name = "txTotalIVA";
            this.txTotalIVA.ReadOnly = true;
            this.txTotalIVA.Size = new System.Drawing.Size(130, 20);
            this.txTotalIVA.TabIndex = 19;
            // 
            // txCantidad
            // 
            this.txCantidad.Location = new System.Drawing.Point(141, 164);
            this.txCantidad.Name = "txCantidad";
            this.txCantidad.Size = new System.Drawing.Size(141, 20);
            this.txCantidad.TabIndex = 8;
            // 
            // txTotalPagar
            // 
            this.txTotalPagar.BackColor = System.Drawing.SystemColors.MenuText;
            this.txTotalPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txTotalPagar.ForeColor = System.Drawing.Color.Crimson;
            this.txTotalPagar.Location = new System.Drawing.Point(598, 32);
            this.txTotalPagar.Name = "txTotalPagar";
            this.txTotalPagar.ReadOnly = true;
            this.txTotalPagar.Size = new System.Drawing.Size(130, 20);
            this.txTotalPagar.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(73, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Precio:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(481, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Total IVA:";
            // 
            // txPrecio
            // 
            this.txPrecio.Location = new System.Drawing.Point(141, 121);
            this.txPrecio.Name = "txPrecio";
            this.txPrecio.Size = new System.Drawing.Size(141, 20);
            this.txPrecio.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(481, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Total a pagar:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Código producto:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.YellowGreen;
            this.panel1.Controls.Add(this.label10);
            this.panel1.Location = new System.Drawing.Point(-4, -74);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(809, 62);
            this.panel1.TabIndex = 30;
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
            // btBuscarNombre
            // 
            this.btBuscarNombre.Image = ((System.Drawing.Image)(resources.GetObject("btBuscarNombre.Image")));
            this.btBuscarNombre.Location = new System.Drawing.Point(306, 72);
            this.btBuscarNombre.Name = "btBuscarNombre";
            this.btBuscarNombre.Size = new System.Drawing.Size(105, 28);
            this.btBuscarNombre.TabIndex = 26;
            this.btBuscarNombre.UseVisualStyleBackColor = true;
            this.btBuscarNombre.Click += new System.EventHandler(this.btBuscarNombre_Click);
            // 
            // btBuscarCodigo
            // 
            this.btBuscarCodigo.Image = ((System.Drawing.Image)(resources.GetObject("btBuscarCodigo.Image")));
            this.btBuscarCodigo.Location = new System.Drawing.Point(306, 24);
            this.btBuscarCodigo.Name = "btBuscarCodigo";
            this.btBuscarCodigo.Size = new System.Drawing.Size(105, 28);
            this.btBuscarCodigo.TabIndex = 0;
            this.btBuscarCodigo.UseVisualStyleBackColor = true;
            this.btBuscarCodigo.Click += new System.EventHandler(this.btBuscarCodigo_Click);
            // 
            // Cotizacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 512);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbFactura);
            this.Controls.Add(this.panel1);
            this.Name = "Cotizacion";
            this.Text = "Cotizacion";
            this.Load += new System.EventHandler(this.Cotizacion_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbFactura.ResumeLayout(false);
            this.gbFactura.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btInsertar;
        private System.Windows.Forms.TextBox txApellido;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txNombre;
        private System.Windows.Forms.TextBox txCedula;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbFecha;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gbFactura;
        private System.Windows.Forms.DataGridView dgvLista;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdMascota;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subtotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn IVA;
        private System.Windows.Forms.Button btBuscarNombre;
        private System.Windows.Forms.ComboBox cbNombre;
        private System.Windows.Forms.Button btCotizar;
        private System.Windows.Forms.ComboBox cbCodigo;
        private System.Windows.Forms.Button btCargar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txTotalIVA;
        private System.Windows.Forms.TextBox txCantidad;
        private System.Windows.Forms.TextBox txTotalPagar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txPrecio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btBuscarCodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
    }
}