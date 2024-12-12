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
        private bool propina10 = false;
        private bool propina15 = false;
        private bool propina20 = false;
        public bool agregarTarjeta = false;
        public string typTarjeta;
        private List<Productos> productosComprados = new List<Productos>();
        Compra compra = new Compra();

        public PagoTarjeta()
        {
            InitializeComponent();
        }

        private void PagoTarjeta_Load(object sender, EventArgs e)
        {
            calcularTotal();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string jsonFile = @"..\\..\\..\\..\\JSONs\\tarjetas.json";

            string numTarjeta = inputNumeroTarjeta.Text.ToString();
            string nipTarjeta = inputNIP.Text.ToString();

            string jsonTarjetas = System.IO.File.ReadAllText(jsonFile);
            Tarjeta[] tarjetas = JsonConvert.DeserializeObject<Tarjeta[]>(jsonTarjetas);

            bool tarjetaEncontrada = false;

            if (numTarjeta == "" || nipTarjeta == "" || (!radioButton1.Checked && !radioButton2.Checked))
            {
                MessageBox.Show("No deje campos vacíos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                double tot = calcularTotal();

                foreach (Tarjeta tarjeta in tarjetas)
                {
                    if (tarjeta.numero.ToString() == numTarjeta && tarjeta.nip.ToString() == nipTarjeta && tarjeta.tipo.ToString() == typTarjeta)
                    {
                        if (tarjeta.fondos < tot)
                        {
                            MessageBox.Show("Fondos insuficientes", "Transacción interrumpida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            tarjeta.fondos -= tot;
                            string actualizarJson = JsonConvert.SerializeObject(tarjetas, Formatting.Indented);
                            System.IO.File.WriteAllText(jsonFile, actualizarJson);
                            MessageBox.Show("¡Operación realizada con éxito! Gracias por la compra", "Transacción exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            tarjetaEncontrada = true;

                            string jsonArchivo = @"..\\..\\..\\..\\JSONs\\compras.json";
                            string jsonCompras = System.IO.File.ReadAllText(jsonArchivo);
                            List<Compra> compras = JsonConvert.DeserializeObject<List<Compra>>(jsonCompras);

                            compra.name = Form1.nombre;
                            compra.clave = Form1.clave;
                            compra.total = calcularTotal();
                            compras.Add(compra);

                            string jsonActualizar = JsonConvert.SerializeObject(compras, Formatting.Indented);
                            System.IO.File.WriteAllText(jsonArchivo, jsonActualizar);

                            actualizarVentas();
                            this.Hide();
                            catalogo catalogoo = new catalogo();
                            catalogo.carrito.Clear();
                            carritofinal.total = 0;
                            catalogoo.Show();
                            break;
                        }
                    }
                }

                if (tarjetaEncontrada == false)
                {
                    DialogResult resultado = MessageBox.Show("Tarjeta no encontrada, ¿Desea agregar una nueva tarjeta al sistema?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (resultado == DialogResult.Yes)
                    {
                        agregarTarjeta = true;
                        this.Hide();
                        Agregar_tarjeta formAgregarTar = new Agregar_tarjeta();
                        formAgregarTar.Show();
                    }
                    else
                    {
                        MessageBox.Show("Vuelva a intentarlo", "Aviso", MessageBoxButtons.OK);
                    }
                }
            }
        }

        private double calcularTotal()
        {
            double cantAPagar = carritofinal.total;

            if (cbpropina10.Checked)
            {
                cantAPagar += cantAPagar * 0.1;
            }
            else if (cbpropina15.Checked)
            {
                cantAPagar += cantAPagar * 0.15;
            }
            else if (cbpropina20.Checked)
            {
                cantAPagar += cantAPagar * 0.2;
            }

            label4.Text = "Importe total: $" + cantAPagar.ToString();

            return cantAPagar;
        }

        private void actualizarVentas()
        {
            string JSONfile = @"..\\..\\..\\..\\JSONs\\cds.json";
            string jsonCDs = System.IO.File.ReadAllText(JSONfile);
            Productos[] CDs = JsonConvert.DeserializeObject<Productos[]>(jsonCDs);

            foreach (Productos p in CDs)
            {
                foreach (Productos producto in catalogo.carrito)
                {
                    if (producto.titulo == p.titulo)
                    {
                        p.ventas++;
                    }
                }
            }

            string jsonActualizar = JsonConvert.SerializeObject(CDs, Formatting.Indented);
            System.IO.File.WriteAllText(JSONfile, jsonActualizar);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            calcularTotal();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                typTarjeta = "debito";
            }
            else
            {
                typTarjeta = "";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                typTarjeta = "credito";
            }
            else
            {
                typTarjeta = "";
            }
        }

        private void cbpropina15_CheckedChanged(object sender, EventArgs e)
        {
            calcularTotal();
        }

        private void cbpropina20_CheckedChanged(object sender, EventArgs e)
        {
            calcularTotal();
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

    public class Tarjeta
    {
        public string numero, tipo, nip;
        public double fondos;
    }
}
