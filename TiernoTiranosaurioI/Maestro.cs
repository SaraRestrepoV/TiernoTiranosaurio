using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TiernoTiranosaurioI
{
    public partial class Menú : Form
    {
        public Menú()
        {
            InitializeComponent();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void porToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void retirarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void tsSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tsOperaciones_Click(object sender, EventArgs e)
        {

        }

        private void porCódigoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PorCodigo objCodigo = new PorCodigo();
            objCodigo.MdiParent = this;
            objCodigo.Show();

            pbDino.Visible = false;
            panelVerde.Visible = false;
        }

        private void porNombreToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PorNombre objNombre = new PorNombre();
            objNombre.MdiParent = this;
            objNombre.Show();

            pbDino.Visible = false;
            panelVerde.Visible = false;
        }

        private void tsFactura_Click(object sender, EventArgs e)
        {
            Facturacion objFactura = new Facturacion();
            objFactura.MdiParent = this;
            objFactura.Show();

            pbDino.Visible = false;
            panelVerde.Visible = false;

        }

        private void tsCotizacion_Click(object sender, EventArgs e)
        {
            Cotizacion objCotizacion = new Cotizacion();
            objCotizacion.MdiParent = this;
            objCotizacion.Show();

            pbDino.Visible = false;
            panelVerde.Visible = false;
        }
    }
}
