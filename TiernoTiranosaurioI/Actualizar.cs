using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TiernoTiranosaurioI
{
    public partial class Actualizar : Form
    {

        SqlConnection objConector;
        SqlDataReader objTabla;
        string nombreArchivo;
        public Actualizar()
        {
            InitializeComponent();
        }

        private void btFoto_Click(object sender, EventArgs e)
        {
            openFileDialogAbrir.ShowDialog();
            nombreArchivo = openFileDialogAbrir.FileName.ToString();
            MessageBox.Show(nombreArchivo);

            Image img = Image.FromFile(nombreArchivo);
            pcImagen.Image = img;

        }

        private void btGuardar_Click(object sender, EventArgs e)
        {

            int cod = Int32.Parse(txCodigo.Text);
            string nombre = txNombre.Text;
            int especie = Int32.Parse(txEspecie.Text);
            int precio = Int32.Parse(txPrecio.Text);
            int cantidad = Int32.Parse(txCantidad.Text);
            objConector = DB.conectar("BDVETERINARIA");
            string consultaSql = "UPDATE MASCOTAS set imagen= '" + nombreArchivo + "' ,nombre= '" + nombre + "' , precio =" + precio + ", cantidad= " + cantidad + ", especie=" + especie + " where codigo= " + cod;

            int n = DB.operar(consultaSql, objConector);
            if (n > 0)
            {
                MessageBox.Show("Actualizaciones aceptadas");
            }
            else
            {
                MessageBox.Show("No se pudo realizar la actualización");
            }
            btGuardar.Enabled = false;
            txCantidad.ReadOnly = true;
            txEspecie.ReadOnly = true;
            txNombre.ReadOnly = true;
            txPrecio.ReadOnly = true;
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pcImagen_Click(object sender, EventArgs e)
        {

        }
    }
}
