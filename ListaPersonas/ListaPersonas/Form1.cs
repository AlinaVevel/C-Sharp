using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace ListaPersonas
{
    public partial class Form1 : Form
    {
        
        OleDbConnection conexionConLaBD = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;
                                                    Data Source=D:\Interfaces\ListaPersonas\Personasaccdb.accdb");
        string cadenaSql = @"SELECT *
                                FROM Personas
                                ORDER BY Dni";






        public Form1()
        {



            InitializeComponent();



        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!checkDni(txtBoxDNI.Text) )
            {
                String cadenaSqlAgregar = $@"
                INSERT INTO Personas
                (Dni, Nombre, Apellido1, Apellido2, Edad)
                VALUES
                (@Dni, @Nombre, @Apellido1, @Apellido2, @Edad);";

                OleDbCommand instruccionesSql = new OleDbCommand(cadenaSqlAgregar, conexionConLaBD);
                instruccionesSql.Parameters.AddWithValue("@Dnie", txtBoxDNI.Text);
                instruccionesSql.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                instruccionesSql.Parameters.AddWithValue("@Apellido1", txtBoxApellino1.Text);
                instruccionesSql.Parameters.AddWithValue("@Apellido2", txtApellido2.Text);
                instruccionesSql.Parameters.AddWithValue("@Edad", txtBoxEdad.Text);

                conexionConLaBD.Open();
                instruccionesSql.ExecuteNonQuery();
                conexionConLaBD.Close();

                Rellenar();
            }

           




        }

        public bool checkDni(string dni)
        {
            if (dni.Equals(""))
            {
                return true;
            }
            return false;
        }
        public void leerFile()
        {
            //string[] campo;
            //
            //    
            //    foreach (string line in File.ReadLines(ruraFichero)
            //    {
            //        campo = Regex.Split(line, "\t")
            //Persona persona = new Persona ();
            //persona.Dni = campo[0];
            //lista.Add(persona);         


            //    }
            //}
            
        }

       /* private List<Persona> leerFichero()
        {
            FileInfo fichero;
            string registro;
            string[] campo;
            DirectoryInfo directorio = new DirectoryInfo(@"..\..\..\DirListaPersonas");

            if (!directorio.Exists)
            {
                Directory.CreateDirectory(@"..\..\..\DirListaPersonas\PersonFile.txt");
            }
            fichero = new FileInfo(@"..\..\..\DirListaPersonas\PersonFile.txt");
            if (fichero.Exists)
            {
                StreamReader linea = new StreamReader(@"..\..\..\DirListaPersonas\PersonFile.txt");
                using (linea)
                {
                    while (linea.Peek() != -1)
                    {
                        Persona persona = new Persona();
                        registro = linea.ReadLine();
                        campo = Regex.Split(registro, "\t");
                        persona.Dni = campo[0];
                        persona.Nombre = campo[1];
                        persona.Apellido1 = campo[2];
                        persona.Apellido2 = campo[3];
                        persona.Edad = int.Parse(campo[4]);

                        lista.Add(persona);
                    }
                }
            }
            return lista;
        }
        public void saveToFile()
        {
            using (TextWriter tw = new StreamWriter(@"..\..\..\DirListaPersonas\PersonFile.txt"))
            {
                foreach (Persona p in lista)
                {                    
                    tw.WriteLine(p.ToString());                    
                }
                tw.Close();
            }
        }*/



        private void btnModificar_Click(object sender, EventArgs e)
        {

            string dni = txtBoxDNI.Text;

            string cadenaSql = $@"
                UPDATE Personas
                SET
                    Dni = @Dni,
                    Nombre = @Nombre,
                    Apellido1 = @Apellido1,
                    Apellido2 = @Apellido2,
                    Edad = @Edad
                WHERE Dni = '{dni}';";

            OleDbCommand instruccionesSql = new OleDbCommand(cadenaSql, conexionConLaBD);
            instruccionesSql.Parameters.AddWithValue("@Dni", dni);
            instruccionesSql.Parameters.AddWithValue("@Nombre", txtNombre.Text);
            instruccionesSql.Parameters.AddWithValue("@Apellido1", txtBoxApellino1.Text);
            instruccionesSql.Parameters.AddWithValue("@Apellido2", txtApellido2.Text);
            instruccionesSql.Parameters.AddWithValue("@Edad", txtBoxEdad.Text);
            conexionConLaBD.Open();
            instruccionesSql.ExecuteNonQuery();
            conexionConLaBD.Close();
            Rellenar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            String cadenaSqlEliminar = @"
                    DELETE FROM Personas
                    WHERE Dni = @DNI;";

            OleDbCommand instruccionesSql = new OleDbCommand(cadenaSqlEliminar, conexionConLaBD);
            instruccionesSql.Parameters.AddWithValue("@DNI", txtBoxDNI.Text);
            conexionConLaBD.Open();
            instruccionesSql.ExecuteNonQuery();
            conexionConLaBD.Close();
            Rellenar();
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            
               

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Rellenar();
        }

        public void LimpiarCampos()
        {
            txtBoxDNI.Text = "";
            txtNombre.Text = "";
            txtBoxApellino1.Text = "";
            txtApellido2.Text = "";
            txtBoxEdad.Text = "";
        }

        private void Rellenar()
        {
            OleDbDataAdapter puente = new OleDbDataAdapter(cadenaSql, conexionConLaBD);
            DataTable dt = new DataTable();
            puente.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string cadenaSqlBuscar = $@"SELECT * 
                                   FROM Personas 
                                  WHERE Dni = @DNI;";

            OleDbCommand instruccionesSql = new OleDbCommand(cadenaSqlBuscar, conexionConLaBD);
            instruccionesSql.Parameters.AddWithValue("@DNI", txtBoxDNI.Text);
            conexionConLaBD.Open();
            OleDbDataReader registro = instruccionesSql.ExecuteReader();
            if (registro.Read())
            {
                txtBoxDNI.Text = registro["DNI"].ToString();
                txtNombre.Text = registro["Nombre"].ToString();
                txtBoxApellino1.Text = registro["Apellido1"].ToString();
                txtApellido2.Text = registro["Apellido2"].ToString();
                txtBoxEdad.Text = registro["Edad"].ToString();
            }
            conexionConLaBD.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtBoxDNI.Text = "";
            txtNombre.Text = "";
            txtApellido2.Text = "";
            txtBoxApellino1.Text = "";
            txtBoxEdad.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
