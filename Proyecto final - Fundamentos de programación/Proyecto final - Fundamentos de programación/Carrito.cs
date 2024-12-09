using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_final___Fundamentos_de_programación
{
    public partial class Carrito : Form
    {
        public bool pagarEfectivo = false;
        public bool pagarTarjeta = false;

        public Carrito()
        {
            InitializeComponent();
        }

        List<Productos> carritoDeCatalogo = catalogo.carrito;
        List<int> indicesCarrito = catalogo.indices;
        Productos[] cdss = catalogo.productos;


        private void mostrarCarrito()
        {
            List<Productos> carritoDeCatalogo = catalogo.carrito;
            List<int> indicesCarrito = catalogo.indices;
            Productos[] cdss = catalogo.productos;

            int cant = 0;
            int num = 1;

            foreach (Productos cd in carritoDeCatalogo)
            {
                cant++;
            }

            foreach (Productos cd in carritoDeCatalogo)
            {
                Panel pan = this.Controls.Find("pan" + num, true).FirstOrDefault() as Panel;
                if (pan != null)
                {
                    pan.Visible = true;
                }

                string nombreImagen = cdss[indicesCarrito[num - 1]].imagen;

                PictureBox pictureBox = this.Controls.Find("xbox" + num, true).FirstOrDefault() as PictureBox;
                if (pictureBox != null && num <= cant)
                {
                    pictureBox.Image = (Image)Properties.Resources.ResourceManager.GetObject(nombreImagen);
                }

                if (num == cant)
                {
                    break;
                }

                num++;
            }
        }

        private void Contenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Carrito_Load(object sender, EventArgs e)
        {
            mostrarCarrito();
        }

        private void pan1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pan1_Click(object sender, EventArgs e)
        {
            
        }

        private void pan2_Click(object sender, EventArgs e)
        {
            
        }

        private void pan3_Click(object sender, EventArgs e)
        {
            
        }

        private void pan1_DClick(object sender, EventArgs e)
        {
            carritoDeCatalogo.RemoveAt(0);
            mostrarCarrito();
            
        }

        private void pan2_DClick(object sender, EventArgs e)
        {
            carritoDeCatalogo.RemoveAt(1);
            mostrarCarrito();
            
        }

        private void pan3_DClick(object sender, EventArgs e)
        {
            carritoDeCatalogo.RemoveAt(2);
            mostrarCarrito();
            
        }

        private void pan4_DClick(object sender, EventArgs e)
        {
            carritoDeCatalogo.RemoveAt(3);
            mostrarCarrito();
            
        }

        private void pan5_DClick(object sender, EventArgs e)
        {
            carritoDeCatalogo.RemoveAt(4);
            mostrarCarrito();
            
        }

        private void pan6_DClick(object sender, EventArgs e)
        {
            carritoDeCatalogo.RemoveAt(5);
            mostrarCarrito();
            
        }

        private void pan7_DClick(object sender, EventArgs e)
        {
            carritoDeCatalogo.RemoveAt(6);
            mostrarCarrito();
            
        }

        private void pan8_DClick(object sender, EventArgs e)
        {
            carritoDeCatalogo.RemoveAt(7);
            mostrarCarrito();
            
        }

        private void pan9_DClick(object sender, EventArgs e)
        {
            carritoDeCatalogo.RemoveAt(8);
            mostrarCarrito();
            
        }

        private void pan10_DClick(object sender, EventArgs e)
        {
            carritoDeCatalogo.RemoveAt(9);
            mostrarCarrito();
            
        }

        private void pan11_DClick(object sender, EventArgs e)
        {
            carritoDeCatalogo.RemoveAt(10);
            mostrarCarrito();
            
        }

        private void pan12_Click(object sender, EventArgs e)
        {
            carritoDeCatalogo.RemoveAt(11);
            mostrarCarrito();
            
        }

        private void pan13_DClick(object sender, EventArgs e)
        {
            carritoDeCatalogo.RemoveAt(12);
            mostrarCarrito();
            
        }

        private void pan14_DClick(object sender, EventArgs e)
        {
            carritoDeCatalogo.RemoveAt(13);
            mostrarCarrito();
            
        }

        private void pan15_DClick(object sender, EventArgs e)
        {
            carritoDeCatalogo.RemoveAt(14);
            mostrarCarrito();
            
        }

        private void pan16_DClick(object sender, EventArgs e)
        {
            carritoDeCatalogo.RemoveAt(15);
            mostrarCarrito();
            
        }

        private void pan17_DClick(object sender, EventArgs e)
        {
            carritoDeCatalogo.RemoveAt(16);
            mostrarCarrito();
            
        }

        private void pan18_DClick(object sender, EventArgs e)
        {
            carritoDeCatalogo.RemoveAt(17);
            mostrarCarrito();
            
        }

        private void pan19_DClick(object sender, EventArgs e)
        {
            carritoDeCatalogo.RemoveAt(18);
            mostrarCarrito();
            
        }

        private void pan20_DClick(object sender, EventArgs e)
        {
            carritoDeCatalogo.RemoveAt(19);
            mostrarCarrito();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pagarEfectivo = true;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pagarTarjeta = true;
        }
    }
}
