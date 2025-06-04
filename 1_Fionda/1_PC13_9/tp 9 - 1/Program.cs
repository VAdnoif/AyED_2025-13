using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp_9___1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroc, i;

            Console.WriteLine("Ingrese un numero entero para hacer su cuenta regresiva");
            numeroc = int.Parse(Console.ReadLine());

            Console.WriteLine();

            for(i = numeroc; i >= 0; i--)
            {
                Console.WriteLine(i);
            }
            

            Console.ReadKey();
        }
    }
}
