﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Proyecto_final___Fundamentos_de_programación
{
    public partial class Ventas : Form
    {
        private List<ventas> ventas = new List<ventas>();

        public Ventas()
        {
            InitializeComponent();
        }

        private void Ventas_Load(object sender, EventArgs e)
        {
            ConfigrarData();
            DescargarListaVentas();
        }

        private void ConfigrarData()
        {   
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
        }

        private void DescargarListaVentas()
        {
            string fileJson = @"..\\..\\..\\..\\JSONs\cds.json";
            string json = System.IO.File.ReadAllText(fileJson);
            dataGridView1.DataSource = JsonConvert.DeserializeObject<DataTable>(json);

        } 

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 Form2 = new Form2();
            Form2.Show();       
                
        }

    }

    public class ventas
    {
        public string articulo, pago;
    }
}
