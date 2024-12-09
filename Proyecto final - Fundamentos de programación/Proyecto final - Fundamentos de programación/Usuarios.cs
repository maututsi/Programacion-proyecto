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
    public partial class Usuarios : Form
    {
        private List<usuario> users = new List<usuario>();
        string Role;
        public Usuarios()
        {
            InitializeComponent();
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            ConfigurarData();
            DescargarListaUsuarios();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Role = "Manager";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Role = "Employed";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void ConfigurarData()
        {
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
        }
        private void DescargarListaUsuarios()
        {
            string fileJson = @"..\\..\\..\\..\\JSONs\usuarios.json";
            string json = System.IO.File.ReadAllText(fileJson);
            dataGridView1.DataSource = JsonConvert.DeserializeObject<DataTable>(json);
            users = JsonConvert.DeserializeObject<List<usuario>>(json);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = textBox1.Text;
            string pass = textBox2.Text;
            string role = Role;
            string clave= textBox3.Text;
            AgregarUsarios(nombre, pass, role, clave);
        }
        public void AgregarUsarios(string username, string password, string rol, string clave)
        {
            usuario newUsuario = new usuario();
            newUsuario.contraseña = password;
            newUsuario.rol = rol;
            newUsuario.nombre = username;
            newUsuario.clave = clave;
            users.Add(newUsuario);
            string fileJson = @"..\\..\\..\\..\\JSONs\usuarios.json";
            string json = JsonConvert.SerializeObject(users, Formatting.Indented);
            System.IO.File.WriteAllText(fileJson, json);
            dataGridView1.DataSource = JsonConvert.DeserializeObject<DataTable>(json);
        }
        public void EliminarUsuario()
        {
            int indiceseleccionado = dataGridView1.SelectedRows[0].Index;
            users.RemoveAt(indiceseleccionado);
            GuardarUsuario();
            DescargarListaUsuarios();
        }
        public void GuardarUsuario()
        {
            string fileJson = @"..\\..\\..\\..\\JSONs\usuarios.json";
            string json = JsonConvert.SerializeObject(users, Formatting.Indented);
            System.IO.File.WriteAllText(fileJson, json);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EliminarUsuario();
        }

        private void txt_user_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}