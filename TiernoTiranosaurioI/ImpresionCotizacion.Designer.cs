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
            this.txImpresion = new System.Windows.Forms.TextBox();
            this.btSalir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txImpresion
            // 
            this.txImpresion.Location = new System.Drawing.Point(3, 3);
            this.txImpresion.Multiline = true;
            this.txImpresion.Name = "txImpresion";
            this.txImpresion.Size = new System.Drawing.Size(98, 106);
            this.txImpresion.TabIndex = 0;
            this.txImpresion.Text = "                        __\r\n                      / _ )\r\n       _/\\/\\/\\_/ /\r\n    " +
    "_|               /\r\n  _|   (   |    (   |\r\n/__.-\' |_|- - -|_|  \r\n\r\nVVVVVVVVVVVVV" +
    "VVV";
            // 
            // btSalir
            // 
            this.btSalir.Location = new System.Drawing.Point(299, 462);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(103, 31);
            this.btSalir.TabIndex = 1;
            this.btSalir.Text = "Salir";
            this.btSalir.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Factura Cotización";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.txImpresion);
            this.panel1.Location = new System.Drawing.Point(35, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(367, 379);
            this.panel1.TabIndex = 4;
            // 
            // ImpresionCotizacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 516);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.panel1);
            this.Name = "ImpresionCotizacion";
            this.Text = "ImpresionCotizacion";
            this.Load += new System.EventHandler(this.ImpresionCotizacion_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btSalir;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txImpresion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
    }
}