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
    public class Productos1
    {
        public string Product { get; set; }
        public decimal Price { get; set; }
        public int Cant { get; set; }
        public string titulo, artista, fecha, precio;
    }

    public partial class Rellenar : Form
    {
        List<Productos1> Productos;

        public Rellenar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ModificarProductos();
            ActualizarJson();
            MessageBox.Show("Productos guardados correctamente.");
        }

        private void Rellenar_Load(object sender, EventArgs e)
        {
            DescarargarJson();  // Cargar el archivo JSON
            if (Productos != null)
            {
                LlenarCantidad();
                LlenarPrecios();
            }
            else
            {
                MessageBox.Show("No se pudo cargar el archivo de productos.");
            }
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
            try
            {
                string json = System.IO.File.ReadAllText(fileJson);
                if (string.IsNullOrEmpty(json))
                {
                    MessageBox.Show("El archivo JSON está vacío.");
                    Productos = new List<Productos1>();
                }
                else
                {
                    Productos = JsonConvert.DeserializeObject<List<Productos1>>(json) ?? new List<Productos1>();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el archivo JSON: " + ex.Message);
                Productos = new List<Productos1>();
            }
        }

        public void ActualizarJson()
        {
            string fileJson = @"..\\..\\..\\..\\JSONs\cds.json";
            try
            {
                string json = JsonConvert.SerializeObject(Productos, Formatting.Indented);
                System.IO.File.WriteAllText(fileJson, json);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el archivo JSON: " + ex.Message);
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        public void LlenarPrecios()
        {
            foreach (var producto in Productos)
            {
                switch (producto.Product)
                {
                    case "The Bends":
                        txt_pTheBends.Text = producto.Price.ToString();
                        break;
                    case "Vespertine":
                        txt_pVespertine.Text = producto.Price.ToString();
                        break;
                    case "All things must pass":
                        txt_pAllThingsMustPass.Text = producto.Price.ToString();
                        break;
                    case "Heaven or Las Vegas":
                        txt_pHeveanOrLasVegas.Text = producto.Price.ToString();
                        break;
                    case "Monster":
                        txt_pMonster.Text = producto.Price.ToString();
                        break;
                    case "Titanic Rising":
                        txt_pTitanicRising.Text = producto.Price.ToString();
                        break;
                    case "deathconsciousness":
                        txt_pDeathconsciousness.Text = producto.Price.ToString();
                        break;
                    case "Graduation":
                        txt_pGraduation.Text = producto.Price.ToString();
                        break;
                    case "Can´t Buy a Thrill":
                        txt_pCantByuaThrill.Text = producto.Price.ToString();
                        break;
                    case "Ten":
                        txt_pTen.Text = producto.Price.ToString();
                        break;
                    case "Human Hymns":
                        txt_pHumanHymns.Text = producto.Price.ToString();
                        break;
                    case "Coastal Grooves":
                        txt_pCoastalGrooves.Text = producto.Price.ToString();
                        break;
                    case "Charm":
                        txt_pCharm.Text = producto.Price.ToString();
                        break;
                    case "Atlanta Millionaires Club":
                        txt_pAtlantaMillionairesClub.Text = producto.Price.ToString();
                        break;
                    case "Midnite Vultures":
                        txt_pMidnightsVultures.Text = producto.Price.ToString();
                        break;
                    case "Imperfecto Extraño":
                        txt_pImperfectoExtraño.Text = producto.Price.ToString();
                        break;
                    case "Plastic Beach":
                        txt_pPlasticBeach.Text = producto.Price.ToString();
                        break;
                    case "40 y 20":
                        txt_p4020.Text = producto.Price.ToString();
                        break;
                    case "My cherie amour":
                        txt_pMyCherieAmour.Text = producto.Price.ToString();
                        break;
                    case "quebec":
                        txt_pQuebec.Text = producto.Price.ToString();
                        break;
                }
            }
        }

        public void LlenarCantidad()
        {
            foreach (var producto in Productos)
            {
                switch (producto.Product)
                {
                    case "The Bends":
                        txt_cTheBends.Text = producto.Cant.ToString();
                        break;
                    case "Vespertine":
                        txt_cVespertine.Text = producto.Cant.ToString();
                        break;
                    case "All things must pass":
                        txt_cAllThingsMustPass.Text = producto.Cant.ToString();
                        break;
                    case "Heaven or Las Vegas":
                        txt_cHeavenOrLasVegas.Text = producto.Cant.ToString();
                        break;
                    case "Monster":
                        txt_cMonster.Text = producto.Cant.ToString();
                        break;
                    case "Titanic Rising":
                        txt_cTitanicRising.Text = producto.Cant.ToString();
                        break;
                    case "deathconsciousness":
                        txt_cDeathconsciousness.Text = producto.Cant.ToString();
                        break;
                    case "Graduation":
                        txt_cGraduation.Text = producto.Cant.ToString();
                        break;
                    case "Can´t Buy a Thrill":
                        txt_cCantByuaThrill.Text = producto.Cant.ToString();
                        break;
                    case "Ten":
                        txt_cTen.Text = producto.Cant.ToString();
                        break;
                    case "Human Hymns":
                        txt_cHumanHymns.Text = producto.Cant.ToString();
                        break;
                    case "Coastal Grooves":
                        txt_cCoastalGrooves.Text = producto.Cant.ToString();
                        break;
                    case "Charm":
                        txt_cCharm.Text = producto.Cant.ToString();
                        break;
                    case "Atlanta Millionaires Club":
                        txt_cAtlantaMillionairesClub.Text = producto.Cant.ToString();
                        break;
                    case "Midnite Vultures":
                        txt_cMidnightsVultrues.Text = producto.Cant.ToString();
                        break;
                    case "Imperfecto Extraño":
                        txt_cImperfectoExtraño.Text = producto.Cant.ToString();
                        break;
                    case "Plastic Beach":
                        txt_cPlasticBeach.Text = producto.Cant.ToString();
                        break;
                    case "40 y 20":
                        txt_c4020.Text = producto.Cant.ToString();
                        break;
                    case "My cherie amour":
                        txt_cMyChaireAmour.Text = producto.Cant.ToString();
                        break;
                    case "quebec":
                        txt_cQuebec.Text = producto.Cant.ToString();
                        break;
                }
            }
        }

        private string GetProductCantidad(string productName)
        {
            var producto = Productos?.Find(item => item.Product == productName);
            return producto?.Cant.ToString() ?? "No disponible";
        }
        public void ModificarProductos()
        {
            if (Productos != null && Productos.Count > 0)
            {
                // Iterar sobre todos los productos
                foreach (var producto in Productos)
                {
                    // Buscar y actualizar la cantidad
                    string nombreCantidad = $"txt_c{producto.Product.Replace(" ", "").Replace("'", "").Replace("´", "")}";
                    var txtCantidad = FindControlRecursive(this, nombreCantidad) as TextBox;
                    if (txtCantidad != null && int.TryParse(txtCantidad.Text, out int cantidad))
                    {
                        producto.Cant = cantidad;
                    }

                    // Buscar y actualizar el precio
                    string nombrePrecio = $"txt_p{producto.Product.Replace(" ", "").Replace("'", "").Replace("´", "")}";
                    var txtPrecio = FindControlRecursive(this, nombrePrecio) as TextBox;
                    if (txtPrecio != null && decimal.TryParse(txtPrecio.Text, out decimal precio))
                    {
                        producto.Price = precio;
                    }
                }

                // Guardar los cambios en el archivo JSON
                ActualizarJson();
                MessageBox.Show("Productos actualizados correctamente.");
            }
        }

        // Método para buscar un control dentro del formulario de manera recursiva
        private Control FindControlRecursive(Control parent, string name)
        {
            foreach (Control control in parent.Controls)
            {
                if (control.Name == name)
                {
                    return control;
                }

                // Buscar recursivamente en los controles hijos
                var child = FindControlRecursive(control, name);
                if (child != null)
                {
                    return child;
                }
            }
            return null;
        }
    }
}

