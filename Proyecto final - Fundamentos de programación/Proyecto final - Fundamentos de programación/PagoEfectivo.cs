using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_final___Fundamentos_de_programación
{
    public partial class PagoEfectivo : Form
    {
        private string[] cantidades = new string[100];

        public PagoEfectivo()
        {
            InitializeComponent();
        }

        private void PagoEfectivo_Load(object sender, EventArgs e)
        {
            cargarOpciones();
            calcularTotal();
            calcularRecibido();
            actualizarLabels();
        }

        private double calcularTotal()
        {
            double cantAPagar = carritofinal.total;

            if (checkBox1.Checked)
            {
                cantAPagar += cantAPagar * 0.1;
            }
            else if (checkBox2.Checked)
            {
                cantAPagar += cantAPagar * 0.15;
            }
            else if (checkBox3.Checked)
            {
                cantAPagar += cantAPagar * 0.2;
            }

            return cantAPagar;
        }

        private void actualizarLabels()
        {
            label3.Text = string.Empty;
            label3.Text = "Importe: $" + calcularTotal() + Environment.NewLine + "Dinero recibido: $" + calcularRecibido();
        }

        private double calcularRecibido()
        {
            double totalRecibido = 0;

            if (comboBox1.SelectedItem != null)
            {
                totalRecibido += Convert.ToDouble(comboBox1.SelectedItem.ToString());
            }

            if (comboBox2.SelectedItem != null)
            {
                totalRecibido += Convert.ToDouble(comboBox2.SelectedItem.ToString()) * 2;
            }

            if (comboBox3.SelectedItem != null)
            {
                totalRecibido += Convert.ToDouble(comboBox3.SelectedItem.ToString()) * 5;
            }

            if (comboBox4.SelectedItem != null)
            {
                totalRecibido += Convert.ToDouble(comboBox4.SelectedItem.ToString()) * 10;
            }

            if (comboBox5.SelectedItem != null)
            {
                totalRecibido += Convert.ToDouble(comboBox5.SelectedItem.ToString()) * 20;
            }

            if (comboBox6.SelectedItem != null)
            {
                totalRecibido += Convert.ToDouble(comboBox6.SelectedItem.ToString()) * 50;
            }

            if (comboBox7.SelectedItem != null)
            {
                totalRecibido += Convert.ToDouble(comboBox7.SelectedItem.ToString()) * 100;
            }

            if (comboBox8.SelectedItem != null)
            {
                totalRecibido += Convert.ToDouble(comboBox8.SelectedItem.ToString()) * 200;
            }

            if (comboBox9.SelectedItem != null)
            {
                totalRecibido += Convert.ToDouble(comboBox9.SelectedItem.ToString()) * 500;
            }

            if (comboBox10.SelectedItem != null)
            {
                totalRecibido += Convert.ToDouble(comboBox10.SelectedItem.ToString()) * 1000;
            }

            return totalRecibido;
        }

        private void cargarOpciones()
        {
            for (int i = 0; i < 100; i++)
            {
                cantidades[i] = (i + 1).ToString();
            }

            comboBox1.Items.AddRange(cantidades);
            comboBox2.Items.AddRange(cantidades);
            comboBox3.Items.AddRange(cantidades);
            comboBox4.Items.AddRange(cantidades);
            comboBox5.Items.AddRange(cantidades);
            comboBox6.Items.AddRange(cantidades);
            comboBox7.Items.AddRange(cantidades);
            comboBox8.Items.AddRange(cantidades);
            comboBox9.Items.AddRange(cantidades);
            comboBox10.Items.AddRange(cantidades);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double importeFinal = calcularTotal();
            double dineroRecibido = calcularRecibido();

            if (dineroRecibido < importeFinal)
            {
                MessageBox.Show("Cantidad insuficiente, no se ha podido concretar la venta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Dar $" + (dineroRecibido - importeFinal) + " de cambio", "Cambio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show("¡Venta concretada con éxito!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.Hide();
                catalogo catalogoo = new catalogo();
                catalogo.carrito.Clear();
                carritofinal.total = 0;
                catalogoo.Show();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            calcularRecibido();
            actualizarLabels();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            calcularRecibido();
            actualizarLabels();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            calcularRecibido();
            actualizarLabels();
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            calcularRecibido();
            actualizarLabels();
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            calcularRecibido();
            actualizarLabels();
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            calcularRecibido();
            actualizarLabels();
        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            calcularRecibido();
            actualizarLabels();
        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {
            calcularRecibido();
            actualizarLabels();
        }

        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {
            calcularRecibido();
            actualizarLabels();
        }

        private void comboBox10_SelectedIndexChanged(object sender, EventArgs e)
        {
            calcularRecibido();
            actualizarLabels();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            calcularTotal();
            actualizarLabels();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            calcularTotal();
            actualizarLabels();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            calcularTotal();
            actualizarLabels();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            catalogo catalogoo = new catalogo();
            catalogo.carrito.Clear();
            carritofinal.total = 0;
            catalogoo.Show();
        }
    }
}
