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
    public partial class Cotizacion : Form
    {
        string[,] ListaVenta = new string[50, 6];
        int Fila = 0;
        string cantidadInventario = "";
        SqlConnection objConector;
        SqlDataReader objTabla;
        public static string imprimirCotizacion = "";
        public static string infoUsuario = "";
        ImpresionCotizacion objCotizar = new ImpresionCotizacion();

        bool UsuarioVerificado = false;

        public Cotizacion()
        {

            InitializeComponent();
            DateTime thisDay = DateTime.Today;
            lbFecha.Text = thisDay.ToString("d");
            cbCodigo.SelectedIndex = 0;
            cbNombre.SelectedIndex = 0;
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
                    ListaVenta[Fila, 4] = (float.Parse(txPrecio.Text) * float.Parse(txCantidad.Text)).ToString();
                    ListaVenta[Fila, 5] = (float.Parse(ListaVenta[Fila, 4]) * 0.19).ToString();

                    dgvLista.Rows.Add(ListaVenta[Fila, 0], ListaVenta[Fila, 1], ListaVenta[Fila, 2], ListaVenta[Fila, 3], ListaVenta[Fila, 4], ListaVenta[Fila, 5]);

                    imprimirCotizacion = imprimirCotizacion + " "+ ListaVenta[Fila, 0] + "\t\t " + ListaVenta[Fila, 1] + "\t" + ListaVenta[Fila, 2] + "\t\t" + ListaVenta[Fila, 3]+ "\t\t" + ListaVenta[Fila, 4]+ "\t " + ListaVenta[Fila, 5] + "\r\n";

                    Fila = Fila + 1;
                    cbCodigo.Text = cbNombre.Text = txPrecio.Text = txCantidad.Text = "";

                    cbCodigo.FindForm();
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
            cbCodigo.Focus();
            cbCodigo.SelectedIndex = 0;
            cbNombre.SelectedIndex = 0;


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
            int cedula = Int32.Parse(txCedula.Text);
            string ConsultaSQL = "SELECT ID, NOMBRE, APELLIDO FROM CLIENTE WHERE ID = " + cedula;
            try
            {
                objTabla = DB.consulta(ConsultaSQL, objConector);
                if (objTabla.Read())
                {
                    txNombre.Text = objTabla[1].ToString();
                    txApellido.Text = objTabla[2].ToString();
                    UsuarioVerificado = true;

                    infoUsuario = "Datos usuario: \r\n" + "Identificación: " + objTabla[0].ToString() + "\r\nNombre: " + objTabla[1].ToString() + "\r\nApellido: " + objTabla[2].ToString();
                    txCedula.Enabled = txNombre.Enabled = txApellido.Enabled = false;
                    
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
                    MessageBox.Show("Usuario ingresado");
                    txCedula.Enabled = txNombre.Enabled = txApellido.Enabled = false;
                    btInsertar.Enabled = false;
                }
                if (n == 0)
                {
                    MessageBox.Show("No se pudo ingresar el usuario");
                    btInsertar.Enabled = false;
                }

            }
        }

        private void Cotizacion_Load(object sender, EventArgs e)
        {
            CriteriosBusqueda("CODIGO");
            CriteriosBusqueda("NOMBRE");
        }

        private void btCotizar_Click(object sender, EventArgs e)
        {
            

            objCotizar.Show();


            objCotizar.txDatosMascota.Text = imprimirCotizacion;
            objCotizar.txDatosUsuario.Text = infoUsuario;
            infoUsuario = "";
            imprimirCotizacion = "";
            this.Close();
        }

        private void txCedula_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
