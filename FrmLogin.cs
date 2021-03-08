using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;


namespace Proyecto_Metodologia
{
    public partial class FrmLogin : Form
    {
     
        public string usuario;
        //------------------------------------------


        public FrmLogin()
        {
            InitializeComponent();
            buttonIngresar.Focus();
           
        }

        public void logins()
        {
            try
            {
                string cnn = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
                using (SqlConnection conexion = new SqlConnection(cnn))
                {
                    conexion.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT * from TUsuarios  WHERE TUsuarios.Usuario='" + txtusuario.Text + "' AND TUsuarios.Contraseña='" + txtcontraseña.Text + "'", conexion))
                    {
                        SqlDataReader dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            MessageBox.Show("Login exitoso.");
                            obtenerusuario();
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("Datos incorrectos.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        public string obtenerusuario()
        {
            usuario = txtusuario.Text;
            return usuario;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            logins();
        }

        private void buttonRegistrarse_Click(object sender, EventArgs e)
        {
            Form a = new FrmRegistro();
            a.ShowDialog();
           
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            FrmOlvidasteContraseña b = new FrmOlvidasteContraseña();
            b.ShowDialog();
        }
    }
}
