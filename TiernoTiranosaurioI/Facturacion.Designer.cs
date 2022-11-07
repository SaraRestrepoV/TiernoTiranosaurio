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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Facturacion));
            this.btBuscar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txPrecio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txCantidad = new System.Windows.Forms.TextBox();
            this.btCargar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.IdMascota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btBuscar
            // 
            this.btBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btBuscar.Image")));
            this.btBuscar.Location = new System.Drawing.Point(347, 97);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(105, 28);
            this.btBuscar.TabIndex = 0;
            this.btBuscar.UseVisualStyleBackColor = true;
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
            // txCodigo
            // 
            this.txCodigo.Location = new System.Drawing.Point(171, 105);
            this.txCodigo.Name = "txCodigo";
            this.txCodigo.Size = new System.Drawing.Size(130, 20);
            this.txCodigo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Código producto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(90, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nombre:";
            // 
            // txNombre
            // 
            this.txNombre.Location = new System.Drawing.Point(171, 152);
            this.txNombre.Name = "txNombre";
            this.txNombre.ReadOnly = true;
            this.txNombre.Size = new System.Drawing.Size(130, 20);
            this.txNombre.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(103, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Precio:";
            // 
            // txPrecio
            // 
            this.txPrecio.Location = new System.Drawing.Point(171, 197);
            this.txPrecio.Name = "txPrecio";
            this.txPrecio.ReadOnly = true;
            this.txPrecio.Size = new System.Drawing.Size(130, 20);
            this.txPrecio.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(82, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 24);
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
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdMascota,
            this.Nombre,
            this.Precio,
            this.Cantidad,
            this.Subtotal});
            this.dataGridView1.Location = new System.Drawing.Point(39, 308);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(532, 150);
            this.dataGridView1.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(517, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 24);
            this.label5.TabIndex = 12;
            this.label5.Text = "Fecha:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(594, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 24);
            this.label6.TabIndex = 13;
            this.label6.Text = "30/12/2022";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(517, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 24);
            this.label7.TabIndex = 14;
            this.label7.Text = "Total a pagar:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(517, 209);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 24);
            this.label8.TabIndex = 15;
            this.label8.Text = "Devolución:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(655, 320);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 24);
            this.label9.TabIndex = 16;
            this.label9.Text = "Efectivo";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(609, 344);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(148, 38);
            this.textBox1.TabIndex = 17;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox2.ForeColor = System.Drawing.Color.Aquamarine;
            this.textBox2.Location = new System.Drawing.Point(520, 174);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(130, 20);
            this.textBox2.TabIndex = 18;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox3.ForeColor = System.Drawing.Color.Aquamarine;
            this.textBox3.Location = new System.Drawing.Point(520, 236);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(130, 20);
            this.textBox3.TabIndex = 19;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(632, 404);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 28);
            this.button1.TabIndex = 20;
            this.button1.Text = "Vender";
            this.button1.UseVisualStyleBackColor = true;
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
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Bebas Neue", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(30, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(222, 31);
            this.label10.TabIndex = 21;
            this.label10.Text = "Módulo de facturación";
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
            // Facturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 482);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btCargar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txCantidad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txPrecio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txCodigo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btBuscar);
            this.Name = "Facturacion";
            this.Text = "Facturacion";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txPrecio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txCantidad;
        private System.Windows.Forms.Button btCargar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdMascota;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subtotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}