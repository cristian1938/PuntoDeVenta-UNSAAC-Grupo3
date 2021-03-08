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
    public partial class FrmProductos : Form
    {
        private DataSet aDatos;

        public string[] DatosT = new string[5];

        public FrmProductos()
        {
            InitializeComponent();
            
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
        public DataTable buscarproductos(string Pdescripcion)
        {
            string Consulta = "select * from TAlmacenProductos where Descripcion like '" + Pdescripcion + "%'";
           
          EjecutarSelect(Consulta);
            return Datos.Tables[0];
        }


        private void txtproductos_TextChanged(object sender, EventArgs e)
        {
           dgvproductos.DataSource= buscarproductos(txtproductos.Text);
            dgvproductos.Columns["Unidad"].Visible = false;
            dgvproductos.Columns["PrecioUnitario"].Visible = false;
            dgvproductos.Columns["Descripcion"].Width = 230;
        }
        public string[] obtenerDatos(string pCodigo)
        {
            string[] datos= new string[5];
            string Consulta = "select * from TAlmacenProductos where CodigoProducto= '" + pCodigo + "'";
            EjecutarSelect(Consulta);
            datos[0] = ValorAtributo("CodigoProducto");
            datos[1] = ValorAtributo("Descripcion");
           datos[2] = ValorAtributo("PrecioUnitario");
           datos[3] = ValorAtributo("Cantidad");
            
           
            DatosT = datos;
            return datos;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // string codigo = dgvproductos[0, dgvproductos.CurrentCell.RowIndex].Value.ToString();
            // DatosT = obtenerDatos(codigo);
            // obtenerdatos();
            // txtproductos.Text = DatosT[0];
            //Close();
            if (dgvproductos.SelectedRows.Count == 1)
            {
                string pCodigo = dgvproductos.CurrentRow.Cells[0].Value.ToString();
                string codigo = dgvproductos[2, dgvproductos.CurrentCell.RowIndex].Value.ToString();
                DatosT = obtenerDatos(pCodigo);
                Close();
            }

            if (dgvproductos[1, dgvproductos.CurrentCell.RowIndex].Value.ToString()==" ")
            {
                string codigo = dgvproductos[0, dgvproductos.CurrentCell.RowIndex].Value.ToString();
   
                DatosT = obtenerDatos(codigo);
                Close();
            }
            if (dgvproductos[2, dgvproductos.CurrentCell.RowIndex].Value.ToString() != " ")
            {
                string codigo = dgvproductos[0, dgvproductos.CurrentCell.RowIndex].Value.ToString();
               
                DatosT = obtenerDatos(codigo);
                Close();
            }
            else
            {
                MessageBox.Show("No ha seleccionado ningún alumno", "ALERTA");
            }
        }
        public string[] obtenerdatos()
        {
            return DatosT;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
