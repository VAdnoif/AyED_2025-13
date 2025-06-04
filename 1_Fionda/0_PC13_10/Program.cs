using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp10___Etapa_0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int radio, superficie;
            float pi = 3.14f;

            Console.WriteLine("Escriba el valor del radio: ");
            radio = int.Parse(Console.ReadLine());

            superficie = 4 * pi * Math.Pow(radio, 2);

            Console.WriteLine("La superficie de la esfera es: " + superficie);

        }
    }
}
