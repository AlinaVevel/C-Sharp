using System;
using System.Text.RegularExpressions;

namespace RomanosToArab
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex sintaxis = new Regex("^M{0,3}(CM|CD|D?C{0,3})(XC|XL|L?X{0,3})(IX|IV|V?I{0,3})$");
                        string numeroRomano;
                        do
                        {
                            Console.Write("Escriba numeros Romanos entre I y MMMCMXCIX ( 0 para salir) : ");
                            numeroRomano = (Console.ReadLine()?.ToUpper());
                            int suma = 0;
            
                            if (numeroRomano != null && sintaxis.IsMatch(numeroRomano) && numeroRomano != "")
                            {
                                for (int i = numeroRomano.Length - 1; i >= 0; i--)
                                {
                                    if (i == 0)
                                    {
                                        suma += valorDeSigno(numeroRomano[0]);
                                    }
                                    else
                                    {
                                        string letras = numeroRomano.Substring(i - 1, 2);
                                        switch (letras)
                                        {
                                            case "IV": suma += 4; i--; break;
                                            case "IX": suma += 9; i--; break;
                                            case "XL": suma += 40; i--; break;
                                            case "XC": suma += 90; i--; break;
                                            case "CD": suma += 400; i--; break;
                                            case "CM": suma += 900; i--; break;
                                            default: suma += valorDeSigno(letras[1]); break;
                                        }
                                    }
                                }
                                Console.WriteLine("En arábigo es : {0}", suma);
                            }
                        } while (numeroRomano != "0");
        }
        private static int valorDeSigno(char letra)
        {
            switch (letra)
            {
                case 'I': return 1;
                case 'V': return 5;
                case 'X': return 10;
                case 'L': return 50;
                case 'C': return 100;
                case 'D': return 500;
                default: return 1000;
            }
        }
    }
}