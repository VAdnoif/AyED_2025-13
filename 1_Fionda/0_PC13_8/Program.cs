using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp8___Etapa_0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1, num2;

            Console.WriteLine("Escriba el primer valor a division: ");
            num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Escriba el segundo valor a division: ");
            num2 = double.Parse(Console.ReadLine());

            Console.WriteLine("El resultado de la resta es: " + (num1 / num2));
        }
    }
}
