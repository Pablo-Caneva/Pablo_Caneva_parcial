using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Pablo_Caneva_parcial
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("es-AR");
            Banco bancoSantaFe = new Banco();
            CargaArchivos.PersonasCA(bancoSantaFe);
            CargaArchivos.PersonasCC(bancoSantaFe);
            CargaArchivos.EmpresasCA(bancoSantaFe);
            CargaArchivos.EmpresasCC(bancoSantaFe);
            CargaArchivos.PlazosFijos(bancoSantaFe);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new VentanaPrincipal(bancoSantaFe));
        }
    }
}
