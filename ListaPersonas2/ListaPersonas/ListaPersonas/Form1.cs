using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaPersonas
{
    public partial class Form1 : Form
    {
        Persona persona = new Persona();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            persona.Dni = txtBoxDNI.Text;   
            persona.Nombre = txtNombre.Text;
            persona.Apellido1 = txtBoxApellino1.Text;
            persona.Apellido2 = txtApellido2.Text;
            
            persona.AgregarPersona(persona);
            dataGridView1.DataSource = persona.Refrescar();
            Limpiar();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = persona.Refrescar();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string dni  = txtBoxDNI.Text;
            
            persona =  persona.BuscarPersona(dni);

            txtNombre.Text = persona.Nombre;
            txtBoxApellino1.Text = persona.Apellido1;
            txtApellido2.Text = persona.Apellido2;
            txtBoxEdad.Text = persona.Edad.ToString();
            dataGridView1.DataSource = persona.Refrescar();

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            persona.Dni = txtBoxDNI.Text;
            persona.Nombre = txtNombre.Text;
            persona.Apellido1 = txtBoxApellino1.Text;
            persona.Apellido2 = txtApellido2.Text;
            persona.Edad = Convert.ToInt32(txtBoxEdad.Text);
            persona.ModificarPersona(persona);
            dataGridView1.DataSource = persona.Refrescar();
            Limpiar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            persona.Dni = txtBoxDNI.Text;
            persona.BorrarPersona(persona);
            dataGridView1.DataSource = persona.Refrescar();
            Limpiar();
        }

        public void Limpiar()
        {
            txtBoxDNI.Text = "";
            txtNombre.Text = "";
            txtBoxApellino1.Text = "";
            txtApellido2.Text = "";
            txtBoxEdad.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}
