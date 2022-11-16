using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TiernoTiranosaurioI
{
    public partial class ImpresionCotizacion : Form
    {
        public ImpresionCotizacion()
        {
            InitializeComponent();
            DateTime thisDay = DateTime.Today;
            lbFecha.Text = thisDay.ToString("d");
            this.ControlBox = false;
        }

        

        private void ImpresionCotizacion_Load(object sender, EventArgs e)
        {
            Cotizacion objCotizacion = new Cotizacion();
            objCotizacion.Close();
        }

        public void DatosMascota()
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txDatosMascota_TextChanged(object sender, EventArgs e)
        {

        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            txDatosMascota.Text = "";
            this.Close();
        }
    }
}
