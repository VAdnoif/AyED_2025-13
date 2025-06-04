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
            string Si;

            Console.WriteLine("Diga SI para terminar el programa: ");

            do
            {
                Console.WriteLine("Desea terminar el programa? ");
                Si = Console.ReadLine();
            }
            while (Si != "SI");

            Console.WriteLine("Hasta la vista! ");

            Console.ReadKey();
        }
    }
}
