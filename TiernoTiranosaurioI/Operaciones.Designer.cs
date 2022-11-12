namespace TiernoTiranosaurioI
{
    partial class Operaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Operaciones));
            this.dgvAnimales = new System.Windows.Forms.DataGridView();
            this.CODIGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRECIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CANTIDAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ESPECIE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mASCOTASBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tIERNOTIRANOSAURIODataSet = new TiernoTiranosaurioI.TIERNOTIRANOSAURIODataSet();
            this.mASCOTASBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbFecha = new System.Windows.Forms.Label();
            this.mASCOTASTableAdapter = new TiernoTiranosaurioI.TIERNOTIRANOSAURIODataSetTableAdapters.MASCOTASTableAdapter();
            this.btSalir = new System.Windows.Forms.Button();
            this.btEliminar = new System.Windows.Forms.Button();
            this.btEditar = new System.Windows.Forms.Button();
            this.btNuevo = new System.Windows.Forms.Button();
            this.mASCOTASBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetFinal = new TiernoTiranosaurioI.DataSetFinal();
            this.mASCOTASBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.mASCOTASTableAdapter1 = new TiernoTiranosaurioI.DataSetFinalTableAdapters.MASCOTASTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnimales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mASCOTASBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tIERNOTIRANOSAURIODataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mASCOTASBindingSource1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mASCOTASBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetFinal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mASCOTASBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAnimales
            // 
            this.dgvAnimales.AutoGenerateColumns = false;
            this.dgvAnimales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAnimales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CODIGO,
            this.NOMBRE,
            this.PRECIO,
            this.CANTIDAD,
            this.ESPECIE});
            this.dgvAnimales.DataSource = this.mASCOTASBindingSource3;
            this.dgvAnimales.Location = new System.Drawing.Point(87, 271);
            this.dgvAnimales.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvAnimales.Name = "dgvAnimales";
            this.dgvAnimales.RowHeadersWidth = 51;
            this.dgvAnimales.Size = new System.Drawing.Size(721, 316);
            this.dgvAnimales.TabIndex = 0;
            this.dgvAnimales.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAnimales_CellClick);
            this.dgvAnimales.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAnimales_CellContentClick);
            // 
            // CODIGO
            // 
            this.CODIGO.DataPropertyName = "CODIGO";
            this.CODIGO.HeaderText = "CODIGO";
            this.CODIGO.MinimumWidth = 6;
            this.CODIGO.Name = "CODIGO";
            this.CODIGO.Width = 125;
            // 
            // NOMBRE
            // 
            this.NOMBRE.DataPropertyName = "NOMBRE";
            this.NOMBRE.HeaderText = "NOMBRE";
            this.NOMBRE.MinimumWidth = 6;
            this.NOMBRE.Name = "NOMBRE";
            this.NOMBRE.Width = 125;
            // 
            // PRECIO
            // 
            this.PRECIO.DataPropertyName = "PRECIO";
            this.PRECIO.HeaderText = "PRECIO";
            this.PRECIO.MinimumWidth = 6;
            this.PRECIO.Name = "PRECIO";
            this.PRECIO.Width = 125;
            // 
            // CANTIDAD
            // 
            this.CANTIDAD.DataPropertyName = "CANTIDAD";
            this.CANTIDAD.HeaderText = "CANTIDAD";
            this.CANTIDAD.MinimumWidth = 6;
            this.CANTIDAD.Name = "CANTIDAD";
            this.CANTIDAD.Width = 125;
            // 
            // ESPECIE
            // 
            this.ESPECIE.DataPropertyName = "ESPECIE";
            this.ESPECIE.HeaderText = "ESPECIE";
            this.ESPECIE.MinimumWidth = 6;
            this.ESPECIE.Name = "ESPECIE";
            this.ESPECIE.Width = 125;
            // 
            // mASCOTASBindingSource2
            // 
            this.mASCOTASBindingSource2.DataMember = "MASCOTAS";
            this.mASCOTASBindingSource2.DataSource = this.tIERNOTIRANOSAURIODataSet;
            // 
            // tIERNOTIRANOSAURIODataSet
            // 
            this.tIERNOTIRANOSAURIODataSet.DataSetName = "TIERNOTIRANOSAURIODataSet";
            this.tIERNOTIRANOSAURIODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mASCOTASBindingSource1
            // 
            this.mASCOTASBindingSource1.DataMember = "MASCOTAS";
            this.mASCOTASBindingSource1.DataSource = this.tIERNOTIRANOSAURIODataSet;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.YellowGreen;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(-4, -5);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1045, 181);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Azure;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(361, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(336, 181);
            this.panel2.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TiernoTiranosaurioI.Properties.Resources.Diseño_sin_título__4__removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(64, 9);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(213, 172);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.YellowGreen;
            this.label1.Location = new System.Drawing.Point(75, 206);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(348, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "Módulo de operaciones";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(708, 204);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 36);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fecha:";
            // 
            // lbFecha
            // 
            this.lbFecha.AutoSize = true;
            this.lbFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFecha.ForeColor = System.Drawing.Color.Black;
            this.lbFecha.Location = new System.Drawing.Point(833, 212);
            this.lbFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbFecha.Name = "lbFecha";
            this.lbFecha.Size = new System.Drawing.Size(131, 29);
            this.lbFecha.TabIndex = 4;
            this.lbFecha.Text = "07/11/2022";
            // 
            // mASCOTASTableAdapter
            // 
            this.mASCOTASTableAdapter.ClearBeforeFill = true;
            // 
            // btSalir
            // 
            this.btSalir.Image = ((System.Drawing.Image)(resources.GetObject("btSalir.Image")));
            this.btSalir.Location = new System.Drawing.Point(869, 655);
            this.btSalir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(155, 41);
            this.btSalir.TabIndex = 8;
            this.btSalir.UseVisualStyleBackColor = true;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // btEliminar
            // 
            this.btEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btEliminar.Image")));
            this.btEliminar.Location = new System.Drawing.Point(468, 630);
            this.btEliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(167, 65);
            this.btEliminar.TabIndex = 7;
            this.btEliminar.UseVisualStyleBackColor = true;
            this.btEliminar.Click += new System.EventHandler(this.btEliminar_Click);
            // 
            // btEditar
            // 
            this.btEditar.Image = ((System.Drawing.Image)(resources.GetObject("btEditar.Image")));
            this.btEditar.Location = new System.Drawing.Point(287, 630);
            this.btEditar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(173, 65);
            this.btEditar.TabIndex = 6;
            this.btEditar.UseVisualStyleBackColor = true;
            this.btEditar.Click += new System.EventHandler(this.btEditar_Click);
            // 
            // btNuevo
            // 
            this.btNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btNuevo.Image")));
            this.btNuevo.Location = new System.Drawing.Point(87, 630);
            this.btNuevo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btNuevo.Name = "btNuevo";
            this.btNuevo.Size = new System.Drawing.Size(192, 65);
            this.btNuevo.TabIndex = 5;
            this.btNuevo.UseVisualStyleBackColor = true;
            this.btNuevo.Click += new System.EventHandler(this.btNuevo_Click);
            // 
            // mASCOTASBindingSource
            // 
            this.mASCOTASBindingSource.DataMember = "MASCOTAS";
            // 
            // dataSetFinal
            // 
            this.dataSetFinal.DataSetName = "DataSetFinal";
            this.dataSetFinal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mASCOTASBindingSource3
            // 
            this.mASCOTASBindingSource3.DataMember = "MASCOTAS";
            this.mASCOTASBindingSource3.DataSource = this.dataSetFinal;
            // 
            // mASCOTASTableAdapter1
            // 
            this.mASCOTASTableAdapter1.ClearBeforeFill = true;
            // 
            // Operaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1040, 731);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.btEliminar);
            this.Controls.Add(this.btEditar);
            this.Controls.Add(this.btNuevo);
            this.Controls.Add(this.lbFecha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvAnimales);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Operaciones";
            this.Text = "Operaciones";
            this.Load += new System.EventHandler(this.Operaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnimales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mASCOTASBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tIERNOTIRANOSAURIODataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mASCOTASBindingSource1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mASCOTASBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetFinal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mASCOTASBindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAnimales;
        private System.Windows.Forms.BindingSource mASCOTASBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODIGODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMBREDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRECIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cANTIDADDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eSPECIEDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbFecha;
        private System.Windows.Forms.Button btNuevo;
        private System.Windows.Forms.Button btEditar;
        private System.Windows.Forms.Button btEliminar;
        private System.Windows.Forms.Button btSalir;
        private TIERNOTIRANOSAURIODataSet tIERNOTIRANOSAURIODataSet;
        private System.Windows.Forms.BindingSource mASCOTASBindingSource1;
        private TIERNOTIRANOSAURIODataSetTableAdapters.MASCOTASTableAdapter mASCOTASTableAdapter;
        private System.Windows.Forms.BindingSource mASCOTASBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRECIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CANTIDAD;
        private System.Windows.Forms.DataGridViewTextBoxColumn ESPECIE;
        private DataSetFinal dataSetFinal;
        private System.Windows.Forms.BindingSource mASCOTASBindingSource3;
        private DataSetFinalTableAdapters.MASCOTASTableAdapter mASCOTASTableAdapter1;
    }
}