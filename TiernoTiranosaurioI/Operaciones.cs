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
    public partial class Operaciones : Form
    {
        public Operaciones()
        {
            InitializeComponent();
        }

        private void Operaciones_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'tIERNOTIRANOSAURIODataSet1.MASCOTAS' Puede moverla o quitarla según sea necesario.
            this.mASCOTASTableAdapter.Fill(this.tIERNOTIRANOSAURIODataSet1.MASCOTAS);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btNuevo_Click(object sender, EventArgs e)
        {
            Agregar objAgregar = new Agregar();
            objAgregar.Show();
        }
    }
}
