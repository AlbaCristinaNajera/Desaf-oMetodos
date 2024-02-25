using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Por favor ingrese el primer valor:");
                int Valor1 = int.Parse(Console.ReadLine());
                Console.Write("Por favor ingrese el segundo valor:");
                int Valor2 = int.Parse(Console.ReadLine());

                Suma(Valor1,Valor2);
                Console.ReadKey();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Los datos ingresados no son válidos para el programa, o son diferentes a int");
                Console.ReadKey();
            }

        }

        static void Suma(int Valor1, int Valor2)
        {
            Console.WriteLine("La suma de los datos ingresados es: " + (Valor1+Valor2) );
        }
    }
}
