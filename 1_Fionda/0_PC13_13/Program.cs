using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp13___Etapa_0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string letra1, letra2, letra3;

            Console.Write("Ingrese la primera letra: ");
            letra1 = Console.ReadLine();

            Console.Write("Ingrese la segunda letra: ");
            letra2 = Console.ReadLine();

            Console.Write("Ingrese la tercera letra: ");
            letra3 = Console.ReadLine();

            string resultado = letra3 + letra2 + letra1;
            Console.WriteLine("Letras al revés: " + resultado);

            Console.ReadKey();
        }
    }
}
