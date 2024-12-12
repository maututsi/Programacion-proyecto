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
        public bool ingresoEmpleado = false;
        public bool ingresoAdmin = false;
        public static string nombre;
        public static string clave;

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
            string archivoJSON = @"..\\..\\..\\..\\JSONs\usuarios.json";

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
                        MessageBox.Show("Bienvenido " + user.nombre, "Ingreso exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Form1.nombre = user.nombre;
                        Form1.clave = user.clave;

                        if (user.rol == "empleado")
                        {
                            ingresoEmpleado = true;
                            this.Close();
                        }
                        else if (user.rol == "admin")
                        {
                            ingresoAdmin = true;
                            this.Close();
                        }
                        break;
                    }
                    else if (user == usuarios[usuarios.Length - 1])
                    {
                        MessageBox.Show("Usuario no encontrado", "Error de ingreso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void passInput_TextChanged(object sender, EventArgs e)
        {

        }
    }

    public class usuario
    {
        public string nombre, clave, contraseña, rol;

    }
}
