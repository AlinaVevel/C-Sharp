using System;

namespace Impuesto3
{
    class Program
    {
        static void Main(string[] args)
        {
            int IVA, precio;

            Impuestos impuesto = new Impuestos();
            do
            {             
                Console.Write("Introduce el tipo de IVA que desea aplicar (el 4%, el 10% o el 21%)(0 para salir) : ");
                string iva = Console.ReadLine();
                int.TryParse(iva, out IVA);
                while (!int.TryParse(iva, out IVA))
                {
                    Console.Write("Introduce el tipo de IVA que desea aplicar (el 4%, el 10% o el 21%)(0 para salir) : ");
                    iva = Console.ReadLine();
                    int.TryParse(iva, out IVA);
                    impuesto.setIVA(IVA);
                }
              
                if (IVA == 4 || IVA == 10 || IVA == 21)
                {
                    Console.Write("Introduce el precio del producto al que deseas añadir el IVA : ");
                    String respuesta = Console.ReadLine();
                    int.TryParse(respuesta, out precio);
                    while (!int.TryParse(respuesta, out precio))
                    {
                        Console.Write("Introduce el precio del producto al que deseas añadir el IVA : ");
                        respuesta = Console.ReadLine();
                        int.TryParse(respuesta, out precio);
                        
                    }
                    impuesto.setPrecio(precio);
                    impuesto.CalculoPrecio(IVA, precio);
                    
                }
            } while (IVA != 0);
        }
    }

}