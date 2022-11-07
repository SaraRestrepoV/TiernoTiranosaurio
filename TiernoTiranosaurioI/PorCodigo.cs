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
    public partial class PorCodigo : Form
    {

        SqlConnection objConector;
        SqlDataReader objTabla;

        public PorCodigo()
        {
            InitializeComponent();
        }

        private void PorCodigo_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'tIERNOTIRANOSAURIODataSet1.MASCOTAS' Puede moverla o quitarla según sea necesario.
            this.mASCOTASTableAdapter.Fill(this.tIERNOTIRANOSAURIODataSet1.MASCOTAS);

        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                objConector = DB.conectar("TIERNOTIRANOSAURIO");
                int codigo = Int32.Parse(cbCodigo.Text);
                string ConsultaSQL = "SELECT * FROM MASCOTAS M INNER JOIN ESPECIE E ON(M.ESPECIE = E.CODIGO) WHERE M.CODIGO =" + codigo;               
                try
                {
                    objTabla = DB.consulta(ConsultaSQL, objConector);                  
                    if (objTabla.Read())
                    {
                        txNombre.Text = objTabla[2].ToString();
                        txPrecio.Text = objTabla[3].ToString();
                        txCantidad.Text = objTabla[4].ToString();
                        txEspecie.Text = objTabla[7].ToString();
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
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
