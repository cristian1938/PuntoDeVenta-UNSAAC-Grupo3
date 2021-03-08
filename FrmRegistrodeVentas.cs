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
using System.Runtime;


namespace Proyecto_Metodologia
{
    public partial class FrmRegistrodeVentas : Form
    {
        private DataSet aDatos;
        public FrmRegistrodeVentas()
        {
            InitializeComponent();
            dateTimeVentas.Value = DateTime.Now;
            lbHora.Text = DateTime.Now.TimeOfDay.Hours.ToString() +":"+ DateTime.Now.TimeOfDay.Minutes.ToString();
            dgventas.DataSource = buscarproductos();
            dgventas.Columns["CodVenta"].Width = 150;
            dgventas.Columns["CodVenta"].HeaderText = "Codigo de Venta";
            dgventas.Columns["PrecioTotal"].Width = 132;
            dgventas.Columns["Fecha"].Width = 150;
            txttotal.Text = dgventas.Rows.Count.ToString();
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
        public DataTable buscarproductos()
        {
            string Consulta = "SELECT * FROM TVentas WHERE Fecha =" +
                " '" + dateTimeVentas.Value.Year+"/"+dateTimeVentas.Value.Month +"/"+dateTimeVentas.Value.Day+ "'";

            EjecutarSelect(Consulta);
            return Datos.Tables[0];

        }

        private void dateTimeVentas_ValueChanged(object sender, EventArgs e)
        {
            dgventas.DataSource = buscarproductos();
            dgventas.Columns["CodVenta"].Width = 150;
            dgventas.Columns["CodVenta"].HeaderText = "Codigo de Venta";
            dgventas.Columns["PrecioTotal"].Width = 132;
            dgventas.Columns["Fecha"].Width = 150;

        }
        public void actualizarEstadodeVenta(string codproducto)
        {
            string Consulta = "update TVentas set Estado ='CANCELADO' where CodVenta='" + codproducto + "'";

            EjecutarSelect(Consulta);
        }
        private void iconButton2_Click(object sender, EventArgs e)
        {
            if (dgventas[1, dgventas.CurrentCell.RowIndex].Value.ToString() == " ")
            {
                string codigo = dgventas[0, dgventas.CurrentCell.RowIndex].Value.ToString();
                string estado = dgventas[3, dgventas.CurrentCell.RowIndex].Value.ToString();
                if (estado == "CANCELADO")
                {
                    MessageBox.Show("LA VENTA YA FUE CANCELADA");
                }
                else
                {
                    actualizarEstadodeVenta(codigo);
                    
                }
              

            }
            if (dgventas[2, dgventas.CurrentCell.RowIndex].Value.ToString() != " ")
            {
                string codigo = dgventas[0, dgventas.CurrentCell.RowIndex].Value.ToString();
                string estado = dgventas[3, dgventas.CurrentCell.RowIndex].Value.ToString();
                if (estado == "CANCELADO")
                {
                    MessageBox.Show("LA VENTA YA FUE CANCELADA");
                }
                else
                {
                    actualizarEstadodeVenta(codigo);
                    
                }

            }
            else
            {
                MessageBox.Show("No ha seleccionado ningún alumno", "ALERTA");
            }

            dgventas.DataSource = buscarproductos();
            dgventas.Columns["CodVenta"].Width = 150;
            dgventas.Columns["CodVenta"].HeaderText = "Codigo de Venta";
            dgventas.Columns["PrecioTotal"].Width = 132;
            dgventas.Columns["Fecha"].Width = 150;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
