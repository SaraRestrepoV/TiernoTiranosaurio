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
    public partial class PorNombre : Form
    {

        SqlConnection objConector;
        SqlDataReader objTabla;

        public PorNombre()
        {
            InitializeComponent();
        }

        private void PorNomb_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'tIERNOTIRANOSAURIODataSet.MASCOTAS' Puede moverla o quitarla según sea necesario.
            this.mASCOTASTableAdapter.Fill(this.tIERNOTIRANOSAURIODataSet.MASCOTAS);
            // TODO: esta línea de código carga datos en la tabla 'tIERNOTIRANOSAURIODataSet.ESPECIE' Puede moverla o quitarla según sea necesario.
            this.eSPECIETableAdapter.Fill(this.tIERNOTIRANOSAURIODataSet.ESPECIE);

        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                objConector = DB.conectar("TIERNOTIRANOSAURIO");
                string nombre = cbNombre.Text;
                string ConsultaSQL = "SELECT * FROM MASCOTAS M INNER JOIN ESPECIE E ON(M.ESPECIE = E.CODIGO) WHERE M.NOMBRE = '" + nombre + "'";
                try
                {
                    objTabla = DB.consulta(ConsultaSQL, objConector);
                    if (objTabla.Read())
                    {
                        txCodigo.Text = objTabla[0].ToString();
                        txPrecio.Text = objTabla[3].ToString();
                        txCantidad.Text = objTabla[4].ToString();
                    }
                    else
                    {
                        MessageBox.Show("El animal no existe.");
                        txCodigo.Text = "";
                        txPrecio.Text = "";
                        txCantidad.Text = "";
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
            txPrecio.Text = "";
            txCodigo.Text = "";
            txCantidad.Text = "";
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
