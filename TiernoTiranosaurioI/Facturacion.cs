using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TiernoTiranosaurioI
{

    public partial class Facturacion : Form
    {
        string[,] ListaVenta = new string[50, 6];
        int Fila = 0;
        string cantidadInventario = "";
        SqlConnection objConector;
        SqlDataReader objTabla;
        int numFactura = 0;

        bool UsuarioVerificado = false;

        public Facturacion()
        {
            InitializeComponent();

            DateTime thisDay = DateTime.Today;
            lbFecha.Text = thisDay.ToString("d");
            cbCodigo.SelectedIndex = 0;
            cbNombre.SelectedIndex = 0;

            try
            {
                objConector = DB.conectar("TIERNOTIRANOSAURIO");
                string ConsultaSQL = "select MAX(F.ID) FROM FACTURA F";
                try
                {
                    objTabla = DB.consulta(ConsultaSQL, objConector);
                    if (objTabla.Read())
                    {
                        numFactura = int.Parse(objTabla[0].ToString()) + 1;
                        lbFactura.Text = numFactura.ToString();

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

        private void btCargar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbCodigo.Text != "" && cbNombre.Text != "" && txPrecio.Text != "" && txCantidad.Text != "")
                {
                    ListaVenta[Fila, 0] = cbCodigo.Text;
                    ListaVenta[Fila, 1] = cbNombre.Text;
                    ListaVenta[Fila, 2] = txPrecio.Text;
                    ListaVenta[Fila, 3] = txCantidad.Text;
                    ListaVenta[Fila, 4] = (double.Parse(txPrecio.Text) * double.Parse(txCantidad.Text)).ToString();
                    ListaVenta[Fila, 5] = (double.Parse(ListaVenta[Fila, 4]) * 0.19).ToString();

                    if (double.Parse(txCantidad.Text) <= double.Parse(cantidadInventario))
                    {
                        dgvLista.Rows.Add(ListaVenta[Fila, 0], ListaVenta[Fila, 1], ListaVenta[Fila, 2], ListaVenta[Fila, 3], ListaVenta[Fila, 4], ListaVenta[Fila, 5]);

                        Fila = Fila + 1;
                        cbCodigo.Text = cbNombre.Text = txPrecio.Text = txCantidad.Text = "";

                    }
                    else
                    {
                        txPrecio.Text = "";
                        txCantidad.Text = "";

                    }

                    cbCodigo.FindForm();
                }
                else
                {
                    MessageBox.Show("Favor ingrese todos los campos");
                    txPrecio.Text = "";
                }
            }
            catch
            {

            }
            txSubtotal.Text = Recorrer(4);
            txTotalIVA.Text = Recorrer(5);
            txTotalPagar.Text = (double.Parse(txSubtotal.Text) + double.Parse(txTotalIVA.Text)).ToString();
            cbCodigo.Focus();
            cbCodigo.SelectedIndex = 0;
            cbNombre.SelectedIndex = 0;



        }

        public string Recorrer(int tipo)
        {
            double total = 0;
            int conteo = dgvLista.RowCount;

            for (int i = 0; i < conteo - 1; i++)
            {
                total += double.Parse(dgvLista.Rows[i].Cells[tipo].Value.ToString());
            }
            return total.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txTotalPagar.Text) || string.IsNullOrEmpty(txTotalIVA.Text))
            {
                txEfectivo.Text = "";
                MessageBox.Show("Debes ingresar un producto antes");
            }

            _ = string.IsNullOrEmpty(txEfectivo.Text) ? txEfectivo.Text = "" : txDevolucion.Text = (double.Parse(txEfectivo.Text) - (double.Parse(txTotalPagar.Text))).ToString();

        }

        private void Facturacion_Load(object sender, EventArgs e)
        {
            CriteriosBusqueda("CODIGO");
            CriteriosBusqueda("NOMBRE");
        }

        private void CriteriosBusqueda(string tipoBusqueda)
        {

            objConector = DB.conectar("TIERNOTIRANOSAURIO");
            string ConsultaSQL = "SELECT " + tipoBusqueda + " FROM MASCOTAS";
            // string ConsultaSQL = "SELECT NOMBRE FROM MASCOTAS";
            try
            {
                objTabla = DB.consulta(ConsultaSQL, objConector);

                while (objTabla.Read())
                {
                    if (tipoBusqueda == "CODIGO") cbCodigo.Items.Add(objTabla[tipoBusqueda].ToString());
                    if (tipoBusqueda == "NOMBRE") cbNombre.Items.Add(objTabla[tipoBusqueda].ToString());
                }

            }
            catch (SqlException exx)
            {
                MessageBox.Show("Error en la consulta " + exx.Message);
            }
        }

        private void btBuscarCodigo_Click(object sender, EventArgs e)
        {
            BuscarPor("CODIGO", cbCodigo.Text);
        }

        private void btBuscarNombre_Click(object sender, EventArgs e)
        {
            BuscarPor("NOMBRE", cbNombre.Text);
        }

        private void BuscarPor(string tpoParametro, string Parametro)
        {
            objConector = DB.conectar("TIERNOTIRANOSAURIO");
            //int codigo = Int32.Parse(cbCodigo.Text);
            string ConsultaSQL = "SELECT CODIGO, NOMBRE, PRECIO, CANTIDAD FROM MASCOTAS WHERE " + tpoParametro + " = '" + Parametro + "'";
            try
            {
                objTabla = DB.consulta(ConsultaSQL, objConector);
                if (objTabla.Read())
                {
                    if (tpoParametro == "CODIGO")
                    {
                        cbNombre.Text = objTabla[1].ToString();
                        txPrecio.Text = objTabla[2].ToString();
                        cantidadInventario = objTabla[3].ToString();

                    }
                    if (tpoParametro == "NOMBRE")
                    {
                        cbCodigo.Text = objTabla[0].ToString();
                        txPrecio.Text = objTabla[2].ToString();
                        cantidadInventario = objTabla[3].ToString();
                    }
                }

            }
            catch (SqlException exx)
            {
                MessageBox.Show("Error en la consulta " + exx.Message);
            }

        }

        private void txCedula_Leave(object sender, EventArgs e)
        {
            objConector = DB.conectar("TIERNOTIRANOSAURIO");

            if (!string.IsNullOrEmpty(txCedula.Text))
            {
                try
                {
                    int cedula = Int32.Parse(txCedula.Text);
                    string ConsultaSQL = "SELECT ID, NOMBRE, APELLIDO FROM CLIENTE WHERE ID = " + cedula;
                    objTabla = DB.consulta(ConsultaSQL, objConector);
                    if (objTabla.Read())
                    {
                        txNombre.Text = objTabla[1].ToString();
                        txApellido.Text = objTabla[2].ToString();
                        gbFactura.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("El usuario no se encuentra registrado");
                        btInsertar.Enabled = true;
                    }

                }
                catch (SqlException exx)
                {
                    MessageBox.Show("Error en la consulta " + exx.Message);
                }
            }

        }

        private void btInsertar_Click(object sender, EventArgs e)
        {
            if (txCedula.Text != null && txNombre.Text != null && txApellido.Text != null)
            {
                objConector = DB.conectar("TIERNOTIRANOSAURIO");
                int cedula = Int32.Parse(txCedula.Text);
                string nombre = txNombre.Text;
                string apellido = txApellido.Text;
                string ConsultaSQL = "INSERT INTO CLIENTE VALUES (" + cedula + ",'" + nombre + "','" + apellido + "')";
                int n = DB.operar(ConsultaSQL, objConector);

                if (n > 0)
                {
                    MessageBox.Show("Usuario ingresado correctamente");
                    gbFactura.Enabled = true;
                }
                if (n == 0)
                {
                    MessageBox.Show("No se pudo ingresar el usuario");
                    btInsertar.Enabled = false;
                }



            }
        }

        private void btVender_Click(object sender, EventArgs e)
        {
            if (double.Parse(txTotalPagar.Text) < double.Parse(txEfectivo.Text))
            {

                int idCliente = int.Parse(txCedula.Text);
                float total = float.Parse(txTotalPagar.Text);
                float iva = float.Parse(txTotalIVA.Text);
                int cantidad = 0;
                objConector = DB.conectar("TIERNOTIRANOSAURIO");
                string consultaSql = "INSERT INTO FACTURA (ID_CLIENTE, TOTAL, IVA, CANTIDAD) VALUES (" + idCliente + "," + total + "," + iva + "," + cantidad + ");";
                int n = DB.operar(consultaSql, objConector);
                if (n > 0)
                {
                    MessageBox.Show("Factura creada");

                    int numCampos = dgvLista.RowCount - 1;

                    for (int i = 0; i < numCampos; i++)
                    {
                        int idMascota = Int32.Parse((ListaVenta[i, 0]));
                        int mascotaCantidad = Int32.Parse(ListaVenta[i, 3]);
                        double totxMascota = double.Parse(ListaVenta[i, 4]);
                        //float TotalFactura = ;

                        MessageBox.Show("" + numFactura);

                        string consultaSql2 = "insert into DETALLE_FACTURA VALUES ( " + numFactura + "," + idMascota + "," + mascotaCantidad + "," + totxMascota + ")";
                        int respuestaConsulta = DB.operar(consultaSql2, objConector);
                        if (respuestaConsulta == 0)
                        {
                            MessageBox.Show("Ocurrió un error al guardar los productos");
                        }
                        MessageBox.Show("Ocurrió un error al guardar los productos");
                    }
                }
                else
                {
                    MessageBox.Show("No se pudo realizar la actualización");
                }
            }
            else
            {
                MessageBox.Show("El efectivo ingresado no puede ser inferior al valor total a pagar");
                txEfectivo.Focus();
            }

        }

    }
}
