using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_final___Fundamentos_de_programación
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form1 form1 = new Form1();
            Form2 form2 = new Form2();
            Application.Run(form1);
            PagoTarjeta pagotarjeta = new PagoTarjeta();
            catalogo catalogoWind = new catalogo();
            carritofinal carritoFinal = new carritofinal();
            PagoEfectivo pagoEfectivo = new PagoEfectivo();


            if (form1.ingresoEmpleado)
            {
                Application.Run(catalogoWind);
            }
            else if (form1.ingresoAdmin)
            {
                Application.Run(form2);
            }

            if (catalogoWind.irAlCarrito)
            {
                Application.Run(carritoFinal);
            }

            if (carritoFinal.irAtarjeta)
            {
                Application.Run(pagotarjeta);
            }
            else if (carritoFinal.irAEfectivo)
            {
                Application.Run(pagoEfectivo);
            }
        }
    }
}
