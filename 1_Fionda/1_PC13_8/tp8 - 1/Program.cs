using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp8___1
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad;

            Console.WriteLine("Ingrese su edad: ");
            edad = int.Parse(Console.ReadLine());

            Console.WriteLine();

            for (int edad1 = 1; edad1 <= edad; edad1++)
            {
                Console.WriteLine(edad1);
            }

            Console.ReadKey();
        }
    }
}
