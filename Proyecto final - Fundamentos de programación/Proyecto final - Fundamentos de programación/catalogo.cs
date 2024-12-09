using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Proyecto_final___Fundamentos_de_programación
{
    public partial class catalogo : Form
    {
        private PagoTarjeta formTarjeta = null;
        private PagoEfectivo formEfectivo = null;

        private Productos[] productos;
        private List<ventas> listVentas = new List<ventas>();

        public catalogo()
        {
            InitializeComponent();
        }

        private void catalogo_Load(object sender, EventArgs e)
        {
            actualizarProductos();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void actualizarProductos()
        {
            productos = new Productos[20];

            string JSONdeCDs = @"..\\..\\..\\..\\JSONs\cds.json";

            string jsonCDs = System.IO.File.ReadAllText(JSONdeCDs);
            productos = JsonConvert.DeserializeObject<Productos[]>(jsonCDs);

            label1.Text = productos[0].titulo.ToString();
            label2.Text = productos[0].artista.ToString();
            label3.Text = "$" + productos[0].precio.ToString();

            label6.Text = productos[1].titulo.ToString();
            label5.Text = productos[1].artista.ToString();
            label4.Text = "$" + productos[1].precio.ToString();

            label9.Text = productos[2].titulo.ToString();
            label8.Text = productos[2].artista.ToString();
            label7.Text = "$" + productos[2].precio.ToString();

            label12.Text = productos[3].titulo.ToString();
            label11.Text = productos[3].artista.ToString();
            label10.Text = "$" + productos[3].precio.ToString();

            label15.Text = productos[4].titulo.ToString();
            label14.Text = productos[4].artista.ToString();
            label13.Text = "$" + productos[4].precio.ToString();

            label18.Text = productos[5].titulo.ToString();
            label17.Text = productos[5].artista.ToString();
            label16.Text = "$" + productos[5].precio.ToString();

            label21.Text = productos[6].titulo.ToString();
            label20.Text = productos[6].artista.ToString();
            label19.Text = "$" + productos[6].precio.ToString();

            label24.Text = productos[7].titulo.ToString();
            label23.Text = productos[7].artista.ToString();
            label22.Text = "$" + productos[7].precio.ToString();

            label27.Text = productos[8].titulo.ToString();
            label26.Text = productos[8].artista.ToString();
            label25.Text = "$" + productos[8].precio.ToString();

            label30.Text = productos[9].titulo.ToString();
            label29.Text = productos[9].artista.ToString();
            label28.Text = "$" + productos[9].precio.ToString();

            label33.Text = productos[10].titulo.ToString();
            label32.Text = productos[10].artista.ToString();
            label31.Text = "$" + productos[10].precio.ToString();

            label36.Text = productos[11].titulo.ToString();
            label35.Text = productos[11].artista.ToString();
            label34.Text = "$" + productos[11].precio.ToString();

            label39.Text = productos[12].titulo.ToString();
            label38.Text = productos[12].artista.ToString();
            label37.Text = "$" + productos[12].precio.ToString();

            label42.Text = productos[13].titulo.ToString();
            label41.Text = productos[13].artista.ToString();
            label40.Text = "$" + productos[13].precio.ToString();

            label45.Text = productos[14].titulo.ToString();
            label44.Text = productos[14].artista.ToString();
            label43.Text = "$" + productos[14].precio.ToString();

            label48.Text = productos[15].titulo.ToString();
            label47.Text = productos[15].artista.ToString();
            label46.Text = "$" + productos[15].precio.ToString();

            label51.Text = productos[16].titulo.ToString();
            label50.Text = productos[16].artista.ToString();
            label49.Text = "$" + productos[16].precio.ToString();

            label54.Text = productos[17].titulo.ToString();
            label53.Text = productos[17].artista.ToString();
            label52.Text = "$" + productos[17].precio.ToString();

            label57.Text = productos[18].titulo.ToString();
            label56.Text = productos[18].artista.ToString();
            label55.Text = "$" + productos[18].precio.ToString();

            label60.Text = productos[19].titulo.ToString();
            label59.Text = productos[19].artista.ToString();
            label58.Text = "$" + productos[19].precio.ToString();

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel14_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }

    public class Productos
    {
        public string titulo, artista, fecha, precio;
    }
}
