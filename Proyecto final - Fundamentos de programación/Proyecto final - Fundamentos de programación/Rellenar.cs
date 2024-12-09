using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Proyecto_final___Fundamentos_de_programación
{
    public class Productos
    {
        public string Product { get; set; }
        public decimal Price { get; set; }
        public int Cant { get; set; }
        public string titulo, artista, fecha, precio;
    }

    public partial class Rellenar : Form
    {
        List<Productos> Productos;
        public Rellenar()
        {
            InitializeComponent();
        }

        private void Rellenar_Load(object sender, EventArgs e)
        {
            DescarargarJson();
            LlenarCantidad();
            LLenarPrecios();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        public void DescarargarJson()
        {
            string fileJson = @"..\\..\\..\\..\\JSONs\cds.json";
            string json = System.IO.File.ReadAllText(fileJson);
            Productos = JsonConvert.DeserializeObject<List<Productos>>(json);
        }
        public void ActualizarJson()
        {
            string fileJson = @"..\\..\\..\\..\\JSONs\cds.json";
            string json = JsonConvert.SerializeObject(Productos, Formatting.Indented);
            System.IO.File.WriteAllText(fileJson, json);
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
        public void LLenarPrecios()
        {
            txt_pTheBends.Text = Productos.Find(item => item.Product == "The Bends").precio.ToString();
            txt_pVespertine.Text = Productos.Find(item => item.Product == "Vespertine").precio.ToString();
            txt_pAllThingsMustPass.Text = Productos.Find(item => item.Product == "All things must pass").precio.ToString();
            txt_pHeveanOrLasVegas.Text = Productos.Find(item => item.Product == "Heaven or Las Vegas").precio.ToString();
            txt_pMonster.Text = Productos.Find(item => item.Product == "Monster").precio.ToString();
            txt_pTitanicRising.Text = Productos.Find(item => item.Product == "Titanic Rising").precio.ToString();
            txt_pDeathconsciousness.Text = Productos.Find(item => item.Product == "deathconsciousness").precio.ToString();
            txt_pGraduation.Text = Productos.Find(item => item.Product == "Graduation").precio.ToString();
            txt_pCantByuaThrill.Text = Productos.Find(item => item.Product == "Can´t Buy a Thrill").precio.ToString();
            txt_pTen.Text = Productos.Find(item => item.Product == "Ten").precio.ToString();
            txt_pHumanHymns.Text = Productos.Find(item => item.Product == "Human Hymns").precio.ToString();
            txt_pCoastalGrooves.Text = Productos.Find(item => item.Product == "Coastal Grooves").precio.ToString();
            txt_pCharm.Text = Productos.Find(item => item.Product == "Charm").precio.ToString();
            txt_pAtlantaMillionairesClub.Text = Productos.Find(item => item.Product == "Atlanta Millionaires Club").precio.ToString();
            txt_pMidnightsVultures.Text = Productos.Find(item => item.Product == "Midnite Vultures").precio.ToString();
            txt_pImperfectoExtraño.Text = Productos.Find(item => item.Product == "Imperfecto Extraño").precio.ToString();
            txt_pPlasticBeach.Text = Productos.Find(item => item.Product == "Plastic Beach").precio.ToString();
            txt_p4020.Text = Productos.Find(item => item.Product == "40 y 20").precio.ToString();
            txt_pMyCherieAmour.Text = Productos.Find(item => item.Product == "My cherie amour").precio.ToString();
            txt_pQuebec.Text = Productos.Find(item => item.Product == "quebec").precio.ToString();
        }
        public void LlenarCantidad()
        {
            txt_cTheBends.Text = Productos.Find(item => item.Product == "The Bends").Cant.ToString();
            txt_cVespertine.Text = Productos.Find(item => item.Product == "Vespertine").Cant.ToString();
            txt_cAllThingsMustPass.Text = Productos.Find(item => item.Product == "All things must pass").Cant.ToString();
            txt_cHeavenOrLasVegas.Text = Productos.Find(item => item.Product == "Heaven or Las Vegas").Cant.ToString();
            txt_cMonster.Text = Productos.Find(item => item.Product == "Monster").Cant.ToString();
            txt_cTitanicRising.Text = Productos.Find(item => item.Product == "Titanic Rising").Cant.ToString();
            txt_cDeathconsciousness.Text = Productos.Find(item => item.Product == "deathconsciousness").Cant.ToString();
            txt_cGraduation.Text = Productos.Find(item => item.Product == "Graduation").Cant.ToString();
            txt_cCantByuaThrill.Text = Productos.Find(item => item.Product == "Can´t Buy a Thrill").Cant.ToString();
            txt_cTen.Text = Productos.Find(item => item.Product == "Ten").Cant.ToString();
            txt_cHumanHymns.Text = Productos.Find(item => item.Product == "Human Hymns").Cant.ToString();
            txt_cCoastalGrooves.Text = Productos.Find(item => item.Product == "Coastal Grooves").Cant.ToString();
            txt_cCharm.Text = Productos.Find(item => item.Product == "Charm").Cant.ToString();
            txt_cAtlantaMillionairesClub.Text = Productos.Find(item => item.Product == "Atlanta Millionaires Club").Cant.ToString();
            txt_cMidnightsVultrues.Text = Productos.Find(item => item.Product == "Midnite Vultures").Cant.ToString();
            txt_cImperfectoExtraño.Text = Productos.Find(item => item.Product == "Imperfecto Extraño").Cant.ToString();
            txt_cPlasticBeach.Text = Productos.Find(item => item.Product == "Plastic Beach").Cant.ToString();
            txt_c4020.Text = Productos.Find(item => item.Product == "40 y 20").Cant.ToString();
            txt_cMyChaireAmour.Text = Productos.Find(item => item.Product == "My cherie amour").Cant.ToString();
            txt_cQuebec.Text = Productos.Find(item => item.Product == "quebec").Cant.ToString();
        }
    }
}