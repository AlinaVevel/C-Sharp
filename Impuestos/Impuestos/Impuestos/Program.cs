using System;

namespace Impuestos
{
    class Program
    {
        static void Main(string[] args)
        {
            string IVA = ""; 
            int impuesto = 0;
                     
            do
            {
                obtenerIVA();
                if (impuesto == 0)
                {
                    break;
                }
            } while (IVA != "0");
            
            
        }
        public static void obtenerIVA()
        {
            string IVA;
            do
            {
                Console.Write("Introduce el tipo de IVA que desea aplicar (el 4%, el 10% o el 21%)(0 para salir) : ");
                IVA = Console.ReadLine();
                int.TryParse(IVA, out int impuesto);
                if (IVA == "4" || IVA == "10"|| IVA == "21")
                {
                    obtenerPrecio(impuesto);
                }
            } while (IVA != "0");
        }
        public static void obtenerPrecio(int impuesto)
        {
            Console.Write("Introduce el precio del producto al que deseas añadir el IVA : ");
            string precioProducto = Console.ReadLine();
            int.TryParse(precioProducto, out int precio);
            
            while (!int.TryParse(precioProducto, out precio))
            {
                Console.Write("Introduce el precio del producto al que deseas añadir el IVA : ");
                precioProducto = Console.ReadLine();
                int.TryParse(precioProducto, out precio);
                        
            }
            CalculoPrecio(impuesto, precio);
        }
        public static void CalculoPrecio(int impuesto, int precio)
        {
            int resultado = 0;
            if (impuesto == 4)
            {
                resultado = (int)(precio * 1.04);
            }
            else if (impuesto == 10)
            {
                resultado = (int)(precio * 1.10);
            }
            else if (impuesto == 21)
            {
                resultado = (int)(precio * 1.21);
            }
            Resultado(impuesto, resultado);
            
            
        }
        public static void Resultado(int impuesto, int resultado)
        {
            Console.WriteLine("El precio final del producto con el {0}% de IVA es {1} Euros", impuesto, resultado);
        }
                }    
            }
       
    