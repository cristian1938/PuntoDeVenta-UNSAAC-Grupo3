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
    public partial class FrmSistemaVentas : Form
    {

        private DataSet aDatos;


        public DataSet Datos
        {
            get { return aDatos; }
        }
        //
        public FrmSistemaVentas()
        {
       
            InitializeComponent();
            FrmLogin test = new FrmLogin();
            test.ShowDialog();
            txtheadtext.Text = test.usuario ;
            txtcategoria.Text = validarcategoria(test.usuario);
            categoriarango();


        }

        public DataSet EjecutarSelect(string pConsulta)
        {//-- Método para ejecutar consultas del tipo SELECT
            string cnn = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
            using (SqlConnection conexion = new SqlConnection(cnn))
            {
                conexion.Open();
                SqlDataAdapter a = new SqlDataAdapter();
                using (SqlCommand cmd = new SqlCommand(pConsulta, conexion)) ;
                a.SelectCommand=new SqlCommand(pConsulta,conexion);
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
        public string  validarcategoria(String pusuario)
        {
            string Datos;
            string Consulta = "select * from TUsuarios where  Usuario='" + pusuario + "'";
            EjecutarSelect(Consulta);
            Datos = ValorAtributo("Categoria");
            return Datos;
        }
        public void categoriarango()
        {
            if (txtcategoria.Text == "Administrador")
            {
                btnventas.Visible = false;
            }
            if (txtcategoria.Text == "Cajero")
            {
                btnusuarios.Visible = false;
                btnregistro.Visible = false;
               
            }
        }
        private void AbrirFormularioHijo(Form FrmHijo)
        {

 
            FrmHijo.TopLevel = false;
            FrmHijo.FormBorderStyle = FormBorderStyle.None;
            FrmHijo.Dock = DockStyle.Fill;
            panelcontenido.Controls.Add(FrmHijo);
            panelcontenido.Tag = FrmHijo;
            FrmHijo.BringToFront();
            FrmHijo.Show();
        }
        private void btnusuarios_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FrmRegistro());
        }

        private void btnventas_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FrmVentas());
        }

        private void btnarqueo_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FrmArqueo());

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FrmRegistroUsuarios());
        }

        private void iconButton1_Click_1(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
