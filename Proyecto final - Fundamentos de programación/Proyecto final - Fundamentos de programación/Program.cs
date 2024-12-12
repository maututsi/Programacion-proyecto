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
            catalogo catalogoWind = new catalogo();
            carritofinal carritoFinal = new carritofinal();
            PagoEfectivo pagoEfectivo = new PagoEfectivo();
            PagoTarjeta pagoTarjeta = new PagoTarjeta();
            Agregar_tarjeta agregarTarjeta = new Agregar_tarjeta();


            if (form1.ingresoEmpleado)
            {
                Application.Run(catalogoWind);
            }
            else if (form1.ingresoAdmin)
            {
                Application.Run(form2);
            }

            if (pagoTarjeta.agregarTarjeta)
            {
                Application.Run(agregarTarjeta);
            }

            if (form2.salir || catalogoWind.salir)
            {
                Application.Exit();
            }
        }
    }
}
