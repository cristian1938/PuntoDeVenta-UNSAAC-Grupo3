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
    public partial class FrmRegistroUsuarios : Form
    {
        private DataSet aDatos;
        public FrmRegistroUsuarios()
        {
            InitializeComponent();
            llenardatos();
        }
        public DataSet Datos
        {
            get { return aDatos; }
        }
        public DataSet EjecutarSelect(string pConsulta)
        {//-- Método para ejecutar consultas del tipo SELECT
            string cnn = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
            using (SqlConnection conexion = new SqlConnection(cnn))
            {
                conexion.Open();
                SqlDataAdapter a = new SqlDataAdapter();
                using (SqlCommand cmd = new SqlCommand(pConsulta, conexion)) ;
                a.SelectCommand = new SqlCommand(pConsulta, conexion);
                aDatos = new DataSet();
                // aAdaptador.Fill(aDatos);
                a.Fill(aDatos);
                conexion.Close();
            }
            return aDatos;
        }
        public string ValorAtributo(string pNombreCampo)
        {//-- Recupera el valor de un atributo del dataset
            if (Datos.Tables[0].Rows.Count > 0)
            {
                return Datos.Tables[0].Rows[0][pNombreCampo].ToString();
            }
            else
                return "";
        }

        private void dgvusuarios_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public DataTable datosusuarios()
        {
            string Consulta = "SELECT * FROM TUsuarios" ;

            EjecutarSelect(Consulta);
            return Datos.Tables[0];
        }
        public void llenardatos()
        {
            dgvusuarios.DataSource = datosusuarios();
            dgvusuarios.Columns["Contraseña"].Visible = false;
        }
        private void iconButton2_Click(object sender, EventArgs e)
        {
            try
            {
                string Consulta = "update TUsuarios " +
                    "set Usuario='" + txtusuario.Text + "',Nombre='" + txtNombre.Text + "',Apellido='" + txtApellido.Text
                    + "',Correo='" + txtCorreo.Text + "'where Usuario='" + dgvusuarios[0, dgvusuarios.CurrentCell.RowIndex].Value.ToString() + "'";

                EjecutarSelect(Consulta);
                MessageBox.Show("ACTUALIZACION CORRECTA");
                txtusuario.Text = "";
                txtNombre.Text = "";
                txtApellido.Text = "";
                txtCorreo.Text = "";
                llenardatos();
            }
            catch
            {
                MessageBox.Show("YA EXISTE ESE USUARIO ");
            }
        }

        private void dgvusuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                txtusuario.Text = dgvusuarios[0, dgvusuarios.CurrentCell.RowIndex].Value.ToString();
                txtNombre.Text = dgvusuarios[1, dgvusuarios.CurrentCell.RowIndex].Value.ToString();
                txtApellido.Text = dgvusuarios[2, dgvusuarios.CurrentCell.RowIndex].Value.ToString();
                txtCorreo.Text = dgvusuarios[5, dgvusuarios.CurrentCell.RowIndex].Value.ToString();
            }
            if (e.ColumnIndex == 1)
            {
                txtusuario.Text = dgvusuarios[0, dgvusuarios.CurrentCell.RowIndex].Value.ToString();
                txtNombre.Text = dgvusuarios[1, dgvusuarios.CurrentCell.RowIndex].Value.ToString();
                txtApellido.Text = dgvusuarios[2, dgvusuarios.CurrentCell.RowIndex].Value.ToString();
                txtCorreo.Text = dgvusuarios[5, dgvusuarios.CurrentCell.RowIndex].Value.ToString();
            }
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            string Consulta = "delete FROM TUsuarios where Usuario='" + dgvusuarios[0, dgvusuarios.CurrentCell.RowIndex].Value.ToString() +"'";
            EjecutarSelect(Consulta);
            MessageBox.Show("ELIMINACION CORRECTA");
            txtusuario.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtCorreo.Text = "";
            llenardatos();
        }
    }
}
