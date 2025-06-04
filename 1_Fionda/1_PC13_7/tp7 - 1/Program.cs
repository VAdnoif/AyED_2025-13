using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp7___1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            for(int i = 0; i < 10 ; i++)
            {
                console.Writeline(palabra);
            }
            */

            string p;

            Console.WriteLine("Ingresa la palabra");
            p = Console.ReadLine();

            for(int i = 0; i < 9 ; i++)
            {
                Console.WriteLine(p);
            }

            Console.ReadKey();
        }
    }
}
