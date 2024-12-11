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
    public partial class carritofinal : Form
    {
        public bool irAtarjeta = false;
        public bool irAEfectivo = false;
        public static int total = 0;

        public carritofinal()
        {
            InitializeComponent();
        }

        private void carritofinal_Load(object sender, EventArgs e)
        {
            cargar_carrito();
            cargar_menus_desplegables();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            irAtarjeta = true;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            irAEfectivo = true;
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void cargar_carrito()
        {
            label1.Text = "";

            int n = 1;
            foreach (Productos producto in catalogo.carrito)
            {
                label1.Text += n + " - " + producto.titulo + " ($" + Convert.ToInt32(producto.precio) + ")" + Environment.NewLine;
                total += Convert.ToInt32(producto.precio);
                n++;
            }
            label3.Text = "Total: " + "$" + total.ToString();
        }

        private void cargar_menus_desplegables()
        {
            foreach (Productos producto in catalogo.carrito)
            {
                comboBox1.Items.Add(producto.titulo.ToString());
            }

            foreach (Productos producto in catalogo.productos)
            {
                comboBox2.Items.Add(producto.titulo.ToString());
            }
        }

        private void vaciar_menus_desplegables()
        {
            do
            {
                if (comboBox1.Items.Count > 0)
                {
                    foreach (string producto in comboBox1.Items)
                    {
                        comboBox1.Items.Remove(producto);
                        break;
                    }
                }

                if (comboBox2.Items.Count > 0)
                {
                    foreach (string producto in comboBox2.Items)
                    {
                        comboBox2.Items.Remove(producto);
                        break;
                    }
                }
            } 
            while (comboBox1.Items.Count > 0 || comboBox2.Items.Count > 0);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                foreach (Productos producto in catalogo.carrito)
                {
                    if (producto.titulo.ToString() == comboBox1.SelectedItem.ToString())
                    {
                        catalogo.carrito.Remove(producto);
                        break;
                    }
                }
            }

            if (comboBox2.SelectedItem != null)
            {
                foreach (Productos producto in catalogo.productos)
                {
                    if (comboBox2.SelectedItem.ToString() == producto.titulo.ToString())
                    {
                        catalogo.carrito.Add(producto);
                        break;
                    }
                }
            }

            total = 0;
            comboBox1.SelectedItem = null;
            comboBox2.SelectedItem = null;
            cargar_carrito();
            vaciar_menus_desplegables();
            cargar_menus_desplegables();
        }
    }
}
