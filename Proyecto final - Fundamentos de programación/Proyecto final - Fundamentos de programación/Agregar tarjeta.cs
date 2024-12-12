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
    public partial class Agregar_tarjeta : Form
    {
        private bool esDebito = true;

        public Agregar_tarjeta()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (inputNumeroTarjeta.Text == "" || inputNumeroTarjeta.Text == "" || inputFondos.Text == "" || (!radioButton1.Checked && !radioButton2.Checked))
            {
                MessageBox.Show("No deje campos vacíos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                string jsonFile = @"..\\..\\..\\..\\JSONs\\tarjetas.json";

                string numTarjeta = inputNumeroTarjeta.Text.ToString();
                string nipTarjeta = inputNIP.Text.ToString();
                double fondosTarjeta = Convert.ToDouble(inputFondos.Text);

                string jsonTarjetas = System.IO.File.ReadAllText(jsonFile);
                List<Tarjeta> tarjetas = JsonConvert.DeserializeObject<List<Tarjeta>>(jsonTarjetas);

                Tarjeta nuevaTarjeta = new Tarjeta();

                nuevaTarjeta.numero = numTarjeta;
                nuevaTarjeta.nip = nipTarjeta;
                nuevaTarjeta.fondos = fondosTarjeta;
                if (esDebito)
                {
                    nuevaTarjeta.tipo = "debito";
                }
                else
                {
                    nuevaTarjeta.tipo = "credito";
                }

                tarjetas.Add(nuevaTarjeta);

                string jsonActualizar = JsonConvert.SerializeObject(tarjetas, Formatting.Indented);
                System.IO.File.WriteAllText(jsonFile, jsonActualizar);
                
                MessageBox.Show("¡Tarjeta agregada con éxito!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                PagoTarjeta pagoTarjeta = new PagoTarjeta();
                pagoTarjeta.Show();
                this.Close();
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                esDebito = false;
            }
        }
    }
}
