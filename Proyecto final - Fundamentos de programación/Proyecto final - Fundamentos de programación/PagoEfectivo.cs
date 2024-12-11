using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_final___Fundamentos_de_programación
{
    public partial class PagoEfectivo : Form
    {
        public int dineroIngresado = 0;
        

        public PagoEfectivo()
        {
            InitializeComponent();
            pantalla();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dineroIngresado++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dineroIngresado += 2;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dineroIngresado += 5;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dineroIngresado += 10;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            dineroIngresado += 20;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dineroIngresado += 100;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            dineroIngresado += 200;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            dineroIngresado += 500;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            dineroIngresado += 50;
        }

        private void pantalla()
        {
            int total = 0;
            texto.Text = "Faltan $";

            foreach (Productos producto in catalogo.carrito)
            {
                total += Convert.ToInt32(producto.precio.ToString());

                if (dineroIngresado >= total)
                {
                    MessageBox.Show("Gracias por la compra", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                }
            }
        }
    }
}
