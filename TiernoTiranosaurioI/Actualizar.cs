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
        public Actualizar()
        {
            InitializeComponent();
        }

        private void btFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog fo = new OpenFileDialog();
            DialogResult rs = fo.ShowDialog();
            if (rs == DialogResult.OK)
            {
                pcImagen.Image = Image.FromFile(fo.FileName);
            }
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            pcImagen.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);

            int cod = Int32.Parse(txCodigo.Text);
            string nombre = txNombre.Text;
            int especie = Int32.Parse(txEspecie.Text);
            int precio = Int32.Parse(txPrecio.Text);
            int cantidad = Int32.Parse(txCantidad.Text);
            objConector = DB.conectar("TIERNOTIRANOSAURIO");
            string consultaSql = "UPDATE MASCOTAS set imagen= '" + ms.GetBuffer() + "' ,nombre= '" + nombre + "' , precio =" + precio + ", cantidad= " + cantidad + ", especie=" + especie + "where codigo= " + cod;

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

        private void btBuscar_Click(object sender, EventArgs e)
        {

            btBuscar.Enabled = false;

            try
            {
                objConector = DB.conectar("TIERNOTIRANOSAURIO");
                int codigo = Int32.Parse(txCodigo.Text);
                string ConsultaSQL = "SELECT * FROM MASCOTAS M WHERE M.CODIGO =" + codigo;
                try
                {
                    objTabla = DB.consulta(ConsultaSQL, objConector);
                    if (objTabla.Read())
                    {
                        txNombre.Text = objTabla[2].ToString();
                        txPrecio.Text = objTabla[3].ToString();
                        txCantidad.Text = objTabla[4].ToString();
                        txEspecie.Text = objTabla[5].ToString();
                    }
                    else
                    {
                        MessageBox.Show("El animal no existe.");
                        txNombre.Text = "";
                        txPrecio.Text = "";
                        txCantidad.Text = "";
                        txEspecie.Text = "";
                    }
                }
                catch (SqlException exx)
                {
                    MessageBox.Show("Error en la consulta " + exx.Message);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error en la conexión " + ex.Message);
            }
        }

        private void Actualizar_Load(object sender, EventArgs e)
        {

        }
    }
}
