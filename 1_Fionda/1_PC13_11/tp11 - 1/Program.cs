using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp11___1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;

            Console.WriteLine("Ingrese el numero hasta q va a llegar el contador: ");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine();

            for(int i = 1; i <= n; i++)
            {
                if(i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            Console.ReadKey();
        }
    }
}
