using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Proyecto_final___Fundamentos_de_programación
{
    public partial class catalogo : Form
    {
        public bool salir = false;

        private int cant = 0;

        private PagoTarjeta formTarjeta = null;
        private PagoEfectivo formEfectivo = null;

        public static Productos[] productos;

        private List<ventas> listVentas = new List<ventas>();

        private int indice;

        public bool irAlCarrito = false;

        public static List<Productos> carrito = new List<Productos>();
        public static List<int> indices = new List<int>(); 

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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Titulo_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Click(object sender, EventArgs e)
        {
            indice = 0;
            Titulo.Visible = true;
            Titulo.Text = productos[indice].titulo.ToString();
            artistaaa.Text = productos[indice].artista.ToString() + " - " + productos[indice].fecha.ToString();
            presio.Text = "$" + productos[indice].precio.ToString();
            presio.Visible = true;
            artistaaa.Visible = true;
            miniatura.Image = Properties.Resources.the_bends;
            AddToCart.Visible = true;
            goToCart.Visible = true;
            warn.Visible = false;
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            indice = 1;
            Titulo.Visible = true;
            Titulo.Text = productos[indice].titulo.ToString();
            artistaaa.Text = productos[indice].artista.ToString() + " - " + productos[indice].fecha.ToString();
            artistaaa.Visible = true;
            miniatura.Image = Properties.Resources.vespertine;
            presio.Text = "$" + productos[indice].precio.ToString();
            presio.Visible = true;
            AddToCart.Visible = true;
            goToCart.Visible = true;
            warn.Visible = false;
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            indice = 2;
            Titulo.Visible = true;
            Titulo.Text = productos[indice].titulo.ToString();
            artistaaa.Text = productos[indice].artista.ToString() + " - " + productos[indice].fecha.ToString();
            artistaaa.Visible = true;
            miniatura.Image = Properties.Resources.All_Things_Must_Pass_BW;
            presio.Text = "$" + productos[indice].precio.ToString();
            presio.Visible = true;
            AddToCart.Visible = true;
            goToCart.Visible = true;
            warn.Visible = false;
        }

        private void panel5_Click(object sender, EventArgs e)
        {
            indice = 3;
            Titulo.Visible = true;
            Titulo.Text = productos[indice].titulo.ToString();
            artistaaa.Text = productos[indice].artista.ToString() + " - " + productos[indice].fecha.ToString();
            artistaaa.Visible = true;
            miniatura.Image = Properties.Resources.heaven_or_las_vegas;
            presio.Text = "$" + productos[indice].precio.ToString();
            presio.Visible = true;
            AddToCart.Visible = true;
            goToCart.Visible = true;
            warn.Visible = false;
        }

        private void panel6_Click(object sender, EventArgs e)
        {
            indice = 4;
            Titulo.Visible = true;
            Titulo.Text = productos[indice].titulo.ToString();
            artistaaa.Text = productos[indice].artista.ToString() + " - " + productos[indice].fecha.ToString();
            artistaaa.Visible = true;
            miniatura.Image = Properties.Resources.monster;
            presio.Text = "$" + productos[indice].precio.ToString();
            presio.Visible = true;
            AddToCart.Visible = true;
            goToCart.Visible = true;
            warn.Visible = false;
        }

        private void panel7_Click(object sender, EventArgs e)
        {
            indice = 5;
            Titulo.Visible = true;
            Titulo.Text = productos[indice].titulo.ToString();
            artistaaa.Text = productos[indice].artista.ToString() + " - " + productos[indice].fecha.ToString();
            artistaaa.Visible = true;
            miniatura.Image = Properties.Resources.titanic_rising;
            presio.Text = "$" + productos[indice].precio.ToString();
            presio.Visible = true;
            AddToCart.Visible = true;
            goToCart.Visible = true;
            warn.Visible = false;
        }

        private void panel8_Click(object sender, EventArgs e)
        {
            indice = 6;
            Titulo.Visible = true;
            Titulo.Text = productos[indice].titulo.ToString();
            artistaaa.Text = productos[indice].artista.ToString() + " - " + productos[indice].fecha.ToString();
            artistaaa.Visible = true;
            miniatura.Image = Properties.Resources.deathconsciousness;
            presio.Text = "$" + productos[indice].precio.ToString();
            presio.Visible = true;
            AddToCart.Visible = true;
            goToCart.Visible = true;
            warn.Visible = false;
        }

        private void panel9_Click(object sender, EventArgs e)
        {
            indice = 7;
            Titulo.Visible = true;
            Titulo.Text = productos[indice].titulo.ToString();
            artistaaa.Text = productos[indice].artista.ToString() + " - " + productos[indice].fecha.ToString();
            artistaaa.Visible = true;
            miniatura.Image = Properties.Resources.graduation;
            presio.Text = "$" + productos[indice].precio.ToString();
            presio.Visible = true;
            AddToCart.Visible = true;
            goToCart.Visible = true;
            warn.Visible = false;
        }

        private void panel10_Click(object sender, EventArgs e)
        {
            indice = 8;
            Titulo.Visible = true;
            Titulo.Text = productos[indice].titulo.ToString();
            artistaaa.Text = productos[indice].artista.ToString() + " - " + productos[indice].fecha.ToString();
            artistaaa.Visible = true;
            miniatura.Image = Properties.Resources.cant_buy_a_thrill;
            presio.Text = "$" + productos[indice].precio.ToString();
            presio.Visible = true;
            AddToCart.Visible = true;
            goToCart.Visible = true;
            warn.Visible = false;
        }

        private void panel11_Click(object sender, EventArgs e)
        {
            indice = 9;
            Titulo.Visible = true;
            Titulo.Text = productos[indice].titulo.ToString();
            artistaaa.Text = productos[indice].artista.ToString() + " - " + productos[indice].fecha.ToString();
            artistaaa.Visible = true;
            miniatura.Image = Properties.Resources.ten;
            presio.Text = "$" + productos[indice].precio.ToString();
            presio.Visible = true;
            AddToCart.Visible = true;
            goToCart.Visible = true;
            warn.Visible = false;
        }

        private void panel12_Click(object sender, EventArgs e)
        {
            indice = 10;
            Titulo.Visible = true;
            Titulo.Text = productos[indice].titulo.ToString();
            artistaaa.Text = productos[indice].artista.ToString() + " - " + productos[indice].fecha.ToString();
            artistaaa.Visible = true;
            miniatura.Image = Properties.Resources.human_hymns;
            presio.Text = "$" + productos[indice].precio.ToString();
            presio.Visible = true;
            AddToCart.Visible = true;
            goToCart.Visible = true;
            warn.Visible = false;
        }

        private void panel13_Click(object sender, EventArgs e)
        {
            indice = 11;
            Titulo.Visible = true;
            Titulo.Text = productos[indice].titulo.ToString();
            artistaaa.Text = productos[indice].artista.ToString() + " - " + productos[indice].fecha.ToString();
            artistaaa.Visible = true;
            miniatura.Image = Properties.Resources.coastal_grooves;
            presio.Text = "$" + productos[indice].precio.ToString();
            presio.Visible = true;
            AddToCart.Visible = true;
            goToCart.Visible = true;
            warn.Visible = false;
        }

        private void panel14_Click(object sender, EventArgs e)
        {
            indice = 12;
            Titulo.Visible = true;
            Titulo.Text = productos[indice].titulo.ToString();
            artistaaa.Text = productos[indice].artista.ToString() + " - " + productos[indice].fecha.ToString();
            artistaaa.Visible = true;
            miniatura.Image = Properties.Resources.charm;
            presio.Text = "$" + productos[indice].precio.ToString();
            presio.Visible = true;
            AddToCart.Visible = true;
            goToCart.Visible = true;
            warn.Visible = false;
        }

        private void panel15_Click(object sender, EventArgs e)
        {
            indice = 13;
            Titulo.Visible = true;
            Titulo.Text = productos[indice].titulo.ToString();
            artistaaa.Text = productos[indice].artista.ToString() + " - " + productos[indice].fecha.ToString();
            artistaaa.Visible = true;
            miniatura.Image = Properties.Resources.atlant_mill_club;
            presio.Text = "$" + productos[indice].precio.ToString();
            presio.Visible = true;
            AddToCart.Visible = true;
            goToCart.Visible = true;
            warn.Visible = false;
        }

        private void panel16_Click(object sender, EventArgs e)
        {
            indice = 14;
            Titulo.Visible = true;
            Titulo.Text = productos[indice].titulo.ToString();
            artistaaa.Text = productos[indice].artista.ToString() + " - " + productos[indice].fecha.ToString();
            artistaaa.Visible = true;
            miniatura.Image = Properties.Resources.midnite_vultures;
            presio.Text = "$" + productos[indice].precio.ToString();
            presio.Visible = true;
            AddToCart.Visible = true;
            goToCart.Visible = true;
            warn.Visible = false;
        }

        private void panel17_Click(object sender, EventArgs e)
        {
            indice = 15;
            Titulo.Visible = true;
            Titulo.Text = productos[indice].titulo.ToString();
            artistaaa.Text = productos[indice].artista.ToString() + " - " + productos[indice].fecha.ToString();
            artistaaa.Visible = true;
            miniatura.Image = Properties.Resources.imperfecto_extraño;
            presio.Text = "$" + productos[indice].precio.ToString();
            presio.Visible = true;
            AddToCart.Visible = true;
            goToCart.Visible = true;
            warn.Visible = false;
        }

        private void panel18_Click(object sender, EventArgs e)
        {
            indice = 16;
            Titulo.Visible = true;
            Titulo.Text = productos[indice].titulo.ToString();
            artistaaa.Text = productos[indice].artista.ToString() + " - " + productos[indice].fecha.ToString();
            artistaaa.Visible = true;
            miniatura.Image = Properties.Resources.plastic_beach;
            presio.Text = "$" + productos[indice].precio.ToString();
            presio.Visible = true;
            AddToCart.Visible = true;
            goToCart.Visible = true;
            warn.Visible = false;
        }

        private void panel19_Click(object sender, EventArgs e)
        {
            indice = 17;
            Titulo.Visible = true;
            Titulo.Text = productos[indice].titulo.ToString();
            artistaaa.Text = productos[indice].artista.ToString() + " - " + productos[indice].fecha.ToString();
            artistaaa.Visible = true;
            miniatura.Image = Properties.Resources.cuaremtayveinte;
            presio.Text = "$" + productos[indice].precio.ToString();
            presio.Visible = true;
            AddToCart.Visible = true;
            goToCart.Visible = true;
            warn.Visible = false;
        }

        private void panel20_Click(object sender, EventArgs e)
        {
            indice = 18;
            Titulo.Visible = true;
            Titulo.Text = productos[indice].titulo.ToString();
            artistaaa.Text = productos[indice].artista.ToString() + " - " + productos[indice].fecha.ToString();
            artistaaa.Visible = true;
            miniatura.Image = Properties.Resources.my_cherie_amour;
            presio.Text = "$" + productos[indice].precio.ToString();
            presio.Visible = true;
            AddToCart.Visible = true;
            goToCart.Visible = true;
            warn.Visible = false;
        }

        private void panel21_Click(object sender, EventArgs e)
        {
            indice = 19;
            Titulo.Visible = true;
            Titulo.Text = productos[indice].titulo.ToString();
            artistaaa.Text = productos[indice].artista.ToString() + " - " + productos[indice].fecha.ToString();
            artistaaa.Visible = true;
            miniatura.Image = Properties.Resources.quebec;
            presio.Text = "$" + productos[indice].precio.ToString();
            presio.Visible = true;
            AddToCart.Visible = true;
            goToCart.Visible = true;
            warn.Visible = false;
        }

        private void label62_Click(object sender, EventArgs e)
        {

        }

        private void AddToCart_Click(object sender, EventArgs e)
        {
            carrito.Add(productos[indice]);
            indices.Add(indice);
            cant++;
            label62.Text = cant.ToString();
            label62.Visible = true;
            pictureBox21.Visible = true;
            warn.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            irAlCarrito = true;
            this.Hide();
            carritofinal carritoFinal = new carritofinal();
            carritoFinal.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            salir = true;
            this.Close();
        }
    }

    public class Productos
    {
        public string titulo, artista, fecha, precio, imagen;
        public int ventas;
    }
}
