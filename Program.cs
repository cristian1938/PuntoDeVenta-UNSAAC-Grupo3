using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Metodologia
{
    static class Program
    {
        /// <summary>--------------------------------------------------
        /// Punto de entrada principal para la aplicación.
        /// </summary>-------------------------------------------------
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            FrmLogin a = new FrmLogin();
            Application.Run( new FrmSistemaVentas());
  
        }
    }
}
