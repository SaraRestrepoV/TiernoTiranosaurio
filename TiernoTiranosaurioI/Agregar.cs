using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace TiernoTiranosaurioI
{
    public partial class Agregar : Form
    {
        SqlConnection objConector;
     //   SqlDataReader objTabla;
        public Agregar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fo = new OpenFileDialog();
            DialogResult rs = fo.ShowDialog();
            if (rs == DialogResult.OK)
            {
                pcImagen.Image = Image.FromFile(fo.FileName);
                pcImagen.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            int codigo = Int32.Parse(txCodigo.Text);
            string nombre = txNombre.Text;
            int especie = Int32.Parse(txEspecie.Text);
            int precio = Int32.Parse(txPrecio.Text);
            int cantidad = Int32.Parse(txCantidad.Text);
            byte[] mifoto = clsImagen.ImageToByte(pcImagen.Image);
            MessageBox.Show("" + mifoto);
            objConector = DB.conectar("TIERNOTIRANOSAURIO");
            string consultaSql = "insert into MASCOTAS VALUES (" + codigo + ",'" + mifoto + "','" + nombre + "'," + precio + "," + cantidad + "," + especie + ");";
            int n = DB.operar(consultaSql, objConector);
            if (n > 0)
            {
                MessageBox.Show("Cambios aceptados");
            }
            else
            {
                MessageBox.Show("No se pudo realizar la actualización");
            }
          
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}