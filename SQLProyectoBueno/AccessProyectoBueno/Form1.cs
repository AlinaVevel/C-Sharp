using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Text.RegularExpressions;
using System.Data.SqlClient;

namespace AccessProyectoBueno
{
    public partial class Form1 : Form
    {
        SqlConnection conexionConlaBD = new SqlConnection(@"server=DESKTOP-SF25OMH\SQLEXPRESS; database = SqlS_DbPersonas; integrated security = true");
        string cadenaSql = @"SELECT * 
                                   FROM SqlS_TaPersonas
                                  ORDER BY Dni;";
        

        public Form1()
        {
            InitializeComponent();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlDataAdapter puenteConLaTabla = new SqlDataAdapter(cadenaSql, conexionConlaBD);
            DataTable tablaDeLaDB = new DataTable();
            puenteConLaTabla.Fill(tablaDeLaDB);
            dtgvDatos.DataSource = tablaDeLaDB;
            //LAPTOP-22N1MPUV\SQLEXPRESS
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Regex regexEdad = new Regex("[0-9]{1,2}^$");

            if(regexEdad.IsMatch(txbEdad.Text))
            {
                txbEdad.Text = "0";
            }      
            string cadenaSql = @"
                 IF NOT EXISTS (SELECT * FROM SqlS_TaPersonas WHERE Dni = @Dni)
                   BEGIN
                      INSERT INTO SqlS_TaPersonas
                        (Dni, Nombre, Apellido1, Apellido2, Edad)
                      VALUES
                        (@Dni, @Nombre, @Apellido1, @Apellido2, @Edad)
                   END;";
          
            SqlCommand instruccionesSql = new SqlCommand(cadenaSql, conexionConlaBD);
            instruccionesSql.Parameters.AddWithValue("@Dni", txbDni.Text);
            instruccionesSql.Parameters.AddWithValue("@Nombre", txbNombre.Text);
            instruccionesSql.Parameters.AddWithValue("@Apellido1", txbApellido1.Text);
            instruccionesSql.Parameters.AddWithValue("@Apellido2", txbApellido2.Text);
            instruccionesSql.Parameters.AddWithValue("@Edad", txbEdad.Text);
            conexionConlaBD.Open(); 
            instruccionesSql.ExecuteNonQuery();
            conexionConlaBD.Close();

            refrescarTabla();
            limpiarPantalla();
          
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string cadenaSql = $@"SELECT * 
                                   FROM SqlS_TaPersonas
                                  WHERE Dni = @Dni;";

            SqlCommand instruccionesSql = new SqlCommand(cadenaSql, conexionConlaBD);
            instruccionesSql.Parameters.AddWithValue("@Dni", txbDni.Text);
            conexionConlaBD.Open();
            SqlDataReader registro = instruccionesSql.ExecuteReader();
            if (registro.Read())
            {
                txbDni.Text = registro["Dni"].ToString();
                txbNombre.Text = registro["Nombre"].ToString();
                txbApellido1.Text = registro["Apellido1"].ToString();
                txbApellido2.Text = registro["Apellido2"].ToString();
                txbEdad.Text = registro["Edad"].ToString();
            }
            conexionConlaBD.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string dni = txbDni.Text;

            string cadenaSql = $@"
            IF EXISTS (SELECT * FROM SqlS_TaPersonas WHERE Dni = @Dni)
              BEGIN

                UPDATE SqlS_TaPersonas
                SET
                    Dni = @Dni,
                    Nombre = @Nombre,
                    Apellido1 = @Apellido1,
                    Apellido2 = @Apellido2,
                    Edad = @Edad
                WHERE Dni = '{dni}'
              END;";

            SqlCommand instruccionesSql = new SqlCommand(cadenaSql, conexionConlaBD);
            instruccionesSql.Parameters.AddWithValue("@Dni", dni);
            instruccionesSql.Parameters.AddWithValue("@Nombre", txbNombre.Text);
            instruccionesSql.Parameters.AddWithValue("@Apellido1", txbApellido1.Text);
            instruccionesSql.Parameters.AddWithValue("@Apellido2", txbApellido2.Text);
            instruccionesSql.Parameters.AddWithValue("@Edad", txbEdad.Text);
            conexionConlaBD.Open();
            instruccionesSql.ExecuteNonQuery();
            conexionConlaBD.Close();
            refrescarTabla();
            limpiarPantalla();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string cadenaSqlEliminar = @"
                    DELETE FROM SqlS_TaPersonas
                    WHERE Dni = @DNI;";

            SqlCommand instruccionesSql = new SqlCommand(cadenaSqlEliminar, conexionConlaBD);
            instruccionesSql.Parameters.AddWithValue("@DNI", txbDni.Text);
            conexionConlaBD.Open();
            instruccionesSql.ExecuteNonQuery();
            conexionConlaBD.Close();
            refrescarTabla();
            limpiarPantalla();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarPantalla();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void refrescarTabla()
        {
            SqlDataAdapter puenteConLaTabla = new SqlDataAdapter(cadenaSql, conexionConlaBD);
            DataTable tablaDeLaDB = new DataTable();
            puenteConLaTabla.Fill(tablaDeLaDB);
            dtgvDatos.DataSource = tablaDeLaDB;
        }

        private void limpiarPantalla()
        {
            txbDni.Text = "";
            txbNombre.Text = "";
            txbApellido1.Text = "";
            txbApellido2.Text = "";
            txbEdad.Text = "";
        }
    }
}
