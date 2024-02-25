using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafío2
{
    internal class Program
    {
        class operaciones
        {
            public static int Suma(int Numero1, int Numero2)
            {
                return Numero1 + Numero2;
            }

            public static int Resta(int Numero1, int Numero2)
            {
                return Numero1 - Numero2;
            }

            public static int multiplicacion(int Numero1, int Numero2)
            {
                return Numero1 * Numero2;
            }

            public static int division(int Numero1, int Numero2)
            {
                return Numero1 / Numero2;
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine(operaciones.Suma(3, 4));
            Console.WriteLine(operaciones.Resta(156,21));
            Console.WriteLine(operaciones.multiplicacion(12,75));
            Console.WriteLine(operaciones.division(100,10));

            Console.ReadKey();
        }
    }
}
