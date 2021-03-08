using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Proyecto_Metodologia
{
    public partial class FrmRegistro : Form
    {
        public FrmRegistro()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            registrar();
        }
         public void inicializar()
        {
            txtusuario.Text = "";
            txtNombre.Text = "";
             txtApellido.Text = "";
            txtCorreo.Text = "";
            txtContraseña.Text = "";
            txtRepitac.Text = "";
            txtDni.Text = "";
            radioAdministrador.Enabled = true;
            radioCajero.Enabled = true;

        }
        public void registrar()
        {
            try
            {
                string cnn = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
                using (SqlConnection conexion = new SqlConnection(cnn))
                {
                string opcion = "";
                    if (radioCajero.Checked)
                    {
                        radioAdministrador.Enabled = false;
                        opcion = radioCajero.Text;
                    }
                    if (radioAdministrador.Checked)
                    {
                        radioCajero.Enabled = false;
                        opcion = radioAdministrador.Text;
                    }

                    if (txtContraseña.Text == txtRepitac.Text)
                    {
                        conexion.Open();
                        using (SqlCommand cmd = new SqlCommand("insert into TUsuarios values ('" + txtusuario.Text + "', '" + txtContraseña.Text + "', '" + txtNombre.Text +
                            "', '" + txtApellido.Text + "', '" + txtDni.Text + "','" + txtCorreo.Text  + "','" + opcion + "')", conexion))
                        


                            cmd.ExecuteNonQuery();
                            conexion.Close();
                           MessageBox.Show("INGRESO EXITOSO");

                            
                        
                    }
                    else
                    {
                        MessageBox.Show("INGRESE LA CONTRASEÑA NO COINCIDE");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
