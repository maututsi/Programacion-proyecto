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
        int TOTAL = Carrito.total;
        public int dinerodepositado = 0;
        public PagoEfectivo()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            dinerodepositado += 100;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dinerodepositado += 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dinerodepositado += 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dinerodepositado += 5;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dinerodepositado += 10;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            dinerodepositado += 20;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            dinerodepositado += 50;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dinerodepositado += 200;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            dinerodepositado += 500;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            dinerodepositado += 1000;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (dinerodepositado>=TOTAL)
            {
                dinerodepositado= dinerodepositado - TOTAL;
                MessageBox.Show("Gracias por su compra", "Su cambio es: "+ dinerodepositado, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
            }
            else
            {
                MessageBox.Show("Cantidad Invalida", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
