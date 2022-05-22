using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaPersonas
{
    internal class Persona
    {
        private string dni;
        private string nombre;
        private string apellido1;
        private string apellido2;
        private int edad;
        OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Interfaces\ListaPersonas2\ListaPersonas\Personasaccdb.accdb");

        //("^[0-9]+([,][0-9]+)?$");

        public string Dni
        {
            get { return dni; }
            set { dni = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }

        }

        public string Apellido1
        {
            get { return apellido1; }
            set { apellido1 = value; }
        }

        public string Apellido2
        {
            get { return apellido2; }
            set { apellido2 = value; }
        }

        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }

        public DataTable Refrescar()
        {
            string cadena = @"Select * FROM Personas";
            OleDbDataAdapter da = new OleDbDataAdapter(cadena, connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public void AgregarPersona(Persona persona)
        {
            try
            {
                string cadena = @"INSERT INTO Personas(Dni, Nombre, Apellido1, Apellido2, Edad) VALUES(@Dni, @Nombre, @Apellido, @Apellido2, @Edad)";
                OleDbCommand cmd = new OleDbCommand(cadena, connection);
                cmd.Parameters.AddWithValue("Dni", persona.dni);
                cmd.Parameters.AddWithValue("Nombre", persona.nombre);
                cmd.Parameters.AddWithValue("Apellido1", persona.apellido1);
                cmd.Parameters.AddWithValue("Apellido2", persona.apellido2);
                cmd.Parameters.AddWithValue("Edad", persona.edad);
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }catch (Exception ex)
            {

            }
           
        }

        public void ModificarPersona(Persona persona)
        {
            try
            {
                string cadena = @"UPDATE Personas SET Dni = @Dni, Nombre = @Nombre, Apellido1 = @Apellido1, Apellido2 = @Apellido2, Edad = @Edad WHERE Dni = @Dni";
                OleDbCommand c = new OleDbCommand(cadena, connection);
                c.Parameters.AddWithValue("Dni", persona.dni);
                c.Parameters.AddWithValue("Nombre", persona.nombre);
                c.Parameters.AddWithValue("Apellido1", persona.apellido1);
                c.Parameters.AddWithValue("Apellido2", persona.apellido2);
                c.Parameters.AddWithValue("Edad", persona.edad);
                connection.Open();
                c.ExecuteNonQuery();
                connection.Close();
            }catch(Exception ex)
            {

            }
            
        }

        public Persona BuscarPersona(string dni)
        {
            Persona persona = new Persona();
           
               
                string cadena = @"SELECT * FROM Personas WHERE Dni = @Dni";
                OleDbCommand cmd = new OleDbCommand(cadena, connection);
                cmd.Parameters.AddWithValue("Dni", dni);
                connection.Open();
                OleDbDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    persona.nombre = reader["Nombre"].ToString();
                    persona.apellido1 = reader["Apellido1"].ToString();
                    persona.apellido2 = reader["Apellido2"].ToString();
                    persona.edad = Convert.ToInt32(reader["Edad"].ToString());
                }
                connection.Close();
           

            return persona;
        }

        public void BorrarPersona(Persona persona)
        {
            try
            {
                string cadena = @"DELETE FROM Personas WHERE Dni = @Dni";
                OleDbCommand command = new OleDbCommand(cadena, connection);
                command.Parameters.AddWithValue("Dni", persona.dni);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }catch(Exception ex)
            {

            }
           
        }
    }
}
