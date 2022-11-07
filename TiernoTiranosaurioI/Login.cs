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
    public partial class Login : Form
    {
        SqlConnection objConector;
        SqlDataReader objTabla;

        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        
        private void txUsuario_TextChanged(object sender, EventArgs e)
        {
           
        }

       
        private void txCod_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string usuario = txUsuario.Text;

            try
            {
                objConector = DB.conectar("TIERNOTIRANOSAURIO");
                //MessageBox.Show("Se realizó la conexión");
                string ConsultaSQL = "Select * from USUARIO where usuario = '" + usuario + "'";

                try
                {
                    objTabla = DB.consulta(ConsultaSQL, objConector);
                    if (objTabla.Read())
                    {
                        txContraseña.Visible = true;
                        btIniciar.Visible = true;
                        lbContraseña.Visible = true;
                        txUsuario.Enabled = false;
                        button1.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("El usuario no existe.");
                        txUsuario.Text = "";
                    }

                }
                catch (SqlException exx)
                {
                    MessageBox.Show("Error en la consulta " + exx.Message);
                }
                DB.cerrar(objConector);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error en la conexión " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string usuario = txUsuario.Text;
            string contraseña = txContraseña.Text;
            try
            {
                objConector = DB.conectar("TIERNOTIRANOSAURIO");
                //MessageBox.Show("Se realizó la conexión");
                string ConsultaSQL = "Select * from USUARIO where usuario = '" + usuario + "'";

                try
                {
                    objTabla = DB.consulta(ConsultaSQL, objConector);
                    if (objTabla.Read())
                    {
                        string contra = objTabla[3].ToString();
                        if(contra == contraseña)
                        {
                            this.Hide();
                            Menú objMenu = new Menú();
                            objMenu.ShowDialog();
                           
                        }
                    }
                    else
                    {
                        MessageBox.Show("El usuario no existe.");
                        txUsuario.Text = "";
                    }

                }
                catch (SqlException exx)
                {
                    MessageBox.Show("Error en la consulta " + exx.Message);
                }
                DB.cerrar(objConector);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error en la conexión " + ex.Message);
            }
        }
    }

}
    

