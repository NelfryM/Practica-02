using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversion_Fraccion
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
                Console.WriteLine("Ingrese su fraccion mixta en el formato 'a b/c': ");
                string input = Console.ReadLine();

                // Separamos los valores de la fracción mixta
                string[] valores = input.Split(' ');

                int a = int.Parse(valores[0]);
                int b = int.Parse(valores[1].Split('/')[0]);
                int c = int.Parse(valores[1].Split('/')[1]);

                // Calculamos la fracción común
                int numerador = (a * c) + b;
                int denominador = c;

                Console.WriteLine($"La fraccion comun correspondiente a {input} es: \n {numerador}/{denominador}");

            Console.ReadLine();
            }
        }
    }
