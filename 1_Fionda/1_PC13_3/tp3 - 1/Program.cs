using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp3___1
{
    class Program
    {
        static void Main(string[] args)
        {

            int n1;

            Console.WriteLine("Ingrese un valor entero: ");
            n1 = int.Parse(Console.ReadLine());

            if (n1 % 2 == 0)
            {
                Console.WriteLine("El numero es par");
            }
            else if (n1 == 0)
            {
                Console.WriteLine("El numero es 0");
            }
            else
            {
                Console.WriteLine("El numero es impar");
            }

                Console.ReadKey();
        }
    }
}
