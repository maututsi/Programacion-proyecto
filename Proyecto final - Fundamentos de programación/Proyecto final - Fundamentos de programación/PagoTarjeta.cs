using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Proyecto_final___Fundamentos_de_programación
{
    public partial class PagoTarjeta : Form
    {
        private Carrito formCarrito;
        private string credito;
        public double cantAPagar = 0;

        public PagoTarjeta()
        {
            InitializeComponent();
        }

        public PagoTarjeta(Carrito mainForm)
        {
            InitializeComponent();
            formCarrito = mainForm;
        }

        private void PagoTarjeta_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            credito = "debito";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            credito = "credito";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            Carrito carrito = new Carrito();
            cantAPagar = carrito.pagoTotal;
            cantAPagar += cantAPagar * 0.1;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            Carrito carrito = new Carrito();
            cantAPagar = carrito.pagoTotal;
            cantAPagar += cantAPagar * 0.15;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            Carrito carrito = new Carrito();
            cantAPagar = carrito.pagoTotal;
            cantAPagar += cantAPagar * 0.2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fileJSON = @"..\\..\\..\\..\\JSONs\tarjetas.json";

            string numero = numTarIn.Text;
            string Nip = nipIN.Text;

            if (numero == "" || Nip == "")
            {
                MessageBox.Show("Por favor, rellene todos los campos.", "Datos inválidos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string json = System.IO.File.ReadAllText(fileJSON);
                Tarjeta[] tarjetas = JsonConvert.DeserializeObject<Tarjeta[]>(json);

                foreach (Tarjeta card in tarjetas)
                {
                    if (card.num == numero && card.nip == Nip && card.tipo == credito)
                    {
                        if (card.fondos < cantAPagar)
                        {
                            MessageBox.Show("La tarjeta no cuenta con saldo suficiente", "Fondos insuficientes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            card.fondos -= cantAPagar;
                            string jsonUpdate = JsonConvert.SerializeObject(tarjetas, Formatting.Indented);
                            System.IO.File.WriteAllText(fileJSON, jsonUpdate);

                            MessageBox.Show("El pago se ha realizado con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;
                        }
                    }
                    else if (card == tarjetas[tarjetas.Length - 1])
                    {
                        MessageBox.Show("Los datos ingresados no son correctos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }

    public class Tarjeta
    {
        public string num, tipo, nip;
        public double fondos;
    }
}
