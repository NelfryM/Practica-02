using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculo_MCD_MCM
{
    internal class Program
    {
        static void Main(string[] args)
        {
        
                Console.WriteLine("Ingrese el primer número: ");
                int num1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese el segundo número: ");
                int num2 = int.Parse(Console.ReadLine());

                int mcd = CalcularMCD(num1, num2);
                int mcm = (num1 * num2) / mcd;


            Console.WriteLine($"El MCD de {num1} y {num2} es {mcd}");
                Console.WriteLine($"El MCM de {num1} y {num2} es {mcm}");

            Console.ReadLine();
        }

        
            static int CalcularMCD(int a, int b)
                
        {
                if (b == 0)
                    return a;

                return CalcularMCD(b, a % b);



        }


    }

}
