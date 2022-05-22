using System;

namespace Impuestos1
{
    class Program
    {
        static void Main(string[] args){
        
            string priceProduct = "";
            string IVA = "";
            int result = 0;
            int price;
            do
            {
                Console.Write("Introduce el tipo de IVA que desea aplicar (el 4%, el 10% o el 21%)(0 para salir) : ");
                IVA = Console.ReadLine();
                int.TryParse(IVA, out int money);
                if (money == 4 || money == 10 || money == 21)
                {
                    Console.Write("Introduce el precio del producto al que deseas añadir el IVA : ");
                    String respuesta = Console.ReadLine();
                    int.TryParse(respuesta, out price);
                    while (!int.TryParse(respuesta, out price))
                    {
                        Console.Write("Introduce el precio del producto al que deseas añadir el IVA : ");
                        respuesta = Console.ReadLine();
                        int.TryParse(respuesta, out price);
                        
                    }
                    
                    if (money == 4)
                    {
                        result = (int)(price * 1.04);
                    }
                    else if (money == 10)
                    {
                        result = (int)(price * 1.10);
                    }
                    else if (money == 21)
                    {
                        result = (int)(price * 1.21);
                    }
                    Console.WriteLine("El precio final del producto con el {0}% de IVA es {1} Euros", IVA, result);
                }
            } while (IVA != "0");
        }
    } 
}
