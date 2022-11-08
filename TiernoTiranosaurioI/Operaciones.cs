using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace TiernoTiranosaurioI
{
    public partial class Operaciones : Form
    {

        public static string codigoDG;
        public static string nombreDG;
        public static string precioDG;
        public static string cantidadDG;
        public static string especieDG;
        public Operaciones()
        {
            InitializeComponent();
            DateTime thisDay = DateTime.Today;
            lbFecha.Text = thisDay.ToString("d");
        }

        private void Operaciones_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'tIERNOTIRANOSAURIODataSet.MASCOTAS' Puede moverla o quitarla según sea necesario.
           this.mASCOTASTableAdapter.Fill(this.tIERNOTIRANOSAURIODataSet.MASCOTAS);
            // TODO: esta línea de código carga datos en la tabla 'tIERNOTIRANOSAURIODataSet1.MASCOTAS' Puede moverla o quitarla según sea necesario.

        }

        private void btNuevo_Click(object sender, EventArgs e)
        {
            Agregar objAgregar = new Agregar();
            objAgregar.Show();
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            Eliminar objE = new Eliminar();
            objE.Show();

            if (codigoDG == "")
            {
                MessageBox.Show("Seleccione una fila a editar", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //Hacer el modifier de los textbox a cambiar, público
                objE.txCodigo.Text = codigoDG;
                objE.txNombre.Text = nombreDG;
                objE.txPrecio.Text = precioDG;
                objE.txCantidad.Text = cantidadDG;
                objE.txEspecie.Text = especieDG;
            }

        }
       

        private void btEditar_Click(object sender, EventArgs e)
        {
            Actualizar objAct = new Actualizar();
            objAct.Show();

            if (codigoDG == "") {
                MessageBox.Show("Seleccione una fila a editar", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                objAct.txCodigo.Text = codigoDG;
                objAct.txNombre.Text = nombreDG;
                objAct.txPrecio.Text = precioDG;
                objAct.txCantidad.Text = cantidadDG;
                objAct.txEspecie.Text = especieDG;
            }

          
          
        }

        private void dgvAnimales_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            codigoDG = dgvAnimales.Rows[e.RowIndex].Cells["CODIGO"].Value.ToString();
            nombreDG = dgvAnimales.Rows[e.RowIndex].Cells["NOMBRE"].Value.ToString();
            precioDG = dgvAnimales.Rows[e.RowIndex].Cells["PRECIO"].Value.ToString();
            cantidadDG = dgvAnimales.Rows[e.RowIndex].Cells["CANTIDAD"].Value.ToString();
            especieDG = dgvAnimales.Rows[e.RowIndex].Cells["ESPECIE"].Value.ToString();
        }

        private void dgvAnimales_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
