using System;
using System.Text.RegularExpressions;

namespace DNI
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputData;
            
            Regex exFecha = new Regex("^[0-9]{8}$");
            Regex salirFecha = new Regex("^0$");
            inputData = InputData();
           
            

            while (inputData != "0")
            {
                int DNI;
                int.TryParse(inputData.Substring(0, 8), out DNI);
                string letters = "TRWAGMYFPDXBNJZSQVHLCKE";
                int result = DNI % 23;
                
                Console.WriteLine("{0}{1}",DNI,letters[result]);
                inputData = InputData();

                
            }
            string InputData()
            {
                string fecha;

                do
                {
                    Console.Write("Introduzca la num dni, 0 para salir  ");
                    fecha = Console.ReadLine();

                } while (!exFecha.IsMatch(fecha) && !salirFecha.IsMatch(fecha));

                return fecha;
            }
        }
    }
}