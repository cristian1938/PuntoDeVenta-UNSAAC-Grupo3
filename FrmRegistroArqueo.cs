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
    public partial class FrmRegistroArqueo : Form
    {
        private DataSet aDatos;
        public FrmRegistroArqueo()
        {
            InitializeComponent();
            lbHora.Text = DateTime.Now.TimeOfDay.Hours.ToString() + ":" + DateTime.Now.TimeOfDay.Minutes.ToString();
            dateTimeArqueo.Value = DateTime.Now;
            dgventas.DataSource=  validarfecha2();

            //dgventas.Columns["CodVenta"].Width = 150;
            //dgventas.Columns["CodVenta"].HeaderText = "Codigo de Venta";
            //dgventas.Columns["PrecioTotal"].Width = 160;
            //dgventas.Columns["Fecha"].Width = 175;
            //dgventas.Columns["Estado"].Visible = false;
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
        public DataTable validarfecha()
        {
            string Consulta = "SELECT * FROM ARQUEO WHERE Fecha" +
                " = '" + dateTimeArqueo.Value.Year + "/" + dateTimeArqueo.Value.Month + "/" + dateTimeArqueo.Value.Day +"'";

            EjecutarSelect(Consulta);
            return Datos.Tables[0];
        }
        public DataTable validarfecha2()
        {
            string Consulta = "SELECT * FROM ARQUEO ";

            EjecutarSelect(Consulta);
            return Datos.Tables[0];
        }

        private void dateTimeArqueo_ValueChanged(object sender, EventArgs e)
        {
            dgventas.DataSource = validarfecha();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
