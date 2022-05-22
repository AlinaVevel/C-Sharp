using System;
using System.Collections.Generic;
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

        public override string ToString()
        {
            return $"{dni}\t {nombre}\t {apellido1}\t {apellido2}\t {edad}\t";
        }
    }
}
