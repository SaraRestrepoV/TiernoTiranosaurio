using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Drawing.Imaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TiernoTiranosaurioI
{
    public partial class PorCodigo : Form
    {

        SqlConnection objConector;
        SqlDataReader objTabla;
        

        public PorCodigo()
        {
            InitializeComponent();
            

            Anuncio.Visible = false;
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            
            try
            {
                cbCodigo.Enabled = false;
                objConector = DB.conectar("TIERNOTIRANOSAURIO");
                int codigo = Int32.Parse(cbCodigo.Text);
                string ConsultaSQL = "SELECT * FROM MASCOTAS M INNER JOIN ESPECIE E ON(M.ESPECIE = E.CODIGO) WHERE M.CODIGO =" + codigo;
                try
                {
                    objTabla = DB.consulta(ConsultaSQL, objConector);
                    if (objTabla.Read())
                    {
                        string imagen = objTabla[1].ToString();

                        txNombre.Text = objTabla[2].ToString();
                        txPrecio.Text = objTabla[3].ToString();
                        txCantidad.Text = objTabla[4].ToString();

                        if (string.IsNullOrEmpty(imagen))
                        {
                            pbImagen.Image = null;
                            Anuncio.Visible = true;
                            Anuncio.Text = "ESTA MASCOTA NO CUENTA CON UNA IMAGEN";
                        }
                        else
                        {
                            Image img = Image.FromFile(imagen);
                            pbImagen.Image = img;
                        }
                        pbImagen.SizeMode = PictureBoxSizeMode.StretchImage;
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

        private void btBorrar_Click(object sender, EventArgs e)
        {
            txNombre.Text = "";
            txEspecie.Text = "";
            txCantidad.Text = "";
            txPrecio.Text = "";
            pbImagen.Image = null;
            cbCodigo.Enabled = true;
            Anuncio.Visible = false;
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PorCodigo_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSetFinal.MASCOTAS' Puede moverla o quitarla según sea necesario.
            this.mASCOTASTableAdapter1.Fill(this.dataSetFinal.MASCOTAS);
            // TODO: esta línea de código carga datos en la tabla 'tIERNOTIRANOSAURIODataSet.MASCOTAS' Puede moverla o quitarla según sea necesario.
            //this.mASCOTASTableAdapter.Fill(this.tIERNOTIRANOSAURIODataSet.MASCOTAS);

        }
                       
    }
}
