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
    public partial class FrmArqueo : Form
    {
        private DataSet aDatos;
        public FrmArqueo()
        {
            InitializeComponent();
            lbHora.Text = DateTime.Now.TimeOfDay.Hours.ToString() + ":" + DateTime.Now.TimeOfDay.Minutes.ToString();
            dateTimeArqueo.Value = DateTime.Now;
            validarfecha();
            dgventas.Columns["CodVenta"].Width = 150;
            dgventas.Columns["CodVenta"].HeaderText = "Codigo de Venta";
            dgventas.Columns["PrecioTotal"].Width = 160;
            dgventas.Columns["Fecha"].Width = 175;
            dgventas.Columns["Estado"].Visible = false;
            total();
        }

        private void btnConteo_Click(object sender, EventArgs e)
        {
            FrmConteo c = new FrmConteo();
            c.ShowDialog();
            double b = c.obtenerdatos();
            if (b != 0)
            {
                txtconteo.Text = b.ToString();
            }
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
        private void dateTimeArqueo_ValueChanged(object sender, EventArgs e)
        {
           dgventas.DataSource= validarfecha();
            dgventas.Columns["CodVenta"].Width = 150;
            dgventas.Columns["CodVenta"].HeaderText = "Codigo de Venta";
            dgventas.Columns["PrecioTotal"].Width = 160;
            dgventas.Columns["Fecha"].Width = 175;
            dgventas.Columns["Estado"].Visible = false;
            total();
            lbHora.Text = DateTime.Now.TimeOfDay.Hours.ToString() + ":" + DateTime.Now.TimeOfDay.Minutes.ToString();
        }
        public DataTable validarfecha()
        {
            string Consulta = "SELECT * FROM TVentas WHERE Fecha" +
                " = '" + dateTimeArqueo.Value.Year + "/" + dateTimeArqueo.Value.Month + "/" + dateTimeArqueo.Value.Day + "'" +
                "AND Estado='VENDIDO'";
          
            EjecutarSelect(Consulta);
            return Datos.Tables[0];
        }
        public void total()
        {
            int i = 0;
            double total = 0;
            double sub = 0;
            Math.Round(total, 2);
            Math.Round(sub, 2);
            while (i<dgventas.RowCount)
            {
                sub = double.Parse(dgventas[1, i].Value.ToString());
                total = total + sub;
                i++;
            }
            txttotal.Text = total.ToString();
        }

        private void txtconteo_TextChanged(object sender, EventArgs e)
        {
            if(txttotal.Text!="" && txtconteo.Text != "")
            {
                double diferencia = (double.Parse(txttotal.Text) - double.Parse(txtconteo.Text));

                lbDiferencia.Text = Math.Round(diferencia, 2).ToString();
                lbHora.Text = DateTime.Now.TimeOfDay.Hours.ToString() + ":" + DateTime.Now.TimeOfDay.Minutes.ToString();
            }
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            FrmLogin test = new FrmLogin();
            test.ShowDialog();
            string usuario=test.usuario;
      
            string categoria = validarcategoria(usuario);
            string Consulta = "insert into arqueo values('"+usuario+"','"+categoria+"','"+
                dateTimeArqueo.Value.Year + "/" + dateTimeArqueo.Value.Month + "/" + dateTimeArqueo.Value.Day 
                +"','"+lbHora.Text+ "','"+lbDiferencia.Text+"','"+txttotal.Text+"')";

            EjecutarSelect(Consulta);
            txttotal.Text = "";
            txtconteo.Text = "";
            lbDiferencia.Text = "";
        }
        public string validarcategoria(String pusuario)
        {
            string Datos;
            string Consulta = "select * from TUsuarios where  Usuario='" + pusuario + "'";
            EjecutarSelect(Consulta);
            Datos = ValorAtributo("Categoria");
            return Datos;
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            FrmRegistroArqueo re = new FrmRegistroArqueo();
            re.ShowDialog();
        }
    }
}
