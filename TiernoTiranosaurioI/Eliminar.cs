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
    public partial class Eliminar : Form
    {
        SqlConnection objConector;
        SqlDataReader objTabla;
        public Eliminar()
        {
            InitializeComponent();
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {

            try
            {
                objConector = DB.conectar("TIERNOTIRANOSAURIO");
                int codigo = Int32.Parse(txCodigo.Text);
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

        private void btEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                objConector = DB.conectar("BDVETERINARIA");
                int codi = Int32.Parse(txCodigo.Text);
                string ConsultaSQL1 = "DELETE from mascotas  where codigo= " + codi;
                int n = DB.operar(ConsultaSQL1, objConector);
                if (n > 0)
                {
                    MessageBox.Show("Se ha eliminado la mascota: " + codi);
                }
                else
                {
                    MessageBox.Show("No se pudo realizar la Eliminación");
                }

            }
            catch (SqlException EXX)
            {
                MessageBox.Show("No se pudo eliminar");
            }

            btEliminar.Enabled = false;
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
