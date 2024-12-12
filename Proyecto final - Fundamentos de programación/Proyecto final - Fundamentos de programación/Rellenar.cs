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
    public partial class Rellenar : Form
    {
        private Productos productoAModificar = new Productos();
        private Productos[] productos;
        private int indice;

        private void generarArreglo()
        {
            string jsonFile = @"..\\..\\..\\..\\JSONs\\cds.json";
            string jsonCds = System.IO.File.ReadAllText(jsonFile);
            productos = new Productos[20];
            productos = JsonConvert.DeserializeObject<Productos[]>(jsonCds);
        }

        public Rellenar()
        {
            InitializeComponent();
        }

        private void Rellenar_Load(object sender, EventArgs e)
        {
            generarArreglo();
            actualizarProductos();
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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void thebends_Click(object sender, EventArgs e)
        {
            productoAModificar = productos[0];
            panelModif.Visible = true;
            label68.Text = "Álbum: " + productos[0].titulo;
            label69.Text = "Artista: " + productos[0].artista;
            label70.Text = "Año: " + productos[0].fecha;
            label71.Text = "Precio: $" + productos[0].precio.ToString();
        }

        private void vespertine_Click(object sender, EventArgs e)
        {
            productoAModificar = productos[1];
            panelModif.Visible = true;
            label68.Text = "Álbum: " + productos[1].titulo;
            label69.Text = "Artista: " + productos[1].artista;
            label70.Text = "Año: " + productos[1].fecha;
            label71.Text = "Precio: $" + productos[1].precio.ToString();
        }

        private void atmp_Click(object sender, EventArgs e)
        {
            productoAModificar = productos[2];
            panelModif.Visible = true;
            label68.Text = "Álbum: " + productos[2].titulo;
            label69.Text = "Artista: " + productos[2].artista;
            label70.Text = "Año: " + productos[2].fecha;
            label71.Text = "Precio: $" + productos[2].precio.ToString();
        }

        private void heavenorlasvegas_Click(object sender, EventArgs e)
        {
            productoAModificar = productos[3];
            panelModif.Visible = true;
            label68.Text = "Álbum: " + productos[3].titulo;
            label69.Text = "Artista: " + productos[3].artista;
            label70.Text = "Año: " + productos[3].fecha;
            label71.Text = "Precio: $" + productos[3].precio.ToString();
        }

        private void monster_Click(object sender, EventArgs e)
        {
            productoAModificar = productos[4];
            panelModif.Visible = true;
            label68.Text = "Álbum: " + productos[4].titulo;
            label69.Text = "Artista: " + productos[4].artista;
            label70.Text = "Año: " + productos[4].fecha;
            label71.Text = "Precio: $" + productos[4].precio.ToString();
        }

        private void titanicRising_Click(object sender, EventArgs e)
        {
            productoAModificar = productos[5];
            panelModif.Visible = true;
            label68.Text = "Álbum: " + productos[5].titulo;
            label69.Text = "Artista: " + productos[5].artista;
            label70.Text = "Año: " + productos[5].fecha;
            label71.Text = "Precio: $" + productos[5].precio.ToString();
        }

        private void deathconsciousness_Click(object sender, EventArgs e)
        {
            productoAModificar = productos[6];
            panelModif.Visible = true;
            label68.Text = "Álbum: " + productos[6].titulo;
            label69.Text = "Artista: " + productos[6].artista;
            label70.Text = "Año: " + productos[6].fecha;
            label71.Text = "Precio: $" + productos[6].precio.ToString();
        }

        private void graduation_Click(object sender, EventArgs e)
        {
            productoAModificar = productos[7];
            panelModif.Visible = true;
            label68.Text = "Álbum: " + productos[7].titulo;
            label69.Text = "Artista: " + productos[7].artista;
            label70.Text = "Año: " + productos[7].fecha;
            label71.Text = "Precio: $" + productos[7].precio.ToString();
        }

        private void cantbuyathrill_Click(object sender, EventArgs e)
        {
            productoAModificar = productos[8];
            panelModif.Visible = true;
            label68.Text = "Álbum: " + productos[8].titulo;
            label69.Text = "Artista: " + productos[8].artista;
            label70.Text = "Año: " + productos[8].fecha;
            label71.Text = "Precio: $" + productos[8].precio.ToString();
        }

        private void ten_Click(object sender, EventArgs e)
        {
            productoAModificar = productos[9];
            panelModif.Visible = true;
            label68.Text = "Álbum: " + productos[9].titulo;
            label69.Text = "Artista: " + productos[9].artista;
            label70.Text = "Año: " + productos[9].fecha;
            label71.Text = "Precio: $" + productos[9].precio.ToString();
        }

        private void humanHymns_Click(object sender, EventArgs e)
        {
            productoAModificar = productos[10];
            panelModif.Visible = true;
            label68.Text = "Álbum: " + productos[10].titulo;
            label69.Text = "Artista: " + productos[10].artista;
            label70.Text = "Año: " + productos[10].fecha;
            label71.Text = "Precio: $" + productos[10].precio.ToString();
        }

        private void coastalgrooves_Click(object sender, EventArgs e)
        {
            productoAModificar = productos[11];
            panelModif.Visible = true;
            label68.Text = "Álbum: " + productos[11].titulo;
            label69.Text = "Artista: " + productos[11].artista;
            label70.Text = "Año: " + productos[11].fecha;
            label71.Text = "Precio: $" + productos[11].precio.ToString();
        }

        private void charm_Click(object sender, EventArgs e)
        {
            productoAModificar = productos[12];
            panelModif.Visible = true;
            label68.Text = "Álbum: " + productos[12].titulo;
            label69.Text = "Artista: " + productos[12].artista;
            label70.Text = "Año: " + productos[12].fecha;
            label71.Text = "Precio: $" + productos[12].precio.ToString();
        }

        private void atlantmillclub_Click(object sender, EventArgs e)
        {
            productoAModificar = productos[13];
            panelModif.Visible = true;
            label68.Text = "Álbum: " + productos[13].titulo;
            label69.Text = "Artista: " + productos[13].artista;
            label70.Text = "Año: " + productos[13].fecha;
            label71.Text = "Precio: $" + productos[13].precio.ToString();
        }

        private void midnitevultures_Click(object sender, EventArgs e)
        {
            productoAModificar = productos[14];
            panelModif.Visible = true;
            label68.Text = "Álbum: " + productos[14].titulo;
            label69.Text = "Artista: " + productos[14].artista;
            label70.Text = "Año: " + productos[14].fecha;
            label71.Text = "Precio: $" + productos[14].precio.ToString();
        }

        private void imperfectoextraño_Click(object sender, EventArgs e)
        {
            productoAModificar = productos[15];
            panelModif.Visible = true;
            label68.Text = "Álbum: " + productos[15].titulo;
            label69.Text = "Artista: " + productos[15].artista;
            label70.Text = "Año: " + productos[15].fecha;
            label71.Text = "Precio: $" + productos[15].precio.ToString();
        }

        private void plasticbeach_Click(object sender, EventArgs e)
        {
            productoAModificar = productos[16];
            panelModif.Visible = true;
            label68.Text = "Álbum: " + productos[16].titulo;
            label69.Text = "Artista: " + productos[16].artista;
            label70.Text = "Año: " + productos[16].fecha;
            label71.Text = "Precio: $" + productos[16].precio.ToString();
        }

        private void cuarentayveinte_Click(object sender, EventArgs e)
        {
            productoAModificar = productos[17];
            panelModif.Visible = true;
            label68.Text = "Álbum: " + productos[17].titulo;
            label69.Text = "Artista: " + productos[17].artista;
            label70.Text = "Año: " + productos[17].fecha;
            label71.Text = "Precio: $" + productos[17].precio.ToString();
        }

        private void mycherieamour_Click(object sender, EventArgs e)
        {
            productoAModificar = productos[18];
            panelModif.Visible = true;
            label68.Text = "Álbum: " + productos[18].titulo;
            label69.Text = "Artista: " + productos[18].artista;
            label70.Text = "Año: " + productos[18].fecha;
            label71.Text = "Precio: $" + productos[18].precio.ToString();
        }

        private void quebec_Click(object sender, EventArgs e)
        {
            productoAModificar = productos[19];
            panelModif.Visible = true;
            label68.Text = "Álbum: " + productos[19].titulo;
            label69.Text = "Artista: " + productos[19].artista;
            label70.Text = "Año: " + productos[19].fecha;
            label71.Text = "Precio: $" + productos[19].precio.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (inputNTitulo.Text != string.Empty)
            {
                productoAModificar.titulo = inputNTitulo.Text;
            }

            if (inputNArtista.Text != string.Empty)
            {
                productoAModificar.artista = inputNArtista.Text;
            }

            if (inputNFecha.Text != string.Empty)
            {
                productoAModificar.fecha = inputNFecha.Text;
            }

            if (inputNPrecio.Text != string.Empty)
            {
                productoAModificar.precio = inputNPrecio.Text;
            }

            for (int i = 0; i < 20; i++)
            {
                if (label68.Text == "Artista: " + productos[i].titulo)
                {
                    productos[i] = productoAModificar;
                    break;
                }
            }

            string jsonFile = @"..\\..\\..\\..\\JSONs\\cds.json";
            string actualizarJSON = JsonConvert.SerializeObject(productos, Formatting.Indented);
            System.IO.File.WriteAllText(jsonFile, actualizarJSON);
            MessageBox.Show("Producto modificado exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            panelModif.Visible = false;

            generarArreglo();
            actualizarProductos();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
