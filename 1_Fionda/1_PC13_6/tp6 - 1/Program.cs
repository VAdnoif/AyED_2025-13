using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp6___1
{
    class Program
    {
        static void Main(string[] args)
        {

            int v1;

            Console.WriteLine("Ingrese los grados: ");
            v1 = int.Parse(Console.ReadLine());

            if (v1 <= 0)
            {
                Console.WriteLine("Se congela ");
            }
            else if (v1 >= 100)
                {
                Console.WriteLine("hierve el agua");
            }
            else
            {
                Console.WriteLine("El agua esta liquida");
            }
            Console.ReadKey();
        }
    }
}
