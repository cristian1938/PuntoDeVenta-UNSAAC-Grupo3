using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Metodologia
{
    public partial class FrmConteo : Form
    {

        public float dataConteo = 0;
        public FrmConteo()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            dataConteo = float.Parse(lbTotal.Text);
            Close();
        }
        public float obtenerdatos()
        {
            return dataConteo;
        }
        public static bool IsNumeric(object Expression)
        {
            double retNum;

            bool isNum = Double.TryParse(Convert.ToString(Expression), System.Globalization.NumberStyles.Any, System.Globalization.NumberFormatInfo.InvariantInfo, out retNum);
            return isNum;
        }
        private void tb200_TextChanged(object sender, EventArgs e)
        {
            double cn = tb200.Text == "" || !IsNumeric(tb200.Text) ? 0 : double.Parse(tb200.Text);
            lb200.Text = (cn * 200).ToString();
            total();
        }

        private void tb100_TextChanged(object sender, EventArgs e)
        {
            double cn = tb100.Text == "" || !IsNumeric(tb100.Text) ? 0 : double.Parse(tb100.Text);
            lb100.Text = (cn * 100).ToString();
            total();
        }

        private void tb50_TextChanged(object sender, EventArgs e)
        {
            double cn = tb50.Text == "" || !IsNumeric(tb50.Text) ? 0 : double.Parse(tb50.Text);
            lb50.Text = (cn * 50).ToString();
            total();
        }

        private void tb20_TextChanged(object sender, EventArgs e)
        {
            double cn = tb20.Text == "" || !IsNumeric(tb20.Text) ? 0 : double.Parse(tb20.Text);
            lb20.Text = (cn * 20).ToString();
            total();
        }

        private void tb10_TextChanged(object sender, EventArgs e)
        {
            double cn = tb10.Text == "" || !IsNumeric(tb10.Text) ? 0 : double.Parse(tb10.Text);
            lb10.Text = (cn * 10).ToString();
            total();
        }

        private void tb5_TextChanged(object sender, EventArgs e)
        {
            double cn = tb5.Text == "" || !IsNumeric(tb5.Text) ? 0 : double.Parse(tb5.Text);
            lb5.Text = (cn * 5).ToString();
            total();
        }

        private void tb2_TextChanged(object sender, EventArgs e)
        {
            double cn = tb2.Text == "" || !IsNumeric(tb2.Text) ? 0 : double.Parse(tb2.Text);
            lb2.Text = (cn * 2).ToString();
            total();
        }

        private void tb1_TextChanged(object sender, EventArgs e)
        {
            double cn = tb1.Text == "" || !IsNumeric(tb1.Text) ? 0 : double.Parse(tb1.Text);
            lb1.Text = (cn * 1).ToString();
            total();
        }

        private void tbp50_TextChanged(object sender, EventArgs e)
        {
            double cn = tbp50.Text == "" || !IsNumeric(tbp50.Text) ? 0 : double.Parse(tbp50.Text);
            lbp50.Text = (cn * 0.5).ToString();
            total();
        }

        private void tbp20_TextChanged(object sender, EventArgs e)
        {
            double cn = tbp20.Text == "" || !IsNumeric(tbp20.Text) ? 0 : double.Parse(tbp20.Text);
            lbp20.Text = (cn * 0.2).ToString();
            total();
        }

        private void tbp10_TextChanged(object sender, EventArgs e)
        {
            double cn = tbp10.Text == "" || !IsNumeric(tbp10.Text) ? 0 : double.Parse(tbp10.Text);
            lbp10.Text = (cn * 0.1).ToString();
            total();
        }
        public double total()
        {
            double cm = lbp10.Text == "" || !IsNumeric(lbp10.Text) ? 0 : double.Parse(lbp10.Text);
            double cm2 = lbp20.Text == "" || !IsNumeric(lbp20.Text) ? 0 : double.Parse(lbp20.Text);
            double cm3 = lbp50.Text == "" || !IsNumeric(lbp50.Text) ? 0 : double.Parse(lbp50.Text);
            double cm4 = lb1.Text == "" || !IsNumeric(lb1.Text) ? 0 : double.Parse(lb1.Text);
            double cm5 = lb2.Text == "" || !IsNumeric(lb2.Text) ? 0 : double.Parse(lb2.Text);
            double cm6 = lb5.Text == "" || !IsNumeric(lb5.Text) ? 0 : double.Parse(lb5.Text);
            double cm7 = lb10.Text == "" || !IsNumeric(lb10.Text) ? 0 : double.Parse(lb10.Text);
            double cm8 = lb20.Text == "" || !IsNumeric(lb20.Text) ? 0 : double.Parse(lb20.Text);
            double cm9 = lb50.Text == "" || !IsNumeric(lb50.Text) ? 0 : double.Parse(lb50.Text);
            double cm10 = lb100.Text == "" || !IsNumeric(lb100.Text) ? 0 : double.Parse(lb100.Text);
            double cm11 = lb200.Text == "" || !IsNumeric(lb200.Text) ? 0 : double.Parse(lb200.Text);
            double total = cm + cm2 + cm3 + cm4 + cm5 + cm6 + cm7 + cm8 + cm9 + cm10 + cm11;
            lbTotal.Text = total.ToString();
            return total;
        }
    }
}
