using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_PC13_1
{
    internal class Program
    {
        static int Sumar(int valor1, int valor2)
        {
            return valor1 + valor2;
        }

        static void Main()
        {
            Console.Write("Ingrese el primer valor: ");
            int valor1 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el segundo valor: ");
            int valor2 = int.Parse(Console.ReadLine());

            int resultado = Sumar(valor1, valor2);

            Console.WriteLine("El resultado es: " + resultado);
        }
    }
}
