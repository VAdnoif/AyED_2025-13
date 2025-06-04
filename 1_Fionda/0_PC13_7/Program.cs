using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp7___Etapa_0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;

            Console.WriteLine("Escriba el primer valor a multiplicar: ");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Escriba el segundo valor a multiplicar: ");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("El resultado de la resta es: " + (num1 * num2));

        }
    }
}
