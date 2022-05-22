using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Libreria
{
    
    public partial class Autores : Form
    {
        OleDbConnection conexionConlaBD = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\alumno\Documents\Interfaces\Libreria2\Libreria\Access_DbLibreria.accdb");
        string cadenaSql = @"SELECT * 
                                   FROM Access_TaAutores 
                                  ORDER BY Nombre;";
        public Autores()
        {
            InitializeComponent();
        }

        private void Autores_Load(object sender, EventArgs e)
        {
            OleDbDataAdapter puenteConLaTabla = new OleDbDataAdapter(cadenaSql, conexionConlaBD);
            DataTable tablaDeLaDB = new DataTable();
            puenteConLaTabla.Fill(tablaDeLaDB);
            dataGridAutores.DataSource = tablaDeLaDB;
        }
    }
}
