using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafío1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ingresosMensuales(10000, 5600, 12450.25, "cristina");
            Console.ReadKey();
        }
        static void ingresosMensuales(double mesUno, double mesDos, double MesTres, string NombreUsuario)
        {
            double suma = mesUno + mesDos + MesTres;
            double promedio = suma / 3;
            Console.WriteLine("Hola{0}, en total ganaste {1} y promediaste {2} ", NombreUsuario, suma, promedio);
        }
    }
}
