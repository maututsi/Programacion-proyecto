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
            Application.Run(form1);
            PagoTarjeta pagotarjeta = new PagoTarjeta();
            catalogo catalogoWind = new catalogo();
            catalogo catalogoWind1 = new catalogo();
            catalogo catalogoWind2 = new catalogo();
            catalogo catalogoWind3 = new catalogo();
            catalogo catalogoWind4 = new catalogo();
            Carrito carrito = new Carrito();
            Carrito carrito1 = new Carrito();
            Carrito carrito2 = new Carrito();
            Carrito carrito3 = new Carrito();
            Carrito carrito4 = new Carrito();
            Carrito carrito5 = new Carrito();
            Carrito carrito6 = new Carrito();
            Carrito carrito7 = new Carrito();


            if (form1.ingresoEmpleado)
            {
                Application.Run(catalogoWind);
            }
            else if (form1.ingresoAdmin)
            {
                Application.Run();
            }

            if (catalogoWind.irAlCarrito)
            {
                Application.Run(carrito);
            }

            if (carrito.pagarTarjeta)
            {
                Application.Run(pagotarjeta);
            }

            if (carrito.regresarACatalogo)
            {
                Application.Run(catalogoWind1);
            }

            if (catalogoWind1.irAlCarrito)
            {
                Application.Run(carrito1);
            }

            if (carrito1.regresarACatalogo)
            {
                Application.Run(catalogoWind2);
            }

            if (catalogoWind2.irAlCarrito)
            {
                Application.Run(carrito3);
            }

            if (carrito3.regresarACatalogo)
            {
                Application.Run(catalogoWind3);
            }

            if (catalogoWind3.irAlCarrito)
            {
                Application.Run(carrito4);
            }

            if (carrito4.regresarACatalogo)
            {
                Application.Run(catalogoWind4);
            }

            if (catalogoWind4.irAlCarrito)
            {
                Application.Run(carrito5);
            }

            if (carrito.reiniciarVentana)
            {
                Application.Run(carrito1);
            }

            if (carrito1.reiniciarVentana)
            {
                Application.Run(carrito2);
            }

            if (carrito2.reiniciarVentana)
            {
                Application.Run(carrito3);
            }

            if (carrito3.reiniciarVentana)
            {
                Application.Run(carrito4);
            }

            if (carrito4.reiniciarVentana)
            {
                Application.Run(carrito5);
            }

            if (carrito5.reiniciarVentana)
            {
                Application.Run(carrito6);
            }

            if (carrito6.reiniciarVentana)
            {
                Application.Run(carrito7);
            }
        }
    }
}
