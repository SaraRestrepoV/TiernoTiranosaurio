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
        string nombreArchivo;
        public Agregar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialogAbrir.ShowDialog();
            //nombreArchivo = openFileDialogAbrir.FileName;
            pcImagen.SizeMode = PictureBoxSizeMode.StretchImage;
            nombreArchivo = openFileDialogAbrir.FileName.ToString();
            MessageBox.Show(nombreArchivo); ;

            Image img = Image.FromFile(nombreArchivo);
            pcImagen.Image = img;
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txCodigo.Text) || string.IsNullOrEmpty(txNombre.Text) || string.IsNullOrEmpty(txEspecie.Text) || string.IsNullOrEmpty(txCantidad.Text) || string.IsNullOrEmpty(txPrecio.Text))
            {
                MessageBox.Show("Debe ingresar información en todos los campos");
            }
            else
            {
                int codigo = Int32.Parse(txCodigo.Text);
                string nombre = txNombre.Text;
                int especie = Int32.Parse(txEspecie.Text);
                int precio = Int32.Parse(txPrecio.Text);
                int cantidad = Int32.Parse(txCantidad.Text);
                objConector = DB.conectar("TIERNOTIRANOSAURIO");
                string consultaSql = "insert into MASCOTAS VALUES (" + codigo + ",'" + nombreArchivo + "','" + nombre + "'," + precio + "," + cantidad + "," + especie + ");";
                int n = DB.operar(consultaSql, objConector);
                if (n > 0)
                {
                    MessageBox.Show("Cambios aceptados");
                    txCodigo.Text = "";
                    txNombre.Text = "";
                    txEspecie.Text = "";
                    txPrecio.Text = "";
                    txCantidad.Text = "";
                    pcImagen.Image = null;
                }
                else
                {
                    MessageBox.Show("No se pudo realizar la actualización");
                }
            }                 
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}