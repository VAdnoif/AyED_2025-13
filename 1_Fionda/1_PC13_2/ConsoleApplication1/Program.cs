using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            double n1, n2;

            Console.WriteLine("Ingrese el primer valor a dividir: ");
            n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo valor a dividir: ");
            n2 = double.Parse(Console.ReadLine());

            if (n2 == 0)
            {
                Console.WriteLine("Error el divisor es cero");
            }

            Console.ReadKey();
        }
    }
}
