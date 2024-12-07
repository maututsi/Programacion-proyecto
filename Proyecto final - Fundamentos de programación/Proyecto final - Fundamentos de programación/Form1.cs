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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string archivoJSON = @"..\\..JSONs\usuarios.json";

            string claveEmpleado = claveInput.Text;
            string contraseña = passInput.Text;

            if (claveEmpleado == "" || contraseña == "")
            {
                MessageBox.Show("No deje campos vacíos", "Error de ingreso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string json = System.IO.File.ReadAllText(archivoJSON);
                usuario[] usuarios = JsonConvert.DeserializeObject<usuario[]>(json);

                foreach(usuario user in usuarios)
                {
                    if (user.clave == claveEmpleado && user.contraseña == contraseña)
                    {
                        
                    }

                }
            }
        }
    }

    public class usuario
    {
        public string clave, contraseña, rol;

    }
}
