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
    public partial class Facturacion : Form
    {
        public Facturacion()
        {
            InitializeComponent();
        }
        string[,] ListaVenta = new string[50,6];
        int Fila = 0;
       
        private void btCargar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txCodigo.Text != "" && txNombre.Text != "" && txPrecio.Text != "" && txCantidad.Text != "") ;
                {
                    ListaVenta[Fila, 0] = txCodigo.Text;
                    ListaVenta[Fila, 1] = txNombre.Text;
                    ListaVenta[Fila, 2] = txPrecio.Text;
                    ListaVenta[Fila, 3] = txCantidad.Text;
                    ListaVenta[Fila, 4] = (float.Parse(txPrecio.Text) * float.Parse(txCantidad.Text)).ToString();
                    ListaVenta[Fila, 5] = (float.Parse(ListaVenta[Fila, 4]) * 0.19).ToString();

                    dgvLista.Rows.Add(ListaVenta[Fila, 0], ListaVenta[Fila, 1], ListaVenta[Fila, 2], ListaVenta[Fila, 3], ListaVenta[Fila, 4], ListaVenta[Fila, 5]);

                    Fila = Fila + 1;
                    txCodigo.Text = txNombre.Text = txPrecio.Text = txCantidad.Text = "";

                    txCodigo.FindForm();
                }
            }
            catch
            {

            }
            string TotalPagar = Recorrer(4);
            string TotalIVA = Recorrer(5);

            txTotalPagar.Text = TotalPagar;
            txTotalIVA.Text = TotalIVA;
        }

        public string Recorrer(int tipo)
        {
            float total = 0;
            int conteo = dgvLista.RowCount;

            for (int i = 0; i < conteo-1; i++)
            {
                total += float.Parse(dgvLista.Rows[i].Cells[tipo].Value.ToString());
            }
            return total.ToString();
        }
    }
}
