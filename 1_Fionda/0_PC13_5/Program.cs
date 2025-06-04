using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp5___etapa_0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;

            Console.WriteLine("Escriba el primer valor a sumar: ");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Escriba el segundo valor a sumar: ");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("La suma de esos numeros es: " + (num1 + num2));

            Console.ReadKey();
        }
    }
}
