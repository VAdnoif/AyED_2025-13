using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int edad;
            string nombre;

            Console.WriteLine("Escriba su nombre: ");
            nombre = Console.ReadLine();

            Console.WriteLine("Escriba su edad: ");
            edad = int.Parse(Console.ReadLine());

            Console.WriteLine("Hola {0}, tu edad es {1}", nombre, edad);
        }
    }
}
