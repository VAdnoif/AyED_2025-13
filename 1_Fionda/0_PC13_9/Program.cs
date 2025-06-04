using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp9___Etapa_0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;

            Console.WriteLine("Escriba el primer valor a obtener el resto: ");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Escriba el segundo valor a obtener el resto: ");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("El resultado del resto es: " + (num1 % num2));
        }
    }
}
