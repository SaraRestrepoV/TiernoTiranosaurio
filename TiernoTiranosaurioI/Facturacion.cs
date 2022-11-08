using System;
using System.Windows.Forms;

namespace TiernoTiranosaurioI
{
    public partial class Facturacion : Form
    {
        string[,] ListaVenta = new string[50, 6];
        int Fila = 0;
        float cantidadInventario = 0;



        public Facturacion()
        {
            InitializeComponent();

            DateTime thisDay = DateTime.Today;
            lbFecha.Text = thisDay.ToString("d");

        }

        private void btCargar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txCodigo.Text != "" && txNombre.Text != "" && txPrecio.Text != "" && txCantidad.Text != "")
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
                else
                {
                    MessageBox.Show("Favor ingrese todos los campos");
                }
            }
            catch
            {

            }
            txTotalPagar.Text = Recorrer(4);
            txTotalIVA.Text = Recorrer(5);
            txCodigo.Focus();

        }

        public string Recorrer(int tipo)
        {
            float total = 0;
            int conteo = dgvLista.RowCount;

            for (int i = 0; i < conteo - 1; i++)
            {
                total += float.Parse(dgvLista.Rows[i].Cells[tipo].Value.ToString());
            }
            return total.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txDevolucion.Text = (float.Parse(txEfectivo.Text) - (float.Parse(txTotalPagar.Text) + float.Parse(txTotalIVA.Text))).ToString();
            }
            catch (Exception)
            {
                txDevolucion.Text = "0.0";
                throw;
            }
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            
        }

        public void Producto(string codigo, string nombre, string precio, string cantidad)
        {
            try
            {
                txCodigo.Text = codigo;
                txNombre.Text = nombre;
                txPrecio.Text = precio;

                cantidadInventario = float.Parse(cantidad);
            }
            catch
            {

            }

        }

    }
}
