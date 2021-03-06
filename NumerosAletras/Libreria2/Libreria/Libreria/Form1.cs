using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Libreria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAutores_Click(object sender, EventArgs e)
        {
            Autores autor = new Autores();
            this.Hide();
            autor.ShowDialog();
            this.Show();
        }

        private void btnLibros_Click(object sender, EventArgs e)
        {
            Libros libros = new Libros();
            this.Hide();
            libros.ShowDialog();
            this.Show();
        }

        private void btnLibreria_Click(object sender, EventArgs e)
        {
            Libreria libreria = new Libreria();
            this.Hide();
            libreria.ShowDialog();
            this.Show();
        }
    }
}
