using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp5___1
{
    class Program
    {
        static void Main(string[] args)
        {
            string comida, refugio, bate;

            Console.WriteLine("Ingrese si tiene comida (si o no): ");
            comida = Console.ReadLine();
            Console.WriteLine("Ingrese si tiene refugio (si o no): ");
            refugio = Console.ReadLine();
            Console.WriteLine("Ingrese si tiene bate (si o no): ");
            bate = Console.ReadLine();

            if(comida == "si" && refugio == "si" && bate == "si")
            {
                Console.WriteLine("Sobrevivis");
            }
            else
            {
                Console.WriteLine("Moris");
            }

            Console.ReadKey();
        }
    }
}
